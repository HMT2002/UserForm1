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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;
using System.Linq.Expressions;

namespace UserForm1.Forms
{

    public partial class FormNhanVien : Form
    {
        //First Load
        #region First Load
        public FormNhanVien()
        {
            InitializeComponent();

            NVTable.DataSource = loaddata().Tables[0];
            comboFilter.SelectedIndex = 0;
            comboColumn.SelectedIndex = 0;
            //comboUser.SelectedIndex = 0;

            newinfo.Text = "VD: Nguyễn A";

            NVTable.DefaultCellStyle.SelectionBackColor = Color.White;
            NVTable.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            Username.Text = "Mã nhân viên";
            Password.Text = "Mật khẩu";
            Fullname.Text = "Họ và tên";
            CMND.Text = "CMND";
            Address.Text = "Địa chỉ";
            Phone.Text = "Số điện thoại";
            Email.Text = "Email";
            Money.Text = "Lương";
        }
        #endregion


        //Connect to database
        SqlConnection conn = new SqlConnection(@"Data Source=.\mssqlserver01;Initial Catalog=Grocery_Management;Integrated Security=True");

        //Load Table
        #region Load Table

        DataSet loaddata()
        {
            DataSet data = new DataSet();
            string select_command = "select * from NHANVIEN";
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(select_command, conn);
            adapter.Fill(data);
            NVTable.Refresh();
            conn.Close();

            return data;
        }
        #endregion


        //Load User List
        #region Load User List
        private void loadcombo()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Uname from NHANVIEN", conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Uname", typeof(string));
            dt.Load(reader);
            comboUser.ValueMember = "Uname";
            comboUser.DataSource = dt;
            conn.Close();
        }
        private void comboUser_Click(object sender, EventArgs e)
        {
            loadcombo();
        }
        #endregion


        public bool CheckData(string username, string password, string fullname, string email, string money, string phone, string cmnd, string address)
        {
            bool flag = false;
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            conn.Open();
            command.CommandText = @"select * from PhanQuyen where tendangnhap ='" + username + "'";
            if (command.ExecuteReader().Read())
            {
                flag = true;
                error_list.Add("Tên đăng nhập đã tồn tại!");
                Username.BackColor = Color.FromArgb(254, 184, 177);
            }
            conn.Close();
            if (username.Count() != 5)
            {
                flag = true;
                error_list.Add("Mã nhân viên cần có 5 ký tự!");
                Username.BackColor = Color.FromArgb(254, 184, 177);
            }

            if (username.Length >= 5)
            {
                if (username.Substring(0, 2) != "ST")
                {
                    flag = true;
                    error_list.Add("Hai ký tự đầu của mã nhân viên phải là ST!");
                    Username.BackColor = Color.FromArgb(254, 184, 177);
                }
            }
            else
            {
                flag = true;
                error_list.Add("Mã nhân viên phải dài hơn 5 kí tự");
                Username.BackColor = Color.FromArgb(254, 184, 177);
            }

            if (password.Count() > 15)
            {
                flag = true;
                error_list.Add("Mật khẩu chỉ có tối đa 15 ký tự!");
                Password.BackColor = Color.FromArgb(254, 184, 177);
            }
            if (password == "Mật khẩu")
            {
                flag = true;
                error_list.Add("Vui lòng nhập giá trị cho mật khẩu!");
                Password.BackColor = Color.FromArgb(254, 184, 177);
            }

            if (fullname.Count() > 50)
            {
                flag = true;
                error_list.Add("Họ tên chỉ có tối đa 50 ký tự!");
                Fullname.BackColor = Color.FromArgb(254, 184, 177);
            }
            if (fullname == "Họ và tên")
            {
                flag = true;
                error_list.Add("Vui lòng nhập họ và tên!");
                Fullname.BackColor = Color.FromArgb(254, 184, 177);
            }

            if (cmnd.Count() != 12)
            {
                flag = true;
                error_list.Add("CMND cần có 12 ký tự!");
                CMND.BackColor = Color.FromArgb(254, 184, 177);
            }

            if (address == "Địa chỉ")
            {
                flag = true;
                error_list.Add("Vui lòng nhập địa chỉ!");
                Address.BackColor = Color.FromArgb(254, 184, 177);
            }
            if (address.Count() > 50)
            {
                flag = true;
                error_list.Add("Địa chỉ chí có tối đa 50 ký tự!");
                Address.BackColor = Color.FromArgb(254, 184, 177);
            }

            if (phone.Count()!=10)
            {
                flag = true;
                error_list.Add("Số điện thoại cần có 10 ký tự!");
                Phone.BackColor = Color.FromArgb(254, 184, 177);
            }

            if (email.Count() > 50)
            {
                flag = true;
                error_list.Add("Email chỉ có tối đa 50 ký tự!");
                Email.BackColor = Color.FromArgb(254, 184, 177);
            }
            if (email == "Email")
            {
                flag = true;
                error_list.Add("Vui lòng nhập email!");
                Email.BackColor = Color.FromArgb(254, 184, 177);
            }

            if (money == "Lương")
            {
                flag = true;
                error_list.Add("Vui lòng nhập giá trị cho lương!");
                Money.BackColor = Color.FromArgb(254, 184, 177);
            }

            decimal parsedValue;
            if (decimal.TryParse(money, out parsedValue) == false)
            {
                flag = true;
                error_list.Add("Chỉ được nhập số cho lương!");
                Money.BackColor = Color.FromArgb(254, 184, 177);
            }

            long parsedValue2;
            if (long.TryParse(cmnd, out parsedValue2) == false)
            {
                flag = true;
                error_list.Add("Chỉ được nhập số cho CMND!");
                CMND.BackColor = Color.FromArgb(254, 184, 177);
            }

            long parsedValue3;
            if (long.TryParse(phone, out parsedValue3) == false)
            {
                flag = true;
                error_list.Add("Chỉ được nhập số cho số điện thoại!");
                Phone.BackColor = Color.FromArgb(254, 184, 177);
            }


            if (flag == true)
            {
                Error_Handler();
                return false;
            }



            return true;

        }

        //Button Event Handler
        #region Button Event Handler
        //Add
        private void Add_Click(object sender, EventArgs e)
        {
            if(!CheckData(Username.Text, Password.Text, Fullname.Text, Email.Text, Money.Text, Phone.Text, CMND.Text, Address.Text))
            {
                return;
            }

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            conn.Open();
            command.CommandText = "insert into NHANVIEN (Uname, Pword, Fname, ID, Aress, Phone, Email, Luong, Photo) values (@username, @pword, @fname, @id, @aress," +
                "@phone, @email, @luong, @photo)";

            Bitmap img = Properties.Resources.blank;
            ImageConverter convert = new ImageConverter();
            byte[] temp = (byte[])convert.ConvertTo(img, typeof(byte[]));

            command.Parameters.Add("@username", SqlDbType.VarChar).Value = Username.Text;
            command.Parameters.Add("@pword", SqlDbType.VarChar).Value = Password.Text;
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = Fullname.Text;
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = CMND.Text;
            command.Parameters.Add("@aress", SqlDbType.VarChar).Value = Address.Text;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = Phone.Text;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = Email.Text;
            command.Parameters.Add("@luong", SqlDbType.Money).Value = decimal.Parse(Money.Text);
            command.Parameters.Add("@photo", SqlDbType.VarBinary).Value = temp;

            command.ExecuteNonQuery();

            command.CommandText = $"insert into PHANQUYEN values ('{Username.Text}', '{Password.Text}', '{Fullname.Text}', 'Staff')";
            command.ExecuteNonQuery();

            MessageBox.Show("Bạn đã thêm thành công thành công!");
            Reset();
            conn.Close();

            NVTable.Rows[NVTable.CurrentCell.RowIndex].Selected = false;
            //NVTable.Rows[NVTable.Rows.Count - 1].Selected = true;
            NVTable.DataSource = loaddata().Tables[0];

            reset_tbs();
        }

        //Reset
        private void List_Click(object sender, EventArgs e)
        {
            //string select_command = "select * from NHANVIEN";
            NVTable.DataSource = loaddata().Tables[0];

            Reset();
            reset_tbs();

            NVTable.ClearSelection();

            newinfo.ForeColor = Color.FromArgb(180, 180, 180);
            newinfo.Text = "VD: Nguyễn A";
        }

        private void reset_tbs()
        {
            Username.ForeColor = Color.FromArgb(180, 180, 180);
            Password.ForeColor = Color.FromArgb(180, 180, 180);
            Fullname.ForeColor = Color.FromArgb(180, 180, 180);
            CMND.ForeColor = Color.FromArgb(180, 180, 180);
            Address.ForeColor = Color.FromArgb(180, 180, 180);
            Phone.ForeColor = Color.FromArgb(180, 180, 180);
            Email.ForeColor = Color.FromArgb(180, 180, 180);
            Money.ForeColor = Color.FromArgb(180, 180, 180);

            Username.Text = "Mã nhân viên";
            Password.Text = "Mật khẩu";
            Fullname.Text = "Họ và tên";
            CMND.Text = "CMND";
            Address.Text = "Địa chỉ";
            Phone.Text = "Số điện thoại";
            Email.Text = "Email";
            Money.Text = "Lương";
            //filterinfo.Text = "VD: 13000";
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

                //long parsedValue2;
                //if (long.TryParse(newinfo.Text, out parsedValue2) == false)
                // throw new Exception();

                switch (comboColumn.SelectedIndex)
                {
                    case 0:
                        command.CommandText = "update NHANVIEN set Pword = @pword where Uname = @uname";
                        command.Parameters.Add("@pword", SqlDbType.VarChar).Value = newinfo.Text;
                        break;
                    case 1:
                        command.CommandText = "update NHANVIEN set Fname = @fname where Uname = @uname";
                        command.Parameters.Add("@fname", SqlDbType.VarChar).Value = newinfo.Text;
                        break;
                    case 2:
                        command.CommandText = "update NHANVIEN set ID = @id where Uname = @uname";
                        command.Parameters.Add("@id", SqlDbType.VarChar).Value = newinfo.Text;
                        break;
                    case 3:
                        command.CommandText = "update NHANVIEN set Aress = @aress where Uname = @uname";
                        command.Parameters.Add("@aress", SqlDbType.VarChar).Value = newinfo.Text;
                        break;
                    case 4:
                        command.CommandText = "update NHANVIEN set Phone = @phone where Uname = @uname";
                        command.Parameters.Add("@phone", SqlDbType.VarChar).Value = newinfo.Text;
                        break;
                    case 5:
                        command.CommandText = "update NHANVIEN set Email = @email where Uname = @uname";
                        command.Parameters.Add("@email", SqlDbType.VarChar).Value = newinfo.Text;
                        break;
                    case 6:
                        command.CommandText = "update NHANVIEN set Luong = @luong where Uname = @uname";
                        command.Parameters.Add("@luong", SqlDbType.Money).Value = newinfo.Text;
                        break;
                }

                command.Parameters.Add("@uname", SqlDbType.Char).Value = comboUser.Text;

                command.ExecuteNonQuery();
                MessageBox.Show("Bạn đã cập nhật thành công!");

                conn.Close();

                newinfo.ForeColor = Color.FromArgb(180, 180, 180);
                newinfo.Text = "VD: Nguyễn A";
                NVTable.DataSource = loaddata().Tables[0];
            }
            catch (Exception er)
            {
                command.CommandText = "select dbo.ch_exist(@name)";
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@name", SqlDbType.Char, 5).Value = Username.Text;
                bool flag = false;

                if (comboUser.SelectedIndex == -1)
                {
                    flag = true;
                    error_list.Add("Vui lòng chọn nhân viên cần cập nhật!");
                }

                if (comboColumn.SelectedIndex == -1)
                {
                    flag = true;
                    error_list.Add("Vui lòng chọn thông tin cần cập nhật!");
                }

                if (comboColumn.SelectedIndex == 0 && newinfo.Text.Count() > 15)
                {
                    flag = true;
                    error_list.Add("Mật khẩu chỉ có tối đa 15 ký tự!");
                    newinfo.BackColor = Color.FromArgb(254, 184, 177);
                }

                if (comboColumn.SelectedIndex == 0 && newinfo.Text == "VD: Nguyễn A")
                {
                    flag = true;
                    error_list.Add("Vui lòng nhập giá trị cho mật khẩu!");
                    newinfo.BackColor = Color.FromArgb(254, 184, 177);
                }

                if (comboColumn.SelectedIndex == 1 && newinfo.Text.Count() > 50)
                {
                    flag = true;
                    error_list.Add("Họ tên chỉ có tối đa 50 ký tự!");
                    newinfo.BackColor = Color.FromArgb(254, 184, 177);
                }

                if (comboColumn.SelectedIndex == 1 && newinfo.Text == "VD: Nguyễn A")
                {
                    flag = true;
                    error_list.Add("Vui lòng nhập họ và tên!");
                    newinfo.BackColor = Color.FromArgb(254, 184, 177);
                }

                if (comboColumn.SelectedIndex == 2 && newinfo.Text.Count() != 12)
                {
                    flag = true;
                    error_list.Add("CMND cần có 12 ký tự!");
                    newinfo.BackColor = Color.FromArgb(254, 184, 177);
                }

                if (comboColumn.SelectedIndex == 3 && newinfo.Text == "VD: Nguyễn A")
                {
                    flag = true;
                    error_list.Add("Vui lòng nhập địa chỉ!");
                    newinfo.BackColor = Color.FromArgb(254, 184, 177);
                }

                if (comboColumn.SelectedIndex == 3 && newinfo.Text.Count() == 50)
                {
                    flag = true;
                    error_list.Add("Địa chỉ chí có tối đa 50 ký tự!");
                    newinfo.BackColor = Color.FromArgb(254, 184, 177);
                }

                if (comboColumn.SelectedIndex == 4 && newinfo.Text == "VD: Nguyễn A")
                {
                    flag = true;
                    error_list.Add("Số điện thoại cần có 10 ký tự!");
                    newinfo.BackColor = Color.FromArgb(254, 184, 177);
                }

                if (comboColumn.SelectedIndex == 5 && newinfo.Text.Count() > 50)
                {
                    flag = true;
                    error_list.Add("Email chỉ có tối đa 50 ký tự!");
                    newinfo.BackColor = Color.FromArgb(254, 184, 177);
                }

                if (comboColumn.SelectedIndex == 5 && newinfo.Text == "VD: Nguyễn A")
                {
                    flag = true;
                    error_list.Add("Vui lòng nhập email!");
                    newinfo.BackColor = Color.FromArgb(254, 184, 177);
                }

                if (comboColumn.SelectedIndex == 6 && newinfo.Text == "VD: Nguyễn A")
                {
                    flag = true;
                    error_list.Add("Vui lòng nhập giá trị cho lương!");
                    newinfo.BackColor = Color.FromArgb(254, 184, 177);
                }

                long parsedValue2;
                if (long.TryParse(newinfo.Text, out parsedValue2) == false)
                {
                    flag = true;
                    error_list.Add("Sai kiểu dữ liệu!");
                    newinfo.BackColor = Color.FromArgb(254, 184, 177);
                }

                if (flag == false)
                {
                    error_list.Add(er.Message);
                    flag = true;
                }

                if (flag == true)
                    Error_Handler();

                conn.Close();

                reset_tbs();

                newinfo.ForeColor = Color.FromArgb(180, 180, 180);
                newinfo.Text = "VD: Nguyễn A";
                NVTable.DataSource = loaddata().Tables[0];
            }
            conn.Close();
        }

        //Delete and Insert Image
        private void NVTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NVTable.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            NVTable.DefaultCellStyle.SelectionForeColor = Color.White;

            if (NVTable.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DialogResult choice = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Thông báo!", MessageBoxButtons.YesNo);

                if (choice == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand();

                    command.Connection = conn;
                    conn.Open();
                    string user_temp = NVTable[1, NVTable.CurrentCell.RowIndex].Value.ToString();

                    try
                    {
                        command.CommandText = "delete from NHANVIEN where Uname = @username";

                        command.Parameters.Add("@username", SqlDbType.VarChar).Value = user_temp;
                    }
                    catch (IndexOutOfRangeException er)
                    {
                        error_list.Add(er.ToString());
                        Error_Handler();
                        conn.Close();
                    }
                    int rowCount = command.ExecuteNonQuery();

                    try
                    {
                        command.CommandText = "delete from PHANQUYEN where tendangnhap = @a";

                        command.Parameters.Add("@a", SqlDbType.VarChar).Value = user_temp;
                    }
                    catch (IndexOutOfRangeException er)
                    {
                        error_list.Add(er.ToString());
                        Error_Handler();
                        conn.Close();
                    }
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xóa nhân viên thành công!");

                    conn.Close();

                    Fullname.ForeColor = Color.FromArgb(180, 180, 180);
                    Money.ForeColor = Color.FromArgb(180, 180, 180);
                    Username.ForeColor = Color.FromArgb(180, 180, 180);
                    CMND.ForeColor = Color.FromArgb(180, 180, 180);
                    Password.ForeColor = Color.FromArgb(180, 180, 180);
                    Phone.ForeColor = Color.FromArgb(180, 180, 180);
                    Address.ForeColor = Color.FromArgb(180, 180, 180);
                    Email.ForeColor = Color.FromArgb(180, 180, 180);

                    NVTable.DataSource = loaddata().Tables[0];
                    //NVTable.Rows[NVTable.CurrentCell.RowIndex].Selected = false;

                    Reset();
                    reset_tbs();
                }
            }
            else if (NVTable.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                OpenFileDialog dlg = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "PNG|*.png|JPG|*.jpg|All files|*.*" };
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = conn;
                    conn.Open();

                    Image img = Image.FromFile(dlg.FileName);
                    ImageConverter convert = new ImageConverter();
                    byte[] temp = (byte[])convert.ConvertTo(img, typeof(byte[]));


                    command.CommandText = "update NHANVIEN set Photo = @photo where Uname = @uname";

                    command.Parameters.Add("@photo", SqlDbType.VarBinary).Value = temp;
                    command.Parameters.Add("@uname", SqlDbType.VarChar).Value = NVTable.CurrentRow.Cells[1].Value.ToString();

                    command.ExecuteNonQuery();
                    NVTable[9, NVTable.CurrentRow.Index].Value = Properties.Resources.White;
                }

                conn.Close();

                NVTable.DataSource = loaddata().Tables[0];
                NVTable.Rows[NVTable.CurrentCell.RowIndex].Selected = false;
                NVTable.Refresh();

                Reset();
                reset_tbs();
            }
        }
        #endregion


        //Change Color, Text when Enter or Leave Textboxs
        #region Click&Leave
        private void Username_Click(object sender, EventArgs e)
        {
            if (Username.Text == "Mã nhân viên")
            {
                Username.Text = "";
                Username.ForeColor = Color.Black;
            }
        }

        private void Username_Leave(object sender, EventArgs e)
        {
            if (Username.Text == "")
            {
                Username.ForeColor = Color.FromArgb(180, 180, 180);
                Username.Text = "Mã nhân viên";
            }
        }

        private void Password_Click(object sender, EventArgs e)
        {
            if (Password.Text == "Mật khẩu")
            {
                Password.Text = "";
                Password.ForeColor = Color.Black;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.ForeColor = Color.FromArgb(180, 180, 180);
                Password.Text = "Mật khẩu";
            }
        }

        private void Fullname_Click(object sender, EventArgs e)
        {
            if (Fullname.Text == "Họ và tên")
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
                Fullname.Text = "Họ và tên";
            }
        }

        private void CMND_Click(object sender, EventArgs e)
        {
            if (CMND.Text == "CMND")
            {
                CMND.ForeColor = Color.Black;
                CMND.Text = "";
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

        private void Address_Click(object sender, EventArgs e)
        {
            if (Address.Text == "Địa chỉ")
            {
                Address.ForeColor = Color.Black;
                Address.Text = "";
            }
        }

        private void Address_Leave(object sender, EventArgs e)
        {
            if (Address.Text == "")
            {
                Address.ForeColor = Color.FromArgb(180, 180, 180);
                Address.Text = "Địa chỉ";
            }
        }

        private void Phone_Click(object sender, EventArgs e)
        {
            if (Phone.Text == "Số điện thoại")
            {
                Phone.ForeColor = Color.Black;
                Phone.Text = "";
            }
        }

        private void Phone_Leave(object sender, EventArgs e)
        {
            if (Phone.Text == "")
            {
                Phone.ForeColor = Color.FromArgb(180, 180, 180);
                Phone.Text = "Số điện thoại";
            }
        }

        private void Email_Click(object sender, EventArgs e)
        {
            if (Email.Text == "Email")
            {
                Email.ForeColor = Color.Black;
                Email.Text = "";
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (Email.Text == "")
            {
                Email.ForeColor = Color.FromArgb(180, 180, 180);
                Email.Text = "Email";
            }
        }

        private void Money_Click(object sender, EventArgs e)
        {
            if (Money.Text == "Lương")
            {
                Money.ForeColor = Color.Black;
                Money.Text = "";
            }
        }

        private void Money_Leave(object sender, EventArgs e)
        {
            if (Money.Text == "")
            {
                Money.ForeColor = Color.FromArgb(180, 180, 180);
                Money.Text = "Lương";
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

        }
        #endregion


        //Load Info From Table To Textboxs
        private void NVTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Username.Text = (string)NVTable[1, e.RowIndex].Value;
                Password.Text = (string)NVTable[2, e.RowIndex].Value;
                Fullname.Text = (string)NVTable[3, e.RowIndex].Value;
                CMND.Text = (string)NVTable[4, e.RowIndex].Value;
                Address.Text = (string)NVTable[5, e.RowIndex].Value;
                Phone.Text = (string)NVTable[6, e.RowIndex].Value;
                Email.Text = (string)NVTable[7, e.RowIndex].Value;
                Money.Text = (string)NVTable[8, e.RowIndex].Value.ToString();
            }
        }


        //Error
        #region Error
        //Error Reset
        private void Money_Enter(object sender, EventArgs e)
        {
            Money.BackColor = Color.White;
        }

        private void Fullname_Enter(object sender, EventArgs e)
        {
            Fullname.BackColor = Color.White;
        }

        private void Username_Enter(object sender, EventArgs e)
        {
            Username.BackColor = Color.White;
        }

        private void CMND_Enter(object sender, EventArgs e)
        {
            CMND.BackColor = Color.White;
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            Password.BackColor = Color.White;
        }

        private void Phone_Enter(object sender, EventArgs e)
        {
            Phone.BackColor = Color.White;
        }

        private void Address_Enter(object sender, EventArgs e)
        {
            Address.BackColor = Color.White;
        }

        private void Email_Enter(object sender, EventArgs e)
        {
            Email.BackColor = Color.White;
        }

        private void filterinfo_Enter(object sender, EventArgs e)
        {
            filterinfo.BackColor = Color.White;
        }

        private void newinfo_Enter(object sender, EventArgs e)
        {
            newinfo.BackColor = Color.White;
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
            Username.BackColor = Color.White;
            Password.BackColor = Color.White;
            Fullname.BackColor = Color.White;
            CMND.BackColor = Color.White;
            Address.BackColor = Color.White;
            Phone.BackColor = Color.White;
            Email.BackColor = Color.White;
            Money.BackColor = Color.White;
            newinfo.BackColor = Color.White;
            filterinfo.BackColor = Color.White;

            ErrorTable.Visible = false;
            ErrorTable.Enabled = false;
            ErrorTable.Rows.Clear();
            ErrorTable.Refresh();
            error_list.Clear();
        }
        #endregion

        //Picture Showing Handler
        #region Picture
        ShowPic show;
        private void NVTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (ena == true)
                if (NVTable.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
                {
                    byte[] imageData = (byte[])NVTable.Rows[e.RowIndex].Cells[9].Value;
                    using (var ms = new MemoryStream(imageData))
                    {
                        Image temp = Image.FromStream(ms);
                        show = new ShowPic(temp);
                        show.Show();
                    }
                }
        }

        private void NVTable_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (ena == true)
                if (NVTable.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
                {
                    show.Close();
                }
        }


        //ENALBE/DISABLE PICTURE
        bool ena = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (ena == true)
            {
                ena = false;
                button1.Text = "Tắt";
            }
            else
            {
                ena = true;
                button1.Text = "Mở";
            }
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

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.LightSkyBlue;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            Button_Reset();
        }

        private void button1_Move(object sender, EventArgs e)
        {
            button1.BackColor = Color.CornflowerBlue;
            button1.ForeColor = Color.White;
        }

        private void button1_Leave(object sender, EventArgs e)
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
            button1.BackColor = Color.White;

            Add.ForeColor = Color.SteelBlue;
            List.ForeColor = Color.SteelBlue;
            Update.ForeColor = Color.SteelBlue;
            button1.ForeColor = Color.SteelBlue;
        }
        #endregion


        //Tab block
        private void Fullname_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                e.IsInputKey = true;
            }
        }

        //Filter
        #region Filter
        private void filterinfo_TextChanged(object sender, EventArgs e)
        {
            string select_command = "", temp = "";
            bool flag = false;

            switch (comboFilter.SelectedIndex)
            {
                case 0:
                    temp = "Uname";
                    break;
                case 1:
                    temp = "Pword";
                    break;
                case 2:
                    temp = "Fname";
                    break;
                case 3:
                    temp = "ID";
                    filterinfo.ForeColor = Color.Black;
                    break;
                case 4:
                    temp = "Aress";
                    break;
                case 5:
                    temp = "Phone";
                    filterinfo.ForeColor = Color.Black;
                    break;
                case 6:
                    temp = "Email";
                    break;
                case 7:
                    temp = "Luong";
                    filterinfo.ForeColor = Color.Black;
                    flag = true;
                    break;
            }

            if (flag == false)
            {
                if (filterinfo.Text == "VD: 13000" || filterinfo.Text == "")
                    select_command = "select * from NHANVIEN";
                else
                    select_command = "select * from NHANVIEN where " + temp + " like " + "'%" + filterinfo.Text + "%'";
            }
            else
            {
                if (filterinfo.Text == "VD: 13000" || filterinfo.Text == "")
                    select_command = "select * from NHANVIEN";
                else
                    select_command = "select * from NHANVIEN where " + temp + " >= " + filterinfo.Text;
            }

            DataSet data = new DataSet();

            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(select_command, conn);
            adapter.Fill(data);

            NVTable.Refresh();
            conn.Close();
            NVTable.DataSource = data.Tables[0];

            reset_tbs();
        }

        private void comboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterinfo.Text = "";
        }
        #endregion

        //Letter Input Control & Maxium Charaters Control
        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            newinfo.ForeColor = Color.Black;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-') && (comboColumn.SelectedIndex == 2 || comboColumn.SelectedIndex == 4 || comboColumn.SelectedIndex == 6))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1) && (comboColumn.SelectedIndex == 2 || comboColumn.SelectedIndex == 4 || comboColumn.SelectedIndex == 6))
            {
                e.Handled = true;
            }
        }
        private void KeyPress2(object sender, KeyPressEventArgs e)
        {
            filterinfo.ForeColor = Color.Black;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-') && (comboFilter.SelectedIndex == 3 || comboFilter.SelectedIndex == 5 || comboFilter.SelectedIndex == 7))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1) && (comboFilter.SelectedIndex == 3 || comboFilter.SelectedIndex == 5 || comboFilter.SelectedIndex == 7))
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
    }
}
