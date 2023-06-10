using BLL.BLL_DTO;
using BLL.ViewModels;
using FontAwesome.Sharp;
using GUILayer.ChildForm;
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
    public partial class FormControl : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public FormControl()
        {
            InitializeComponent();
            InitializeUI();
            Authorization();
        }
        #region Logo, Timer, Exit , Minimize , Zoom
        private void picLogo_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentForm.IconChar = IconChar.Squarespace;
            iconCurrentForm.IconColor = Color.Gainsboro;
            lblCurrentForm.Text = "Trang Chủ";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            //this.lblDateTime.Text = datetime.ToString("dd/MM/yyyy HH:mm:ss");
            this.lblTime.Text = datetime.ToString("HH:mm:ss");
            this.lblDMY.Text = datetime.ToString("dd/MM/yyyy");
            this.lblDate.Text = datetime.ToString("dddd");
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconZoom_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        #endregion
        #region InitializeUI
        private void InitializeUI()
        {
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            PanelMenu.Controls.Add(leftBorderBtn);
            timer.Start(); //đồng hồ
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }
        #endregion
        #region SubPanel Design  

        private void HideSubMenu()
        {
            if (PanelCapNhat.Visible == true)
                PanelCapNhat.Visible = false;
            if (PanelThiHanh.Visible == true)
                PanelThiHanh.Visible = false;
            if (pnlBCDS.Visible == true)
                pnlBCDS.Visible = false;
            if(pnlTaiKhoan.Visible == true)
                pnlTaiKhoan.Visible = false;
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblCurrentForm.Text = childForm.Text;
            childForm.BackColor = Color.WhiteSmoke;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #endregion
        #region Authorization
        public void Authorization()
        {
            Account_BLL acc_bll = new Account_BLL();
            AccountInformation_BLL acci_bll = new AccountInformation_BLL();
            AccountVM currentAcc = acc_bll.GetAccountById(FormLogin.currentAccount_Id);
            AccountInformationVM currentAccIfo = acci_bll.GetAIByAccountId(FormLogin.currentAccount_Id);
            //string Name = currentAccIfo != null ? currentAccIfo.Name : "";
            if (currentAcc.Role != "Admin")
            {
                //lblRole.Text = $"Thu Ngân {Name}";
                btnCapNhat.Visible = false;
                btnNhanVien.Visible = false;
                btnDuDoan.Visible = false;
                
                //btnTimKiem.Visible = false;
            }
            
            //else lblRole.Text = $"Quản lý {Name}";
            
        }
        #endregion
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ShowSubMenu(PanelCapNhat);
            ActiveButton(sender, RGBColors.color4);
        }
        #region ChildForm Design 
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(145, 151, 154);
        }

        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left border btn
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //icon small
                //iconCurrentForm.IconChar = currentBtn.IconChar;
                //iconCurrentForm.IconColor = color;

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(34, 36, 49);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        #endregion

        private void btnThiHanh_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ShowSubMenu(PanelThiHanh);
            ActiveButton(sender, RGBColors.color1);
        }

        private void btn_BaoCao_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ShowSubMenu(pnlBCDS);
            ActiveButton(sender, RGBColors.color1);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ShowSubMenu(pnlTaiKhoan);
            ActiveButton(sender, RGBColors.color1);
        }

        private void btnTiepNhanXe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTiepNhanXe());
        }

        private void btnLapPhieuSuaChua_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPhieuSuaChua());
        }

        private void btnPhuTung_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPhuTung());
        }

        private void btnDSNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDSNV());
        }

        private void btnDSTK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTaiKhoan());
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ActiveButton(sender, RGBColors.color6);
            OpenChildForm(new FormThietLap());
        }

        private void btnTienCong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTienCong());
        }

        private void btnQuyDinh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuyDinh());
        }

        private void btnHieuXe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHieuXe());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ActiveButton(sender, RGBColors.color7);
            this.Close();
        }

        private void btn_BCDS_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKe());
        }

        private void btn_BCVTPT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKeSoLieu());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DuDoanDoanhThu());
        }
    }
}
