using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BL;



namespace BL
{
    public class FileString 
    {
        public FileString(string path)
        {
            this.Path = path; 
        }

        public string Path { get; set; }
        public List<double> ReadStringFromFile()
        {
            string Str_From_file = File.ReadAllText(Path);
            var substring_list = new List<double>();


            string[] substring = Str_From_file.Split(' ');

            for (int i = 0; i < substring.Length; i++)
            {
                try
                {
                    double k = Convert.ToDouble(substring[i]);
                    substring_list.Add(k);
                }
                catch (FormatException)
                {
                    continue;
                }
            }


            return substring_list;
        }

        public static void SaveFile(string str, string path)
        {
                       
            File.WriteAllText(path, str);
           
        }



    }
}
