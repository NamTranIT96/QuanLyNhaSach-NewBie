using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessEntities.EF;
using System.Windows.Forms;
using System.Data;
using BusinessEntities.Repositories;
using System.ComponentModel;

namespace BusinessLogicLayer
{
    public class HangHoaServices
    {
        private HangHoaDAL hanghoaDAL;
        private DonViTinhDAL donViTinhDAL;
        private NhomHangDAL nhomHangDAL;
        public HangHoaServices()
        {
            try
            {
                hanghoaDAL = new HangHoaDAL();
                donViTinhDAL = new DonViTinhDAL();
                nhomHangDAL = new NhomHangDAL();

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Lấy tất cả tên các hàng hoá, để hổ trợ cho việc tìm kiếm
        /// </summary>
        /// <returns></returns>
        public List<string> getAllNameHangHoa()
        {
            List<string> output = new List<string>();
            List<HangHoa> listHangHoa = hanghoaDAL.getAllHangHoa();
            foreach (HangHoa temp in listHangHoa)
            {
                output.Add(temp.TenHang);
            }
            return output;
        }

        public string getMaHangHoaByTenHangHoa(string tenHang)
        {
            if (hanghoaDAL.getHangHoaByTenHang(tenHang) == null)
            {
                return null;
            }
            else
            {
                return hanghoaDAL.getHangHoaByTenHang(tenHang).MaHangHoa;
            }
        }

        public string getTenHangHoaByMaHangHoa(string maHH)
        {
            return hanghoaDAL.getHangHoaByMaHangHoa(maHH).TenHang;
        }

        public string getDonViTinhByMaHangHoa(string maHH)
        {
            return hanghoaDAL.getHangHoaByMaHangHoa(maHH).DonViTinh1.TenDonViTinh;
        }

        public double getGiaTienHangHoaByMaHangHoa(string maHH)
        {
            return (double)hanghoaDAL.getHangHoaByMaHangHoa(maHH).GiaBan;
        }

        public DataTable getAllHangHoa()
        {
            List<HangHoa> temp = hanghoaDAL.getAllHangHoa();
            List<HangHoaTempRepositories> listHangHoaTemp = new List<HangHoaTempRepositories>();

            foreach(HangHoa x in temp)
            {
                HangHoaTempRepositories hangHoaTempRepo = new HangHoaTempRepositories();
                hangHoaTempRepo.maHangHoa = x.MaHangHoa;
                hangHoaTempRepo.tenHangHoa = x.TenHang;
                hangHoaTempRepo.donViTinh = donViTinhDAL.getTenDonViTinhByMaDonViTinh((int)x.DonViTinh);
                hangHoaTempRepo.giaTien = (double)x.GiaBan;
                listHangHoaTemp.Add(hangHoaTempRepo);
            }

            DataTable output = new DataTable();
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(HangHoaTempRepositories));
            foreach (PropertyDescriptor prop in properties)
            {
                if(prop.Name == "soLuong"||prop.Name == "tongCong")
                {
                    continue;
                }
                output.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (HangHoaTempRepositories hanghoa in listHangHoaTemp)
            {
                DataRow row = output.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    if (prop.Name == "soLuong" || prop.Name == "tongCong")
                        continue;
                    row[prop.Name] = prop.GetValue(hanghoa) ?? DBNull.Value;
                }
                output.Rows.Add(row);
            }
            return output;

        }

        public HangHoa getHangHoaByMaHangHoa(string maHangHoa)
        {
            return hanghoaDAL.getHangHoaByMaHangHoa(maHangHoa);
        }

        public DataTable getAllHangHoaToChinhSuaGia()
        {
            List<HangHoa> temp = hanghoaDAL.getAllHangHoa();
            List<HangHoaBangGiaRepositories> listHangHoaTemp = new List<HangHoaBangGiaRepositories>();

            foreach (HangHoa x in temp)
            {
                HangHoaBangGiaRepositories hangHoaTempRepo = new HangHoaBangGiaRepositories();
                hangHoaTempRepo.MaHangHoa = x.MaHangHoa;
                hangHoaTempRepo.TenHang = x.TenHang;
                hangHoaTempRepo.GiaVon = (double)x.GiaVon;
                hangHoaTempRepo.GiaBan = (double)x.GiaBan;

                listHangHoaTemp.Add(hangHoaTempRepo);
            }

            DataTable output = new DataTable();
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(HangHoaBangGiaRepositories));
            foreach (PropertyDescriptor prop in properties)
            {

                output.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (HangHoaBangGiaRepositories hanghoa in listHangHoaTemp)
            {
                DataRow row = output.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(hanghoa) ?? DBNull.Value;
                }
                output.Rows.Add(row);
            }
            return output;
        }
        public DataTable setFormatDataTable()
        {
            DataTable output = new DataTable();
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(HangHoaTempRepositories));
            foreach (PropertyDescriptor prop in properties)
            {
                output.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            return output;
        }

        public bool setPathForImageHangHoa(string maHangHoa, string path)
        {
            return hanghoaDAL.setPathForImageHangHoa(maHangHoa, path);
        }
        public bool editHangHoa(string maHH,string tenHang, string tenNhomHang, string giaBan, string giavon,
            string tonkho,string tenDonViTinh, string maBarCode)
        {
            try
            {
                HangHoa temp = new HangHoa();
                temp.MaHangHoa = maHH;
                temp.TenHang = tenHang;
                temp.NhomHang = nhomHangDAL.getMaNhomHangByTenNhomHang(tenNhomHang);
                temp.GiaBan = double.Parse(giaBan);
                temp.GiaVon = double.Parse(giavon);
                temp.TonKho = int.Parse(tonkho);
                temp.DonViTinh = donViTinhDAL.getMaDonViByTenDonVi(tenDonViTinh);
                temp.MaBarCode = maBarCode;
                if (hanghoaDAL.editInforHangHoa(temp))
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
    }
}
