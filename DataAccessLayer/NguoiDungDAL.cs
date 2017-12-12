using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.EF;
namespace DataAccessLayer
{
    public class NguoiDungDAL:BaseDAL
    {
        public List<NguoiDung> GetAllNguoiDung()
        {
            return data.NguoiDungs.ToList();
        }
        public NguoiDung getNguoiDungByMaND(string maND)
        {
            return data.NguoiDungs.Where(a => a.MaNguoiDung == maND).FirstOrDefault();
        }

        public string getTenNguoiDungByMaNguoiDung(string maNguoiDung)
        {
            return data.NguoiDungs.Where(x => x.MaNguoiDung == maNguoiDung).FirstOrDefault().TenNguoiDung;
        }

        //Long
        public bool setPathForAvatar(string maND, string path)
        {
            NguoiDung temp = data.NguoiDungs.Where(x => x.MaNguoiDung == maND).FirstOrDefault();
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
    }
}
