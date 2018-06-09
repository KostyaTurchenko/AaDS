using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.Students_1._3._13_;
using System.IO;

namespace _1._3._13
{
    public partial class Form1 : Form
    {

        //13.	Вывести студента с наибольшим средним баллом на каждом курсе.


        Student[] students;
        

        public Form1()
        {
            
            InitializeComponent();
            openFileDialog1.InitialDirectory = Path.Combine(Application.StartupPath);
            openFileDialog1.Filter = "Data files | *.dat";

        }


        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                StudentsInBinary studentsB = new StudentsInBinary(path);
                students = studentsB.Read();
                FillTable(students);
                button1.Visible = true;               
            }
        }

        void FillTable(IList<Student> students)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < students.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = students[i].FIO;
                dataGridView1.Rows[i].Cells[1].Value = students[i].Year;
                for (int j = 0; j < students[i].MedB.Length; j++)
                    dataGridView1.Rows[i].Cells[2].Value += students[i].MedB[j] + "; ";
                dataGridView1.Rows[i].Cells[3].Value = students[i].Course;
                dataGridView1.Rows[i].Cells[4].Value = students[i].Group;
                dataGridView1.Rows[i].Cells[5].Value = students[i].AverageRating;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SortOfStudents stud = new SortOfStudents(students);
            IList<Student> uns = stud.StudetsWithMaxMark();
            FillTable(uns);
        }
    }
}
