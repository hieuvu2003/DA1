using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlycuahangbantrasua.DAL;
using NUnit.Framework;

namespace TestProject1
{
    class TaiKhoan
    {
        [Test]
        public void TestCorrectLogin()
        {
            DAL_TaiKhoan dAL_TaiKhoan = new DAL_TaiKhoan();
            // Arrange
            string userName = "ngoc";
            string password = "ngoc123";
            string error;

            // Act
            bool result = dAL_TaiKhoan.CheckLogin(userName, password, out error);

            // Assert
            Assert.IsTrue(result, "Login should succeed.");
            Assert.IsEmpty(error, "Error message should be empty.");
        }

        [Test]
        public void TestIncorrectLogin()
        {
            DAL_TaiKhoan dAL_TaiKhoan = new DAL_TaiKhoan();

            // Arrange
            string userName = "testuser";
            string password = "wrongpassword";
            string error;

            // Act
            bool result = dAL_TaiKhoan.CheckLogin(userName, password, out error);

            // Assert
            Assert.IsFalse(result, "Login should fail.");
            Assert.IsNotEmpty(error, "Error message should not be empty.");
        }
    }
}
