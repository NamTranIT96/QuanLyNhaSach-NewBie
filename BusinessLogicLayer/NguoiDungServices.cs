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
    public class NguoiDungServices
    {
        private NguoiDungDAL nguoiDungDAL;

        private string maNDDangSuDung = null;

        public NguoiDungServices()
        {
            try
            {
                nguoiDungDAL = new NguoiDungDAL();
            }
            catch(Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Kiểm tra đăng nhập: trả về id vai trò khi đúng username, password
        /// Trả về 0 khi đúng username, sai pass
        /// Trả về -1 khi không có username nào đúng.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public int Login(string username, string password)
        {
            if(nguoiDungDAL == null)
            {
                throw new Exception("Can not get database");
            }
            List<NguoiDung> getAllNguoiDung = nguoiDungDAL.GetAllNguoiDung();
            foreach(NguoiDung nd in getAllNguoiDung)
            {
                if(nd.TenDangNhap == username)
                {
                    if (nd.MatKhau == password)
                    {
                        maNDDangSuDung = nd.MaNguoiDung;
                        return nd.VaiTro.Value;
                    }
                    else
                        return 0;
                }
            }
            return -1;
        }
        public string getMaNDangDung()
        {
            return maNDDangSuDung;
        }
        //Long
        public NguoiDung getMaNDangDungByMaND(string maND)
        {
            return nguoiDungDAL.getNguoiDungByMaND(maND);
        }
        //Long
        public bool setPathForAvatar(string maND, string path)
        {
            return nguoiDungDAL.setPathForAvatar(maND, path);
        }
        public string getTenNguoiDungBymaND(string maND)
        {
            NguoiDung output = nguoiDungDAL.getNguoiDungByMaND(maND);
            return output.TenNguoiDung;
        }
        public string getVaiTroNguoiDungBymaND(string maND)
        {
            NguoiDung output = nguoiDungDAL.getNguoiDungByMaND(maND);
            return output.VaiTro1.TenVaiTro;
        }


    }
}
