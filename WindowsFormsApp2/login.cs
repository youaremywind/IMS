﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\新建文件夹\WindowsFormsApp2\mysqltable.mdf;Integrated Security=True");

        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from userinfo where username= '" +textBox1.Text +"'and password='"+ textBox2.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i =Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("账号密码不匹配");
            }
            else {
                this.Hide();
                MDIParent1 mdi = new MDIParent1();
                mdi.Show();


            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Open) {
                con.Close();
            }
            con.Open();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
