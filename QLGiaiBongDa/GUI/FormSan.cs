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
    public partial class FormSan : Form
    {
        public FormSan()
        {
            InitializeComponent();
        }

        SanBUS _sanBUS = new SanBUS();
        BindingSource _src = new BindingSource();

        private void FormSan_Load(object sender, EventArgs e)
        {
            gridData.DataSource = _src;
            LoadGrid();
        }

        private void LoadGrid()
        {
            _src.DataSource = _sanBUS.Get();
            _src.ResetBindings(true);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSan.Text))
            {
                AlertMsg.Show("Mã sân không được để trống !");
                return;
            }

            SanDTO obj = _sanBUS.Get(txtMaSan.Text);

            if (obj != null)
            {
                AlertMsg.Show("Mã sân đã tồn tại !");
                return;
            }

            SanDTO o = new SanDTO();
            o.MaSanNha = txtMaSan.Text;
            o.TenSanNha = txtTenSan.Text;
            o.DiaChi = txtDiaChi.Text;
            o.SucChua = (int) txtSucChua.Value;

            if (_sanBUS.Create(o))
            {
                InfoMsg.Show("Thêm mới thông tin sân thành công !");
                LoadGrid();
                return;
            }

            AlertMsg.Show("Thêm mới thông tin sân không thành công !");
        }

        private void gridData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!Helpers.IsValidRow(gridData.CurrentRow))
                return;

            SanDTO obj = gridData.CurrentRow.DataBoundItem as SanDTO;

            if (obj == null)
                return;

            Display(obj);
        }

        private void Display(SanDTO obj)
        {
            txtMaSan.Text = obj.MaSanNha;
            txtTenSan.Text = obj.TenSanNha;
            txtSucChua.Value = obj.SucChua;
            txtDiaChi.Text = obj.DiaChi;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Display(new SanDTO());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SanDTO obj = _sanBUS.Get(txtMaSan.Text);

            if (obj == null)
            {
                AlertMsg.Show("Không tìm thấy mã sân cần sửa !");
                return;
            }

            SanDTO o = new SanDTO();
            o.MaSanNha = txtMaSan.Text;
            o.TenSanNha = txtTenSan.Text;
            o.DiaChi = txtDiaChi.Text;
            o.SucChua = (int)txtSucChua.Value;

            if (_sanBUS.Edit(o))
            {
                InfoMsg.Show("Sửa thông tin sân thành công !");
                LoadGrid();
                return;
            }

            AlertMsg.Show("Sửa thông tin sân không thành công !");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SanDTO obj = _sanBUS.Get(txtMaSan.Text);

                if (obj == null)
                {
                    AlertMsg.Show("Không tìm thấy mã sân cần xoá !");
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn muốn xoá sân được chọn ?",
                 "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                if (_sanBUS.Delete(obj.MaSanNha))
                {
                    InfoMsg.Show("Xoá thông tin sân thành công !");
                    LoadGrid();
                    return;
                }

                AlertMsg.Show("Xoá thông tin sân không thành công !");
            }
            catch (Exception ex) {
                AlertMsg.Show("Xoá thông tin sân không thành công !");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                LoadGrid();
                return;
            }

            string searchTerm = txtSearch.Text.ToLower();

            List<SanDTO> ds = _sanBUS.Get();
            ds = ds.Where(x => x.TenSanNha.ToLower().Contains(searchTerm)).ToList();
            _src.DataSource = ds;
            _src.ResetBindings(true);
        }
    }
}
