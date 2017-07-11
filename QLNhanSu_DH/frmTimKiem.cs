using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;

namespace QLNhanSu_DH
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
        ChucVuBUS chucvubus = new ChucVuBUS();
        PhongBanBUS phongbanbus = new PhongBanBUS();
        private void frmTimKiem_Load(object sender, EventArgs e)
        {

            dgvTimKiem.DataSource = nhansubus.viewNhanSu();

            dgvTimKiem.Columns["Anh"].Visible = false;
            dgvTimKiem.Columns["MaDanToc"].Visible = false;
            dgvTimKiem.Columns["MaCV"].Visible = false;
            dgvTimKiem.Columns["MaPhongBan"].Visible = false;

            dgvTimKiem.Columns["MaNhanSu"].HeaderText = "Mã Nhân Sự";
            dgvTimKiem.Columns["TenNS"].HeaderText = "Họ Tên";
            dgvTimKiem.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgvTimKiem.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvTimKiem.Columns["NoiSinh"].HeaderText = "Nơi Sinh";
            dgvTimKiem.Columns["QueQuan"].HeaderText = "Quê Quán";
            dgvTimKiem.Columns["HoKhauThuongChu"].HeaderText = "Hộ Khẩu";
            dgvTimKiem.Columns["CMND"].HeaderText = "CMND";
            dgvTimKiem.Columns["NoiCap"].HeaderText = "Nơi Cấp";
            dgvTimKiem.Columns["NgayCap"].HeaderText = "Ngày Cấp";
            dgvTimKiem.Columns["QuocTich"].HeaderText = "Quốc Tịch";
            dgvTimKiem.Columns["TonGiao"].HeaderText = "Tôn Giáo";
            dgvTimKiem.Columns["SDT"].HeaderText = "ĐT Liên Hệ";
            dgvTimKiem.Columns["Email"].HeaderText = "Email";
            dgvTimKiem.Columns["NhomMau"].HeaderText = "Nhóm Máu";
            dgvTimKiem.Columns["ChieuCao"].HeaderText = "Chiều Cao";
            dgvTimKiem.Columns["CanNang"].HeaderText = "Cân Nặng";
            dgvTimKiem.Columns["SucKhoe"].HeaderText = "Sức Khỏe";
            dgvTimKiem.Columns["TinhTrangHonNhan"].HeaderText = "Tình Trạng Hôn Nhân";
            dgvTimKiem.Columns["ThanhPhanGiaDinh"].HeaderText = "Thành Phần Gia Đình";
            dgvTimKiem.Columns["DangVien"].HeaderText = "Đảng Viên";
            dgvTimKiem.Columns["NgayVaoDoan"].HeaderText = "Ngày Vào Đoàn";
            dgvTimKiem.Columns["NgayVaoDang"].HeaderText = "Ngày Vào Đảng";
            dgvTimKiem.Columns["TrinhDoVanHoa"].HeaderText = "Trình Độ Văn Hóa";
            dgvTimKiem.Columns["TotNghiep"].HeaderText = "Tốt Nghiệp";
            dgvTimKiem.Columns["NganhDaoTao"].HeaderText = "Ngành Đào Tạo";
            dgvTimKiem.Columns["Loai"].HeaderText = "Xếp Loại";
            dgvTimKiem.Columns["HocVi"].HeaderText = "Học Vị";
            dgvTimKiem.Columns["NgoaiNgu"].HeaderText = "Trình Độ Ngoại Ngữ";
            dgvTimKiem.Columns["DanToc"].HeaderText = "Dân Tộc";
            dgvTimKiem.Columns["ChucVu"].HeaderText = "Chức Vụ";
            dgvTimKiem.Columns["PhongBan"].HeaderText = "Phòng Ban";



            cbTimCV.DataSource = chucvubus.viewChucVu();
            cbTimCV.DisplayMember = "TenCV";
            cbTimCV.ValueMember = "MaCV";

            cbTimPB.DataSource = phongbanbus.viewPhongBan();
            cbTimPB.DisplayMember = "TenPhongBan";
            cbTimPB.ValueMember = "MaPhongBan";
        }

        private void cbTimPB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var Lst = from ns in DB.HoSoNhanSus
                      join dt in DB.DanTocs on ns.MaDanToc equals dt.MaDanToc
                      join cv in DB.ChucVus on ns.MaCV equals cv.MaCV
                      join pb in DB.PhongBans on ns.MaPhongBan equals pb.MaPhongBan
                      where ns.MaPhongBan.Contains(cbTimPB.SelectedValue.ToString())
                      select new
                      {
                          MaNhanSu = ns.MaNhanSu,
                          TenNS = ns.TenNS,
                          Anh = ns.Anh,
                          GioiTinh = ns.GioiTinh,
                          NgaySinh = ns.NgaySinh,
                          NoiSinh = ns.NoiSinh,
                          QueQuan = ns.QueQuan,
                          HoKhauThuongChu = ns.HoKhauThuongTru,
                          CMND = ns.CMND,
                          NgayCap = ns.NgayCap,
                          NoiCap = ns.NoiCap,
                          QuocTich = ns.QuocTich,
                          TonGiao = ns.TonGiao,
                          MaDanToc = ns.MaDanToc,
                          MaCV = ns.MaCV,
                          MaPhongBan = ns.MaPhongBan,
                          SDT = ns.SDT,
                          Email = ns.Email,
                          NhomMau = ns.NhomMau,
                          ChieuCao = ns.ChieuCao,
                          CanNang = ns.CanNang,
                          SucKhoe = ns.SucKhoe,
                          TinhTrangHonNhan = ns.TinhTrangHonNhan,
                          ThanhPhanGiaDinh = ns.ThanhPhanGiaDinh,
                          DangVien = ns.DangVien,
                          NgayVaoDoan = ns.NgayVaoDoan,
                          NgayVaoDang = ns.NgayVaoDang,
                          TrinhDoVanHoa = ns.TrinhDoVanHoa,
                          TotNghiep = ns.TotNghiep,
                          NganhDaoTao = ns.NganhDaoTao,
                          Loai = ns.Loai,
                          HocVi = ns.HocVi,
                          NgoaiNgu = ns.NgoaiNgu,
                          DanToc = dt.TenDanToc,
                          ChucVu = cv.TenCV,
                          PhongBan = pb.TenPhongBan,

                      };
            dgvTimKiem.DataSource = Lst;
        }
        NhanSuBUS nhansubus = new NhanSuBUS();

        private void cbTimCV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var Lst = from ns in DB.HoSoNhanSus
                      join dt in DB.DanTocs on ns.MaDanToc equals dt.MaDanToc
                      join cv in DB.ChucVus on ns.MaCV equals cv.MaCV
                      join pb in DB.PhongBans on ns.MaPhongBan equals pb.MaPhongBan
                      where ns.MaCV.Contains(cbTimCV.SelectedValue.ToString())
                      select new
                      {
                          MaNhanSu = ns.MaNhanSu,
                          TenNS = ns.TenNS,
                          Anh = ns.Anh,
                          GioiTinh = ns.GioiTinh,
                          NgaySinh = ns.NgaySinh,
                          NoiSinh = ns.NoiSinh,
                          QueQuan = ns.QueQuan,
                          HoKhauThuongChu = ns.HoKhauThuongTru,
                          CMND = ns.CMND,
                          NgayCap = ns.NgayCap,
                          NoiCap = ns.NoiCap,
                          QuocTich = ns.QuocTich,
                          TonGiao = ns.TonGiao,
                          MaDanToc = ns.MaDanToc,
                          MaCV = ns.MaCV,
                          MaPhongBan = ns.MaPhongBan,
                          SDT = ns.SDT,
                          Email = ns.Email,
                          NhomMau = ns.NhomMau,
                          ChieuCao = ns.ChieuCao,
                          CanNang = ns.CanNang,
                          SucKhoe = ns.SucKhoe,
                          TinhTrangHonNhan = ns.TinhTrangHonNhan,
                          ThanhPhanGiaDinh = ns.ThanhPhanGiaDinh,
                          DangVien = ns.DangVien,
                          NgayVaoDoan = ns.NgayVaoDoan,
                          NgayVaoDang = ns.NgayVaoDang,
                          TrinhDoVanHoa = ns.TrinhDoVanHoa,
                          TotNghiep = ns.TotNghiep,
                          NganhDaoTao = ns.NganhDaoTao,
                          Loai = ns.Loai,
                          HocVi = ns.HocVi,
                          NgoaiNgu = ns.NgoaiNgu,
                          DanToc = dt.TenDanToc,
                          ChucVu = cv.TenCV,
                          PhongBan = pb.TenPhongBan,

                      };
            dgvTimKiem.DataSource = Lst;
        }
        QuanLyNhanSuDataContext DB = new QuanLyNhanSuDataContext();
        private void txtTimTheoMa_KeyUp(object sender, KeyEventArgs e)
        {

            var Lst = from ns in DB.HoSoNhanSus
                      join dt in DB.DanTocs on ns.MaDanToc equals dt.MaDanToc
                      join cv in DB.ChucVus on ns.MaCV equals cv.MaCV
                      join pb in DB.PhongBans on ns.MaPhongBan equals pb.MaPhongBan
                      where ns.MaNhanSu.Contains(txtTimTheoMa.Text)
                      select new
                      {
                          MaNhanSu = ns.MaNhanSu,
                          TenNS = ns.TenNS,
                          Anh = ns.Anh,
                          GioiTinh = ns.GioiTinh,
                          NgaySinh = ns.NgaySinh,
                          NoiSinh = ns.NoiSinh,
                          QueQuan = ns.QueQuan,
                          HoKhauThuongChu = ns.HoKhauThuongTru,
                          CMND = ns.CMND,
                          NgayCap = ns.NgayCap,
                          NoiCap = ns.NoiCap,
                          QuocTich = ns.QuocTich,
                          TonGiao = ns.TonGiao,
                          MaDanToc = ns.MaDanToc,
                          MaCV = ns.MaCV,
                          MaPhongBan = ns.MaPhongBan,
                          SDT = ns.SDT,
                          Email = ns.Email,
                          NhomMau = ns.NhomMau,
                          ChieuCao = ns.ChieuCao,
                          CanNang = ns.CanNang,
                          SucKhoe = ns.SucKhoe,
                          TinhTrangHonNhan = ns.TinhTrangHonNhan,
                          ThanhPhanGiaDinh = ns.ThanhPhanGiaDinh,
                          DangVien = ns.DangVien,
                          NgayVaoDoan = ns.NgayVaoDoan,
                          NgayVaoDang = ns.NgayVaoDang,
                          TrinhDoVanHoa = ns.TrinhDoVanHoa,
                          TotNghiep = ns.TotNghiep,
                          NganhDaoTao = ns.NganhDaoTao,
                          Loai = ns.Loai,
                          HocVi = ns.HocVi,
                          NgoaiNgu = ns.NgoaiNgu,
                          DanToc = dt.TenDanToc,
                          ChucVu = cv.TenCV,
                          PhongBan = pb.TenPhongBan,

                      };

            dgvTimKiem.DataSource = Lst;
 

        }

        private void txtTimTheoTen_KeyUp(object sender, KeyEventArgs e)
        {
            var Lst = from ns in DB.HoSoNhanSus
                      join dt in DB.DanTocs on ns.MaDanToc equals dt.MaDanToc
                      join cv in DB.ChucVus on ns.MaCV equals cv.MaCV
                      join pb in DB.PhongBans on ns.MaPhongBan equals pb.MaPhongBan
                      where ns.TenNS.Contains(txtTimTheoTen.Text)
                      select new
                      {
                          MaNhanSu = ns.MaNhanSu,
                          TenNS = ns.TenNS,
                          Anh = ns.Anh,
                          GioiTinh = ns.GioiTinh,
                          NgaySinh = ns.NgaySinh,
                          NoiSinh = ns.NoiSinh,
                          QueQuan = ns.QueQuan,
                          HoKhauThuongChu = ns.HoKhauThuongTru,
                          CMND = ns.CMND,
                          NgayCap = ns.NgayCap,
                          NoiCap = ns.NoiCap,
                          QuocTich = ns.QuocTich,
                          TonGiao = ns.TonGiao,
                          MaDanToc = ns.MaDanToc,
                          MaCV = ns.MaCV,
                          MaPhongBan = ns.MaPhongBan,
                          SDT = ns.SDT,
                          Email = ns.Email,
                          NhomMau = ns.NhomMau,
                          ChieuCao = ns.ChieuCao,
                          CanNang = ns.CanNang,
                          SucKhoe = ns.SucKhoe,
                          TinhTrangHonNhan = ns.TinhTrangHonNhan,
                          ThanhPhanGiaDinh = ns.ThanhPhanGiaDinh,
                          DangVien = ns.DangVien,
                          NgayVaoDoan = ns.NgayVaoDoan,
                          NgayVaoDang = ns.NgayVaoDang,
                          TrinhDoVanHoa = ns.TrinhDoVanHoa,
                          TotNghiep = ns.TotNghiep,
                          NganhDaoTao = ns.NganhDaoTao,
                          Loai = ns.Loai,
                          HocVi = ns.HocVi,
                          NgoaiNgu = ns.NgoaiNgu,
                          DanToc = dt.TenDanToc,
                          ChucVu = cv.TenCV,
                          PhongBan = pb.TenPhongBan,

                      };
                      
            dgvTimKiem.DataSource = Lst;
        }
    }
}
