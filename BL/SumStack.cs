using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BL
{
    public class SumStack
    {
        public string StrIn;

        public SumStack(string str)
        {
            StrIn = str;
        }


        private List<double> ConvertToList(string str)
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


        public double FormStacks()
        {
            var list = ConvertToList(StrIn);

            Stack<double> positive_stack = new Stack<double>();

            var outputlist = new List<double>();

            foreach (double num in list)
            {
                if (num > 0)
                {
                    positive_stack.Push(num);
                }
            }

            double sum = 0;
            double k = 10;
            while (positive_stack.Count != 0)
            {
                sum += positive_stack.Pop() * k;
                k *= 10;
            }

            return sum;
        }

        public static void SaveFile(string str, SaveFileDialog save)
        {
            if (save.ShowDialog() == DialogResult.OK)
            {
                string path = save.FileName;
                File.WriteAllText(path, str);

            }

        }

    }
}