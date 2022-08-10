using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
     public class LuuLuongCPTT
    {
        string id_LLTT, KL_LLTT, KT_CoCauTK, KT_BangMat, KL_TK;
        float VFD_LLTT,
                VREF_LLTT,
                E_LLTT,
                QA_TK,
                VFD_TK,
                VTEF_TK,
                EFD_TK,
                ED_TK;

        public string ID_LLTT
        {
            get { return id_LLTT; }
            set { id_LLTT = value; }
        }

        public string kl_lltt
        {
            get { return KL_LLTT; }
            set { KL_LLTT = value; }
        }

        public string kt_cocauTK
        {
            get { return KT_CoCauTK; }
            set { KT_CoCauTK = value; }
        }

        public string kt_bangmat
        {
            get { return KT_BangMat; }
            set { KT_BangMat = value; }
        }

        public float vfd_lltt
        {
            get { return VFD_LLTT; }
            set { VFD_LLTT = value; }
        }

        public float vref_lltt
        {
            get { return VREF_LLTT; }
            set { VREF_LLTT = value; }
        }

        public float e_lltt
        {
            get { return E_LLTT; }
            set { E_LLTT = value; }
        }


        public float qa_tk
        {
            get { return QA_TK; }
            set { QA_TK = value; }
        }

        public float vfd_tk
        {
            get { return VFD_TK; }
            set { VFD_TK = value; }
        }

        public float vtef_tk
        {
            get { return VTEF_TK; }
            set { VTEF_TK = value; }
        }

        public float efd_tk
        {
            get { return EFD_TK; }
            set { EFD_TK = value; }
        }

        public float ed_tk
        {
            get { return ED_TK; }
            set { ED_TK = value; }
        }

        public string kl_tk
        {
            get { return KL_TK; }
            set { KL_TK = value; }
        }
    }
}
