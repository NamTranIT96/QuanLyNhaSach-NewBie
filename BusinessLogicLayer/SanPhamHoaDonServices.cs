using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessEntities.EF;
using System.Data;
using System.ComponentModel;

namespace BusinessLogicLayer
{
    public class SanPhamHoaDonServices
    {
        SanPhamHoaDonDAL sanPhamHoaDonDAL;
        public SanPhamHoaDonServices()
        {
            sanPhamHoaDonDAL = new SanPhamHoaDonDAL();
        }

        public DataTable getSanPhamHoaDonByMaHoaDon(string maHoaDon)
        {
            DataTable output = new DataTable();
            List<SanPhamHoaDon> listSanPhamHoaDon = sanPhamHoaDonDAL.getSanPhamHoaDonByMaHoaDon(maHoaDon);

            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(SanPhamHoaDon));
            foreach (PropertyDescriptor prop in properties)
            {
                output.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (SanPhamHoaDon sanPhamHoaDon in listSanPhamHoaDon)
            {
                DataRow row = output.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(sanPhamHoaDon) ?? DBNull.Value;
                }
                output.Rows.Add(row);
            }
            return output;
        }

    }
}
