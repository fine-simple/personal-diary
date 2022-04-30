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
        DiariesCrystalReport CR;

        public DiariesReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CR;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CR = new DiariesCrystalReport();
        }
    }
}
