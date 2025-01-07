using QLGiaiBongDa.BUS;
using QLGiaiBongDa.DTO;
using QLGiaiBongDa.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGiaiBongDa.GUI
{
    public partial class FormQuyDinhDoiBong : Form
    {
        public FormQuyDinhDoiBong()
        {
            InitializeComponent();
        }

        QuyDinhDoiBongBUS _quyDinhBUS = new QuyDinhDoiBongBUS();
        BindingSource _src = new BindingSource();
        private void FormTrongTai_Load(object sender, EventArgs e)
        {
            gridData.DataSource = _src;
            LoadGrid();
        }

        private void LoadGrid()
        {
            _src.DataSource = _quyDinhBUS.Get();
            _src.ResetBindings(true);
        }

        private void gridData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!Helpers.IsValidRow(gridData.CurrentRow))
                return;

            QuyDinhDoiBongDTO obj = gridData.CurrentRow.DataBoundItem as QuyDinhDoiBongDTO;

            if (obj == null)
                return;

            Display(obj);
        }

        private void Display(QuyDinhDoiBongDTO obj)
        {
            txtMaQuyDinh.Text = obj.MaQuyDinh;
            txtSoCauThuToiThieu.Value = obj.SoLuongCauThuToiThieu;
            txtSoCauThuToiDa.Value = obj.SoLuongCauThuToiDa;
            txtSoCauThuNuocNgoai.Value = obj.SoLuongCauThuToiDaNuocNgoai;
            txtSoTuoiToiThieu.Value = obj.SoTuoiToiThieu;
            txtSoTuoiToiDa.Value = obj.SoLuongCauThuToiDa;
            qdThoiDiemGhiBan.Value = obj.ThoiDiemGhiBanToiDa;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Display(new QuyDinhDoiBongDTO());
        }

      
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                QuyDinhDoiBongDTO obj = _quyDinhBUS.Get(txtMaQuyDinh.Text);

                if (obj == null)
                {
                    AlertMsg.Show("Không tìm quy định cần sửa !");
                    return;
                }

                QuyDinhDoiBongDTO o = new QuyDinhDoiBongDTO();
                o.MaQuyDinh = txtMaQuyDinh.Text;
                o.SoLuongCauThuToiThieu = (int)txtSoCauThuToiThieu.Value;
                o.SoLuongCauThuToiDa = (int)txtSoCauThuToiDa.Value;
                o.SoLuongCauThuToiDaNuocNgoai = (int)txtSoCauThuNuocNgoai.Value;
                o.SoTuoiToiThieu = (int)txtSoCauThuToiThieu.Value;
                o.SoTuoiToiDa = (int)txtSoTuoiToiDa.Value;
                o.ThoiDiemGhiBanToiDa = (int)qdThoiDiemGhiBan.Value;
                if (_quyDinhBUS.Edit(o))
                {
                    InfoMsg.Show("Sửa thông tin thành công !");
                    LoadGrid();
                    return;
                }

                AlertMsg.Show("Sửa thông tin không thành công !");
            }
            catch (Exception ex)
            {
                AlertMsg.Show("Sửa thông tin không thành công !");
            }
        }
    }
}
