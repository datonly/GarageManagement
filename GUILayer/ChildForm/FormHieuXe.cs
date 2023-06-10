using BLL.BLL_DTO;
using BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUILayer.ChildForm
{
    public partial class FormHieuXe : Form
    {
        public FormHieuXe()
        {
            InitializeComponent();
            setCbbHieuXe();
        }
        public void setCbbHieuXe()
        {
            HieuXe_BLL hx_bll = new HieuXe_BLL();
            cbbHieuXe.DataSource = hx_bll.getAllHieuXe();
            cbbHieuXe.DisplayMember = "NameHieuXe";
            cbbHieuXe.ValueMember = "Id";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                HieuXe_BLL hx_bll = new HieuXe_BLL();
                hx_bll.themHieuXe(new HieuXeVM()
                {
                    NameHieuXe = txtNameHieuXe.Text
                    
                });
                
                setCbbHieuXe();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            DialogResult dr = MessageBox.Show("Bạn đã chắc chắn đã xem xét kĩ chưa?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HieuXe_BLL hx_bll = new HieuXe_BLL();
                int id = Convert.ToInt32(cbbHieuXe.SelectedValue);
                hx_bll.xoaHieuXe(id);
                MessageBox.Show("Đã xóa hiệu xe!");
                setCbbHieuXe();
            }
            else
            {
                MessageBox.Show("Đã hủy việc xóa! ");
            }
            
            
        }
    }
}
