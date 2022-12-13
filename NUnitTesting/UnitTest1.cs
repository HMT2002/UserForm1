using NUnit.Framework;
using System.Net;
using System.Security.Policy;
using UserForm1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NUnitTesting
{
    public class Tests
    {
        UserForm1.Forms.FormNhanVien FNhanVien;
        UserForm1.Forms.FormKhachHang FKhachHang;
        UserForm1.Forms.FormKhoHang FKhoHang;
        UserForm1.Forms.FormBanHang FBanHang;


        [SetUp]
        public void Setup()
        {
            string tendangnhap = "1";

            FNhanVien = new UserForm1.Forms.FormNhanVien();
            FKhachHang = new UserForm1.Forms.FormKhachHang();
            FKhoHang = new UserForm1.Forms.FormKhoHang();
            //FBanHang = new UserForm1.Forms.FormBanHang(tendangnhap);
        }

        //[Test]
        //public void Test1()
        //{
        //    Assert.Pass();
        //}


         //đúng định dạng, không trùng tồn tại

        [Test]
        public void UTCID_AddEmployee_01()
        {
            string username = "ST005";
            string password = "aejv7412";
            string fullname = "nguyen van c";
            string email = "email@mail.com";
            string money = "840000";
            string phone = "0914568823";
            string cmnd = "045216985315";
            string address = "123 Nguyen Dinh Chieu";
            Assert.True(FNhanVien.CheckData(username, password, fullname, email, money , phone , cmnd , address ));
        }


        //trùng tên đăng nhập
        [Test]
        public void UTCID_AddEmployee_02()
        {
            string username = "ST002";
            string password = "aejv7412";
            string fullname = "nguyen van c";
            string cmnd = "045216985315";
            string money = "840000";
            string phone = "0914568823";
            string address = "123 Nguyen Dinh Chieu";
            string email = "email@mail.com";

            Assert.False(FNhanVien.CheckData(username, password, fullname, email, money, phone, cmnd, address));
        }


        //sai tất cả định dạng
        [Test]
        public void UTCID_AddEmployee_03()
        {
            string username = "5j";
            string password = "5j";
            string fullname = "5j";
            string email = "5j";
            string money = "5j";
            string phone = "5j";
            string cmnd = "5j";
            string address = "5j";

            Assert.False(FNhanVien.CheckData(username, password, fullname, email, money, phone, cmnd, address));
        }

        //Để trống
        [Test]
        public void UTCID_AddEmployee_04()
        {
            string username = "";
            string password = "";
            string fullname = "";
            string email = "";
            string money = "";
            string phone = "";
            string cmnd = "";
            string address = "";

            Assert.False(FNhanVien.CheckData(username, password, fullname, email, money, phone, cmnd, address));
        }

        [Test]
        public void UTCID_UpdateEmployee_01()
        {
            string username = "ST003";

            Assert.False(FNhanVien.CheckUpdateData("some legit information", username, -1));
        }

        [Test]
        public void UTCID_UpdateEmployee_02()
        {
            string username = "ST003";
            string password = "aejv7412";

            Assert.True(FNhanVien.CheckUpdateData(password, username, 0));

        }

        [Test]
        public void UTCID_UpdateEmployee_03()
        {
            string username = "ST003";
            string fullname = "nguyen van c";

            Assert.True(FNhanVien.CheckUpdateData(fullname, username, 1));
        }

        [Test]
        public void UTCID_UpdateEmployee_04()
        {
            string username = "ST003";
            string email = "email@mail.com";

            Assert.True(FNhanVien.CheckUpdateData(email, username, 5));
        }

        [Test]
        public void UTCID_UpdateEmployee_05()
        {
            string username = "ST003";
            string money = "840000";

            Assert.True(FNhanVien.CheckUpdateData(money, username, 6));
        }

        [Test]
        public void UTCID_UpdateEmployee_06()
        {
            string username = "ST003";
            string phone = "0914568823";

            Assert.True(FNhanVien.CheckUpdateData(phone, username, 4));

        }

        [Test]
        public void UTCID_UpdateEmployee_07()
        {
            string username = "ST003";

            string cmnd = "045216985315";

            Assert.True(FNhanVien.CheckUpdateData(cmnd, username, 2));
        }

        [Test]
        public void UTCID_UpdateEmployee_08()
        {
            string username = "ST003";
            string address = "123 Nguyen Dinh Chieu";

            Assert.True(FNhanVien.CheckUpdateData(address, username, 3));
        }

        [Test]
        public void UTCID_UpdateEmployee_09()
        {
            string username = "ST003";
            string password = "";

            Assert.False(FNhanVien.CheckUpdateData(password, username, 0));
        }

        [Test]
        public void UTCID_UpdateEmployee_10()
        {
            string username = "ST003";
            string fullname = "";

            Assert.False(FNhanVien.CheckUpdateData(fullname, username, 1));
        }

        [Test]
        public void UTCID_UpdateEmployee_11()
        {
            string username = "ST003";
            string email = "";

            Assert.False(FNhanVien.CheckUpdateData(email, username, 5));


        }

        [Test]
        public void UTCID_UpdateEmployee_12()
        {
            string username = "ST003";
            string money = "";

            Assert.False(FNhanVien.CheckUpdateData(money, username, 6));


        }

        [Test]
        public void UTCID_UpdateEmployee_13()
        {
            string username = "ST003";
            string phone = "";

            Assert.False(FNhanVien.CheckUpdateData(phone, username, 4));

        }

        [Test]
        public void UTCID_UpdateEmployee_14()
        {
            string username = "ST003";

            string cmnd = "";

            Assert.False(FNhanVien.CheckUpdateData(cmnd, username, 2));
        }

        [Test]
        public void UTCID_UpdateEmployee_15()
        {

            string username = "ST003";
            string address = "";

            Assert.False(FNhanVien.CheckUpdateData(address, username, 3));
        }

        [Test]
        public void UTCID_DeleteEmployee_1()
        {
            string username = "ST003";

            Assert.True(FNhanVien.CheckDeleteData(username));

        }

        //đúng định dạng, không trùng tồn tại
        [Test]
        public void UTCID_AddCustomer_01()
        {
            string id = "KH50";
            string hoten = "Nguyen Khanh R";
            string diachi = "45/8A Pham Van Dong";
            string sdt = "0986647512";
            string cmnd = "025614992257";

            Assert.True(FKhachHang.CheckData(id, hoten, diachi, sdt, cmnd));
        }

        //trùng ID đã tồn tại
        [Test]
        public void UTCID_AddCustomer_02()
        {
            string id = "KH01";
            string hoten = "Nguyen Khanh R";
            string diachi = "45/8A Pham Van Dong";
            string sdt = "0986647512";
            string cmnd = "025614992257";

            Assert.False(FKhachHang.CheckData(id, hoten, diachi, sdt, cmnd));
        }


        //sai tất cả định dạng
        [Test]
        public void UTCID_AddCustomer_03()
        {
            string id = "5t";
            string hoten = "5t";
            string diachi = "5t";
            string sdt = "5t";
            string cmnd = "5t";

            Assert.False(FKhachHang.CheckData(id, hoten, diachi, sdt, cmnd));
        }

        //Để trống
        [Test]
        public void UTCID_AddCustomer_04()
        {
            string id = "";
            string hoten = "";
            string diachi = "";
            string sdt = "";
            string cmnd = "";

            Assert.False(FKhachHang.CheckData(id, hoten, diachi, sdt, cmnd));
        }


        //đúng định dạng, không trùng tồn tại
        [Test]
        public void UTCID_ImportGood_01()
        {
            string id = "GD011";
            string tensp = "Choi lau nha";
            string gia = "40000";
            string soluong = "60";
            string xuatxu = "Viet Nam";
            Assert.True(FKhoHang.CheckData(id, tensp, gia, xuatxu, soluong));
        }

        //trùng ID đã tồn tại
        [Test]
        public void UTCID_ImportGood_02()
        {
            string id = "GD001";
            string tensp = "Choi lau nha";
            string gia = "40000";
            string soluong = "60";
            string xuatxu = "Viet Nam";

            Assert.False(FKhoHang.CheckData(id, tensp, gia, xuatxu, soluong));
        }

        //sai tất cả định dạng
        [Test]
        public void UTCID_ImportGood_03()
        {
            string id = "7rt9";
            string tensp = "7rt9";
            string gia = "7rt9";
            string soluong = "7rt9";
            string xuatxu = "7rt9";

            Assert.False(FKhoHang.CheckData(id, tensp, gia, xuatxu, soluong));
        }

        //Để trống
        [Test]
        public void UTCID_ImportGood_04()
        {
            string id = "";
            string tensp = "";
            string gia = "";
            string soluong = "";
            string xuatxu = "";

            Assert.False(FKhoHang.CheckData(id, tensp, gia, xuatxu, soluong));
        }
    }
}