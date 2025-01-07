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
    public partial class FormCauThu : Form
    {
        public FormCauThu()
        {
            InitializeComponent();
        }

        DoiBongBUS _doiBongBUS = new DoiBongBUS();
        CauThuBUS _cauThuBUS = new CauThuBUS();
        BindingSource _src = new BindingSource();

        private void FormCauThu_Load(object sender, EventArgs e)
        {
            gridData.DataSource = _src;
            LoadDoiBong();
            LoadLoaiCT();
            LoadGrid();
        }

        private void LoadGrid()
        {
            _src.DataSource = _cauThuBUS.Get();
            _src.ResetBindings(true);
            gridData.Columns[2].Visible = false;
            gridData.Columns[4].Visible = false;

        }

        private void LoadDoiBong()
        {
            cboMaDB.DataSource = _doiBongBUS.Get();
            cboMaDB.DisplayMember = "TenDoiBong";
            cboMaDB.ValueMember = "MaDoiBong";
            if (cboMaDB.Items.Count > 0)
                cboMaDB.SelectedIndex = 0;
        }

        private void LoadLoaiCT()
        {
            cboLoaiCT.DataSource = _cauThuBUS.GetLoaiCauThu();
            cboLoaiCT.DisplayMember = "TenLoai";
            cboLoaiCT.ValueMember = "MaLoaiCT";
            if (cboLoaiCT.Items.Count > 0)
                cboLoaiCT.SelectedIndex = 0;
        }


        private void gridData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!Helpers.IsValidRow(gridData.CurrentRow)) return;

            CauThuViewDTO obj = gridData.CurrentRow.DataBoundItem as CauThuViewDTO;

            if (obj == null) return;

            Display(obj);
        }

        private void Display(CauThuViewDTO obj)
        {
            txtMaCT.Text = obj.MaCT;
            txtTenCT.Text = obj.TenCT;
            dtNgaySinh.Value = obj.NgaySinh;
            txtSoAo.Value = obj.SoAo;
            if (!string.IsNullOrEmpty(obj.MaDoiBong))
                cboMaDB.SelectedValue = obj.MaDoiBong;
            else
                cboMaDB.SelectedIndex = -1;


            if (!string.IsNullOrEmpty(obj.MaLoaiCT))
                cboLoaiCT.SelectedValue = obj.MaLoaiCT;
            else
                cboLoaiCT.SelectedIndex = -1;

            txtGhiChu.Text = obj.GhiChu;

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Display(new CauThuViewDTO());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaCT.Text))
                {
                    AlertMsg.Show("Mã cầu thủ không được để trống !");
                    return;
                }

                CauThuDTO obj = _cauThuBUS.Get(txtMaCT.Text);

                if (obj != null)
                {
                    AlertMsg.Show("Mã cầu thủ đã tồn tại !");
                    return;
                }

                if (cboMaDB.SelectedIndex < 0)
                {
                    AlertMsg.Show("Hãy chọn mã đội bóng !");
                    return;
                }

                if (DateTime.Now.Year - dtNgaySinh.Value.Year < 18)
                {
                    AlertMsg.Show("Cầu thủ phải lớn hơn 18 tuổi !");
                    return;
                }

                if (cboLoaiCT.SelectedIndex < 0)
                {
                    AlertMsg.Show("Vui lòng chọn quốc tịch !");
                    return;
                }

                CauThuDTO o = new CauThuDTO();
                o.MaCT = txtMaCT.Text;
                o.TenCT = txtTenCT.Text;
                o.MaDoiBong = cboMaDB.SelectedValue.ToString();
                o.NgaySinh = dtNgaySinh.Value;
                o.SoAo = (int)txtSoAo.Value;
                o.MaLoaiCT = cboLoaiCT.SelectedValue.ToString();
                o.GhiChu = txtGhiChu.Text;
                if (_cauThuBUS.Create(o))
                {
                    InfoMsg.Show("Thêm mới thông tin cầu thủ thành công !");
                    LoadGrid();
                    return;
                }
                AlertMsg.Show("Thêm mới thông tin cầu thủ không thành công !");

            }
            catch (Exception ex) { 
            AlertMsg.Show("Thêm mới thông tin cầu thủ không thành công !");

            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                CauThuDTO obj = _cauThuBUS.Get(txtMaCT.Text);

                if (obj == null)
                {
                    AlertMsg.Show("Không tìm thấy mã cầu thủ cần sửa !");
                    return;
                }

                if (cboMaDB.SelectedIndex < 0)
                {
                    AlertMsg.Show("Hãy chọn mã đội bóng !");
                    return;
                }

                if (DateTime.Now.Year - dtNgaySinh.Value.Year < 18)
                {
                    AlertMsg.Show("Cầu thủ phải lớn hơn 18 tuổi !");
                    return;
                }

                if (cboLoaiCT.SelectedIndex < 0)
                {
                    AlertMsg.Show("Vui lòng chọn quốc tịch !");
                    return;
                }

                CauThuDTO o = new CauThuDTO();
                o.MaCT = txtMaCT.Text;
                o.TenCT = txtTenCT.Text;
                o.MaDoiBong = cboMaDB.SelectedValue.ToString();
                o.NgaySinh = dtNgaySinh.Value;
                o.SoAo = (int)txtSoAo.Value;
                o.MaLoaiCT = cboLoaiCT.SelectedValue.ToString();
                o.GhiChu = txtGhiChu.Text;

                if (_cauThuBUS.Edit(o))
                {
                    InfoMsg.Show("Sửa thông tin cầu thủ thành công !");
                    LoadGrid();
                    return;
                }

                AlertMsg.Show("Sửa thông tin cầu thủ không thành công !");
            }
            catch (Exception ex) { 
                AlertMsg.Show("Sửa thông tin cầu thủ không thành công !");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                CauThuDTO obj = _cauThuBUS.Get(txtMaCT.Text);

                if (obj == null)
                {
                    AlertMsg.Show("Không tìm thấy mã cầu thủ cần xoá !");
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn muốn xoá cầu thủ được chọn ?",
                   "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                if (_cauThuBUS.Delete(obj.MaCT))
                {
                    InfoMsg.Show("Xoá thông tin cầu thủ thành công !");
                    LoadGrid();
                    return;
                }

                AlertMsg.Show("Xoá thông tin cầu thủ không thành công !");
            }
            catch (Exception ex)
            {
                AlertMsg.Show("Xoá thông tin cầu thủ không thành công!");
            }
        }
    }
}
