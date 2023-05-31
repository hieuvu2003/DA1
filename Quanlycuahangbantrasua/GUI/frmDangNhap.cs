using Quanlycuahangbantrasua.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quanlycuahangbantrasua.GUI
{
    public partial class frmDangNhap : Form
    {
        private readonly BUS_TaiKhoan busTaiKhoan;
        public frmDangNhap()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-8SU7OS9\\SQLEXPRESS;Initial Catalog=VMHQuanLyQuanTraSua;Integrated Security=True";
            busTaiKhoan = new BUS_TaiKhoan(connectionString);
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // Lấy kích thước của Form
            int formWidth = this.Width;
            int formHeight = this.Height;

            // Lấy kích thước của màn hình
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            // Tính toán vị trí để hiển thị Form ở giữa trang
            int left = (screenWidth - formWidth) / 2;
            int top = (screenHeight - formHeight) / 2;

            // Đặt vị trí mới cho Form
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(left, top);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {

            textDangNhap1.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string userName = textDangNhap.Text.Trim();
            string password = textDangNhap1.Text.Trim();
            if (userName == "" || password == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng nhập... ");
                return;
            }

            try
            {
                bool result = busTaiKhoan.checklogin(userName, password, out string error);
                if (result)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    frmMain frm = new frmMain();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại: " + error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void btnThu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btnThoát_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn chắc chắn muốn thoát khỏi ứng dụng chứ", "THÔNG BÁO",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (result == DialogResult.OK)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn chắc chắn muốn thoát chứ", "THÔNG BÁO",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
                this.Close();
        }
    }
}
