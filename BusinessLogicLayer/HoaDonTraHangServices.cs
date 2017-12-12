using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessEntities.Repositories;
using BusinessEntities.EF;
using System.Data;
using System.ComponentModel;

namespace BusinessLogicLayer
{
    public class HoaDonTraHangServices
    {
        private HoaDonTraHangDAL hoaDonTraHangDAL;
        private KhachHangDAL khachHangDAL;
        private NguoiDungDAL nguoiDungDAL;
        public HoaDonTraHangServices()
        {
            hoaDonTraHangDAL = new HoaDonTraHangDAL();
            khachHangDAL = new KhachHangDAL();
            nguoiDungDAL = new NguoiDungDAL();
        }

        public bool addNewHoaDonTraHang(HoaDonTraHang hoaDonTraHang)
        {
            return hoaDonTraHangDAL.addNewHoaDonTraHang(hoaDonTraHang);
        }

        public string getTheNewMaHoaDonTraHang()
        {
            return hoaDonTraHangDAL.getTheNewMaHoaDonTraHang();
        }

        public DataTable getALLHoaDonTraHangConvertToDataTable()
        {
            DataTable output = new DataTable();
            List<HoaDonTraHang> listHDTH = hoaDonTraHangDAL.getAllHoaDonTraHang();
            List<HoaDonTraHangRepositories> listHDBHRepo = new List<HoaDonTraHangRepositories>();

            foreach (HoaDonTraHang x in listHDTH)
            {
                HoaDonTraHangRepositories temp = new HoaDonTraHangRepositories();
                temp.MaHoaDon_TraHang = x.MaHoaDon_TraHang;
                temp.MaHoaDon_BanHang = x.MaHoaDon_TraHang;

                if (x.MaKhachHang != null)
                    temp.TenKhachHang = khachHangDAL.getTenKhachHangByMaKH(x.MaKhachHang);
                else
                    temp.TenKhachHang = "Khách lẻ";
                temp.TenNguoiDung = nguoiDungDAL.getTenNguoiDungByMaNguoiDung(x.MaNguoiDung);
                temp.NgayGio = x.NgayGio;
                temp.ThanhTien = x.ThanhTien;
                temp.PhiTraHang = x.PhiTraHang;
                temp.TienTraLaiKhach = x.TienTraLaiKhach;
                listHDBHRepo.Add(temp);
            }

            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(HoaDonTraHangRepositories));
            foreach (PropertyDescriptor prop in properties)
            {
                output.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (HoaDonTraHangRepositories hoaDonBanHang in listHDBHRepo)
            {
                DataRow row = output.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(hoaDonBanHang) ?? DBNull.Value;
                }
                output.Rows.Add(row);
            }
            return output;
        }
    }
}
