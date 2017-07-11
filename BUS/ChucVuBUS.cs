using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class ChucVuBUS
    {
        QuanLyNhanSuDataContext DB = new QuanLyNhanSuDataContext();
        public IEnumerable<ChucVu> viewChucVu()
        {
            IEnumerable<ChucVu> chucvu = from cv in DB.ChucVus
                                             select cv;
            return chucvu;
        }
        public bool KTTonTai(string macv)
        {
            int kt = (from cv in DB.ChucVus
                      where cv.MaCV == macv
                      select cv
                      ).Count();

            if (kt == 1)
                return true;
            else
                return false;
        }
        public void ThemChucVu(string macv, string tencv)
        {
            ChucVu themchucvu = new ChucVu();
            themchucvu.MaCV = macv;
            themchucvu.TenCV = tencv;
            DB.ChucVus.InsertOnSubmit(themchucvu);
            DB.SubmitChanges();
        }
        public void SuaChucVu(string macv, string tencv)
        {
            ChucVu suachucvu = (from cv in DB.ChucVus
                                    select cv).Single(t => t.MaCV == macv);

            suachucvu.TenCV = tencv;
            DB.SubmitChanges();

        }
        public void XoaChucVu(string macv)
        {
            ChucVu xoachucvu = (from cv in DB.ChucVus
                                    select cv).Single(t => t.MaCV == macv);
            DB.ChucVus.DeleteOnSubmit(xoachucvu);
            DB.SubmitChanges();
        }
    }
}
