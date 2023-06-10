using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUILayer
{
    public partial class MuaPhuTung : Form
    {
        TextBox txtSoLuong;

        public MuaPhuTung(TextBox _txtSL)
        {
            InitializeComponent();
            txtSoLuong = _txtSL;
        }

        private void btnMua_Click(object sender, EventArgs e)
        {
            if (txtSL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng phụ tùng cần mua", "Thông báo");
            }
            else if (Convert.ToDouble(txtSL.Text) < 1)
            {
                MessageBox.Show("Số lượng phụ tùng cần nhập phải lớn hơn 1!", "Thông báo");
            }
            else
            {
                double soLuong = Convert.ToDouble(txtSoLuong.Text);
                try
                {
                    soLuong += Convert.ToDouble(txtSL.Text);
                    txtSoLuong.Text = soLuong.ToString();
                    MessageBox.Show("Mua thành công!", "Thông báo");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Số lượng phải là một số nguyên", "Thông báo");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
