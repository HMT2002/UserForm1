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
    public partial class FormThongKe : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.DatabaseConnection);
        public FormThongKe()
        {
            InitializeComponent();
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Montserrat", 12, FontStyle.Regular);
            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Montserrat", 12, FontStyle.Regular);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Montserrat", 12, FontStyle.Regular);
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Montserrat", 12, FontStyle.Regular);
            chart1.ChartAreas[0].AxisX.Minimum = 1;

            chart2.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Montserrat", 12, FontStyle.Regular);
            chart2.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Montserrat", 12, FontStyle.Regular);
            chart2.ChartAreas[0].AxisY.TitleFont = new Font("Montserrat", 12, FontStyle.Regular);
            chart2.ChartAreas[0].AxisX.TitleFont = new Font("Montserrat", 12, FontStyle.Regular);

            chart3.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart3.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart3.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Montserrat", 9, FontStyle.Regular);
            chart3.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Montserrat", 9, FontStyle.Regular);
            chart3.ChartAreas[0].AxisY.TitleFont = new Font("Montserrat", 12, FontStyle.Regular);
            chart3.ChartAreas[0].AxisX.TitleFont = new Font("Montserrat", 12, FontStyle.Regular);

            load_chart_doanhthu();
            load_chart_sanpham();
            Load_Chart3();
        }

        string year = "2021";

        private void load_chart_doanhthu()
        {
            DataTable dt = new DataTable();
            conn.Open();
            string query = "select month(NGHD) thang, Sum(TRIGIA)/1000 doanh_thu from HOADON where year(NGHD) = " + year + "group by month(NGHD)";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(dt);
            conn.Close();
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu (nghìn Vnđ)";
            chart1.Series["Số tiền"].Color = Color.SteelBlue;

            for (int i = 0; i < dt.Rows.Count; i++) 
            {
                chart1.Series["Số tiền"].Points.AddXY(dt.Rows[i]["thang"], dt.Rows[i]["doanh_thu"]);
            }
        }

        private void load_chart_sanpham()
        {
            DataTable dt = new DataTable();
            conn.Open();
            string query = "select sum(SL) SL_DaBan from CTHD where MASP like 'GD%'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(dt);

            int SL_GD = int.Parse(dt.Rows[0]["SL_DaBan"].ToString());

            dt.Rows.Clear();
            query = "select sum(SL) SL_DaBan from CTHD where MASP like 'MP%'";
            da = new SqlDataAdapter(query, conn);
            da.Fill(dt);

            int SL_MP = int.Parse(dt.Rows[0]["SL_DaBan"].ToString());

            dt.Rows.Clear();
            query = "select sum(SL) SL_DaBan from CTHD where MASP like 'TP%'";
            da = new SqlDataAdapter(query, conn);
            da.Fill(dt);
            conn.Close();

            int SL_TP = int.Parse(dt.Rows[0]["SL_DaBan"].ToString());

            chart2.Series["SL_SP"].Points.AddXY("GD", SL_GD);
            chart2.Series["SL_SP"].Points.AddXY("NT", SL_MP);
            chart2.Series["SL_SP"].Points.AddXY("TP", SL_TP);
        }

        private void Load_Chart3()
        {
            DataTable dt = new DataTable();
            conn.Open();
            string query = "select Month(NGHD) thang, Sum(SL) SL from HOADON, CTHD where HOADON.SOHD = CTHD.SOHD and CTHD.MASP like 'GD%' and year(NGHD) = " + year + "group by month(NGHD)";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(dt);
            chart3.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chart3.ChartAreas["ChartArea1"].AxisY.Title = "SL";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chart3.Series["Gia dụng"].Points.AddXY(dt.Rows[i]["thang"], dt.Rows[i]["SL"]);
            }

            dt.Rows.Clear();
            query = "select Month(NGHD) thang, Sum(SL) SL from HOADON, CTHD where HOADON.SOHD = CTHD.SOHD and CTHD.MASP like 'MP%' and year(NGHD) = " + year + "group by month(NGHD)";
            da = new SqlDataAdapter(query, conn);
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chart3.Series["Nội thất"].Points.AddXY(dt.Rows[i]["thang"], dt.Rows[i]["SL"]);
            }

            dt.Rows.Clear();
            query = "select Month(NGHD) thang, Sum(SL) SL from HOADON, CTHD where HOADON.SOHD = CTHD.SOHD and CTHD.MASP like 'TP%' and year(NGHD) = " + year + "group by month(NGHD)";
            da = new SqlDataAdapter(query, conn);
            da.Fill(dt);
            conn.Close();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chart3.Series["Thực phẩm"].Points.AddXY(dt.Rows[i]["thang"], dt.Rows[i]["SL"]);
            }
        }

        private void FormCaiDat_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            conn.Open();
            string query = "select distinct Year(NGHD) from hoadon";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(dt);
            conn.Close();

            for (int i = 0; i < dt.Rows.Count; i++)
                domainUpDown1.Items.Add(dt.Rows[i][0].ToString());

            domainUpDown1.Text = dt.Rows[0][0].ToString();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            year = domainUpDown1.Text;
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in chart3.Series)
            {
                series.Points.Clear();
            }
            load_chart_doanhthu();
            Load_Chart3();
        }
    }
}
