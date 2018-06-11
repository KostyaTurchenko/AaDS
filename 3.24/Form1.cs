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

namespace _3._24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Path.Combine(Application.StartupPath);
        }


        string[] students;
        Queue myqueue;

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                students = File.ReadAllLines(path);
                myqueue = new Queue();
                foreach(string student in students)
                {
                    myqueue.InQueue(student);
                }
                label1.Text = myqueue.Print();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                myqueue.InQueueWithKeepingOfOrder(textBox1.Text);
                label1.Text = myqueue.Print();
                students = label1.Text.Split('\n');

            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                File.WriteAllLines(path, students);
            }
        }
    }
}
