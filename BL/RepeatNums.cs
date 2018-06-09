using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace BL
{
    public class RepeatNums 
    {

        public List<int> Nums { get; set; }

        public RepeatNums(List<int> input)
        {
            this.Nums = input;
        }


        public List<int> repeat_num()
        {
            var output_list = new List<int>();
            int n = 1;
            foreach (int num in Nums)
            {
                if (num >= 5 && num <= 10)
                {
                    output_list.Add(num);
                    output_list.Add(num);
                }
                else
                    output_list.Add(num);
           
            }

            return output_list;

        }


    }
}
