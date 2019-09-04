using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConnectDevice;
using Microsoft.VisualBasic;
using System.Windows.Forms.DataVisualization.Charting;

using Mathematica;
using System.IO;

using ReadWriteFile;
//using System.Threading.Tasks;

namespace MainForm
{
    public partial class MainForm : Form
    {
        IConnect cnct;

        myMath math_obj;
        DateTime time_first, time_last;
        List<int> time_list;//перенести в math
        Setting setting;
        ReadWriteFileClass rw;
        bool read_from_file;
       

        public MainForm()
        {
            InitializeComponent();
            //cnct = new Connect();
            setting = new Setting(); //окно настроек
            setting.SKO_visible_change+=setting_SKO_visible_change;
            setting.Allan_visible_change+=setting_Allan_visible_change;
            setting.SKSV_visible_change += setting_SKSV_visible_change;
            setting.AllanOver_visible_change += setting_AllanOver_visible_change;
            math_obj = new myMath();
            time_list = new List<int> { 2, 4, 8, 16 };
            rw = new ReadWriteFileClass();

            read_from_file = false;
            backgroundproccess.DoWork += Backgroundproccess_DoWork;//событие запускающее фоновый процесс
            backgroundproccess.ProgressChanged += Backgroundproccess_ProgressChanged;//событие возвращения результата из фонового процесса
            setting.Time_List_Change+=setting_Time_List_Change;
        }

        private void setting_Time_List_Change(string tl)
        {
            SKO.Rows.Clear();
            AllanTable.Rows.Clear();
            SKSV.Rows.Clear();
            AllanOver.Rows.Clear();
            chartSKO.Series[0].Points.Clear();
            chartAllan.Series[0].Points.Clear();
            chartSKSV.Series[0].Points.Clear();
            chartOverAllan.Series[0].Points.Clear();
            math_obj.reset();
            DrawResultFromTime(chartSKO, "sko(T)", new List<double>() { 1 }, new List<int>() { 1 });// Построение графика CKO 
            DrawResultFromTime(chartAllan, "avar(T)", new List<double>() { 1 }, new List<int>() { 1 });
            DrawResultFromTime(chartSKSV, "sksv(T)", new List<double>() { 1 }, new List<int>() { 1 });
            DrawResultFromTime(chartOverAllan, "sksv(T)", new List<double>() { 1 }, new List<int>() { 1 });
            List<double> td = new List<double>();

            for (int i = 0; i < MainTable.Rows.Count; i++)
            {
                td.Add( Conversion.Val(MainTable[2, i].Value)); 
            }

            math_obj.set_TimeListType(setting.get_TimeListType());
            math_obj.AddMeas_Static(td);
            time_list = math_obj.get_time_list();
            List<double> avar_list_open = math_obj.get_allanvar(time_list);//получаем список значений вариаций Аллана
            List<double> sko_list_open = math_obj.get_sko(time_list);
            WriteResultFromTime(AllanTable, "avar(T)", avar_list_open, time_list);
            if (time_list.Count >= 1)
                DrawResultFromTime(chartAllan, "avar(T)", sko_list_open, time_list);

            WriteResultFromTime(SKO, "sko(T)", sko_list_open, time_list);
            if (time_list.Count >= 1)
                DrawResultFromTime(chartSKO, "sko(T)", sko_list_open, time_list);
            //    return;
        }


        bool Sko_visible = true;
        private void setting_SKO_visible_change(bool b)
        {
            if (b==false) TableSKO.Parent = null;
            if (b == true) TableSKO.Parent = tabControl1;
            math_obj.SKO_visible = b;
            Sko_visible = b;
        }
        bool Allan_visible = true;
        private void setting_Allan_visible_change(bool Allan)
        {
            if (Allan == false) TableAllan.Parent = null;
            if (Allan == true) TableAllan.Parent = tabControl1;
            math_obj.Allan__visible = Allan;
            Allan_visible = Allan;
        }
        bool Sksv_visible = true;
        private void setting_SKSV_visible_change(bool SKSV)
        {
            if (SKSV == false) TableSKSV.Parent = null;
            if (SKSV == true) TableSKSV.Parent = tabControl1;
            math_obj.SKSV_visible = SKSV;
            Sksv_visible = SKSV;
        }
        bool AllanOver_visible = true;
        private void setting_AllanOver_visible_change(bool AllanOver)
        {
            if (AllanOver == false) TableAllanOver.Parent = null;
            if (AllanOver == true) TableAllanOver.Parent = tabControl1;
            math_obj.AllanOver_visible = AllanOver;
            AllanOver_visible = AllanOver;
        }
        private void Backgroundproccess_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            math_obj.AddMeas((double)e.UserState, DateTime.Now.ToString()); // получаем f_new из фонового процесса 
        }

        private void Backgroundproccess_DoWork(object sender, DoWorkEventArgs e) //процедура фонового процесса (обращение к прибору)
        {
            //var cn=(IConnect)e.Argument;
            IConnect cnct =setting.NewConnect();
            //if (cn!=null) cnct.Mode = cn.Mode;
            //if (cn != null) cnct.Address = cn.Address;
            
         
                //(Connect)e.Argument;
            if (cnct.Connection() == "Error") MessageBox.Show("Ошибка подключения к прибору");
               
            for (long i = 0; !backgroundproccess.CancellationPending; i++)
            
                while (true)
                {
                    string str_f = cnct.MeasFreq();
                    if (str_f == "VCH_Error_NotEnoughPhaseData") continue;

                    double f = Conversion.Val(str_f.Replace(",", "."));

                    const int f0 = 5000000;
                    double f_new = 0;
                    string time_string = "";

                    if (cnct.Type == "ConnectVCH308")
                    {
                        time_string = DateTime.Now.ToString();
                        f_new = f;
                        backgroundproccess.ReportProgress((int)i, f_new);//возвращаем частоту
                    }
                    else
                    {
                        //time_last = DateTime.Now;
                        time_string = DateTime.Now.ToString();
                        f_new = (f0 - f) / f0;
                        backgroundproccess.ReportProgress((int)i, f_new);//возвращаем частоту
                    }
                    if (backgroundproccess.CancellationPending)
                    {
                        cnct.CloseSession();
                        break;
                    }
                }
            
        }
      
        private void StartMeas_Click(object sender, EventArgs e)
        {
            ClearTables.Enabled = false; // заблокируем кнопку очищения таблиц во время измерительного цикла
            backgroundproccess.RunWorkerAsync(cnct);// запуск фонового процесса, передаем туда cnct
            math_obj.set_TimeListType(setting.get_TimeListType());// передача в Math типа ряда из окна настроек 
            math_obj.set_CountPointListType(setting.get_CountPoint()); // передача количества точек на графике
            timer1.Start();
        }
        private void OpenSetting_Click(object sender, EventArgs e)
        {
            setting.Owner = this;//чтобы при закрытии основного окна закрывалось и окно настроек
            setting.Show();
        }

        //int i_timer1_Tick = 0;
        private void timer1_Tick(object sender, EventArgs e) 
        {
           

            CountMeas.Text = math_obj.get_n_all_meas().ToString();//счетчик числа измерений
            
            //Цикл считывания данных частоты и вариаций в таблицу является независимым от
            //цикла записи данных и вычислений в Math, где они хранятся

            #region основная таблица
            //MainTable.Rows.Add();
            //MainTable.Rows[MainTable.Rows.Count - 1].Cells[0].Value = time_string;
            //string Resol_F = setting.get_Resol_F();//число точек после запятой равно колву #
            //MainTable.Rows[MainTable.Rows.Count - 1].Cells[1].Value = f_new.ToString("0." + Resol_F + "E+00");
            //if (setting.get_AutoScrolChecked) MainTable.CurrentCell = MainTable.Rows[MainTable.Rows.Count - 1].Cells[1];
            //MainTable.Rows[MainTable.Rows.Count - 1].HeaderCell.Value = math_obj.get_n_all_meas().ToString();//получаем номер текущего измерения и записываем в заголовок строки
           
            //List<int> time_list = math_obj.get_time_list();//получаем временной ряд
            //DrawFreqFromTime(f_new);// Построение графика частоты от времени 
            List<double> freq = new List<double>(math_obj.get_all_freq());
            
            for (int i = MainTable.Rows.Count; i < freq.Count; i++)//добавляем в таблицу новые данные если freq.count>maintable.rows.count т.е. если есть новые данные
            {
                WriteFreqFromTime(freq[i]);
                DrawFreqFromTime(freq[i]);
            }
            #endregion

            #region AutoSave
            if (math_obj.get_n_all_meas() == 1)
                time_first = time_last;

            double dt_minute = time_last.Minute - time_first.Minute,
                   dt_second = time_last.Second - time_first.Second;
            if (dt_minute < 0)
              dt_minute += 60;

            if ((-1 <= dt_second) && (dt_second <= 1) && (dt_minute != 0) && (dt_minute % 10 == 0))
            {
                List<string> date = new List<string>(MainTable.Rows.Count);
                for (int i = 0; i < MainTable.Rows.Count; ++i)
                    date.Insert(i, Convert.ToString(MainTable.Rows[i].Cells[0].Value));
                rw.PrintMeasToFileAuto(date, math_obj.get_all_freq());
            }
            #endregion

            #region СКО
            if (Sko_visible == true)
            {
                List<double> sko_list = math_obj.get_sko();//получаем список значений ско
                time_list = math_obj.get_time_list();
                WriteResultFromTime(SKO, "sko(T)", sko_list, time_list);
                if (time_list.Count >= 1) DrawResultFromTime(chartSKO, "sko(T)", sko_list, time_list);// Построение графика CKO 
            }
            #endregion
            #region Вариация Аллана
            if (Allan_visible == true)
            {
                List<double> avar_list = math_obj.get_allan_var();//получаем список значений вариаций Аллана
                //time_list = math_obj.get_time_list();
                WriteResultFromTime(AllanTable, "avar(T)", avar_list, time_list);
                if (time_list.Count >= 1)
                    DrawResultFromTime(chartAllan, "avar(T)", avar_list, time_list);
            }
            #endregion
            #region СКСВ
            if (Sksv_visible == true)
            {
                List<double> sksv_list = math_obj.get_sksv();//получаем список значений сксв
                WriteResultFromTime(SKSV, "avar(T)", sksv_list, time_list);
                if (time_list.Count >= 1) DrawResultFromTime(chartSKSV, "sksv(T)", sksv_list, time_list);
            }
            #endregion
            #region Вариация Аллана с перекрытиями
           
            List<double> allan_over_list = math_obj.get_allan_over();//получаем список значений сксв
            WriteResultFromTime(AllanOver, "avarO(T)", allan_over_list, time_list);        
            if (time_list.Count >= 1) DrawResultFromTime(chartOverAllan, "avarO(T)", allan_over_list, time_list);
            #endregion

            #region Мусор
            //MainTable.Refresh();
            // AllanTable.Rows.Add();
            // AllanTable.Rows[0].Cells[1].Value = math_obj.AVAR(freq);
            // AllanTable.Rows[1].Cells[1].Value = math_obj.AVAR(math_obj.Aver(freq, 10));
            //for (int i = 0; i <  time_list.Count; i++)
            //{
            //    AllanTable.Rows.Insert(i,  time_list.Count[i]);
            //    AllanTable.Rows[i].Cells[1].Value = math_obj.AVAR;
            //}


            //SKO.Rows[0].Cells[1].Value = math_obj.SKO(freq);
            //for (int i = 0; i < time_list.Count; i++)
            //{
            //    SKSV.Rows[i].Cells[1].Value = math_obj.SKSV(math_obj.Aver(freq, time_list[i]));
            //}
            //SKSV.Rows[SKSV.Rows.Count - 2].Cells[0].Value = current_time.ToLongTimeString();
            // SKSV.Rows[SKSV.Rows.Count - 2].Cells[1].Value = math_obj.SKSV();

            //           MainTable.Rows.Add();
            //           MainTable.Rows[MainTable.Rows.Count - 2].Cells[0].Value = math_obj.get_last_time();
            //           MainTable.Rows[MainTable.Rows.Count - 2].Cells[1].Value = math_obj.get_last_freq();


            //math_obj.get_all_freq(freq);
            // math_obj.get_all_time(t);



            // Отрисовка графика зависимости вариации Аллана от времени
            //List<double> avar = new List<double>(math_obj.Nmax - 1);
            // math_obj.get_allan_var(avar);
            // DrawResultFromTime(this.chart2, "avar(T)", avar, t);

            // // Отрисовка графика зависимости СКО от времени
            // List<double> sko = new List<double>(math_obj.Nmax - 1);
            // math_obj.get_sko(sko);
            //// math_obj.SKO(math_obj.Aver(freq, 10));


            // // Отрисовка графика зависимости СКСВ от времени
            // List<double> sksv = new List<double>(math_obj.Nmax - 1);
            // math_obj.get_sksv(sksv);

            //DrawResultFromTime(this.chart4, "sksv(T)", sksv, t);

            // int No = math_obj.get_n_all_meas();

            // rw.PrintMeasToFile(No, current_time, f_new);

            //cnct.MeasFreq(); 
            #endregion
        }
         
        // Построение графика частоты от времени
        public void DrawFreqFromTime(double f)
        {
            string get_CountPoint = setting.get_CountPoint();
            List<int> countpoint_list = math_obj.get_countpoint_list();
            MainChart.Series[0].Points.AddXY(DateTime.Now.ToString("d/MMM HH:mm"),f);
            for (int i = 0; i < MainChart.Series[0].Points.Count; i++)
            {
                if (MainChart.Series[0].Points.Count > Conversion.Val(setting.get_CountPoint()))
                {
                    MainChart.Series[0].Points.RemoveAt(0);
                } 
            } 
            //if (MainChart.Series[0].Points.Count > countpoint_list)
            //{
            //    MainChart.Series[0].Points.RemoveAt(0);
            //}
            
        }
        public void WriteFreqFromTime(double f)
        {
            string Resol_F = setting.get_Resol_F();//число точек после запятой равно колву #
            MainTable.Rows.Add();
            MainTable.Rows[MainTable.Rows.Count - 1].Cells[0].Value = (int)math_obj.get_n_all_meas();
            MainTable.Rows[MainTable.Rows.Count - 1].Cells[1].Value = DateTime.Now.ToString();
            MainTable.Rows[MainTable.Rows.Count - 1].Cells[2].Value = f.ToString("0." + Resol_F + "E+00");
            MainTable.Rows[MainTable.Rows.Count - 1].HeaderCell.Value = CountMeas.Text = math_obj.get_n_all_meas().ToString();//получаем номер текущего измерения и записываем в заголовок строки
            if (setting.get_AutoScrolChecked) MainTable.CurrentCell = MainTable.Rows[MainTable.Rows.Count - 1].Cells[0];
        }
     
        private void DrawResultFromTime(Chart chart, string result_str, List<double> result, List<int> t)
      {

            chart.Series[0].Points.Clear();//очищение графика
           
           
            for (int i = 0; i < result.Count; i++)//заполнение графика
            {
                chart.Series[0].Points.AddXY(t[i], result[i]);
            }
         
          

            #region Mysor
            //if (result.Count >= 2)
            //{
            //    chart.ChartAreas[0].AxisY.Crossing = (max+min)/2;
            //    ////chart.ChartAreas[0].AxisY.Minimum = 0.9 * min;
            //}
            //const double Max_time = 11;

            //chart.Series.Clear();

            //////            this.chart1.Titles.Add("Total Income");

            //Series series = chart.Series.Add(result_str);
            //series.ChartType = SeriesChartType.Spline;

            //int i_first = 0,
            //    i_last = result.Count - 1;

            //  double t_last = t[i_last];
            // for (int i = i_last - 1; i > 0; --i)
            //{
            //     if (t_last - t[i] > Max_time)
            //    {
            //        i_first = i + 1;
            //         break;
            //    }
            // }

            //for (int i = i_first; i <= i_last; ++i)
            //{
            //   for (int j = 0; j <= 2; j++)
            //  { 
            //for (int i = 0; i < time_list.Count; i++)
            //{
            //    chartALLAN.Series[0].Points[i].YValues = new double[] { 1000000 * Conversion.Val(AllanTable.Rows[i].Cells[1].Value) };
            //    chartSKO.Series[0].Points[i].YValues = new double[] { 1000000 * Conversion.Val(SKO.Rows[i].Cells[1].Value) };
            //    chartSKSV.Series[0].Points[i].YValues = new double[] { 1000000 * Conversion.Val(SKSV.Rows[i].Cells[1].Value) };


            //}

            //chart3.Series[0].Points[0].YValues = new double[] { 1000000*Conversion.Val(SKO.Rows[0].Cells[1].Value )};
            //chart3.Series[0].Points[1].YValues = new double[] { 1000000*Conversion.Val(SKO.Rows[1].Cells[1].Value) };
            //chart3.Series[0].Points[0].YValues = new double[] { 1000000 * Conversion.Val(SKO.Rows[2].Cells[1].Value) };
            //chart3.Series[0].Points[1].YValues = new double[] { 1000000 * Conversion.Val(SKO.Rows[1].Cells[1].Value) };
            //series.Points.DataBindXY(t, result);
            // }
            //series.Points[i];
            //series.Points.
            //} 
            #endregion
        }
        private void WriteResultFromTime(DataGridView Table, string result_str, List<double> result, List<int> t)
        {
            //int scroll_position = 0;
            //int curentrow= 0;
            //int curentcolumn = 0;
            //if (Table.CurrentCell == null)
            //{
            //}
            //else
            //{
            //    scroll_position = Table.FirstDisplayedScrollingRowIndex;
            //    curentrow = Table.CurrentCell.RowIndex;
            //    curentcolumn = Table.CurrentCell.ColumnIndex;
            //}
            //не будем очищать каждый раз чтобы не моргало, и тогда не нужна вся эта хрень с запоминанием позиции текущей ячейки и ползунка
            // также можно с графиком сделать
            //Table.Rows.Clear();//очищение таблицы (таблица каждый раз очищается и заполняется заново)
            string Resol = "";//число точек после запятой для таблицы ско из окна настроек
            switch (result_str) 
            {
                case "sko(T)":
                    Resol = setting.get_Resol_SKO();
                    break;
                case "avar(T)":
                    Resol = setting.get_Resol_AVAR();
                    break;
                case "sksv(T)":
                    Resol= setting.get_Resol_SKSV();
                    break;
                case "avarO(T)":
                    Resol = setting.get_Resol_SKSV();
                    break;

            }

            if((result.Count - Table.Rows.Count)>0) Table.Rows.Add(result.Count-Table.Rows.Count); // вычисляем сколько строк надо добавить
            for (int i = 0; i < result.Count; i++)//заполнение таблицы
            {
                Table.Rows[i].Cells[0].Value = time_list[i];
                Table.Rows[i].Cells[1].Value = result[i].ToString("0." + Resol + "E+00"); ;
                Table.Rows[i].Cells[2].Value = (int)math_obj.get_n_all_meas() / time_list[i];
            }
            //if (Table.CurrentCell != null)
            //{
            //    Table.CurrentCell = Table[curentcolumn, curentrow];
            //    Table.FirstDisplayedScrollingRowIndex = scroll_position;
            //}

        }

        private void StopMeas_Click(object sender, EventArgs e)
        {
            timer1.Stop();//остановка таймера опроса
            backgroundproccess.CancelAsync();// остановка фонового процесса считывания данных с прибора
            ClearTables.Enabled = true;// разблокировка кнопки очищения таблиц

        }

      

        private void создатьToolStripButton_Click(object sender, EventArgs e)
        {

        }

       

        private void MainForm_Load(object sender, EventArgs e) 
        {
            math_obj.set_TimeListType(setting.get_TimeListType());// передача в Math типа ряда из окна настроек 
            math_obj.set_CountPointListType(setting.get_CountPoint()); // передача количества точек на графике
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            if (MainTable.Rows.Count == 0)
            {
              MessageBox.Show("Нет измерений!");
              return;
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.FileName = (Convert.ToString(MainTable.Rows[MainTable.Rows.Count - 1].Cells[0].Value)).Replace(':', '_') + ".txt";
            saveFileDialog1.OverwritePrompt = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
              return;

            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            rw.SetFilenameWrite(filename);

            // получаем измерения
            List<double> freq = math_obj.get_all_freq();
            List<double> allanvar = math_obj.get_allan_var();
            List<double> sko = math_obj.get_sko();
            List<double> sksv = math_obj.get_sksv();
            List<string> t = math_obj.get_all_time();
            // сохраняем измерения в файл
            //int n_all_meas = math_obj.get_n_all_meas();
            int n_all_meas = MainTable.Rows.Count;
            for (int i_meas = 0; i_meas < n_all_meas; ++i_meas)
                rw.PrintMeasToFile(i_meas + 1, t[i_meas], freq[i_meas]);
            for (int i_meas = 0; i_meas < AllanTable.Rows.Count; ++i_meas)
                rw.PrintAllanToFile(i_meas + 1, Convert.ToString(AllanTable.Rows[i_meas].Cells[0].Value), allanvar[i_meas], Convert.ToString(AllanTable.Rows[i_meas].Cells[2].Value));
            for (int i_meas = 0; i_meas < SKO.Rows.Count; ++i_meas)
                rw.PrintSKOToFile(i_meas + 1, Convert.ToString(SKO.Rows[i_meas].Cells[0].Value), sko[i_meas], Convert.ToString(SKO.Rows[i_meas].Cells[2].Value));
            for (int i_meas = 0; i_meas < SKSV.Rows.Count; ++i_meas)
                rw.PrintSKSVToFile(i_meas + 1, Convert.ToString(SKSV.Rows[i_meas].Cells[0].Value), sksv[i_meas], Convert.ToString(SKSV.Rows[i_meas].Cells[2].Value));

            MessageBox.Show("Измерения сохранены в файл");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainTable.Rows.Clear();
            SKO.Rows.Clear();
            AllanTable.Rows.Clear();
            SKSV.Rows.Clear();
            AllanOver.Rows.Clear();

            MainChart.Series[0].Points.Clear();
            chartSKO.Series[0].Points.Clear();
            chartAllan.Series[0].Points.Clear();
            chartSKSV.Series[0].Points.Clear();
            chartOverAllan.Series[0].Points.Clear();
            math_obj.reset();
            DrawResultFromTime(chartSKO, "sko(T)", new List<double>() { 1 }, new List<int>() { 1 });// Построение графика CKO 
            DrawResultFromTime(chartAllan, "avar(T)", new List<double>() { 1 }, new List<int>() { 1 });
            DrawResultFromTime(chartSKSV, "sksv(T)", new List<double>() { 1 }, new List<int>() { 1 });
            DrawResultFromTime(chartOverAllan, "sksv(T)", new List<double>() { 1 }, new List<int>() { 1 });
        }

        private void открытьToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.DefaultExt = ".txt";
            openFileDialog1.AddExtension = true;
            openFileDialog1.FileName = "data.txt";
            StartMeas.Enabled = false;//заблокируем кнопку запуска измерений во время чтения из файла
            StopMeas.Enabled = false;//заблокируем кнопку остановки измерений во время чтения из файла
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            rw.SetFilenameRead(filename);
            int i = 0;
            List<double> td= new List<double>();
            string[] args = new string[3];
            string Resol_F = setting.get_Resol_F();
            while(rw.ReadMeasFromFile(i, args) == 0)
            {
                MainTable.Rows.Add();
                MainTable[0, i].Value = args[0];
                MainTable[1, i].Value = args[1];
                MainTable[2, i].Value = args[2];
                DateTime t = DateTime.Parse(args[1]);
                td.Add(Convert.ToDouble(args[2]));
                MainChart.Series[0].Points.AddXY(t.ToString("d/MMM HH:mm"), td[i]);
                //math_obj.AddMeas(td);

                i++;
            }
            math_obj.set_TimeListType(setting.get_TimeListType());
            math_obj.AddMeas_Static(td);
            time_list = math_obj.get_time_list();
            List<double> avar_list_open = math_obj.get_allanvar(time_list);//получаем список значений вариаций Аллана
            List<double> sko_list_open = math_obj.get_sko(time_list);
            WriteResultFromTime(AllanTable, "avar(T)", avar_list_open, time_list);
            if (time_list.Count >= 1)
                DrawResultFromTime(chartAllan, "avar(T)", sko_list_open, time_list);

            WriteResultFromTime(SKO, "sko(T)", sko_list_open, time_list);
            if (time_list.Count >= 1)
                DrawResultFromTime(chartSKO, "sko(T)", sko_list_open, time_list);
            //    return;
            //time_string = args[0];
            //f_new = Convert.ToDouble(args[1]);
        }
      

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            read_from_file = !read_from_file;
        }

        private void очиститьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTable.Rows.Clear();
            SKO.Rows.Clear();
            AllanTable.Rows.Clear();
            SKSV.Rows.Clear();
            AllanOver.Rows.Clear();

            MainChart.Series[0].Points.Clear();
            chartSKO.Series[0].Points.Clear();
            chartAllan.Series[0].Points.Clear();
            chartSKSV.Series[0].Points.Clear();
            chartOverAllan.Series[0].Points.Clear();
            math_obj.reset();
            DrawResultFromTime(chartSKO, "sko(T)", new List<double>() { 1 }, new List<int>() { 1 });// Построение графика CKO 
            DrawResultFromTime(chartAllan, "avar(T)", new List<double>() { 1 }, new List<int>() { 1 });
            DrawResultFromTime(chartSKSV, "sksv(T)", new List<double>() { 1 }, new List<int>() { 1 });
            DrawResultFromTime(chartOverAllan, "sksv(T)", new List<double>() { 1 }, new List<int>() { 1 });
        }
    } 
}
