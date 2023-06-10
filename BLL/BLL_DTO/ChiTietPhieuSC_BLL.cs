using BLL.ViewModels;
using DAL.DAL_DTO;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL_DTO
{
    public class ChiTietPhieuSC_BLL
    {
        public List<ChiTietPhieuSCVM> getAllChiTietPSC(int BillID)
        {
            ChiTietPhieuSC_DAL ctpsc_dal = new ChiTietPhieuSC_DAL();
            
            List<ChiTietPhieuSCVM> datavm = new List<ChiTietPhieuSCVM> ();
            foreach(ChiTietPhieuSC i in ctpsc_dal.getAllChiTietPSC())
            {
                if (i.ID_Phieu == BillID)
                {
                    datavm.Add(new ChiTietPhieuSCVM()
                    {
                        Id = i.Id,
                        ID_Phieu = i.ID_Phieu,
                        Bill_Code = i.PhieuSuaChua.BillCode,
                        ID_TienCong = i.ID_TienCong,
                        NoiDung = i.TienCong.NoiDung,
                        isDone = i.isDone,
                        ID_PhuTung = i.ID_PhuTung,
                        TenVTPT = i.PhuTung.NameVTPT,
                        SoLuong = i.SoLuong,
                        TienUng = i.TienUng,
                        Total = i.Total
                    });
                }
            }
            return datavm;
        }
        public void addCTPSC(ChiTietPhieuSCVM a)
        {
            if (a.Validate().Length != 0)
            {
                throw new Exception(a.Validate());
            }
            else
            {
                ChiTietPhieuSC_DAL ctpsc_dal = new ChiTietPhieuSC_DAL();
                ctpsc_dal.addCTPSC(new ChiTietPhieuSC()
                {
                    ID_Phieu = a.ID_Phieu,
                    ID_TienCong = a.ID_TienCong,
                    ID_PhuTung = a.ID_PhuTung,
                    SoLuong = a.SoLuong,
                    TienUng = a.TienUng,
                    Total = a.Total,
                    isDone = a.isDone
                });
            }    
        }
        public bool checkSLPhuTung(int id, double soluong)
        {
            PhuTung_BLL pt_bll = new PhuTung_BLL();
            if(pt_bll.getSoLuongPT(id) < soluong)
            {
                return false;
            }
            return true;
        }
        public void updateCTPSC(ChiTietPhieuSCVM a)
        {
            if (a.Validate().Length != 0)
            {
                throw new Exception(a.Validate());
            }
            else
            {
                ChiTietPhieuSC_DAL ctpsc_dal = new ChiTietPhieuSC_DAL();
                ctpsc_dal.updateCTPSC(new ChiTietPhieuSC()
                {
                    Id = a.Id,
                    ID_Phieu = a.ID_Phieu,
                    ID_TienCong = a.ID_TienCong,
                    ID_PhuTung = a.ID_PhuTung,
                    SoLuong = a.SoLuong,
                    TienUng = a.TienUng,
                    Total = a.Total,
                    isDone = a.isDone
                });
            }
        }
        public ChiTietPhieuSCVM getCTPSCByID(int ID)
        {
            ChiTietPhieuSC_DAL ctpsc_dal = new ChiTietPhieuSC_DAL();
            ChiTietPhieuSC i = ctpsc_dal.getCTPSCByID(ID);
            return new ChiTietPhieuSCVM()
            {
                Id = i.Id,
                ID_Phieu = i.ID_Phieu,
                Bill_Code = i.PhieuSuaChua.BillCode,
                ID_TienCong = i.ID_TienCong,
                NoiDung = i.TienCong.NoiDung,
                isDone = i.isDone,
                ID_PhuTung = i.ID_PhuTung,
                TenVTPT = i.PhuTung.NameVTPT,
                SoLuong = i.SoLuong,
                TienUng = i.TienUng,
                Total = i.Total
            };
        }
        public void updateHoanThanh(int Id)
        {
            ChiTietPhieuSC_DAL ctpsc_dal = new ChiTietPhieuSC_DAL();
            ctpsc_dal.updateHoanThanh(Id);
        }
        public bool checkHoanThanh(int Id)
        {
            ChiTietPhieuSC_DAL ctpsc_dal = new ChiTietPhieuSC_DAL();
            foreach (ChiTietPhieuSC i in ctpsc_dal.getAllChiTietPSC())
            {
                if(i.Id == Id && i.isDone == false)
                {
                    return true;
                } 
                    
            }
            return false;
        }
        public void deleteCTPSC(int Id)
        {
            ChiTietPhieuSC_DAL ctpsc_dal = new ChiTietPhieuSC_DAL();
            ctpsc_dal.deleteCTPSC(Id);
        }
        
    }
}
