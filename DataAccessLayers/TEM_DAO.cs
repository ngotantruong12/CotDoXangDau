using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayers
{
    public class TEM_DAO
    {
        static SqlConnection con;
        public static bool TimTEM(int tem)
        {
            string sTruyVan = string.Format(@"select * from KT_TEM where id_tem = N'{0}'", tem);
            con = Dataprovider.moketnoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool THEM_TEM( int tem)
        {
            string query = string.Format(@"INSERT INTO KT_TEM VALUES (N'{0}')", tem);
            con = Dataprovider.moketnoi();
            bool kq = Dataprovider.TruyVanKhongLayDuLieu(query, con);
            return kq;
        }
    }
}
