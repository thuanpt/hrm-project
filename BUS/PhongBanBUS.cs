using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class PhongBanBUS
    {
        QuanLyNhanSuDataContext DB = new QuanLyNhanSuDataContext();
        public IEnumerable<PhongBan> viewPhongBan()
        {
            IEnumerable<PhongBan> phongban = from pb in DB.PhongBans
                                             select pb;
            return phongban;
        }
        public bool KTTonTai (string maphongban)
        {
            int kt = (from pb in DB.PhongBans
                              where pb.MaPhongBan == maphongban
                              select pb).Count();

            if (kt == 1)
                return true;
            else
                return false;
        }
        public void ThemPhongBan(string maphongban, string tenphongban, string ghichu)
        {
            PhongBan themphongban = new PhongBan();
            themphongban.MaPhongBan = maphongban;
            themphongban.TenPhongBan = tenphongban;
            themphongban.GhiChu = ghichu;
            DB.PhongBans.InsertOnSubmit(themphongban);
            DB.SubmitChanges();
        }

        public void SuaPhongBan(string maphongban, string tenphongban, string ghichu)
        {
            PhongBan suaphongban = (from pb in DB.PhongBans
                                    select pb).Single(t => t.MaPhongBan == maphongban);

            suaphongban.TenPhongBan = tenphongban;
            suaphongban.GhiChu = ghichu;
            DB.SubmitChanges();

        }
        public void XoaPhongBan (string maphongban)
        {
            PhongBan xoaphongban = (from pb in DB.PhongBans
                                    select pb).Single(t => t.MaPhongBan == maphongban);
            DB.PhongBans.DeleteOnSubmit(xoaphongban);
            DB.SubmitChanges();
        }
    }
}
