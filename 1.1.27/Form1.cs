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
using Utils;
using BL;

namespace _1._1._27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void MainMenuOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                 string path = openFileDialog1.FileName;
                 File_Text.Text = File.ReadAllText(path);

                 FileString instance = new FileString(path);
                 string output_str = string.Join("; ", instance.ReadStringFromFile()); 

                 label2.Text = output_str;

            }
        }

        private void MainMenuSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string path = saveFileDialog1.FileName;
                FileString.SaveFile(label2.Text, path);


            }
        }


    }
}
