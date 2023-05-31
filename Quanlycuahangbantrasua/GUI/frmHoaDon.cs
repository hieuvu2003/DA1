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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Quanlycuahangbantrasua.GUI
{
    public partial class frmHoaDon : Form
    {
        BUS_HoaDon bushd = new BUS_HoaDon();
        BUS_CTHD buscthd = new BUS_CTHD();
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbNgayBan_Click(object sender, EventArgs e)
        {

        }

        private void frmHoaDon_Load(object sender, EventArgs e)
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
            dtgThongTinHoaDon.DataSource = bushd.getHoaDon();
            dtgThongTinCTHD.DataSource = buscthd.getCTHD();
        }

        private void dtgThongTinHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                textMaHoaDon.Text = dtgThongTinHoaDon[0, hang].Value.ToString();
                textMaKH.Text = dtgThongTinHoaDon[1, hang].Value.ToString();
                cbMaNV.Text = dtgThongTinHoaDon[2, hang].Value.ToString();
                cbMaBan.Text = dtgThongTinHoaDon[3, hang].Value.ToString();
                textTongTien.Text = dtgThongTinHoaDon[5, hang].Value.ToString();
                if (DateTime.TryParse(dtgThongTinHoaDon[4, hang].Value.ToString(), out DateTime ngayBan))
                {
                    dtpNgayBan.Value = ngayBan;
                }
                else
                {
                    dtpNgayBan.Value = DateTime.Today; // Gán giá trị mặc định là ngày hôm nay
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ ở đây
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void textTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn chắc chắn muốn thoát chứ", "THÔNG BÁO",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
                this.Close();
        }

        private void dtgThongTinCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                cbMaMon.Text = dtgThongTinCTHD[1, hang].Value.ToString();
                textTenMon.Text = dtgThongTinCTHD[2, hang].Value.ToString();
                textGiaMon.Text = dtgThongTinCTHD[4, hang].Value.ToString();
                cbSoLuong.Text = dtgThongTinCTHD[3, hang].Value.ToString();
                textThanhTien.Text = dtgThongTinCTHD[0, hang].Value.ToString();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ ở đây
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ngay = string.Format("{0:MM/dd/yyyy}", dtpNgayBan.Value);
            double tongtien;
            if (double.TryParse(textTongTien.Text, out tongtien))
            {
                int maNV;
                if (int.TryParse(cbMaNV.Text, out maNV))
                {
                    bushd.ThemHoaDon(textMaHoaDon.Text, textMaKH.Text, maNV, cbMaBan.ValueMember.ToString(), ngay, tongtien);
                    MessageBox.Show("Thêm mới hóa đơn thành công");
                    dtgThongTinHoaDon.DataSource = bushd.getHoaDon();
                }
                else
                {
                    MessageBox.Show("Mã nhân viên không hợp lệ");
                }
            }
            else
            {
                MessageBox.Show("Tổng tiền không hợp lệ");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maHoaDon = textMaHoaDon.Text;
            string maKhachHang = textMaKH.Text;
            int maNV = int.Parse(cbMaNV.Text);
            string maBan = cbMaBan.Text;
            string ngayXuatHoaDon = dtpNgayBan.Text;
            int tongTien = int.Parse(textTongTien.Text);

            bool result = bushd.SuaHoaDon(maHoaDon, maKhachHang, maNV, maBan, ngayXuatHoaDon, tongTien);
            if (result)
            {
                MessageBox.Show("Cập nhật hóa đơn thành công!");
                dtgThongTinHoaDon.DataSource = bushd.getHoaDon();

            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật hóa đơn!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maHoaDon = textMaHoaDon.Text;
            bool result =bushd.xoaHoaDon(maHoaDon);
            if (result)
            {
                MessageBox.Show("Xóa hoá đơn thành công!");
                dtgThongTinHoaDon.DataSource = bushd.getHoaDon();

            }
            else
            {
                MessageBox.Show("Xóa hoá đơn thất bại!");
            }
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            string maMonAn = cbMaMon.Text;
            string tenMonAn = textTenMon.Text;
            int soLuong = int.Parse(cbSoLuong.Text.ToString());
            string donGia = textGiaMon.Text;
            string maHoaDon = textThanhTien.Text;

            bool result = buscthd.ThemCTHD(maHoaDon, maMonAn, tenMonAn, soLuong, donGia);
            if (result)
            {
                MessageBox.Show("Thêm chi tiết hoá đơn thành công!");
                dtgThongTinHoaDon.DataSource = bushd.getHoaDon();
            }
            else
            {
                MessageBox.Show("Thêm chi tiết hoá đơn thất bại!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbTKHD.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                dtgThongTinHoaDon.DataSource = bushd.TimKiem(cbTKHD.Text);
            }
            if (cbTKHD.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                dtgThongTinCTHD.DataSource = bushd.TimKiem(cbTKHD.Text);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dtgThongTinCTHD.DataSource = buscthd.getCTHD();
            dtgThongTinHoaDon.DataSource = bushd.getHoaDon();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maHoaDon = textMaHoaDon.Text;
            string maKhachHang = textMaKH.Text;
            int maNV = int.Parse(cbMaNV.Text);
            string maBan = cbMaBan.Text;
            string ngayXuatHoaDon = dtpNgayBan.Text;
            int tongTien = int.Parse(textTongTien.Text);

            bool result = bushd.SuaHoaDon(maHoaDon, maKhachHang, maNV, maBan, ngayXuatHoaDon, tongTien);
            if (result)
            {
                MessageBox.Show("Lưu hóa đơn thành công!");
                dtgThongTinHoaDon.DataSource = bushd.getHoaDon();

            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi lưu hóa đơn!");
            }
        }

        private void btnkl_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại thông báo
            DialogResult result = MessageBox.Show("Bạn chắc là không muốn lưu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra kết quả trả về từ hộp thoại thông báo
            if (result == DialogResult.Yes)
            {
                // Người dùng chọn lưu, thực hiện lưu dữ liệu ở đây
            }
            else
            {
                // Người dùng không chọn lưu, không thực hiện lưu dữ liệu
            }
        }

        private void dtgThongTinHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbMaMon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
