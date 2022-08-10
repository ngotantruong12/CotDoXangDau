using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class KT_CCTT
    {
        private string id_CCTT;
        private float PFD_DT;
        private float PPR_DT;
        private string KL_GT;
        private float VFD_DT;
        private float VPR_DT;
        private float VREF_DT;
        private float EFD_DT;
        private string KL_TheTich;
        private float VFD_TT;
        private float PU_TT;
        private float PC_TT;
        private float PFD_TT;
        private float EP_TT;
        private string KL_CCTT;

        public string Id_CCTT
        {
            get { return id_CCTT; }
            set { id_CCTT = value; }
        }
        public float Pfd_dt
        {
            get { return PFD_DT; }
            set { PFD_DT = value; }
        }
        public float Ppr_dt
        {
            get { return PPR_DT; }
            set { PPR_DT = value; }
        }
        public string Kl_gt
        {
            get { return KL_GT; }
            set { KL_GT = value; }
        }
        public float Vfd_dt
        {
            get { return VFD_DT; }
            set { VFD_DT = value; }
        }
        public float Vpr_dt
        {
            get { return VPR_DT; }
            set { VPR_DT = value; }
        }
        public float Vref_dt
        {
            get { return VREF_DT; }
            set { VREF_DT = value; }
        }
        public float Efd_dt
        {
            get { return EFD_DT; }
            set { EFD_DT = value; }
        }
        public string Kl_thetich
        {
            get { return KL_TheTich; }
            set { KL_TheTich = value; }
        }
        public float Vfd_tt
        {
            get { return VFD_TT; }
            set { VFD_TT = value; }
        }
        public float Pu_tt
        {
            get { return PU_TT; }
            set { PU_TT = value; }
        }
        public float Pc_tt
        {
            get { return PC_TT; }
            set { PC_TT = value; }
        }
        public float Pfd_tt
        {
            get { return PFD_TT; }
            set { PFD_TT = value; }
        }
        public float Ep_tt
        {
            get { return EP_TT; }
            set { EP_TT = value; }
        }
        public string Kl_cctt
        {
            get { return KL_CCTT; }
            set { KL_CCTT = value; }
        }
    }
}
