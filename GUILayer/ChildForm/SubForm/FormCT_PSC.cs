using BLL;
using BLL.BLL_DTO;
using BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUILayer.ChildForm.SubForm
{
    public partial class FormCT_PSC : Form
    {
        private int bill_Id;
       
        public FormCT_PSC(int Bill_Id, string BillCode)
        {
            InitializeComponent();
            LoadDataCBB();
            lblMaHD.Text = BillCode;
            txtTienUng.Text = 0.ToString();
            txtTienUng.Visible = false;
            bill_Id = Bill_Id;
            dgvChiTiet.FormatTable();
            btnHoanThanh.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
            printDocumentBill.DefaultPageSettings.Landscape = true;
            LoadData();
        }
        public void LoadDataCBB()
        {
            PhuTung_BLL pt_bll = new PhuTung_BLL();
            List<PhuTungVM> data = new List<PhuTungVM>();
            data = pt_bll.getPhuTungByName("");
            cbbPhuTung.DataSource = data;
            cbbPhuTung.DisplayMember = "NameVTPT";
            cbbPhuTung.ValueMember = "Id";
            cbbPhuTung.SelectedIndex = -1;
            TienCong_BLL tc_bll = new TienCong_BLL();
            List<TienCongVM> data1 = new List<TienCongVM>();
            data1 = tc_bll.getTienCongByName("");
            cbbNoiDung.DataSource = data1;
            cbbNoiDung.DisplayMember = "NoiDung";
            cbbNoiDung.ValueMember = "Id";
            cbbNoiDung.SelectedIndex = -1;

        }
        public void LoadData()
        {
            ChiTietPhieuSC_BLL ctpsc_bll = new ChiTietPhieuSC_BLL();
            dgvChiTiet.DataSource = ctpsc_bll.getAllChiTietPSC(bill_Id);
            dgvChiTiet.Columns["Id"].Visible = false;
            dgvChiTiet.Columns["Bill_Code"].Visible = false;
            dgvChiTiet.Columns["ID_TienCong"].Visible = false;
            dgvChiTiet.Columns["ID_PhuTung"].Visible = false;
            dgvChiTiet.Columns["isDone"].ReadOnly = false;

        }

        private void cbbNoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            TienCong_BLL tc_bll = new TienCong_BLL();
            txtTienCong.Text = String.Format("{0:0,0}", tc_bll.GetTienCong(Convert.ToInt32(cbbNoiDung.SelectedValue)));
            double donGia;
            double soLuong;
            double tienCong;
            double thanhTien = 0;
            if (!String.IsNullOrEmpty(txtDonGia.Text) && !String.IsNullOrEmpty(txtSL.Text))
            {
                tienCong = Convert.ToDouble(txtTienCong.Text);
                donGia = Convert.ToDouble(txtDonGia.Text);
                soLuong = Convert.ToDouble(txtSL.Text);
                thanhTien = donGia * soLuong + tienCong;
                txtThanhTien.Text = string.Format("{0:0,0}", decimal.Parse(thanhTien.ToString()));

            }
        }

        private void cbbPhuTung_SelectedIndexChanged(object sender, EventArgs e)
        {
            PhuTung_BLL pt_bll = new PhuTung_BLL();
            txtDonGia.Text = String.Format("{0:0,0}", pt_bll.getTienPT(Convert.ToInt32(cbbPhuTung.SelectedValue)));
            txtDonVi.Text = pt_bll.getDonViPT(Convert.ToInt32(cbbPhuTung.SelectedValue));
            if (cbbPhuTung.Text == "Không dùng")
            {
                txtSL.Text = 0.ToString();
                txtSL.Enabled = false;
            }
            else
            {
                txtSL.Enabled = true;
                txtSL.Text = 1.ToString();
            }
            double donGia;
            double soLuong;
            double tienCong;
            double thanhTien = 0;
            if (!String.IsNullOrEmpty(txtDonGia.Text) && !String.IsNullOrEmpty(txtSL.Text))
            {
                tienCong = Convert.ToDouble(txtTienCong.Text);
                donGia = Convert.ToDouble(txtDonGia.Text);
                soLuong = Convert.ToDouble(txtSL.Text);
                thanhTien = donGia * soLuong + tienCong;
                txtThanhTien.Text = string.Format("{0:0,0}", decimal.Parse(thanhTien.ToString()));

            }

        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {

            try
            {
                double donGia;
                double soLuong;
                double tienCong;
                double thanhTien = 0;
                if (!String.IsNullOrEmpty(txtDonGia.Text) && !String.IsNullOrEmpty(txtSL.Text))
                {
                    tienCong = Convert.ToDouble(txtTienCong.Text);
                    donGia = Convert.ToDouble(txtDonGia.Text);
                    soLuong = Convert.ToDouble(txtSL.Text);
                    thanhTien = donGia * soLuong + tienCong;
                    txtThanhTien.Text = string.Format("{0:0,0}", decimal.Parse(thanhTien.ToString()));

                }
            }
            catch (Exception ex)
            {
                txtSL.Text = "";
                //MessageBox.Show("Vui lòng nhập đúng số lượng!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtThanhTien.Text) > 2000000)
            {
                double a = Convert.ToDouble(txtThanhTien.Text);
                a = a * 15 / 100;
                txtTienUng.Visible = true;
                txtTienUng.Enabled = false;
                txtTienUng.Text = string.Format("{0:0,0}", decimal.Parse(a.ToString()));
            }
            else
            {
                txtTienUng.Visible = false;
                txtTienUng.Enabled = true;
                txtTienUng.Text = 0.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //String s = String.Format("Tiền ứng {0}, Tổng tiền {1}, Nội dung {2}, Phụ tùng {3}, Số lượng {4}",
            //              txtTienUng.Text, txtThanhTien.Text, cbbNoiDung.Text, cbbPhuTung.Text, txtSL.Text);
            //MessageBox.Show(s);
            if (cbbNoiDung.Text == "" || cbbPhuTung.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nội dung/Phụ Tùng để sửa!");
            }
            else if (txtSL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng phụ tùng");
            }
            else
            {


                ChiTietPhieuSC_BLL ctpsc_bll = new ChiTietPhieuSC_BLL();
                if (ctpsc_bll.checkSLPhuTung(Convert.ToInt32(cbbPhuTung.SelectedValue), Convert.ToDouble(txtSL.Text)) == false)
                {
                    DialogResult dialogResult = MessageBox.Show("Số lượng phụ tùng bạn nhập vượt quá trong kho. Bạn vẫn muốn thêm vào?", "Bình tĩnh !", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            ChiTietPhieuSCVM a = new ChiTietPhieuSCVM()
                            {
                                ID_Phieu = bill_Id,
                                ID_TienCong = Convert.ToInt32(cbbNoiDung.SelectedValue),
                                ID_PhuTung = Convert.ToInt32(cbbPhuTung.SelectedValue),
                                SoLuong = Convert.ToDouble(txtSL.Text),
                                TienUng = Convert.ToDouble(txtTienUng.Text),
                                Total = Convert.ToDouble(txtThanhTien.Text),
                                isDone = false,


                            };
                            
                            ctpsc_bll.addCTPSC(a);
                            LoadData();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
                    }
                }
                else
                {
                    try
                    {
                        ChiTietPhieuSCVM a = new ChiTietPhieuSCVM()
                        {
                            ID_Phieu = bill_Id,
                            ID_TienCong = Convert.ToInt32(cbbNoiDung.SelectedValue),
                            ID_PhuTung = Convert.ToInt32(cbbPhuTung.SelectedValue),
                            SoLuong = Convert.ToDouble(txtSL.Text),
                            TienUng = Convert.ToDouble(txtTienUng.Text),
                            Total = Convert.ToDouble(txtThanhTien.Text),
                            isDone = false,


                        };
                        
                        ctpsc_bll.addCTPSC(a);
                        LoadData();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }    


            }
        }

        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {

                    cbbNoiDung.SelectedValue = Convert.ToInt32(dgvChiTiet.Rows[e.RowIndex].Cells["ID_TienCong"].Value.ToString());
                    cbbPhuTung.SelectedValue = Convert.ToInt32(dgvChiTiet.Rows[e.RowIndex].Cells["ID_PhuTung"].Value.ToString());
                    txtSL.Text = dgvChiTiet.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
                    txtThanhTien.Text = dgvChiTiet.Rows[e.RowIndex].Cells["Total"].Value.ToString();
                    txtTienUng.Text = dgvChiTiet.Rows[e.RowIndex].Cells["TienUng"].Value.ToString();
                    btnHoanThanh.Visible = true;
                    btnSua.Visible = true;
                    btnXoa.Visible = true;

                    //txtDonGia.Text = String.Format("{0:0,0}", decimal.Parse(dgvPhuTung.Rows[e.RowIndex].Cells["GiaBan"].Value.ToString()));
                    //txtDonVi.Text = dgvPhuTung.Rows[e.RowIndex].Cells["DonVi"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cbbNoiDung.Text == "" || cbbPhuTung.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nội dung/Phụ Tùng để sửa!");
            }
            else if (txtSL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng phụ tùng");
            }
            else
            {


                ChiTietPhieuSC_BLL ctpsc_bll = new ChiTietPhieuSC_BLL();
                if (ctpsc_bll.checkSLPhuTung(Convert.ToInt32(cbbPhuTung.SelectedValue), Convert.ToDouble(txtSL.Text)) == false)
                {
                    DialogResult dialogResult = MessageBox.Show("Số lượng phụ tùng bạn nhập vượt quá trong kho. Bạn vẫn muốn sửa?", "Bình tĩnh !", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            ChiTietPhieuSCVM a = new ChiTietPhieuSCVM()
                            {
                                Id = Convert.ToInt32(dgvChiTiet.SelectedRows[0].Cells["Id"].Value.ToString()),
                                ID_Phieu = bill_Id,
                                ID_TienCong = Convert.ToInt32(cbbNoiDung.SelectedValue),
                                ID_PhuTung = Convert.ToInt32(cbbPhuTung.SelectedValue),
                                SoLuong = Convert.ToDouble(txtSL.Text),
                                TienUng = Convert.ToDouble(txtTienUng.Text),
                                Total = Convert.ToDouble(txtThanhTien.Text),
                                isDone = false,


                            };

                            ctpsc_bll.updateCTPSC(a);
                            LoadData();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
                    }
                }
                else
                {
                    try
                    {
                        ChiTietPhieuSCVM a = new ChiTietPhieuSCVM()
                        {
                            Id = Convert.ToInt32(dgvChiTiet.SelectedRows[0].Cells["Id"].Value.ToString()),
                            ID_Phieu = bill_Id,
                            ID_TienCong = Convert.ToInt32(cbbNoiDung.SelectedValue),
                            ID_PhuTung = Convert.ToInt32(cbbPhuTung.SelectedValue),
                            SoLuong = Convert.ToDouble(txtSL.Text),
                            TienUng = Convert.ToDouble(txtTienUng.Text),
                            Total = Convert.ToDouble(txtThanhTien.Text),
                            isDone = false,


                        };

                        ctpsc_bll.updateCTPSC(a);
                        LoadData();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }


            }
        }
        

        private void printDocumentBill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PhieuSuaChua_BLL psc_bll = new PhieuSuaChua_BLL();
            string content = psc_bll.GetContentPrint(bill_Id);
            e.Graphics.DrawString(content, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, 100);
            MessageBox.Show("In hoá đơn thành công");
        }

        private void btnBaoGia_Click(object sender, EventArgs e)
        {
            try
            {
                printDialogBill.Document = printDocumentBill;
                if (printDialogBill.ShowDialog() == DialogResult.OK)
                {
                    printDocumentBill.Print();
                }
            }
            catch
            {
                MessageBox.Show("Không in được!");
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            ChiTietPhieuSC_BLL ctpsc_bll = new ChiTietPhieuSC_BLL();
            if (dgvChiTiet.SelectedRows.Count == 1)
            {
                int Id = Convert.ToInt32(dgvChiTiet.SelectedRows[0].Cells["Id"].Value.ToString());
                if (ctpsc_bll.checkHoanThanh(Id))
                {


                    ChiTietPhieuSCVM a = ctpsc_bll.getCTPSCByID(Id);
                    if (ctpsc_bll.checkSLPhuTung(a.ID_PhuTung, a.SoLuong) == false)
                    {
                        MessageBox.Show("Không thể hoàn thành nội dung này vì phụ tùng trong kho đã hết!", "Thông báo");
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Xác nhận hoàn thành nội dung này? ", "Bình tĩnh !", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            PhuTung_BLL pt_bll = new PhuTung_BLL();

                            double soluongtrongkho = pt_bll.getSoLuongPT(a.ID_PhuTung);
                            double soluongsudung = a.SoLuong;
                            double soluongconlai = soluongtrongkho - soluongsudung;
                            
                            pt_bll.UpdateSoLuong(a.ID_PhuTung, soluongconlai);
                            ctpsc_bll.updateHoanThanh(Id);
                            LoadData();

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Đã hoàn thành sửa chữa rồi!");
                }    
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ChiTietPhieuSC_BLL ctpsc_bll = new ChiTietPhieuSC_BLL();
            if (dgvChiTiet.SelectedRows.Count == 1)
            {
                int Id = Convert.ToInt32(dgvChiTiet.SelectedRows[0].Cells["Id"].Value.ToString());
                if (ctpsc_bll.checkHoanThanh(Id))
                {
                    ctpsc_bll.deleteCTPSC(Id);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Nội dung đã hoàn thành thì không thể xóa!");
                }
            }
        }
    }
}
