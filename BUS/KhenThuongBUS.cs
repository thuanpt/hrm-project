using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class KhenThuongBUS
    {
        QuanLyNhanSuDataContext DB = new QuanLyNhanSuDataContext();
        public IQueryable viewKhenThuong()
        {
            var khenthuong = from k in DB.KhenThuongs
                             join ns in DB.HoSoNhanSus on k.MaNhanSu equals ns.MaNhanSu
                             select new
                             {
                                 MaKhenThuong=k.MaKhenThuong,
                                 MaNhanSu =k.MaNhanSu,
                                 NgayKT = k.NgayKT,
                                 NoiDungKT = k.NoiDungKT,
                                 NhanSu= ns.TenNS,


                             };

            return khenthuong;
        }
        public bool KTTonTai(string makhenthuong)
        {
            int kt = (from k in DB.KhenThuongs
                      where k.MaKhenThuong == makhenthuong
                      select k).Count();

            if (kt == 1)
                return true;
            else
                return false;
        }
        public void ThemKhenThuong(string makhenthuong, string manhansu, DateTime ngaykhenthuong, string noidung)
        {
            KhenThuong themkhenthuong = new KhenThuong ();
            themkhenthuong.MaKhenThuong = makhenthuong;
            themkhenthuong.MaNhanSu = manhansu;
            themkhenthuong.NgayKT = ngaykhenthuong;
            themkhenthuong.NoiDungKT = noidung;
            DB.KhenThuongs.InsertOnSubmit(themkhenthuong);
            DB.SubmitChanges();
        }

        public void SuaKhenThuong(string makhenthuong, string manhansu, DateTime ngaykhenthuong, string noidung)
        {
            KhenThuong suakhenthuong = (from k in DB.KhenThuongs
                                    select k).Single(t => t.MaKhenThuong == makhenthuong);

            suakhenthuong.MaNhanSu = manhansu;
            suakhenthuong.NgayKT = ngaykhenthuong;
            suakhenthuong.NoiDungKT = noidung;
            DB.SubmitChanges();

        }
        public void XoaKhenThuong(string makhenthuong)
        {
            KhenThuong xoakhenthuong = (from k in DB.KhenThuongs
                                    select k).Single(t => t.MaKhenThuong == makhenthuong);
            DB.KhenThuongs.DeleteOnSubmit(xoakhenthuong);
            DB.SubmitChanges();
        }
    }
}
