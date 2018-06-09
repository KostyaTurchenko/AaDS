using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;



namespace BL
{
    public class WorkWithStack 
    {
        public string StrIn;

        public WorkWithStack (string str)
        {
            StrIn = str;
        }


        private List<double> ConvertToList (string str)
        {
            var outputList = new List<double>();
            string[] outputMass = str.Split(' ');
            foreach (string n in outputMass)
            {
                double num;
                if (double.TryParse(n, out num))
                {
                    outputList.Add(num);
                }

            }
            return outputList;
        }

        public List<double> FormStacks ()
        {
            var list = ConvertToList(StrIn);

            Stack<double> negative_stack = new Stack<double>();
            Stack<double> positive_stack = new Stack<double>();

            var outputlist = new List<double>();

            foreach (double num in list)
            {
                if (num < 0)
                {
                    negative_stack.Push(num);
                }
                else positive_stack.Push(num);
            }

            outputlist.AddRange(negative_stack.print());
            outputlist.AddRange(positive_stack.print());

            return outputlist;
        }

        public static void SaveFile(string str, string path)
        {
            File.WriteAllText(path, str);


        }

    }
}
