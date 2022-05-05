using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;
using Personal_Diary;

namespace WindowsFormsApplication4
{
    public partial class ManageDiaries : Form
    {

        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds = new DataSet();

        public ManageDiaries()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void ManageDiaries_Load(object sender, EventArgs e)
        {
            string cmdstr = "Select * from Diary Where username=:name";
            adapter = new OracleDataAdapter(cmdstr, Globals.ordb);
            adapter.SelectCommand.Parameters.Add("name", Globals.username);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            saveBtn.Enabled = true;
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new ManageTasks().ShowDialog();
            Show();
        }

        private void tasksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            new TasksReport().ShowDialog();
            Show();
        }

        private void diariesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new DiariesReport().ShowDialog();
            Show();
        }
    }
}