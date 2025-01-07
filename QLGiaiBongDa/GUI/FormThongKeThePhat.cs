using Microsoft.Reporting.WinForms;
using QLGiaiBongDa.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGiaiBongDa.GUI
{
    public partial class FormThongKeThePhat : Form
    {
        public FormThongKeThePhat()
        {
            InitializeComponent();
        }

        ThongKeBUS _thongKeBUS = new ThongKeBUS();
        private void FormThongKeThePhat_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource();
            //// Must match the DataSource in the RDLC
            reportDataSource.Name = "vThongKeThePhat";
            reportDataSource.Value = _thongKeBUS.ThongKeThePhat();
            this.rptViewer.ProcessingMode = ProcessingMode.Local;
            this.rptViewer.LocalReport.ReportPath = "Reports/RptThongKeThePhat.rdlc";
            this.rptViewer.LocalReport.SetParameters(new ReportParameter("NGAY_LAP", string.Format("Ngày {0} tháng {1} năm {2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year)));

            this.rptViewer.LocalReport.DataSources.Clear();
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource);
            this.rptViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.rptViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.rptViewer.ZoomPercent = 100;
            this.rptViewer.RefreshReport();
        }
    }
}
