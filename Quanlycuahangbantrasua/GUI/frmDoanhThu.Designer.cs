namespace Quanlycuahangbantrasua.GUI
{
    partial class frmDoanhThu
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
            this.lbDoanhThu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbDoanhThu = new System.Windows.Forms.GroupBox();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lbTuNgay = new System.Windows.Forms.Label();
            this.lbDenNgay = new System.Windows.Forms.Label();
            this.dptTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dptDenNgay = new System.Windows.Forms.DateTimePicker();
            this.grbThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.dtgThongTinCT = new System.Windows.Forms.DataGridView();
            this.lbTDT = new System.Windows.Forms.Label();
            this.textTongDoanhThu = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grbDoanhThu.SuspendLayout();
            this.grbThongTinChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgThongTinCT)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDoanhThu
            // 
            this.lbDoanhThu.AutoSize = true;
            this.lbDoanhThu.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.lbDoanhThu.Location = new System.Drawing.Point(330, 10);
            this.lbDoanhThu.Name = "lbDoanhThu";
            this.lbDoanhThu.Size = new System.Drawing.Size(172, 40);
            this.lbDoanhThu.TabIndex = 0;
            this.lbDoanhThu.Text = "Doanh Thu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbDoanhThu);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 66);
            this.panel1.TabIndex = 1;
            // 
            // grbDoanhThu
            // 
            this.grbDoanhThu.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.grbDoanhThu.Controls.Add(this.lbDoanhThu);
            this.grbDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.grbDoanhThu.Name = "grbDoanhThu";
            this.grbDoanhThu.Size = new System.Drawing.Size(865, 73);
            this.grbDoanhThu.TabIndex = 1;
            this.grbDoanhThu.TabStop = false;
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDoanhThu.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.btnDoanhThu.Location = new System.Drawing.Point(44, 98);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(165, 75);
            this.btnDoanhThu.TabIndex = 2;
            this.btnDoanhThu.Text = "Doanh Thu Hôm Nay";
            this.btnDoanhThu.UseVisualStyleBackColor = true;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheck.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.Red;
            this.btnCheck.Location = new System.Drawing.Point(638, 102);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(165, 75);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lbTuNgay
            // 
            this.lbTuNgay.AutoSize = true;
            this.lbTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTuNgay.Location = new System.Drawing.Point(246, 102);
            this.lbTuNgay.Name = "lbTuNgay";
            this.lbTuNgay.Size = new System.Drawing.Size(67, 20);
            this.lbTuNgay.TabIndex = 4;
            this.lbTuNgay.Text = "Từ Ngày";
            // 
            // lbDenNgay
            // 
            this.lbDenNgay.AutoSize = true;
            this.lbDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDenNgay.Location = new System.Drawing.Point(234, 153);
            this.lbDenNgay.Name = "lbDenNgay";
            this.lbDenNgay.Size = new System.Drawing.Size(79, 20);
            this.lbDenNgay.TabIndex = 5;
            this.lbDenNgay.Text = "Đến Ngày";
            // 
            // dptTuNgay
            // 
            this.dptTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptTuNgay.Location = new System.Drawing.Point(319, 102);
            this.dptTuNgay.Name = "dptTuNgay";
            this.dptTuNgay.Size = new System.Drawing.Size(294, 26);
            this.dptTuNgay.TabIndex = 6;
            // 
            // dptDenNgay
            // 
            this.dptDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptDenNgay.Location = new System.Drawing.Point(319, 153);
            this.dptDenNgay.Name = "dptDenNgay";
            this.dptDenNgay.Size = new System.Drawing.Size(294, 26);
            this.dptDenNgay.TabIndex = 7;
            // 
            // grbThongTinChiTiet
            // 
            this.grbThongTinChiTiet.Controls.Add(this.dtgThongTinCT);
            this.grbThongTinChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinChiTiet.Location = new System.Drawing.Point(78, 198);
            this.grbThongTinChiTiet.Name = "grbThongTinChiTiet";
            this.grbThongTinChiTiet.Size = new System.Drawing.Size(697, 197);
            this.grbThongTinChiTiet.TabIndex = 8;
            this.grbThongTinChiTiet.TabStop = false;
            this.grbThongTinChiTiet.Text = "Thông Tin Chi Tiết";
            // 
            // dtgThongTinCT
            // 
            this.dtgThongTinCT.BackgroundColor = System.Drawing.Color.White;
            this.dtgThongTinCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgThongTinCT.Location = new System.Drawing.Point(19, 23);
            this.dtgThongTinCT.Name = "dtgThongTinCT";
            this.dtgThongTinCT.Size = new System.Drawing.Size(659, 159);
            this.dtgThongTinCT.TabIndex = 0;
            this.dtgThongTinCT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgThongTinCT_CellClick);
            // 
            // lbTDT
            // 
            this.lbTDT.AutoSize = true;
            this.lbTDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTDT.Location = new System.Drawing.Point(147, 426);
            this.lbTDT.Name = "lbTDT";
            this.lbTDT.Size = new System.Drawing.Size(128, 20);
            this.lbTDT.TabIndex = 9;
            this.lbTDT.Text = "Tổng Doanh Thu";
            // 
            // textTongDoanhThu
            // 
            this.textTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTongDoanhThu.Location = new System.Drawing.Point(283, 416);
            this.textTongDoanhThu.Multiline = true;
            this.textTongDoanhThu.Name = "textTongDoanhThu";
            this.textTongDoanhThu.Size = new System.Drawing.Size(330, 42);
            this.textTongDoanhThu.TabIndex = 10;
            // 
            // btnDong
            // 
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDong.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.Red;
            this.btnDong.Location = new System.Drawing.Point(666, 416);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(90, 42);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(865, 476);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.textTongDoanhThu);
            this.Controls.Add(this.lbTDT);
            this.Controls.Add(this.grbThongTinChiTiet);
            this.Controls.Add(this.dptDenNgay);
            this.Controls.Add(this.dptTuNgay);
            this.Controls.Add(this.lbDenNgay);
            this.Controls.Add(this.lbTuNgay);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnDoanhThu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoanhThu";
            this.Text = "frmDoanhThu";
            this.Load += new System.EventHandler(this.frmDoanhThu_Load);
            this.panel1.ResumeLayout(false);
            this.grbDoanhThu.ResumeLayout(false);
            this.grbDoanhThu.PerformLayout();
            this.grbThongTinChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgThongTinCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDoanhThu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lbTuNgay;
        private System.Windows.Forms.Label lbDenNgay;
        private System.Windows.Forms.DateTimePicker dptTuNgay;
        private System.Windows.Forms.DateTimePicker dptDenNgay;
        private System.Windows.Forms.GroupBox grbThongTinChiTiet;
        private System.Windows.Forms.DataGridView dtgThongTinCT;
        private System.Windows.Forms.Label lbTDT;
        private System.Windows.Forms.TextBox textTongDoanhThu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.GroupBox grbDoanhThu;
        private System.Windows.Forms.Button btnDoanhThu;
    }
}