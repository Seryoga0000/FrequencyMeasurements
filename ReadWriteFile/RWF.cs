using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
//using System.IO;
namespace ReadWriteFile
{
    public class ReadWriteFileClass
    {
        public string filename_write;
        public string filename_write_allan;
        public string filename_write_sko;
        public string filename_write_sksv;
        public string filename_auto,
                      foldername_auto;
        public string filename_read;

        public ReadWriteFileClass()
        {
            filename_write = "results.txt";
            filename_write_allan = "Вариация Аллана.txt";
            filename_write_sko = "СКО.txt";
            filename_write_sksv = "СКСВ.txt";
            filename_auto = "results_auto.txt";
            foldername_auto = "Results_auto";
        }

        public void SetFilenameWrite(string filename_)
        {
            filename_write = filename_;
        }

        public void SetFilenameRead(string filename_)
        {
            filename_read = filename_;
        }

        public void PrintMeasToFile(int No, string date, double data)
        {
            string path = filename_write;
            FileStream file;
            if (No == 1)
              file = new FileStream(path, FileMode.Create);
            else
              file = new FileStream(path, FileMode.Append);

            StreamWriter writer = new StreamWriter(file);

            writer.WriteLine(Convert.ToString(No) + " " + date + " {0:0.###############e+0}", data);

            writer.Close();
           // var e=Environment.CurrentDirectory;
        }
        public void PrintAllanToFile(int No, string date, double data, string N)
        {
            string path_allan = filename_write + "_" + filename_write_allan;
            FileStream file_allan;
            if (No == 1)
                file_allan = new FileStream(path_allan, FileMode.Create);
            else
                file_allan = new FileStream(path_allan, FileMode.Append);

            StreamWriter writer_allan = new StreamWriter(file_allan);
            writer_allan.WriteLine(Convert.ToString(No) + " " + date + " {0:0.###############e+0}", data + " " + N);
            writer_allan.Close();

        }
        public void PrintSKOToFile(int No, string date, double data, string N)
        {
            string path_sko = filename_write + "_" + filename_write_sko;
            FileStream file_sko;
            if (No == 1)
                file_sko = new FileStream(path_sko, FileMode.Create);
            else
                file_sko = new FileStream(path_sko, FileMode.Append);

            StreamWriter writer_sko = new StreamWriter(file_sko);
            writer_sko.WriteLine(Convert.ToString(No) + " " + date + " {0:0.###############e+0}", data + " " + N);
            writer_sko.Close();

        }
        public void PrintSKSVToFile(int No, string date, double data, string N)
        {
            string path_sksv = filename_write + "_" + filename_write_sksv;
            FileStream file_sksv;
            if (No == 1)
                file_sksv = new FileStream(path_sksv, FileMode.Create);
            else
                file_sksv = new FileStream(path_sksv, FileMode.Append);

            StreamWriter writer_sksv = new StreamWriter(file_sksv);
            writer_sksv.WriteLine(Convert.ToString(No) + " " + date + " {0:0.###############e+0}", data + " " + N);
            writer_sksv.Close();

        }

        public void PrintMeasToFileAuto(List<string> date, List<double> data)
        {
            Directory.CreateDirectory(foldername_auto);

            string path = foldername_auto + "/" + filename_auto;
            FileStream file = new FileStream(path, FileMode.Create);
            
            StreamWriter writer = new StreamWriter(file);

            for (int i = 0; i < data.Count; ++i)
              writer.WriteLine(Convert.ToString(i+1) + " " + date[i] + " {0:0.###############e+0}", data[i]);

            writer.Close();
        }

        public int ReadMeasFromFile(int n_freq, string[] args)
        {
            string path = filename_read;          

            StreamReader reader = new StreamReader(path);

            string line = "";
            for (int i = 0; i < n_freq + 1; ++i)
            {
                line = reader.ReadLine();
                if (line == null)
                    return 1;
            }

            string[] str = line.Split(' ');

            args[0] = str[0];
            args[1] = str[1] + " " + str[2];
            args[2] = str[3];

            reader.Close();

            return 0;
        }
    }
}
