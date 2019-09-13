using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ivi.Visa.Interop;
using System.Threading;
using System.Diagnostics;
using WriteDataToFileLib;
namespace ConnectDevice
{
    public interface IConnect
    {
        string Connection();
        string Info();
        string[] FindDevice();
        string Address { get; set; }
        string MeasFreq();
        void CloseSession();
        string Atributes { get; set; }
        string Type { get; set; }
        //string Info();
        string ErrorMessage { get; set; }

    }
    public class ConnectCNT90 : IConnect
    {

        ResourceManager rm;
        FormattedIO488 Device;
        string address = "USB0::5355::145::158208::0::INSTR";
        string mode = "FETCH";
        string errorMessage = "";
        public string ErrorMessage
        {
            get
            {
                return errorMessage;
            }
            set { }
        }
        public string Type
        {
            get
            {
                return "ConnectCNT90";
            }
            set { }
        } //
        public string Address
        {
            set
            {
                address = value;
            }
            get
            {
                return address;
            }
        } // адрес прибора выбранный пользователем 
        public string Atributes
        {
            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }
        }
        public string Mode
        {
            set
            {
                mode = value;
            }
            get
            {
                return mode;
            }
        } //режим измерения прибора 
        public ConnectCNT90()
        {
            rm = new ResourceManager();
            Device = new FormattedIO488();

        }
        public ConnectCNT90(string Atr)
        {
            rm = new ResourceManager();
            Device = new FormattedIO488();
            Atributes = Atr;
        }
        public string Connection()
        {

            try
            {
                if (address != "Виртуальный прибор") Device.IO = (IMessage)rm.Open(address, AccessMode.NO_LOCK, 2000, "");
                return "Ok";
            }
            catch
            {
                return "Error";

            }

        }
        public void CloseSession()
        {
            Device.IO.Close();
        }
        public string MeasFreq() //функция запроса значения частоты прибора
        {

            try
            {
                if (Mode == "Simulate")
                {
                    Random rnd = new Random();
                    Thread.Sleep(1000);
                    return (rnd.Next(0, 1000000) / 1000000000.0 + 5000000.0).ToString().Replace(",", ".");
                }
                else if (Mode == "MEAS")
                {
                    Device.WriteString("MEAS:FREQ?");
                    return Device.ReadString();
                }
                else if (Mode == "FETCH")
                {
                    Device.WriteString("FETCH:FREQ?");
                    return Device.ReadString();
                }
                else if (Mode == "READ")
                {
                    Device.WriteString("READ:FREQ?");
                    return Device.ReadString();
                }
                else
                {
                    Device.WriteString("MEAS:FREQ?");
                    return Device.ReadString();
                }
            }
            catch
            {
                return "Error";
            }

        }
        public string[] FindDevice() //функция поиска доступных измерительных приборов
        {
            try
            {

                ResourceManager rm = new ResourceManager();
                string[] addresses = rm.FindRsrc("?*INSTR");
                return addresses;
            }
            catch
            {
                return null;
            }
        }
        public string Info()
        {
            try
            {
                Device.WriteString("*IDN?");
                return Device.ReadString();
            }
            catch
            {
                return "Error";
            }
        }//полученние информации о приь\боре по команде *IDN?
    }
    public class ConnectVCH308 : IConnect
    {
        System.IO.Ports.SerialPort ComPort;

        Stopwatch stopWatch;
        string address = "COM1";
        string tt = "";
        string info = "Error";
        string errorMessage = "";
        public string ErrorMessage
        {
            get
            {
                return errorMessage;
            }
            set { }
        }
        public string Address
        {
            set
            {
                address = value;
            }
            get
            {
                return address;
            }
        } // адрес прибора выбранный пользователем 
        //public string Mode
        //{
        //    set
        //    {
        //        mode = value;
        //    }
        //    get
        //    {
        //        return mode;
        //    }
        //} //режим измерения прибора 
        WriteDataToFile wdtf;
        WriteDataToFile wdtf2;
        WriteDataToFile wdtf3;
        public string Type
        {
            get
            {
                return "ConnectVCH308";
            }
            set { }
        }
        public ConnectVCH308(string Atr)
        {
            ComPort = new System.IO.Ports.SerialPort() { DtrEnable = true, RtsEnable = true, PortName = address, BaudRate = 19200 };
            //ComPort.Handshake = System.IO.Ports.Handshake.RequestToSend;
            stopWatch = new Stopwatch();
            ComPort.DataReceived += ComPort_DataReceived;
            Atributes = Atr;
            wdtf = new WriteDataToFile();
            wdtf2 = new WriteDataToFile();
            wdtf3 = new WriteDataToFile();
            //wdtf.OpenFile
        }
        public ConnectVCH308()
        {
            ComPort = new System.IO.Ports.SerialPort() { DtrEnable = true, RtsEnable = true, PortName = address, BaudRate = 19200 };
            stopWatch = new Stopwatch();
            ComPort.DataReceived += ComPort_DataReceived;

        }
        private void ComPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            DR0();
        }

        private void DR0()
        {
            string buf = "";
            if (ComPort.BytesToRead > 0)
            {

                byte[] buffer = new byte[ComPort.BytesToRead];

                ComPort.Read(buffer, 0, buffer.Length);

                for (byte i = 0; i <= buffer.Length - 1; i++)
                {
                    int ii = i;
                    //Buffer.Add(buffer[ii]);
                    buf = buffer[ii].ToString("X");
                    if (buf.Length == 1) buf = "0" + buf;
                    tt += buf + " ";
                }
                buf = "";
                //ComPort.
                //if (tt.IndexOf("01")==-1||((tt.Length - tt.Replace("01", "").Length) / 2) < 2) return;//Проверим что 01 встречается в строке более 1 раза

                ////tt = tt.Substring(tt.IndexOf("01"), 1);
                //var splitTT = tt.Split(new string[] {"01"}, StringSplitOptions.None);
                //if (splitTT.Count() > 3)
                //{
                //    MessageBox.Show("splitTT.Count() > 3");
                //}
                //tt ="01 "+ splitTT[2].Trim()+" ";
                //var ttt = splitTT[1].Trim();
                //ReadText2.Invoke((MethodInvoker)(() =>
                //{
                //    if (ttt.Length < 29) MessageBox.Show("ttt.Length < 29");
                //    int ph = Convert.ToInt32(ttt.Substring(28, 1) + ttt.Substring(25, 1) + ttt.Substring(22, 1)+ ttt.Substring(19, 1) + ttt.Substring(16, 1) + ttt.Substring(12, 1), 16);
                //    ReadText2.Rows.Add(ph.ToString());
                //    ttt = "";
                //}));

                //ReadText2.Invoke((MethodInvoker)(() =>
                //{
                //    ReadText2.Rows.Add(DateTime.Now.ToLongTimeString().ToString() + "   " + tt);
                //    ReadText2.CurrentCell = ReadText2.Rows[ReadText2.Rows.Count - 2].Cells[0];
                //}));
                //tt = "";

            }
        }
        private void DR1()
        {
            string buf = "";
            buf = ComPort.ReadExisting();
            tt += buf;
            buf = "";
        }
        public string Atributes
        {
            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }
        }
        public string Connectionz()
        {

            stopWatch.Start();
            if (!ComPort.IsOpen) ComPort.Open();

            WriteCommand("01363034");
            string ttt = tt;
            //ComPort.
            while (tt.Length - ttt.Length < 30) { if (stopWatch.Elapsed.Seconds >= 2) { errorMessage = "NoAnswerFromDevice"; return "Error"; } }
            stopWatch.Stop();
            //if (ttt.Length == tt.Length)  return "Error";//_NoAnswerFromDevice";
            if (tt.Length < 30) { errorMessage = "AnswerLenghtSmall " + tt; tt = ""; return "Error"; }//_AnswerLenghtSmall";
            string[] arrtt = tt.Trim().Split(' ');
            if (arrtt.Count() < 10) { tt = ""; return "Error"; }//_AnswerLenghtSmall2";
            if ((Convert.ToInt32(arrtt[8]) & 1) != 0) { tt = ""; errorMessage = "NoInputSignal"; return "Error"; }//_NoInputSignal";
            //if ((Convert.ToInt32(arrtt[8]) & 2) != 0) { tt = ""; errorMessage = "DeviceBad"; return "Error"; }//_DeviceBad";
            //if (arrtt[2] != "4F" || arrtt[2] != "4B") { tt = ""; errorMessage = "NoOkMessage"; return "Error"; }//_NoOkMessage";
            tt = "";
            info = "Device Ok";
            return "Ok";
        }
        public string Connection()
        {

            stopWatch.Start();
            if (!ComPort.IsOpen) ComPort.Open();

            WriteCommand("01723030");
            Thread.Sleep(100);
            WriteCommand("01533030");
            Thread.Sleep(100);
            WriteCommand("01363030");
            Thread.Sleep(100);
            WriteCommand("01573130");
            Thread.Sleep(100);
            tt = "";
            info = "Device Ok";
            return "Ok";
        }
        private void WriteCommand(string cmnd)
        {
            if (!ComPort.IsOpen)
            {
                return;
            }
            if (cmnd.Length < 1) return;
            byte[] tttt = StringToByteArray(cmnd);

            ComPort.Write(tttt, 0, tttt.Length);
        }
        public byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
        public void CloseSession()
        {
            ComPort.Close();
        }
        int count1 = 0;
        public string MeasFreq() //функция запроса значения частоты прибора
        {
            wdtf.ChooseFile("1.txt");
            wdtf.OpenFile();
            wdtf2.OpenFile("2.txt");
            wdtf3.ChooseFile("3.txt");
            wdtf3.OpenFile();
            
            //stopWatch.Start();
            string ttt = tt;
            WriteCommand("01683030");
            //WriteCommand("01683030");
            //WriteCommand("01683030");
            //WriteCommand("01683030");

            //ComPort.
            // while (tt.Length - ttt.Length < 95) { if (stopWatch.Elapsed.Seconds >= 1) { errorMessage = "VCH_Error_NotEnoughPhaseData"; return "VCH_Error_NotEnoughPhaseData"; } }
            //int i = 0;
            //while (tt.Length - ttt.Length < 95) 
            //{
            //    i++;
            //    if (i > 1000000000)
            //        break;
            //    //if (stopWatch.Elapsed.Seconds >= 50) { errorMessage = "VCH_Error_NotEnoughPhaseData"; return "VCH_Error_NotEnoughPhaseData"; } 
            //}
            Thread.Sleep(500);
           //if(count1%2==0)
           //    Thread.Sleep(1000);
           //if (count1 % 2 == 1)
           //    Thread.Sleep(3000);
           //count1++;
            wdtf.WriteToFile(tt);

            if (tt.IndexOf("01") == -1 || ((tt.Length - tt.Replace("01", "").Length)) < 4 || tt.Length < 64)
            {
                //Thread.Sleep(1000);
                return "VCH_Error_NotEnoughPhaseData";
            }
            //wdtf.WriteToFile("2" + tt);
            //int t1 = tt.IndexOf("01");
            //int t2 = tt.Replace.IndexOf("01");
            string[] splitTT = ("XX " + tt).Split(new string[] { "01" }, StringSplitOptions.None);

            string message1 = splitTT[1].Trim();
            string message2 = splitTT[2].Trim();

            //wdtf2.WriteToFile(message1);
            //wdtf2.WriteToFile(message2);
            //wdtf2.WriteToFile(" ");
            if (message1.Length < 32 || message2.Length < 32)
            {
                //Thread.Sleep(1000);
                return "VCH_Error_NotEnoughPhaseData";
            }

            int ph1 = Convert.ToInt32(message1.Substring(28, 1) + message1.Substring(25, 1) + message1.Substring(22, 1) + message1.Substring(19, 1) + message1.Substring(16, 1) + message1.Substring(13, 1), 16);
            int ph2 = Convert.ToInt32(message2.Substring(28, 1) + message2.Substring(25, 1) + message2.Substring(22, 1) + message2.Substring(19, 1) + message2.Substring(16, 1) + message2.Substring(13, 1), 16);

            int n1 = Convert.ToInt32(message1.Substring(61, 1) + message1.Substring(58, 1) + message1.Substring(55, 1) + message1.Substring(52, 1) + message1.Substring(49, 1) + message1.Substring(46, 1) + message1.Substring(43, 1) + message1.Substring(40, 1), 16);
            int n2 = Convert.ToInt32(message2.Substring(61, 1) + message2.Substring(58, 1) + message2.Substring(55, 1) + message2.Substring(52, 1) + message2.Substring(49, 1) + message2.Substring(46, 1) + message2.Substring(43, 1) + message2.Substring(40, 1), 16);

            //int a1 = Convert.ToInt32(message1.Substring(73, 1) + message1.Substring(70, 1) + message1.Substring(67, 1), 16);
            //int a2 = Convert.ToInt32(message2.Substring(73, 1) + message2.Substring(70, 1) + message2.Substring(67, 1), 16);

            //int b1 = Convert.ToInt32(message1.Substring(85, 1) + message1.Substring(82, 1) + message1.Substring(79, 1), 16);
            //int b2 = Convert.ToInt32(message2.Substring(85, 1) + message2.Substring(82, 1) + message2.Substring(79, 1), 16);
            int a1 = Convert.ToInt32(message1.Substring(67, 1) + message1.Substring(70, 1) + message1.Substring(73, 1));
            int a2 = Convert.ToInt32(message2.Substring(67, 1) + message2.Substring(70, 1) + message2.Substring(73, 1));

            int b1 = Convert.ToInt32(message1.Substring(79, 1) + message1.Substring(82, 1) + message1.Substring(85, 1));
            int b2 = Convert.ToInt32(message2.Substring(79, 1) + message2.Substring(82, 1) + message2.Substring(85, 1));
            wdtf3.WriteToFile("Время:        "+DateTime.Now.ToString());
            wdtf3.WriteToFile("message1:     " + message1);
            wdtf3.WriteToFile("message2:     " + message2);
            
            //string MessageAscii1="";
            ////string MessageAscii2="";
            //foreach (var bb in message1.Split(new string[] { " " }, StringSplitOptions.None))
            //{
            //    MessageAscii1 +=" "+ Convert.ToChar((Convert.ToInt32(bb,16)))+" ";
            //}

            //wdtf3.WriteToFile("MAscii1:      " + MessageAscii1);

            wdtf3.WriteToFile("n1,2:         " + n1.ToString() + " " + n2.ToString());
            wdtf3.WriteToFile("Phase1,2:     " + ph2.ToString() + "-" + ph1.ToString() + "=" + (ph2 - ph1).ToString());

            wdtf3.WriteToFile("a1,b1:         " + a1.ToString() + " " + b1.ToString());
            wdtf3.WriteToFile("a2,b2:         " + a2.ToString() + " " + b2.ToString());
            wdtf3.WriteToFile(" ");

            //if (n2 == n1 )
            //{
            //    return "VCH_Error_NotEnoughPhaseData";
            //}


            if (ph2 == ph1)
            {
                tt = "01 " + message2 + " ";
                splitTT = ("XX " + tt).Split(new string[] { "01" }, StringSplitOptions.None);
                for (int i = 3; i < splitTT.Count(); i++)
                {
                    tt = " " + splitTT[i];
                }
                return "VCH_Error_EqualPhases";
            }
            else if (n2 == n1)
            {
                tt = "01 " + message2 + " ";
                splitTT = ("XX " + tt).Split(new string[] { "01" }, StringSplitOptions.None);
                for (int i = 3; i < splitTT.Count(); i++)
                {
                    tt = " " + splitTT[i];
                }
                return "VCH_Error_EqualPhases";
            }
            double f = ph2 - ph1;

            if (n2 - n1 > 1)
            {
                f /= (n2 - n1);
            }
            //if (a1 == a2)
            //{
            //    tt = "01 " + message2 + " ";
            //    splitTT = ("XX " + tt).Split(new string[] { "01" }, StringSplitOptions.None);
            //    for (int i = 3; i < splitTT.Count(); i++)
            //    {
            //        tt = " " + splitTT[i];
            //    }
            //    return "VCH_Error_LessThanSecond";
            //}
            if (f > 8388608)
                f -= 16014251;
            if (f < -8388608)
                f += 16014251;

            
            
            //if (n2 != n1) f = ((ph2 - ph1) );
            //else
            //{
            //    tt = "01 " + message2 + " ";
            //    splitTT = ("XX " + tt).Split(new string[] { "01" }, StringSplitOptions.None);
            //    for (int i = 3; i < splitTT.Count(); i++)
            //    {
            //        tt = " " + splitTT[i];
            //    }
            //    Thread.Sleep(1000);
            //    return "VCH_Error_NotEnoughPhaseData";
            //}

           


            tt = "01 " + message2 + " ";


            splitTT = ("XX " + tt).Split(new string[] { "01" }, StringSplitOptions.None);
            for (int i = 3; i < splitTT.Count(); i++)
            {
                tt = " " + splitTT[i];
            }

            //int s=0;
            //s= stopWatch.Elapsed.Milliseconds;
            //+ ((splitTT.Count() > 3) ? (" " + splitTT[3].Trim()) : "")
            //while (true) 
            //{
            //    if (stopWatch.Elapsed.Milliseconds+s >= 1000) break;
            //}
            //stopWatch.Stop();

            //Thread.Sleep(1000);

            wdtf.CloseFile();
            wdtf2.CloseFile();
            wdtf3.CloseFile();
            return (f / 100000000000000.0).ToString();

        }


        public string[] FindDevice() //функция поиска доступных измерительных приборов
        {
            return null;
        }
        public string Info()
        {
            return info;

        }//полученние информации о приь\боре по команде *IDN?
    }
    public class ConnectVirtual : IConnect
    {

        Random rnd;
        string errorMessage = "";
        public string ErrorMessage
        {
            get
            {
                return errorMessage;
            }
            set { }
        }
        public string Address
        {
            set
            {
                Address = value;
            }
            get
            {
                return Address;
            }
        } // / адрес прибора выбранный пользователем 
        public string Atributes
        {
            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }
        }
        public string Type
        {
            get
            {
                return "ConnectVirtual";
            }
            set { }
        }
        //public string Mode
        //{

        //} //режим измерения прибора 
        public string MeasFreq() //функция запроса значения частоты прибора
        {
            Thread.Sleep(1000);
            return (rnd.Next(0, 1000000) / 1000000000.0 + 5000000.0).ToString().Replace(",", ".");
        }
        public ConnectVirtual()
        {

            rnd = new Random();
        }
        public string Connection()
        {

            return null;

        }

        public void CloseSession()
        {

        }

        public string[] FindDevice() //функция поиска доступных измерительных приборов
        {
            return null;
        }
        public string Info()
        {
            return null;
        }//полученние информации о приь\боре по команде *IDN?
    }
}
