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
    public partial class FormTranDau : Form
    {
        public FormTranDau()
        {
            InitializeComponent();
        }

        TranDauBUS _tranDauBUS = new TranDauBUS();
        DoiBongBUS _doiBongBUS = new DoiBongBUS();
        SanBUS _sanBUS = new SanBUS();
        MuaGiaiBUS _muaGiai = new MuaGiaiBUS();
        BindingSource _src = new BindingSource();
        private void FormTranDau_Load(object sender, EventArgs e)
        {
            gridData.DataSource = _src;
            LoadDoiBong1();
            LoadDoiBong2();
            LoadMuaGiai();
            //LoadSan();
            //LoadLoaiTranDau();
            //LoadTrangThai();
            LoadGrid();
        }

        private void LoadDoiBong1()
        {
            cboMaDoi1.DataSource = _doiBongBUS.Get();
            cboMaDoi1.DisplayMember = "TenDoiBong";
            cboMaDoi1.ValueMember = "MaDoiBong";
            if (cboMaDoi1.Items.Count > 0)
                cboMaDoi1.SelectedIndex = 0;
        }
        private void LoadDoiBong2()
        {
            cboMaDoi2.DataSource = _doiBongBUS.Get();
            cboMaDoi2.DisplayMember = "TenDoiBong";
            cboMaDoi2.ValueMember = "MaDoiBong";
            if (cboMaDoi2.Items.Count > 0)
                cboMaDoi2.SelectedIndex = 0;
        }

        private void LoadMuaGiai()
        {
            cboMuaGiai.DataSource = _muaGiai.Get();
            cboMuaGiai.DisplayMember = "TenMuaGiai";
            cboMuaGiai.ValueMember = "MaMuaGiai";
            if (cboMuaGiai.Items.Count > 0)
                cboMuaGiai.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                TranDauDTO o = new TranDauDTO();
                o.MaThiDau = txtMaTD.Text;
                o.TenThiDau = txtTenThiDau.Text;
                o.MaDoiBong1 = cboMaDoi1.SelectedValue.ToString();
                o.MaDoiBong2 = cboMaDoi2.SelectedValue.ToString();
                o.ThoiGianThiDau = tdThoiGianThiDau.Value;
                if (tdLuotThiDau.Checked)
                {
                    o.LuotThiDau = 1;
                }
                else o.LuotThiDau = 0;
                o.MaMuaGiai = cboMuaGiai.SelectedValue.ToString();
                o.ThoiLuongThiDau = (int)txtThoiLuong.Value;
                if (_tranDauBUS.Create(o))
                {
                    InfoMsg.Show("Thêm mới lich thi dau thành công !");
                    LoadGrid();
                    return;
                }

                AlertMsg.Show("Thêm mới lich thi dau không thành công !");
            }
            catch (Exception ex) { 
                AlertMsg.Show("Thêm mới lich thi dau không thành công !");
            }
        }

        private void LoadGrid()
        {
            _src.DataSource = _tranDauBUS.Get();
            _src.ResetBindings(true);
            gridData.Columns["MaDoiBong1"].Visible = false;
            gridData.Columns["MaDoiBong2"].Visible = false;
            gridData.Columns["MaSanNha"].Visible = false;
            gridData.Columns["MaMuaGiai"].Visible = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                TranDauDTO obj = _tranDauBUS.Get(txtMaTD.Text);

                if (obj == null)
                {
                    AlertMsg.Show("Không tìm thấy trận đấu cần sửa !");
                    return;
                }

                TranDauDTO o = new TranDauDTO();
                o.MaThiDau = txtMaTD.Text;
                o.TenThiDau = txtTenThiDau.Text;
                o.MaDoiBong1 = cboMaDoi1.SelectedValue.ToString();
                o.MaDoiBong2 = cboMaDoi2.SelectedValue.ToString();
                o.ThoiGianThiDau = tdThoiGianThiDau.Value;
                if (tdLuotThiDau.Checked)
                {
                    o.LuotThiDau = 1;
                }
                else o.LuotThiDau = 0;
                o.MaMuaGiai = cboMuaGiai.SelectedValue.ToString();
                o.ThoiLuongThiDau = (int)txtThoiLuong.Value;

                if (_tranDauBUS.Edit(o))
                {
                    InfoMsg.Show("Sửa thông tin trận đấu thành công !");
                    LoadGrid();
                    return;
                }

                AlertMsg.Show("Sửa thông tin trận đấu không thành công !");
            }
            catch (Exception ex) { 
                AlertMsg.Show("Sửa thông tin trận đấu không thành công !");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                TranDauDTO obj = _tranDauBUS.Get(txtMaTD.Text);

                if (obj == null)
                {
                    AlertMsg.Show("Không tìm thấy trận đấu cần xoa !");
                    return;
                }


                DialogResult result = MessageBox.Show("Bạn muốn xoá tran dau được chọn ?",
                 "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                if (_tranDauBUS.Delete(obj.MaThiDau))
                {
                    InfoMsg.Show("Xoá thông tin tran dau thành công !");
                    LoadGrid();
                    return;
                }

                AlertMsg.Show("Xoá thông tin tran dau không thành công !");
            }
            catch (Exception ex)
            {
                AlertMsg.Show("Xoá thông tin tran dau không thành công !");
            }
        }

        private void gridData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!Helpers.IsValidRow(gridData.CurrentRow))
                return;

            var obj = gridData.CurrentRow.DataBoundItem as TranDauDTO;

            if (obj == null)
                return;

            Display(obj);
        }

        private void Display(TranDauDTO obj)
        {
            txtMaTD.Text = obj.MaThiDau;
            txtTenThiDau.Text = obj.TenThiDau;

            if (!string.IsNullOrEmpty(obj.MaDoiBong1))
                cboMaDoi1.SelectedValue = obj.MaDoiBong1;
            else
                cboMaDoi1.SelectedIndex = -1;

            if (!string.IsNullOrEmpty(obj.MaDoiBong2))
                cboMaDoi2.SelectedValue = obj.MaDoiBong2;
            else
                cboMaDoi2.SelectedIndex = -1;

            if (!string.IsNullOrEmpty(obj.MaMuaGiai))
                cboMuaGiai.SelectedValue = obj.MaMuaGiai;
            else
                cboMuaGiai.SelectedIndex = -1;
            txtThoiLuong.Value = obj.ThoiLuongThiDau;
            tdThoiGianThiDau.Value = obj.ThoiGianThiDau;
            if (obj.LuotThiDau == 1)
            {
                tdLuotThiDau.Checked = true;
            }
            else tdLuotThiDau .Checked = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Display(new TranDauDTO());
        }

        private void cboMaDoi1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtTenDoi1.Text = (cboMaDoi1.SelectedItem as DoiBongDTO)?.TenDoiBong ?? string.Empty;
        }

        private void cboMaDoi2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtTenDoi2.Text = (cboMaDoi2.SelectedItem as DoiBongDTO)?.TenDoiBong ?? string.Empty;

        }

        private void cboMaSan_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtTenSan.Text = (cboMaSan.SelectedItem as SanDTO)?.TenSanNha ?? string.Empty;
        }

        private void cboVongDau_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtTenVongDau.Text = cboMuaGiai.SelectedItem as string;
        }

        private void cboLoaiTranDau_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtTenLoaiTranDau.Text = (cboLoaiTranDau.SelectedItem as LoaiTranDauDTO)?.TenLoai ?? string.Empty;
        }
    }
}
