using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessEntities.EF;
using System.Data;

namespace BusinessLogicLayer
{
    public class KhachHangServices
    {
        private KhachHangDAL khachHangDAL;
        private NhomKhachHangDAL nhomKhachHangDAL;
        public KhachHangServices()
        {
            try
            {
                khachHangDAL = new KhachHangDAL();
                nhomKhachHangDAL = new NhomKhachHangDAL();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<string> getAllNameKhachHang()
        {
            List<string> output = new List<string>();
            List<KhachHang> listKhachHang = khachHangDAL.getAllKhachHang();
            foreach (KhachHang temp in listKhachHang)
            {
                output.Add(temp.TenKhachHang);
            }
            return output;
        }
        /// <summary>
        /// Lấy tất cả khách hàng theo dạng datatable
        /// </summary>
        /// <returns></returns>
        public DataTable getAllKhachHang()
        {
            return khachHangDAL.getAllKhachHangToDataTable();
        }

        public double getSoPhanTramTichDiem(string maKH)
        {
            return khachHangDAL.getSoPhanTramTichDiem(maKH);
        }
        public string getTenKhachHangByMaKH(string maKH)
        {
            return khachHangDAL.getTenKhachHangByMaKH(maKH);
        }

        public bool checkKhachHangCoTonTaiTheoTen(string tenKhachHang)
        {
            return khachHangDAL.checkKhachHangCoTonTaiTheoTen(tenKhachHang);
        }

        public KhachHang getKhachHangByMaKhachHang(string maKhachHang)
        {
            return khachHangDAL.getKhachHangByMaKhachHang(maKhachHang);
        }

        public bool setPathForAvatar(string maKhachHang, string path)
        {
            return khachHangDAL.setPathForAvatar(maKhachHang, path);
        }
        public bool editKhachHang(string maKH, string tenKH, string dienthoai, string diachi, string khuvuc,
       string phuongxa, string masothue, string ngaysinh, string gioitinh, string email, string nhom,
       string ghichu)
        {
            try
            {
                KhachHang temp = new KhachHang();
                temp.MaKhachHang = maKH;
                temp.TenKhachHang = tenKH;
                temp.DienThoai = dienthoai;
                temp.DiaChi = diachi;
                temp.KhuVuc = khuvuc;
                temp.PhuongXa = phuongxa;
                temp.MaSoThue = masothue;
                temp.NgaySinh = DateTime.Parse(ngaysinh);
                temp.GioiTinh = gioitinh;
                temp.Email = email;
                temp.Nhom = nhomKhachHangDAL.getMaNhomKHByTenNhomKH(nhom);
                temp.Ghichu = ghichu;


                if (khachHangDAL.editInforKhachHang(temp))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

        }
        public string getDiaChiKhachHangByMaKH(string maKH)
        {
            return khachHangDAL.getDiaChiKhachHangByMaKH(maKH);
        }
        public string getDienThoaiKhachHangByMaKH(string maKH)
        {
            return khachHangDAL.getDienThoaiKhachHangByMaKH(maKH);
        }
    }
}
