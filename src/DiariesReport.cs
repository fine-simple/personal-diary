using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;

namespace WindowsFormsApplication4
{
    public partial class DiariesReport : Form
    {
        Personal_Diary.DiariesCrystalReport CR;

        public DiariesReport()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CR = new Personal_Diary.DiariesCrystalReport();
            crystalReportViewer1.ReportSource = CR;
        }
    }
}
