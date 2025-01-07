namespace QLGiaiBongDa.GUI
{
    partial class FormCauThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCauThu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSoAo = new System.Windows.Forms.NumericUpDown();
            this.btnXoa = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.cboMaDB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaCT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ctQuocTich = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cboLoaiCT = new System.Windows.Forms.ComboBox();
            this.txtLoaiCT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenCT = new System.Windows.Forms.TextBox();
            this.gridData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoAo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.ctQuocTich.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoAo
            // 
            this.txtSoAo.Location = new System.Drawing.Point(752, 148);
            this.txtSoAo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoAo.Name = "txtSoAo";
            this.txtSoAo.Size = new System.Drawing.Size(319, 26);
            this.txtSoAo.TabIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.ImageKey = "icons8_erase_32.png";
            this.btnXoa.ImageList = this.imageList1;
            this.btnXoa.Location = new System.Drawing.Point(1076, 318);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(187, 49);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_idea_32.png");
            this.imageList1.Images.SetKeyName(1, "icons8_save_32.png");
            this.imageList1.Images.SetKeyName(2, "icons8_save_as_32.png");
            this.imageList1.Images.SetKeyName(3, "icons8_erase_32.png");
            this.imageList1.Images.SetKeyName(4, "icons8_search_32.png");
            // 
            // btnSua
            // 
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.ImageKey = "icons8_save_as_32.png";
            this.btnSua.ImageList = this.imageList1;
            this.btnSua.Location = new System.Drawing.Point(835, 318);
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
            this.btnThem.Location = new System.Drawing.Point(605, 318);
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
            this.btnLamMoi.Location = new System.Drawing.Point(368, 318);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(198, 49);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // cboMaDB
            // 
            this.cboMaDB.FormattingEnabled = true;
            this.cboMaDB.Location = new System.Drawing.Point(156, 148);
            this.cboMaDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaDB.Name = "cboMaDB";
            this.cboMaDB.Size = new System.Drawing.Size(293, 28);
            this.cboMaDB.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(684, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số Áo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Đội Bóng";
            // 
            // txtMaCT
            // 
            this.txtMaCT.Location = new System.Drawing.Point(156, 42);
            this.txtMaCT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Size = new System.Drawing.Size(293, 26);
            this.txtMaCT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Cầu Thủ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Cầu Thủ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridData);
            this.groupBox2.Location = new System.Drawing.Point(14, 445);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1290, 338);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // ctQuocTich
            // 
            this.ctQuocTich.Controls.Add(this.txtGhiChu);
            this.ctQuocTich.Controls.Add(this.lbGhiChu);
            this.ctQuocTich.Controls.Add(this.dtNgaySinh);
            this.ctQuocTich.Controls.Add(this.txtSoAo);
            this.ctQuocTich.Controls.Add(this.btnXoa);
            this.ctQuocTich.Controls.Add(this.btnSua);
            this.ctQuocTich.Controls.Add(this.btnThem);
            this.ctQuocTich.Controls.Add(this.btnLamMoi);
            this.ctQuocTich.Controls.Add(this.cboLoaiCT);
            this.ctQuocTich.Controls.Add(this.cboMaDB);
            this.ctQuocTich.Controls.Add(this.label6);
            this.ctQuocTich.Controls.Add(this.txtLoaiCT);
            this.ctQuocTich.Controls.Add(this.label5);
            this.ctQuocTich.Controls.Add(this.label3);
            this.ctQuocTich.Controls.Add(this.txtTenCT);
            this.ctQuocTich.Controls.Add(this.txtMaCT);
            this.ctQuocTich.Controls.Add(this.label2);
            this.ctQuocTich.Controls.Add(this.label1);
            this.ctQuocTich.Location = new System.Drawing.Point(14, 15);
            this.ctQuocTich.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctQuocTich.Name = "ctQuocTich";
            this.ctQuocTich.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctQuocTich.Size = new System.Drawing.Size(1290, 405);
            this.ctQuocTich.TabIndex = 4;
            this.ctQuocTich.TabStop = false;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(156, 206);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(293, 26);
            this.txtGhiChu.TabIndex = 8;
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Location = new System.Drawing.Point(64, 209);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(67, 20);
            this.lbGhiChu.TabIndex = 7;
            this.lbGhiChu.Text = "Ghi Chú";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(752, 42);
            this.dtNgaySinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(319, 26);
            this.dtNgaySinh.TabIndex = 5;
            // 
            // cboLoaiCT
            // 
            this.cboLoaiCT.FormattingEnabled = true;
            this.cboLoaiCT.Items.AddRange(new object[] {
            "Việt Nam",
            "Thái Lan"});
            this.cboLoaiCT.Location = new System.Drawing.Point(752, 93);
            this.cboLoaiCT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboLoaiCT.Name = "cboLoaiCT";
            this.cboLoaiCT.Size = new System.Drawing.Size(319, 28);
            this.cboLoaiCT.TabIndex = 2;
            // 
            // txtLoaiCT
            // 
            this.txtLoaiCT.AutoSize = true;
            this.txtLoaiCT.Location = new System.Drawing.Point(648, 99);
            this.txtLoaiCT.Name = "txtLoaiCT";
            this.txtLoaiCT.Size = new System.Drawing.Size(89, 20);
            this.txtLoaiCT.TabIndex = 0;
            this.txtLoaiCT.Text = "Mã Loại CT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(656, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Sinh";
            // 
            // txtTenCT
            // 
            this.txtTenCT.Location = new System.Drawing.Point(156, 95);
            this.txtTenCT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenCT.Name = "txtTenCT";
            this.txtTenCT.Size = new System.Drawing.Size(293, 26);
            this.txtTenCT.TabIndex = 1;
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
            this.gridData.Size = new System.Drawing.Size(1284, 311);
            this.gridData.TabIndex = 0;
            this.gridData.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridData_CellEnter);
            // 
            // FormCauThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 798);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ctQuocTich);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCauThu";
            this.Text = "CẦU THỦ";
            this.Load += new System.EventHandler(this.FormCauThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSoAo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ctQuocTich.ResumeLayout(false);
            this.ctQuocTich.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtSoAo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.ComboBox cboMaDB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaCT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox ctQuocTich;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenCT;
        private System.Windows.Forms.ComboBox cboLoaiCT;
        private System.Windows.Forms.Label txtLoaiCT;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.DataGridView gridData;
    }
}