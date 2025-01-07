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
    public partial class FormLoaiTranDau : Form
    {
        public FormLoaiTranDau()
        {
            InitializeComponent();
        }

        LoaiTranDauBUS _loaiTranDauBUS = new LoaiTranDauBUS();
        BindingSource _src = new BindingSource();

        private void FormLoaiTranDau_Load(object sender, EventArgs e)
        {
            gridData.DataSource = _src;
            LoadGrid();
        }

        private void LoadGrid()
        {
            _src.DataSource = _loaiTranDauBUS.Get();
            _src.ResetBindings(true);
        }

        private void gridData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!Helpers.IsValidRow(gridData.CurrentRow))
                return;

            LoaiTranDauDTO obj = gridData.CurrentRow.DataBoundItem as LoaiTranDauDTO;

            if (obj == null)
                return;

            Display(obj);
        }

        private void Display(LoaiTranDauDTO obj)
        {
            txtMaLoai.Text = obj.MaLoai;
            txtTenLoai.Text = obj.TenLoai;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Display(new LoaiTranDauDTO());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLoai.Text))
            {
                AlertMsg.Show("Mã loại trận đấu không được để trống !");
                return;
            }

            LoaiTranDauDTO obj = _loaiTranDauBUS.Get(txtMaLoai.Text);
            
            if (obj != null)
            {
                AlertMsg.Show("Mã loại trận đấu đã tồn tại !");
                return;
            }

            LoaiTranDauDTO o = new LoaiTranDauDTO();
            o.MaLoai = txtMaLoai.Text;
            o.TenLoai = txtTenLoai.Text;

            if (_loaiTranDauBUS.Create(o))
            {
                InfoMsg.Show("Thêm loại trận đấu thành công !");
                LoadGrid();
                return;
            }

            AlertMsg.Show("Thêm loại trận đấu không thành công !");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LoaiTranDauDTO obj = _loaiTranDauBUS.Get(txtMaLoai.Text);

            if (obj == null)
            {
                AlertMsg.Show("Không tìm thấy mã loại trận đấu cần sửa !");
                return;
            }

            LoaiTranDauDTO o = new LoaiTranDauDTO();
            o.MaLoai = txtMaLoai.Text;
            o.TenLoai = txtTenLoai.Text;

            if (_loaiTranDauBUS.Edit(o))
            {
                InfoMsg.Show("Sửa thông tin loại trận đấu thành công !");
                LoadGrid();
                return;
            }

            AlertMsg.Show("Sửa thông tin loại trận đấu không thành công !");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                LoaiTranDauDTO obj = _loaiTranDauBUS.Get(txtMaLoai.Text);

                if (obj == null)
                {
                    AlertMsg.Show("Không tìm thấy mã loại trận đấu cần xoá !");
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn muốn xoá loại trận đấu được chọn ?",
                  "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                if (_loaiTranDauBUS.Delete(obj.MaLoai))
                {
                    InfoMsg.Show("Xoá thông tin loại trận đấu thành công !");
                    LoadGrid();
                    return;
                }

                AlertMsg.Show("Xoá thông tin loại trận đấu không thành công !");
            }
            catch (Exception ex)
            {
                AlertMsg.Show("Xoá thông tin loại trận đấu không thành công !");
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

            List<LoaiTranDauDTO> ds = _loaiTranDauBUS.Get();
            ds = ds.Where(x => x.TenLoai.ToLower().Contains(searchTerm))
                .ToList();
            _src.DataSource = ds;
            _src.ResetBindings(true);
        }
    }
}
