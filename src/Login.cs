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
using WindowsFormsApplication4;

namespace Personal_Diary
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new Register().ShowDialog();
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmdText = @"SELECT * FROM DiaryUser WHERE username=:name AND password=:pass";
            OracleConnection conn = new OracleConnection(Globals.ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(cmdText, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("name", usernameTxtBox.Text);
            cmd.Parameters.Add("pass", passTxtBox.Text.ToArray());
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Hide();
                Globals.username = dr["username"].ToString();
                new ManageDiaries().ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}