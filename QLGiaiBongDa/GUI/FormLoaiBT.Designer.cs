namespace QLGiaiBongDa.GUI
{
    partial class FormLoaiBT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoaiBT));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbTenLLoaiBT = new System.Windows.Forms.TextBox();
            this.txtMaLoaiBT = new System.Windows.Forms.TextBox();
            this.lbTenLoaiBT = new System.Windows.Forms.Label();
            this.lbMaLoaiBT = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.gridDataViTri = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataViTri)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.ImageKey = "icons8_idea_32.png";
            this.btnLamMoi.ImageList = this.imageList1;
            this.btnLamMoi.Location = new System.Drawing.Point(402, 214);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(198, 49);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
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
            // lbTenLLoaiBT
            // 
            this.lbTenLLoaiBT.Location = new System.Drawing.Point(194, 99);
            this.lbTenLLoaiBT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbTenLLoaiBT.Name = "lbTenLLoaiBT";
            this.lbTenLLoaiBT.Size = new System.Drawing.Size(293, 26);
            this.lbTenLLoaiBT.TabIndex = 1;
            // 
            // txtMaLoaiBT
            // 
            this.txtMaLoaiBT.Location = new System.Drawing.Point(194, 46);
            this.txtMaLoaiBT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaLoaiBT.Name = "txtMaLoaiBT";
            this.txtMaLoaiBT.Size = new System.Drawing.Size(293, 26);
            this.txtMaLoaiBT.TabIndex = 1;
            // 
            // lbTenLoaiBT
            // 
            this.lbTenLoaiBT.AutoSize = true;
            this.lbTenLoaiBT.Location = new System.Drawing.Point(36, 102);
            this.lbTenLoaiBT.Name = "lbTenLoaiBT";
            this.lbTenLoaiBT.Size = new System.Drawing.Size(94, 20);
            this.lbTenLoaiBT.TabIndex = 0;
            this.lbTenLoaiBT.Text = "Tên Loại BT";
            // 
            // lbMaLoaiBT
            // 
            this.lbMaLoaiBT.AutoSize = true;
            this.lbMaLoaiBT.Location = new System.Drawing.Point(36, 46);
            this.lbMaLoaiBT.Name = "lbMaLoaiBT";
            this.lbMaLoaiBT.Size = new System.Drawing.Size(89, 20);
            this.lbMaLoaiBT.TabIndex = 0;
            this.lbMaLoaiBT.Text = "Mã Loại BT";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(542, 36);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(474, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSua
            // 
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.ImageKey = "icons8_save_as_32.png";
            this.btnSua.ImageList = this.imageList1;
            this.btnSua.Location = new System.Drawing.Point(868, 214);
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
            this.btnThem.Location = new System.Drawing.Point(639, 214);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(187, 49);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.ImageKey = "icons8_search_32.png";
            this.btnSearch.ImageList = this.imageList1;
            this.btnSearch.Location = new System.Drawing.Point(1098, 26);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(198, 49);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(14, 325);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(1324, 98);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(381, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nội Dung";
            // 
            // btnXoa
            // 
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.ImageKey = "icons8_erase_32.png";
            this.btnXoa.ImageList = this.imageList1;
            this.btnXoa.Location = new System.Drawing.Point(1109, 214);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(187, 49);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // gridDataViTri
            // 
            this.gridDataViTri.AllowUserToAddRows = false;
            this.gridDataViTri.AllowUserToDeleteRows = false;
            this.gridDataViTri.AllowUserToResizeColumns = false;
            this.gridDataViTri.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridDataViTri.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDataViTri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDataViTri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDataViTri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDataViTri.Location = new System.Drawing.Point(3, 23);
            this.gridDataViTri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridDataViTri.Name = "gridDataViTri";
            this.gridDataViTri.ReadOnly = true;
            this.gridDataViTri.RowHeadersWidth = 51;
            this.gridDataViTri.RowTemplate.Height = 24;
            this.gridDataViTri.Size = new System.Drawing.Size(1320, 282);
            this.gridDataViTri.TabIndex = 0;
            this.gridDataViTri.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridData_CellEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridDataViTri);
            this.groupBox2.Location = new System.Drawing.Point(11, 430);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1326, 309);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.lbTenLLoaiBT);
            this.groupBox1.Controls.Add(this.txtMaLoaiBT);
            this.groupBox1.Controls.Add(this.lbTenLoaiBT);
            this.groupBox1.Controls.Add(this.lbMaLoaiBT);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1324, 302);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // FormLoaiBT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 751);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLoaiBT";
            this.Text = "Loại Bàn Thắng";
            this.Load += new System.EventHandler(this.FormSan_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataViTri)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox lbTenLLoaiBT;
        private System.Windows.Forms.TextBox txtMaLoaiBT;
        private System.Windows.Forms.Label lbTenLoaiBT;
        private System.Windows.Forms.Label lbMaLoaiBT;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView gridDataViTri;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}