using NUnit.Framework;
using Quanlycuahangbantrasua.DAL;
using Quanlycuahangbantrasua.DTO;
using Quanlycuahangbantrasua.BUS;
using System.Data;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Khởi tạo các đối tượng cần thiết trước khi chạy các bài kiểm tra
        }
        [TestFixture]
        public class DAL_KhachHangTests
        {
            private DAL_KhachHang dalKhachHang;

            [SetUp]
            public void SetUp()
            {
                dalKhachHang = new DAL_KhachHang();
            }

            [Test]
            public void GetKhachHang_ShouldReturnDataTable()
            {
                // Act
                DataTable result = dalKhachHang.getKhachHang();

                // Assert
                Assert.IsNotNull(result);
                Assert.IsTrue(result.Rows.Count > 0);
            }

            [Test]
            public void ThemKH_ShouldInsertNewCustomer()
            {
                // Arrange
                KhachHang kh = new KhachHang
                {
                    MaKhachHang = "KH1000",
                    HoTen = "Nguyen Van A",
                    GioiTinh = "nam",
                    SDT = "0987654321"
                };

                // Act
                bool result = dalKhachHang.themKH(kh);

                // Assert
                Assert.IsTrue(result);
            }

            [Test]
            public void XoaKH_ShouldDeleteCustomer()
            {
                // Arrange
                string maKhachHang = "KH6";

                // Act
                bool result = dalKhachHang.xoaKH(maKhachHang);

                // Assert
                Assert.IsTrue(result);
            }

            [Test]
            public void SuaKH_ShouldUpdateCustomer()
            {
                // Arrange
                KhachHang kh = new KhachHang
                {
                    MaKhachHang = "KH6",
                    HoTen = "Nguyen Van A",
                    GioiTinh = "Nu", // sửa giá trị của cột GioiTinh thành "Nu" để đảm bảo hợp lệ
                    SDT = "0987654321"
                };

                // Act
                bool result = dalKhachHang.suaKH(kh);

                // Assert
                Assert.IsTrue(result);
            }


            [TearDown]
            public void TearDown()
            {
                // Giải phóng tài nguyên sau khi chạy các bài kiểm tra
                dalKhachHang = null;
            }
        }

    }
}
