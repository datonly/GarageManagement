namespace GUILayer.ChildForm.SubForm
{
    partial class FormCT_PSC
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSua = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnHoanThanh = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTienUng = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThanhTien = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDonGia = new System.Windows.Forms.Label();
            this.txtDonVi = new System.Windows.Forms.Label();
            this.txtTienCong = new System.Windows.Forms.Label();
            this.btnXoa = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnThem = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtSL = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbbPhuTung = new System.Windows.Forms.ComboBox();
            this.cbbNoiDung = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.btnBaoGia = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnXacNhan = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.printDialogBill = new System.Windows.Forms.PrintDialog();
            this.printDocumentBill = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(30, 98);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(126, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Mã Hóa Đơn: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnHoanThanh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTienUng);
            this.groupBox1.Controls.Add(this.materialLabel11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtThanhTien);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtDonVi);
            this.groupBox1.Controls.Add(this.txtTienCong);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtSL);
            this.groupBox1.Controls.Add(this.cbbPhuTung);
            this.groupBox1.Controls.Add(this.cbbNoiDung);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.materialLabel8);
            this.groupBox1.Controls.Add(this.materialLabel9);
            this.groupBox1.Controls.Add(this.materialLabel6);
            this.groupBox1.Controls.Add(this.materialLabel7);
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Location = new System.Drawing.Point(205, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1171, 250);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua.Depth = 0;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(690, 199);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSua.Name = "btnSua";
            this.btnSua.Primary = true;
            this.btnSua.Size = new System.Drawing.Size(118, 34);
            this.btnSua.TabIndex = 103;
            this.btnSua.Text = "sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.BackColor = System.Drawing.SystemColors.Control;
            this.btnHoanThanh.Depth = 0;
            this.btnHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanThanh.Location = new System.Drawing.Point(980, 199);
            this.btnHoanThanh.Margin = new System.Windows.Forms.Padding(4);
            this.btnHoanThanh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Primary = true;
            this.btnHoanThanh.Size = new System.Drawing.Size(171, 34);
            this.btnHoanThanh.TabIndex = 102;
            this.btnHoanThanh.Text = "hoàn thành";
            this.btnHoanThanh.UseVisualStyleBackColor = false;
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 22);
            this.label2.TabIndex = 101;
            this.label2.Text = "VND";
            // 
            // txtTienUng
            // 
            this.txtTienUng.Depth = 0;
            this.txtTienUng.ForeColor = System.Drawing.Color.IndianRed;
            this.txtTienUng.Hint = "";
            this.txtTienUng.Location = new System.Drawing.Point(181, 205);
            this.txtTienUng.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTienUng.Name = "txtTienUng";
            this.txtTienUng.PasswordChar = '\0';
            this.txtTienUng.SelectedText = "";
            this.txtTienUng.SelectionLength = 0;
            this.txtTienUng.SelectionStart = 0;
            this.txtTienUng.Size = new System.Drawing.Size(313, 28);
            this.txtTienUng.TabIndex = 100;
            this.txtTienUng.UseSystemPasswordChar = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(6, 212);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(90, 24);
            this.materialLabel11.TabIndex = 99;
            this.materialLabel11.Text = "Tiền Ứng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 98;
            this.label1.Text = "VND";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Depth = 0;
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.ForeColor = System.Drawing.Color.IndianRed;
            this.txtThanhTien.Hint = "";
            this.txtThanhTien.Location = new System.Drawing.Point(181, 169);
            this.txtThanhTien.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.PasswordChar = '\0';
            this.txtThanhTien.SelectedText = "";
            this.txtThanhTien.SelectionLength = 0;
            this.txtThanhTien.SelectionStart = 0;
            this.txtThanhTien.Size = new System.Drawing.Size(313, 28);
            this.txtThanhTien.TabIndex = 97;
            this.txtThanhTien.UseSystemPasswordChar = false;
            this.txtThanhTien.TextChanged += new System.EventHandler(this.txtThanhTien_TextChanged);
            // 
            // txtDonGia
            // 
            this.txtDonGia.AutoSize = true;
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(654, 80);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(58, 22);
            this.txtDonGia.TabIndex = 96;
            this.txtDonGia.Text = "label2";
            // 
            // txtDonVi
            // 
            this.txtDonVi.AutoSize = true;
            this.txtDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonVi.Location = new System.Drawing.Point(340, 123);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(22, 22);
            this.txtDonVi.TabIndex = 95;
            this.txtDonVi.Text = "()";
            // 
            // txtTienCong
            // 
            this.txtTienCong.AutoSize = true;
            this.txtTienCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienCong.Location = new System.Drawing.Point(686, 29);
            this.txtTienCong.Name = "txtTienCong";
            this.txtTienCong.Size = new System.Drawing.Size(0, 22);
            this.txtTienCong.TabIndex = 94;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Depth = 0;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(830, 199);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Primary = true;
            this.btnXoa.Size = new System.Drawing.Size(118, 34);
            this.btnXoa.TabIndex = 93;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem.Depth = 0;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(526, 199);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.Primary = true;
            this.btnThem.Size = new System.Drawing.Size(118, 34);
            this.btnThem.TabIndex = 93;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSL
            // 
            this.txtSL.Depth = 0;
            this.txtSL.Hint = "";
            this.txtSL.Location = new System.Drawing.Point(181, 123);
            this.txtSL.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSL.Name = "txtSL";
            this.txtSL.PasswordChar = '\0';
            this.txtSL.SelectedText = "";
            this.txtSL.SelectionLength = 0;
            this.txtSL.SelectionStart = 0;
            this.txtSL.Size = new System.Drawing.Size(181, 28);
            this.txtSL.TabIndex = 87;
            this.txtSL.UseSystemPasswordChar = false;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            // 
            // cbbPhuTung
            // 
            this.cbbPhuTung.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbPhuTung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPhuTung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbPhuTung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPhuTung.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbbPhuTung.FormattingEnabled = true;
            this.cbbPhuTung.Location = new System.Drawing.Point(181, 82);
            this.cbbPhuTung.Name = "cbbPhuTung";
            this.cbbPhuTung.Size = new System.Drawing.Size(329, 33);
            this.cbbPhuTung.TabIndex = 86;
            this.cbbPhuTung.SelectedIndexChanged += new System.EventHandler(this.cbbPhuTung_SelectedIndexChanged);
            // 
            // cbbNoiDung
            // 
            this.cbbNoiDung.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbNoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNoiDung.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbbNoiDung.FormattingEnabled = true;
            this.cbbNoiDung.Location = new System.Drawing.Point(181, 29);
            this.cbbNoiDung.Name = "cbbNoiDung";
            this.cbbNoiDung.Size = new System.Drawing.Size(329, 33);
            this.cbbNoiDung.TabIndex = 86;
            this.cbbNoiDung.SelectedIndexChanged += new System.EventHandler(this.cbbNoiDung_SelectedIndexChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(546, 29);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(105, 24);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Tiền Công: ";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(546, 80);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(87, 24);
            this.materialLabel8.TabIndex = 0;
            this.materialLabel8.Text = "Đơn Giá: ";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(6, 169);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(112, 24);
            this.materialLabel9.TabIndex = 0;
            this.materialLabel9.Text = "Thành Tiền: ";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(6, 127);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(96, 24);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Số Lượng:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(494, 80);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(0, 24);
            this.materialLabel7.TabIndex = 0;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(6, 82);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(99, 24);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "Phụ Tùng: ";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(6, 29);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(93, 24);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Nội Dung:";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Location = new System.Drawing.Point(23, 288);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowHeadersWidth = 51;
            this.dgvChiTiet.RowTemplate.Height = 24;
            this.dgvChiTiet.Size = new System.Drawing.Size(1333, 343);
            this.dgvChiTiet.TabIndex = 2;
            this.dgvChiTiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTiet_CellClick);
            // 
            // btnBaoGia
            // 
            this.btnBaoGia.BackColor = System.Drawing.SystemColors.Control;
            this.btnBaoGia.Depth = 0;
            this.btnBaoGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoGia.Location = new System.Drawing.Point(1056, 650);
            this.btnBaoGia.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaoGia.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBaoGia.Name = "btnBaoGia";
            this.btnBaoGia.Primary = true;
            this.btnBaoGia.Size = new System.Drawing.Size(135, 38);
            this.btnBaoGia.TabIndex = 93;
            this.btnBaoGia.Text = "BÁO GIÁ";
            this.btnBaoGia.UseVisualStyleBackColor = false;
            this.btnBaoGia.Click += new System.EventHandler(this.btnBaoGia_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.SystemColors.Control;
            this.btnXacNhan.Depth = 0;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(1209, 650);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnXacNhan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Primary = true;
            this.btnXacNhan.Size = new System.Drawing.Size(135, 38);
            this.btnXacNhan.TabIndex = 93;
            this.btnXacNhan.Text = "XÁC NHẬN";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.ForeColor = System.Drawing.Color.IndianRed;
            this.lblMaHD.Location = new System.Drawing.Point(55, 144);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(58, 22);
            this.lblMaHD.TabIndex = 94;
            this.lblMaHD.Text = "label1";
            // 
            // printDialogBill
            // 
            this.printDialogBill.UseEXDialog = true;
            // 
            // printDocumentBill
            // 
            this.printDocumentBill.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentBill_PrintPage);
            // 
            // FormCT_PSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 697);
            this.Controls.Add(this.lblMaHD);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnBaoGia);
            this.Controls.Add(this.dgvChiTiet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialLabel1);
            this.Name = "FormCT_PSC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Phiếu Sửa Chữa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox cbbNoiDung;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSL;
        private System.Windows.Forms.ComboBox cbbPhuTung;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private MaterialSkin.Controls.MaterialRaisedButton btnXoa;
        private MaterialSkin.Controls.MaterialRaisedButton btnThem;
        private MaterialSkin.Controls.MaterialRaisedButton btnBaoGia;
        private MaterialSkin.Controls.MaterialRaisedButton btnXacNhan;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label txtTienCong;
        private System.Windows.Forms.Label txtDonGia;
        private System.Windows.Forms.Label txtDonVi;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTienUng;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtThanhTien;
        private MaterialSkin.Controls.MaterialRaisedButton btnHoanThanh;
        private MaterialSkin.Controls.MaterialRaisedButton btnSua;
        private System.Windows.Forms.PrintDialog printDialogBill;
        private System.Drawing.Printing.PrintDocument printDocumentBill;
    }
}