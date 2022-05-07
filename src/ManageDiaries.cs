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
        DataSet ds = new DataSet();

        public ManageDiaries()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            Console.WriteLine(ds.Tables[0].Rows.Count);
            adapter.Update(ds.Tables[0]);
        }

        private void ManageDiaries_Load(object sender, EventArgs e)
        {
            string cmdstr = "Select title, content, username from Diary Where username=:name";
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

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            string diaryTitle = dataGridView1.Rows[e.RowIndex].Cells["title"].Value.ToString();
            string content = dataGridView1.Rows[e.RowIndex].Cells["content"].Value.ToString();
            Console.WriteLine(diaryTitle);
            Diary diary = new Diary(diaryTitle, content);
            diary.ShowDialog();
            if (diary.DialogResult != DialogResult.OK)
                return;
            
            DataTable table = (DataTable)(dataGridView1.DataSource);
            bool addNew = e.RowIndex == dataGridView1.Rows.Count - 1;
            if(addNew)
            {
                DataRow row = table.NewRow();
                row["title"] = diary.getTitle();
                row["content"] = diary.getContent();
                row["username"] = Globals.username;
                ds.Tables[0].Rows.Add(row);
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);
            }
            else
            {
                dataGridView1.Rows[e.RowIndex].Cells["title"].Value = diary.getTitle();
                dataGridView1.Rows[e.RowIndex].Cells["content"].Value = diary.getContent();
                dataGridView1.Rows[e.RowIndex].Cells["username"].Value = Globals.username;
            }
        }
    }
}