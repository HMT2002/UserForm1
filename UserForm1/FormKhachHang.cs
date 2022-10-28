using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserForm1.Forms
{
    public partial class FormKhachHang : Form
    {
        //string select_command = "select * from KHACHHANG";
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-OENF2126\SQLEXPRESS;Initial Catalog=Grocery_Management;Integrated Security=True");

        public FormKhachHang()
        {
            InitializeComponent();
        }
        DataSet loaddata()
        {
            DataSet data = new DataSet();

            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from KHACHHANG", conn);
            conn.Close();
            adapter.Fill(data);
            KHTable.Refresh();
            return data;
        }
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            KHTable.DataSource = loaddata().Tables[0];
            KHTable.ClearSelection();
            KHTable.DefaultCellStyle.SelectionBackColor = Color.White;
            KHTable.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void KHTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (KHTable.SelectedRows.Count > 0)
            {
                MAKH_SUA.Text = (string)KHTable[1, e.RowIndex].Value;
                ID.Text = (string)KHTable[1, e.RowIndex].Value;
                HoTen.Text = (string)KHTable[2, e.RowIndex].Value;
                SDT.Text = (string)KHTable[4, e.RowIndex].Value;
                DiaChi.Text = (string)KHTable[3, e.RowIndex].Value;
                CMND.Text = (string)KHTable[5, e.RowIndex].Value;
            }
            else
            {
                HoTen.Text = "Họ, tên";
                CMND.Text = "CMND";
                DiaChi.Text = "Địa chỉ";
                SDT.Text = "Số điện thoại";
                ID.Text = "Mã KH";
            }
        }

        #region event_click_leave
        private void textBox1_Click(object sender, EventArgs e)
        {
            if (MAKH_SUA.Text == "KH01")
            {
                MAKH_SUA.Text = "";
                MAKH_SUA.ForeColor = Color.Black;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (MAKH_SUA.Text == "")
            {
                MAKH_SUA.ForeColor = Color.FromArgb(180, 180, 180);
                MAKH_SUA.Text = "KH01";
            }
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            if (DuLieuMoi.Text == "VD: 0355175321")
            {
                DuLieuMoi.Text = "";
                DuLieuMoi.ForeColor = Color.Black;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (DuLieuMoi.Text == "")
            {
                DuLieuMoi.ForeColor = Color.FromArgb(180, 180, 180);
                DuLieuMoi.Text = "VD: 0355175321";
            }
        }
        private void HoTen_Click(object sender, EventArgs e)
        {
            if (HoTen.Text == "Họ, tên")
            {
                HoTen.Text = "";
                HoTen.ForeColor = Color.Black;
                HoTen.BackColor = Color.White;
            }
        }
        private void HoTen_Leave(object sender, EventArgs e)
        {
            if (HoTen.Text == "")
            {
                HoTen.ForeColor = Color.FromArgb(180, 180, 180);
                HoTen.Text = "Họ, tên";
            }
        }
        private void ID_Click(object sender, EventArgs e)
        {
            if (ID.Text == "Mã KH")
            {
                ID.Text = "";
                ID.ForeColor = Color.Black;
                ID.BackColor = Color.White;
            }
        }
        private void ID_Leave(object sender, EventArgs e)
        {
            if (ID.Text == "")
            {
                ID.ForeColor = Color.FromArgb(180, 180, 180);
                ID.Text = "Mã KH";
            }
        }
        private void SDT_Click(object sender, EventArgs e)
        {
            if (SDT.Text == "Số điện thoại")
            {
                SDT.Text = "";
                SDT.ForeColor = Color.Black;
                SDT.BackColor = Color.White;
            }
        }
        private void SDT_Leave(object sender, EventArgs e)
        {
            if (SDT.Text == "")
            {
                SDT.ForeColor = Color.FromArgb(180, 180, 180);
                SDT.Text = "Số điện thoại";
            }
        }
        private void DiaChi_Click(object sender, EventArgs e)
        {
            if (DiaChi.Text == "Địa chỉ")
            {
                DiaChi.Text = "";
                DiaChi.ForeColor = Color.Black;
                DiaChi.BackColor = Color.White;
            }
        }
        private void DiaChi_Leave(object sender, EventArgs e)
        {
            if (DiaChi.Text == "")
            {
                DiaChi.ForeColor = Color.FromArgb(180, 180, 180);
                DiaChi.Text = "Địa chỉ";
            }
        }
        private void ThongTin_Click(object sender, EventArgs e)
        {
            if (ThongTin.Text == "VD: KH01")
            {
                ThongTin.Text = "";
                ThongTin.ForeColor = Color.Black;
                ThongTin.BackColor = Color.White;
            }
        }
        private void ThongTin_Leave(object sender, EventArgs e)
        {
            if (ThongTin.Text == "")
            {
                ThongTin.ForeColor = Color.FromArgb(180, 180, 180);
                ThongTin.Text = "VD: KH01";
            }
        }
        private void CMND_Click(object sender, EventArgs e)
        {
            if (CMND.Text == "CMND")
            {
                CMND.Text = "";
                CMND.ForeColor = Color.Black;
                CMND.BackColor = Color.White;
            }
        }
        private void CMND_Leave(object sender, EventArgs e)
        {
            if (CMND.Text == "")
            {
                CMND.ForeColor = Color.FromArgb(180, 180, 180);
                CMND.Text = "CMND";
            }
        }


        private void buttonAdd_MouseDown(object sender, MouseEventArgs e)
        {
            buttonAdd.ForeColor = Color.White;
            buttonAdd.BackColor = Color.LightSkyBlue;
        }

        private void buttonAdd_MouseUp(object sender, MouseEventArgs e)
        {
            buttonAdd.ForeColor = Color.SteelBlue;
            buttonAdd.BackColor = Color.White;
        }

        private void buttonAdd_MouseLeave(object sender, EventArgs e)
        {
            buttonAdd.ForeColor = Color.SteelBlue;
            buttonAdd.BackColor = Color.White;
        }

        private void buttonAdd_MouseMove(object sender, MouseEventArgs e)
        {
            buttonAdd.ForeColor = Color.White;
            buttonAdd.BackColor = Color.CornflowerBlue;
        }

        private void buttonUpdate_MouseDown(object sender, MouseEventArgs e)
        {
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.BackColor = Color.LightSkyBlue;
        }

        private void buttonUpdate_MouseLeave(object sender, EventArgs e)
        {
            buttonUpdate.ForeColor = Color.SteelBlue;
            buttonUpdate.BackColor = Color.White;
        }

        private void buttonUpdate_MouseMove(object sender, MouseEventArgs e)
        {
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.BackColor = Color.CornflowerBlue;
        }

        private void buttonUpdate_MouseUp(object sender, MouseEventArgs e)
        {
            buttonUpdate.ForeColor = Color.SteelBlue;
            buttonUpdate.BackColor = Color.White;
        }
        #endregion

        #region buttons 
        //UPDATE
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            DataTable dt = KHTable.DataSource as DataTable;
            bool flag = false;
            string query = "";
            int check = 0; //Khong co loi

            foreach (DataRow dr in dt.Rows)
            {
                if (MAKH_SUA.Text == dr[0].ToString())
                {
                    flag = true;
                    if (cbb_sua.Text == "Họ tên")
                    {
                        if (DuLieuMoi.Text.Count() > 50)
                        {
                            error_list.Add("Họ tên chỉ có tối đa 50 ký tự!");
                            check = 1;
                        }
                        dr[1] = DuLieuMoi.Text;
                        query = "Update KHACHHANG SET HoTen = '" + DuLieuMoi.Text + "' Where MAKH = '" + MAKH_SUA.Text + "'";
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                    }
                    else if (cbb_sua.Text == "Số ĐT")
                    {
                        if (DuLieuMoi.Text.Count() != 10)
                        {
                            error_list.Add("Số điện thoại cần có 10 ký tự!");
                            check = 1;
                        }
                        dr[2] = DuLieuMoi.Text;
                        query = "Update KHACHHANG SET SODT = '" + DuLieuMoi.Text + "' Where MAKH = '" + MAKH_SUA.Text + "'";
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                    }
                    else if (cbb_sua.Text == "Địa chỉ")
                    {
                        dr[3] = DuLieuMoi.Text;
                        query = "Update KHACHHANG SET DIACHI = '" + DuLieuMoi.Text + "' Where MAKH = '" + MAKH_SUA.Text + "'";
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                    }
                    else if (cbb_sua.Text == "Doanh số")
                    {
                        dr[4] = DuLieuMoi.Text;
                        query = "Update KHACHHANG SET DOANHSO = '" + DuLieuMoi.Text + "' Where MAKH = '" + MAKH_SUA.Text + "'";
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                    }
                    else if (cbb_sua.Text == "Ngày ĐK")
                    {
                        dr[5] = DuLieuMoi.Text;
                        query = "Update KHACHHANG SET NGDK = '" + DuLieuMoi.Text + "' Where MAKH = '" + MAKH_SUA.Text + "'";
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                    }
                    else if (cbb_sua.Text == "CMND")
                    {
                        if (CMND.Text.Count() != 12)
                        {
                            error_list.Add("CMND cần có 12 ký tự!");
                            check = 1;
                        }
                        dr[6] = DuLieuMoi.Text;
                        query = "Update KHACHHANG SET CMND = '" + DuLieuMoi.Text + "' Where MAKH = '" + MAKH_SUA.Text + "'";
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                    }
                }
            }
            if (flag == false)
            {
                error_list.Add("Không tìm thấy mã khách hàng này!");
                Error_Handler();
            }
            if (check == 1)
                Error_Handler();
            MAKH_SUA.Text = "";
            cbb_sua.Text = "";
            DuLieuMoi.Text = "";
            conn.Close();
        }

        //ADD
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int check = 0; //Khong co loi 
            DataTable dataTable = KHTable.DataSource as DataTable;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (ID.Text == dataRow[0].ToString())
                {
                    error_list.Add("Mã khách hàng đã tồn tại!");
                    check = 1;
                }
            }

            if(ID.Text == "Mã KH")
            {
                error_list.Add("Vui lòng nhập mã khách hàng!");
                ID.BackColor = Color.FromArgb(254, 184, 177);
                check = 1;
            }
            if (ID.Text.Substring(0, 2) != "KH")
            {
                error_list.Add("Hai ký tự đầu của mã khách hàng phải là KH!");
                ID.BackColor = Color.FromArgb(254, 184, 177);
                check = 1;
            }
                

            if (HoTen.Text.Count() > 50)
            {
                error_list.Add("Họ tên chỉ có tối đa 50 ký tự!");
                HoTen.BackColor = Color.FromArgb(254, 184, 177);
                check = 1;
            }
            if (HoTen.Text == "Họ, tên")
            {
                error_list.Add("Vui lòng nhập họ tên khách hàng!");
                HoTen.BackColor = Color.FromArgb(254, 184, 177);
                check = 1;
            }


            if (DiaChi.Text == "Địa chỉ")
            {
                error_list.Add("Vui lòng nhập địa chỉ!");
                DiaChi.BackColor = Color.FromArgb(254, 184, 177);
                check = 1;
            }


            if (SDT.Text == "Số điện thoại")
            {
                error_list.Add("Vui lòng nhập số điện thoại!");
                SDT.BackColor = Color.FromArgb(254, 184, 177);
                check = 1;
            }
            if (SDT.Text.Count() != 10)
            {
                error_list.Add("SDT cần có 10 ký tự!");
                SDT.BackColor = Color.FromArgb(254, 184, 177);
                check = 1;
            }


            if (CMND.Text == "CMND")
            {
                error_list.Add("Vui lòng nhập CMND!");
                CMND.BackColor = Color.FromArgb(254, 184, 177);
                check = 1;
            }
            if (CMND.Text.Count() != 12)
            {
                error_list.Add("CMND cần có 12 ký tự!");
                CMND.BackColor = Color.FromArgb(254, 184, 177);
                check = 1;
            }
            if (check == 0)
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                string NGAYDK = DateTime.Now.ToShortDateString();
                command.CommandText = "insert into KHACHHANG (MAKH,HOTEN,DIACHI,SODT,NGDK,CMND)" +
                            "values(@makh,@hoten,@diachi, @sdt,@ngdk,@cmnd)";
                command.Parameters.Add("@makh", SqlDbType.VarChar).Value = ID.Text;
                command.Parameters.Add("@hoten", SqlDbType.VarChar).Value = HoTen.Text;
                command.Parameters.Add("@diachi", SqlDbType.VarChar).Value = DiaChi.Text;
                command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = SDT.Text;
                command.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = CMND.Text;
                command.Parameters.Add("@ngdk", SqlDbType.DateTime).Value = NGAYDK;
                command.ExecuteNonQuery();

                MessageBox.Show("Bạn đã thêm thành công!");
                conn.Close();
                KHTable.Rows[KHTable.CurrentCell.RowIndex].Selected = false;
                KHTable.Rows[KHTable.Rows.Count - 1].Selected = true;
                KHTable.DataSource = loaddata().Tables[0];
                Reset();
            }
            if (check == 1)
                Error_Handler();
        }

        //FILTER
        private void ThongTin_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxKH.Text == "Mã KH")
            {
                (KHTable.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("MAKH like '%" + ThongTin.Text + "%'");
            }
            else if (comboBoxKH.Text == "Họ tên")
            {
                (KHTable.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("HOTEN like '%" + ThongTin.Text + "%'");
            }
            else if (comboBoxKH.Text == "Số điện thoại")
            {
                (KHTable.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("SODT like '%" + ThongTin.Text + "%'");
            }
            else if (comboBoxKH.Text == "Địa chỉ")
            {
                (KHTable.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("DIACHI like '%" + ThongTin.Text + "%'");
            }
            else if (comboBoxKH.Text == "CMND")
            {
                (KHTable.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("CMND like '%" + ThongTin.Text + "%'");
            }
            else if (comboBoxKH.Text == "--All")
            {
                KHTable.DataSource = loaddata().Tables[0];
            }
        }

        //DELETE
        private void KHTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KHTable.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            KHTable.DefaultCellStyle.SelectionForeColor = Color.White;
            conn.Open();
            if (KHTable.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DialogResult choice = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Thông báo!", MessageBoxButtons.YesNo);

                if (choice == DialogResult.Yes)
                {
                    
                    SqlCommand command = new SqlCommand();

                    command.Connection = conn;
                    
                    try
                    {
                        command.CommandText = "delete from KHACHHANG where MAKH = @makh";

                        command.Parameters.Add("@makh", SqlDbType.Char).Value = KHTable[1, KHTable.CurrentCell.RowIndex].Value;
                        
                    }
                    catch (IndexOutOfRangeException er)
                    {
                        MessageBox.Show(er.Message);
                    }
                    int rowCount = command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Xóa khách hàng thành công!");
                    KHTable.DataSource = loaddata().Tables[0];
                }
            }
            conn.Close();
        }
        #endregion

        #region Error 
        List<string> error_list = new List<string>();
        private void Error_Handler()
        {
            if (ErrorTable.Visible == false)
            {
                foreach (string a in error_list)
                {
                    ErrorTable.Rows.Add("*" + a);
                }

                ErrorTable.CurrentCell.Selected = false;
                ErrorTable.Visible = true;
                ErrorTable.Enabled = true;
            }
        }
        private void ErrorTable_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            HoTen.BackColor = Color.White;
            ID.BackColor = Color.White;
            DiaChi.BackColor = Color.White;
            CMND.BackColor = Color.White;
            SDT.BackColor = Color.White;
            ThongTin.BackColor = Color.White;
            MAKH_SUA.BackColor = Color.White;
            DuLieuMoi.BackColor = Color.White;
            

            ErrorTable.Visible = false;
            ErrorTable.Enabled = false;
            ErrorTable.Rows.Clear();
            ErrorTable.Refresh();
            error_list.Clear();
        }
        #endregion

        
    }
}
