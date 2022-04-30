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


namespace WindowsFormsApplication4
{
    public partial class ManageTasks : Form
    {

        OracleDataAdapter adapter2;
        OracleCommandBuilder builder2;
        DataSet ds2;

        public ManageTasks()
        {
            InitializeComponent();
        }

        

        private void Display_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl ;User Id=scott ; Password=tiger;";
            string cmdstr = "Select * from Tasks Where username= :name";
            adapter2 = new OracleDataAdapter(cmdstr, constr);
            adapter2.SelectCommand.Parameters.Add("name", textBox1.Text);
            ds2 = new DataSet();
            adapter2.Fill(ds2);
            dataGridView1.DataSource = ds2.Tables[0];
        }

        private void Save_Click(object sender, EventArgs e)
        {
            builder2 = new OracleCommandBuilder(adapter2);
            adapter2.Update(ds2.Tables[0]);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

