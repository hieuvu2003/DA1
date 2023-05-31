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
    public partial class frmDoanhThu : Form
    {
        BUS_HoaDon bushd = new BUS_HoaDon();
        DAL_HoaDon dalhd = new  DAL_HoaDon();
        BUS_DoanhThu doanhThu = new BUS_DoanhThu();
        long tongDoanhThu;

        public frmDoanhThu()
        { 
            InitializeComponent();
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
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
            dtgThongTinCT.DataSource = bushd.getHoaDon();
        }
        public long TongDoanhThuHomNay()
        {
            tongDoanhThu = 0;
            long tongtien = 0;
            DataTable dt = doanhThu.LayDSHoaDonChoDoanhThuHomNay();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tongtien = long.Parse(dt.Rows[i][5].ToString());
                tongDoanhThu += tongtien;
            }
            return tongDoanhThu;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn chắc chắn muốn thoát chứ", "THÔNG BÁO",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
                this.Close();
        }

        private void dtgThongTinCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            long totalDoanhThuHomNay = TongDoanhThuHomNay();
            textTongDoanhThu.Text = totalDoanhThuHomNay.ToString();
        }
        public long TongDoanhThuTungayDenNgay()
        {
            tongDoanhThu = 0;
            long tongtien = 0;
            DataTable dt = doanhThu.LayDSHoaDonChoDoanhThuTuNgayDenNgay(dptTuNgay.Value, dptDenNgay.Value);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tongtien = long.Parse(dt.Rows[i][5].ToString());
                tongDoanhThu += tongtien;
            }
            return tongDoanhThu;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            long totalDoanhThu = TongDoanhThuTungayDenNgay();
            textTongDoanhThu.Text = totalDoanhThu.ToString();
        }
    }

}
