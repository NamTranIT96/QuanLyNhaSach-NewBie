using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.EF;
using System.Data;
using System.ComponentModel;
using BusinessEntities.Repositories;
namespace DataAccessLayer
{
    public class KhachHangDAL : BaseDAL
    {
        public List<KhachHang> getAllKhachHang()
        {
            return data.KhachHangs.ToList();
        }

        public DataTable getAllKhachHangToDataTable()
        {
            List<KhachHangRepositories> listKhachHangRepo = new List<KhachHangRepositories>();
            List<KhachHang> listKH = getAllKhachHang();

            foreach (KhachHang x in listKH)
            {
                KhachHangRepositories temp = new KhachHangRepositories();
                temp.MaKhachHang = x.MaKhachHang;
                temp.TenKhachHang = x.TenKhachHang;
                temp.NgaySinh = x.NgaySinh;
                temp.KhuVuc = x.KhuVuc;
                temp.DienThoai = x.DienThoai;
                temp.TichDiem = x.TichDiem;
                listKhachHangRepo.Add(temp);
            }


            DataTable output = new DataTable();
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(KhachHangRepositories));
            foreach (PropertyDescriptor prop in properties)
            {
                output.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (KhachHangRepositories khachhang in listKhachHangRepo)
            {
                DataRow row = output.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(khachhang) ?? DBNull.Value;
                }
                output.Rows.Add(row);
            }
            return output;
        }
        /// <summary>
        /// Lấy thông tin phần trăm tích điểm của khách hàng
        /// </summary>
        /// <param name="maKH"></param>
        /// <returns></returns>
        public double getSoPhanTramTichDiem(string maKH)
        {
            KhachHang output = data.KhachHangs.Where(x => x.MaKhachHang == maKH).FirstOrDefault();
            return (double)output.TichDiem;
        }

        /// <summary>
        ///  lấy tên khách hàng thông qua mã khách hàng
        /// </summary>
        /// <param name="maKH"></param>
        /// <returns></returns>
        public string getTenKhachHangByMaKH(string maKH)
        {
            return data.KhachHangs.Where(x => x.MaKhachHang == maKH).FirstOrDefault().TenKhachHang;
        }

        public bool checkKhachHangCoTonTaiTheoTen(string tenKhachHang)
        {
            KhachHang temp = data.KhachHangs.Where(x => x.TenKhachHang.Contains(tenKhachHang)).FirstOrDefault();
            if (temp != null)
                return true;
            else
                return false;
        }

        public KhachHang getKhachHangByMaKhachHang(string maKhachHang)
        {
            return data.KhachHangs.Where(x => x.MaKhachHang == maKhachHang).FirstOrDefault();
        }

        public bool setPathForAvatar(string maKhachHang, string path)
        {
            KhachHang temp = data.KhachHangs.Where(x => x.MaKhachHang == maKhachHang).FirstOrDefault();
            if (temp != null)
            {
                try
                {
                    temp.AnhDaiDien = path;
                    data.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
        public bool editInforKhachHang(KhachHang khachHang)
        {
            KhachHang temp = data.KhachHangs.Where(x => x.MaKhachHang == khachHang.MaKhachHang).FirstOrDefault();
            if (temp != null)
            {
                temp.MaKhachHang = khachHang.MaKhachHang;
                temp.TenKhachHang = khachHang.TenKhachHang;
                temp.DienThoai = khachHang.DienThoai;
                temp.DiaChi = khachHang.DiaChi;
                temp.KhuVuc = khachHang.KhuVuc;
                temp.PhuongXa = khachHang.PhuongXa;
                temp.MaSoThue = khachHang.MaSoThue;
                temp.NgaySinh = khachHang.NgaySinh;
                temp.GioiTinh = khachHang.GioiTinh;
                temp.Email = khachHang.Email;
                temp.Nhom = khachHang.Nhom;
                temp.Ghichu = khachHang.Ghichu;

                try
                {
                    data.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        public string getDiaChiKhachHangByMaKH(string maKH)
        {
            return data.KhachHangs.Where(x => x.MaKhachHang == maKH).FirstOrDefault().DiaChi;
        }
        public string getDienThoaiKhachHangByMaKH(string maKH)
        {
            return data.KhachHangs.Where(x => x.MaKhachHang == maKH).FirstOrDefault().DienThoai;
        }
    }
}
