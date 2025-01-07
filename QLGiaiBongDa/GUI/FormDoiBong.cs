using QLGiaiBongDa.BUS;
using QLGiaiBongDa.DTO;
using QLGiaiBongDa.Utils;
using QLGiaiBongDa.VIEW;
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
    public partial class FormDoiBong : Form
    {
        public FormDoiBong()
        {
            InitializeComponent();
        }

        DoiBongBUS _doiBongBUS = new DoiBongBUS();
        SanBUS _sanBUS = new SanBUS();
        QuyDinhDoiBongBUS _quyDinhDoiBongBUS = new QuyDinhDoiBongBUS();
        BindingSource _src = new BindingSource();

        private void FormDoiBong_Load(object sender, EventArgs e)
        {
            gridData.DataSource = _src;
            LoadDoiBong();
            LoadGrid();
        }

        private void LoadDoiBong()
        {
            dbMaSanNha.DataSource = _sanBUS.Get();
            dbMaSanNha.DisplayMember = "TenSanNha";
            dbMaSanNha.ValueMember = "MaSanNha";
            if (dbMaSanNha.Items.Count > 0)
                dbMaSanNha.SelectedIndex = 0;
        }

        private void LoadGrid()
        {
            _src.DataSource = _doiBongBUS.Get();
            _src.ResetBindings(true);
            gridData.Columns[3].Visible = false;
        }

        private void gridData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!Helpers.IsValidRow(gridData.CurrentRow))
                return;

            DoiBongView obj = gridData.CurrentRow.DataBoundItem as DoiBongView;

            if (obj == null)
                return;

            Display(obj);
        }

        private void Display(DoiBongView obj)
        {
            txtMaDB.Text = obj.MaDoiBong;
            txtTenDB.Text = obj.TenDoiBong;
            showTimeThanhLap.Value = obj.ThoiGianThanhLap;
            if (!string.IsNullOrEmpty(obj.MaSanNha))
                dbMaSanNha.SelectedValue = obj.MaSanNha;
            else
                dbMaSanNha.SelectedIndex = 0;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Display(new DoiBongView());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaDB.Text))
                {
                    AlertMsg.Show("Mã đội bóng không được để trống !");
                    return;
                }

                DoiBongDTO obj = _doiBongBUS.Get(txtMaDB.Text);

                if (obj != null)
                {
                    AlertMsg.Show("Mã đội bóng đã tồn tại !");
                    return;
                }

                DoiBongView o = new DoiBongView();
                o.MaDoiBong = txtMaDB.Text;
                o.TenDoiBong = txtTenDB.Text;
                o.ThoiGianThanhLap = showTimeThanhLap.Value;
                o.MaSanNha = dbMaSanNha.SelectedValue?.ToString();

                if (_doiBongBUS.Create(o))
                {
                    InfoMsg.Show("Thêm mới đội bóng thành công !");
                    LoadGrid();
                    return;
                }

                AlertMsg.Show("Thêm mới đội bóng không thành công !");
            }
            catch (Exception ex) { 
                AlertMsg.Show("Thêm mới đội bóng không thành công !");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DoiBongDTO obj = _doiBongBUS.Get(txtMaDB.Text);

                if (obj == null)
                {
                    AlertMsg.Show("Không tìm thấy mã đội bóng cần sửa !");
                    return;
                }

                DoiBongDTO o = new DoiBongDTO();
                o.MaDoiBong = txtMaDB.Text;
                o.TenDoiBong = txtTenDB.Text;
                o.ThoiGianThanhLap = showTimeThanhLap.Value;
                o.MaSanNha = dbMaSanNha.SelectedValue?.ToString();

                if (_doiBongBUS.Edit(o))
                {
                    InfoMsg.Show("Sửa thông tin đội bóng thành công !");
                    LoadGrid();
                    return;
                }

                AlertMsg.Show("Sửa thông tin đội bóng không thành công !");
            }
            catch (Exception ex)
            {
                AlertMsg.Show("Sửa thông tin đội bóng không thành công !");

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DoiBongDTO obj = _doiBongBUS.Get(txtMaDB.Text);

                if (obj == null)
                {
                    AlertMsg.Show("Không tìm thấy mã đội bóng cần xoá !");
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn muốn xoá đội bóng được chọn ?",
                   "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                if (_doiBongBUS.Delete(obj.MaDoiBong))
                {
                    InfoMsg.Show("Xoá thông tin đội bóng thành công !");
                    LoadGrid();
                    return;
                }

                AlertMsg.Show("Xoá thông tin đội bóng không thành công (Còn cầu thủ trong đội bóng)!");
            }
            catch (Exception ex)
            {
                AlertMsg.Show("Xoá thông tin đội bóng không thành công (Còn cầu thủ trong đội bóng)!");

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    LoadGrid();
                    return;
                }

                string searchTerm = txtSearch.Text.ToLower();

                List<DoiBongView> ds = _doiBongBUS.Get();
                ds = ds.Where(x => x.TenDoiBong.ToLower().Contains(searchTerm))
                    .ToList();
                _src.DataSource = ds;
                _src.ResetBindings(true);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
