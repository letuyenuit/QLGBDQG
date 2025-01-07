using QLGiaiBongDa.BUS;
using QLGiaiBongDa.DTO;
using QLGiaiBongDa.Utils;
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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        TaiKhoanBUS _bus = new TaiKhoanBUS();

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            txtMaTK.Text = "admin";
            txtMatKhau.Text = "admin";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTK.Text))
            {
                AlertMsg.Show("Mã tài khoản không được bỏ trống !");
                return;
            }

            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                AlertMsg.Show("Mật khẩu không được bỏ trống !");
                return;
            }

            TaiKhoanDTO obj = _bus.Get(txtMaTK.Text);

            if (obj == null)
            {
                AlertMsg.Show("Tên tài khoản hoặc mật khẩu không đúng !");
                return;
            }


            if (obj.MatKhau != txtMatKhau.Text)
            {
                AlertMsg.Show("Tên tài khoản hoặc mật khẩu không đúng !");
                return;
            }

            this.Hide();
            FormMain frm = new FormMain(obj);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            this.Show();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát ứng dụng ?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
