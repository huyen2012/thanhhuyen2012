using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLCLBSACH
{
    class KiemTraDangNhap
    {
        public int CheckLogin(string username, string password, string quyen)
        {
            AccessData acc = new AccessData();
            SqlDataReader reader = acc.ExecuteReader("SELECT MATV, MATKHAU, MAQUYENDN FROM THANHVIEN");
            while (reader.Read())
            {
                if (reader[0].ToString() == username && reader[1].ToString() == password && reader[2].ToString() == quyen)
                {
                    return 1;
                }
            }
            return 0;
        }

    }
}
