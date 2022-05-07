using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Personal_Diary
{
    public partial class Diary : Form
    {
        private string title;
        private string content;
        public Diary(string title, string content)
        {
            this.title = title;
            this.content = content;
            InitializeComponent();
        }
        private void Diary_Load(object sender, EventArgs e)
        {
            titleTxtBox.Text = title;
            contentRichBox.Text = content;
            Globals.conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Globals.conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getTags";
            cmd.Parameters.Add("title", title);
            cmd.Parameters.Add("cursor", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                tagsCheckedListBox.Items.Add(dr["tagtitle"].ToString(), dr["diarytitle"].ToString().Length > 0);
            }
            Globals.conn.Close();
        }
        public string getTitle() { return title; }
        public string getContent() { return content; }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            title = titleTxtBox.Text;
            content = contentRichBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}