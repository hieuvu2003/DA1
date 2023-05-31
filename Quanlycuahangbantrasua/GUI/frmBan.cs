using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
    public partial class frmBan : Form
    {
        BUS_Ban busb = new BUS_Ban();
        bool kt; int dem;

        public frmBan()
        {
            InitializeComponent();
        }
        void HienThiBanChuaSD()
        {
            chklsbBanTrong.Items.Clear();
            DataTable dt = busb.LayDSBanChuaSD(); // sử dụng phương thức LayDSChuaSD() của lớp DAL_Ban
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chklsbBanTrong.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        bool KiemTraTrung(string maBan)
        {
            DataTable dt = busb.getBan();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == maBan)
                    return true;
            }
            return false;
        }

        void HienThiBanDangSD()
        {
            chklsbBanDangSD.Items.Clear();
            DataTable dt = busb.LayDSBanDangSD(); // sử dụng phương thức LayDSBanDangSD() của lớp DAL_Ban
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chklsbBanDangSD.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbTenBan_Click(object sender, EventArgs e)
        {

        }

        private void frmBan_Load(object sender, EventArgs e)
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
        int ktrachuoi(string s)
        {
            /* Khai bao mot chuoi */
            int dem = 0;
            foreach (char chr in s)
            {
                dem += 1;

            }
            return dem;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = KiemTraTrung(textThemBan.Text);
            dem = ktrachuoi(textThemBan.Text);
            if (dem > 10)
            {
                MessageBox.Show("Tên Bàn không quá 10 ký tự");
            }
            else if (textThemBan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên bàn");
            }
            else if (kt == true)
            {
                busb.ThemBan(new Ban(textThemBan.Text, "ChưaSD"));
                HienThiBanChuaSD();
            }
            else
            {
                bool result = busb.ThemBan(new Ban(textThemBan.Text, "ChưaSD"));
                if (result)
                {
                    MessageBox.Show("Thêm Bàn Thành Công");
                    HienThiBanChuaSD();
                }
                else
                {
                    MessageBox.Show("Thêm Bàn Thất Bại");
                }
            }
            textThemBan.Text = "";
            textThemBan.Focus();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklsbBanTrong.Items.Count; i++)
            {
                if (chklsbBanTrong.GetItemChecked(i))
                {
                    DialogResult ret = MessageBox.Show("Bạn có chắc muốn xóa không ?",
                        "Thông Báo",
                        MessageBoxButtons.YesNo);
                    if (ret == DialogResult.Yes)
                    {
                        string maBan = chklsbBanTrong.Items[i].ToString();
                        if (busb.XoaBan(maBan))
                        {
                            chklsbBanTrong.Items.RemoveAt(i);
                            HienThiBanChuaSD();
                        }
                        else
                        {
                            MessageBox.Show("Xóa bàn không thành công!");
                        }
                    }
                }
            }
        }
    
        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn chắc chắn muốn thoát chứ", "THÔNG BÁO",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
                this.Close();
        }

        private void chklsbBanTrong_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chklsbBanTrong.Items.Count; i++)
            {
                if (chklsbBanTrong.GetItemChecked(i))
                {
                    busb.LeftToRight(chklsbBanTrong.Items[i].ToString());
                    chklsbBanTrong.Items.RemoveAt(i);
                    HienThiBanDangSD();
                }

            }
        }

        private void chklsbBanDangSD_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chklsbBanDangSD.Items.Count; i++)
            {
                if (chklsbBanDangSD.SelectedIndex == i)
                {
                    busb.RightToLeft(chklsbBanDangSD.Items[i].ToString());
                    chklsbBanDangSD.Items.RemoveAt(i);
                    HienThiBanChuaSD();
                }
            }
        }
    }
}
