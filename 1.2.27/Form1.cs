using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BL;

namespace _1._2._27
{
    public partial class Form1 : Form
    {
        //27.	Дан файл целых чисел.Продублировать в нем все числа, принадлежащие диапазону 5..10. 
        RepeatNums Rnums;
        string path;

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Path.Combine(Application.StartupPath);
            var nums = new List<int>() { 3, 5, 12, 6, 9, 24 };
            WorkWithBinary.WriteOfDouble(nums, "int_nums.dat");
            openFileDialog1.Filter = "Data files | *.dat";

            

        }

 

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                path = openFileDialog1.FileName;
                List<int> intList = WorkWithBinary.ReadOfDouble(path);
                label1.Text = string.Join(" ", intList);

                Rnums = new RepeatNums(intList);
                label2.Text = string.Join(" ", Rnums.repeat_num()); 

            }
        }



        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var list = new List<int>();
                label2.Text = string.Join(" ", list);
                WorkWithBinary.WriteOfDouble(list, path);

                

            }
        }


    }
}
