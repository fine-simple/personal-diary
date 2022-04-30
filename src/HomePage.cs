using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void ManageDiaries_Click(object sender, EventArgs e)
        {

            ManageDiaries mg = new ManageDiaries();
            mg.ShowDialog();
        }

        private void UserTaskReports_Click(object sender, EventArgs e)
        {
            TasksReport tr = new TasksReport();
            tr.ShowDialog();
        }

        private void DiariesReports_Click(object sender, EventArgs e)
        {
            DiariesReport dr = new DiariesReport();
            dr.ShowDialog();
        }

        private void ManageTasks_Click(object sender, EventArgs e)
        {
            ManageTasks mt = new ManageTasks();
            mt.ShowDialog();

        }

        
    }
}
