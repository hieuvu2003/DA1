    
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Quanlycuahangbantrasua.BUS;
using Quanlycuahangbantrasua.DAL;

namespace Quanlycuahangbantrasua.GUI
{
    public partial class reportMenu : Form
    {
        BUS_Menu busmn = new BUS_Menu();

        public reportMenu()
        {
            InitializeComponent();
        }
       
        private void reportMenu_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    //WINDOW/C
            //    reportViewer1.LocalReport.ReportEmbeddedResource = "Quanlycuahangbantrasua.Report1.rdlc";
            //    ReportDataSource reportDataSource = new ReportDataSource();
            //    reportDataSource.Name = "DataSet1";
            //    reportDataSource.Value = busmn.getMeNu();
            //    reportViewer1.LocalReport.DataSources.Add (reportDataSource);
            //    this.reportViewer1.RefreshReport(); 
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //WINDOW/C
            reportViewer1.LocalReport.ReportEmbeddedResource = "Quanlycuahangbantrasua.Report1.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet1";
            reportDataSource.Value = busmn.getMeNu();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
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

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
