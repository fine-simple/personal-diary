using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace WindowsFormsApplication4
{
    public partial class TasksReport : Form
    {
        TasksCrystalReport Cr2;
        public TasksReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Cr2 = new TasksCrystalReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cr2.SetParameterValue(0, textBox1.Text);
            crystalReportViewer2.ReportSource = Cr2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
