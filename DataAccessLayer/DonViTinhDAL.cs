using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.EF;
namespace DataAccessLayer
{
    public class DonViTinhDAL : BaseDAL
    {
        public string getTenDonViTinhByMaDonViTinh(int maDV)
        {
            return data.DonViTinhs.Where(x => x.MaDonViTinh == maDV).FirstOrDefault().TenDonViTinh;
        }

        public List<string> loadAllNameDonViTinh()
        {
            return data.DonViTinhs.Select(x => x.TenDonViTinh).ToList();
        }
        public int getMaDonViByTenDonVi(string tenDonViTinh)
        {
            return data.DonViTinhs.Where(x => x.TenDonViTinh == tenDonViTinh).Select(a => a.MaDonViTinh).FirstOrDefault();
        }
        /// <summary>
        /// Thêm mới một đơn vị tính
        /// Trả về -1 nếu không add được
        /// trả về 0 nếu đã có đơn vị tính đó rồi
        /// trả về 1 khi add thành công
        /// </summary>
        /// <param name="tenDonViTinh"></param>
        /// <returns></returns>
        public int addNewDonViTinh(string tenDonViTinh)
        {
            DonViTinh temp = data.DonViTinhs.Where(x => x.TenDonViTinh == tenDonViTinh).FirstOrDefault();
            if(temp!=null)
            {
                // đã có rồi, ko được thêm,
                return 0;
            }
            else
            {
                try
                {
                    DonViTinh newDVT = new DonViTinh();
                    newDVT.TenDonViTinh = tenDonViTinh;
                    data.DonViTinhs.Add(newDVT);
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
