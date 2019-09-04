using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConnectDevice;
namespace MainForm
{
    public partial class Setting : Form
    {
        IConnect cnct;
        public Setting()
        {
            InitializeComponent();
            cnct = new ConnectCNT90();
        }

        private void Setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) // чтобы при нажатии на крестик окно настроек не закрывалась а просто скрывалось
            {
                e.Cancel = true;
            }
            this.Hide();
        }

        private void DeviceList_Click(object sender, EventArgs e)
        {
            DeviceList.Items.Clear();// очистим список
            if (ChooseFreqMeter.Text == "CNT-90/CNT-91")
            {
                string[] addresses = cnct.FindDevice();// принимаем список доступных девайсов
                //DeviceList.Items.Add("Виртуальный прибор");
                if (addresses != null)
                {
                    foreach (string adr in addresses)// создаем список для выбора пользователя
                    {
                        DeviceList.Items.Add(adr);
                    }
                }
                DeviceList.DroppedDown = true;//разворачивает комбобокс
            }
            else if (ChooseFreqMeter.Text == "VCH308A")
            {
                foreach (string cp in System.IO.Ports.SerialPort.GetPortNames())
                {
                    DeviceList.Items.Add(cp);
                }
                if (DeviceList.Items.Count > 0) DeviceList.Text = DeviceList.Items[0].ToString();
            }

        }

        private void ConnectToDevice_Click(object sender, EventArgs e)
        {
            cnct.Address = DeviceList.Text;
            if (cnct.Connection() == "Error") MessageBox.Show("Ошибка подключения к прибору  \n" + cnct.ErrorMessage);
            string Info = cnct.Info();
            DeviceInfo.Text = "Информация о приборе: " + Info;
            cnct.CloseSession();
        }

        private void Setting_Load(object sender, EventArgs e)
        {

        }
        public bool get_AutoScrolChecked
        {
            get
            {
                return AutoScrol.Checked;
            }
        }
        public string get_TimeListType()
        {
            return TimeListType.Text;
        }
        public string get_CountPoint()
        {
            return CountPointListType.Text;
        }

        public string get_Resol_F()
        {
            return Resolution_F.Text;
        }
        public string get_Resol_SKO()
        {
            return Resolution_SKO.Text;
        }
        public string get_Resol_AVAR()
        {
            return Resolution_AVAR.Text;
        }

        public string get_Resol_SKSV()
        {
            return Resolution_SKSV.Text;
        }
        public string get_Resol_AllanOver()
        {
            return Resolution_AllanOver.Text;
        }

        private void DeviceList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SKO_visible_CheckedChanged(object sender, EventArgs e)
        {
            SKO_visible_change(SKO_visible.Checked);
        }

        public bool get_SKO_visible()
        {
            return SKO_visible.Checked;
        }

        public event Action<bool> SKO_visible_change;

        private void Allan_visible_CheckedChanged(object sender, EventArgs e)
        {
            Allan_visible_change(Allan_visible.Checked);
        }

        public bool get_Allan_visible()
        {
            return Allan_visible.Checked;
        }

        public event Action<bool> Allan_visible_change;

        private void SKSV_visible_CheckedChanged(object sender, EventArgs e)
        {
            SKSV_visible_change(SKSV_visible.Checked);
        }

        public bool get_SKSV_visible()
        {
            return SKSV_visible.Checked;
        }

        public event Action<bool> SKSV_visible_change;

        private void AllanOver_visible_CheckedChanged(object sender, EventArgs e)
        {
            AllanOver_visible_change(AllanOver_visible.Checked);
        }
        public bool get_AllanOver_visible()
        {
            return AllanOver_visible.Checked;
        }

        public event Action<bool> AllanOver_visible_change;

        public event Action<string> Time_List_Change; 
        private void TimeListType_TextChanged(object sender, EventArgs e)
        {
            if(Time_List_Change!=null) Time_List_Change(TimeListType.Text);
        }

        private void ChooseFreqMeter_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (ChooseFreqMeter.Text == "CNT-90/CNT-91") cnct = new ConnectCNT90();

           if (ChooseFreqMeter.Text == "VCH308A") cnct = new ConnectVCH308();

           if (ChooseFreqMeter.Text == "Виртуальный прибор") cnct = new ConnectVCH308();

        }
        public IConnect NewConnect()
        {
            //return new ConnectCNT90(cnct.Address);
            if (cnct.Type == "ConnectCNT90")
            {
                return new ConnectCNT90(cnct.Address);
            }

            else if (cnct.Type == "ConnectVCH308") return new ConnectVCH308(cnct.Address);
            else if (cnct.Type == "ConnectVirtual") return new ConnectVirtual();
            else return null;
        }

    }
}
