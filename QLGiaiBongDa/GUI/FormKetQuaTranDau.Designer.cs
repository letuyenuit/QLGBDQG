namespace QLGiaiBongDa.GUI
{
    partial class FormKetQuaTranDau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKetQuaTranDau));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gridDataViTri = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMuaGiai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLuotThiDau = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataViTri)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.imageList1.Images.SetKeyName(4, "icons8_search_32.png");
            // 
            // gridDataViTri
            // 
            this.gridDataViTri.AllowUserToAddRows = false;
            this.gridDataViTri.AllowUserToDeleteRows = false;
            this.gridDataViTri.AllowUserToResizeColumns = false;
            this.gridDataViTri.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridDataViTri.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridDataViTri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDataViTri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDataViTri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDataViTri.Location = new System.Drawing.Point(3, 23);
            this.gridDataViTri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridDataViTri.Name = "gridDataViTri";
            this.gridDataViTri.ReadOnly = true;
            this.gridDataViTri.RowHeadersWidth = 51;
            this.gridDataViTri.RowTemplate.Height = 24;
            this.gridDataViTri.Size = new System.Drawing.Size(1320, 562);
            this.gridDataViTri.TabIndex = 0;
            this.gridDataViTri.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridData_CellEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridDataViTri);
            this.groupBox2.Location = new System.Drawing.Point(11, 150);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1326, 589);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mùa Giải";
            // 
            // cboMuaGiai
            // 
            this.cboMuaGiai.FormattingEnabled = true;
            this.cboMuaGiai.Location = new System.Drawing.Point(206, 41);
            this.cboMuaGiai.Name = "cboMuaGiai";
            this.cboMuaGiai.Size = new System.Drawing.Size(203, 28);
            this.cboMuaGiai.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Lượt Thi Đấu";
            // 
            // cboLuotThiDau
            // 
            this.cboLuotThiDau.FormattingEnabled = true;
            this.cboLuotThiDau.Location = new System.Drawing.Point(206, 95);
            this.cboLuotThiDau.Name = "cboLuotThiDau";
            this.cboLuotThiDau.Size = new System.Drawing.Size(203, 28);
            this.cboLuotThiDau.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.ImageKey = "icons8_search_32.png";
            this.btnSearch.ImageList = this.imageList1;
            this.btnSearch.Location = new System.Drawing.Point(1136, 84);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(198, 49);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormKetQuaTranDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 751);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboLuotThiDau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMuaGiai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormKetQuaTranDau";
            this.Text = "Kết Quả Thi Đấu";
            this.Load += new System.EventHandler(this.FormSan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDataViTri)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView gridDataViTri;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMuaGiai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLuotThiDau;
        private System.Windows.Forms.Button btnSearch;
    }
}