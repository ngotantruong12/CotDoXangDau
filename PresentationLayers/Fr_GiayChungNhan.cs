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
    public partial class Fr_GiayChungNhan : Form
    {
        float tgcapphat;
        string ma = "";
        float tgcapphat1, sochithetich1, luuluongQmaxmin1;
        string ketluan_tgcp, ketluan_tgcp_Đ1, ketluan_tgcp_K1;
        float EFD_maxT1, EFD_maxT2, EFD_minT1, EFD_minT2, EFD_maxS1, EFD_maxS2, EFD_minS1, EFD_minS2, EAV_maxT;
        float VFD_maxT1, VREF_maxT1, VFD_maxT2, VREF_maxT2, delta_EFD_maxT;
        string ketluan_maxT;
        float VFD_minT1, VREF_minT1, VFD_minT2, VREF_minT2, delta_EFD_minT, EAV_minT;
        string ketluan_minT;
        float VFD_maxS1, VREF_maxS1, VFD_maxS2, VREF_maxS2, delta_EFD_maxS, EAV_maxS;
        string ketluan_maxS;
        float VFD_minS1, VREF_minS1, VFD_minS2, VREF_minS2, delta_EFD_minS, EAV_minS;
        string ketluan_minS;
        int tem;

        public Fr_GiayChungNhan()
        {
            InitializeComponent();
        }
        public Fr_GiayChungNhan(int tem )
        {
            InitializeComponent();
            this.tem = tem;
        }

        private void Fr_GiayChungNhan_Load(object sender, EventArgs e)
        {
            GiayKG rp = new GiayKG();
         /*   rp.SetParameterValue("pr_tgcapnhat", tgcapphat1);
            rp.SetParameterValue("pr_sochiTT", 111);
            rp.SetParameterValue("pr_luuluongQm", luuluongQmaxmin1);
            rp.SetParameterValue("pr_danhgiaĐ", ketluan_tgcp_Đ1);
            rp.SetParameterValue("pr_danhgiaK", ketluan_tgcp_K1); */
           rp.SetParameterValue("pr_tem", tem);
            crystalReportGKD.ReportSource = rp;
        }

    }
}
