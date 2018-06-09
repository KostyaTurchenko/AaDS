using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using System.IO;


namespace _3._28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

             string path = openFileDialog1.FileName;
             label1.Text = File.ReadAllText(path);

             var instance = new SumStack(label1.Text);
             label2.Text = String.Join(" ", instance.FormStacks());
                

            
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                WorkWithStack.SaveFile(label2.Text, path);
            }
        }
    }
}
