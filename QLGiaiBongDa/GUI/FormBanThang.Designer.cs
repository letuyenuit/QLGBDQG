namespace QLGiaiBongDa.GUI
{
    partial class FormBanThang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanThang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gridData = new System.Windows.Forms.DataGridView();
            this.txtThoiDiem = new System.Windows.Forms.NumericUpDown();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.cboMaTD = new System.Windows.Forms.ComboBox();
            this.lbThoiDiem = new System.Windows.Forms.Label();
            this.txtMaBT = new System.Windows.Forms.TextBox();
            this.lbMaTD = new System.Windows.Forms.Label();
            this.lbMaBT = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenBanThang = new System.Windows.Forms.TextBox();
            this.lbTenBanThang = new System.Windows.Forms.Label();
            this.cboMaLBT = new System.Windows.Forms.ComboBox();
            this.lbMaLBT = new System.Windows.Forms.Label();
            this.cboMaCT = new System.Windows.Forms.ComboBox();
            this.lbMaCT = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiDiem)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_idea_32.png");
            this.imageList1.Images.SetKeyName(1, "icons8_save_32.png");
            this.imageList1.Images.SetKeyName(2, "icons8_save_as_32.png");
            this.imageList1.Images.SetKeyName(3, "icons8_erase_32.png");
            // 
            // gridData
            // 
            this.gridData.AllowUserToAddRows = false;
            this.gridData.AllowUserToDeleteRows = false;
            this.gridData.AllowUserToResizeColumns = false;
            this.gridData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.Location = new System.Drawing.Point(3, 23);
            this.gridData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridData.Name = "gridData";
            this.gridData.ReadOnly = true;
            this.gridData.RowHeadersWidth = 51;
            this.gridData.RowTemplate.Height = 24;
            this.gridData.Size = new System.Drawing.Size(1282, 209);
            this.gridData.TabIndex = 0;
            this.gridData.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridData_CellEnter);
            // 
            // txtThoiDiem
            // 
            this.txtThoiDiem.Location = new System.Drawing.Point(867, 130);
            this.txtThoiDiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThoiDiem.Name = "txtThoiDiem";
            this.txtThoiDiem.Size = new System.Drawing.Size(293, 26);
            this.txtThoiDiem.TabIndex = 4;
            this.txtThoiDiem.ValueChanged += new System.EventHandler(this.txtThoiDiem_ValueChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.ImageKey = "icons8_erase_32.png";
            this.btnXoa.ImageList = this.imageList1;
            this.btnXoa.Location = new System.Drawing.Point(1074, 371);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(187, 49);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.ImageKey = "icons8_save_as_32.png";
            this.btnSua.ImageList = this.imageList1;
            this.btnSua.Location = new System.Drawing.Point(834, 371);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(187, 49);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.ImageKey = "icons8_save_32.png";
            this.btnThem.ImageList = this.imageList1;
            this.btnThem.Location = new System.Drawing.Point(604, 371);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(187, 49);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.ImageKey = "icons8_idea_32.png";
            this.btnLamMoi.ImageList = this.imageList1;
            this.btnLamMoi.Location = new System.Drawing.Point(367, 371);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(198, 49);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // cboMaTD
            // 
            this.cboMaTD.FormattingEnabled = true;
            this.cboMaTD.Location = new System.Drawing.Point(245, 128);
            this.cboMaTD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaTD.Name = "cboMaTD";
            this.cboMaTD.Size = new System.Drawing.Size(293, 28);
            this.cboMaTD.TabIndex = 2;
            this.cboMaTD.SelectedIndexChanged += new System.EventHandler(this.cboMaTD_SelectedIndexChanged);
            // 
            // lbThoiDiem
            // 
            this.lbThoiDiem.AutoSize = true;
            this.lbThoiDiem.Location = new System.Drawing.Point(714, 131);
            this.lbThoiDiem.Name = "lbThoiDiem";
            this.lbThoiDiem.Size = new System.Drawing.Size(80, 20);
            this.lbThoiDiem.TabIndex = 0;
            this.lbThoiDiem.Text = "Thời Điểm";
            // 
            // txtMaBT
            // 
            this.txtMaBT.Location = new System.Drawing.Point(245, 40);
            this.txtMaBT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaBT.Name = "txtMaBT";
            this.txtMaBT.Size = new System.Drawing.Size(293, 26);
            this.txtMaBT.TabIndex = 1;
            // 
            // lbMaTD
            // 
            this.lbMaTD.AutoSize = true;
            this.lbMaTD.Location = new System.Drawing.Point(83, 131);
            this.lbMaTD.Name = "lbMaTD";
            this.lbMaTD.Size = new System.Drawing.Size(101, 20);
            this.lbMaTD.TabIndex = 0;
            this.lbMaTD.Text = "Mã Trận Đấu";
            // 
            // lbMaBT
            // 
            this.lbMaBT.AutoSize = true;
            this.lbMaBT.Location = new System.Drawing.Point(83, 43);
            this.lbMaBT.Name = "lbMaBT";
            this.lbMaBT.Size = new System.Drawing.Size(113, 20);
            this.lbMaBT.TabIndex = 0;
            this.lbMaBT.Text = "Mã Bàn Thắng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridData);
            this.groupBox2.Location = new System.Drawing.Point(14, 481);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1288, 236);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenBanThang);
            this.groupBox1.Controls.Add(this.lbTenBanThang);
            this.groupBox1.Controls.Add(this.cboMaLBT);
            this.groupBox1.Controls.Add(this.lbMaLBT);
            this.groupBox1.Controls.Add(this.txtThoiDiem);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.cboMaCT);
            this.groupBox1.Controls.Add(this.cboMaTD);
            this.groupBox1.Controls.Add(this.lbThoiDiem);
            this.groupBox1.Controls.Add(this.lbMaCT);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.txtMaBT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbMaTD);
            this.groupBox1.Controls.Add(this.lbMaBT);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1288, 465);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtTenBanThang
            // 
            this.txtTenBanThang.Location = new System.Drawing.Point(867, 42);
            this.txtTenBanThang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenBanThang.Name = "txtTenBanThang";
            this.txtTenBanThang.Size = new System.Drawing.Size(293, 26);
            this.txtTenBanThang.TabIndex = 9;
            // 
            // lbTenBanThang
            // 
            this.lbTenBanThang.AutoSize = true;
            this.lbTenBanThang.Location = new System.Drawing.Point(714, 46);
            this.lbTenBanThang.Name = "lbTenBanThang";
            this.lbTenBanThang.Size = new System.Drawing.Size(118, 20);
            this.lbTenBanThang.TabIndex = 8;
            this.lbTenBanThang.Text = "Tên Bàn Thắng";
            // 
            // cboMaLBT
            // 
            this.cboMaLBT.FormattingEnabled = true;
            this.cboMaLBT.Location = new System.Drawing.Point(245, 213);
            this.cboMaLBT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaLBT.Name = "cboMaLBT";
            this.cboMaLBT.Size = new System.Drawing.Size(293, 28);
            this.cboMaLBT.TabIndex = 7;
            this.cboMaLBT.SelectedIndexChanged += new System.EventHandler(this.cboMaDB_SelectedIndexChanged);
            // 
            // lbMaLBT
            // 
            this.lbMaLBT.AutoSize = true;
            this.lbMaLBT.Location = new System.Drawing.Point(83, 216);
            this.lbMaLBT.Name = "lbMaLBT";
            this.lbMaLBT.Size = new System.Drawing.Size(147, 20);
            this.lbMaLBT.TabIndex = 5;
            this.lbMaLBT.Text = "Mã Loại Bàn Thắng";
            // 
            // cboMaCT
            // 
            this.cboMaCT.FormattingEnabled = true;
            this.cboMaCT.Location = new System.Drawing.Point(867, 213);
            this.cboMaCT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaCT.Name = "cboMaCT";
            this.cboMaCT.Size = new System.Drawing.Size(293, 28);
            this.cboMaCT.TabIndex = 2;
            this.cboMaCT.SelectedIndexChanged += new System.EventHandler(this.cboMaCT_SelectedIndexChanged);
            // 
            // lbMaCT
            // 
            this.lbMaCT.AutoSize = true;
            this.lbMaCT.Location = new System.Drawing.Point(714, 216);
            this.lbMaCT.Name = "lbMaCT";
            this.lbMaCT.Size = new System.Drawing.Size(95, 20);
            this.lbMaCT.TabIndex = 0;
            this.lbMaCT.Text = "Mã Cầu Thủ";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(156, 300);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(1104, 26);
            this.txtGhiChu.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ghi Chú";
            // 
            // FormBanThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 722);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormBanThang";
            this.Text = "BÀN THẮNG";
            this.Load += new System.EventHandler(this.FormBanThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiDiem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.NumericUpDown txtThoiDiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.ComboBox cboMaTD;
        private System.Windows.Forms.Label lbThoiDiem;
        private System.Windows.Forms.TextBox txtMaBT;
        private System.Windows.Forms.Label lbMaTD;
        private System.Windows.Forms.Label lbMaBT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMaCT;
        private System.Windows.Forms.Label lbMaCT;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMaLBT;
        private System.Windows.Forms.Label lbMaLBT;
        private System.Windows.Forms.TextBox txtTenBanThang;
        private System.Windows.Forms.Label lbTenBanThang;
    }
}