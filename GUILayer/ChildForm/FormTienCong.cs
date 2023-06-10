using BLL;
using BLL.BLL_DTO;
using BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUILayer.ChildForm
{
    public partial class FormTienCong : Form
    {
        public FormTienCong()
        {
            InitializeComponent();
            dgvTienCong.FormatTable();
            LoadData();
        }
        public void LoadData(string name = "")
        {
            TienCong_BLL tc_bll = new TienCong_BLL();
            dgvTienCong.DataSource = tc_bll.getTienCongByName(name);
            dgvTienCong.Columns["Id"].Visible = false;
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtNoiDung.Enabled = false;

            txtNoiDung.Clear();
            txtTienCong.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                TienCong_BLL tc_bll = new TienCong_BLL();
                tc_bll.AddTienCong(new TienCongVM()
                {
                    NoiDung = txtNoiDung.Text,
                    GiaTC = Convert.ToDouble(txtTienCong.Text)
                });
                MessageBox.Show("Thêm tiền công thành công", "Thông báo");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNoiDung.Text = txtTienCong.Text = "";
            btnSua.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                TienCong_BLL tc_bll = new TienCong_BLL();
                tc_bll.UpdateTienCong(new TienCongVM()
                {
                    Id = Convert.ToInt32(dgvTienCong.SelectedRows[0].Cells["Id"].Value),
                    NoiDung = txtNoiDung.Text,
                    GiaTC = Convert.ToDouble(txtTienCong.Text)
                });
                MessageBox.Show("Cập nhật tiền công thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dgvTienCong_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvTienCong.SelectedRows;
            if (r.Count == 1)
            {
                txtNoiDung.Text = r[0].Cells["NoiDung"].Value.ToString();
                txtTienCong.Text = r[0].Cells["GiaTC"].Value.ToString();
                btnSua.Enabled = true;
            }
        }
    }
}
