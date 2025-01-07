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
    public partial class FormLoaiBT : Form
    {
        public FormLoaiBT()
        {
            InitializeComponent();
        }

        BanThangBUS _banThangBUS = new BanThangBUS();
        BindingSource _src = new BindingSource();

        private void FormSan_Load(object sender, EventArgs e)
        {
            gridDataViTri.DataSource = _src;
            LoadGrid();
        }

        private void LoadGrid()
        {
            _src.DataSource = _banThangBUS.GetLoaiBT();
            _src.ResetBindings(true);
            gridDataViTri.Columns[2].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaLoaiBT.Text))
                {
                    AlertMsg.Show("Mã loại BT không được để trống !");
                    return;
                }

                LoaiBanThangDTO obj = _banThangBUS.GetLoaiBTBy(txtMaLoaiBT.Text);

                if (obj != null)
                {
                    AlertMsg.Show("Mã vi tri đã tồn tại !");
                    return;
                }

                LoaiBanThangDTO o = new LoaiBanThangDTO();
                o.MaLoaiBT = txtMaLoaiBT.Text;
                o.TenLoai = lbTenLLoaiBT.Text;
                o.MoTa = "";

                if (_banThangBUS.CreateLoaiBT(o))
                {
                    InfoMsg.Show("Thêm mới loại BT thành công !");
                    LoadGrid();
                    return;
                }

                AlertMsg.Show("Thêm mới loại BT không thành công !");
            }
            catch (Exception ex) {
                AlertMsg.Show("Thêm mới loại BT không thành công !");
            }
        }

        private void gridData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!Helpers.IsValidRow(gridDataViTri.CurrentRow))
                return;

            LoaiBanThangDTO obj = gridDataViTri.CurrentRow.DataBoundItem as LoaiBanThangDTO;

            if (obj == null)
                return;

            Display(obj);
        }

        private void Display(LoaiBanThangDTO obj)
        {
            txtMaLoaiBT.Text = obj.MaLoaiBT;
            lbTenLLoaiBT.Text = obj.TenLoai;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Display(new LoaiBanThangDTO());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                LoaiBanThangDTO obj = _banThangBUS.GetLoaiBTBy(txtMaLoaiBT.Text);

                if (obj == null)
                {
                    AlertMsg.Show("Không tìm thấy loại bàn thắng cần sửa !");
                    return;
                }

                LoaiBanThangDTO o = new LoaiBanThangDTO();
                o.MaLoaiBT = txtMaLoaiBT.Text;
                o.TenLoai = lbTenLLoaiBT.Text;

                if (_banThangBUS.EditLoaiBT(o))
                {
                    InfoMsg.Show("Sửa thông tin loại bàn thắng thành công !");
                    LoadGrid();
                    return;
                }

                AlertMsg.Show("Sửa thông tin loại bàn thắng không thành công !");
            }
            catch (Exception ex)
            {
                AlertMsg.Show("Sửa thông tin loại bàn thắng không thành công !");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                LoaiBanThangDTO obj = _banThangBUS.GetLoaiBTBy(txtMaLoaiBT.Text);

                if (obj == null)
                {
                    AlertMsg.Show("Không tìm thấy loại bàn thắng cần xoá !");
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn muốn xoá loại bàn thắng được chọn ?",
                 "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                if (_banThangBUS.DeleteLoaiBT(obj.MaLoaiBT))
                {
                    InfoMsg.Show("Xoá thông tin loại bàn thắng thành công !");
                    LoadGrid();
                    return;
                }

                AlertMsg.Show("Xoá thông tin loại bàn thắng không thành công !");
            }
            catch (Exception ex)
            {
                AlertMsg.Show("Xoá thông tin loại bàn thắng không thành công !");
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

            List<LoaiBanThangDTO> ds = _banThangBUS.GetLoaiBT();
            ds = ds.Where(x => x.TenLoai.ToLower().Contains(searchTerm)).ToList();
            _src.DataSource = ds;
            _src.ResetBindings(true);
        }
    }
}
