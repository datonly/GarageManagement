namespace GUILayer
{
    partial class MuaPhuTung
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
            this.txtSL = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnMua = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnHuy = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(49, 27);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(303, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Nhập số lượng phụ tùng mua thêm";
            // 
            // txtSL
            // 
            this.txtSL.Depth = 0;
            this.txtSL.Hint = "";
            this.txtSL.Location = new System.Drawing.Point(175, 86);
            this.txtSL.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSL.Name = "txtSL";
            this.txtSL.PasswordChar = '\0';
            this.txtSL.SelectedText = "";
            this.txtSL.SelectionLength = 0;
            this.txtSL.SelectionStart = 0;
            this.txtSL.Size = new System.Drawing.Size(167, 28);
            this.txtSL.TabIndex = 1;
            this.txtSL.UseSystemPasswordChar = false;
            // 
            // btnMua
            // 
            this.btnMua.BackColor = System.Drawing.SystemColors.Control;
            this.btnMua.Depth = 0;
            this.btnMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMua.Location = new System.Drawing.Point(53, 166);
            this.btnMua.Margin = new System.Windows.Forms.Padding(4);
            this.btnMua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMua.Name = "btnMua";
            this.btnMua.Primary = true;
            this.btnMua.Size = new System.Drawing.Size(110, 38);
            this.btnMua.TabIndex = 94;
            this.btnMua.Text = "Mua";
            this.btnMua.UseVisualStyleBackColor = false;
            this.btnMua.Click += new System.EventHandler(this.btnMua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.Control;
            this.btnHuy.Depth = 0;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(362, 166);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Primary = true;
            this.btnHuy.Size = new System.Drawing.Size(110, 38);
            this.btnHuy.TabIndex = 95;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // MuaPhuTung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 249);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnMua);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.materialLabel1);
            this.Name = "MuaPhuTung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MuaPhuTung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSL;
        private MaterialSkin.Controls.MaterialRaisedButton btnMua;
        private MaterialSkin.Controls.MaterialRaisedButton btnHuy;
    }
}