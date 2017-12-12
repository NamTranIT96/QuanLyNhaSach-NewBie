using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using BusinessEntities.EF;
using BusinessEntities.Repositories;
using System.ComponentModel;

namespace BusinessLogicLayer
{
    public class NhaCungCapServices
    {
        private NhaCungCapDAL nhaCungCapDAL;
        private NhomNhaCungCapDAL nhomNhaCungCapDAL;
        public NhaCungCapServices()
        {
            nhaCungCapDAL = new NhaCungCapDAL();
            nhomNhaCungCapDAL = new NhomNhaCungCapDAL();

        }
        public List<string> getAllNameNhaCungCap()
        {
            return nhaCungCapDAL.getAllNameNhaCungCap();
        }
        public DataTable getAllNhaCungCap()
        {
            List<NhaCungCap> temp = nhaCungCapDAL.getAllNhaCungCap();
            List<NhaCungCapRepositories> listNhaCC = new List<NhaCungCapRepositories>();

            foreach (NhaCungCap x in temp)
            {
                NhaCungCapRepositories nhacungCapRepo = new NhaCungCapRepositories();
                nhacungCapRepo.MaNhaCungCap = x.MaNhaCungCap;
                nhacungCapRepo.TenNhaCungCap = x.TenNhaCungCap;
                nhacungCapRepo.DienThoai = x.DienThoai;
                nhacungCapRepo.TenNhomNhaCC = nhomNhaCungCapDAL.getNameNhomByMaNhom((int)x.NhomNhaCC);
                listNhaCC.Add(nhacungCapRepo);
            }

            DataTable output = new DataTable();
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(NhaCungCapRepositories));
            foreach (PropertyDescriptor prop in properties)
            {
                output.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (NhaCungCapRepositories hanghoa in listNhaCC)
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
        public NhaCungCap getNhaCCByMaNhaCungCap(string maNhaCC)
        {
            return nhaCungCapDAL.getNhaCCByMaNhaCungCap(maNhaCC);
        }

        public bool setPathForLogo(string maNhaCC, string path)
        {
            return nhaCungCapDAL.setPathForLogo(maNhaCC, path);
        }
    }
}
