using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class NhanSuBUS
    {
        QuanLyNhanSuDataContext DB = new QuanLyNhanSuDataContext();
        public IQueryable viewNhanSu()
        {
            var nhansu = from ns in DB.HoSoNhanSus
                       join dt in DB.DanTocs on ns.MaDanToc equals dt.MaDanToc
                       join cv in DB.ChucVus on ns.MaCV equals cv.MaCV
                       join pb in DB.PhongBans on ns.MaPhongBan equals pb.MaPhongBan
                       select new
                       {
                           MaNhanSu = ns.MaNhanSu,
                           TenNS = ns.TenNS,
                           Anh = ns.Anh,
                           GioiTinh = ns.GioiTinh,
                           NgaySinh = ns.NgaySinh,
                           NoiSinh =ns.NoiSinh,
                           QueQuan =ns.QueQuan,
                           HoKhauThuongChu = ns.HoKhauThuongTru,
                           CMND = ns.CMND,
                           NgayCap = ns.NgayCap,
                           NoiCap = ns.NoiCap,
                           QuocTich = ns.QuocTich,
                           TonGiao =ns.TonGiao,
                           MaDanToc =ns.MaDanToc,
                           MaCV =ns.MaCV,
                           MaPhongBan = ns.MaPhongBan,
                           SDT =ns.SDT,
                           Email = ns.Email,
                           NhomMau = ns.NhomMau,
                           ChieuCao =  ns.ChieuCao,
                           CanNang = ns.CanNang,
                           SucKhoe = ns.SucKhoe,
                           TinhTrangHonNhan =ns.TinhTrangHonNhan,
                           ThanhPhanGiaDinh =ns.ThanhPhanGiaDinh,
                           DangVien = ns.DangVien,
                           NgayVaoDoan =ns.NgayVaoDoan,
                           NgayVaoDang = ns.NgayVaoDang,
                           TrinhDoVanHoa = ns.TrinhDoVanHoa,
                           TotNghiep = ns.TotNghiep,
                           NganhDaoTao =ns.NganhDaoTao,
                           Loai =ns.Loai,
                           HocVi =ns.HocVi,
                           NgoaiNgu =ns.NgoaiNgu,
                           DanToc = dt.TenDanToc,
                           ChucVu = cv.TenCV,
                           PhongBan = pb.TenPhongBan,
                           
                       };

            return nhansu;
        }
         public bool KTTonTai(string mans)
       {
           int kt = (from ns in DB.HoSoNhanSus
                     where ns.MaNhanSu == mans
                     select ns).Count();
           if (kt == 1)
               return true;
           else
               return false;
         }
            public void ThemHoSo (string mans, string tenns ,string gioitinh, DateTime ngaysinh, string noisinh, string quequan, string hokhau, int cmnd, DateTime ngaycap, string noicap, string quoctich, string tongiao, string dantoc, string chucvu, string phongban, int sdt, string email, string nhommau, string chieucao, string cannang, string suckhoe, string tthonnhan, string tpgiadinh, string dangvien, DateTime ngayvaodoan, DateTime ngayvaodang , string trinhdovh, string totnghiep, string nganhdaotao, string loai, string hocvi, string ngoaingu ,string anh)
            {
                HoSoNhanSu themnhansu = new HoSoNhanSu();
                themnhansu.MaNhanSu = mans;
                themnhansu.TenNS = tenns;
                themnhansu.Anh = anh;
                themnhansu.GioiTinh = gioitinh;
                themnhansu.NgaySinh = ngaysinh;
                themnhansu.NoiSinh = noisinh;
                themnhansu.QueQuan = quequan;
                themnhansu.HoKhauThuongTru = hokhau;
                themnhansu.CMND = cmnd;
                themnhansu.NgayCap = ngaycap;
                themnhansu.NoiCap = noicap;
                themnhansu.QuocTich = quoctich;
                themnhansu.TonGiao = tongiao;
                themnhansu.MaDanToc = dantoc;
                themnhansu.MaCV = chucvu;
                themnhansu.MaPhongBan = phongban;
                themnhansu.SDT = sdt;
                themnhansu.Email = email;
                themnhansu.NhomMau = nhommau;
                themnhansu.ChieuCao = chieucao;
                themnhansu.CanNang = cannang;
                themnhansu.SucKhoe = suckhoe;
                themnhansu.TinhTrangHonNhan = tthonnhan;
                themnhansu.ThanhPhanGiaDinh = tpgiadinh;
                themnhansu.DangVien = dangvien;
                themnhansu.NgayVaoDoan = ngayvaodoan;
                themnhansu.NgayVaoDang = ngayvaodang;
                themnhansu.TrinhDoVanHoa = trinhdovh;
                themnhansu.TotNghiep = totnghiep;
                themnhansu.NganhDaoTao = nganhdaotao;
                themnhansu.Loai = loai;
                themnhansu.HocVi = hocvi;
                themnhansu.NgoaiNgu = ngoaingu;
                DB.HoSoNhanSus.InsertOnSubmit(themnhansu);
                DB.SubmitChanges();
            }

            public void SuaNhanSu(string mans, string tenns, string gioitinh, DateTime ngaysinh, string noisinh, string quequan, string hokhau, int cmnd, DateTime ngaycap, string noicap, string quoctich, string tongiao, string dantoc, string chucvu, string phongban, int sdt, string email, string nhommau, string chieucao, string cannang, string suckhoe, string tthonnhan, string tpgiadinh,string dangvien, DateTime ngayvaodoan, DateTime ngayvaodang, string trinhdovh, string totnghiep, string nganhdaotao, string loai, string hocvi, string ngoaingu, string anh)
            {
                HoSoNhanSu suanhansu = (from ns in DB.HoSoNhanSus
                                        select ns).Single(t => t.MaNhanSu == mans);

                suanhansu.TenNS = tenns;
                if (anh != null && System.IO.File.Exists(anh))
                    suanhansu.Anh = anh;
                suanhansu.GioiTinh = gioitinh;
                suanhansu.NgaySinh = ngaysinh;
                suanhansu.NoiSinh = noisinh;
                suanhansu.QueQuan = quequan;
                suanhansu.HoKhauThuongTru = hokhau;
                suanhansu.CMND = cmnd;
                suanhansu.NgayCap = ngaycap;
                suanhansu.NoiCap = noicap;
                suanhansu.QuocTich = quoctich;
                suanhansu.TonGiao = tongiao;
                suanhansu.MaDanToc = dantoc;
                suanhansu.MaCV = chucvu;
                suanhansu.MaPhongBan = phongban;
                suanhansu.SDT = sdt;
                suanhansu.Email = email;
                suanhansu.NhomMau = nhommau;
                suanhansu.ChieuCao = chieucao;
                suanhansu.CanNang = cannang;
                suanhansu.SucKhoe = suckhoe;
                suanhansu.TinhTrangHonNhan = tthonnhan;
                suanhansu.ThanhPhanGiaDinh = tpgiadinh;
                suanhansu.DangVien = dangvien;
                suanhansu.NgayVaoDoan = ngayvaodoan;
                suanhansu.NgayVaoDang = ngayvaodang;
                suanhansu.TrinhDoVanHoa = trinhdovh;
                suanhansu.TotNghiep = totnghiep;
                suanhansu.NganhDaoTao = nganhdaotao;
                suanhansu.Loai = loai;
                suanhansu.HocVi = hocvi;
                suanhansu.NgoaiNgu = ngoaingu;
                DB.SubmitChanges();

            }
            public void XoaNhanSu(string mans)
            {
                HoSoNhanSu xoanhansu = (from ns in DB.HoSoNhanSus
                                        select ns).Single(t => t.MaNhanSu == mans);
                DB.HoSoNhanSus.DeleteOnSubmit(xoanhansu);
                DB.SubmitChanges();
            }
    }
}
