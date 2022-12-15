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
    public partial class FormHoaDon : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.DatabaseConnection);

        public FormHoaDon()
        {
            InitializeComponent();
        }

        DataSet Get_all_hoa_don()
        {
            DataSet dt = new DataSet();
            conn.Open();
            string query = "select * from HOADON";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        private void Load_MIN_DateTimePicker()
        {
            DataTable dt = new DataTable();
            //DataSet dt = new DataSet();
            conn.Open();
            string query = "select MIN(NGHD) MIN_NGHD from HOADON";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();

            DataRow dr = dt.Rows[0];
            dateTimePicker.Value = DateTime.Parse(dr["MIN_NGHD"].ToString());
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            conn.Open();
            string query = "select Uname from NHANVIEN";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();

            comboBoxMANV.DisplayMember = "Uname";
            comboBoxMANV.DataSource = dt;

            Load_MIN_DateTimePicker();
            comboBoxMANV.Text = "";
            datagridviewHD.DataSource = Get_all_hoa_don().Tables[0];

            label_SLHD.Text = "SL Hóa đơn: " + datagridviewHD.Rows.Count.ToString();
        }

        private void textBoxGIAHD_Click(object sender, EventArgs e)
        {
            if (textBoxGIAHD.Text == "MIN(vnd)")
            {
                textBoxGIAHD.Text = "";
                textBoxGIAHD.ForeColor = Color.Black;
            }
        }

        private void textBoxGIAHD2_Click(object sender, EventArgs e)
        {
            if (textBoxGIAHD2.Text == "MAX(vnd)")
            {
                textBoxGIAHD2.Text = "";
                textBoxGIAHD2.ForeColor = Color.Black;
            }
        }

        private void textBoxGIAHD_Leave(object sender, EventArgs e)
        {
            if (textBoxGIAHD.Text == "")
            {
                textBoxGIAHD.ForeColor = Color.FromArgb(180, 180, 180);
                textBoxGIAHD.Text = "MIN(vnd)";
            }
        }

        private void textBoxGIAHD2_Leave(object sender, EventArgs e)
        {
            if (textBoxGIAHD2.Text == "")
            {
                textBoxGIAHD2.ForeColor = Color.FromArgb(180, 180, 180);
                textBoxGIAHD2.Text = "MAX(vnd)";
            }
        }

        //private void buttonSelect_all_Click(object sender, EventArgs e)
        //{
        //    comboBoxMANV.Text = "";
        //    Load_MIN_DateTimePicker();
        //    datagridviewHD.DataSource = Get_all_hoa_don().Tables[0];
        //    label_SLHD.Text = "SL HD: " + datagridviewHD.Rows.Count.ToString();
        //}

        private void buttonLam_moi_Click(object sender, EventArgs e)
        {
            textBoxGIAHD.Text = "MIN(vnd)";
            textBoxGIAHD.ForeColor = Color.FromArgb(180, 180, 180);
            textBoxGIAHD2.Text = "MAX(vnd)";
            textBoxGIAHD2.ForeColor = Color.FromArgb(180, 180, 180);
            comboBoxMANV.Text = "";
            textBoxMAKH.Text = "";
            Load_MIN_DateTimePicker();
            datagridviewHD.DataSource = Get_all_hoa_don().Tables[0];
            label_SLHD.Text = "SL Hóa đơn: " + datagridviewHD.Rows.Count.ToString();
        }

        #region Tuong tac chuot button 'Chi tiet'
        private void buttonDetail_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDetail.ForeColor = Color.White;
            buttonDetail.BackColor = Color.LightSkyBlue;
        }

        private void buttonDetail_MouseLeave(object sender, EventArgs e)
        {
            buttonDetail.ForeColor = Color.SteelBlue;
            buttonDetail.BackColor = Color.White;
        }

        private void buttonDetail_MouseUp(object sender, MouseEventArgs e)
        {
            buttonDetail.ForeColor = Color.SteelBlue;
            buttonDetail.BackColor = Color.White;
        }

        private void buttonDetail_MouseMove(object sender, MouseEventArgs e)
        {
            buttonDetail.ForeColor = Color.White;
            buttonDetail.BackColor = Color.CornflowerBlue;
        }
        #endregion

        #region Tuong tac chuot button 'Lam moi'
        private void buttonLam_moi_MouseDown(object sender, MouseEventArgs e)
        {
            buttonLam_moi.ForeColor = Color.White;
            buttonLam_moi.BackColor = Color.LightSkyBlue;
        }

        private void buttonLam_moi_MouseLeave(object sender, EventArgs e)
        {
            buttonLam_moi.ForeColor = Color.SteelBlue;
            buttonLam_moi.BackColor = Color.White;
        }

        private void buttonLam_moi_MouseMove(object sender, MouseEventArgs e)
        {
            buttonLam_moi.ForeColor = Color.White;
            buttonLam_moi.BackColor = Color.CornflowerBlue;
        }

        private void buttonLam_moi_MouseUp(object sender, MouseEventArgs e)
        {
            buttonLam_moi.ForeColor = Color.SteelBlue;
            buttonLam_moi.BackColor = Color.White;
        }
        #endregion

        #region Show CTHD
        private void datagridviewHD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CTHD formCTHD = new CTHD();
            formCTHD.sohd = datagridviewHD.Rows[e.RowIndex].Cells[0].Value.ToString();
            formCTHD.Show();    
        }
        #endregion


        #region THAO TAC FILTER

        private void Filter()
        {
            datagridviewHD.DataSource = null;



            string manv = comboBoxMANV.Text;
            string makh = textBoxMAKH.Text;
            long giamin = -1;
            long giamax = -1;
            if (textBoxGIAHD.Text != "MIN(vnd)")
                giamin = long.Parse(textBoxGIAHD.Text);
            if (textBoxGIAHD2.Text != "MAX(vnd)")
                giamax = long.Parse(textBoxGIAHD2.Text);



            conn.Open();
            DataSet dt = new DataSet();



            if (manv != "")
            {
                if (makh != "")
                {
                    if (giamin != -1)
                    {
                        if (giamax != -1)
                        {
                            string query = "select * from HOADON where NGHD >= '" + dateTimePicker.Value.ToString("yyyy/MM/dd") + "' and MANV = '" + manv + "' and MAKH like '%" + makh + "%' and TRIGIA >= '" + giamin + "' and TRIGIA <= '" + giamax + "' ";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                        }
                        else
                        {
                            string query = "select * from HOADON where NGHD >= '" + dateTimePicker.Value.ToString("yyyy/MM/dd") + "' and MANV = '" + manv + "' and MAKH like '%" + makh + "%' and TRIGIA >= '" + giamin + "'";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                        }
                    }
                    else
                    {
                        if (giamax != -1)
                        {
                            string query = "select * from HOADON where NGHD >= '" + dateTimePicker.Value.ToString("yyyy/MM/dd") + "' and MANV = '" + manv + "' and MAKH like '%" + makh + "%'and TRIGIA <= '" + giamax + "'";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                        }
                        else
                        {
                            string query = "select * from HOADON where NGHD >= '" + dateTimePicker.Value.ToString("yyyy/MM/dd") + "' and MANV = '" + manv + "' and MAKH like '%" + makh + "%'";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                        }
                    }
                }
                else
                {
                    if (giamin != -1)
                    {
                        if (giamax != -1)
                        {
                            string query = "select * from HOADON where NGHD >= '" + dateTimePicker.Value.ToString("yyyy/MM/dd") + "' and MANV = '" + manv + "' and TRIGIA >= '" + giamin + "' and TRIGIA <= '" + giamax + "' ";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                        }
                        else
                        {
                            string query = "select * from HOADON where NGHD >= '" + dateTimePicker.Value.ToString("yyyy/MM/dd") + "' and MANV = '" + manv + "' and TRIGIA >= '" + giamin + "'";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                        }
                    }
                    else
                    {
                        if (giamax != -1)
                        {
                            string query = "select * from HOADON where NGHD >= '" + dateTimePicker.Value.ToString("yyyy/MM/dd") + "' and MANV = '" + manv + "' and TRIGIA <= '" + giamax + "' ";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                        }
                        else
                        {
                            string query = "select * from HOADON where NGHD >= '" + dateTimePicker.Value.ToString("yyyy/MM/dd") + "' and MANV = '" + manv + "'";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                        }
                    }
                }
            }
            else
            {
                if (makh != "")
                {
                    if (giamin != -1)
                    {
                        if (giamax != -1)
                        {
                            string query = "select * from HOADON where NGHD >= '" + dateTimePicker.Value.ToString("yyyy/MM/dd") + "' and MAKH like '%" + makh + "%' and TRIGIA >= '" + giamin + "' and TRIGIA <= '" + giamax + "' ";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                        }
                        else
                        {
                            string query = "select * from HOADON where NGHD >= '" + dateTimePicker.Value.ToString("yyyy/MM/dd") + "' and MAKH like '%" + makh + "%' and TRIGIA >= '" + giamin + "'";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                        }
                    }
                    else
                    {
                        if (giamax != -1)
                        {
                            string query = "select * from HOADON where NGHD >= '" + dateTimePicker.Value.ToString("yyyy/MM/dd") + "' and MAKH like '%" + makh + "%' and TRIGIA <= '" + giamax + "' ";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                        }
                        else
                        {
                            string query = "select * from HOADON where NGHD >= '" + dateTimePicker.Value.ToString("yyyy/MM/dd") + "' and MAKH like '%" + makh + "%'";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                        }
                    }
                }
                else
                {
                    if (giamin != -1)
                    {
                        if (giamax != -1)
                        {
                            string query = "select * from HOADON where NGHD >= '" + dateTimePicker.Value.ToString("yyyy/MM/dd") + "' and TRIGIA >= '" + giamin + "' and TRIGIA <= '" + giamax + "' ";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                        }
                        else
                        {
                            string query = "select * from HOADON where NGHD >= '" + dateTimePicker.Value.ToString("yyyy/MM/dd") + "' and TRIGIA >= '" + giamin + "'";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                        }
                    }
                    else
                    {
                        if (giamax != -1)
                        {
                            string query = "select * from HOADON where NGHD >= '" + dateTimePicker.Value.ToString("yyyy/MM/dd") + "' and TRIGIA <= '" + giamax + "' ";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                        }
                        else
                        {
                            string query = "select * from HOADON where NGHD >= '" + dateTimePicker.Value.ToString("yyyy/MM/dd") + "'";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                        }
                    }
                }
            }
            conn.Close();
            datagridviewHD.DataSource = dt.Tables[0];
            label_SLHD.Text = "SL Hóa đơn: " + datagridviewHD.Rows.Count.ToString();
        }



        private void textBoxGIAHD_TextChanged(object sender, EventArgs e)
        {
            if (textBoxGIAHD.Text != "" && textBoxGIAHD.Text != "MIN(vnd)")
                Filter();
        }



        private void textBoxGIAHD2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxGIAHD2.Text != "" && textBoxGIAHD2.Text != "MAX(vnd)")
                Filter();
        }



        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Filter();
        }



        private void comboBoxMANV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMANV.Text != "")
                Filter();
        }



        private void textBoxMAKH_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMAKH.Text != "")
                Filter();
        }
        #endregion

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            CTHD formCTHD = new CTHD();
            int index = datagridviewHD.SelectedRows[0].Index;
            formCTHD.sohd = datagridviewHD.Rows[index].Cells[0].Value.ToString();
            formCTHD.Show();
        }

        private void textBoxGIAHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxGIAHD.Text.Length == 12)
                e.Handled = false;



            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }



            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }



        private void textBoxGIAHD2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }



            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
