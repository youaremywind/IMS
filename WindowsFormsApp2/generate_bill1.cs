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
    public partial class generate_bill1 : Form
    {
        int j;
        int tot = 0;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\新建文件夹\WindowsFormsApp2\mysqltable.mdf;Integrated Security=True");
        public generate_bill1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void generate_bill1_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            DataSet2 ds = new DataSet2();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from order_user where id=" + j + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.DataTable1);

            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from order_item where order_id=" + j + "";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(ds.DataTable2);
            da2.Fill(dt2);

            tot = 0;
            foreach (DataRow dr2 in dt2.Rows)
            {
                tot = tot + Convert.ToInt32(dr2["total"].ToString());
               
            }

            CrystalReport1 myr = new CrystalReport1();
            myr.SetDataSource(ds);
            myr.SetParameterValue("total", tot.ToString());
            crystalReportViewer1.ReportSource = myr;

        }
        public void get_value(int i) {
            j = i;

        }
    }
}
