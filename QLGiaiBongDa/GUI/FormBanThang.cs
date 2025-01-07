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
    public partial class FormBanThang : Form
    {
        public FormBanThang()
        {
            InitializeComponent();
        }

        TranDauBUS _tranDauBUS = new TranDauBUS();
        CauThuBUS _cauThuBUS = new CauThuBUS();
        BanThangBUS _banThangBUS = new BanThangBUS();
        BindingSource _src = new BindingSource();

        private void FormBanThang_Load(object sender, EventArgs e)
        {
            gridData.DataSource = _src;
            LoadTranDau();
            LoadLoaiBT();
            LoadGrid();
        }

        private void LoadGrid()
        {
            _src.DataSource = _banThangBUS.Get();
            _src.ResetBindings(true);
            gridData.Columns["MaCT"].Visible = false;
            gridData.Columns["MaThiDau"].Visible = false;
        }

        private void LoadCauThu(string ma)
        {
            cboMaCT.DataSource = _cauThuBUS.GetsBy(ma);
            cboMaCT.ValueMember = "MaCT";
            cboMaCT.DisplayMember = "TenCT";
            if (cboMaCT.Items.Count > 0)
                cboMaCT.SelectedIndex = 0;
        }

        private void LoadTranDau()
        {
            cboMaTD.DataSource = _tranDauBUS.Get();
            cboMaTD.ValueMember = "MaThiDau";
            cboMaTD.DisplayMember = "TenThiDau";
            if (cboMaTD.Items.Count > 0)
                cboMaTD.SelectedIndex = 0;
        }

        private void LoadLoaiBT()
        {

            cboMaLBT.DataSource = _banThangBUS.GetLoaiBT();
            cboMaLBT.ValueMember = "MaLoaiBT";
            cboMaLBT.DisplayMember = "TenLoai";
            if (cboMaLBT.Items.Count > 0)
                cboMaLBT.SelectedIndex = 0;
        }

        private void gridData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!Helpers.IsValidRow(gridData.CurrentRow))
                return;

            BanThangDTO obj = gridData.CurrentRow.DataBoundItem as BanThangDTO;

            if (obj == null) return;

            Display(obj);
        }

        private void Display(BanThangDTO obj)
        {
            txtMaBT.Text = obj.MaBanThang;
            txtTenBanThang.Text = obj.TenBanThang;
            if (!string.IsNullOrEmpty(obj.MaCT))
                cboMaCT.SelectedValue = obj.MaCT;
            else
                cboMaCT.SelectedIndex = 0;

            if (!string.IsNullOrEmpty(obj.MaThiDau))
                cboMaTD.SelectedValue = obj.MaThiDau;
            else
                cboMaTD.SelectedIndex = 0;

            if (!string.IsNullOrEmpty(obj.MaLoaiBT))
                cboMaLBT.SelectedValue = obj.MaLoaiBT;
            else
                cboMaLBT.SelectedIndex = 0;

            txtThoiDiem.Value = obj.ThoiDiemGhiBan;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Display(new BanThangDTO());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaBT.Text))
                {
                    AlertMsg.Show("Mã bàn thắng không được để trống !");
                    return;
                }
                if (string.IsNullOrEmpty(txtTenBanThang.Text))
                {
                    AlertMsg.Show("Tên bàn thắng không được để trống !");
                    return;
                }

                BanThangDTO obj = _banThangBUS.Get(txtMaBT.Text);
                if (obj != null)
                {
                    AlertMsg.Show("Mã Bàn thắng không được trùng nhau");
                }
                BanThangDTO o = new BanThangDTO();
                o.MaBanThang = txtMaBT.Text;
                o.TenBanThang = txtTenBanThang.Text;
                o.MaCT = cboMaCT.SelectedValue.ToString();
                o.MaThiDau = cboMaTD.SelectedValue.ToString();
                o.MaLoaiBT = cboMaLBT.SelectedValue.ToString();
                o.ThoiDiemGhiBan = (int)txtThoiDiem.Value;
                if (_banThangBUS.Create(o))
                {
                    InfoMsg.Show("Thêm mới bàn thắng thành công !");
                    LoadGrid();
                    return;
                }

                AlertMsg.Show("Thêm mới bàn thắng không thành công !");
            }
            catch (Exception ex)
            {
                AlertMsg.Show("Thêm mới bàn thắng không thành công !");

            }
        }

        private void cboMaTD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboMaTD.SelectedValue.ToString()))
            {
                cboMaCT.Text = "";
                LoadCauThu(cboMaTD.SelectedValue.ToString());
            }
        }

        private void cboMaCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            CauThuDTO obj = cboMaCT.SelectedItem as CauThuDTO;

            if (obj != null)
            {
                //txtTenCT.Text = obj.TenCT;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                BanThangDTO obj = _banThangBUS.Get(txtMaBT.Text);

                if (obj == null)
                {
                    AlertMsg.Show("Không tìm thấy mã bàn thắng cần sửa !");
                    return;
                }
                BanThangDTO o = new BanThangDTO();
                o.MaBanThang = txtMaBT.Text;
                o.TenBanThang = txtTenBanThang.Text;
                o.MaCT = cboMaCT.SelectedValue.ToString();
                o.MaThiDau = cboMaTD.SelectedValue.ToString();
                o.MaLoaiBT = cboMaLBT.SelectedValue.ToString();
                o.ThoiDiemGhiBan = (int)txtThoiDiem.Value;
                if (_banThangBUS.Edit(o))
                {
                    InfoMsg.Show("Sửa thông tin bàn thắng thành công !");
                    LoadGrid();
                    return;
                }

                AlertMsg.Show("Sửa thông tin bàn thắng không thành công !");
            }
            catch (Exception ex)
            {
                AlertMsg.Show("Sửa thông tin bàn thắng không thành công !");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                BanThangDTO obj = _banThangBUS.Get(txtMaBT.Text);

                if (obj == null)
                {
                    AlertMsg.Show("Không tìm thấy mã bàn thắng cần xoá !");
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn muốn xoá bàn thắng được chọn ?",
                   "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                if (_banThangBUS.Delete(obj.MaBanThang))
                {
                    InfoMsg.Show("Xoá thông tin bàn thắng thành công !");
                    LoadGrid();
                    return;
                }

                AlertMsg.Show("Xoá thông tin bàn thắng không thành công !");
            }
            catch (Exception ex)
            {
                AlertMsg.Show("Xoá thông tin bàn thắng không thành công !");
            }
        }

        private void cboMaDB_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtThoiDiem_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
