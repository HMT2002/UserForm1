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

namespace UserForm1.Forms
{
    public partial class CTHD : Form
    {
        public CTHD()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=.\mssqlserver01;Initial Catalog=Grocery_Management;Integrated Security=True");
        public string sohd;

        private void CTHD_Load(object sender, EventArgs e)
        {
            Load_label_NV();
            Load_label_KH();
            Load_gridview();
        }

        private void Load_label_NV()
        {
            DataTable dt = new DataTable();
            conn.Open();
            string query = "select Fname, NGHD, TRIGIA from NHANVIEN a, HOADON b where a.Uname = b.MANV and b.SOHD = " + sohd;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            labelNVien.Text = dt.Rows[0].ItemArray[0].ToString();
            label_SoHD.Text = "So HD: " + sohd;
            labelNgayHD.Text = dt.Rows[0].ItemArray[1].ToString();
            label_TongTien.Text = dt.Rows[0].ItemArray[2].ToString() + "đ";

            conn.Close();
        }

        private void Load_label_KH()
        {
            conn.Open();
            DataTable dt = new DataTable();
            string query = "select hoten from KHACHHANG a, HOADON b where a.MAKH = b.MAKH and b.SOHD = " + sohd;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
                labelKHang.Text = dt.Rows[0].ItemArray[0].ToString();
            else
                labelKHang.Text = "";

            conn.Close();
        }

        private void Load_gridview()
        {
            conn.Open();
            DataTable dt = new DataTable();
            string query = "select TENSP, SL, (SL*GIA) TRIGIA from SANPHAM a, CTHD b where a.MASP = b.MASP and b.SOHD = " + sohd;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView_CTHD.DataSource = dt;

            conn.Close();
        }
    }
}
