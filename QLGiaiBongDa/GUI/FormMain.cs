using QLGiaiBongDa.DTO;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(TaiKhoanDTO user)
            : this()
        {
            User = user;
        }

        public static TaiKhoanDTO User;

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuDoiBong_Click(object sender, EventArgs e)
        {
            LoadForm(new FormDoiBong());
        }
        private void mnuQuyDinhDoiBong_Click(object sender, EventArgs e)
        {
            LoadForm(new FormQuyDinhDoiBong());
        }
        public void LoadForm(Form frm)
        {
            if (frm == null)
                return;

            // Close all current child form
            foreach (var form in this.MdiChildren)
            {
                form.Close();
            }

            // Load form
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void mnuTrongTai_Click(object sender, EventArgs e)
        {
            //LoadForm(new FormTrongTai());
        }

        private void mnuCauThu_Click(object sender, EventArgs e)
        {
            LoadForm(new FormCauThu());
        }


        private void mnuSan_Click(object sender, EventArgs e)
        {
            LoadForm(new FormSan());
        }

        private void mnuLoaiTranDau_Click(object sender, EventArgs e)
        {
            LoadForm(new FormLoaiTranDau());
        }

        private void mnuTaiKhoan_Click(object sender, EventArgs e)
        {
            LoadForm(new FormTaiKhoan());
        }

        private void mnuQLTranDau_Click(object sender, EventArgs e)
        {
            LoadForm(new FormTranDau());
        }


        private void mnuBanThang_Click(object sender, EventArgs e)
        {
            LoadForm(new FormBanThang());
        }


        private void mnuBangXepHang_Click(object sender, EventArgs e)
        {
            LoadForm(new FormBangXepHang());
        }

        private void mnuThongKeKetQua_Click(object sender, EventArgs e)
        {
            LoadForm(new FormThongKeKetQua());
        }

        private void mnuThongKeThePhat_Click(object sender, EventArgs e)
        {
            LoadForm(new FormThongKeThePhat());
        }

        private void mnuLoaiBanThang_Click(object sender, EventArgs e)
        {
            LoadForm(new FormLoaiBT());
        }

        private void mnuKetQuaThiDau_Click(object sender, EventArgs e)
        {
            LoadForm(new FormKetQuaTranDau());
        }
    }
}
