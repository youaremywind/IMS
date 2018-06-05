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
    public partial class sales : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\新建文件夹\WindowsFormsApp2\mysqltable.mdf;Integrated Security=True");
        DataTable dt = new DataTable();
        int tot = 0;
        public sales()
        {
            InitializeComponent();
        }

        private void sales_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            dt.Clear();
            dt.Columns.Add("product");
            dt.Columns.Add("price");
            dt.Columns.Add("qty");
            dt.Columns.Add("total");


       
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            listBox1.Visible = true;
            listBox1.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from stock where product_name like(N'"+ textBox3.Text +"%') ";
            
            //cmd.CommandText = "select * from stock where product_name like('w%') ";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["product_name"].ToString());
            }
            //MessageBox.Show(cmd.CommandText);
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) {
                listBox1.Focus();
                listBox1.SelectedIndex = 0;

            }
        }

       private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down)
                {
                    this.listBox1.SelectedIndex = this.listBox1.SelectedIndex + 1;

                }
                if(e.KeyCode == Keys.Up)
                {
                    this.listBox1.SelectedIndex = this.listBox1.SelectedIndex - 1;

                }
                if (e.KeyCode == Keys.Enter)
                {
                    textBox3.Text = listBox1.SelectedItem.ToString();
                    listBox1.Visible = false;
                    textBox4.Focus();

                }
            }
            catch (Exception ex) {

            }
        }


        private void textBox4_Enter(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top 1* from purchase_master where product_name=N'"+textBox3.Text+"' order by id desc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox4.Text=dr["product_price"].ToString();
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            try
            {
                textBox6.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox5.Text));
            }
            catch {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int stock = 0;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == ""|| string.IsNullOrEmpty(comboBox1.Text) == true)
            {
                MessageBox.Show("请输入完整再提交");
            }
            else {
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from stock where product_name=N'" + textBox3.Text + "'";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);
                foreach (DataRow dr1 in dt1.Rows)
                {
                    stock = Convert.ToInt32(dr1["product_qty"].ToString());

                }
                if (Convert.ToInt32(textBox5.Text) > stock)
                {
                    MessageBox.Show("这个值不可用");
                }
                else
                {
                    DataRow dr = dt.NewRow();
                    dr["product"] = textBox3.Text;
                    dr["price"] = textBox4.Text;
                    dr["qty"] = textBox5.Text;
                    dr["total"] = textBox6.Text;
                    dt.Rows.Add(dr);
                    dataGridView1.DataSource = dt;
                    tot = tot + Convert.ToInt32(dr["total"].ToString());
                    label10.Text = tot.ToString();
                }
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                tot = 0;
                dt.Rows.RemoveAt(Convert.ToInt32(dataGridView1.CurrentCell .RowIndex.ToString()));
                foreach (DataRow dr1 in dt.Rows) {
                    tot=tot+ Convert.ToInt32(dr1["total"].ToString());
                    label10.Text = tot.ToString();
                }
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string orderid = "";
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "insert into order_user values(N'"+textBox1.Text+"',N'"+textBox2.Text+"',N'"+comboBox1.Text+"',N'"+dateTimePicker1.Value.ToString("dd-MM-yyyy") +"')";
            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select top 1* from order_user order by id desc";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                orderid =dr2["id"].ToString();

            }

            foreach (DataRow dr in dt.Rows) {
                int qty = 0;
                string pname = "";

                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "insert into order_item values(N'" + orderid.ToString() + "',N'" + dr["product"].ToString() + "',N'" + dr["price"].ToString() + "',N'" + dr["qty"].ToString() + "',N'"
                    + dr["total"].ToString() + "',N'" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "')";
                cmd3.ExecuteNonQuery();

                qty = Convert.ToInt32(dr["qty"].ToString());
                pname =dr["product"].ToString();
                SqlCommand cmd6 = con.CreateCommand();
                cmd6.CommandType = CommandType.Text;
                cmd6.CommandText = "update stock set product_qty=product_qty-"+qty+" where product_name=N'"+pname.ToString()+"'";
                cmd6.ExecuteNonQuery();
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            label10.Text = "";

            dt.Clear();
            dataGridView1.DataSource = dt;


            MessageBox.Show("添加成功");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string orderid = "";
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "insert into order_user values(N'" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + comboBox1.Text + "',N'" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "')";
            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select top 1* from order_user order by id desc";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                orderid = dr2["id"].ToString();

            }

            foreach (DataRow dr in dt.Rows)
            {
                int qty = 0;
                string pname = "";

                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "insert into order_item values(N'" + orderid.ToString() + "',N'" + dr["product"].ToString() + "',N'" + dr["price"].ToString() + "',N'" + dr["qty"].ToString() + "',N'" 
                    + dr["total"].ToString() + "',N'" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "')";
                cmd3.ExecuteNonQuery();

                qty = Convert.ToInt32(dr["qty"].ToString());
                pname = dr["product"].ToString();
                SqlCommand cmd6 = con.CreateCommand();
                cmd6.CommandType = CommandType.Text;
                cmd6.CommandText = "update stock set product_qty=product_qty-" + qty + " where product_name=N'" + pname.ToString() + "'";
                cmd6.ExecuteNonQuery();
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            label10.Text = "";

            dt.Clear();
            dataGridView1.DataSource = dt;

            generate_bill1 gb1 = new generate_bill1();
            gb1.get_value(Convert.ToInt32(orderid.ToString()));
            gb1.Show();






        }
    }
}
