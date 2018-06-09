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
using BL.utils;

namespace _4._28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            var instance = new WorkWithTeams(RandomTeamList.Get_Teams());
            ;
            label1.Text = instance.ShowInformation(instance.SortOfTeams());
            
        }
    }
}
