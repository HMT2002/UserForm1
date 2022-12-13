using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace UserForm1.Forms
{
    public partial class FormBanHang : Form
    {
        string temp = "";
        public FormBanHang(string temp)
        {
            InitializeComponent();
            this.temp = temp;
        }
    
        DataTable dt = new DataTable();
        

        private void button2_Click(object sender, EventArgs e)
        {

        }

        void GetSHD()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\mssqlserver01;Initial Catalog=Grocery_Management;Integrated Security=True");
            con.Open();

            string query = "Select count(SOHD) from HOADON";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            DataRow dr = table.Rows[0];
            string SL = dr[0].ToString();
            int sl = 1020 + int.Parse(SL);
            sl += 1;
            txtBSHD.Text = sl.ToString();

            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            SPTable.AutoGenerateColumns = false;
            dt.Columns.Add("#", typeof(string));
            dt.Columns.Add("MASP",typeof(string));
            dt.Columns.Add("TENSP", typeof(string));
            dt.Columns.Add("GIA", typeof(string));
            dt.Columns.Add("SOLUONG", typeof(string));
            dt.Columns.Add("THANHTIEN", typeof(string));

            dt.Columns[0].AutoIncrement = true;
            dt.Columns[0].AutoIncrementSeed = 1;
            dt.Columns[0].AutoIncrementStep = 1;

            SPTable.Columns[0].DataPropertyName = "#";
            SPTable.Columns[1].DataPropertyName = "MASP";
            SPTable.Columns[2].DataPropertyName = "TENSP";
            SPTable.Columns[3].DataPropertyName = "GIA";
            SPTable.Columns[4].DataPropertyName = "SOLUONG";
            SPTable.Columns[5].DataPropertyName = "THANHTIEN";

            
            GetSHD();

            lbMANV.Text = temp;

            datetimeNHD.Value = DateTime.Now;
        }

                
        private void SPTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in SPTable.SelectedRows)
                {
                    Plus_SL(row);
                    SPTable.Rows.RemoveAt(row.Index);
                    
                }

            }
            textBoxTriGia.Text = TinhTongTien().ToString("###,##0") + "đ";
        }


        private int TinhTongTien()
        {
            int s = 0;
            for(int i = 0;i<SPTable.Rows.Count;i++)
            {
                int tien = Convert.ToInt32(SPTable.Rows[i].Cells[5].Value);
                s += tien;
            }
            return s;
        }

        private int TinhTienThua()
        {
            string TienNhan = textBoxTienNhan.Text.Remove(textBoxTienNhan.Text.IndexOf("đ"));
            TienNhan = TienNhan.Replace(",", "");
            int a = int.Parse(TienNhan);

            string TriGia = textBoxTriGia.Text.Remove(textBoxTriGia.Text.IndexOf("đ"));
            TriGia = TriGia.Replace(",", "");
            int b = int.Parse(TriGia);

            return a - b;
        }

        bool MASP_exists(string masp)
        {
            foreach(DataGridViewRow dr in SPTable.Rows)
            {
                if (dr.Cells[1].Value.ToString() == masp)
                    return true;
            }
            return false;
        }

        void Show_Error()
        {
            try
            {
            //ErrorTable.CurrentCell.Selected = false;
            ErrorTable.Visible = true;
            }
            catch
            {

            }

            
        }
        
        void Clear_Error()
        {
            ErrorTable.Rows.Clear();
            ErrorTable.Refresh();
            ErrorTable.Visible = false;
        }

        public bool CheckAddCart()
        {
            Clear_Error();                           

            bool flag = true;

            #region check loi


            // Check sl sản phẩm còn trong kho                                
            if (Subtract_SL() == false)
            {
                panel3.BackColor = Color.FromArgb(254, 184, 177);
                txtBSL.BackColor = Color.FromArgb(254, 184, 177);
                ErrorTable.Rows.Add("Số lượng sản phẩm không đủ");
                flag = false;

            }
            //Neu MASP ko ton tai
            if (cbbMaSP.FindString(cbbMaSP.Text) == -1 || string.IsNullOrEmpty(cbbMaSP.Text))
            {
                cbbMaSP.BackColor = Color.FromArgb(254, 184, 177);
                ErrorTable.Rows.Add("Mã sản phẩm không hợp lệ");
                flag = false;

            }

            #endregion

            if (flag == false)
            {
                Show_Error();
            }

            return flag;
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckAddCart() == false)
            {
                return;
            }

//            bool flag = true;
#region check loi
                                    

//            // Check sl sản phẩm còn trong kho                                
//            if (Subtract_SL() == false)
//            {
//                panel3.BackColor = Color.FromArgb(254, 184, 177);
//                txtBSL.BackColor = Color.FromArgb(254, 184, 177);
//                ErrorTable.Rows.Add("Số lượng sản phẩm không đủ");               
//                flag = false;
                
//            }
//            //Neu MASP ko ton tai
//            if (cbbMaSP.FindString(cbbMaSP.Text) == -1 || string.IsNullOrEmpty(cbbMaSP.Text))
//            {
//                cbbMaSP.BackColor = Color.FromArgb(254, 184, 177);
//                ErrorTable.Rows.Add("Mã sản phẩm không hợp lệ");                                
//                flag = false;
                
//            }

            #endregion
//            if (flag == false)  
//            {
//                Show_Error();
//                return;
//            }

            SqlConnection con = new SqlConnection(@"Data Source=.\mssqlserver01;Initial Catalog=Grocery_Management;Integrated Security=True");
            con.Open();

            string query = "Select * from SANPHAM where MASP = '" + cbbMaSP.Text + "'";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            //TH MASP ko thay đổi thì + thêm số lượng vào datagridview
            if (MASP_exists(cbbMaSP.SelectedItem.ToString()))
            {
                //Tìm row nào trong Datagridview trùng MASP để + số lượng
                DataTable table = SPTable.DataSource as DataTable;
                foreach (DataRow dr in table.Rows)
                {
                    if (dr[1].ToString() == cbbMaSP.SelectedItem.ToString())
                    {
                        int sl = int.Parse(dr[4].ToString());
                        sl += int.Parse(txtBSL.Text);
                        dr[4] = sl.ToString();

                        string temp = dr[3].ToString(); //dr[3] vì đây la datatable lấy từ datagridview
                        temp = temp.Remove(temp.IndexOf("."));
                        int gia = int.Parse(temp);
                        int thanhtien = gia * sl;

                        dr[5] = thanhtien.ToString();
                        textBoxTriGia.Text = TinhTongTien().ToString("###,##0") + "đ";
                        break;
                    }
                }
            }
            else
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataRow dr = table.Rows[0];

                //dr[2] = GIA 
                //cập nhật giá trị thành tiền
                string temp = dr[2].ToString(); //dr[2] vì datatable không có cột #
                temp = temp.Remove(temp.IndexOf("."));
                int gia = int.Parse(temp);
                int sl = int.Parse(txtBSL.Text);
                int thanhtien = gia * sl;

                dt.Rows.Add(null, cbbMaSP.Text, txtBTenSP.Text, dr[2].ToString(), txtBSL.Text, thanhtien.ToString());
                SPTable.DataSource = dt;
                con.Close();
                textBoxTriGia.Text = TinhTongTien().ToString("###,##0") + "đ";
            }
        }
                    
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            panel3.BackColor = Color.White;
            txtBSL.BackColor = Color.White;
            SqlConnection con = new SqlConnection(@"Data Source=.\mssqlserver01;Initial Catalog=Grocery_Management;Integrated Security=True");
            con.Open();

            string query = "Select * from SANPHAM where MASP = '" + cbbMaSP.Text + "'";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataRow dr = table.Rows[0];

            txtBTenSP.Text = dr[1].ToString();
            con.Close();
            }
            catch
            {

            }

        }

        void InsertCTHD(DataRow dr)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\mssqlserver01;Initial Catalog=Grocery_Management;Integrated Security=True");
            con.Open();
            string query = "insert into CTHD values (@sohd,@masp,@sl)";
            SqlCommand command = new SqlCommand(query, con);

            
            command.Parameters.Add("@sohd", SqlDbType.Int).Value = int.Parse(txtBSHD.Text);
            command.Parameters.Add("@masp", SqlDbType.Char).Value = dr[1];
            command.Parameters.Add("@sl", SqlDbType.Int).Value = int.Parse(dr[4].ToString());
            command.ExecuteNonQuery();
            con.Close();
        }

        bool check_MAKH(string makh)
        {
            bool temp = false;

            SqlConnection con = new SqlConnection(@"Data Source=.\mssqlserver01;Initial Catalog=Grocery_Management;Integrated Security=True");
            con.Open();
            string query = "SELECT MAKH FROM KHACHHANG";
            SqlCommand command = new SqlCommand(query, con);
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (dataRow[0].ToString() == makh)
                {
                    temp = true;
                    break;
                }
            }
            con.Close();
            return temp;

        }
        void InsertHoaDon()
        {
            datetimeNHD.Value = DateTime.Now;

            SqlConnection con = new SqlConnection(@"Data Source=.\mssqlserver01;Initial Catalog=Grocery_Management;Integrated Security=True");
            con.Open();
            string query = "insert into HOADON values (@sohd,@nghd,@makh,@manv,@trigia)";

            SqlCommand command = new SqlCommand(query,con);
            command.Parameters.Add("@sohd", SqlDbType.Int).Value = int.Parse(txtBSHD.Text);
            command.Parameters.Add("@nghd", SqlDbType.SmallDateTime).Value = datetimeNHD.Value;

            if (string.IsNullOrEmpty(txtbMAKH.Text ))
                command.Parameters.Add("@makh", SqlDbType.Char).Value = DBNull.Value;
            else
                command.Parameters.Add("@makh", SqlDbType.Char).Value = txtbMAKH.Text;

            command.Parameters.Add("@manv", SqlDbType.Char).Value = lbMANV.Text;
            int index = textBoxTriGia.Text.IndexOf("đ");
            command.Parameters.Add("@trigia", SqlDbType.Money).Value = Convert.ToDecimal(textBoxTriGia.Text.Remove(index));

            command.ExecuteNonQuery();
            con.Close();
        }

        bool Subtract_SL()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\mssqlserver01;Initial Catalog=Grocery_Management;Integrated Security=True");
                con.Open();

                // Check sl sản phẩm còn trong kho
                string query = "UPDATE SANPHAM SET SOLUONG = SOLUONG - " + txtBSL.Text + " where MASP = '" + cbbMaSP.Text + "'";
                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        void Plus_SL(DataGridViewRow viewRow)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\mssqlserver01;Initial Catalog=Grocery_Management;Integrated Security=True");
            con.Open();

            // Check sl sản phẩm còn trong kho
            string query = "UPDATE SANPHAM SET SOLUONG = SOLUONG + " + viewRow.Cells[4].Value + " where MASP = '" + viewRow.Cells[1].Value + "'";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flag = true;


            Clear_Error();
            if (MessageBox.Show("Bạn có chắc muốn tính tiền và in hóa đơn?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {                                   
                    //list bán hàng rỗng 
                if(SPTable.RowCount == 0)
                {
                    ErrorTable.Rows.Add("Vui lòng thêm sản phẩm để thanh toán");
                    flag = false;
                }

                if(!string.IsNullOrEmpty(txtbMAKH.Text))
                {
                    if(check_MAKH(txtbMAKH.Text)==false)
                    {
                        flag = false;
                        txtbMAKH.BackColor = Color.FromArgb(254, 184, 177);
                        panel4.BackColor = Color.FromArgb(254, 184, 177);
                        ErrorTable.Rows.Add("Mã khách hàng không hợp lệ");
                    }
                }

                if (string.IsNullOrEmpty(textBoxTienNhan.Text))
                {
                    textBoxTienNhan.BackColor = Color.FromArgb(254, 184, 177);
                    ErrorTable.Rows.Add("Tiền nhận không hợp lệ");
                    flag = false;
                }
                else if (TinhTienThua() < 0)
                {

                    ErrorTable.Rows.Add("*Tiền nhận không được nhỏ hơn trị giá hóa đơn");
                    textBoxTienNhan.BackColor = Color.FromArgb(254, 184, 177);                    
                    flag = false;
                }


                if (flag == false)
                {
                    Show_Error();
                    return;
                }
                InsertHoaDon();
                DataTable dt;
                dt = (DataTable)SPTable.DataSource;
                foreach (DataRow dr in dt.Rows)
                {
                    InsertCTHD(dr);
                }
                MessageBox.Show("Tính tiền hoàn tất!");
                GetSHD();
                cbbMaSP.Text = "";
                txtBTenSP.Text = "";
                textBoxTriGia.Text = "0đ";
                textBoxTienNhan.Text = "0đ";
                textBoxTienTraLai.Text = "0đ";
                txtBSL.Text = "1";
                dt.Clear();
                
                
            }
        }

        

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            FormBarcode formBarcode = new FormBarcode(this);
            formBarcode.Show();
        }
       private void textBoxTienNhan_Leave(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBoxTienNhan.Text) && textBoxTienNhan.Text.Contains("đ") == false)
            {
                int a = int.Parse(textBoxTienNhan.Text);
                textBoxTienNhan.Text = a.ToString("###,##0") + "đ";
            }
        }

        private void textBoxTienNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            //sau khi nhap tien thi nhấn enter => gọi event Leave
            if (e.KeyChar == (char)13)
            {
                Clear_Error();
                textBoxTienNhan_Leave(sender, e);
                //Check neu tien nhan < tong tien
                if (TinhTienThua() < 0)
                {
                    
                    ErrorTable.Rows.Add("*Tiền nhận không được nhỏ hơn trị giá hóa đơn");
                    textBoxTienNhan.BackColor = Color.FromArgb(254, 184, 177);
                    Show_Error();
                    return;
                }
                textBoxTienTraLai.Text = TinhTienThua().ToString("###,##0") + "đ";
            }
        }

        private void textBoxTienNhan_Enter(object sender, EventArgs e)
        {
            
            textBoxTienNhan.BackColor = Color.White;
            if(!string.IsNullOrEmpty(textBoxTienNhan.Text))
            {
                string text = textBoxTienNhan.Text.Remove(textBoxTienNhan.Text.IndexOf('đ'));
                text = text.Replace(",", "");
                textBoxTienNhan.Text = text;
            }
        }

        private void cbbMaSP_Enter(object sender, EventArgs e)
        {
            
            cbbMaSP.BackColor = Color.White;
        }
                        
        private void btnBarcode_MouseDown(object sender, MouseEventArgs e)
        {
            btnBarcode.ForeColor = Color.White;
            btnBarcode.BackColor = Color.LightSkyBlue;
        }

        private void btnBarcode_MouseLeave(object sender, EventArgs e)
        {
            btnBarcode.ForeColor = Color.SteelBlue;
            btnBarcode.BackColor = Color.White;
        }

        private void btnBarcode_MouseUp(object sender, MouseEventArgs e)
        {
            btnBarcode.ForeColor = Color.SteelBlue;
            btnBarcode.BackColor = Color.White;
        }

        private void btnBarcode_MouseMove(object sender, MouseEventArgs e)
        {
            btnBarcode.ForeColor = Color.White;
            btnBarcode.BackColor = Color.CornflowerBlue;
        }

        private void btnAdd_MouseDown(object sender, MouseEventArgs e)
        {
            btnAdd.ForeColor = Color.White;
            btnAdd.BackColor = Color.LightSkyBlue;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.ForeColor = Color.SteelBlue;
            btnAdd.BackColor = Color.White;
        }

        private void btnAdd_MouseUp(object sender, MouseEventArgs e)
        {
            btnAdd.ForeColor = Color.SteelBlue;
            btnAdd.BackColor = Color.White;
        }

        private void btnAdd_MouseMove(object sender, MouseEventArgs e)
        {
            btnAdd.ForeColor = Color.White;
            btnAdd.BackColor = Color.CornflowerBlue;
        }

        private void btnTinhTien_MouseDown(object sender, MouseEventArgs e)
        {
            btnTinhTien.ForeColor = Color.White;
            btnTinhTien.BackColor = Color.LightSkyBlue;
        }

        private void btnTinhTien_MouseLeave(object sender, EventArgs e)
        {
            btnTinhTien.ForeColor = Color.SteelBlue;
            btnTinhTien.BackColor = Color.White;
        }

        private void btnTinhTien_MouseMove(object sender, MouseEventArgs e)
        {
            btnTinhTien.ForeColor = Color.White;
            btnTinhTien.BackColor = Color.CornflowerBlue;
        }

        private void btnTinhTien_MouseUp(object sender, MouseEventArgs e)
        {
            btnTinhTien.ForeColor = Color.SteelBlue;
            btnTinhTien.BackColor = Color.White;
            
        }

        private void txtBSL_Enter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;
            txtBSL.BackColor = Color.White;
        }

        private void textBoxTienNhan_TextChanged(object sender, EventArgs e)
        {
            textBoxTienNhan.BackColor = Color.White;
        }

        private void ErrorTable_Click(object sender, EventArgs e)
        {
            Clear_Error();
        }

        private void txtbMAKH_Enter(object sender, EventArgs e)
        {
            txtbMAKH.BackColor = Color.White;
        }
    } 
}
