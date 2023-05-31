namespace Quanlycuahangbantrasua.GUI
{
    partial class frmKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbThemKH = new System.Windows.Forms.GroupBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.textSDT = new System.Windows.Forms.TextBox();
            this.textTenKH = new System.Windows.Forms.TextBox();
            this.textMaKH = new System.Windows.Forms.TextBox();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtgKhachHang = new System.Windows.Forms.DataGridView();
            this.grbThemKH.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThemKH
            // 
            this.grbThemKH.Controls.Add(this.cbGioiTinh);
            this.grbThemKH.Controls.Add(this.textSDT);
            this.grbThemKH.Controls.Add(this.textTenKH);
            this.grbThemKH.Controls.Add(this.textMaKH);
            this.grbThemKH.Controls.Add(this.lbSDT);
            this.grbThemKH.Controls.Add(this.lbTen);
            this.grbThemKH.Controls.Add(this.lbGioiTinh);
            this.grbThemKH.Controls.Add(this.lbMaKH);
            this.grbThemKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThemKH.ForeColor = System.Drawing.Color.DarkBlue;
            this.grbThemKH.Location = new System.Drawing.Point(42, 22);
            this.grbThemKH.Name = "grbThemKH";
            this.grbThemKH.Size = new System.Drawing.Size(775, 131);
            this.grbThemKH.TabIndex = 0;
            this.grbThemKH.TabStop = false;
            this.grbThemKH.Text = "Thêm Khách Hàng";
            this.grbThemKH.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.ForeColor = System.Drawing.Color.Red;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "nam",
            "nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(178, 78);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(163, 26);
            this.cbGioiTinh.TabIndex = 7;
            // 
            // textSDT
            // 
            this.textSDT.ForeColor = System.Drawing.Color.Red;
            this.textSDT.Location = new System.Drawing.Point(554, 78);
            this.textSDT.Name = "textSDT";
            this.textSDT.Size = new System.Drawing.Size(157, 24);
            this.textSDT.TabIndex = 6;
            // 
            // textTenKH
            // 
            this.textTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTenKH.ForeColor = System.Drawing.Color.Red;
            this.textTenKH.Location = new System.Drawing.Point(554, 32);
            this.textTenKH.Multiline = true;
            this.textTenKH.Name = "textTenKH";
            this.textTenKH.Size = new System.Drawing.Size(157, 24);
            this.textTenKH.TabIndex = 5;
            // 
            // textMaKH
            // 
            this.textMaKH.ForeColor = System.Drawing.Color.Red;
            this.textMaKH.Location = new System.Drawing.Point(178, 32);
            this.textMaKH.Name = "textMaKH";
            this.textMaKH.Size = new System.Drawing.Size(163, 24);
            this.textMaKH.TabIndex = 4;
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(421, 79);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(102, 18);
            this.lbSDT.TabIndex = 3;
            this.lbSDT.Text = "Số Điện Thoại";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(405, 35);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(118, 18);
            this.lbTen.TabIndex = 2;
            this.lbTen.Text = "Tên Khách Hàng";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(53, 79);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(67, 18);
            this.lbGioiTinh.TabIndex = 1;
            this.lbGioiTinh.Text = "Giới Tính";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Location = new System.Drawing.Point(36, 38);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(114, 18);
            this.lbMaKH.TabIndex = 0;
            this.lbMaKH.Text = "Mã Khách Hàng";
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnSua);
            this.grbChucNang.Controls.Add(this.btnThoat);
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChucNang.ForeColor = System.Drawing.Color.DarkBlue;
            this.grbChucNang.Location = new System.Drawing.Point(42, 173);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(775, 72);
            this.grbChucNang.TabIndex = 1;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức Năng";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Red;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.ForeColor = System.Drawing.Color.Navy;
            this.btnSua.Location = new System.Drawing.Point(226, 26);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 33);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Location = new System.Drawing.Point(614, 25);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 34);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Location = new System.Drawing.Point(424, 25);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 33);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Red;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Location = new System.Drawing.Point(39, 28);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 33);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtgKhachHang
            // 
            this.dtgKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dtgKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKhachHang.Location = new System.Drawing.Point(42, 263);
            this.dtgKhachHang.Name = "dtgKhachHang";
            this.dtgKhachHang.Size = new System.Drawing.Size(775, 200);
            this.dtgKhachHang.TabIndex = 2;
            this.dtgKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKhachHang_CellClick);
            this.dtgKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKhachHang_CellContentClick);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(865, 475);
            this.Controls.Add(this.dtgKhachHang);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.grbThemKH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.grbThemKH.ResumeLayout(false);
            this.grbThemKH.PerformLayout();
            this.grbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThemKH;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.DataGridView dtgKhachHang;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.TextBox textSDT;
        private System.Windows.Forms.TextBox textTenKH;
        private System.Windows.Forms.TextBox textMaKH;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
    }
}