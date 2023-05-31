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
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Quanlycuahangbantrasua.GUI
{
    public partial class frmMenu : Form
    {
        BUS_Menu busmn = new BUS_Menu();
        BUS_CTHD cTHD = new BUS_CTHD();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCaPhe_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mô tả từ ComboBox
                string moTa = cbMoTa.Text;

                // Tạo chuỗi kết nối đến cơ sở dữ liệu
                string connectionString = "Data Source=DESKTOP-8SU7OS9\\SQLEXPRESS;Initial Catalog=VMHQuanLyQuanTraSua;Integrated Security=True";

                // Tạo đối tượng SqlConnection để kết nối đến cơ sở dữ liệu
                SqlConnection connection = new SqlConnection(connectionString);

                // Mở kết nối
                connection.Open();

                // Tạo câu truy vấn SQL để lấy danh sách các món ăn có mô tả tương ứng
                string sql = "SELECT MaMonAn, TenMonAn, MoTa, DonGia, MANV FROM MENU WHERE MoTa = N'Cà Phê'";

                // Tạo đối tượng SqlCommand để thực hiện truy vấn
                SqlCommand command = new SqlCommand(sql, connection);

                // Tạo đừa tượng SqlDataAdapter để lấy dữ liệu và đổ vào DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();

                // Đổ dữ liệu từ SqlDataAdapter vào DataTable
                adapter.Fill(table);

                // Gán DataTable vào DataSource của DataGridView
                dtgMenu.DataSource = table;

                // Đóng kết nối
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            DialogResult result;
            result = MessageBox.Show("Bạn chắc chắn muốn thoát chứ", "THÔNG BÁO",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
                this.Close();
        }

        private void frmMenu_Load(object sender, EventArgs e)
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
            dtgMenu.DataSource = busmn.getMeNu();
        }

            private void dtgMenu_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                try
                {
                    int hang = e.RowIndex;
                    if (hang >= 0)
                    {
                        // Lấy dữ liệu từ DataGridView theo dòng được chọn
                        string maMonAn = dtgMenu[0, hang].Value.ToString();
                        string tenMonAn = dtgMenu[1, hang].Value.ToString();
                        string moTa = dtgMenu[2, hang].Value.ToString();
                        string donGia = dtgMenu[3, hang].Value.ToString();
                        string maNV = dtgMenu[4, hang].Value.ToString();
                        // Gán dữ liệu vào các ô textbox tương ứng
                        textMaMonAn.Text = maMonAn;
                        cbTenMonAn.Text = tenMonAn;
                        cbMoTa.Text = moTa;
                        textDonGia.Text = donGia;
                        cbMaNV.Text = maNV;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            string maMonAn = textMaMonAn.Text;
            string tenMonAn = cbTenMonAn.Text;
            string moTa = cbMoTa.Text;
            string donGia = textDonGia.Text;
            string maNV = cbMaNV.Text;
            if (busmn.themMN(maMonAn, tenMonAn, moTa, donGia, maNV) == true)
            {
                MessageBox.Show("Thêm Món Ăn Thành Công");
                dtgMenu.DataSource = busmn.getMeNu();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maMonAn = textMaMonAn.Text;

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa món ăn này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng xác nhận xóa, thực hiện thao tác xóa và cập nhật lại danh sách món ăn trên DataGridView
            if (result == DialogResult.Yes)
            {
                if (busmn.xoaMN(maMonAn))
                {
                    MessageBox.Show("Xóa thành công");
                    dtgMenu.DataSource = busmn.getMeNu();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textMaHoaDon_TextChanged(object sender, EventArgs e)
        {

        }

        private void textMaMonAn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbTenMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenMonAn.Text == "Táo" || cbTenMonAn.Text == "Ổi" || cbTenMonAn.Text == "CoCa" || cbTenMonAn.Text == "Bò Húc" || cbTenMonAn.Text == "Seven Up" || cbTenMonAn.Text == "Cam" || cbTenMonAn.Text == "Xoài" || cbTenMonAn.Text == "Dưa Hấu" || cbTenMonAn.Text == "Orange" || cbTenMonAn.Text == "Xúc Xích" || cbTenMonAn.Text == "Lạp Sườn")
            {
                textDonGia.Text = "10000";
            }
            if (cbTenMonAn.Text == "Cafe Ca Cao" || cbTenMonAn.Text == "Cafe Đen Đá" || cbTenMonAn.Text == "Cafe Sữa")
            {
                textDonGia.Text = "30000";
            }
            if (cbTenMonAn.Text == "Cafe Trà Sữa Chân Châu" || cbTenMonAn.Text == "Trà Sữa Matta" || cbTenMonAn.Text == "Trà Sữa Hồng Đào")
            {
                textDonGia.Text = "25000";
            }
            if (cbTenMonAn.Text == "Trà Quất Nha Đam" || cbTenMonAn.Text == "Trà Đào")
            {
                textDonGia.Text = "15000";
            }
        }
        private void btnTongHop_Click(object sender, EventArgs e)
        {
              dtgMenu.DataSource = busmn.getMeNu();
        }

        private void btnTraSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mô tả từ ComboBox
                string moTa = cbMoTa.Text;

                // Tạo chuỗi kết nối đến cơ sở dữ liệu
                string connectionString = "Data Source=DESKTOP-8SU7OS9\\SQLEXPRESS;Initial Catalog=VMHQuanLyQuanTraSua;Integrated Security=True";

                // Tạo đối tượng SqlConnection để kết nối đến cơ sở dữ liệu
                SqlConnection connection = new SqlConnection(connectionString);

                // Mở kết nối
                connection.Open();

                // Tạo câu truy vấn SQL để lấy danh sách các món ăn có mô tả tương ứng
                string sql = "SELECT MaMonAn, TenMonAn, MoTa, DonGia, MANV FROM MENU WHERE MoTa = N'Trà Sữa'";

                // Tạo đối tượng SqlCommand để thực hiện truy vấn
                SqlCommand command = new SqlCommand(sql, connection);

                // Tạo đừa tượng SqlDataAdapter để lấy dữ liệu và đổ vào DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();

                // Đổ dữ liệu từ SqlDataAdapter vào DataTable
                adapter.Fill(table);

                // Gán DataTable vào DataSource của DataGridView
                dtgMenu.DataSource = table;

                // Đóng kết nối
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnTraiCayEp_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mô tả từ ComboBox
                string moTa = cbMoTa.Text;

                // Tạo chuỗi kết nối đến cơ sở dữ liệu
                string connectionString = "Data Source=DESKTOP-8SU7OS9\\SQLEXPRESS;Initial Catalog=VMHQuanLyQuanTraSua;Integrated Security=True";

                // Tạo đối tượng SqlConnection để kết nối đến cơ sở dữ liệu
                SqlConnection connection = new SqlConnection(connectionString);

                // Mở kết nối
                connection.Open();

                // Tạo câu truy vấn SQL để lấy danh sách các món ăn có mô tả tương ứng
                string sql = "SELECT MaMonAn, TenMonAn, MoTa, DonGia, MANV FROM MENU WHERE MoTa = N'Trái Cây'";

                // Tạo đối tượng SqlCommand để thực hiện truy vấn
                SqlCommand command = new SqlCommand(sql, connection);

                // Tạo đừa tượng SqlDataAdapter để lấy dữ liệu và đổ vào DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();

                // Đổ dữ liệu từ SqlDataAdapter vào DataTable
                adapter.Fill(table);

                // Gán DataTable vào DataSource của DataGridView
                dtgMenu.DataSource = table;

                // Đóng kết nối
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnNuocNgot_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mô tả từ ComboBox
                string moTa = cbMoTa.Text;

                // Tạo chuỗi kết nối đến cơ sở dữ liệu
                string connectionString = "Data Source=DESKTOP-8SU7OS9\\SQLEXPRESS;Initial Catalog=VMHQuanLyQuanTraSua;Integrated Security=True";

                // Tạo đối tượng SqlConnection để kết nối đến cơ sở dữ liệu
                SqlConnection connection = new SqlConnection(connectionString);

                // Mở kết nối
                connection.Open();

                // Tạo câu truy vấn SQL để lấy danh sách các món ăn có mô tả tương ứng
                string sql = "SELECT MaMonAn, TenMonAn, MoTa, DonGia, MANV FROM MENU WHERE MoTa = N'Nước Ngọt'";

                // Tạo đối tượng SqlCommand để thực hiện truy vấn
                SqlCommand command = new SqlCommand(sql, connection);

                // Tạo đừa tượng SqlDataAdapter để lấy dữ liệu và đổ vào DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();

                // Đổ dữ liệu từ SqlDataAdapter vào DataTable
                adapter.Fill(table);

                // Gán DataTable vào DataSource của DataGridView
                dtgMenu.DataSource = table;

                // Đóng kết nối
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThucAn_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mô tả từ ComboBox
                string moTa = cbMoTa.Text;

                // Tạo chuỗi kết nối đến cơ sở dữ liệu
                string connectionString = "Data Source=DESKTOP-8SU7OS9\\SQLEXPRESS;Initial Catalog=VMHQuanLyQuanTraSua;Integrated Security=True";

                // Tạo đối tượng SqlConnection để kết nối đến cơ sở dữ liệu
                SqlConnection connection = new SqlConnection(connectionString);

                // Mở kết nối
                connection.Open();

                // Tạo câu truy vấn SQL để lấy danh sách các món ăn có mô tả tương ứng
                string sql = "SELECT MaMonAn, TenMonAn, MoTa, DonGia, MANV FROM MENU WHERE MoTa = N'Thức Ăn'";

                // Tạo đối tượng SqlCommand để thực hiện truy vấn
                SqlCommand command = new SqlCommand(sql, connection);

                // Tạo đừa tượng SqlDataAdapter để lấy dữ liệu và đổ vào DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();

                // Đổ dữ liệu từ SqlDataAdapter vào DataTable
                adapter.Fill(table);

                // Gán DataTable vào DataSource của DataGridView
                dtgMenu.DataSource = table;

                // Đóng kết nối
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            reportMenu rpmn = new reportMenu();
             rpmn.ShowDialog();
        }

        private void pctMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaMonMN_Click(object sender, EventArgs e)
        {
            string maMonAn = textMaMonAn.Text;
            string tenMonAn = cbTenMonAn.Text;
            string MoTa = cbMoTa.Text;
            string DonGia = textDonGia.Text;
            string MANV = cbMaNV.Text;

            bool result = busmn.SuaMN(maMonAn, tenMonAn, MoTa, DonGia, MANV);
            if (result)
            {
                MessageBox.Show("Cập nhật hóa đơn thành công!");
                dtgMenu.DataSource = busmn.getMeNu();

            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật hóa đơn!");
            }
        }

        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            string maHD = textMaHoaDon.Text;
            string maMonAn = textMaMonAn.Text;
            string tenMonAn = cbTenMonAn.Text;
            int soLuong = int.Parse(cbSoLuong.Text);
            string donGia = textDonGia.Text;
            if(cTHD.ThemCTHD(maHD, maMonAn, tenMonAn, soLuong, donGia))
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
;           }    
            else
                MessageBox.Show("Thêm không thành công", "Thông báo");
        }
    }
} 
