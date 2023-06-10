using BLL.ViewModels;
using DAL.DAL_DTO;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BLL.BLL_DTO
{
    public class TienCong_BLL
    {
        public List<TienCongVM> getTienCongByName(string name)
        {
            List<TienCong> data = new List<TienCong>();
            List<TienCongVM> datavm = new List<TienCongVM>();
            TienCong_DAL tc_dal = new TienCong_DAL();
            if (name == "")
            {
                data = tc_dal.getAllTienCong();
            }
            else
            {
                foreach (TienCong i in tc_dal.getAllTienCong())
                {
                    if (i.NoiDung == name)
                    {
                        data.Add(i);
                    }
                }
            }
            foreach (TienCong i in data)
            {
                datavm.Add(new TienCongVM()
                {
                    Id = i.Id,
                    NoiDung = i.NoiDung,
                    GiaTC = i.GiaTC
                    
                    

                });
            }
            return datavm;

        }
        public void AddTienCong(TienCongVM vm)
        {
            if (vm.Validate().Length != 0)
            {
                throw new Exception(vm.Validate());
            }
            else
            {
                if (checkTrungNoiDung(vm.Id, vm.NoiDung) == false)
                {
                    throw new Exception("Nội dung này đã tồn tại! Vui lòng xem lại");
                }
                else
                {
                    TienCong_DAL tc_dal = new TienCong_DAL();
                    tc_dal.addTienCong(new TienCong()
                    {
                        NoiDung = vm.NoiDung,
                        GiaTC = vm.GiaTC
                    });
                }
            }
        }
        public bool checkTrungNoiDung(int Id, string noidung)
        {
            TienCong_DAL tc_dal = new TienCong_DAL();
            foreach (TienCong i in tc_dal.getAllTienCong())
            {
                if (i.NoiDung == noidung && i.Id != Id)
                    return false;
            }
            return true;
        }
        public void UpdateTienCong(TienCongVM vm)
        {
            if (vm.Validate().Length != 0)
            {
                throw new Exception(vm.Validate());
            }
            else
            {
                if(checkTrungNoiDung(vm.Id, vm.NoiDung) == false)
                {
                    throw new Exception("Nội dung này đã tồn tại. Vui lòng xem lại!");
                }    
                TienCong_DAL tc_dal = new TienCong_DAL();
                tc_dal.UpdateTienCong(new TienCong()
                { 
                    Id = vm.Id,
                    NoiDung = vm.NoiDung,
                    GiaTC = vm.GiaTC
                });
            }
                
        }
        public double GetTienCong(int Id)
        {
            TienCong_DAL tc_dal = new TienCong_DAL();
            foreach (TienCong i in tc_dal.getAllTienCong())
            {
                if(i.Id == Id)
                {
                    return i.GiaTC;
                }    
            }
            return 0;
        }
    }
}
