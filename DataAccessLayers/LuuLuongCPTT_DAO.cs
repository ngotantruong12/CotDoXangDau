using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataTransferObject;
using System.Data;

namespace DataAccessLayers
{
    public class LuuLuongCPTT_DAO
    {
        static SqlConnection Conn;
        //them luu luong CPTT
        public static bool Them_LuuLuongCPTT(LuuLuongCPTT ll_CPTT)
        {
            string Addquery = string.Format(@"INSERT INTO KT_LUULUONG_CPTT VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}',N'{11}',N'{12}')"
                , ll_CPTT.ID_LLTT, ll_CPTT.vfd_lltt, ll_CPTT.vref_lltt, ll_CPTT.e_lltt, ll_CPTT.kl_lltt, ll_CPTT.kt_cocauTK, ll_CPTT.kt_bangmat, ll_CPTT.qa_tk, ll_CPTT.vfd_tk,
                ll_CPTT.vtef_tk, ll_CPTT.efd_tk, ll_CPTT.ed_tk, ll_CPTT.kl_tk);
            Conn = Dataprovider.moketnoi();
            bool result = Dataprovider.TruyVanKhongLayDuLieu(Addquery, Conn);
            return result;
        }
        // Sua luu luong CPTT
        public static bool Sua_LuuLuongCPTT(LuuLuongCPTT fixll_cptt, string ID_CPTT)
        {
            string Fixquery = string.Format(@"UPDATE KT_LUULUONG_CPTT SET VFD_LLTT = N'{0}', 
                VREF_LLTT = N'{1}',
                E_LLTT = N'{2}',
                KL_LLTT = N'{3}', 
                KT_CoCauTK = N'{4}',
                KT_BangMat = N'{5}',
                QA_TK = N'{6}',
               VFD_TK = N'{7}',
                VTEF_TK = '{8}', 
                EFD_TK = N'{9}',
                ED_TK = N'{10}', 
                KL_TK = '{11}'
            WHERE id_LLTT = N'{12}'",
            fixll_cptt.vfd_lltt,//
            fixll_cptt.vref_lltt, //
            fixll_cptt.e_lltt, //
            fixll_cptt.kl_lltt, //
            fixll_cptt.kt_cocauTK,//
            fixll_cptt.kt_bangmat, //
            fixll_cptt.qa_tk,//
            fixll_cptt.vfd_tk, //
            fixll_cptt.vtef_tk, //
            fixll_cptt.efd_tk, //
            fixll_cptt.ed_tk, //
            fixll_cptt.kl_tk, //
            ID_CPTT);//
            Conn = Dataprovider.moketnoi();
            bool result = Dataprovider.TruyVanKhongLayDuLieu(Fixquery, Conn);
            return result;
        }

        /*  public static thongtin_cdxd XemThongTin_CDXD(string id_cdxd)
        {
            string queryXem = string.Format(@"SELECT * FROM THONGTIN_CDXD WHERE id_CDXD = N'{0}'", id_cdxd);
            Conn = Dataprovider.moketnoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(queryXem, Conn);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            thongtin_cdxd Xemtt_cdxd = new thongtin_cdxd();
            Xemtt_cdxd.TENPHUONGTIEN = dt.Rows[0]["TenPhuongTien"].ToString();
            Xemtt_cdxd.kieu = int.Parse( dt.Rows[0]["Kieu"].ToString()); public static thongtin_cdxd XemThongTin_CDXD(string id_cdxd)
        {
            string queryXem = string.Format(@"SELECT * FROM THONGTIN_CDXD WHERE id_CDXD = N'{0}'", id_cdxd);
            Conn = Dataprovider.moketnoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(queryXem, Conn);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            thongtin_cdxd Xemtt_cdxd = new thongtin_cdxd();
            Xemtt_cdxd.TENPHUONGTIEN = dt.Rows[0]["TenPhuongTien"].ToString();
            Xemtt_cdxd.kieu = int.Parse( dt.Rows[0]["Kieu"].ToString());*/
        public static LuuLuongCPTT XemLuuLuongCPTT(string id_CPTT)
        {
            string queryXem = string.Format(@"SELECT * FROM KT_LUULUONG_CPTT WHERE id_LLTT = N'{0}'", id_CPTT);
            Conn = Dataprovider.moketnoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(queryXem, Conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            LuuLuongCPTT XemLLCPTT = new LuuLuongCPTT();
            XemLLCPTT.vfd_lltt = float.Parse(dt.Rows[0]["VFD_LLTT"].ToString());
            XemLLCPTT.vref_lltt = float.Parse(dt.Rows[0]["VREF_LLTT"].ToString());
            XemLLCPTT.e_lltt = float.Parse(dt.Rows[0]["E_LLTT"].ToString());
            XemLLCPTT.kl_lltt = dt.Rows[0]["KL_LLTT"].ToString();
            XemLLCPTT.kt_cocauTK = dt.Rows[0]["KT_CoCauTK"].ToString();
            XemLLCPTT.kt_bangmat = dt.Rows[0]["KT_BangMat"].ToString();
            XemLLCPTT.qa_tk = float.Parse(dt.Rows[0]["QA_TK"].ToString());
            XemLLCPTT.vfd_tk = float.Parse(dt.Rows[0]["VFD_TK"].ToString());
            XemLLCPTT.vtef_tk = float.Parse(dt.Rows[0]["VTEF_TK"].ToString());
            XemLLCPTT.efd_tk = float.Parse(dt.Rows[0]["EFD_TK"].ToString());
            XemLLCPTT.ed_tk = float.Parse(dt.Rows[0]["ED_TK"].ToString());
            XemLLCPTT.kl_tk = dt.Rows[0]["KL_TK"].ToString();
            return XemLLCPTT;
        }
    }
}
