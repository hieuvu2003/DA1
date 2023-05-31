using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlycuahangbantrasua.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
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

        private void picMain_Click(object sender, EventArgs e)
        {

        }
        private void btnThu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnPhong_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void picMain_Click_1(object sender, EventArgs e)
        {

        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenu frm = this.MdiChildren.OfType<frmMenu>().FirstOrDefault();
            if (frm == null)
            {
                frmMenu frmMenu = new frmMenu();
                //frmMenu.MdiParent = this;
                frmMenu.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void bÀNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBan frm = this.MdiChildren.OfType<frmBan>().FirstOrDefault();
            if (frm == null)
            {
                frmBan frmBan = new frmBan();
                //frmBan.MdiParent = this;
                frmBan.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void qUẢNLÝToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = this.MdiChildren.OfType<frmNhanVien>().FirstOrDefault();
            if (frm == null)
            {
                frmNhanVien frmNhanVien = new frmNhanVien();
                //frmHoaDon.MdiParent = this;
                frmNhanVien.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void kHÁCHHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = this.MdiChildren.OfType<frmKhachHang>().FirstOrDefault();
            if (frm == null)
            {
                frmKhachHang frmkhachhang = new frmKhachHang();
                //frmkhachhang.MdiParent = this;
                frmkhachhang.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void dOANHTHUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoanhThu frm = this.MdiChildren.OfType<frmDoanhThu>().FirstOrDefault();
            if (frm == null)
            {
                frmDoanhThu frmDoanhThu = new frmDoanhThu();
                //frmDoanhThu.MdiParent = this;
                frmDoanhThu.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void hÓAĐƠNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon frm = this.MdiChildren.OfType<frmHoaDon>().FirstOrDefault();
            if (frm == null)
            {
                frmHoaDon frmHoaDon = new frmHoaDon();
                //frmHoaDon.MdiParent = this;
                frmHoaDon.Show();
            }
            else
            {
                frm.Activate();
            }
        }
    }
}   

