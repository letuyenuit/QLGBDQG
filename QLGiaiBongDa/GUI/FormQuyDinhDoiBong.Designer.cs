namespace QLGiaiBongDa.GUI
{
    partial class FormQuyDinhDoiBong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuyDinhDoiBong));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtMaQuyDinh = new System.Windows.Forms.TextBox();
            this.maQuyDinh = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.qdThoiDiemGhiBan = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoTuoiToiDa = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoTuoiToiThieu = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoCauThuNuocNgoai = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoCauThuToiDa = new System.Windows.Forms.NumericUpDown();
            this.txtSoCauThuToiThieu = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qdThoiDiemGhiBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTuoiToiDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTuoiToiThieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoCauThuNuocNgoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoCauThuToiDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoCauThuToiThieu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.ImageKey = "icons8_idea_32.png";
            this.btnLamMoi.ImageList = this.imageList1;
            this.btnLamMoi.Location = new System.Drawing.Point(912, 189);
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
            // txtMaQuyDinh
            // 
            this.txtMaQuyDinh.Location = new System.Drawing.Point(194, 26);
            this.txtMaQuyDinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaQuyDinh.Name = "txtMaQuyDinh";
            this.txtMaQuyDinh.Size = new System.Drawing.Size(300, 26);
            this.txtMaQuyDinh.TabIndex = 1;
            // 
            // maQuyDinh
            // 
            this.maQuyDinh.AutoSize = true;
            this.maQuyDinh.Location = new System.Drawing.Point(36, 26);
            this.maQuyDinh.Name = "maQuyDinh";
            this.maQuyDinh.Size = new System.Drawing.Size(100, 20);
            this.maQuyDinh.TabIndex = 0;
            this.maQuyDinh.Text = "Mã Quy Định";
            // 
            // btnSua
            // 
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.ImageKey = "icons8_save_as_32.png";
            this.btnSua.ImageList = this.imageList1;
            this.btnSua.Location = new System.Drawing.Point(1131, 189);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(187, 49);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.gridData.Size = new System.Drawing.Size(1341, 346);
            this.gridData.TabIndex = 0;
            this.gridData.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridData_CellEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridData);
            this.groupBox2.Location = new System.Drawing.Point(11, 318);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1347, 373);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.qdThoiDiemGhiBan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSoTuoiToiDa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSoTuoiToiThieu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoCauThuNuocNgoai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSoCauThuToiDa);
            this.groupBox1.Controls.Add(this.txtSoCauThuToiThieu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.txtMaQuyDinh);
            this.groupBox1.Controls.Add(this.maQuyDinh);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1344, 279);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // qdThoiDiemGhiBan
            // 
            this.qdThoiDiemGhiBan.Location = new System.Drawing.Point(251, 189);
            this.qdThoiDiemGhiBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.qdThoiDiemGhiBan.Name = "qdThoiDiemGhiBan";
            this.qdThoiDiemGhiBan.Size = new System.Drawing.Size(168, 26);
            this.qdThoiDiemGhiBan.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Thời điểm ghi bàn tối đa";
            // 
            // txtSoTuoiToiDa
            // 
            this.txtSoTuoiToiDa.Location = new System.Drawing.Point(194, 127);
            this.txtSoTuoiToiDa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoTuoiToiDa.Name = "txtSoTuoiToiDa";
            this.txtSoTuoiToiDa.Size = new System.Drawing.Size(168, 26);
            this.txtSoTuoiToiDa.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Số tuổi tối đa";
            // 
            // txtSoTuoiToiThieu
            // 
            this.txtSoTuoiToiThieu.Location = new System.Drawing.Point(957, 127);
            this.txtSoTuoiToiThieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoTuoiToiThieu.Name = "txtSoTuoiToiThieu";
            this.txtSoTuoiToiThieu.Size = new System.Drawing.Size(168, 26);
            this.txtSoTuoiToiThieu.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(683, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Số tuổi tối thiểu";
            // 
            // txtSoCauThuNuocNgoai
            // 
            this.txtSoCauThuNuocNgoai.Location = new System.Drawing.Point(957, 75);
            this.txtSoCauThuNuocNgoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoCauThuNuocNgoai.Name = "txtSoCauThuNuocNgoai";
            this.txtSoCauThuNuocNgoai.Size = new System.Drawing.Size(168, 26);
            this.txtSoCauThuNuocNgoai.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cầu thủ tối đa ngước ngoài";
            // 
            // txtSoCauThuToiDa
            // 
            this.txtSoCauThuToiDa.Location = new System.Drawing.Point(957, 24);
            this.txtSoCauThuToiDa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoCauThuToiDa.Name = "txtSoCauThuToiDa";
            this.txtSoCauThuToiDa.Size = new System.Drawing.Size(168, 26);
            this.txtSoCauThuToiDa.TabIndex = 9;
            // 
            // txtSoCauThuToiThieu
            // 
            this.txtSoCauThuToiThieu.Location = new System.Drawing.Point(194, 75);
            this.txtSoCauThuToiThieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoCauThuToiThieu.Name = "txtSoCauThuToiThieu";
            this.txtSoCauThuToiThieu.Size = new System.Drawing.Size(168, 26);
            this.txtSoCauThuToiThieu.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(774, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cầu thủ tối đa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cầu thủ tối thiểu";
            // 
            // FormQuyDinhDoiBong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 699);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormQuyDinhDoiBong";
            this.Text = "Quy Định";
            this.Load += new System.EventHandler(this.FormTrongTai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qdThoiDiemGhiBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTuoiToiDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTuoiToiThieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoCauThuNuocNgoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoCauThuToiDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoCauThuToiThieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtMaQuyDinh;
        private System.Windows.Forms.Label maQuyDinh;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtSoCauThuNuocNgoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtSoCauThuToiDa;
        private System.Windows.Forms.NumericUpDown txtSoCauThuToiThieu;
        private System.Windows.Forms.NumericUpDown txtSoTuoiToiDa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtSoTuoiToiThieu;
        private System.Windows.Forms.NumericUpDown qdThoiDiemGhiBan;
        private System.Windows.Forms.Label label6;
    }
}