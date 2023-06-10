namespace GUILayer.ChildForm
{
    partial class FormPhuTung
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
            this.dgvPhuTung = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnThemSL = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtDonGia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDonVi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTenPT = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnThayDoi = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNhapMoi = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuTung)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhuTung
            // 
            this.dgvPhuTung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuTung.Location = new System.Drawing.Point(12, 118);
            this.dgvPhuTung.Name = "dgvPhuTung";
            this.dgvPhuTung.RowHeadersWidth = 51;
            this.dgvPhuTung.RowTemplate.Height = 24;
            this.dgvPhuTung.Size = new System.Drawing.Size(810, 567);
            this.dgvPhuTung.TabIndex = 0;
            this.dgvPhuTung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhuTung_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.btnThemSL);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.txtDonVi);
            this.groupBox2.Controls.Add(this.txtTenPT);
            this.groupBox2.Controls.Add(this.materialLabel12);
            this.groupBox2.Controls.Add(this.materialLabel10);
            this.groupBox2.Controls.Add(this.materialLabel7);
            this.groupBox2.Controls.Add(this.materialLabel4);
            this.groupBox2.Location = new System.Drawing.Point(828, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 365);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Location = new System.Drawing.Point(210, 126);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 22);
            this.txtSoLuong.TabIndex = 97;
            // 
            // btnThemSL
            // 
            this.btnThemSL.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemSL.Depth = 0;
            this.btnThemSL.Enabled = false;
            this.btnThemSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSL.Location = new System.Drawing.Point(336, 124);
            this.btnThemSL.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemSL.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemSL.Name = "btnThemSL";
            this.btnThemSL.Primary = true;
            this.btnThemSL.Size = new System.Drawing.Size(36, 28);
            this.btnThemSL.TabIndex = 96;
            this.btnThemSL.Text = "+";
            this.btnThemSL.UseVisualStyleBackColor = false;
            this.btnThemSL.Click += new System.EventHandler(this.btnThemSL_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Depth = 0;
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Hint = "";
            this.txtDonGia.Location = new System.Drawing.Point(209, 283);
            this.txtDonGia.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.PasswordChar = '\0';
            this.txtDonGia.SelectedText = "";
            this.txtDonGia.SelectionLength = 0;
            this.txtDonGia.SelectionStart = 0;
            this.txtDonGia.Size = new System.Drawing.Size(315, 28);
            this.txtDonGia.TabIndex = 1;
            this.txtDonGia.UseSystemPasswordChar = false;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Depth = 0;
            this.txtDonVi.Enabled = false;
            this.txtDonVi.Hint = "";
            this.txtDonVi.Location = new System.Drawing.Point(209, 204);
            this.txtDonVi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.PasswordChar = '\0';
            this.txtDonVi.SelectedText = "";
            this.txtDonVi.SelectionLength = 0;
            this.txtDonVi.SelectionStart = 0;
            this.txtDonVi.Size = new System.Drawing.Size(101, 28);
            this.txtDonVi.TabIndex = 1;
            this.txtDonVi.UseSystemPasswordChar = false;
            // 
            // txtTenPT
            // 
            this.txtTenPT.Depth = 0;
            this.txtTenPT.Enabled = false;
            this.txtTenPT.Hint = "";
            this.txtTenPT.Location = new System.Drawing.Point(209, 40);
            this.txtTenPT.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenPT.Name = "txtTenPT";
            this.txtTenPT.PasswordChar = '\0';
            this.txtTenPT.SelectedText = "";
            this.txtTenPT.SelectionLength = 0;
            this.txtTenPT.SelectionStart = 0;
            this.txtTenPT.Size = new System.Drawing.Size(310, 28);
            this.txtTenPT.TabIndex = 1;
            this.txtTenPT.UseSystemPasswordChar = false;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(16, 287);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(80, 24);
            this.materialLabel12.TabIndex = 0;
            this.materialLabel12.Text = "Giá Bán:";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(16, 208);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(71, 24);
            this.materialLabel10.TabIndex = 0;
            this.materialLabel10.Text = "Đơn Vị:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(16, 44);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(130, 24);
            this.materialLabel7.TabIndex = 0;
            this.materialLabel7.Text = "Tên Phụ Tùng:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(16, 124);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(96, 24);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Số Lượng:";
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.BackColor = System.Drawing.SystemColors.Control;
            this.btnThayDoi.Depth = 0;
            this.btnThayDoi.Enabled = false;
            this.btnThayDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThayDoi.Location = new System.Drawing.Point(1195, 529);
            this.btnThayDoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnThayDoi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Primary = true;
            this.btnThayDoi.Size = new System.Drawing.Size(157, 59);
            this.btnThayDoi.TabIndex = 94;
            this.btnThayDoi.Text = "Lưu Thay Đổi";
            this.btnThayDoi.UseVisualStyleBackColor = false;
            this.btnThayDoi.Click += new System.EventHandler(this.btnThayDoi_Click);
            // 
            // btnNhapMoi
            // 
            this.btnNhapMoi.BackColor = System.Drawing.SystemColors.Control;
            this.btnNhapMoi.Depth = 0;
            this.btnNhapMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapMoi.Location = new System.Drawing.Point(885, 529);
            this.btnNhapMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhapMoi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNhapMoi.Name = "btnNhapMoi";
            this.btnNhapMoi.Primary = true;
            this.btnNhapMoi.Size = new System.Drawing.Size(157, 59);
            this.btnNhapMoi.TabIndex = 95;
            this.btnNhapMoi.Text = "Nhập PT Mới";
            this.btnNhapMoi.UseVisualStyleBackColor = false;
            this.btnNhapMoi.Click += new System.EventHandler(this.btnNhapMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Depth = 0;
            this.btnXoa.Enabled = false;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(885, 626);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Primary = true;
            this.btnXoa.Size = new System.Drawing.Size(157, 59);
            this.btnXoa.TabIndex = 95;
            this.btnXoa.Text = "xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 29);
            this.label1.TabIndex = 96;
            this.label1.Text = "Danh Sách Các Phụ Tùng";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem.Depth = 0;
            this.btnThem.Enabled = false;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(1195, 626);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.Primary = true;
            this.btnThem.Size = new System.Drawing.Size(157, 59);
            this.btnThem.TabIndex = 97;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FormPhuTung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 697);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnNhapMoi);
            this.Controls.Add(this.btnThayDoi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvPhuTung);
            this.Name = "FormPhuTung";
            this.Text = "Quản lý Phụ Tùng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuTung)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhuTung;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDonGia;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDonVi;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenPT;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialRaisedButton btnThayDoi;
        private MaterialSkin.Controls.MaterialRaisedButton btnNhapMoi;
        private MaterialSkin.Controls.MaterialRaisedButton btnXoa;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton btnThem;
        private MaterialSkin.Controls.MaterialRaisedButton btnThemSL;
        private System.Windows.Forms.TextBox txtSoLuong;
    }
}