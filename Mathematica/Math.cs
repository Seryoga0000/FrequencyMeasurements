using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Math;

namespace Mathematica
{
    public class myMath
    {
        //public int Nmax = 100000; // максимально хранимое количество измерений

        private int n_meas;        // текущее количество измерений
        private int n_all_meas;    // общее количество измерений
        private List<double> freq; // список значений измерений частот
        private List<string> t;    // список значений времён, в которые получены измерения частот
        private List<double> allan_var; // список значений вариаций Аллана
        private List<double> sko_; // SKO
        private List<double> sksv_; // SkSV
        private List<double> allanOver_var;
        private string TimeListType= "";
        private string CountPointListType = "10";
        private List<int> time_list;
        private List<int> countpoint_list;
        Task<List<double>> Avar = null;//с помощью тасков осуществляется асинхронность вычислений
        Task<List<double>> Sko = null;
        Task<List<double>> Sksv = null;
        Task<List<double>> AvarO = null;
        // Конструктор
        public myMath()
        {
          n_meas = 0;
          n_all_meas = 0;
          freq      = new List<double>();
          t         = new List<string>();
          allan_var = new List<double>();
          sko_      = new List<double>();
          sksv_     = new List<double>();
          allanOver_var = new List<double>();
          time_list = new List<int>();
          countpoint_list = new List<int>();
        }

        

        public void reset()
        {
          n_meas = 0;
          n_all_meas = 0;
          freq.Clear();
          t.Clear();
          allan_var.Clear();
          sko_.Clear();
          sksv_.Clear();
          allanOver_var.Clear();
          time_list.Clear();
        }
        
        public void GenerateTimeList()//функция генерирующая список значений Ти на основе выбранного пользователем ряда и текущего количества измерений
        {
            if(TimeListType == "1,10,100...")
            {

                for (int i = time_list.Count; n_meas / Math.Pow(10, i) >= 3; i++)
                {
                    time_list.Add((int)Math.Pow(10, i));
                }

            }
            if (TimeListType == "1,2,4,8,16...")
            {

                //time_list.Add(1);
                for (int i = time_list.Count; n_meas / Math.Pow(2, i) >= 3; i++)
                {
                    time_list.Add((int)Math.Pow(2, i));
                }

            }
            if (TimeListType == "1,2,5,10,20,50,100...")
            {
                for (int i = time_list.Count(x => x.ToString().StartsWith("1")); n_meas >= 3 * Math.Pow(10, i); i++ )
                {
                    time_list.Add(1* (int)Math.Pow(10, i));
                }
                for (int i = time_list.Count(x => x.ToString().StartsWith("2")); n_meas >= 6 * Math.Pow(10, i); i++)
                {
                    time_list.Add(2 * (int)Math.Pow(10, i));
                }
                for (int i = time_list.Count(x => x.ToString().StartsWith("5")); n_meas >= 15 * Math.Pow(10, i); i++)
                {
                    time_list.Add(5 * (int)Math.Pow(10, i));
                }

            }
            if (TimeListType == "1,2,3,4,5,6,7,8...")
            {
                for (int i = time_list.Count; n_meas >= 3 * (i + 1); i++)
                {
                    time_list.Add(i + 1);
                }
            }
        }

        public void GenerateCountPointList() {
            if (CountPointListType == "10")
            {
                countpoint_list.Add(10);
            }
            if (CountPointListType == "100")
            {
                countpoint_list.Add(100);
            }
            if (CountPointListType == "1000")
            {
                 countpoint_list.Add(1000);
            }
            if (CountPointListType == "10000")
            {
                countpoint_list.Add(10000);
            }
        }

        // Добавление нового измерения
        // Входные параметры:
        //   f_meas - значений нового измерения частоты;
        //   t_meas - время, в которое получено это измерение.


        // теперь после добавления нового значения частоты запускаются процедуры
        //вычисления вариаций в асинхронном режиме(для этого используется ТASK)
        //после вычисления значения вариаций записываются в соответствующие поля
        // получение их в основное окно планируется делать отдельным циклом
        bool Sko_visible = true;
        public bool SKO_visible
        {
            get { return Sko_visible; }
            set { Sko_visible = value; }
        }
        bool Allan_visible = true;
        public bool Allan__visible
        {
            get { return Allan_visible; }
            set { Allan_visible = value; }
        }
        bool Sksv_visible = true;
        public bool SKSV_visible
        {
            get { return Sksv_visible; }
            set { Sksv_visible = value; }
        }
        bool Allanover_visible = true;
        public bool AllanOver_visible
        {
            get { return Allanover_visible; }
            set { Allanover_visible = value; }
        }
        public void AddMeas(double f_meas)
        {
            freq.Insert(n_meas, f_meas);
            //t.Insert(n_meas, t_meas);
            n_all_meas++;
            n_meas++;
            //n_meas = n_meas % Nmax;
            GenerateTimeList();
            GenerateCountPointList();
           // запуск асинхронных задач
            if (Allan_visible)if (Avar == null || Avar.IsCompleted) { Avar = Task.Factory.StartNew(() => set_allan_var(freq, time_list)); Avar.ContinueWith(ReturnAvar, TaskScheduler.FromCurrentSynchronizationContext()); };
            if (Sko_visible) if (Sko == null || Sko.IsCompleted) { Sko = Task.Factory.StartNew(() => set_sko(freq, time_list)); Sko.ContinueWith(ReturnSko, TaskScheduler.FromCurrentSynchronizationContext()); }
            if (Sksv_visible) if( Sksv == null || Sksv.IsCompleted) { Sksv = Task.Factory.StartNew(() => set_sksv(freq, time_list)); Sksv.ContinueWith(ReturnSksv, TaskScheduler.FromCurrentSynchronizationContext()); }
            if (Allanover_visible) if (AvarO == null || AvarO.IsCompleted) { AvarO = Task.Factory.StartNew(() => set_allanOver_var(freq, time_list)); AvarO.ContinueWith(RetuntAvarO, TaskScheduler.FromCurrentSynchronizationContext()); }
        }
        public void AddMeas(double f_meas, string t_meas)
        {
            freq.Insert(n_meas, f_meas);
            t.Insert(n_meas, t_meas);
            n_all_meas++;
            n_meas++;
            //n_meas = n_meas % Nmax;
            GenerateTimeList();
            GenerateCountPointList();
            // запуск асинхронных задач
            if (Allan_visible) if (Avar == null || Avar.IsCompleted) { Avar = Task.Factory.StartNew(() => set_allan_var(freq, time_list)); Avar.ContinueWith(ReturnAvar, TaskScheduler.FromCurrentSynchronizationContext()); };
            if (Sko_visible) if (Sko == null || Sko.IsCompleted) { Sko = Task.Factory.StartNew(() => set_sko(freq, time_list)); Sko.ContinueWith(ReturnSko, TaskScheduler.FromCurrentSynchronizationContext()); }
            if (Sksv_visible) if (Sksv == null || Sksv.IsCompleted) { Sksv = Task.Factory.StartNew(() => set_sksv(freq, time_list)); Sksv.ContinueWith(ReturnSksv, TaskScheduler.FromCurrentSynchronizationContext()); }
            if (Allanover_visible) if (AvarO == null || AvarO.IsCompleted) { AvarO = Task.Factory.StartNew(() => set_allanOver_var(freq, time_list)); AvarO.ContinueWith(RetuntAvarO, TaskScheduler.FromCurrentSynchronizationContext()); }
        }
        public void AddMeas(List<double> f_meas)
        {
            freq = f_meas;
            n_all_meas = f_meas.Count;
            n_meas = f_meas.Count;
            GenerateTimeList();
            GenerateCountPointList();
            // запуск асинхронных задач
            if (Avar == null || Avar.IsCompleted) { Avar = Task.Factory.StartNew(() => set_allan_var(freq, time_list)); Avar.ContinueWith(ReturnAvar, TaskScheduler.FromCurrentSynchronizationContext()); }
            if (Sko == null || Sko.IsCompleted) { Sko = Task.Factory.StartNew(() => set_sko(freq, time_list)); Sko.ContinueWith(ReturnSko, TaskScheduler.FromCurrentSynchronizationContext()); }
            if (Sksv == null || Sksv.IsCompleted) { Sksv = Task.Factory.StartNew(() => set_sksv(freq, time_list)); Sksv.ContinueWith(ReturnSksv, TaskScheduler.FromCurrentSynchronizationContext()); }
            if (AvarO == null || AvarO.IsCompleted) { AvarO = Task.Factory.StartNew(() => set_allanOver_var(freq, time_list)); AvarO.ContinueWith(RetuntAvarO, TaskScheduler.FromCurrentSynchronizationContext()); }
        }
        public void AddMeas_Static(List<double> f_meas)
        {
            freq = f_meas;
            n_all_meas = f_meas.Count;
            n_meas = f_meas.Count;
            GenerateTimeList();
            GenerateCountPointList();
            get_time_list(); 
            get_allanvar(time_list);
            get_sko(time_list);
        }
        #region Gets и Sets
       
        #region получение и установка вида временного ряда и еще какойто CountPointList
        //получение временного ряда
        public List<int> get_time_list()
        {
            return time_list;
        }
        public void set_TimeListType(string TLT) //установка вида ряда 
        {
            TimeListType = TLT;
        }
        public List<int> get_countpoint_list()
        {
            return countpoint_list;
        }
        public void set_CountPointListType(string CPLT) //установка вида ряда 
        {
            CountPointListType = CPLT;
        }
        // Получение последнего записанного измерения частоты 
        #endregion

        #region Получение последнего записанного измерения частоты, времени и номера измерения
        public double get_last_freq()
        {
            return freq[n_meas - 1];
        }

        // Получение времени последнего записанного измерения времени
        public string get_last_time()
        {
            return t[n_meas - 1];
        }

        public int get_n_all_meas()
        {
            return n_all_meas;
        }
        #endregion

        #region Получение всех записанных измерений частоты и времени
        // Получение всех записанных измерений частоты
        // Входные параметры:
        //   freq_ - список, в который будут записаны все имеющиеся измерения частоты
        public void get_all_freq(List<double> freq_)
        {
            for (int i = 0; i < freq.Count; ++i)
                freq_.Insert(i, freq[i]);
        }
        public List<double> get_all_freq()
        {
            return freq;
        }
        // Получение времён всех записанных измерений частоты
        // Входные параметры:
        //   t_ - список, в который будут записаны времена всех имеющихся измерений частоты
        // пока не используется
        public void get_all_time(List<string> t_)
        {
            for (int i = 0; i < t.Count; ++i)
                t_.Insert(i, t[i]);
        }
        public List<string> get_all_time()
        {
            return t;
        }
        #endregion

        #region  Получение и установка allan_var
        //public void get_allan_var(List<double> allan_var_)
        //{
        //    for (int i = 0; i < allan_var.Count; ++i)
        //        allan_var_.Insert(i, allan_var[i]);
        //}

        public List<double> get_allanvar(List<int> time_list)
        {
            List<double> AvarList = new List<double>();
            time_list = new List<int>(time_list);
            for (int i = 0; i < time_list.Count; ++i)
            {
                AvarList.Add(AVAR(Aver(freq, time_list[i])));
            }
            return AvarList;
        }
        public void get_allan_var(List<double> allan_var_)
        {
            allan_var_ = allan_var;
        }
        public List<double> get_allan_var()
        {
            return allan_var;
        }
        private List<double> set_allan_var(List<double> freq, List<int> time_list)
        {
            List<double> allan_var = new List<double>();
            time_list = new List<int>(time_list);
            foreach (int t in time_list)
            {
                allan_var.Add(AVAR(Aver(freq, t)));
            }
            return allan_var;
        }
        private void ReturnAvar(Task<List<double>> Avar)
        {
            allan_var.Clear();
            allan_var = Avar.Result;
        }
        #endregion

        #region Получение и установка sko
        //public void get_sko(List<double> sko__)
        //{
        //    for (int i = 0; i < sko_.Count; ++i)
        //        sko__.Insert(i, sko_[i]);
        //}
        public List<double> get_sko(List<int> time_list)
        {
            List<double> SkoList = new List<double>();
            time_list = new List<int>(time_list);
            for (int i = 0; i < time_list.Count; ++i)
            {
                SkoList.Insert(i, SKO(Aver(freq, time_list[i])));
            }
            return SkoList;
            //for (int i = 0; i < sko_.Count; ++i)
            //    sko__.Insert(i, sko_[i]);
        }

        public void get_sko(List<double> sko__)
        {
            sko__ = sko_;
        }
        public List<double> get_sko()
        {
            return sko_;
        }
        private List<double> set_sko(List<double> freq, List<int> time_list)
        {
            
            List<double> sko_ = new List<double>();
            time_list = new List<int>(time_list);
            foreach (int t in time_list)
            {
                sko_.Add(SKO(Aver(freq, t)));
            }
            return sko_;
        }
        private void ReturnSko(Task<List<double>> Sko)
        {
            sko_.Clear();
            sko_ = Sko.Result;
        }
        #endregion

        #region Получение и установка sksv
        //public void get_sksv(List<double> sksv__)
        //{
        //    for (int i = 0; i < sksv_.Count; ++i)
        //        sksv__.Insert(i, sksv_[i]);
        //}
        //public List<double> get_sksv()
        //{
        //    List<double> SksvList = new List<double>();
        //    for (int i = 0; i < time_list.Count; ++i)
        //    {
        //        SksvList.Insert(i, SKSV(Aver(freq, time_list[i])));
        //    }
        //    return SksvList;
        //} 
        public void get_sksv(List<double> sksv__)
        {
            sksv__ = sksv_;
        }
        public List<double> get_sksv()
        {
            return sksv_;
        }
        private List<double> set_sksv(List<double> freq, List<int> time_list)
        {
           
            List<double> sksv_ = new List<double>();
            time_list = new List<int>(time_list);
            foreach (int t in time_list)
            {
                sksv_.Add(SKSV(Aver(freq, t)));
            }
            return sksv_;
        }
        private void ReturnSksv(Task<List<double>> Sksv)
        {
            sksv_.Clear();
            sksv_ = Sksv.Result;
        }
        #endregion

        #region Получение и установка allanOver_var
        //public List<double> get_allan_over()
        //{
        //    List<double> AllanOverList = new List<double>();
        //    for (int i = 0; i < time_list.Count; ++i)
        //    {
        //        AllanOverList.Insert(i, OverAllan(AverforOverAllan(freq, time_list[i]), time_list[i]));
        //    }
        //    return AllanOverList;
        //} 
        public List<double> get_allan_over()
        {
            return allanOver_var;
        }
        private List<double> set_allanOver_var(List<double> freq, List<int> time_list)
        {
            
            List<double> allanOver_var = new List<double>();
            time_list = new List<int>(time_list);
            foreach (int t in time_list)
            {
                allanOver_var.Add(OverAllan(freq, t));
            }
            return allanOver_var;
        }
        private void RetuntAvarO(Task<List<double>> AvarO)
        {
            allanOver_var.Clear();
            allanOver_var = AvarO.Result;
        }
        #endregion

        #endregion

        #region Основная Математика
        #region Алгоритмы усреднения
        public List<double> Aver(List<double> Ar0, int tusr)//расчет усредненного ряда
        {
            List<double> Ar1 = new List<double>();
            //if (freq.Count < 10)
            //{
            //    return Math.Pow(10, -30);
            //}
            for (int i = 0; i < (Ar0.Count) / tusr; i++)
            {
                double sredfreq = 0;
                for (int j = 0; j < tusr; j++)
                {
                    //Ar1.Insert(0;Ar1[i]);

                    sredfreq += Ar0[i * tusr + j];
                }
                sredfreq /= tusr;
                Ar1.Insert(i, sredfreq);
            }
            return Ar1;
        }
        public List<double> AverforOverAllan(List<double> Ar0, int tusr)//расчет усредненного ряда
        {
            List<double> Ar1 = new List<double>();
            //if (freq.Count < 10)
            //{
            //    return Math.Pow(10, -30);
            //}
            for (int i = 0; i < Ar0.Count - tusr + 1; i++)
            {
                double sredfreq = 0;
                for (int j = i; j < i + tusr; j++)
                {

                    sredfreq += Ar0[j];
                }
                sredfreq /= tusr;
                Ar1.Insert(i, sredfreq);
            }
            return Ar1;
        } 
        #endregion

        // Расчёт вариации Аллана
        public double AVAR(List<double> freq)
        {
            if (freq.Count == 1)
            {
                allan_var.Insert(n_meas - 1, 0);
                return 0;
            }

            double fn = 1;

            double Gav = 0;
            double G0i = 0;

            for (int j = 1; j < freq.Count; j++)
            {
                G0i = (freq[j] - freq[j - 1]) / fn;
                Gav += G0i * G0i;
            }

            Gav /= (2 * (freq.Count - 1));
            Gav = Math.Sqrt(Gav);
            // allan_var.Insert(n_meas - 1, Gav);

            return Gav;
        }

        public double SKO(List<double> freq)
        {
            if (freq.Count == 1)
            {
                //sko_.Insert(n_meas - 1, 0);
                return 0;
            }

            double sredfreq = 0;
            double sko = 0;

            for (int i = 0; i < freq.Count; i++)
            {
                sredfreq += freq[i];
            }
            sredfreq /= freq.Count;

            for (int j = 0; j < freq.Count; j++)
            {
                sko += (freq[j] - sredfreq) * (freq[j] - sredfreq);
            }
            sko /= (freq.Count - 1);

            double return_sko = Math.Sqrt(sko);
            //sko = return_sko;
            return return_sko;
        }

        public double SKSV(List<double> freq)
        {
            //if (freq.Count <= 2)
            //{
            //    sksv_.Insert(n_meas - 1, 0);
            //    return 0;
            //}

            List<double> otn_variance = new List<double>(freq.Count - 1);// относительная вариация частоты
            double sred_otn_variance = 0;// средняя относительная вариация частоты
            double fn = 5000000;
            double sksv = 0; // средняя квадратическая случайная вариация частоты(нестабильность)
            for (int i = 0; i < freq.Count - 1; i++)
            {
                otn_variance.Insert(i, (freq[i] - freq[i + 1]));
            }

            sred_otn_variance = (freq[0] - freq[freq.Count - 1]) / (otn_variance.Count);

            for (int k = 0; k < otn_variance.Count; k++)
            {
                sksv += (otn_variance[k] - sred_otn_variance) * (otn_variance[k] - sred_otn_variance);
            }
            sksv /= (otn_variance.Count);

            double return_sksv = Math.Sqrt(sksv);
            //sksv_.Insert(n_meas - 1, return_sksv);

            return return_sksv;
        }
      
        public double OverAllan(List<double> freq, int m_aver)
        {
            //int m_aver = 1; // коэффициент усреднения 
            double return_sum = 0,
                   sum = 0;
            int M = n_meas;
            for (int i = 0; i < M - 2 * m_aver + 1; i++)
            {
                sum = 0;
                for (int j = i; j <= i + m_aver - 1; j++)
                {
                    sum += freq[i + m_aver] - freq[i];
                }

                return_sum += sum * sum;
            }
            return_sum = return_sum/2.0 / m_aver / m_aver / (M - 2 * m_aver + 1);
            return Math.Sqrt(return_sum);
        } 
        #endregion
    }
}
