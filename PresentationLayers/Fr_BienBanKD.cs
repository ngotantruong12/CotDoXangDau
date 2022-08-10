using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayers
{
    public partial class Fr_BienBanKD : Form
    {

        string ma = "";
        float tgcapphat1, sochithetich1, luuluongQmaxmin1;
        string ketluan_tgcp, ketluan_tgcp_Ð1, ketluan_tgcp_K1;
        float EFD_maxT1, EFD_maxT2, EFD_minT1, EFD_minT2, EFD_maxS1, EFD_maxS2, EFD_minS1, EFD_minS2, EAV_maxT;
        float VFD_maxT1, VREF_maxT1, VFD_maxT2, VREF_maxT2, delta_EFD_maxT;
        string ketluan_maxT;
        float VFD_minT1, VREF_minT1, VFD_minT2, VREF_minT2, delta_EFD_minT, EAV_minT;
        string ketluan_minT;
        float VFD_maxS1, VREF_maxS1, VFD_maxS2, VREF_maxS2, delta_EFD_maxS, EAV_maxS;
        string ketluan_maxS;
        float VFD_minS1, VREF_minS1, VFD_minS2, VREF_minS2, delta_EFD_minS, EAV_minS;
        string ketluan_minS;
        //Co cau dat truoc, tinh tien
        string KL_TheTich, KL_GT, KL_CCTT;
        float PFD_DT, PPR_DT, VFD_DT, VPR_DT, VREF_DT, EFD_DT, VFD_TT, PU_TT, PC_TT, PFD_TT, EP_TT;
        // ong mem
        string kl_so_od, kt_cci, ketluan_1_OD, ketluan_2_OD, kt_cni, kt_nd;
        float so_od, vfd_1_OD, pfd_1_OD, luuluong_GN_1, tien_tt1, vfd_2_OD, pfd_2_OD, luuluong_GN_2, tien_tt2;
        string check_kl_so_od_Đ, check_kl_so_od_K, check_kt_cni_Đ, check_kt_cni_K, check_kt_nd_Đ, check_kt_nd_K;
        public Fr_BienBanKD()
        {
            InitializeComponent();
        }
        public Fr_BienBanKD(float tgcapphat, float sochithetich, float luuluongQmaxmin, string ketluan_tgcp_Ð, string ketluan_tgcp_K
            , float VFD_maxT1, float VREF_maxT1, float EFD_maxT1, float VFD_maxT2, float VREF_maxT2, float EFD_maxT2, float delta_EFD_maxT, float EAV_maxT, string ketluan_maxT
            , float VFD_minT1, float VREF_minT1, float EFD_minT1, float VFD_minT2, float VREF_minT2, float EFD_minT2, float delta_EFD_minT, float EAV_minT, string ketluan_minT
            , float VFD_maxS1, float VREF_maxS1, float EFD_maxS1, float VFD_maxS2, float VREF_maxS2, float EFD_maxS2, float delta_EFD_maxS, float EAV_maxS, string ketluan_maxS
            , float VFD_minS1, float VREF_minS1, float EFD_minS1, float VFD_minS2, float VREF_minS2, float EFD_minS2, float delta_EFD_minS, float EAV_minS, string ketluan_minS
            , string KL_TheTich, string KL_GT, string KL_CCTT, float PFD_DT, float PPR_DT, float VFD_DT, float VPR_DT, float VREF_DT, float EFD_DT, float VFD_TT, float PU_TT
            , float PC_TT, float PFD_TT, float EP_TT
            , float so_od,float vfd_1_OD,float pfd_1_OD,float luuluong_GN_1,float tien_tt1,float vfd_2_OD,float pfd_2_OD,float luuluong_GN_2,float tien_tt2
            , string check_kl_so_od_Đ, string check_kl_so_od_K, string check_kt_cni_Đ, string check_kt_cni_K, string check_kt_nd_Đ, string check_kt_nd_K
            , string ketluan_1_OD, string ketluan_2_OD)
        {
            InitializeComponent();
            this.tgcapphat1 = tgcapphat;
            this.sochithetich1 = sochithetich;
            this.luuluongQmaxmin1 = luuluongQmaxmin;
            this.ketluan_tgcp_Ð1 = ketluan_tgcp_Ð;
            this.ketluan_tgcp_K1 = ketluan_tgcp_K;

            this.VFD_maxT1 = VFD_maxT1;
            this.VREF_maxT1 = VREF_maxT1;
            this.EFD_maxT1 = EFD_maxT1;
            this.VFD_maxT2 = VFD_maxT2;
            this.VREF_maxT2 = VREF_maxT2;
            this.EFD_maxT2 = EFD_maxT2;
            this.delta_EFD_maxT = delta_EFD_maxT;
            this.EAV_maxT = EAV_maxT;
            this.ketluan_maxT = ketluan_maxT;
            // 
            this.VFD_minT1 = VFD_minT1;
            this.VREF_minT1 = VREF_minT1;
            this.EFD_minT1 = EFD_minT1;
            this.VFD_minT2 = VFD_minT2;
            this.VREF_minT2 = VREF_minT2;
            this.EFD_minT2 = EFD_minT2;
            this.delta_EFD_minT = delta_EFD_minT;
            this.EAV_minT = EAV_minT;
            this.ketluan_minT = ketluan_minT;
            // 
            this.VFD_maxS1 = VFD_maxS1;
            this.VREF_maxS1 = VREF_maxS1;
            this.EFD_maxS1 = EFD_maxS1;
            this.VFD_maxS2 = VFD_maxS2;
            this.VREF_maxS2 = VREF_maxS2;
            this.EFD_maxS2 = EFD_maxS2;
            this.delta_EFD_maxS = delta_EFD_maxS;
            this.EAV_maxS = EAV_maxS;
            this.ketluan_maxS = ketluan_maxS;
            //
            this.VFD_minS1 = VFD_minS1;
            this.VREF_minS1 = VREF_minS1;
            this.EFD_minS1 = EFD_minS1;
            this.VFD_minS2 = VFD_minS2;
            this.VREF_minS2 = VREF_minS2;
            this.EFD_minS2 = EFD_minS2;
            this.delta_EFD_minS = delta_EFD_minS;
            this.EAV_minS = EAV_minS;
            this.ketluan_minS = ketluan_minS;
            ///Co cau dat truoc, tinh tien
            this.PFD_DT = PFD_DT;
            this.PPR_DT = PPR_DT;
            this.KL_GT = KL_GT;
            this.VFD_DT = VFD_DT;
            this.VPR_DT = VPR_DT;
            this.VREF_DT = VREF_DT;
            this.EFD_DT = EFD_DT;
            this.KL_TheTich = KL_TheTich;
            this.VFD_TT = VFD_TT;
            this.PU_TT = PU_TT;
            this.PC_TT = PC_TT;
            this.PFD_TT = PFD_TT;
            this.EP_TT = EP_TT;
            this.KL_CCTT = KL_CCTT;
            // ong mem
            this.so_od=so_od;
            this.vfd_1_OD= vfd_1_OD;
            this.pfd_1_OD= pfd_1_OD;
            this.luuluong_GN_1= luuluong_GN_1;
            this.tien_tt1=tien_tt1 ;
            this.vfd_2_OD= vfd_2_OD;
            this.pfd_2_OD=pfd_2_OD ;
            this.luuluong_GN_2=luuluong_GN_2 ;
            this.tien_tt2 = tien_tt2;
            this.check_kl_so_od_Đ = check_kl_so_od_Đ; 
            this.check_kl_so_od_K =check_kl_so_od_K ;
            this.check_kt_cni_Đ =check_kt_cni_Đ ;
            this.check_kt_cni_K = check_kt_cni_K;
            this.check_kt_nd_Đ = check_kt_nd_Đ;
            this.check_kt_nd_K = check_kt_nd_K;
            this.ketluan_1_OD = ketluan_1_OD;
            this.ketluan_2_OD = ketluan_2_OD;

        }

        private void Fr_BienBanKD_Load(object sender, EventArgs e)
        {
            rpBBKD_TB rp = new rpBBKD_TB();
            rp.SetParameterValue("pr_tgcapnhat", tgcapphat1);
            rp.SetParameterValue("pr_sochiTT", sochithetich1);
            rp.SetParameterValue("pr_luuluongQm", luuluongQmaxmin1);
            rp.SetParameterValue("pr_danhgiaÐ", ketluan_tgcp_Ð1);
            rp.SetParameterValue("pr_danhgiaK", ketluan_tgcp_K1);

            rp.SetParameterValue("VFD_maxT1", VFD_maxT1);
            rp.SetParameterValue("VREF_maxT1", VREF_maxT1);
            rp.SetParameterValue("EFD_maxT1", EFD_maxT1);
            rp.SetParameterValue("VFD_maxT2", VFD_maxT2);
            rp.SetParameterValue("VREF_maxT2", VREF_maxT2);
            rp.SetParameterValue("EFD_maxT2", EFD_maxT2);
            rp.SetParameterValue("delta_EFD_maxT", delta_EFD_maxT);
            rp.SetParameterValue("EAV_maxT", EAV_maxT);
            rp.SetParameterValue("ketluan_maxT", ketluan_maxT);

            rp.SetParameterValue("VFD_minT1", VFD_minT1);
            rp.SetParameterValue("VREF_minT1", VREF_minT1);
            rp.SetParameterValue("EFD_minT1", EFD_minT1);
            rp.SetParameterValue("VFD_minT2", VFD_minT2);
            rp.SetParameterValue("VREF_minT2", VREF_minT2);
            rp.SetParameterValue("EFD_minT2", EFD_minT2);
            rp.SetParameterValue("delta_EFD_minT", delta_EFD_minT);
            rp.SetParameterValue("EAV_minT", EAV_minT);
            rp.SetParameterValue("ketluan_minT", ketluan_minT);

            rp.SetParameterValue("VFD_maxS1", VFD_maxS1);
            rp.SetParameterValue("VREF_maxS1", VREF_maxS1);
            rp.SetParameterValue("EFD_maxS1", EFD_maxS1);
            rp.SetParameterValue("VFD_maxS2", VFD_maxS2);
            rp.SetParameterValue("VREF_maxS2", VREF_maxS2);
            rp.SetParameterValue("EFD_maxS2", EFD_maxS2);
            rp.SetParameterValue("delta_EFD_maxS", delta_EFD_maxS);
            rp.SetParameterValue("EAV_maxS", EAV_maxS);
            rp.SetParameterValue("ketluan_maxS", ketluan_maxS);

            rp.SetParameterValue("VFD_minS1", VFD_minS1);
            rp.SetParameterValue("VREF_minS1", VREF_minS1);
            rp.SetParameterValue("EFD_minS1", EFD_minS1);
            rp.SetParameterValue("VFD_minS2", VFD_minS2);
            rp.SetParameterValue("VREF_minS2", VREF_minS2);
            rp.SetParameterValue("EFD_minS2", EFD_minS2);
            rp.SetParameterValue("delta_EFD_minS", delta_EFD_minS);
            rp.SetParameterValue("EAV_minS", EAV_minS);
            rp.SetParameterValue("ketluan_minS", ketluan_minS);
            // co cau tinh tien
            rp.SetParameterValue("PFD_DT", PFD_DT);
            rp.SetParameterValue("PPR_DT", PPR_DT);
            rp.SetParameterValue("KL_GT", KL_GT);
            rp.SetParameterValue("VFD_DT", VFD_DT);
            rp.SetParameterValue("VPR_DT", VPR_DT);
            rp.SetParameterValue("VREF_DT", VREF_DT);
            rp.SetParameterValue("EFD_DT", EFD_DT);
            rp.SetParameterValue("KL_TheTich", KL_TheTich);
            rp.SetParameterValue("VFD_TT", VFD_TT);
            rp.SetParameterValue("PU_TT", PU_TT);
            rp.SetParameterValue("PC_TT", PC_TT);
            rp.SetParameterValue("PFD_TT", PFD_TT);
            rp.SetParameterValue("EP_TT", EP_TT);
            rp.SetParameterValue("KL_CCTT", KL_CCTT);
            // ong mem
            rp.SetParameterValue("pr_sochisodong", so_od);
            rp.SetParameterValue("pr_VFD_OD_1", vfd_1_OD);
            rp.SetParameterValue("pr_PFD_OD_1", pfd_1_OD);
            rp.SetParameterValue("pr_luonggiaonhan_1", luuluong_GN_1);
            rp.SetParameterValue("pr_tienthanhtoan_1", tien_tt1);
            rp.SetParameterValue("pr_KL_OD_1", ketluan_1_OD);
            rp.SetParameterValue("pr_VFD_OD_2", vfd_2_OD);
            rp.SetParameterValue("pr_PFD_OD_2", pfd_2_OD);
            rp.SetParameterValue("pr_luonggiaonhan_2", luuluong_GN_2);
            rp.SetParameterValue("pr_tienthanhtoan_2", tien_tt2);
            rp.SetParameterValue("pr_KL_OD_2", ketluan_2_OD);
            rp.SetParameterValue("pr_kl_chisodong_Đ", check_kl_so_od_Đ);
            rp.SetParameterValue("pr_kl_chisodong_K", check_kl_so_od_K);
            rp.SetParameterValue("prr_KT_CNI_Đ", check_kt_cni_Đ);
            rp.SetParameterValue("prr_KT_CNI_K", check_kt_cni_K);
            rp.SetParameterValue("pr_KT_NDI_Đ", check_kt_nd_Đ);
            rp.SetParameterValue("pr_KT_NDI_K", check_kt_nd_K);

            crrp_BBKG.ReportSource = rp;
        }
    }
}
