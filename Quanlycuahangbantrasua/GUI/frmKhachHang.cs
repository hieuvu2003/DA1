using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlycuahangbantrasua.DTO;
using Quanlycuahangbantrasua.DAL;
using Quanlycuahangbantrasua.BUS;
using System.Data.SqlClient;

namespace Quanlycuahangbantrasua.GUI
{
    public partial class frmKhachHang : Form
    {
        BUS_KhachHang buskh = new BUS_KhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
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
            dtgKhachHang.DataSource = buskh.getKhachHang();
        }

        private void dtgKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                if (hang >= 0)
                {
                    // Lấy dữ liệu từ DataGridView theo dòng được chọn
                    string maKhachHang = dtgKhachHang[0, hang].Value.ToString();
                    string hoTen = dtgKhachHang[1, hang].Value.ToString();
                    string gioiTinh = dtgKhachHang[2, hang].Value.ToString();
                    string sDT = dtgKhachHang[3, hang].Value.ToString();

                    // Gán dữ liệu vào các ô textbox tương ứng
                    textMaKH.Text = maKhachHang;
                    cbGioiTinh.Text = gioiTinh;
                    textTenKH.Text = hoTen;
                    textSDT.Text = sDT;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dtgKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maKhachHang = textMaKH.Text;
                string hoTen = textTenKH.Text;
                string gioiTinh = cbGioiTinh.Text;
                string sDT = textSDT.Text;
                KhachHang kh = new KhachHang(maKhachHang, hoTen, gioiTinh, sDT);

                if (buskh.themKH(kh))
                {
                    MessageBox.Show("Thêm Khách Hàng Thành Công");
                    DataTable dt = buskh.getKhachHang();
                    // Sắp xếp dữ liệu theo mã khách hàng tăng dần
                    //dt.DefaultView.Sort = "MaKhachHang ASC";
                    dtgKhachHang.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maKhachHang = textMaKH.Text;

                if (buskh.xoaKH(maKhachHang))
                {
                    MessageBox.Show("Xóa thành công");
                    dtgKhachHang.DataSource = buskh.getKhachHang();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maKhachHang = textMaKH.Text;
                string hoTen = textTenKH.Text;
                string gioiTinh = cbGioiTinh.Text;
                string sDT = textSDT.Text;
                KhachHang kh = new KhachHang(maKhachHang, hoTen, gioiTinh, sDT);
                if (buskh.suaKH(kh) == true)
                {
                    MessageBox.Show("Sửa thành công");
                    dtgKhachHang.DataSource = buskh.getKhachHang();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
 }
