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
    public partial class frmNhanVien : Form
    {
        BUS_NhanVien busnv = new BUS_NhanVien();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
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
            //
            dtgNhanVien.DataSource= busnv.getNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = textMaNV.Text;
            string hoTen = textHoTen.Text;
            string sDT = textSDT.Text;
            string diaChi = textDiaChi.Text;
            DateTime namSinh = DateTime.Parse(dtpNgaySinh.Value.ToShortDateString());
            string gioiTinh = textGioiTinh.Text;
            string maChucVu = textChucVu.Text;
            string taiKhoan = textTaiKhoan.Text;
            string matKhau = textMatKhau.Text;
            NhanVien nv = new NhanVien( maNV,hoTen, sDT, diaChi, namSinh, gioiTinh, maChucVu, taiKhoan, matKhau);
            if (busnv.themNV(nv) == true)
            {
                MessageBox.Show("Thêm Nhân Viên Thành Công");
                dtgNhanVien.DataSource = busnv.getNhanVien();
            }
        }

        private void dtgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                textHoTen.Text = dtgNhanVien[1, hang].Value.ToString();
                textSDT.Text = dtgNhanVien[2, hang].Value.ToString();
                textDiaChi.Text = dtgNhanVien[3, hang].Value.ToString();
                // Kiểm tra giá trị của cột thứ 3 có phải là kiểu ngày tháng năm không
                if (DateTime.TryParse(dtgNhanVien[4, hang].Value.ToString(), out DateTime ngaySinh))
                {
                    dtpNgaySinh.Value = ngaySinh; // Chuyển đổi giá trị của cột thứ 3 sang kiểu DateTime và gán cho dtpNgaySinh
                }
                else
                {
                    // Xử lý lỗi nếu giá trị của cột thứ 3 không phải là kiểu ngày tháng năm
                    // Ví dụ, gán giá trị mặc định cho dtpNgaySinh
                    dtpNgaySinh.Value = DateTime.Today; // Gán giá trị mặc định là ngày hôm nay
                }
                textGioiTinh.Text = dtgNhanVien[5, hang].Value.ToString();
                textChucVu.Text = dtgNhanVien[6, hang].Value.ToString();
                textTaiKhoan.Text = dtgNhanVien[7, hang].Value.ToString();
                textMatKhau.Text = dtgNhanVien[8, hang].Value.ToString();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ ở đây
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNV = textMaNV.Text;    
            string hoTen = textHoTen.Text;
            string sDT = textSDT.Text;
            string diaChi = textDiaChi.Text;
            DateTime namSinh = DateTime.Parse(dtpNgaySinh.Value.ToShortDateString());
            string gioiTinh = textGioiTinh.Text;
            string maChucVu = textChucVu.Text;
            string taiKhoan = textTaiKhoan.Text;
            string matKhau = textMatKhau.Text;
            NhanVien nv = new NhanVien( maNV,hoTen, sDT, diaChi, namSinh, gioiTinh, maChucVu, taiKhoan, matKhau);
            if (busnv.suaNV(nv) == true)
            {
                MessageBox.Show("Sửa thành công");
                dtgNhanVien.DataSource = busnv.getNhanVien();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string hoTen = textHoTen.Text;

                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Nếu người dùng xác nhận xóa, thực hiện thao tác xóa và cập nhật lại danh sách nhân viên trên DataGridView
                if (result == DialogResult.Yes)
                {
                    if (busnv.xoaNV(hoTen))
                    {
                        MessageBox.Show("Xóa thành công");
                        dtgNhanVien.DataSource = busnv.getNhanVien(); // cập nhật lại dữ liệu hiển thị trên DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên để xóa");
                    }
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

        private void dtgNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            dtpNgaySinh.CalendarForeColor = Color.Cyan;
            dtpNgaySinh.CalendarMonthBackground = Color.Cyan;
        }
    }
}
