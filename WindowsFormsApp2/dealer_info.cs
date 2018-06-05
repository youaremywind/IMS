using System;
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
    public partial class dealer_info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\新建文件夹\WindowsFormsApp2\mysqltable.mdf;Integrated Security=True");
        public dealer_info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("请输入完整再提交");
            }
            else {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into dealer_info values(N'" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + textBox3.Text +
                    "',N'" + textBox4.Text + "',N'" + textBox5.Text + "')";
                cmd.ExecuteNonQuery();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                dg();
                MessageBox.Show("插入成功");
            }
            
        }

        private void dealer_info_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            dg();
        }
        public void dg() {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select* from dealer_info ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            int id;
            //MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString());
            id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dealer_info where id=" + id + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows) {
                textBox6.Text = dr["dealer_name"].ToString();
                textBox7.Text = dr["dealer_company_name"].ToString();
                textBox8.Text = dr["contact"].ToString();
                textBox9.Text = dr["address"].ToString();
                textBox10.Text = dr["city"].ToString();


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from dealer_info where id=" + id + "";
            cmd.ExecuteNonQuery();
            dg();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int id;
            id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            if (textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "")
            {
                MessageBox.Show("不能为空哦");
            }
            else {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update dealer_info set dealer_name=N'" + textBox6.Text + "',dealer_company_name=N'" + textBox7.Text + "',contact=N'" + textBox8.Text + "',address=N'" + textBox9.Text + "',city=N'" + textBox10.Text + "'where id=" + id + "";
                cmd.ExecuteNonQuery();
                MessageBox.Show("更新成功");
                panel2.Visible = false;
                dg();
            }
            
        }
    }
}
