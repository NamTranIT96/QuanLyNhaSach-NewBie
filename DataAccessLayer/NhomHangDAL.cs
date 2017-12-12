using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.EF;
namespace DataAccessLayer
{
    public class NhomHangDAL : BaseDAL
    {
        public string getNameNhomHangByMaNhomHang(int maNhomHang)
        {
            return data.NhomHangs.Where(x => x.MaNhomHang == maNhomHang).FirstOrDefault().TenNhomHang;
        }

        public List<string> loadAllNameNhomHang()
        {
            return data.NhomHangs.Select(x => x.TenNhomHang).ToList();
        }
        public int getMaNhomHangByTenNhomHang(string tenNhomHang)
        {
            return data.NhomHangs.Where(x => x.TenNhomHang == tenNhomHang).Select(a => a.MaNhomHang).FirstOrDefault();
        }

        /// <summary>
        ///         /// Thêm mới một nhóm hàng
        /// Trả về -1 nếu không add được
        /// trả về 0 nếu đã có đơn vị tính đó rồi
        /// trả về 1 khi add thành công
        /// </summary>
        /// <param name="tenNhomHang"></param>
        /// <returns></returns>
        public int addNewNhomHang(string tenNhomHang)
        {
            NhomHang temp = data.NhomHangs.Where(x => x.TenNhomHang == tenNhomHang).FirstOrDefault();
            if (temp != null)
            {
                // đã có rồi, ko được thêm,
                return 0;
            }
            else
            {
                try
                {
                    NhomHang newNH = new NhomHang();
                    newNH.TenNhomHang = tenNhomHang;
                    data.NhomHangs.Add(newNH);
                    data.SaveChanges();
                    return 1;
                }
                catch
                {
                    return -1;
                }
            }
        }
    }
}
