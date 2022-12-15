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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UserForm1.Forms
{
    public partial class FormKhoHang: Form
    {
        //First Load
        #region First Load
        public FormKhoHang()
        {
            InitializeComponent();

            SPTable.DataSource = loaddata().Tables[0];
            comboFilter.SelectedIndex = 0;

            SPTable.DefaultCellStyle.SelectionBackColor = Color.White;
            SPTable.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        //Enum
        enum Goods
        {
            GD, TP, MP
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {   
            Goodname.Text = "Mã sản phẩm";
            Fullname.Text = "Tên sản phẩm";
            Country.Text = "Nước sản xuất";
            Price.Text = "Giá";
            SL.Text = "SL";
            pictureBox1.Image = Properties.Resources.plus;

            SPTable.ClearSelection();
        }
        #endregion


        //Connect to database
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.DatabaseConnection);


        //Load Table
        #region Load Table
        
        DataSet loaddata()
        {
            string select_command = "select MASP, TENSP, GIA, NUOCSX, SOlUONG from SANPHAM";
            DataSet data = new DataSet();

            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(select_command, conn);
            adapter.Fill(data);
            SPTable.Refresh();
            conn.Close();

            return data;
        }
        #endregion


        //Load Goods List
        #region Load User List
        private void loadcombo()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select MASP from SANPHAM", conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("MASP", typeof(string));
            dt.Load(reader);
            comboSP.ValueMember = "MASP";
            comboSP.DataSource = dt;
            conn.Close();
        }
        private void comboSP_Click(object sender, EventArgs e)
        {
            loadcombo();
        }
        #endregion


        //Button Event Handler
        #region Button Event Handler

        public bool CheckData(string masp,string tensp, string gia, string nuocsx, string soluong)
        {

            bool flag = false;
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            conn.Open();
            command.CommandText = @"select * from SANPHAM where MASP ='"+ masp + "'";
            if (command.ExecuteReader().Read())
            {
                flag = true;
                error_list.Add("Mã sản phẩm đã tồn tại!");
                Goodname.BackColor = Color.FromArgb(254, 184, 177);
            }
            conn.Close();
            if (masp.Count() != 5)
            {
                flag = true;
                error_list.Add("Mã sản phẩm cần có 5 ký tự!");
                Goodname.BackColor = Color.FromArgb(254, 184, 177);
            }

            if (masp.Count() == 5)
            {
                object value = masp.Substring(0, 2);
                if (!Enum.IsDefined(typeof(Goods), value))
                {
                    flag = true;
                    error_list.Add("Hai ký tự đầu của mã sản phẩm phải là GD, TP hoặc MP!");
                    Goodname.BackColor = Color.FromArgb(254, 184, 177);
                }
            }

            if (tensp == "Tên sản phẩm")
            {
                flag = true;
                error_list.Add("Vui lòng nhập giá trị cho tên sản phẩm!");
                Fullname.BackColor = Color.FromArgb(254, 184, 177);
            }

            if (tensp.Count() > 50)
            {
                flag = true;
                error_list.Add("Tên sản phẩm chỉ có tối đa 50 ký tự!");
                Fullname.BackColor = Color.FromArgb(254, 184, 177);
            }


            if (nuocsx.Count() > 40)
            {
                flag = true;
                error_list.Add("Nước sản xuất chỉ có tối đa 40 ký tự!");
                Country.BackColor = Color.FromArgb(254, 184, 177);
            }
            if (nuocsx == "Nước sản xuất")
            {
                flag = true;
                error_list.Add("Vui lòng nhập nước sản xuất!");
                Country.BackColor = Color.FromArgb(254, 184, 177);
            }

            if (gia == "Giá")
            {
                flag = true;
                error_list.Add("Vui lòng nhập giá trị cho giá!");
                Price.BackColor = Color.FromArgb(254, 184, 177);
            }

            if (soluong == "SL")
            {
                flag = true;
                error_list.Add("Vui lòng nhập giá trị cho số lượng!");
                SL.BackColor = Color.FromArgb(254, 184, 177);
            }

            decimal parsedValue;
            if (decimal.TryParse(soluong, out parsedValue) == false)
            {
                flag = true;
                error_list.Add("Chỉ được nhập số cho giá!");
                Price.BackColor = Color.FromArgb(254, 184, 177);
            }

            int parsedValue2;
            if (int.TryParse(soluong, out parsedValue2) == false)
            {
                flag = true;
                error_list.Add("Chỉ được nhập số cho số lượng!");
                SL.BackColor = Color.FromArgb(254, 184, 177);
            }

            if (flag == true)
            {
                Error_Handler();
                return false;
            }


            return true;
        }

        //Add
        private void Add_Click(object sender, EventArgs e)
        {
            if (!CheckData(Goodname.Text, Fullname.Text, Price.Text, Country.Text, SL.Text))
            {
                return;
            }

            try
            {
                SqlCommand command = new SqlCommand();

            command.Connection = conn;
            conn.Open();

                Image img = pictureBox1.Image;
                ImageConverter convert = new ImageConverter();
                byte[] temp = (byte[])convert.ConvertTo(img, typeof(byte[]));

                command.CommandText = "insert into SANPHAM values (@spname, @fname, @price, @country, @photo, @sl)";
                command.Parameters.Add("@spname", SqlDbType.VarChar).Value = Goodname.Text;
                command.Parameters.Add("@price", SqlDbType.Money).Value = decimal.Parse(Price.Text);
                command.Parameters.Add("@fname", SqlDbType.VarChar).Value = Fullname.Text;
                command.Parameters.Add("@country", SqlDbType.VarChar).Value = Country.Text;
                command.Parameters.Add("@photo", SqlDbType.VarBinary).Value = temp;
                command.Parameters.Add("@sl", SqlDbType.Int).Value = int.Parse(SL.Text);
                command.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Bạn đã thêm thành công thành công!");

                Reset();
                

                SPTable.Rows[SPTable.CurrentCell.RowIndex].Selected = false;
                //SPTable.Rows[SPTable.Rows.Count - 1].Selected = true;
                SPTable.DataSource = loaddata().Tables[0];

                reset_tbs();
            }
            catch (Exception er)
            {
                conn.Close();
            }
        }
       
        //Reset
        private void List_Click(object sender, EventArgs e)
        {
            //string select_command = "";
            //select_command = "select MASP, TENSP, GIA, NUOCSX, SOlUONG from SANPHAM";
            SPTable.DataSource = loaddata().Tables[0];

            Reset();
            reset_tbs();

            SPTable.ClearSelection();

            newinfo.ForeColor = Color.FromArgb(180, 180, 180);
            newinfo.Text = "VD: Nguyễn A";
        }

        private void reset_tbs()
        {
            Goodname.ForeColor = Color.FromArgb(180, 180, 180);
            Fullname.ForeColor = Color.FromArgb(180, 180, 180);
            Country.ForeColor = Color.FromArgb(180, 180, 180);
            Price.ForeColor = Color.FromArgb(180, 180, 180);
            SL.ForeColor = Color.FromArgb(180, 180, 180);

            Goodname.Text = "Mã sản phẩm";
            Fullname.Text = "Tên sản phẩm";
            Country.Text = "Nước sản xuất";
            Price.Text = "Giá";
            SL.Text = "SL";
            pictureBox1.Image = Properties.Resources.plus;
        }    

        //Update
        private void Update_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            conn.Open();

            try
            {
                if (newinfo.Text == "VD: Nguyễn A")
                    throw new Exception();

                long parsedValue2;
                if (long.TryParse(newinfo.Text, out parsedValue2) == false && (comboColumn.SelectedIndex == 1 || comboColumn.SelectedIndex == 3))
                    throw new Exception();

                switch (comboColumn.SelectedIndex)
                {
                    case 0:
                        command.CommandText = "update SANPHAM set TENSP = @tensp where MASP = @MASP";
                        command.Parameters.Add("@tensp", SqlDbType.VarChar).Value = newinfo.Text;
                        break;
                    case 1:
                        command.CommandText = "update SANPHAM set GIA = @gia where MASP = @MASP";
                        command.Parameters.Add("@gia", SqlDbType.Money).Value = newinfo.Text;
                        break;
                    case 2:
                        command.CommandText = "update SANPHAM set NUOCSX = @nuocsx where MASP = @MASP";
                        command.Parameters.Add("@nuocsx", SqlDbType.VarChar).Value = newinfo.Text;
                        break;
                    case 3:
                        command.CommandText = "update SANPHAM set SOLUONG = @soluong where MASP = @MASP";
                        command.Parameters.Add("@soluong", SqlDbType.Int).Value = int.Parse(newinfo.Text);
                        break;
                }

                command.Parameters.Add("@MASP", SqlDbType.Char).Value = comboSP.Text;

                command.ExecuteNonQuery();
                MessageBox.Show("Bạn đã cập nhật thành công!");

                conn.Close();

                newinfo.ForeColor = Color.FromArgb(180, 180, 180);
                newinfo.Text = "VD: Nguyễn A";
                SPTable.DataSource = loaddata().Tables[0];

                reset_tbs();
            }
            catch (Exception er)
            {
            //    command.CommandText = "select dbo.ch_exist2(@name)";
            //    command.CommandType = CommandType.Text;
            //    command.Parameters.Add("@name", SqlDbType.Char, 5).Value = Goodname.Text;
            //    bool flag = false;

            //    if (comboSP.SelectedIndex == -1)
            //    {
            //        flag = true;
            //        error_list.Add("Vui lòng chọn sản phẩm cần cập nhật!");
            //    }

            //    if (comboColumn.SelectedIndex == -1)
            //    {
            //        flag = true;
            //        error_list.Add("Vui lòng chọn thông tin cần cập nhật!");
            //    }

            //    if (comboColumn.SelectedIndex == 0 && newinfo.Text.Count() > 50)
            //    {
            //        flag = true;
            //        error_list.Add("Tên sản phẩm chỉ có tối đa 50 ký tự!");
            //        newinfo.BackColor = Color.FromArgb(254, 184, 177);
            //    }

            //    if (comboColumn.SelectedIndex == 0 && newinfo.Text == "VD: Nguyễn A")
            //    {
            //        flag = true;
            //        error_list.Add("Vui lòng nhập giá trị cho tên sản phẩm!");
            //        newinfo.BackColor = Color.FromArgb(254, 184, 177);
            //    }

            //    if (comboColumn.SelectedIndex == 1 && newinfo.Text == "VD: Nguyễn A")
            //    {
            //        flag = true;
            //        error_list.Add("Vui lòng nhập giá trị cho giá!");
            //        newinfo.BackColor = Color.FromArgb(254, 184, 177);
            //    }

            //    if (comboColumn.SelectedIndex == 2 && newinfo.Text.Count() > 40)
            //    {
            //        flag = true;
            //        error_list.Add("Nước sản xuất chỉ có tối đa 40 ký tự!");
            //        newinfo.BackColor = Color.FromArgb(254, 184, 177);
            //    }

            //    if (comboColumn.SelectedIndex == 2 && newinfo.Text == "VD: Nguyễn A")
            //    {
            //        flag = true;
            //        error_list.Add("Vui lòng nhập nước sản xuất!");
            //        newinfo.BackColor = Color.FromArgb(254, 184, 177);
            //    }

            //    long parsedValue2;
            //    if (long.TryParse(newinfo.Text, out parsedValue2) == false)
            //    {
            //        flag = true;
            //        error_list.Add("Kiểu dữ liệu không phù hợp!");
            //        newinfo.BackColor = Color.FromArgb(254, 184, 177);
            //    }

            //    if (long.TryParse(newinfo.Text, out parsedValue2) == true && long.Parse(newinfo.Text) < 1000 && comboColumn.SelectedIndex == 1)
            //    {
            //        flag = true;
            //        error_list.Add("Giá phải lớn hơn 1000!");
            //        newinfo.BackColor = Color.FromArgb(254, 184, 177);
            //    }

            //    if (long.TryParse(newinfo.Text, out parsedValue2) == true && long.Parse(newinfo.Text) < 0 && comboColumn.SelectedIndex == 3)
            //    {
            //        flag = true;
            //        error_list.Add("Số lượng phải lớn hơn hoặc bằng 0!");
            //        newinfo.BackColor = Color.FromArgb(254, 184, 177);
            //    }

            //    if (flag == false)
            //    {
            //        error_list.Add(er.ToString());
            //        flag = true;
            //    }

            //    if (flag == true)
            //        Error_Handler();

            //    conn.Close();

            //    newinfo.ForeColor = Color.FromArgb(180, 180, 180);
            //    newinfo.Text = "VD: Nguyễn A";
            //    int cur = SPTable.CurrentRow.Index;

            //    SPTable.DataSource = loaddata().Tables[0];

            //    SPTable.Rows[cur].Selected = true;

            }
            conn.Close();
        }

        //Delete
        private void SPTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SPTable.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            SPTable.DefaultCellStyle.SelectionForeColor = Color.White;

            if (SPTable.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DialogResult choice = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Thông báo!", MessageBoxButtons.YesNo);

                if (choice == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand();

                    command.Connection = conn;
                    conn.Open();
                    try
                    {
                        command.CommandText = "delete from SANPHAM where MASP = @masp";

                        command.Parameters.Add("@masp", SqlDbType.Char).Value = SPTable[1, SPTable.CurrentCell.RowIndex].Value;
                    }
                    catch (IndexOutOfRangeException er)
                    {
                        MessageBox.Show(er.Message);
                        conn.Close();
                    }

                    int rowCount = command.ExecuteNonQuery();
                    MessageBox.Show("Xóa sản phẩm thành công!");

                    conn.Close();

                    Fullname.ForeColor = Color.FromArgb(180, 180, 180);
                    Price.ForeColor = Color.FromArgb(180, 180, 180);
                    Goodname.ForeColor = Color.FromArgb(180, 180, 180);
                    Country.ForeColor = Color.FromArgb(180, 180, 180);

                    SPTable.DataSource = loaddata().Tables[0];
                    SPTable.ClearSelection();

                    reset_tbs();
                }
            }
        }
        #endregion


        //Change Color, Text when Enter or Leave Textboxs
        #region Click&Leave
        private void Goodname_Click(object sender, EventArgs e)
        {
            if (Goodname.Text == "Mã sản phẩm")
            {
                Goodname.Text = "";
                Goodname.ForeColor = Color.Black;
            }
        }

        private void Goodname_Leave(object sender, EventArgs e)
        {
            if (Goodname.Text == "")
            {
                Goodname.ForeColor = Color.FromArgb(180, 180, 180);
                Goodname.Text = "Mã sản phẩm";
            }
        }

        private void Fullname_Click(object sender, EventArgs e)
        {
            if (Fullname.Text == "Tên sản phẩm")
            {
                Fullname.Text = "";
                Fullname.ForeColor = Color.Black;
            }
        }

        private void Fullname_Leave(object sender, EventArgs e)
        {
            if (Fullname.Text == "")
            {
                Fullname.ForeColor = Color.FromArgb(180, 180, 180);
                Fullname.Text = "Tên sản phẩm";
            }
        }

        private void Country_Click(object sender, EventArgs e)
        {
            if (Country.Text == "Nước sản xuất")
            {
                Country.ForeColor = Color.Black;
                Country.Text = "";
            }
        }

        private void Country_Leave(object sender, EventArgs e)
        {
            if (Country.Text == "")
            {
                Country.ForeColor = Color.FromArgb(180, 180, 180);
                Country.Text = "Nước sản xuất";
            }
        }

        private void Price_Click(object sender, EventArgs e)
        {
            if (Price.Text == "Giá")
            {
                Price.ForeColor = Color.Black;
                Price.Text = "";
            }
        }

        private void Price_Leave(object sender, EventArgs e)
        {
            if (Price.Text == "")
            {
                Price.ForeColor = Color.FromArgb(180, 180, 180);
                Price.Text = "Giá";
            }
        }

        private void newinfo_Click(object sender, EventArgs e)
        {
            if (newinfo.Text == "VD: Nguyễn A")
            {
                newinfo.ForeColor = Color.Black;
                newinfo.Text = "";
            }
        }

        private void newinfo_Leave(object sender, EventArgs e)
        {
            if (newinfo.Text == "")
            {
                newinfo.ForeColor = Color.FromArgb(180, 180, 180);
                newinfo.Text = "VD: Nguyễn A";
            }
        }

        private void filterinfo_Click(object sender, EventArgs e)
        {
            if (filterinfo.Text == "VD: 13000")
            {
                filterinfo.ForeColor = Color.Black;
                filterinfo.Text = "";
            }
        }

        private void filterinfo_Leave(object sender, EventArgs e)
        {
            if (filterinfo.Text == "")
            {
                filterinfo.ForeColor = Color.FromArgb(180, 180, 180);
                filterinfo.Text = "VD: 13000";
            }
        }
        private void SL_Click(object sender, EventArgs e)
        {
            if (SL.Text == "SL")
            {
                SL.ForeColor = Color.Black;
                SL.Text = "";
            }
        }

        private void SL_Leave(object sender, EventArgs e)
        {
            if (SL.Text == "")
            {
                SL.ForeColor = Color.FromArgb(180, 180, 180);
                SL.Text = "SL";
            }
        }
        #endregion


        //Load Info From Table To Textboxs
        private void SPTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Goodname.Text = SPTable[1, e.RowIndex].Value.ToString();
                Fullname.Text = SPTable[2, e.RowIndex].Value.ToString();
                Price.Text = SPTable[3, e.RowIndex].Value.ToString();
                Country.Text = SPTable[4, e.RowIndex].Value.ToString();
                SL.Text = SPTable[5, e.RowIndex].Value.ToString();


                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT Photo FROM SANPHAM WHERE MASP = '" + SPTable[1, e.RowIndex].Value.ToString() + "'", conn));
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);
                conn.Close();
                try
                {
                    if (dataSet.Tables[0].Rows.Count == 1)
                    {
                        System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                        pictureBox1.Image = (Image)converter.ConvertFrom((byte[])(dataSet.Tables[0].Rows[0]["Photo"]));


                    }
                }
                catch
                {

                }

            }
        }


        //Error
        #region Error
        //Error Reset
        private void Username_Enter(object sender, EventArgs e)
        {}

        private void Fullname_Enter(object sender, EventArgs e)
        {
            Fullname.BackColor = Color.White;
        }

        private void Goodname_Enter(object sender, EventArgs e)
        {
            Goodname.BackColor = Color.White;
        }

        private void Price_Enter(object sender, EventArgs e)
        {
            Price.BackColor = Color.White;
        }

        private void SL_Enter(object sender, EventArgs e)
        {
            SL.BackColor = Color.White;
        }

        private void Country_Enter(object sender, EventArgs e)
        {
            Country.BackColor = Color.White;
        }

        private void newinfo_Enter(object sender, EventArgs e)
        {
            newinfo.BackColor = Color.White;
        }

        private void filterinfo_Enter(object sender, EventArgs e)
        {
            filterinfo.BackColor = Color.White;
        }


        //Error Handler
        List<string> error_list = new List<string>();

        //Showing
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

        //Closing
        private void ErrorTable_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //Closing
        private void Reset()
        {
            Goodname.BackColor = Color.White;
            Fullname.BackColor = Color.White;
            Country.BackColor = Color.White;
            Price.BackColor = Color.White;
            newinfo.BackColor = Color.White;
            filterinfo.BackColor = Color.White;
            SL.BackColor = Color.White;

            ErrorTable.Visible = false;
            ErrorTable.Enabled = false;
            ErrorTable.Rows.Clear();
            ErrorTable.Refresh();
            error_list.Clear();
        }
        #endregion

        //Button setting
        #region Button Setting
        private void Add_MouseDown(object sender, MouseEventArgs e)
        {
            Add.BackColor = Color.LightSkyBlue;
            Add.ForeColor = Color.White;
        }

        private void Add_MouseUp(object sender, MouseEventArgs e)
        {
            Button_Reset();
        }

        private void Add_MouseMove(object sender, MouseEventArgs e)
        {
            Add.BackColor = Color.CornflowerBlue;
            Add.ForeColor = Color.White;
        }

        private void Add_Leave(object sender, EventArgs e)
        {
            Button_Reset();
        }

        private void Add_Move(object sender, EventArgs e)
        {
            Add.BackColor = Color.CornflowerBlue;
            Add.ForeColor = Color.White;
        }

    private void List_MouseDown(object sender, MouseEventArgs e)
        {
            List.BackColor = Color.LightSkyBlue; 
            List.ForeColor = Color.White;
        }

        private void List_MouseUp(object sender, MouseEventArgs e)
        {
            Button_Reset();
        }

        private void List_Move(object sender, EventArgs e)
        {
            List.BackColor = Color.CornflowerBlue;
            List.ForeColor = Color.White;
        }

        private void List_Leave(object sender, EventArgs e)
        {
            Button_Reset();
        }

        private void Update_MouseDown(object sender, MouseEventArgs e)
        {
            Update.BackColor = Color.LightSkyBlue;
            Update.ForeColor = Color.White;
        }

        private void Update_MouseUp(object sender, MouseEventArgs e)
        {
            Button_Reset();
        }

        private void Update_Move(object sender, EventArgs e)
        {
            Update.BackColor = Color.CornflowerBlue; 
            Update.ForeColor = Color.White;
        }

        private void Update_Leave(object sender, EventArgs e)
        {
            Button_Reset();
        }

        private void Button_Reset()
        {
            Add.BackColor = Color.White;
            List.BackColor = Color.White;
            Update.BackColor = Color.White; 

            Add.ForeColor = Color.SteelBlue;
            List.ForeColor = Color.SteelBlue;
            Update.ForeColor = Color.SteelBlue;
        }
        #endregion

        //Filter
        #region Filter
        private void filterinfo_TextChanged(object sender, EventArgs e)
        {
            string select_command = "", temp = "";
            int flag = 0;

            try
            {
                switch (comboFilter.SelectedIndex)
                {
                    case 0:
                        temp = "MASP";
                        break;
                    case 1:
                        temp = "TENSP";
                        break;
                    case 2:
                        temp = "GIA";
                        flag = 1;
                        break;
                    case 3:
                        temp = "NUOCSX";
                        break;
                    case 4:
                        temp = "SOLUONG";
                        flag = 1;
                        break;
                }

                if (flag == 0)
                {
                    if (filterinfo.Text == "VD: 13000" || filterinfo.Text == "")
                        select_command = "select MASP, TENSP, GIA, NUOCSX, SOlUONG from SANPHAM";
                    else
                        select_command = "select MASP, TENSP, GIA, NUOCSX, SOlUONG from SANPHAM where " + temp + " like " + "'%" + filterinfo.Text + "%'";
                }
                else if (flag == 1)
                {
                    if (filterinfo.Text == "VD: 13000" || filterinfo.Text == "")
                        select_command = "select MASP, TENSP, GIA, NUOCSX, SOlUONG from SANPHAM";
                    else
                        select_command = "select MASP, TENSP, GIA, NUOCSX, SOlUONG from SANPHAM where " + temp + " >= " + filterinfo.Text;
                }
            

                DataSet data = new DataSet();

                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(select_command, conn);
                adapter.Fill(data);

                SPTable.Refresh();
                conn.Close();
                SPTable.DataSource = data.Tables[0];

                reset_tbs();
                SPTable.ClearSelection();
            }
            catch
            {
                conn.Close();
                error_list.Add("Kiểu dữ liệu không phù hợp!");
                Error_Handler();
            }
        }

        private void comboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterinfo.Text = "";
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (SPTable.SelectedRows.Count <= 0)
            {
                OpenFileDialog dlg = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "PNG|*.png|JPG|*.jpg|All files|*.*" };
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Image img = Image.FromFile(dlg.FileName);
                    pictureBox1.Image = img;
                }
            }
            else
            {
                OpenFileDialog dlg = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "PNG|*.png|JPG|*.jpg|All files|*.*" };
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = conn;
                    conn.Open();

                    Image img = Image.FromFile(dlg.FileName);
                    pictureBox1.Image = Properties.Resources.White;
                    pictureBox1.Image = img;
                    ImageConverter convert = new ImageConverter();
                    byte[] temp = (byte[])convert.ConvertTo(img, typeof(byte[]));


                    command.CommandText = "update SANPHAM set Photo = @photo where MASP = @masp";

                    command.Parameters.Add("@photo", SqlDbType.VarBinary).Value = temp;
                    command.Parameters.Add("@masp", SqlDbType.VarChar).Value = SPTable.CurrentRow.Cells[1].Value.ToString();

                    command.ExecuteNonQuery();

                    conn.Close();
                }
            }
        }

        //Letter Input Control & Maxium Charaters Control
        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            newinfo.ForeColor = Color.Black;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-') && (comboColumn.SelectedIndex == 1 || comboColumn.SelectedIndex == 3))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1) && (comboColumn.SelectedIndex == 2 || comboColumn.SelectedIndex == 4))
            {
                e.Handled = true;
            }
        }
        private void KeyPress2(object sender, KeyPressEventArgs e)
        {
            filterinfo.ForeColor = Color.Black;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-') && (comboFilter.SelectedIndex == 2 || comboFilter.SelectedIndex == 4))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1) && (comboFilter.SelectedIndex == 2 || comboFilter.SelectedIndex == 4))
            {
                e.Handled = true;
            }
        }


        private void comboColumn_TextChanged(object sender, EventArgs e)
        {
            switch (comboColumn.SelectedIndex)
            {
                case 0:
                    newinfo.MaxLength = 15;
                    break;
                case 1:
                    newinfo.MaxLength = 50;
                    break;
                case 2:
                    newinfo.MaxLength = 12;
                    break;
                case 3:
                    newinfo.MaxLength = 50;
                    break;
                case 4:
                    newinfo.MaxLength = 10;
                    break;
                case 5:
                    newinfo.MaxLength = 50;
                    break;
                case 6:
                    newinfo.MaxLength = 12;
                    break;
            }
        }

        private void comboFilter_TextChanged(object sender, EventArgs e)
        {
            switch (comboFilter.SelectedIndex)
            {
                case 0:
                    filterinfo.MaxLength = 5;
                    break;
                case 1:
                    filterinfo.MaxLength = 15;
                    break;
                case 2:
                    filterinfo.MaxLength = 50;
                    break;
                case 3:
                    filterinfo.MaxLength = 12;
                    break;
                case 4:
                    filterinfo.MaxLength = 50;
                    break;
                case 5:
                    filterinfo.MaxLength = 10;
                    break;
                case 6:
                    filterinfo.MaxLength = 50;
                    break;
                case 7:
                    filterinfo.MaxLength = 12;
                    break;
            }
        }

        private void comboColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            newinfo.Text = "";
        }

        private void comboFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            filterinfo.Text = "";
        }
    }
}

