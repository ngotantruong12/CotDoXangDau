using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayers;
using DataTransferObject;
using System.Data;
using System.Data.SqlClient;
using DataTransferObject;



namespace DataAccessLayers
{
  
    public class KTNgoai_DAO
    {
        static SqlConnection conn;

        public static bool Them_KTNgoai(KTNgoai_DTO ktn)
        {
            string query = string.Format(@"INSERT INTO KT_NGOAI VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')", ktn.id_bn, ktn.KT_nhanmac, ktn.KT_bophanchinh, ktn.KT_kinh, ktn.KT_ongcs);
            conn = Dataprovider.moketnoi();
            bool kq = Dataprovider.TruyVanKhongLayDuLieu(query, conn);
            return kq;
        }
        public static bool Edit_KTNgoai(KTNgoai_DTO ktn,   String ma_ktn)
        {
            string query = string.Format(@"UPDATE KT_NGOAI SET KT_NhanMac= N'{0}',KT_BoPhanChinh=N'{1}',KT_Kinh=N'{2}',KT_OngCS=N'{3}'WHERE id_BN = N'{4}'", ktn.KT_nhanmac, ktn.KT_bophanchinh, ktn.KT_kinh, ktn.KT_ongcs,ma_ktn);
            conn = Dataprovider.moketnoi();
            bool kq = Dataprovider.TruyVanKhongLayDuLieu(query, conn);
            return kq;
        }
        public static KTNgoai_DTO Show_KTNgoai(string ma_dl)
        {
            string query = string.Format(@"SELECT * FROM KT_NGOAI WHERE id_BN = N'{0}' ", ma_dl);
            conn = Dataprovider.moketnoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(query, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            KTNgoai_DTO ktn = new KTNgoai_DTO();
            ktn.KT_nhanmac = dt.Rows[0]["KT_NhanMac"].ToString();
            ktn.KT_bophanchinh = dt.Rows[0]["KT_BoPhanChinh"].ToString();
            ktn.KT_kinh = dt.Rows[0]["KT_Kinh"].ToString();
            ktn.KT_ongcs = dt.Rows[0]["KT_OngCS"].ToString();

            return ktn;
        }
       


    }
}
