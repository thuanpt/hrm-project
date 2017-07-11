using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class TaiKhoanBUS
    {
        QuanLyNhanSuDataContext DB = new QuanLyNhanSuDataContext();
        public bool KTDangNhap (string tendangnhap, string matkhau)
        {
            int taikhoan = (from tk in DB.TaiKhoans
                            where tk.TaiKhoan1 == tendangnhap && tk.MatKhau == matkhau
                            select tk).Count();
            if (taikhoan == 1)
                return true;
            else
                return false;

        }
        public bool KTDoiMatKhau (string taikhoan, string matkhaucu)
        {
            int matkhau = (from mk in DB.TaiKhoans
                           where mk.MatKhau == matkhaucu && taikhoan == taikhoan
                           select mk).Count();
            if (matkhau == 1)
                return true;
            else
                return false;
        }

        public void DoiMatKhau(string taikhoan, string matkhau)
        {
            
           
            TaiKhoan tk = DB.TaiKhoans.Where(p => p.TaiKhoan1 == taikhoan).SingleOrDefault();
            tk.MatKhau = matkhau;
            DB.SubmitChanges();

        }
    }
}
