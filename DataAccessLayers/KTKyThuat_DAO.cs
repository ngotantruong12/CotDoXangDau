using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using DataTransferObject;
using System.Data.SqlClient;
using DataAccessLayers;
using System.Data;

namespace DataAccessLayers
{
    public class KTKyThuat_DAO
    {
        static SqlConnection conn;
         public static bool Them_KTKyThuat(KTKyThuat_DTO ktk)
        {
             string query= string.Format(@"INSERT INTO KT_KYTHUAT VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')", ktk.id_kt, ktk.kt_sobo, ktk.kt_dokin, ktk.kt_hoatdongccxs, ktk.kt_cocautungat);
             conn = Dataprovider.moketnoi();
             bool kq = Dataprovider.TruyVanKhongLayDuLieu(query, conn);
             return kq;
        }
        public static bool Edit_KTKyThuat(KTKyThuat_DTO ktk, string ma_ktk)
         {
             string query = string.Format(@"UPDATE KT_KYTHUAT SET KT_SoBo=N'{0}',KT_DoKin=N'{1}',KT_HoatDongCCXS=N'{2}',KT_CoCauTuNgat=N'{3}',id_KT=N'{4}'", ktk.kt_sobo,ktk.kt_dokin,ktk.kt_hoatdongccxs,ktk.kt_cocautungat,ma_ktk);
             conn = Dataprovider.moketnoi();
             bool kq = Dataprovider.TruyVanKhongLayDuLieu(query, conn);
             return kq;
         }
        public static KTKyThuat_DTO Show_KTKyThuat(string ma_dl)
        {
            string query = string.Format(@"SELECT * FROM KT_KYTHUAT WHERE id_KT = N'{0}' ", ma_dl);
            conn = Dataprovider.moketnoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(query, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            KTKyThuat_DTO ktk = new KTKyThuat_DTO();
            ktk.kt_sobo = dt.Rows[0]["KT_SoBo"].ToString();
            ktk.kt_dokin = dt.Rows[0]["KT_DoKin"].ToString();
            ktk.kt_hoatdongccxs = dt.Rows[0]["KT_HoatDongCCXS"].ToString();
            ktk.kt_cocautungat = dt.Rows[0]["KT_CoCauTuNgat"].ToString();

            return ktk;
        }
       

    }
}
