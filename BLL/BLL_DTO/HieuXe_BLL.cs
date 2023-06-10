using BLL.ViewModels;
using DAL.DAL_DTO;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace BLL.BLL_DTO
{
    public class HieuXe_BLL
    {
        public List<HieuXeVM> getAllHieuXe()
        {
            List<HieuXeVM> data = new List<HieuXeVM>();
            HieuXe_DAL hx_dal = new HieuXe_DAL();
            foreach(HieuXe i in hx_dal.getAllHieuXe())
            {
                data.Add(new HieuXeVM
                {
                    Id = i.Id,
                    NameHieuXe = i.NameHieuXe,
                });
            } 
            return data;
        }
        public bool checkNameHieuXe(string hieuxename, int id)
        {
            HieuXe_DAL hx_dal = new HieuXe_DAL();
            foreach(HieuXe i in hx_dal.getAllHieuXe())
            {
                if(i.NameHieuXe == hieuxename && i.Id != id)
                {
                    return false;
                }
            }
            return true;
        }
        public void themHieuXe(HieuXeVM hxvm)
        {
           
            HieuXe_DAL hx_dal = new HieuXe_DAL();
            if (hxvm.Validate().Length != 0)
            {
                throw new Exception(hxvm.Validate());
            }
            else
            {
                if (checkNameHieuXe(hxvm.NameHieuXe, hxvm.Id))
                {
                    HieuXe data = new HieuXe();
                    data.Id = hxvm.Id;
                    data.NameHieuXe = hxvm.NameHieuXe;
                    hx_dal.themHieuXe(data);
                    
                }
                else
                {
                    throw new Exception("Hiệu xe đã tồn tại!");
                }
            }
            
            
            

        }
        public void xoaHieuXe(int id)
        {
            HieuXe_DAL hx_dal = new HieuXe_DAL();
            hx_dal.xoaHieuXe(id);
        }
    }
}
