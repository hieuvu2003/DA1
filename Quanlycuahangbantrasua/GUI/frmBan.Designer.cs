namespace Quanlycuahangbantrasua.GUI
{
    partial class frmBan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.grbSuDung = new System.Windows.Forms.GroupBox();
            this.chklsbBanDangSD = new System.Windows.Forms.CheckedListBox();
            this.grbtrong = new System.Windows.Forms.GroupBox();
            this.chklsbBanTrong = new System.Windows.Forms.CheckedListBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.textThemBan = new System.Windows.Forms.TextBox();
            this.lbTenBan = new System.Windows.Forms.Label();
            this.lbQuanLy = new System.Windows.Forms.Label();
            this.grbBan = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.grbSuDung.SuspendLayout();
            this.grbtrong.SuspendLayout();
            this.grbBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.grbSuDung);
            this.panel1.Controls.Add(this.grbtrong);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.textThemBan);
            this.panel1.Controls.Add(this.lbTenBan);
            this.panel1.Location = new System.Drawing.Point(1, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 391);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.Cyan;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDong.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDong.Location = new System.Drawing.Point(711, 337);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(88, 41);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Cyan;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnXoa.Location = new System.Drawing.Point(562, 337);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 41);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa Bàn";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // grbSuDung
            // 
            this.grbSuDung.Controls.Add(this.chklsbBanDangSD);
            this.grbSuDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSuDung.ForeColor = System.Drawing.Color.Blue;
            this.grbSuDung.Location = new System.Drawing.Point(447, 154);
            this.grbSuDung.Name = "grbSuDung";
            this.grbSuDung.Size = new System.Drawing.Size(352, 167);
            this.grbSuDung.TabIndex = 6;
            this.grbSuDung.TabStop = false;
            this.grbSuDung.Text = "Danh Sách Bàn Đang Sử Dụng";
            // 
            // chklsbBanDangSD
            // 
            this.chklsbBanDangSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklsbBanDangSD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.chklsbBanDangSD.FormattingEnabled = true;
            this.chklsbBanDangSD.Location = new System.Drawing.Point(33, 33);
            this.chklsbBanDangSD.Name = "chklsbBanDangSD";
            this.chklsbBanDangSD.Size = new System.Drawing.Size(287, 114);
            this.chklsbBanDangSD.TabIndex = 4;
            this.chklsbBanDangSD.SelectedIndexChanged += new System.EventHandler(this.chklsbBanDangSD_SelectedIndexChanged);
            // 
            // grbtrong
            // 
            this.grbtrong.Controls.Add(this.chklsbBanTrong);
            this.grbtrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbtrong.ForeColor = System.Drawing.Color.Blue;
            this.grbtrong.Location = new System.Drawing.Point(64, 154);
            this.grbtrong.Name = "grbtrong";
            this.grbtrong.Size = new System.Drawing.Size(342, 167);
            this.grbtrong.TabIndex = 5;
            this.grbtrong.TabStop = false;
            this.grbtrong.Text = "Danh Sách Bàn Trống";
            // 
            // chklsbBanTrong
            // 
            this.chklsbBanTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklsbBanTrong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.chklsbBanTrong.FormattingEnabled = true;
            this.chklsbBanTrong.Items.AddRange(new object[] {
            "Bàn 1",
            "Bàn 2",
            "Bàn 3",
            "Bàn 4",
            "Bàn 5"});
            this.chklsbBanTrong.Location = new System.Drawing.Point(27, 33);
            this.chklsbBanTrong.Name = "chklsbBanTrong";
            this.chklsbBanTrong.Size = new System.Drawing.Size(282, 114);
            this.chklsbBanTrong.TabIndex = 3;
            this.chklsbBanTrong.SelectedIndexChanged += new System.EventHandler(this.chklsbBanTrong_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Cyan;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Red;
            this.btnThem.Location = new System.Drawing.Point(689, 50);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 41);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm Bàn";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // textThemBan
            // 
            this.textThemBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textThemBan.Location = new System.Drawing.Point(257, 51);
            this.textThemBan.Multiline = true;
            this.textThemBan.Name = "textThemBan";
            this.textThemBan.Size = new System.Drawing.Size(401, 40);
            this.textThemBan.TabIndex = 1;
            // 
            // lbTenBan
            // 
            this.lbTenBan.AutoSize = true;
            this.lbTenBan.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenBan.ForeColor = System.Drawing.Color.Green;
            this.lbTenBan.Location = new System.Drawing.Point(91, 54);
            this.lbTenBan.Name = "lbTenBan";
            this.lbTenBan.Size = new System.Drawing.Size(160, 29);
            this.lbTenBan.TabIndex = 0;
            this.lbTenBan.Text = "Nhập Tên Bàn:";
            this.lbTenBan.Click += new System.EventHandler(this.lbTenBan_Click);
            // 
            // lbQuanLy
            // 
            this.lbQuanLy.AutoSize = true;
            this.lbQuanLy.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuanLy.ForeColor = System.Drawing.Color.Yellow;
            this.lbQuanLy.Location = new System.Drawing.Point(338, 16);
            this.lbQuanLy.Name = "lbQuanLy";
            this.lbQuanLy.Size = new System.Drawing.Size(205, 39);
            this.lbQuanLy.TabIndex = 2;
            this.lbQuanLy.Text = "Quản Lý Bàn";
            // 
            // grbBan
            // 
            this.grbBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbBan.Controls.Add(this.lbQuanLy);
            this.grbBan.Location = new System.Drawing.Point(1, -2);
            this.grbBan.Name = "grbBan";
            this.grbBan.Size = new System.Drawing.Size(855, 73);
            this.grbBan.TabIndex = 3;
            this.grbBan.TabStop = false;
            // 
            // frmBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 459);
            this.Controls.Add(this.grbBan);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBan";
            this.Text = "frmBan";
            this.Load += new System.EventHandler(this.frmBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbSuDung.ResumeLayout(false);
            this.grbtrong.ResumeLayout(false);
            this.grbBan.ResumeLayout(false);
            this.grbBan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox textThemBan;
        private System.Windows.Forms.Label lbTenBan;
        private System.Windows.Forms.Label lbQuanLy;
        private System.Windows.Forms.CheckedListBox chklsbBanDangSD;
        private System.Windows.Forms.CheckedListBox chklsbBanTrong;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox grbSuDung;
        private System.Windows.Forms.GroupBox grbtrong;
        private System.Windows.Forms.GroupBox grbBan;
    }
}