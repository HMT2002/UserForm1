using NUnit.Framework;
using System;
using System.Net;
using System.Security.Policy;
using System.Threading;
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
            string tendangnhap = "ST003";

            FNhanVien = new UserForm1.Forms.FormNhanVien();
            FKhachHang = new UserForm1.Forms.FormKhachHang();
            FKhoHang = new UserForm1.Forms.FormKhoHang();
            FBanHang = new UserForm1.Forms.FormBanHang(tendangnhap);
        }

        //[Test]
        //public void Test1()
        //{
        //    Assert.Pass();
        //}


        //đúng định dạng, không trùng tồn tại

        [Test]
        [Apartment(ApartmentState.STA)]
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
        [Apartment(ApartmentState.STA)]
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
        [Apartment(ApartmentState.STA)]
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
        [Apartment(ApartmentState.STA)]
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
        [Apartment(ApartmentState.STA)]
        public void UTCID_UpdateEmployee_01()
        {
            string username = "ST004";

            Assert.False(FNhanVien.CheckUpdateData("some legit information", username, -1));
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_UpdateEmployee_02()
        {
            string username = "ST003";
            string password = "aejv7412";

            Assert.True(FNhanVien.CheckUpdateData(password, username, 0));

        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_UpdateEmployee_03()
        {
            string username = "ST003";
            string fullname = "nguyen van c";

            Assert.True(FNhanVien.CheckUpdateData(fullname, username, 1));
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_UpdateEmployee_04()
        {
            string username = "ST003";
            string email = "email@mail.com";

            Assert.True(FNhanVien.CheckUpdateData(email, username, 5));
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_UpdateEmployee_05()
        {
            string username = "ST003";
            string money = "840000";

            Assert.True(FNhanVien.CheckUpdateData(money, username, 6));
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_UpdateEmployee_06()
        {
            string username = "ST003";
            string phone = "0914568823";

            Assert.True(FNhanVien.CheckUpdateData(phone, username, 4));

        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_UpdateEmployee_07()
        {
            string username = "ST003";

            string cmnd = "045216985315";

            Assert.True(FNhanVien.CheckUpdateData(cmnd, username, 2));
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_UpdateEmployee_08()
        {
            string username = "ST003";
            string address = "123 Nguyen Dinh Chieu";

            Assert.True(FNhanVien.CheckUpdateData(address, username, 3));
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_UpdateEmployee_09()
        {
            string username = "ST003";
            string password = "";

            Assert.False(FNhanVien.CheckUpdateData(password, username, 0));
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_UpdateEmployee_10()
        {
            string username = "ST003";
            string fullname = "";

            Assert.False(FNhanVien.CheckUpdateData(fullname, username, 1));
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_UpdateEmployee_11()
        {
            string username = "ST003";
            string email = "";

            Assert.False(FNhanVien.CheckUpdateData(email, username, 5));


        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_UpdateEmployee_12()
        {
            string username = "ST003";
            string money = "";

            Assert.False(FNhanVien.CheckUpdateData(money, username, 6));


        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_UpdateEmployee_13()
        {
            string username = "ST003";
            string phone = "";

            Assert.False(FNhanVien.CheckUpdateData(phone, username, 4));

        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_UpdateEmployee_14()
        {
            string username = "ST003";

            string cmnd = "";

            Assert.False(FNhanVien.CheckUpdateData(cmnd, username, 2));
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_UpdateEmployee_15()
        {

            string username = "ST003";
            string address = "";

            Assert.False(FNhanVien.CheckUpdateData(address, username, 3));
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_DeleteEmployee_01()
        {
            string username = "ST003";

            Assert.True(FNhanVien.CheckDeleteData(username));

        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_DeleteEmployee_02()
        {
            string username = "ST004";

            Assert.False(FNhanVien.CheckDeleteData(username));

        }

        //đúng định dạng, không trùng tồn tại
        [Test]
        [Apartment(ApartmentState.STA)]
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
        [Apartment(ApartmentState.STA)]
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
        [Apartment(ApartmentState.STA)]
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
        [Apartment(ApartmentState.STA)]
        public void UTCID_AddCustomer_04()
        {
            string id = "";
            string hoten = "";
            string diachi = "";
            string sdt = "";
            string cmnd = "";

            Assert.False(FKhachHang.CheckData(id, hoten, diachi, sdt, cmnd));
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_UpdateCustomer_01()
        {
            string id = "KH03";
            string hoten = "Nguyen Khanh R";
            string diachi = "45/8A Pham Van Dong";
            string sdt = "0986647512";
            string cmnd = "025614992257";

            Assert.False(FKhachHang.CheckUpdate(hoten, id, 0));
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_UpdateCustomer_02()
        {
            string id = "KH02";
            string hoten = "Nguyen Khanh R";
            string diachi = "45/8A Pham Van Dong";
            string sdt = "0986647512";
            string cmnd = "025614992257";

            Assert.True(FKhachHang.CheckUpdate(hoten,id,0));
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_UpdateCustomer_03()
        {
            string id = "KH02";
            string hoten = "Nguyen Khanh R";
            string diachi = "45/8A Pham Van Dong";
            string sdt = "0986647512";
            string cmnd = "025614992257";

            Assert.True(FKhachHang.CheckUpdate(sdt, id, 1));
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_UpdateCustomer_04()
        {
            string id = "KH02";
            string hoten = "Nguyen Khanh R";
            string diachi = "45/8A Pham Van Dong";
            string sdt = "0986647512";
            string cmnd = "025614992257";

            Assert.True(FKhachHang.CheckUpdate(diachi, id, 2));
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_UpdateCustomer_05()
        {
            string id = "KH02";
            string hoten = "Nguyen Khanh R";
            string diachi = "45/8A Pham Van Dong";
            string sdt = "0986647512";
            string cmnd = "025614992257";

            Assert.True(FKhachHang.CheckUpdate(cmnd, id, 3));
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_UpdateCustomer_06()
        {
            string id = "KH02";
            string hoten = "";
            string diachi = "45/8A Pham Van Dong";
            string sdt = "0986647512";
            string cmnd = "025614992257";

            Assert.False(FKhachHang.CheckUpdate(hoten, id, 0));
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_UpdateCustomer_07()
        {
            string id = "KH02";
            string hoten = "Nguyen Khanh R";
            string diachi = "45/8A Pham Van Dong";
            string sdt = "";
            string cmnd = "025614992257";

            Assert.False(FKhachHang.CheckUpdate(sdt, id, 1));
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_UpdateCustomer_08()
        {
            string id = "KH02";
            string hoten = "Nguyen Khanh R";
            string diachi = "";
            string sdt = "0986647512";
            string cmnd = "025614992257";

            Assert.False(FKhachHang.CheckUpdate(diachi, id, 2));
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_UpdateCustomer_09()
        {
            string id = "KH02";
            string hoten = "Nguyen Khanh R";
            string diachi = "45/8A Pham Van Dong";
            string sdt = "0986647512";
            string cmnd = "";

            Assert.False(FKhachHang.CheckUpdate(cmnd, id, 3));
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_DeleteCustomer_01()
        {
            string id = "KH02";
            string hoten = "Nguyen Khanh R";
            string diachi = "45/8A Pham Van Dong";
            string sdt = "0986647512";
            string cmnd = "025614992257";

            Assert.True(FKhachHang.CheckDeleteData(id));
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_DeleteCustomer_02()
        {
            string id = "KH03";
            string hoten = "Nguyen Khanh R";
            string diachi = "45/8A Pham Van Dong";
            string sdt = "0986647512";
            string cmnd = "025614992257";

            Assert.False(FKhachHang.CheckDeleteData(id));
        }


        //đúng định dạng, không trùng tồn tại
        [Test]
        [Apartment(ApartmentState.STA)]
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
        [Apartment(ApartmentState.STA)]
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
        [Apartment(ApartmentState.STA)]
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
        [Apartment(ApartmentState.STA)]
        public void UTCID_ImportGood_04()
        {
            string id = "";
            string tensp = "";
            string gia = "";
            string soluong = "";
            string xuatxu = "";

            Assert.False(FKhoHang.CheckData(id, tensp, gia, xuatxu, soluong));
        }


        [Test]
        [Apartment(ApartmentState.STA)]

        public void UTCID_AddToCart_01()
        {
            string id = "";
            string soluong = "30";
            Assert.False(FBanHang.CheckAddCart(id, soluong));
        }

        [Test]
        [Apartment(ApartmentState.STA)]

        public void UTCID_AddToCart_02()
        {
            string id = "GD002";
            string soluong = "30";
            Assert.False(FBanHang.CheckAddCart(id, soluong));
        }

        [Test]
        [Apartment(ApartmentState.STA)]

        public void UTCID_AddToCart_03()
        {
            string id = "GD001";
            string soluong = "10";
            Assert.True(FBanHang.CheckAddCart(id, soluong));
        }

        [Test]
        [Apartment(ApartmentState.STA)]

        public void UTCID_AddToCart_04()
        {
            string id = "GD001";
            string soluong = "9300";
            Assert.False(FBanHang.CheckAddCart(id, soluong));
        }

        [Test]
        [Apartment(ApartmentState.STA)]

        public void UTCID_SellingGood_01()
        {
            string id = "GD001";
            string soluong = "20";
            FBanHang.CheckAddCart(id, soluong);

            string id_kh = "KH02";
            string tien_nhan = "3500000";
            DateTime date = DateTime.Now;

            Assert.True(FBanHang.CheckTinhTien(id_kh, tien_nhan,date));
        }

        [Test]
        [Apartment(ApartmentState.STA)]

        public void UTCID_SellingGood_02()
        {
            string id = "GD001";
            string soluong = "20";

            string id_kh = "KH02";
            string tien_nhan = "350000đ";
            DateTime date=DateTime.Now.Date.AddDays(-1);

            FBanHang.CheckAddCart(id, soluong);
            Assert.False(FBanHang.CheckTinhTien(id_kh, tien_nhan, date));
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_SellingGood_03()
        {
            string id = "0";
            string soluong = "0";


            string id_kh = "KH02";
            string tien_nhan = "350000đ";
            DateTime date = DateTime.Now.Date;

            FBanHang.CheckAddCart(id, soluong);

            Assert.False(FBanHang.CheckTinhTien(id_kh, tien_nhan, date));
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_SellingGood_04()
        {
            string id = "GD001";
            string soluong = "20";


            string id_kh = "KH09";
            string tien_nhan = "150000đ";
            DateTime date = DateTime.Now.Date;

            FBanHang.CheckAddCart(id, soluong);

            Assert.False(FBanHang.CheckTinhTien(id_kh, tien_nhan, date));
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_SellingGood_05_1()
        {
            string id = "GD001";
            string soluong = "20";

            string id_kh = "";
            string tien_nhan = "350000đ";
            DateTime date = DateTime.Now.Date;

            FBanHang.CheckAddCart(id, soluong);

            Assert.False(FBanHang.CheckTinhTien(id_kh, tien_nhan, date));
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void UTCID_SellingGood_05_2()
        {
            string id = "GD001";
            string soluong = "20";


            string id_kh = "KH03";
            string tien_nhan = "350000đ";
            DateTime date = DateTime.Now.Date;

            FBanHang.CheckAddCart(id, soluong);

            Assert.False(FBanHang.CheckTinhTien(id_kh, tien_nhan, date));
        }
    }
}