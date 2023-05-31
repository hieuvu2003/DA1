using NUnit.Framework;
using Quanlycuahangbantrasua.BUS;
using Quanlycuahangbantrasua.DTO;
using System;
using System.Data;

namespace Quanlycuahangbantrasua.UnitTest
{
    [TestFixture]
    public class BUS_KhachHang_Test
    {
        private BUS_KhachHang busKhachHang;

        [SetUp]
        public void SetUp()
        {
            busKhachHang = new BUS_KhachHang();
        }

        [Test]
        public void GetKhachHang_ShouldReturnDataTable()
        {
            // Act
            DataTable result = busKhachHang.getKhachHang();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<DataTable>(result);
            Assert.IsTrue(result.Rows.Count > 0);
        }

        [Test]
        public void ThemKH_ShouldInsertNewCustomer()
        {
            // Arrange
            KhachHang kh = new KhachHang
            {
                MaKhachHang = "KH1122",
                HoTen = "Nguyen Van B",
                GioiTinh = "Nam",
                SDT = "0987654321"
            };

            // Act
            bool result = busKhachHang.themKH(kh);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void XoaKH_ShouldDeleteCustomer()
        {
            // Arrange
            string maKhachHang = "KH10";

            // Act
            bool result = busKhachHang.xoaKH(maKhachHang);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void SuaKH_ShouldUpdateCustomer()
        {
            // Arrange
            KhachHang kh = new KhachHang
            {
                MaKhachHang = "KH111",
                HoTen = "Nguyen Van A",
                GioiTinh = "Nu",
                SDT = "0987654321"
            };

            // Act
            bool result = busKhachHang.suaKH(kh);

            // Assert
            Assert.IsTrue(result);
        }
    }
}