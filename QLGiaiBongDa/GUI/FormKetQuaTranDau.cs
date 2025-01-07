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

    public partial class FormKetQuaTranDau : Form
    {
        public FormKetQuaTranDau()
        {
            InitializeComponent();
        }

        KetQuaTranDauBUS _ketQuaBUS = new KetQuaTranDauBUS();
        MuaGiaiBUS _muaGiaiBUS = new MuaGiaiBUS();
        BindingSource _src = new BindingSource();

        private void FormSan_Load(object sender, EventArgs e)
        {
            gridDataViTri.DataSource = _src;
            LoadMuaGiai();
            LoadLuotThiDau();
            LoadGrid();
        }

        private void LoadGrid()
        {
            _src.DataSource = _ketQuaBUS.Get();
            _src.ResetBindings(true);
            gridDataViTri.Columns["MaMuaGiai"].Visible = false;
        }
        private void LoadMuaGiai()
        {
            cboMuaGiai.DataSource = _muaGiaiBUS.Get();
            cboMuaGiai.ValueMember = "MaMuaGiai";
            cboMuaGiai.DisplayMember = "TenMuaGiai";
            if (cboMuaGiai.Items.Count > 0)
                cboMuaGiai.SelectedIndex = 0;
        }
        private void LoadLuotThiDau()
        {
            Dictionary<int, string> luotThiDau = new Dictionary<int, string>
            {
                { 1, "Luot di" },
                { 0, "Luot ve" }
            };
            cboLuotThiDau.DataSource = luotThiDau.ToList();
            cboLuotThiDau.ValueMember = "key";
            cboLuotThiDau.DisplayMember = "value";
            if (cboLuotThiDau.Items.Count > 0)
                cboLuotThiDau.SelectedIndex = 0;
        }
        private void gridData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!Helpers.IsValidRow(gridDataViTri.CurrentRow))
                return;

            KetQuaTranDauDTO obj = gridDataViTri.CurrentRow.DataBoundItem as KetQuaTranDauDTO;

            if (obj == null)
                return;

            Display(obj);
        }

        private void Display(KetQuaTranDauDTO obj)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string maMuaGiai = cboMuaGiai.SelectedValue.ToString();
                string selectedValue = cboLuotThiDau.SelectedValue?.ToString();
                if (int.TryParse(selectedValue, out int luotThiDau))
                {
                    Console.WriteLine($"Lượt thi đấu: {luotThiDau}");
                    List<KetQuaTranDauDTO> ds = _ketQuaBUS.Get(maMuaGiai, luotThiDau);
                    _src.DataSource = ds;
                    _src.ResetBindings(true);
                }
                else
                {
                    AlertMsg.Show("Giá trị lượt thi đấu không hợp lệ");
                }
            }
            catch (Exception ex) { }
        }
    }
}
