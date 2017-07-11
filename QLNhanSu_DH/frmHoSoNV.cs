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
    public partial class frmHoSoNV : Form
    {
        public frmHoSoNV()
        {
            InitializeComponent();
          
            
        }
        NhanSuBUS nhansubus = new NhanSuBUS();
        DanTocBUS dantocbus = new DanTocBUS();
        ChucVuBUS chucvubus = new ChucVuBUS();
        PhongBanBUS phongbanbus = new PhongBanBUS();

        private void frmHoSoNV_Load(object sender, EventArgs e)
        {
            dgvNhanSu.DataSource = nhansubus.viewNhanSu();

            dgvNhanSu.Columns["Anh"].Visible = false;
            dgvNhanSu.Columns["MaDanToc"].Visible = false;
            dgvNhanSu.Columns["MaCV"].Visible = false;
            dgvNhanSu.Columns["MaPhongBan"].Visible = false;

            dgvNhanSu.Columns["MaNhanSu"].HeaderText = "Mã Nhân Sự";
            dgvNhanSu.Columns["TenNS"].HeaderText = "Họ Tên";
            dgvNhanSu.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgvNhanSu.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvNhanSu.Columns["NoiSinh"].HeaderText = "Nơi Sinh";
            dgvNhanSu.Columns["QueQuan"].HeaderText = "Quê Quán";
            dgvNhanSu.Columns["HoKhauThuongChu"].HeaderText = "Hộ Khẩu";
            dgvNhanSu.Columns["CMND"].HeaderText = "CMND";
            dgvNhanSu.Columns["NoiCap"].HeaderText = "Nơi Cấp";
            dgvNhanSu.Columns["NgayCap"].HeaderText = "Ngày Cấp";
            dgvNhanSu.Columns["QuocTich"].HeaderText = "Quốc Tịch";
            dgvNhanSu.Columns["TonGiao"].HeaderText = "Tôn Giáo";
            dgvNhanSu.Columns["SDT"].HeaderText = "ĐT Liên Hệ";
            dgvNhanSu.Columns["Email"].HeaderText = "Email";
            dgvNhanSu.Columns["NhomMau"].HeaderText = "Nhóm Máu";
            dgvNhanSu.Columns["ChieuCao"].HeaderText = "Chiều Cao";
            dgvNhanSu.Columns["CanNang"].HeaderText = "Cân Nặng";
            dgvNhanSu.Columns["SucKhoe"].HeaderText = "Sức Khỏe";
            dgvNhanSu.Columns["TinhTrangHonNhan"].HeaderText = "Tình Trạng Hôn Nhân";
            dgvNhanSu.Columns["ThanhPhanGiaDinh"].HeaderText = "Thành Phần Gia Đình";
            dgvNhanSu.Columns["DangVien"].HeaderText = "Đảng Viên";
            dgvNhanSu.Columns["NgayVaoDoan"].HeaderText = "Ngày Vào Đoàn";
            dgvNhanSu.Columns["NgayVaoDang"].HeaderText = "Ngày Vào Đảng";
            dgvNhanSu.Columns["TrinhDoVanHoa"].HeaderText = "Trình Độ Văn Hóa";
            dgvNhanSu.Columns["TotNghiep"].HeaderText = "Tốt Nghiệp";
            dgvNhanSu.Columns["NganhDaoTao"].HeaderText = "Ngành Đào Tạo";
            dgvNhanSu.Columns["Loai"].HeaderText = "Xếp Loại";
            dgvNhanSu.Columns["HocVi"].HeaderText = "Học Vị";
            dgvNhanSu.Columns["NgoaiNgu"].HeaderText = "Trình Độ Ngoại Ngữ";
            dgvNhanSu.Columns["DanToc"].HeaderText = "Dân Tộc";
            dgvNhanSu.Columns["ChucVu"].HeaderText = "Chức Vụ";
            dgvNhanSu.Columns["PhongBan"].HeaderText = "Phòng Ban";


            cbChucVu.DataSource = chucvubus.viewChucVu();
            cbChucVu.DisplayMember = "TenCV";
            cbChucVu.ValueMember = "MaCV";

            cbDanToc.DataSource = dantocbus.viewDanToc();
            cbDanToc.DisplayMember = "TenDanToc";
            cbDanToc.ValueMember = "MaDanToc";

            cbPhongBan.DataSource = phongbanbus.viewPhongBan();
            cbPhongBan.DisplayMember = "TenPhongBan";
            cbPhongBan.ValueMember = "MaPhongBan";

            btSua.Enabled = false;
            btXoa.Enabled = false;
            btLuu.Enabled = false;
           
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void txtNoiCap_TextChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtTonGiao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void cbDanToc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void bntLuu_Click(object sender, EventArgs e)
        {
            string gioitinh = "";
            if (rbNam.Checked == true)
                gioitinh = "Nam";
            else
                gioitinh = "Nữ";

            string tthonnhan = "";
            if (rbDaKetHon.Checked == true)
                tthonnhan = "Đã kết hôn";
            else
                tthonnhan = "Chưa kết hôn";

            string dangvien = "";
            if (rbLaDangVien.Checked == true)
                dangvien = "Là Đảng viên";
            else
                dangvien = "Không";

            nhansubus.SuaNhanSu(txtMaNhanSu.Text, txtTenNhanSu.Text,gioitinh, dtNgaySinh.Value, txtNoiSinh.Text, txtQueQuan.Text, txtHoKhau.Text, int.Parse(txtCMND.Text), dtNgayCap.Value, txtNoiCap.Text, txtQuocTich.Text, txtTonGiao.Text, cbDanToc.SelectedValue.ToString(), cbChucVu.SelectedValue.ToString(), cbPhongBan.SelectedValue.ToString(), int.Parse(txtSDT.Text), txtEmail.Text, txtNhomMau.Text, txtChieuCao.Text, txtCanNang.Text, txtSucKhoe.Text, tthonnhan, txtTPGiaDinh.Text, dangvien, dtNgayVaoDoan.Value, dtNgayVaoDang.Value, txtTDVanHoa.Text, txtTotNghiep.Text, txtNganhDaoTao.Text, txtXepLoai.Text, txtHocVi.Text, txtNgoaiNgu.Text, imgUrl);
            dgvNhanSu.DataSource = nhansubus.viewNhanSu();
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {

            txtMaNhanSu.Enabled = true;
            txtTenNhanSu.Enabled = true;
            rbNam.Enabled = true;
            rbNu.Enabled = true;
            dtNgaySinh.Enabled = true;
            txtCMND.Enabled = true;
            txtNoiSinh.Enabled = true;
            txtQueQuan.Enabled = true;
            txtHoKhau.Enabled = true;
            dtNgayCap.Enabled = true;
            txtNoiCap.Enabled = true;
            txtQuocTich.Enabled = true;
            txtTonGiao.Enabled = true;
            cbDanToc.Enabled = true;
            cbChucVu.Enabled = true;
            cbPhongBan.Enabled = true;
            txtSDT.Enabled = true;
            txtEmail.Enabled = true;
            txtNhomMau.Enabled = true;
            txtChieuCao.Enabled = true;
            txtCanNang.Enabled = true;
            txtSucKhoe.Enabled = true;
            txtTPGiaDinh.Enabled = true;
            dtNgayVaoDoan.Enabled = true;
            dtNgayVaoDang.Enabled = true;
            txtTDVanHoa.Enabled = true;
            txtTotNghiep.Enabled = true;
            txtNganhDaoTao.Enabled = true;
            txtXepLoai.Enabled = true;
            txtHocVi.Enabled = true;
            txtNgoaiNgu.Enabled = true;

            txtMaNhanSu.Text = "";
            txtTenNhanSu.Text = "";
     
            txtCMND.Text = "";
            txtNoiSinh.Text = "";
            txtQueQuan.Text = "";
            txtHoKhau.Text = "";
            
            txtNoiCap.Text = "";
            txtQuocTich.Text = "";
            txtTonGiao.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtNhomMau.Text = "";
            txtChieuCao.Text = "";
            txtCanNang.Text = "";
            txtSucKhoe.Text = "";
            txtTPGiaDinh.Text = "";
            
            txtTDVanHoa.Text = "";
            txtTotNghiep.Text = "";
            txtNganhDaoTao.Text = "";
            txtXepLoai.Text = "";
            txtHocVi.Text = "";
            txtNgoaiNgu.Text = "";

            btSua.Enabled = false;
            btXoa.Enabled = false;
            btLuu.Enabled = false;
            btThem.Enabled = true;
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            if (txtMaNhanSu.Text == "" || txtTenNhanSu.Text == "" || txtHoKhau.Text == "" || txtCMND.Text == "")
                MessageBox.Show("Bạn bỏ qua quá thông tin quan trọng. Hãy nhập lại đầy đủ!", "Thông báo");
            else
            {
                string gioitinh = "";
                if (rbNam.Checked == true)
                    gioitinh = "Nam";
                else
                    gioitinh = "Nữ";

                string tthonnhan = "";
                if (rbDaKetHon.Checked == true)
                    tthonnhan = "Đã kết hôn";
                else
                    tthonnhan = "Chưa kết hôn";
                
                string dangvien = "";
                if (rbLaDangVien.Checked == true)
                    dangvien = "Là Đảng viên";
                else
                    dangvien = "Không";

                //string hinhanh;
                //hinhanh = picBoxAnh.ImageLocation();
                //string tenhinh;

                //tenhinh = ofd.FileName();
                //if (picBoxAnh.Image == null)
                //{
                //    hinhanh = null;

                //}
                //else
                //{
                //    picBoxAnh.Image.Save(Application.StartupPath + "/image/" + tenhinh + ".jpg");
                //    hinhanh = "image/" + tenhinh + ".jpg";
                //}

                if (nhansubus.KTTonTai(txtMaNhanSu.Text) == true)
                    MessageBox.Show("Ma NS đã tồn tại !");
                else
                {
                    nhansubus.ThemHoSo(txtMaNhanSu.Text, txtTenNhanSu.Text, gioitinh, dtNgaySinh.Value, txtNoiSinh.Text, txtQueQuan.Text, txtHoKhau.Text, int.Parse(txtCMND.Text), dtNgayCap.Value, txtNoiCap.Text, txtQuocTich.Text, txtTonGiao.Text, cbDanToc.SelectedValue.ToString(), cbChucVu.SelectedValue.ToString(), cbPhongBan.SelectedValue.ToString(), int.Parse(txtSDT.Text), txtEmail.Text, txtNhomMau.Text, txtChieuCao.Text, txtCanNang.Text, txtSucKhoe.Text, tthonnhan, txtTPGiaDinh.Text, dangvien,dtNgayVaoDoan.Value, dtNgayVaoDang.Value, txtTDVanHoa.Text, txtTotNghiep.Text, txtNganhDaoTao.Text, txtXepLoai.Text, txtHocVi.Text, txtNgoaiNgu.Text, imgUrl);
                    dgvNhanSu.DataSource = nhansubus.viewNhanSu();
                }
            }
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            btLuu.Enabled = true;

            txtMaNhanSu.Enabled = false;
            txtTenNhanSu.Enabled = true;
            rbNam.Enabled = true;
            rbNu.Enabled = true;
            dtNgaySinh.Enabled = true;
            txtCMND.Enabled = true;
            txtNoiSinh.Enabled = true;
            txtQueQuan.Enabled = true;
            txtHoKhau.Enabled = true;
            dtNgayCap.Enabled = true;
            txtNoiCap.Enabled = true;
            txtQuocTich.Enabled = true;
            txtTonGiao.Enabled = true;
            cbDanToc.Enabled = true;
            cbChucVu.Enabled = true;
            cbPhongBan.Enabled = true;
            txtSDT.Enabled = true;
            txtEmail.Enabled = true;
            txtNhomMau.Enabled = true;
            txtChieuCao.Enabled = true;
            txtCanNang.Enabled = true;
            txtSucKhoe.Enabled = true;
            txtTPGiaDinh.Enabled = true;
            dtNgayVaoDoan.Enabled = true;
            dtNgayVaoDang.Enabled = true;
            txtTDVanHoa.Enabled = true;
            txtTotNghiep.Enabled = true;
            txtNganhDaoTao.Enabled = true;
            txtXepLoai.Enabled = true;
            txtHocVi.Enabled = true;
            txtNgoaiNgu.Enabled = true;

        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            nhansubus.XoaNhanSu(txtMaNhanSu.Text);
            dgvNhanSu.DataSource = nhansubus.viewNhanSu();
        }

        private void dgvNhanSu_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvNhanSu.SelectedRows[0];
            txtMaNhanSu.Text = dr.Cells["MaNhanSu"].Value.ToString();
            txtTenNhanSu.Text = dr.Cells["TenNS"].Value.ToString();
            dtNgaySinh.Text = dr.Cells["NgaySinh"].Value.ToString();
            dtNgayVaoDoan.Text = dr.Cells["NgayVaoDoan"].Value.ToString();
            dtNgayVaoDang.Text = dr.Cells["NgayVaoDang"].Value.ToString();
            txtCMND.Text = dr.Cells["CMND"].Value.ToString();
            dtNgayCap.Text = dr.Cells["NgayCap"].Value.ToString();
            txtNoiSinh.Text = dr.Cells["NoiSinh"].Value.ToString();
            txtQueQuan.Text = dr.Cells["QueQuan"].Value.ToString();
            txtHoKhau.Text = dr.Cells["HoKhauThuongChu"].Value.ToString();
            dtNgayCap.Text = dr.Cells["NgayCap"].Value.ToString();
            txtNoiCap.Text = dr.Cells["NoiCap"].Value.ToString();
            txtQuocTich.Text = dr.Cells["QuocTich"].Value.ToString();
            txtTonGiao.Text = dr.Cells["TonGiao"].Value.ToString();
            cbDanToc.Text = dr.Cells["DanToc"].Value.ToString();
            cbChucVu.Text = dr.Cells["ChucVu"].Value.ToString();
            cbPhongBan.Text = dr.Cells["PhongBan"].Value.ToString();
            txtSDT.Text = dr.Cells["SDT"].Value.ToString();
            txtEmail.Text = dr.Cells["Email"].Value.ToString();
            txtNhomMau.Text = dr.Cells["NhomMau"].Value.ToString();
            txtChieuCao.Text = dr.Cells["ChieuCao"].Value.ToString();
            txtCanNang.Text = dr.Cells["CanNang"].Value.ToString();
            txtSucKhoe.Text = dr.Cells["SucKhoe"].Value.ToString();
            txtTPGiaDinh.Text = dr.Cells["ThanhPhanGiaDinh"].Value.ToString();           
            txtTDVanHoa.Text = dr.Cells["TrinhDoVanHoa"].Value.ToString();
            txtTotNghiep.Text = dr.Cells["TotNghiep"].Value.ToString();
            txtNganhDaoTao.Text = dr.Cells["NganhDaoTao"].Value.ToString();
            txtXepLoai.Text = dr.Cells["Loai"].Value.ToString();
            txtHocVi.Text = dr.Cells["HocVi"].Value.ToString();
            txtNgoaiNgu.Text = dr.Cells["NgoaiNgu"].Value.ToString();

            var value = dr.Cells["Anh"].Value;
            if (value != null)
            {
                if (System.IO.File.Exists(dr.Cells["Anh"].Value.ToString()))
                    picBoxAnh.Image = new Bitmap(dr.Cells["Anh"].Value.ToString());
                else
                    picBoxAnh.Image = null;
            }
            else picBoxAnh.Image = null;
            

            if (dr.Cells["GioiTinh"].Value.ToString() == "Nam")
                rbNam.Checked = true;
            else
                rbNu.Checked = true;

            if (dr.Cells["TinhTrangHonNhan"].Value.ToString() == "Đã kết hôn")
                rbDaKetHon.Checked = true;
            else
                rbChuaKethon.Checked = true;

            if (dr.Cells["DangVien"].Value.ToString() == "Là Đảng viên")
                rbLaDangVien.Checked = true;
            else
                rbKhong.Checked = true;



            btSua.Enabled = true;
            btXoa.Enabled = true;
            btThem.Enabled = false;
        }
        OpenFileDialog ofd = new OpenFileDialog();
        string imgUrl { get; set; }
        private void btAnh_Click(object sender, EventArgs e)
        {
            ofd.Title = "Open Image";
            ofd.InitialDirectory = @"C:\Users\thuan\Documents\Visual Studio 2013\Projects\QLNhanSu_DH\Images";
            ofd.Filter = "Image|*.jpg; *.jpeg;*.png;*.gif;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string hinhanh = ofd.FileName.Substring(ofd.FileName.LastIndexOf("\\") + 1, ofd.FileName.Length - ofd.FileName.LastIndexOf("\\") - 1);
                picBoxAnh.Image = new Bitmap(ofd.FileName);
                imgUrl = ofd.FileName;
            }

        }

        private void dtNgayVaoDang_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                dtNgayVaoDang.Format = DateTimePickerFormat.Custom;
                dtNgayVaoDang.CustomFormat = " ";
            }
        }

        private void dtNgayVaoDang_ValueChanged(object sender, EventArgs e)
        {
            dtNgayVaoDang.CustomFormat = "";
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
