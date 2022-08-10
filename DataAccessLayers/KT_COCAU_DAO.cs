using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayers
{
    public class KT_COCAU_DAO
    {
        static SqlConnection conn;
        public static bool Them_CCTT(KT_CCTT kt)
        {
            string query = string.Format(@"INSERT INTO KT_COCAU VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}',N'{11}',N'{12}',N'{13}',N'{14}')"
             , kt.Id_CCTT, kt.Pfd_dt, kt.Ppr_dt, kt.Kl_gt, kt.Vfd_dt, kt.Vpr_dt, kt.Vref_dt, kt.Efd_dt, kt.Kl_thetich, kt.Vfd_tt, kt.Pu_tt, kt.Pc_tt, kt.Pfd_tt, kt.Ep_tt, kt.Kl_cctt);
            conn = Dataprovider.moketnoi();
            bool kq = Dataprovider.TruyVanKhongLayDuLieu(query, conn);
            return kq;
        }
        public static bool Edit_CCTT(KT_CCTT kt, string ma_cctt)
        {
            string query = string.Format(@"UPDATE KT_COCAU SET PFD_DT= N'{0}',PPR_DT= N'{1}',KL_GT= N'{2}',VFD_DT = N'{3}', VPR_DT = N'{4}', VREF_DT= N'{5}',EFD_DT= N'{6}',KL_TheTich= N'{7}',VFD_TT = N'{8}',PU_TT=N'{9}',PC_TT=N'{10}',PFD_TT= N'{11}',EP_TT =N'{12}',KL_CCTT= N'{13}' WHERE id_CCTT = N'{14}'"
            , kt.Pfd_dt, kt.Ppr_dt, kt.Kl_gt, kt.Vfd_dt, kt.Vpr_dt, kt.Vref_dt, kt.Efd_dt, kt.Kl_thetich, kt.Vfd_tt, kt.Pu_tt, kt.Pc_tt, kt.Pfd_tt, kt.Ep_tt, kt.Kl_cctt, ma_cctt);
            conn = Dataprovider.moketnoi();
            bool kq = Dataprovider.TruyVanKhongLayDuLieu(query, conn);
            return kq;
        }
        public static KT_CCTT Show_CCTT(string ma_cctt)
        {
            string query = string.Format(@"SELECT * FROM KT_COCAU WHERE id_CCTT = N'{0}' ", ma_cctt);
            conn = Dataprovider.moketnoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(query, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            KT_CCTT kt = new KT_CCTT();
            kt.Pfd_dt = float.Parse(dt.Rows[0]["PFD_DT"].ToString());
            kt.Ppr_dt = float.Parse(dt.Rows[0]["PPR_DT"].ToString());
            kt.Kl_gt = dt.Rows[0]["KL_GT"].ToString();
            kt.Vfd_dt = float.Parse(dt.Rows[0]["VFD_DT"].ToString());
            kt.Vpr_dt = float.Parse(dt.Rows[0]["VPR_DT"].ToString());
            kt.Vref_dt = float.Parse(dt.Rows[0]["VREF_DT"].ToString());
            kt.Efd_dt = float.Parse(dt.Rows[0]["EFD_DT"].ToString());
            kt.Kl_thetich = dt.Rows[0]["KL_TheTich"].ToString();
            kt.Vfd_tt = float.Parse(dt.Rows[0]["VFD_TT"].ToString());
            kt.Pu_tt = float.Parse(dt.Rows[0]["PU_TT"].ToString());
            kt.Pc_tt = float.Parse(dt.Rows[0]["PC_TT"].ToString());
            kt.Pfd_tt = float.Parse(dt.Rows[0]["PFD_TT"].ToString());
            kt.Ep_tt = float.Parse(dt.Rows[0]["EP_TT"].ToString());
            kt.Kl_cctt = dt.Rows[0]["KL_CCTT"].ToString();

            return kt;
        }
    }
}
