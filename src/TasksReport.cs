using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using Personal_Diary;

namespace WindowsFormsApplication4
{
    public partial class TasksReport : Form
    {
        Personal_Diary.TasksCrystalReport Cr2;
        public TasksReport()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Cr2 = new Personal_Diary.TasksCrystalReport();

            Cr2.SetParameterValue(0, Globals.username);
            crystalReportViewer2.ReportSource = Cr2;
        }

        
    }
}
