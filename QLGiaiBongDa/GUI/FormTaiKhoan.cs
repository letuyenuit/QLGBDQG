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
    public partial class FormTaiKhoan : Form
    {
        public FormTaiKhoan()
        {
            InitializeComponent();
        }

        TaiKhoanBUS _taiKhoanBUS = new TaiKhoanBUS();
        BindingSource _src = new BindingSource();

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            gridData.DataSource = _src;
            LoadGrid();
        }

        private void LoadGrid()
        {
            _src.DataSource = _taiKhoanBUS.Get();
            _src.ResetBindings(true);
        }

        private void gridData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!Helpers.IsValidRow(gridData.CurrentRow))
                return;

            TaiKhoanDTO obj = gridData.CurrentRow.DataBoundItem as TaiKhoanDTO;

            if (obj == null)
                return;

            Display(obj);

        }

        private void Display(TaiKhoanDTO obj)
        {
            txtMaTK.Text = obj.MaTK;
            txtMatKhau.Text = obj.MatKhau;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Display(new TaiKhoanDTO());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTK.Text))
            {
                AlertMsg.Show("Mã tài khoản không được để trống !");
                return;
            }

            TaiKhoanDTO obj = _taiKhoanBUS.Get(txtMaTK.Text);
            
            if (obj != null)
            {
                AlertMsg.Show("Mã tài khoản đã tồn tại !");
                return;
            }
            
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                AlertMsg.Show("Mật khẩu không được để trống !");
                return;
            }

            TaiKhoanDTO o = new TaiKhoanDTO();
            o.MaTK = txtMaTK.Text;
            o.MatKhau = txtMatKhau.Text;

            if (_taiKhoanBUS.Create(o))
            {
                InfoMsg.Show("Thêm mới tài khoản thành công !");
                LoadGrid();
                return;
            }
            AlertMsg.Show("Thêm mới tài khoản không thành công !");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO obj = _taiKhoanBUS.Get(txtMaTK.Text);

            if (obj == null)
            {
                AlertMsg.Show("Không tìm thấy mã tài khoản cần sửa !");
                return;
            }

            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                AlertMsg.Show("Mật khẩu không được để trống !");
                return;
            }

            TaiKhoanDTO o = new TaiKhoanDTO();
            o.MaTK = txtMaTK.Text;
            o.MatKhau = txtMatKhau.Text;

            if (_taiKhoanBUS.Edit(o))
            {
                InfoMsg.Show("Sửa thông tin tài khoản thành công !");
                LoadGrid();
                return;
            }
            AlertMsg.Show("Sửa thông tin tài khoản không thành công !");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO obj = _taiKhoanBUS.Get(txtMaTK.Text);

            if (obj == null)
            {
                AlertMsg.Show("Không tìm thấy mã tài khoản cần xoá !");
                return;
            }

            if (obj.MaTK == FormMain.User.MaTK)
            {
                AlertMsg.Show("Không thể xoá tài khoản đang đăng nhập !");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn muốn xoá thông tin tài khoản được chọn ?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            if (_taiKhoanBUS.Delete(obj.MaTK))
            {
                InfoMsg.Show("Xoá thông tin tài khoản thành công !");
                LoadGrid();
                return;
            }

            AlertMsg.Show("Xoá thông tin tài khoản không thành công !");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                LoadGrid();
                return;
            }

            string searchTerm = txtSearch.Text.ToLower();

            List<TaiKhoanDTO> ds = _taiKhoanBUS.Get();
            ds = ds.Where(x => x.MaTK.ToLower().Contains(searchTerm)).ToList();
            _src.DataSource = ds;
            _src.ResetBindings(true);
        }
    }
}
