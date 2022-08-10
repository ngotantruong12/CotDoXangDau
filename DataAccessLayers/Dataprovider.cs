using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayers
{
    public class Dataprovider
    {
        public static SqlConnection moketnoi()
        {
            string str = @"Data Source=NGOTANTRUONG-PC\SQLEXPRESS;Initial Catalog=TRUBOM;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            return conn;
        }
        public static DataTable TruyVanLayDuLieu(string truyvan, SqlConnection ketnoi)
        {
            SqlDataAdapter da = new SqlDataAdapter(truyvan, ketnoi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static bool TruyVanKhongLayDuLieu(string truyvan, SqlConnection ketnoi)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(truyvan, ketnoi);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
