namespace GUILayer.ChildForm
{
    partial class FormTiepNhanXe
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
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSoDienThoai = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDiaChi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblEmail = new MaterialSkin.Controls.MaterialLabel();
            this.lblSoDienThoai = new MaterialSkin.Controls.MaterialLabel();
            this.lblDiaChi = new MaterialSkin.Controls.MaterialLabel();
            this.txtTenKhachHang = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTenKhachHang = new MaterialSkin.Controls.MaterialLabel();
            this.lblBienSo = new MaterialSkin.Controls.MaterialLabel();
            this.txtBienSo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblHieuXe = new MaterialSkin.Controls.MaterialLabel();
            this.cbbHieuXe = new System.Windows.Forms.ComboBox();
            this.btnThem = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSua = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnClear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvTiepNhanXe = new System.Windows.Forms.DataGridView();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiepNhanXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(219, 170);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(420, 28);
            this.txtEmail.TabIndex = 19;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Depth = 0;
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Hint = "";
            this.txtSoDienThoai.Location = new System.Drawing.Point(219, 118);
            this.txtSoDienThoai.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.PasswordChar = '\0';
            this.txtSoDienThoai.SelectedText = "";
            this.txtSoDienThoai.SelectionLength = 0;
            this.txtSoDienThoai.SelectionStart = 0;
            this.txtSoDienThoai.Size = new System.Drawing.Size(420, 28);
            this.txtSoDienThoai.TabIndex = 18;
            this.txtSoDienThoai.UseSystemPasswordChar = false;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Depth = 0;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Hint = "";
            this.txtDiaChi.Location = new System.Drawing.Point(230, 71);
            this.txtDiaChi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.SelectionLength = 0;
            this.txtDiaChi.SelectionStart = 0;
            this.txtDiaChi.Size = new System.Drawing.Size(409, 28);
            this.txtDiaChi.TabIndex = 17;
            this.txtDiaChi.UseSystemPasswordChar = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Depth = 0;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmail.Location = new System.Drawing.Point(16, 170);
            this.lblEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(68, 24);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email: ";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Depth = 0;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSoDienThoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSoDienThoai.Location = new System.Drawing.Point(16, 122);
            this.lblSoDienThoai.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(132, 24);
            this.lblSoDienThoai.TabIndex = 15;
            this.lblSoDienThoai.Text = "Số Điện Thoại:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Depth = 0;
            this.lblDiaChi.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDiaChi.Location = new System.Drawing.Point(16, 75);
            this.lblDiaChi.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(75, 24);
            this.lblDiaChi.TabIndex = 16;
            this.lblDiaChi.Text = "Địa Chỉ:";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Depth = 0;
            this.txtTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.Hint = "";
            this.txtTenKhachHang.Location = new System.Drawing.Point(230, 23);
            this.txtTenKhachHang.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.PasswordChar = '\0';
            this.txtTenKhachHang.SelectedText = "";
            this.txtTenKhachHang.SelectionLength = 0;
            this.txtTenKhachHang.SelectionStart = 0;
            this.txtTenKhachHang.Size = new System.Drawing.Size(409, 28);
            this.txtTenKhachHang.TabIndex = 13;
            this.txtTenKhachHang.UseSystemPasswordChar = false;
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Depth = 0;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTenKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTenKhachHang.Location = new System.Drawing.Point(16, 27);
            this.lblTenKhachHang.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(153, 24);
            this.lblTenKhachHang.TabIndex = 16;
            this.lblTenKhachHang.Text = "Tên Khách Hàng:";
            // 
            // lblBienSo
            // 
            this.lblBienSo.AutoSize = true;
            this.lblBienSo.Depth = 0;
            this.lblBienSo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblBienSo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBienSo.Location = new System.Drawing.Point(721, 27);
            this.lblBienSo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBienSo.Name = "lblBienSo";
            this.lblBienSo.Size = new System.Drawing.Size(79, 24);
            this.lblBienSo.TabIndex = 16;
            this.lblBienSo.Text = "Biển Số:";
            // 
            // txtBienSo
            // 
            this.txtBienSo.Depth = 0;
            this.txtBienSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBienSo.Hint = "";
            this.txtBienSo.Location = new System.Drawing.Point(854, 23);
            this.txtBienSo.Margin = new System.Windows.Forms.Padding(4);
            this.txtBienSo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.PasswordChar = '\0';
            this.txtBienSo.SelectedText = "";
            this.txtBienSo.SelectionLength = 0;
            this.txtBienSo.SelectionStart = 0;
            this.txtBienSo.Size = new System.Drawing.Size(267, 28);
            this.txtBienSo.TabIndex = 13;
            this.txtBienSo.UseSystemPasswordChar = false;
            // 
            // lblHieuXe
            // 
            this.lblHieuXe.AutoSize = true;
            this.lblHieuXe.Depth = 0;
            this.lblHieuXe.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblHieuXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHieuXe.Location = new System.Drawing.Point(721, 88);
            this.lblHieuXe.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHieuXe.Name = "lblHieuXe";
            this.lblHieuXe.Size = new System.Drawing.Size(81, 24);
            this.lblHieuXe.TabIndex = 16;
            this.lblHieuXe.Text = "Hiệu Xe:";
            // 
            // cbbHieuXe
            // 
            this.cbbHieuXe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbHieuXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHieuXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbHieuXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbHieuXe.FormattingEnabled = true;
            this.cbbHieuXe.Location = new System.Drawing.Point(857, 84);
            this.cbbHieuXe.Margin = new System.Windows.Forms.Padding(4);
            this.cbbHieuXe.Name = "cbbHieuXe";
            this.cbbHieuXe.Size = new System.Drawing.Size(264, 28);
            this.cbbHieuXe.TabIndex = 20;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem.Depth = 0;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(533, 205);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.Primary = true;
            this.btnThem.Size = new System.Drawing.Size(95, 44);
            this.btnThem.TabIndex = 70;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua.Depth = 0;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(696, 205);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSua.Name = "btnSua";
            this.btnSua.Primary = true;
            this.btnSua.Size = new System.Drawing.Size(95, 44);
            this.btnSua.TabIndex = 71;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Depth = 0;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(854, 205);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Primary = true;
            this.btnXoa.Size = new System.Drawing.Size(95, 44);
            this.btnXoa.TabIndex = 72;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Depth = 0;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1007, 205);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = true;
            this.btnClear.Size = new System.Drawing.Size(95, 44);
            this.btnClear.TabIndex = 73;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvTiepNhanXe
            // 
            this.dgvTiepNhanXe.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTiepNhanXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiepNhanXe.Location = new System.Drawing.Point(20, 276);
            this.dgvTiepNhanXe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTiepNhanXe.Name = "dgvTiepNhanXe";
            this.dgvTiepNhanXe.RowHeadersWidth = 51;
            this.dgvTiepNhanXe.Size = new System.Drawing.Size(1356, 408);
            this.dgvTiepNhanXe.TabIndex = 74;
            this.dgvTiepNhanXe.SelectionChanged += new System.EventHandler(this.dgvTiepNhanXe_SelectionChanged);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 31;
            this.iconPictureBox1.Location = new System.Drawing.Point(1149, 243);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(33, 31);
            this.iconPictureBox1.TabIndex = 75;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Hint = "";
            this.txtSearch.Location = new System.Drawing.Point(1190, 243);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(185, 28);
            this.txtSearch.TabIndex = 76;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // FormTiepNhanXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1388, 697);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.dgvTiepNhanXe);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbbHieuXe);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSoDienThoai);
            this.Controls.Add(this.lblHieuXe);
            this.Controls.Add(this.lblBienSo);
            this.Controls.Add(this.lblTenKhachHang);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtBienSo);
            this.Controls.Add(this.txtTenKhachHang);
            this.Name = "FormTiepNhanXe";
            this.Text = "Tiếp nhận xe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiepNhanXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSoDienThoai;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDiaChi;
        private MaterialSkin.Controls.MaterialLabel lblEmail;
        private MaterialSkin.Controls.MaterialLabel lblSoDienThoai;
        private MaterialSkin.Controls.MaterialLabel lblDiaChi;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenKhachHang;
        private MaterialSkin.Controls.MaterialLabel lblTenKhachHang;
        private MaterialSkin.Controls.MaterialLabel lblBienSo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBienSo;
        private MaterialSkin.Controls.MaterialLabel lblHieuXe;
        private System.Windows.Forms.ComboBox cbbHieuXe;
        private MaterialSkin.Controls.MaterialRaisedButton btnThem;
        private MaterialSkin.Controls.MaterialRaisedButton btnSua;
        private MaterialSkin.Controls.MaterialRaisedButton btnXoa;
        private MaterialSkin.Controls.MaterialRaisedButton btnClear;
        private System.Windows.Forms.DataGridView dgvTiepNhanXe;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
    }
}