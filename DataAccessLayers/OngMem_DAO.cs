using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayers;
using DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayers
{
    public class OngMem_DAO
    {
        static SqlConnection conn;
        public static bool Them_ongmem(OngMem_In_DTO om)
        {
            string query = string.Format(@"INSERT INTO KT_OM_CCI VALUES(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}',N'{11}',N'{12}',N'{13}',N'{14}',N'{15}')", om.ID_OM_CCI, om.SO_OD, om.KL_SO_OD, om.KT_CCI, om.VFD_1_OD, om.PFD_1_OD, om.LuuLuong_GN_1, om.Tien_TT_1, om.Ket_Luan_1_OD, om.VFD_2_OD, om.PFD_2_OD, om.LuuLuong_GN_2, om.Tien_TT_2, om.Ket_Luan_2_OD, om.KT_CNI, om.KT_ND);
            conn = Dataprovider.moketnoi();
            bool kq = Dataprovider.TruyVanKhongLayDuLieu(query, conn);
            return kq;
        }
        public static bool Edit_ongmem(OngMem_In_DTO om , string ma_om)
        {
            string query = string.Format(@"UPDATE KT_OM_CCI SET So_OD= N'{0}',KL_SoOD= N'{1}',KT_CCI= N'{2}',VFD_1 =N'{3}',PFD_1= N'{4}',Luong_GN_1 = N'{5}',Tien_TT_1 = N'{6}',KL_1= N'{7}',VFD_2= N'{8}',PFD_2= N'{9}',Luong_GN_2 = N'{10}',Tien_TT_2 = N'{11}',KL_2 = N'{12}',KT_CNI = N'{13}',KT_ND = N'{14}' WHERE id_OM_CCI=  N'{15}'",  om.SO_OD, om.KL_SO_OD, om.KT_CCI, om.VFD_1_OD, om.PFD_1_OD, om.LuuLuong_GN_1, om.Tien_TT_1, om.Ket_Luan_1_OD, om.VFD_2_OD, om.PFD_2_OD, om.LuuLuong_GN_2, om.Tien_TT_2, om.Ket_Luan_2_OD, om.KT_CNI, om.KT_ND, ma_om);
            conn = Dataprovider.moketnoi();
            bool kq = Dataprovider.TruyVanKhongLayDuLieu(query, conn);
            return kq;
        }
        public static OngMem_In_DTO Show_ongmem( string ma_om)
        {
            string query = string.Format(@"SELECT * FROM  KT_OM_CCI WHERE id_OM_CCI=  N'{0}' ", ma_om);
            conn = Dataprovider.moketnoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(query, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            OngMem_In_DTO om = new OngMem_In_DTO();
            om.SO_OD = float.Parse(dt.Rows[0]["So_OD"].ToString());
            om.KL_SO_OD = dt.Rows[0]["KL_SoOD"].ToString();
            om.KT_CCI = dt.Rows[0]["KT_CCI"].ToString();
            om.VFD_1_OD = float.Parse(dt.Rows[0]["VFD_1"].ToString());
            om.PFD_1_OD = float.Parse(dt.Rows[0]["PFD_1"].ToString());
            om.LuuLuong_GN_1 = float.Parse(dt.Rows[0]["Luong_GN_1"].ToString());
            om.Tien_TT_1 = float.Parse(dt.Rows[0]["Tien_TT_1"].ToString());
            om.Ket_Luan_1_OD = dt.Rows[0]["KL_1"].ToString();
            om.VFD_2_OD = float.Parse(dt.Rows[0]["VFD_2"].ToString());
            om.PFD_2_OD = float.Parse(dt.Rows[0]["PFD_2"].ToString());
            om.LuuLuong_GN_2 = float.Parse(dt.Rows[0]["Luong_GN_2"].ToString());
            om.Tien_TT_2 = float.Parse(dt.Rows[0]["Tien_TT_2"].ToString());
            om.Ket_Luan_2_OD = dt.Rows[0]["KL_2"].ToString();
            om.KT_CNI = dt.Rows[0]["KT_CNI"].ToString();
            om.KT_ND = dt.Rows[0]["KT_ND"].ToString();
            return om;

        }
    }
}
