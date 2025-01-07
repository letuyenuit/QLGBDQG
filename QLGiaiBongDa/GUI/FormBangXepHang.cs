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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGiaiBongDa.GUI
{
    public partial class FormBangXepHang : Form
    {
        public FormBangXepHang()
        {
            InitializeComponent();
        }

        DoiBongBUS _doiBongBUS = new DoiBongBUS();
        MuaGiaiBUS _muaGiaiBUS = new MuaGiaiBUS();
        BangXepHangBUS _bangXepHangBUS = new BangXepHangBUS();
        BindingSource _src = new BindingSource();

        private void FormBangXepHang_Load(object sender, EventArgs e)
        {
            gridData.DataSource = _src;
            LoadGrid();
            LoadMuaGiai();
        }

        private void LoadGrid()
        {
                _src.DataSource = _bangXepHangBUS.Get();
                _src.ResetBindings(true);
        }

        private void LoadMuaGiai()
        {
            cboMaMuaGiai.DataSource = _muaGiaiBUS.Get();
            cboMaMuaGiai.DisplayMember = "TenMuaGiai";
            cboMaMuaGiai.ValueMember = "MaMuaGiai";
            if (cboMaMuaGiai.Items.Count > 0)
                cboMaMuaGiai.SelectedIndex = 0;
        }

        private void gridData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!Helpers.IsValidRow(gridData.CurrentRow))
                return;

            var obj = gridData.CurrentRow.DataBoundItem as BangXepHangDTO;

            if (obj == null)
                return;
        }
        private void gridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboMaMuaGiai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maMuaGiai = cboMaMuaGiai.SelectedValue.ToString();
            if (string.IsNullOrEmpty(maMuaGiai))
            {
                LoadGrid();
                return;
            }

            List<BangXepHangDTO> ds = _bangXepHangBUS.GetBy(maMuaGiai);
            _src.DataSource = ds;
            _src.ResetBindings(true);
        }
    }
}
