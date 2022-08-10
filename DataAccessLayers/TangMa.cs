using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DataAccessLayers
{
    public class TangMa
    {
        static SqlConnection conn;
        public static string matutang()
        {
            string query = @"SELECT id_CDXD FROM THONGTIN_CDXD ";
            conn = Dataprovider.moketnoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(query, conn);
            string s = "";
            // string s = DateTime.Now.Year.ToString();
            if (dt.Rows.Count <= 0)
            {
                s = DateTime.Now.Year.ToString() + "00001";

            }
            else
            {
                // int k;
                s = "2021";
                int k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(4, 5));
                k = k + 1;
                if (k < 10)
                    s = s + "0000";
                else if (k < 100)
                    s = s + "000";
                else if (k < 1000)
                    s = s + "00";
                else if (k < 1000)
                    s = s + "0";

                s = s + k.ToString();
            }
            return s;
        }
    }
}
