using BLL.ViewModels;
using DAL.DAL_DTO;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Xml.Linq;

namespace BLL.BLL_DTO
{
    public class PhuTung_BLL
    {
        public List<PhuTungVM> getPhuTungByName(string name)
        {
            List<PhuTung> data = new List<PhuTung>();
            List<PhuTungVM> datavm = new List<PhuTungVM>();
            PhuTung_DAL pt_dal = new PhuTung_DAL();
            if(name == "")
            {
                foreach (PhuTung i in pt_dal.getAllPhuTung())
                {
                    if (i.isDeleted == false)
                    {
                        data.Add(i);
                    }
                }
            }    
            else
            {
                foreach(PhuTung i in pt_dal.getAllPhuTung())
                {
                    if(i.NameVTPT ==  name && i.isDeleted == false)
                    {
                        data.Add(i);
                    }    
                }
            }
            foreach(PhuTung i in data)
            {
                datavm.Add(new PhuTungVM()
                {
                    Id = i.Id,
                    NameVTPT = i.NameVTPT,
                    DonVi = i.DonVi,
                    SoLuong = i.SoLuong,
                    GiaBan = i.GiaBan,

                });
            }
            return datavm;

        }
        
        public void addPhuTung(PhuTungVM a)
        {
            if (a.Validate().Length != 0)
            {
                throw new Exception(a.Validate());
            }
            else
            {
                PhuTung_DAL pt_dal = new PhuTung_DAL();
                pt_dal.addPhuTung(new PhuTung()
                {
                    NameVTPT = a.NameVTPT,
                    DonVi = a.DonVi,
                    GiaBan = a.GiaBan,
                    SoLuong = a.SoLuong,
                    isDeleted = false
                });
            }
        }
        public void UpdateSoLuong(int Id, double SoLuong)
        {
            PhuTung_DAL pt_dal = new PhuTung_DAL();
            pt_dal.UpdateSoLuong(Id, SoLuong);
        }
        public void UpdatePhuTung(PhuTungVM a)
        {
            if (a.Validate().Length != 0)
            {
                throw new Exception(a.Validate());
            }
            else
            {
                PhuTung_DAL pt_dal = new PhuTung_DAL();
                pt_dal.UpdatePhuTung(new PhuTung()
                {
                    Id = a.Id,
                    NameVTPT = a.NameVTPT,
                    DonVi = a.DonVi,
                    GiaBan = a.GiaBan,
                    SoLuong = a.SoLuong,
                    isDeleted = false
                });
            }

        }
        public double getTienPT(int Id)
        {
            PhuTung_DAL pt_dal = new PhuTung_DAL();
            foreach (PhuTung i in pt_dal.getAllPhuTung())
            {
                if (i.Id == Id)
                {
                    return i.GiaBan;
                }
            }
            return 0;
        }
        public string getDonViPT(int Id)
        {
            PhuTung_DAL pt_dal = new PhuTung_DAL();
            foreach (PhuTung i in pt_dal.getAllPhuTung())
            {
                if (i.Id == Id)
                {
                    return i.DonVi;
                }
            }
            return "";
        }
        public double getSoLuongPT(int Id)
        {
            PhuTung_DAL pt_dal = new PhuTung_DAL();
            foreach (PhuTung i in pt_dal.getAllPhuTung())
            {
                if (i.Id == Id)
                {
                    return i.SoLuong;
                }
            }
            return 0;
        }
        public void deletePhuTung(int Id)
        {
            PhuTung_DAL pt_dal = new PhuTung_DAL();
            pt_dal.deletePhuTung(Id);
        }
        
    }
}
