using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UserForm1.Forms
{
    public partial class FormKhachHang : Form
    {
        //string select_command = "select * from KHACHHANG";
        SqlConnection conn = new SqlConnection(@"Data Source=.\mssqlserver01;Initial Catalog=Grocery_Management;Integrated Security=True");

        public FormKhachHang()
        {
            InitializeComponent();
            KHTable.DataSource = loaddata().Tables[0];
            KHTable.ClearSelection();
            KHTable.DefaultCellStyle.SelectionBackColor = Color.White;
            KHTable.DefaultCellStyle.SelectionForeColor = Color.Black;

            cbb_sua.SelectedIndex = 0;
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
            if (MAKH_SUA.Text == "KHXX")
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
                MAKH_SUA.Text = "KHXX";
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
            if (ThongTin.Text == "VD: KHXX")
            {
                ThongTin.Text = "";
                ThongTin.ForeColor = Color.Black;
                ThongTin.BackColor = Color.White;
            }
        }
        private void ThongTin_Leave(object sender, EventArgs e)
        {

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


        public bool CheckDeleteData(string user)
        {

            bool flag = false;
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = conn;
                conn.Open();
                command.CommandText = @"select * from KHACHHANG where MAKH ='" + user + "'";
                if (command.ExecuteReader().Read())
                {
                    flag = true;
                }
                conn.Close();
            }

            return flag;

        }

        public bool CheckUpdate(string DuLieuMoi="",string ma_kh="",int selected_index=-1)
        {
            bool flag = true;

            int check = 0;


            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = conn;
                conn.Open();
                command.CommandText = @"select * from KHACHHANG where MAKH ='" + ma_kh + "'";
                if (command.ExecuteReader().Read())
                {
                    //error_list.Add("Mã khách hàng đã tồn tại!");
                }
                else
                {
                    flag = false;

                }
                conn.Close();
            }


            if (ma_kh == "KHXX" && selected_index == -1)
            {
                error_list.Add("Vui lòng chọn thông tin cần sửa!");
                check = 1;
                MAKH_SUA.Text = "KHXX";
                cbb_sua.Text = "";
                DuLieuMoi = "VD: 0355175321";
                flag = false;

            }
            if (DuLieuMoi == "VD: 0355175321")
            {
                error_list.Add("Vui lòng nhập dữ liệu mới!");
                check = 1;

                cbb_sua.Text = "";
                DuLieuMoi = "VD: 0355175321";
                flag = false;
            }
            if (DuLieuMoi == "")
            {
                error_list.Add("Vui lòng nhập dữ liệu mới!");
                check = 1;

                cbb_sua.Text = "";
                DuLieuMoi = "VD: 0355175321";
                flag = false;
            }
            if (check == 1)
                Error_Handler();

            return flag;
        }


        #region buttons 
        //UPDATE
        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            if (CheckUpdate(DuLieuMoi.Text, MAKH_SUA.Text,cbb_sua.SelectedIndex) == false)
            {
                return;
            }

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
                        if (DuLieuMoi.Text.Count() > 50|| DuLieuMoi.Text.CompareTo(string.Empty)==0)
                        {
                            error_list.Add("Họ tên chỉ có tối đa 50 ký tự và không được để trống! ");
                            check = 1;
                        }
                        else
                        {
                            dr[1] = DuLieuMoi.Text;
                            query = "Update KHACHHANG SET HoTen = '" + DuLieuMoi.Text + "' Where MAKH = '" + MAKH_SUA.Text + "'";
                            command.CommandText = query;
                            command.ExecuteNonQuery();
                        }
                    }
                    else if (cbb_sua.Text == "Số ĐT")
                    {
                        if (DuLieuMoi.Text.Count() != 10)
                        {
                            error_list.Add("Số điện thoại cần có 10 ký tự!");
                            check = 1;
                        }
                        else
                        {
                            dr[3] = DuLieuMoi.Text;
                            query = "Update KHACHHANG SET SODT = '" + DuLieuMoi.Text + "' Where MAKH = '" + MAKH_SUA.Text + "'";
                            command.CommandText = query;
                            command.ExecuteNonQuery();
                        }
                    }
                    else if (cbb_sua.Text == "Địa chỉ")
                    {
                        if (DuLieuMoi.Text.Count() != 12)
                        {
                            error_list.Add("CMND cần có 12 ký tự!");
                            check = 1;
                        }
                        else
                        {
                        dr[2] = DuLieuMoi.Text;
                        query = "Update KHACHHANG SET DIACHI = '" + DuLieuMoi.Text + "' Where MAKH = '" + MAKH_SUA.Text + "'";
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                        }

                    }
                   
                    else if (cbb_sua.Text == "CMND")
                    {
                        if (DuLieuMoi.Text.Count() != 12)
                        {
                            error_list.Add("CMND cần có 12 ký tự!");
                            check = 1;
                        }
                        else
                        {
                            dr[6] = DuLieuMoi.Text;
                            query = "Update KHACHHANG SET CMND = '" + DuLieuMoi.Text + "' Where MAKH = '" + MAKH_SUA.Text + "'";
                            command.CommandText = query;
                            command.ExecuteNonQuery();
                        }
                    }

                    Reset();
                    MessageBox.Show("Bạn đã cập nhật thành công!");
                }
            }
            if (flag == false)
            {
                error_list.Add("Không tìm thấy mã khách hàng này!");
                Error_Handler();
            }

            if (MAKH_SUA.Text == "KHXX" && cbb_sua.SelectedIndex == 0)
            {
                error_list.Add("Vui lòng chọn thông tin cần sửa!");
                check = 1;
                MAKH_SUA.Text = "KHXX";
                cbb_sua.Text = "";
                DuLieuMoi.Text = "VD: 0355175321";
            }
            if (DuLieuMoi.Text == "VD: 0355175321")
            {
                error_list.Add("Vui lòng nhập dữ liệu mới!");
                check = 1;

                cbb_sua.Text = "";
                DuLieuMoi.Text = "VD: 0355175321";
            }

            if (check == 1)
                Error_Handler();


            cbb_sua.Text = "";
            DuLieuMoi.Text = "VD: 0355175321";
            DuLieuMoi.ForeColor = Color.FromArgb(180, 180, 180);
            conn.Close();
        }

        public bool CheckData(string id, string hoten, string diachi, string sdt, string cmnd)
        {
            bool check = true;
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = conn;
                conn.Open();
                command.CommandText = @"select * from KHACHHANG where MAKH ='" + id + "'";
                if (command.ExecuteReader().Read())
                {
                    error_list.Add("Mã khách hàng đã tồn tại!");
                    check = false;
                }
                conn.Close();
            }


            if (id == "Mã KH")
            {
                error_list.Add("Vui lòng nhập mã khách hàng!");
                ID.BackColor = Color.FromArgb(254, 184, 177);
                check = false;
            }
            if (id.Count() >= 2)
            {
                if (id.Substring(0, 2) != "KH")
                {
                    error_list.Add("Hai ký tự đầu của mã khách hàng phải là KH!");
                    ID.BackColor = Color.FromArgb(254, 184, 177);
                    check = false;
                }
            }



            if (hoten.Count() > 50)
            {
                error_list.Add("Họ tên chỉ có tối đa 50 ký tự!");
                HoTen.BackColor = Color.FromArgb(254, 184, 177);
                check = false;
            }
            if (hoten == "Họ, tên")
            {
                error_list.Add("Vui lòng nhập họ tên khách hàng!");
                HoTen.BackColor = Color.FromArgb(254, 184, 177);
                check = false;
            }


            if (diachi == "Địa chỉ")
            {
                error_list.Add("Vui lòng nhập địa chỉ!");
                DiaChi.BackColor = Color.FromArgb(254, 184, 177);
                check = false;
            }


            if (sdt == "Số điện thoại")
            {
                error_list.Add("Vui lòng nhập số điện thoại!");
                SDT.BackColor = Color.FromArgb(254, 184, 177);
                check = false;
            }
            if (sdt.Count() != 10)
            {
                error_list.Add("SDT cần có 10 ký tự!");
                SDT.BackColor = Color.FromArgb(254, 184, 177);
                check = false;
            }


            if (cmnd == "CMND")
            {
                error_list.Add("Vui lòng nhập CMND!");
                CMND.BackColor = Color.FromArgb(254, 184, 177);
                check = false;
            }
            if (cmnd.Count() != 12)
            {
                error_list.Add("CMND cần có 12 ký tự!");
                CMND.BackColor = Color.FromArgb(254, 184, 177);
                check = false;
            }

            if (check == false)
            {
                Error_Handler();
            }

            return check;   
        }

        //ADD
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Reset();

            bool check = CheckData(ID.Text, HoTen.Text, DiaChi.Text, SDT.Text, CMND.Text); //Khong co loi 


            if (check == true)
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
                

                reset_tbs();
            }
            //if (check == true)
            //    Error_Handler();
          
            reset_tbs();
        }



        private void reset_tbs()
        {
            HoTen.ForeColor = Color.FromArgb(180, 180, 180);
            ID.ForeColor = Color.FromArgb(180, 180, 180);
            SDT.ForeColor = Color.FromArgb(180, 180, 180);
            DiaChi.ForeColor = Color.FromArgb(180, 180, 180);
            CMND.ForeColor = Color.FromArgb(180, 180, 180);
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
            if (KHTable.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DialogResult choice = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Thông báo!", MessageBoxButtons.YesNo);

                if (choice == DialogResult.Yes)
                {
                    
                    string ma_kh= KHTable[1, KHTable.CurrentCell.RowIndex].Value.ToString();

                    if (CheckDeleteData(ma_kh) == false)
                    {
                        return;
                    }

                    SqlCommand command = new SqlCommand();

                    command.Connection = conn;
                    conn.Open();
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
                    KHTable.Rows[KHTable.CurrentCell.RowIndex].Selected = false;
                    Reset();

                    //KHTable.Rows[KHTable.CurrentCell.RowIndex].Selected = false;
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

        private void DuLieuMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (cbb_sua.Text == "Số ĐT" || cbb_sua.Text == "Doanh số" || cbb_sua.Text == "CMND"))
            {
                e.Handled = true;
            }

        }

        private void KeyPress(object sender, KeyPressEventArgs e)
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

        //Refresh
        private void Refresh_Click(object sender, EventArgs e)
        {
            KHTable.DataSource = loaddata().Tables[0];
            //KHTable.ClearSelection();
            KHTable.DefaultCellStyle.SelectionBackColor = Color.White;
            KHTable.DefaultCellStyle.SelectionForeColor = Color.Black;
            //cbb_sua.SelectedIndex = 0;
            //comboBoxKH.SelectedIndex = 0;
            MAKH_SUA.Text = "KHXX";
            DuLieuMoi.Text = "VD: 0355175321";

            HoTen.ForeColor = Color.FromArgb(180, 180, 180);
            ID.ForeColor = Color.FromArgb(180, 180, 180); 
            SDT.ForeColor = Color.FromArgb(180, 180, 180);
            DiaChi.ForeColor = Color.FromArgb(180, 180, 180);
            CMND.ForeColor = Color.FromArgb(180, 180, 180);

            HoTen.Text = "Họ, tên";
            CMND.Text = "CMND";
            DiaChi.Text = "Địa chỉ";
            SDT.Text = "Số điện thoại";
            ID.Text = "Mã KH";
        }

        private void comboBoxKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThongTin.Text = "";
        }

        private void ThongTin_KeyPress(object sender, KeyPressEventArgs e)
        {
            ThongTin.ForeColor = Color.Black;
        }

        private void cbb_sua_TextChanged(object sender, EventArgs e)
        {
            switch (cbb_sua.SelectedIndex)
            {
                case 0:
                    DuLieuMoi.MaxLength = 40;
                    break;
                case 1:
                    DuLieuMoi.MaxLength = 10;
                    break;
                case 2:
                    DuLieuMoi.MaxLength = 50;
                    break;
                case 3:
                    DuLieuMoi.MaxLength = 12;
                    break;
            }
        }

        private void cbb_sua_SelectedIndexChanged(object sender, EventArgs e)
        {
            DuLieuMoi.Text = "";
        }
    }
}
