using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class KyLuatBUS
    {
        QuanLyNhanSuDataContext DB = new QuanLyNhanSuDataContext();
        public IQueryable viewKyLuat()
        {
            var kyluat = from kl in DB.KyLuats
                             join ns in DB.HoSoNhanSus on kl.MaNhanSu equals ns.MaNhanSu
                             select new
                             {
                                 MaKyLuat = kl.MaKyLuat,
                                 MaNhanSu = kl.MaNhanSu,
                                 NgayKL = kl.NgayKL,
                                 NoiDungKL = kl.NoiDungKL,
                                 NhanSu = ns.TenNS,


                             };

            return kyluat;
        }
        public bool KTTonTai(string makyluat)
        {
            int kt = (from kl in DB.KyLuats
                      where kl.MaKyLuat == makyluat
                      select kl).Count();

            if (kt == 1)
                return true;
            else
                return false;
        }
        public void ThemKyLuat(string makyluat, string manhansu, DateTime ngaykyluat, string noidungkl)
        {
            KyLuat themkyluat = new KyLuat();
            themkyluat.MaKyLuat = makyluat;
            themkyluat.MaNhanSu = manhansu;
            themkyluat.NgayKL = ngaykyluat;
            themkyluat.NoiDungKL = noidungkl;
            DB.KyLuats.InsertOnSubmit(themkyluat);
            DB.SubmitChanges();
        }

        public void SuaKyLuat(string makyluat, string manhansu, DateTime ngaykyluat, string noidungkl)
        {
            KyLuat suakyluat = (from kl in DB.KyLuats
                                        select kl).Single(t => t.MaKyLuat == makyluat);

            suakyluat.MaNhanSu = manhansu;
            suakyluat.NgayKL = ngaykyluat;
            suakyluat.NoiDungKL = noidungkl;
            DB.SubmitChanges();

        }
        public void XoaKyLuat(string makyluat)
        {
            KyLuat xoakyluat = (from kl in DB.KyLuats
                                        select kl).Single(t => t.MaKyLuat == makyluat);
            DB.KyLuats.DeleteOnSubmit(xoakyluat);
            DB.SubmitChanges();
        }
    }
}
