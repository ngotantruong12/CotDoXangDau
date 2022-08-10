using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayers;
using DataTransferObject;
using BusinessLogicLayers;

namespace PresentationLayers
{
    public partial class frm_trubom : Form
    {
        string ma = "";
        float tgcapphat, sochithetich, luuluongQmaxmin;
        string ketluan_tgcp, ketluan_tgcp_Đ, ketluan_tgcp_K;
        float EFD_maxT1, EFD_maxT2, EFD_minT1, EFD_minT2, EFD_maxS1, EFD_maxS2, EFD_minS1, EFD_minS2, EAV_maxT;
        float VFD_maxT1, VREF_maxT1,  VFD_maxT2, VREF_maxT2, delta_EFD_maxT ;
        string ketluan_maxT;
        float VFD_minT1, VREF_minT1, VFD_minT2, VREF_minT2,  delta_EFD_minT, EAV_minT;
        string ketluan_minT;
        float VFD_maxS1, VREF_maxS1, VFD_maxS2, VREF_maxS2,  delta_EFD_maxS, EAV_maxS;
        string ketluan_maxS;
        float VFD_minS1, VREF_minS1,  VFD_minS2, VREF_minS2, delta_EFD_minS, EAV_minS;
        string ketluan_minS;
        // tem
        int tem;
        bool flag = false;
        // kt ben ngoai
        string id_bn, KT_nhanmac, KT_bophanchinh, KT_kinh, KT_ongcs;
        // KT KYTHUAT
        string id_kt, kt_sobo, kt_dokin, kt_hoatdongccxs, kt_cocautungat;
        //Co cau dat truoc, tinh tien
        string KL_TheTich, KL_GT, KL_CCTT;
        float PFD_DT, PPR_DT, VFD_DT, VPR_DT, VREF_DT, EFD_DT, VFD_TT, PU_TT, PC_TT, PFD_TT, EP_TT;
        // Ong mem
        string kl_so_od, kt_cci, ketluan_1_OD, ketluan_2_OD, kt_cni, kt_nd;
        float so_od, vfd_1_OD, pfd_1_OD, luuluong_GN_1, tien_tt1, vfd_2_OD, pfd_2_OD, luuluong_GN_2, tien_tt2;
        string check_kl_so_od_Đ, check_kl_so_od_K, check_kt_cni_Đ, check_kt_cni_K, check_kt_nd_Đ, check_kt_nd_K;
        // thong tin chung
        string id_cdxd = " ", TenPhuongTien, CoSo_SX, CheDo_KD, ChatLong_KD, PhuongPhap_TH,
        ChuanThietBi_SD, DonVi_SD, DiaChi_SD, DiaDiem_TH;
        int Kieu, So, CapChinhXac, Nam_SX, id_NV;
        DateTime Ngay_KD;
        float LuuLuong_Max, LuuLuong_Min, LuongCapPhat_Min;
        //LuuLuong CPTT
        string id_LLTT = " ", KL_LLTT, KT_CoCauTK, KT_BangMat, KL_TK;
        float VFD_LLTT, VREF_LLTT, E_LLTT, QA_TK, VFD_TK, VTEF_TK, EFD_TK, ED_TK, ED;
        public frm_trubom()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                MessageBox.Show("Không Đạt Yêu Cầu");
            }
            else
            {
                Fr_GiayChungNhan fr = new Fr_GiayChungNhan(tem);
                this.Hide();
                fr.ShowDialog();
                this.Show();
            }
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
             Fr_BienBanKD fr = new Fr_BienBanKD(tgcapphat, sochithetich, luuluongQmaxmin, ketluan_tgcp_Đ, ketluan_tgcp_K,
               VFD_maxT1, VREF_maxT1, EFD_maxT1, VFD_maxT2, VREF_maxT2, EFD_maxT2, delta_EFD_maxT, EAV_maxT, ketluan_maxT
              , VFD_minT1, VREF_minT1, EFD_minT1, VFD_minT2, VREF_minT2, EFD_minT2, delta_EFD_minT, EAV_minT, ketluan_minT
              , VFD_maxS1, VREF_maxS1, EFD_maxS1, VFD_maxS2, VREF_maxS2, EFD_maxS2, delta_EFD_maxS, EAV_maxS, ketluan_maxS
              , VFD_minS1, VREF_minS1, EFD_minS1, VFD_minS2, VREF_minS2, EFD_minS2, delta_EFD_minS, EAV_minS, ketluan_minS
              , KL_TheTich, KL_GT, KL_CCTT, PFD_DT, PPR_DT, VFD_DT, VPR_DT, VREF_DT, EFD_DT, VFD_TT, PU_TT, PC_TT, PFD_TT, EP_TT
               , so_od, vfd_1_OD, pfd_1_OD, luuluong_GN_1, tien_tt1, vfd_2_OD, pfd_2_OD, luuluong_GN_2, tien_tt2
                ,check_kl_so_od_Đ, check_kl_so_od_K, check_kt_cni_Đ, check_kt_cni_K, check_kt_nd_Đ, check_kt_nd_K
                , ketluan_1_OD, ketluan_2_OD);
            this.Hide();
            fr.ShowDialog();
            this.Show();
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try {
                if (tabControl1.SelectedTab.Text == "Nhập thông tin chung")
                {

                    AnhXaThongTin_CDXD();
                    thongtin_cdxd thongtin_cdxd = new thongtin_cdxd();
                    thongtin_cdxd.ID_CDXD = ma;
                    thongtin_cdxd.TENPHUONGTIEN = TenPhuongTien;
                    thongtin_cdxd.CS_SX = CoSo_SX;
                    thongtin_cdxd.CHEDO_KD = CheDo_KD;
                    thongtin_cdxd.PHUONGPHAP_TH = PhuongPhap_TH;
                    thongtin_cdxd.CHUANTHIETBI_SD = ChuanThietBi_SD;
                    thongtin_cdxd.DONVI_SD = DonVi_SD;
                    thongtin_cdxd.DIACHI_SD = DiaChi_SD;
                    thongtin_cdxd.DIADIEM_TH = DiaDiem_TH;
                    thongtin_cdxd.kieu = Kieu;
                    thongtin_cdxd.so = So;
                    thongtin_cdxd.CAPCHINHXAC = CapChinhXac;
                    thongtin_cdxd.NAM_SX = Nam_SX;
                    thongtin_cdxd.ID_NV = id_NV;
                    thongtin_cdxd.NGAY_KD = Ngay_KD;
                    thongtin_cdxd.LUULUONG_MAX = LuuLuong_Max;
                    thongtin_cdxd.LUULUONG_MIN = LuuLuong_Min;
                    thongtin_cdxd.LUONGCAPPHAT_MIN = LuongCapPhat_Min;
                    thongtin_cdxd.CHATLONG_KD = ChatLong_KD;
                    if (ThongTinCDXD_BUS.Add_ThongTinCDXD(thongtin_cdxd) == false)
                    {
                        MessageBox.Show("Thêm thất bại");

                    }
                    else
                    {
                        MessageBox.Show("Đã Thêm");
                        button6.Enabled = true;
                    }


                }
                if (tabControl1.SelectedTab.Text == "LL lớn nhất và sai số")
                {

                    anhxa_dluong();
                    DoLuong dl = new DoLuong();
                    dl.Id_doluong = ma;
                    dl.Tg_capphat = tgcapphat;
                    dl.Sothetich = sochithetich;
                    dl.Luuluong_qmax = luuluongQmaxmin;
                    dl.ketLuan_qmax = ketluan_tgcp;

                    dl.vfd_max_t1 = VFD_maxT1;
                    dl.vref_max_t1 = VREF_maxT1;
                    dl.efd_max_t1 = EFD_maxT1;
                    dl.vfd_max_t2 = VFD_maxT2;
                    dl.vref_max_t2 = VREF_maxT2;
                    dl.efd_max_t2 = EFD_maxT2;
                    dl.delta_EFD_maxT = delta_EFD_maxT;
                    dl.eav_max_t = EAV_maxT;
                    dl.Ketluan_qmax_t = ketluan_maxT;
                    // min t
                    dl.vfd_min_t1 = VFD_minT1;
                    dl.vref_min_t1 = VREF_minT1;
                    dl.efd_min_t1 = EFD_minT1;
                    dl.vfd_min_t2 = VFD_minT2;
                    dl.vref_min_t2 = VREF_minT2;
                    dl.efd_min_t2 = EFD_minT2;
                    dl.delta_EFD_minT = delta_EFD_minT;
                    dl.eav_min_t = EAV_minT;
                    dl.Ketluan_qmin_t = ketluan_minT;
                    // max s
                    dl.vfd_max_s1 = VFD_maxS1;
                    dl.vref_max_s1 = VREF_maxS1;
                    dl.efd_max_s1 = EFD_maxS1;
                    dl.vfd_max_s2 = VFD_maxS2;
                    dl.vref_max_s2 = VREF_maxS2;
                    dl.efd_max_s2 = EFD_maxS2;
                    dl.delta_EFD_maxS = delta_EFD_maxS;
                    dl.eav_max_s = EAV_maxS;
                    dl.Ketluan_qmax_s = ketluan_maxS;
                    // min s
                    dl.vfd_min_s1 = VFD_minS1;
                    dl.vref_min_s1 = VREF_minS1;
                    dl.efd_min_s1 = EFD_minS1;
                    dl.vfd_min_s2 = VFD_minS2;
                    dl.vref_min_s2 = VREF_minS2;
                    dl.efd_min_s2 = EFD_minS2;
                    dl.delta_EFD_minS = delta_EFD_minS;
                    dl.eav_min_s = EAV_minS;
                    dl.Ketluan_qmin_s = ketluan_minS;
                    if (DoLuong_BUS.Them_DOLUONG(dl) == false)
                    {
                        MessageBox.Show("Thêm Không Thành Công");

                    }
                    else
                    {
                        if (ketluan_maxT == "Đạt" && ketluan_minT == "Đạt" && ketluan_maxS == "Đạt" && ketluan_minS == "Đạt" && ketluan_tgcp == "Đạt")
                        { flag = true; }
                        else { flag = false; }
                        MessageBox.Show("Đã Thêm");
                      //  button6.Enabled = true;

                    }

                }
         //Thêm KT_NGOAI
            if (tabControl1.SelectedTab.Text == "KT bên ngoài")
            {
                anhxa_ktngoai();
                KTNgoai_DTO ktn = new KTNgoai_DTO();
                ktn.id_bn = ma;
                ktn.KT_nhanmac = KT_nhanmac;
                ktn.KT_bophanchinh = KT_bophanchinh;
                ktn.KT_kinh = KT_kinh;
                ktn.KT_ongcs = KT_ongcs;
                if (KTNgoai_BUS.Them_KTNgoai(ktn)==false)
                {
                    MessageBox.Show("Thêm Không Thành Công");
                }
                else
                {
                    if (KT_nhanmac == "Đạt" && KT_bophanchinh == "Đạt" && KT_kinh == "Đạt" && KT_ongcs =="Đạt")
                    { flag = true; }
                    else { flag = false; }
                    MessageBox.Show("Đã Thêm");
                }      
            }
            //Thêm KT_KY THuật
            if (tabControl1.SelectedTab.Text == "KT kỹ thuật")
            {
                anhxa_kythuat();
                KTKyThuat_DTO ktk = new KTKyThuat_DTO();
                ktk.id_kt = ma;
                ktk.kt_sobo = kt_sobo;
                ktk.kt_dokin = kt_dokin;
                ktk.kt_hoatdongccxs = kt_hoatdongccxs;
                ktk.kt_cocautungat = kt_cocautungat;
                if (KTKyThuat_BUS.Them_KTKyThuat(ktk) == false)
                {
                    MessageBox.Show("Thêm Không Thành Công");
                }
               else
                {
                    if (kt_sobo == "Đạt" && kt_dokin == "Đạt" && kt_hoatdongccxs == "Đạt" && kt_cocautungat == "Đạt")
                    { flag = true; }
                    else { flag = false; }
                    MessageBox.Show("Đã Thêm");
                }
               
            }
            if (tabControl1.SelectedTab.Text == "Cơ cấu đặt trước, tính tiền")
            {
                anhxa_cocautinhtien();
                KT_CCTT tt = new KT_CCTT();
                tt.Id_CCTT = ma;
                tt.Pfd_dt = PFD_DT;
                tt.Ppr_dt = PPR_DT;
                tt.Kl_gt = KL_GT;
                tt.Vfd_dt = VFD_DT;
                tt.Vpr_dt = VPR_DT;
                tt.Vref_dt = VREF_DT;
                tt.Efd_dt = EFD_DT;
                tt.Kl_thetich = KL_TheTich;
                tt.Vfd_tt = VFD_TT;
                tt.Pu_tt = PU_TT;
                tt.Pc_tt = PC_TT;
                tt.Pfd_tt = PFD_TT;
                tt.Ep_tt = EP_TT;
                tt.Kl_cctt = KL_CCTT;
                if (KT_CCTT_BUS.Them_COCAU(tt) == true)
                {
                    if(KL_GT == "Đạt" && KL_TheTich =="Đạt" && KL_CCTT == "Đạt")
                    { flag = true; }
                    else { flag = false; }
                    MessageBox.Show("Da them vao bang KT_COCAU");
                }
                else
                {
                    MessageBox.Show("Chua them vao bang KT_COCAU");
                }
            }
            if (tabControl1.SelectedTab.Text == "Ống mềm, in")
            {
                anhxa_ongmem();
                OngMem_In_DTO om = new OngMem_In_DTO();
                om.ID_OM_CCI = ma;
                om.SO_OD = so_od;
                om.KL_SO_OD = kl_so_od;
                om.KT_CCI = kt_cci;
                om.VFD_1_OD = vfd_1_OD;
                om.PFD_1_OD = pfd_1_OD;
                om.LuuLuong_GN_1 = luuluong_GN_1;
                om.Tien_TT_1 = tien_tt1;
                om.Ket_Luan_1_OD = ketluan_1_OD;
                om.VFD_2_OD = vfd_2_OD;
                om.PFD_2_OD = pfd_2_OD;
                om.LuuLuong_GN_2 = luuluong_GN_2;
                om.Tien_TT_2 = tien_tt2;
                om.Ket_Luan_2_OD = ketluan_2_OD;
                om.KT_CNI = kt_cni;
                om.KT_ND = kt_nd;
                if (OngMem_BUS.Them_OM(om) == false)
                {
                    MessageBox.Show("Thêm Không Thành Công");
                }
                else
                {
                    if (kl_so_od == "Đạt" && ketluan_1_OD == "Đạt" && ketluan_2_OD == "Đạt" && kt_cni == "Đạt" && kt_nd == "Đạt")
                    { flag = true; }
                    else { flag = false; }
                    MessageBox.Show("Đã Thêm");
                }



            }
            // cap phat toi thieu tach khi
            if (tabControl1.SelectedTab.Text == "Cấp phát tối thiểu, tách khí")
            {
                AnhXaLuuLuongCPTT();
                LuuLuongCPTT ll_ccptt = new LuuLuongCPTT();
                ll_ccptt.vfd_lltt = VFD_LLTT;
                ll_ccptt.vref_lltt = VREF_LLTT;
                ll_ccptt.e_lltt = E_LLTT;
                ll_ccptt.kl_lltt = KL_LLTT;
                ll_ccptt.kt_cocauTK = KT_CoCauTK;
                ll_ccptt.kt_bangmat = KT_BangMat;
                ll_ccptt.qa_tk = QA_TK;
                ll_ccptt.vfd_tk = VFD_TK;
                ll_ccptt.vtef_tk = VTEF_TK;
                ll_ccptt.efd_tk = EFD_TK;
                ll_ccptt.ed_tk = ED_TK;
                ll_ccptt.kl_tk = KL_TK;
                ll_ccptt.ID_LLTT = ma;
                if (LuuLuongCPTT_BUS.Add_LuuLuongCPTT(ll_ccptt) == false)
                {

                    MessageBox.Show("Thêm thất bại");
                }
                else
                {
                    MessageBox.Show("Đã Thêm");
                    button6.Enabled = true;
                }

            }

            }
            catch
            {
                MessageBox.Show("Vui lòng nhập thông tin");
            }


        }

        private void frm_trubom_Load(object sender, EventArgs e)
        {
            ma = TangMa.matutang();
            btn_luu_TEM.Enabled = false;
         //   button6.Enabled = false;
            button7.Enabled = false;
            DataTable dt = ThongTinCDXD_BUS.load_cbb();
            cbxKiemDinhVien.DataSource = dt;
            cbxKiemDinhVien.DisplayMember = "HoTen";
            cbxKiemDinhVien.ValueMember = "id_NV";

        }
        private void ClearTextBoxesRadio()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is RadioButton)
                        (control as RadioButton).Checked = false;
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void txtEFD_maxT1_Click(object sender, EventArgs e)
        {
            VFD_maxT1 = Convert.ToSingle(txtVFD_maxT1.Text);
            VREF_maxT1 = Convert.ToSingle(txtVREF_maxT1.Text);
            EFD_maxT1 = (100 * (VFD_maxT1 - VREF_maxT1)) / VREF_maxT1;
            txtEFD_maxT1.Text = EFD_maxT1.ToString();
        }

        private void txtEFD_maxT2_Click(object sender, EventArgs e)
        {
            VFD_maxT2 = float.Parse(txtVFD_maxT2.Text);
            VREF_maxT2 = float.Parse(txtVREF_maxT2.Text);
            EFD_maxT2 = (100 * (VFD_maxT2 - VREF_maxT2)) / VREF_maxT2;
            txtEFD_maxT2.Text = EFD_maxT2.ToString();

        }
        public void anhxa_dluong()
        {
            tgcapphat = float.Parse(txttg_capphat.Text);
            sochithetich = float.Parse(txtsochithetich.Text);
            luuluongQmaxmin = float.Parse(txtluuluongQminmax.Text);
            if (radketluandat.Checked == true)
            {

                ketluan_tgcp = "Đạt";
                ketluan_tgcp_Đ = "X";
                ketluan_tgcp_K = "";
            }
            else if (radketluanKHONGdat.Checked == true)
            {
              //  flag = false;
                ketluan_tgcp = "Không";
                ketluan_tgcp_Đ = "";
                ketluan_tgcp_K = "X";
            }

            // float VFD_maxT1 = float.Parse(txtVFD_maxT1.Text);
            VFD_maxT1 = Convert.ToSingle(txtVFD_maxT1.Text);
            VREF_maxT1 = float.Parse(txtVREF_maxT1.Text);
            //
            VFD_maxT2 = float.Parse(txtVFD_maxT2.Text);
            VREF_maxT2 = float.Parse(txtVREF_maxT2.Text);
            delta_EFD_maxT = EFD_maxT1 - EFD_maxT2;
            ketluan_maxT = txtketluan_maxT.Text;
    
            // qmin T
            VFD_minT1 = float.Parse(txtVFD_minT1.Text);
            VREF_minT1 = float.Parse(txtVREF_minT1.Text);

            VFD_minT2 = float.Parse(txtVFD_minT2.Text);
            VREF_minT2 = float.Parse(txtVREF_minT2.Text);
            delta_EFD_minT = EFD_minT1 - EFD_minT2;
            ketluan_minT = txtketluan_minT.Text;
           
            //max sau
            VFD_maxS1 = float.Parse(txtVFD_maxS1.Text);
            VREF_maxS1 = float.Parse(txtVREF_maxS1.Text);

            VFD_maxS2 = float.Parse(txtVFD_maxS2.Text);
            VREF_maxS2 = float.Parse(txtVREF_maxS2.Text);
            delta_EFD_maxS = EFD_maxS1 - EFD_maxS2;
            ketluan_maxS = txtketluan_maxS.Text;
            
            // min sau 
            VFD_minS1 = float.Parse(txtVFD_minS1.Text);
            VREF_minS1 = float.Parse(txtVREF_minS1.Text);

            VFD_minS2 = float.Parse(txtVFD_minS2.Text);
            VREF_minS2 = float.Parse(txtVREF_minS2.Text);
            delta_EFD_minS = EFD_minS1 = EFD_minS2;
            ketluan_minS = txtketluan_minS.Text;
            
        }
        public void anhxa_kythuat()
        {
            if(rdokiemtrasobo.Checked ==true)
            {
                kt_sobo = "Đạt";
            }
            if (rdokiemtrasobo_kodat.Checked == true)
            {
                kt_sobo = "Không";
            }
            if (rdokiemtradokin.Checked == true)
            {
                kt_dokin = "Đạt";
            }
            if (rdokiemtradokin_kodat.Checked == true)
            {
                kt_dokin = "Không";
            }
            if (rdokiemtrahdccxs.Checked == true)
            {
                kt_hoatdongccxs = "Đạt";
            }
            if (rdokiemtrahdccxs_kodat.Checked == true)
            {
                kt_hoatdongccxs = "Không";
            }
            if (rdoktcocautn.Checked == true)
            {
                kt_cocautungat = "Đạt";
                
            }
            if (rdoktcocautn_kodat.Checked == true)
            {
                kt_cocautungat = "Không";

            }
            
        }
        public void anhxa_ktngoai()
        {
             //Nhãn Mác
            if (rdoktNM_dat.Checked == true)
            {
                KT_nhanmac = "Đạt";
            }
            if (rdoktNM_khongdat.Checked == true)
            {
                KT_nhanmac = "Không";
            }
             //Bộ phận chính
            if (rdochitietBPC_dat.Checked == true)
            {
                KT_bophanchinh = "Đạt";
            }
            if (rdochitietBPC_khongdat.Checked == true)
            {
                KT_bophanchinh = "Không";
            }
             //Kiểm tra kính
            if (rdokinhBVQS_dat.Checked == true)
            {
                KT_kinh = "Đạt";
            }
            if (rdokinhBVQS_khongdat.Checked == true)
            {
                KT_kinh = "Không";
            }
             //kiểm tra ống cao su
            if (rdoOngcaosu_dat.Checked == true)
            {
                KT_ongcs = "Đạt";
            }
            if (rdoOngcaosu_khongdat.Checked == true)
            {
                KT_ongcs = "Không";
            }


        }
        public void anhxa_cocautinhtien()
         {
             PFD_DT = float.Parse(txtPFD.Text);
             PPR_DT = float.Parse(txtPPR.Text);
             KL_GT = txtKLgiatien.Text;

             VFD_DT = float.Parse(txtVFD.Text);
             VPR_DT = float.Parse(txtVPR.Text);
             VREF_DT = float.Parse(txtVREF.Text);
             EFD_DT = float.Parse(txtEFD.Text);
             KL_TheTich = txtKLthetich.Text;

             VFD_TT = float.Parse(txtVFDtt.Text);
             PU_TT = float.Parse(txtPUtt.Text);
             PC_TT = float.Parse(txtPCtt.Text);
             PFD_TT = float.Parse(txtPFDtt.Text);
             EP_TT = float.Parse(txtEPtt.Text);
             KL_CCTT = txtKLcctt.Text;
         }
        public void anhxa_ongmem()
        {
            so_od = float.Parse(txt_chisodong.Text);
            if (rad_KL_CSD_Đ.Checked == true)
            {
                kl_so_od = "Đạt";
                check_kl_so_od_Đ = "X";
                check_kl_so_od_K = "";
            }
            if(rad_KL_CSD_K.Checked == true){
                kl_so_od = "Không";
                check_kl_so_od_Đ = "";
                check_kl_so_od_K = "X";
            }
            if (rad_KT_CCT_Co.Checked == true)
            {
                kt_cci = "Có";
            }
            if (rad_KT_CCT_Khong.Checked == true)
            {
                kt_cci = "Không";
            }
            vfd_1_OD = float.Parse(txt_VFD_OD_1.Text);
            pfd_1_OD = float.Parse(txt_PFD_OD_1.Text);
            luuluong_GN_1 = float.Parse(txt_luongGN_OD_1.Text);
            tien_tt1 = float.Parse(txt_TienThanhToan_1.Text);
            ketluan_1_OD = txt_KetLuan_CCI_1.Text;
            //
            vfd_2_OD = float.Parse(txt_VFD_OD_2.Text);
            pfd_2_OD = float.Parse(txt_PFD_OD_2.Text);
            luuluong_GN_2 = float.Parse(txt_luongGN_OD_2.Text);
            tien_tt2 = float.Parse(txt_TienThanhToan_2.Text);
            ketluan_2_OD = txt_KetLuan_CCI_2.Text;
            if (rad_CNI_Đ.Checked == true)
            {
                kt_cni = "Đạt";
                check_kt_cni_Đ = "X";
                check_kt_cni_K = "";
            }
            if (rad_CNI_K.Checked == true)
            {
                kt_cni = "không";
                check_kt_cni_Đ = "";
                check_kt_cni_K = "X";
            }
            if (rad_NDBG_Đ.Checked == true)
            {
                kt_nd = "Đạt";
                check_kt_nd_Đ = "X";
                check_kt_nd_K = "";
            }
            if (rad_NDBG_K.Checked == true)
            {
                kt_nd = "Không";
                check_kt_nd_Đ = "";
                check_kt_nd_K = "X";
            }


        }
        public void AnhXaThongTin_CDXD()
        {
            TenPhuongTien = txtTenPhuongTien.Text;
            CoSo_SX = txtCoSoSX.Text;
            CheDo_KD = txtCheDoKiemDinh.Text;
            ChatLong_KD = txtChatLongKiemDinh.Text;
            PhuongPhap_TH = txtPhuongPhapThucHien.Text;
            ChuanThietBi_SD = txtChuanThietBiSD.Text;
            DonVi_SD = txtDonViSD.Text;
            DiaChi_SD = txtDiaChiSD.Text;
            DiaDiem_TH = txtDiaDiemTH.Text;
            Kieu = int.Parse(txtKieu.Text);
            So = int.Parse(txtSo.Text);
            CapChinhXac = int.Parse(txtCapChinhXac.Text);
            Nam_SX = int.Parse(txtNamSX.Text);
            id_NV = int.Parse(cbxKiemDinhVien.SelectedValue.ToString());
            Ngay_KD = DateTime.Parse(txtNgayKiemDinh.Text);
            LuuLuong_Max = float.Parse(txtLuuLuongMax.Text);
            LuuLuong_Min = float.Parse(txtLuuLuongMin.Text);
            LuongCapPhat_Min = float.Parse(txtLuongCapPhatMin.Text);
        }
        public void AnhXaLuuLuongCPTT()
        {

            VFD_LLTT = float.Parse(txtVFD_CP.Text);
            VREF_LLTT = float.Parse(txtVREF_CP.Text);
            E_LLTT = float.Parse(txtE.Text);
            if (rbtD1DAT.Checked == true)
            {
                KL_LLTT = "Đạt";
            }
            else if (rbtD1KDAT.Checked == true)
            {
                KL_LLTT = "Không";
            }
            if (rbtD2MAT.Checked == true)
            {
                if (rbtMatDAT.Checked == true)
                {
                    KT_BangMat = "Đạt";
                }
                else if (rbtMatKDAT.Checked == true)
                {
                    KT_BangMat = "Không";
                }
            }
            else if (rbtD2MAT.Checked == false)
            {
                KT_BangMat = "Không dùng";
            }

            if (rbtD2ThietBi.Checked == true)
            {
                if (rbtThietBiDAT.Checked == true)
                {
                    KT_CoCauTK = "Đạt";
                    KL_TK = "Đạt";
                }
                else if (rbtThietBiKDAT.Checked == true)
                {
                    KT_CoCauTK = "Không";
                    KL_TK = "Không";
                }
            }
            else if (rbtD2ThietBi.Checked == false)
            {
                KT_CoCauTK = "Không dùng";
                KL_TK = "Không dùng";
            }

            QA_TK = float.Parse(txtQA.Text);
            VFD_TK = float.Parse(txtVFDThietBi.Text);
            VTEF_TK = float.Parse(txtVREFThietBi.Text);
            EFD_TK = float.Parse(txtEFDThietBi.Text);
            ED_TK = float.Parse(txtEDThietBi.Text);


        }
        private void txtEAV_maxT_Click(object sender, EventArgs e)
        {
            
            double kq = (EFD_maxT1 + EFD_maxT2)/2;
            EAV_maxT =Convert.ToSingle(kq);
            txtEAV_maxT.Text = EAV_maxT.ToString();
        }

        private void txtEFD_minT1_Click(object sender, EventArgs e)
        { //  EFD_maxT2 = (100 * (VFD_maxT2 - VREF_maxT2)) / VREF_maxT2;
            VFD_minT1 = float.Parse(txtVFD_minT1.Text);
            VREF_minT1 = float.Parse(txtVREF_minT1.Text);
            EFD_minT1 = (100 * (VFD_minT1 - VREF_minT1)) / VREF_minT1;
            txtEFD_minT1.Text = EFD_minT1.ToString();

        }

        private void txtEFD_minT2_Click(object sender, EventArgs e)
        {
            VFD_minT2 = float.Parse(txtVFD_minT2.Text);
            VREF_minT2 = float.Parse(txtVREF_minT2.Text);
            EFD_minT2 = (100 * (VFD_minT2 - VREF_minT2)) / VREF_minT2;
            txtEFD_minT2.Text = EFD_minT2.ToString();
        }

        private void txtEAV_minT_Click(object sender, EventArgs e)
        {
            double kq = (EFD_minT1 + EFD_minT2) / 2;
            EAV_minT = Convert.ToSingle(kq);
            txtEAV_minT.Text = EAV_minT.ToString();
        }

        private void txtEFD_maxS1_Click(object sender, EventArgs e)
        {//  EFD_maxT2 = (100 * (VFD_maxT2 - VREF_maxT2)) / VREF_maxT2;
            VFD_maxS1 = float.Parse(txtVFD_maxS1.Text);
            VREF_maxS1 = float.Parse(txtVREF_maxS1.Text);
            EFD_maxS1 = (100 * (VFD_maxS1 - VREF_maxS1)) / VREF_maxS1;
            txtEFD_maxS1.Text = EFD_maxT1.ToString();
        }

        private void txtEFD_maxS2_Click(object sender, EventArgs e)
        {
            VFD_maxS2 = float.Parse(txtVFD_maxS2.Text);
            VREF_maxS2 = float.Parse(txtVREF_maxS2.Text);
            EFD_maxS2 = (100 * (VFD_maxS2 - VREF_maxS2)) / VREF_maxS2;
            txtEFD_maxS2.Text = EFD_maxS2.ToString();
        }

        private void txtEAV_maxS_Click(object sender, EventArgs e)
        {
            double kq = (EFD_maxT1 + EFD_maxS2) / 2;
            EAV_maxS = Convert.ToSingle(kq);
            txtEAV_maxS.Text = EAV_maxS.ToString();
        }

        private void txtEFD_minS1_Click(object sender, EventArgs e)
        {
            VFD_minS1 = float.Parse(txtVFD_minS1.Text);
            VREF_minS1 = float.Parse(txtVREF_minS1.Text);
            EFD_minS1 = (100 * (VFD_minS1 - VREF_minS1)) / VREF_minS1;
            txtEFD_minS1.Text = EFD_minS1.ToString();
        }

        private void txtEFD_minS2_Click(object sender, EventArgs e)
        {
            VFD_minS2 = float.Parse(txtVFD_minS2.Text);
            VREF_minS2 = float.Parse(txtVREF_minS2.Text);
            EFD_minS2 = (100 * (VFD_minS2 - VREF_minS2)) / VREF_minS2;
            txtEFD_minS2.Text = EFD_minS2.ToString();
        }

        private void txtEAV_minS_Click(object sender, EventArgs e)
        {
            double kq = (EFD_minS1 + EFD_minS2) / 2;
            EAV_minS = Convert.ToSingle(kq);
            txtEAV_minS.Text = EAV_minS.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tem = int.Parse(txt_tem.Text);
            if (Tem_BUS.TIM_TEM(tem) == false)
            {
                MessageBox.Show("Tem Này Đã Tồn Tại");
                btn_luu_TEM.Enabled = false;
                button7.Enabled = false;
            }
            else
            {
                MessageBox.Show("Tem Này Chưa Được Sử Dụng");
                btn_luu_TEM.Enabled = true;
            }
        }

        private void btn_luu_TEM_Click(object sender, EventArgs e)
        {
          int  tem_v2 = int.Parse(txt_tem.Text);
            if (Tem_BUS.THEM_TEM(tem) == false)
            {
                MessageBox.Show("Không Thể Lưu Tem");
            }
            else
            {
                tem = int.Parse(txt_tem.Text);
                MessageBox.Show("Đã Lưu Tem");
                button7.Enabled = true;

            }

        }


        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Nhập thông tin chung")
            {

                AnhXaThongTin_CDXD();
                thongtin_cdxd thongtin_cdxd = new thongtin_cdxd();
                thongtin_cdxd.ID_CDXD = ma;
                thongtin_cdxd.TENPHUONGTIEN = TenPhuongTien;
                thongtin_cdxd.CS_SX = CoSo_SX;
                thongtin_cdxd.CHEDO_KD = CheDo_KD;
                thongtin_cdxd.PHUONGPHAP_TH = PhuongPhap_TH;
                thongtin_cdxd.CHUANTHIETBI_SD = ChuanThietBi_SD;
                thongtin_cdxd.DONVI_SD = DonVi_SD;
                thongtin_cdxd.DIACHI_SD = DiaChi_SD;
                thongtin_cdxd.DIADIEM_TH = DiaDiem_TH;
                thongtin_cdxd.kieu = Kieu;
                thongtin_cdxd.so = So;
                thongtin_cdxd.CAPCHINHXAC = CapChinhXac;
                thongtin_cdxd.NAM_SX = Nam_SX;
                thongtin_cdxd.ID_NV = id_NV;
                thongtin_cdxd.NGAY_KD = Ngay_KD;
                thongtin_cdxd.LUULUONG_MAX = LuuLuong_Max;
                thongtin_cdxd.LUULUONG_MIN = LuuLuong_Min;
                thongtin_cdxd.LUONGCAPPHAT_MIN = LuongCapPhat_Min;
                thongtin_cdxd.CHATLONG_KD = ChatLong_KD;

                if (ThongTinCDXD_BUS.Edit_ThongTinCDXD(thongtin_cdxd, ma) == false)
                {
                    MessageBox.Show("Sửa không thành công");

                }
                else
                {
                    MessageBox.Show("Chỉnh sửa thành công");
                    button6.Enabled = true;
                }
            }
                if (tabControl1.SelectedTab.Text == "LL lớn nhất và sai số")
                {

                    anhxa_dluong();
                    DoLuong dl = new DoLuong();
                    //  dl.Id_doluong = ma;
                    dl.Tg_capphat = tgcapphat;
                    dl.Sothetich = sochithetich;
                    dl.Luuluong_qmax = luuluongQmaxmin;
                    dl.ketLuan_qmax = ketluan_tgcp;

                    dl.vfd_max_t1 = VFD_maxT1;
                    dl.vref_max_t1 = VREF_maxT1;
                    dl.efd_max_t1 = EFD_maxT1;
                    dl.vfd_max_t2 = VFD_maxT2;
                    dl.vref_max_t2 = VREF_maxT2;
                    dl.efd_max_t2 = EFD_maxT2;
                    dl.delta_EFD_maxT = delta_EFD_maxT;
                    dl.eav_max_t = EAV_maxT;
                    dl.Ketluan_qmax_t = ketluan_maxT;
                    // min t
                    dl.vfd_min_t1 = VFD_minT1;
                    dl.vref_min_t1 = VREF_minT1;
                    dl.efd_min_t1 = EFD_minT1;
                    dl.vfd_min_t2 = VFD_minT2;
                    dl.vref_min_t2 = VREF_minT2;
                    dl.efd_min_t2 = EFD_minT2;
                    dl.delta_EFD_minT = delta_EFD_minT;
                    dl.eav_min_t = EAV_minT;
                    dl.Ketluan_qmin_t = ketluan_minT;
                    // max s
                    dl.vfd_max_s1 = VFD_maxS1;
                    dl.vref_max_s1 = VREF_maxS1;
                    dl.efd_max_s1 = EFD_maxS1;
                    dl.vfd_max_s2 = VFD_maxS2;
                    dl.vref_max_s2 = VREF_maxS2;
                    dl.efd_max_s2 = EFD_maxS2;
                    dl.delta_EFD_maxS = delta_EFD_maxS;
                    dl.eav_max_s = EAV_maxS;
                    dl.Ketluan_qmax_s = ketluan_maxS;
                    // min s
                    dl.vfd_min_s1 = VFD_minS1;
                    dl.vref_min_s1 = VREF_minS1;
                    dl.efd_min_s1 = EFD_minS1;
                    dl.vfd_min_s2 = VFD_minS2;
                    dl.vref_min_s2 = VREF_minS2;
                    dl.efd_min_s2 = EFD_minS2;
                    dl.delta_EFD_minS = delta_EFD_minS;
                    dl.eav_min_s = EAV_minS;
                    dl.Ketluan_qmin_s = ketluan_minS;
                    if (DoLuong_BUS.EDIT_DOLUONG(dl, ma) == false)
                    {
                        MessageBox.Show(" Chỉnh Sửa Không  Thành Công");

                    }
                    else
                    {
                        if (ketluan_maxT == "Đạt" && ketluan_minT == "Đạt" && ketluan_maxS == "Đạt" && ketluan_minS == "Đạt" && ketluan_tgcp == "Đạt")
                        { flag = true; }
                        else { flag = false; }
                        MessageBox.Show("Chỉnh Sửa Thành Công");
                        button6.Enabled = true;

                    }

                }
                // kiem tra ngoai
                if (tabControl1.SelectedTab.Text == "KT bên ngoài")
                {
                    anhxa_ktngoai();
                    KTNgoai_DTO ktn = new KTNgoai_DTO();
                    // ktn.id_bn = ma;
                    ktn.KT_nhanmac = KT_nhanmac;
                    ktn.KT_bophanchinh = KT_bophanchinh;
                    ktn.KT_kinh = KT_kinh;
                    ktn.KT_ongcs = KT_ongcs;
                    if (KTNgoai_BUS.Edit_KTNgoai(ktn, ma) == false)
                    {
                        MessageBox.Show("Sửa Không Thành Công");
                    }
                    else
                    {
                        MessageBox.Show("Chỉnh Sửa Thành Công");
                        if (KT_nhanmac == "Đạt" && KT_bophanchinh == "Đạt" && KT_kinh == "Đạt" && KT_ongcs == "Đạt")
                        { flag = true; }
                        else { flag = false; }
                    }

                }
            // chức năng Sửa Kiểm tra kĩ thuật
             if (tabControl1.SelectedTab.Text=="KT kỹ thuật")
             {
                 anhxa_kythuat();
                 KTKyThuat_DTO ktk = new KTKyThuat_DTO();
                 ktk.kt_sobo = kt_sobo;
                 ktk.kt_dokin = kt_dokin;
                 ktk.kt_hoatdongccxs = kt_hoatdongccxs;
                 ktk.kt_cocautungat = kt_cocautungat;
                 if (KTKyThuat_BUS.Edit_KTKyThuat(ktk ,ma)==false)
                 {
                     MessageBox.Show("Sửa Không Thành Công");
                 }
                 else
                 {
                     MessageBox.Show("Chỉnh Sửa Thành Công");
                     if (kt_sobo == "Đạt" && kt_dokin == "Đạt" && kt_hoatdongccxs == "Đạt" && kt_cocautungat == "Đạt")
                     { flag = true; }
                     else { flag = false; }
                 }

             }
                // 
                if (tabControl1.SelectedTab.Text == "Cơ cấu đặt trước, tính tiền")
                {
                    anhxa_cocautinhtien();
                    KT_CCTT kt = new KT_CCTT();
                    kt.Pfd_dt = PFD_DT;
                    kt.Ppr_dt = PPR_DT;
                    kt.Kl_gt = KL_GT;
                    kt.Vfd_dt = VFD_DT;
                    kt.Vpr_dt = VPR_DT;
                    kt.Vref_dt = VREF_DT;
                    kt.Efd_dt = EFD_DT;
                    kt.Kl_thetich = KL_TheTich;
                    kt.Vfd_tt = VFD_TT;
                    kt.Pu_tt = PU_TT;
                    kt.Pc_tt = PC_TT;
                    kt.Pfd_tt = PFD_TT;
                    kt.Ep_tt = EP_TT;
                    kt.Kl_cctt = KL_CCTT;
                    if (KT_CCTT_BUS.Edit_CCTT(kt, ma) == true)
                    {
                        MessageBox.Show("Sửa Thành Công");
                        if (KL_GT == "Đạt" && KL_TheTich == "Đạt" && KL_CCTT == "Đạt")
                        { flag = true; }
                        else { flag = false; }
                    }
                    else
                    {

                        MessageBox.Show("Sửa Không Thành Công");


                    }
                }
                if (tabControl1.SelectedTab.Text == "Ống mềm, in")
                {
                    anhxa_ongmem();
                    OngMem_In_DTO om = new OngMem_In_DTO();
                    //   om.ID_OM_CCI = ma;
                    om.SO_OD = so_od;
                    om.KL_SO_OD = kl_so_od;
                    om.KT_CCI = kt_cci;
                    om.VFD_1_OD = vfd_1_OD;
                    om.PFD_1_OD = pfd_1_OD;
                    om.LuuLuong_GN_1 = luuluong_GN_1;
                    om.Tien_TT_1 = tien_tt1;
                    om.Ket_Luan_1_OD = ketluan_1_OD;
                    om.VFD_2_OD = vfd_2_OD;
                    om.PFD_2_OD = pfd_2_OD;
                    om.LuuLuong_GN_2 = luuluong_GN_2;
                    om.Tien_TT_2 = tien_tt2;
                    om.Ket_Luan_2_OD = ketluan_2_OD;
                    om.KT_CNI = kt_cni;
                    om.KT_ND = kt_nd;
                    if (OngMem_BUS.Edit_OM(om, ma) == false)
                    {
                        MessageBox.Show("Sửa Không Thành Công");
                    }
                    else
                    {
                        MessageBox.Show("Đã Sửa");
                        if (kl_so_od == "Đạt" && ketluan_1_OD == "Đạt" && ketluan_2_OD == "Đạt" && kt_cni == "Đạt" && kt_nd == "Đạt")
                        { flag = true; }
                        else { flag = false; }
                    }
                }
                if (tabControl1.SelectedTab.Text == "Cấp phát tối thiểu, tách khí")
                {
                    AnhXaLuuLuongCPTT();
                    LuuLuongCPTT LL_CPTT = new LuuLuongCPTT();
                    LL_CPTT.ID_LLTT = ma;
                    LL_CPTT.vfd_lltt = VFD_LLTT;
                    LL_CPTT.vref_lltt = VREF_LLTT;
                    LL_CPTT.e_lltt = E_LLTT;
                    LL_CPTT.kl_lltt = KL_LLTT;
                    LL_CPTT.kt_cocauTK = KT_CoCauTK;
                    LL_CPTT.kt_bangmat = KT_BangMat;
                    LL_CPTT.qa_tk = QA_TK;
                    LL_CPTT.vfd_tk = VFD_TK;
                    LL_CPTT.vtef_tk = VTEF_TK;
                    LL_CPTT.efd_tk = EFD_TK;
                    LL_CPTT.ed_tk = ED_TK;
                    LL_CPTT.kl_tk = KL_TK;
                    if (LuuLuongCPTT_BUS.Fix_LuuLuongCPTT(LL_CPTT, ma) == false)
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                    else
                    {
                        MessageBox.Show("Đã sửa");
                        button6.Enabled = true;
                    }
                }
        }

        

        private void btn_tim_Click(object sender, EventArgs e)
        {
            if (ThongTinCDXD_BUS.Xem_ThongTinCDXD(txt_tim.Text) == null)
            {
                MessageBox.Show("Không tìm thấy");
            }
            else
            {
                MessageBox.Show("Tìm Thấy");
                btn_Edit.Enabled = false;
                thongtin_cdxd tt_cdxd = ThongTinCDXD_BUS.Xem_ThongTinCDXD(txt_tim.Text);
                txtTenPhuongTien.Text = tt_cdxd.TENPHUONGTIEN.ToString();
                txtKieu.Text = tt_cdxd.kieu.ToString();
                txtSo.Text = tt_cdxd.so.ToString();
                txtCapChinhXac.Text = tt_cdxd.CAPCHINHXAC.ToString();
                txtNamSX.Text = tt_cdxd.NAM_SX.ToString();
                txtCoSoSX.Text = tt_cdxd.CS_SX.ToString();
                txtCheDoKiemDinh.Text = tt_cdxd.CHEDO_KD.ToString();
                txtNgayKiemDinh.Text = tt_cdxd.NGAY_KD.ToString();
                txtLuuLuongMax.Text = tt_cdxd.LUULUONG_MAX.ToString();
                txtLuuLuongMin.Text = tt_cdxd.LUULUONG_MIN.ToString();
                txtLuongCapPhatMin.Text = tt_cdxd.LUONGCAPPHAT_MIN.ToString();
                txtChatLongKiemDinh.Text = tt_cdxd.CHATLONG_KD.ToString();
                txtPhuongPhapThucHien.Text = tt_cdxd.PHUONGPHAP_TH.ToString();
                txtChuanThietBiSD.Text = tt_cdxd.CHUANTHIETBI_SD.ToString();
                txtDonViSD.Text = tt_cdxd.DONVI_SD.ToString();
                if (tt_cdxd.ID_NV.ToString() == "2")
                { cbxKiemDinhVien.Text = "Nguyến Hồng Phong"; }
                if (tt_cdxd.ID_NV.ToString() == "1") { cbxKiemDinhVien.Text = "Nguyến Tiến Trung"; }

                //cbxKiemDinhVien.Text = tt_cdxd.ID_NV.ToString();
                txtDiaChiSD.Text = tt_cdxd.DIACHI_SD.ToString();
                txtDiaDiemTH.Text = tt_cdxd.DIADIEM_TH.ToString();
               
                // do luong
                 DoLuong dl = DoLuong_BUS.Show_DOluong(txt_tim.Text);
                 txttg_capphat.Text = dl.Tg_capphat.ToString();
                 txtsochithetich.Text = dl.Sothetich.ToString();
                 txtluuluongQminmax.Text = dl.Luuluong_qmax.ToString();
                 // rad
                 if (dl.ketLuan_qmax == "Đạt")
                 {
                     radketluandat.Checked = true;
                 }
                 else
                 {
                     radketluanKHONGdat.Checked = true;
                 }
                 txtVFD_maxT1.Text = dl.vfd_max_t1.ToString();
                 txtVREF_maxT1.Text = dl.vref_max_t1.ToString();
                 txtEFD_maxT1.Text = dl.efd_max_t1.ToString();
                 txtVFD_maxT2.Text = dl.vfd_max_t2.ToString();
                 txtVREF_maxT2.Text = dl.vref_max_t2.ToString();
                 txtEFD_maxT2.Text = dl.efd_max_t2.ToString();
                 txtEAV_maxT.Text = dl.eav_max_s.ToString();
                 txtketluan_maxT.Text = dl.Ketluan_qmax_t ;

                 txtVFD_minT1.Text = dl.vfd_min_t1.ToString();
                 txtVREF_minT1.Text = dl.vref_min_t1.ToString();
                 txtEFD_minT1.Text = dl.efd_min_t1.ToString();
                 txtVFD_minT2.Text = dl.vfd_min_t2.ToString();
                 txtVREF_minT2.Text = dl.vref_min_t2.ToString();
                 txtEFD_minT2.Text = dl.efd_min_t2.ToString();
                 txtEAV_minT.Text = dl.eav_min_t.ToString();
                 txtketluan_minT.Text =dl.Ketluan_qmin_t  ;

                 txtVFD_maxS1.Text = dl.vfd_max_s1.ToString();
                 txtVREF_maxS1.Text = dl.vref_max_s1.ToString();
                 txtEFD_maxS1.Text = dl.efd_max_s1.ToString();
                 txtVFD_maxS2.Text = dl.vfd_max_s2.ToString();
                 txtVREF_maxS2.Text = dl.vref_max_s2.ToString();
                 txtEFD_maxS2.Text = dl.efd_max_s2.ToString();
                 txtEAV_maxS.Text = dl.eav_max_s.ToString();
                 txtketluan_maxS.Text =dl.Ketluan_qmax_s  ;

                 txtVFD_minS1.Text = dl.vfd_min_s1.ToString();
                 txtVREF_minS1.Text = dl.vref_min_s1.ToString();
                 txtEFD_minS1.Text = dl.efd_min_s1.ToString();
                 txtVFD_minS2.Text = dl.vfd_min_s2.ToString();
                 txtVREF_minS2.Text = dl.vref_min_s2.ToString();
                 txtEFD_minS2.Text = dl.efd_min_s2.ToString();
                 txtEAV_minS.Text = dl.eav_min_s.ToString();
                 txtketluan_minS.Text = dl.Ketluan_qmin_s;
                


                 // KT NGAOI
                 KTNgoai_DTO ktn = KTNgoai_BUS.Show_KTNgoai(txt_tim.Text);

                 if (ktn.KT_nhanmac == "Đạt")
                 {
                     rdoktNM_dat.Checked = true;

                 }
                 else
                 {
                     rdoktNM_khongdat.Checked = true;
                 }
                 if (ktn.KT_bophanchinh == "Đạt")
                 {
                     rdochitietBPC_dat.Checked = true;

                 }
                 else
                 {
                     rdochitietBPC_khongdat.Checked = true;
                 }
                 if (ktn.KT_kinh == "Đạt")
                 {
                     rdokinhBVQS_dat.Checked = true;

                 }
                 else
                 {
                     rdokinhBVQS_khongdat.Checked = true;
                 }
                 if (ktn.KT_ongcs == "Đạt")
                 {
                     rdoOngcaosu_dat.Checked = true;

                 }
                 else
                 {
                     rdoOngcaosu_khongdat.Checked = true;
                 }

                 //tìm kím kiểm tra kĩ thuật
              /*   KTKyThuat_DTO ktk = KTKyThuat_BUS.Show_KTKyThuat(txt_tim.Text);
                 if (ktk.kt_sobo == "Đạt")
                 {
                     rdokiemtrasobo.Checked = true;
                 }
                 else
                 {
                     rdokiemtrasobo_kodat.Checked = true;
                 }
                 if (ktk.kt_dokin == "Đạt")
                 {
                     rdokiemtradokin.Checked = true;
                 }
                 else
                 {
                     rdokiemtradokin_kodat.Checked = true;
                 }
                 if (ktk.kt_hoatdongccxs == "Đạt")
                 {
                     rdokiemtrahdccxs.Checked = true;
                 }
                 else
                 {
                     rdokiemtrahdccxs_kodat.Checked = true;
                 }
                 if (ktk.kt_cocautungat == "Đạt")
                 {
                     rdoktcocautn.Checked = true;
                 }
                 else
                 {
                     rdoktcocautn_kodat.Checked = true;
                 }

                */

                 // CCTT

                 KT_CCTT kt = KT_CCTT_BUS.Show_CCTT(txt_tim.Text);
                 txtPFD.Text = kt.Pfd_dt.ToString();
                 txtPPR.Text = kt.Ppr_dt.ToString();
                 txtKLgiatien.Text = kt.Kl_gt;
                 txtVFD.Text = kt.Vfd_dt.ToString();
                 txtVPR.Text = kt.Vpr_dt.ToString();
                 txtVREF.Text = kt.Vref_dt.ToString();
                 txtEFD.Text = kt.Efd_dt.ToString();
                 txtKLthetich.Text = kt.Kl_thetich;
                 txtVFDtt.Text = kt.Vfd_tt.ToString();
                 txtPUtt.Text = kt.Pu_tt.ToString();
                 txtPCtt.Text = kt.Pc_tt.ToString();
                 txtPFDtt.Text = kt.Pfd_tt.ToString();
                 txtEPtt.Text = kt.Ep_tt.ToString();
                 txtKLcctt.Text = kt.Kl_cctt.ToString();


             // ong mem
                OngMem_In_DTO om = OngMem_BUS.show_OM(txt_tim.Text);
                txt_chisodong.Text = om.SO_OD.ToString() ;
                if(om.KL_SO_OD == "Đạt"){
                     rad_KL_CSD_Đ.Checked = true;
                }
                else  rad_KL_CSD_K.Checked = true;
               if(om.KT_CCI == "Có"){
                     rad_KT_CCT_Co.Checked = true;
                }
                else  rad_KT_CCT_Khong.Checked = true;
              
                txt_VFD_OD_1.Text =  om.VFD_1_OD.ToString();
                txt_PFD_OD_1.Text = om.PFD_1_OD.ToString() ;
                txt_luongGN_OD_1.Text = om.LuuLuong_GN_1.ToString();
                txt_TienThanhToan_1.Text =om.Tien_TT_1.ToString() ;
                txt_KetLuan_CCI_1.Text = om.Ket_Luan_1_OD.ToString(); ;
                txt_VFD_OD_2.Text = om.VFD_2_OD.ToString();
                txt_PFD_OD_2.Text = om.PFD_2_OD.ToString();
                txt_luongGN_OD_2.Text =om.LuuLuong_GN_2.ToString() ;
                txt_TienThanhToan_2.Text = om.Tien_TT_2.ToString();
                txt_KetLuan_CCI_2.Text = om.Ket_Luan_2_OD.ToString();
                if (om.KT_CNI == "Đạt")
                {
                    rad_CNI_Đ.Checked = true;
                }
                else rad_CNI_K.Checked = true;
                if (om.KT_ND == "Đạt")
                {
                    rad_NDBG_Đ.Checked = true;
                }
                else rad_NDBG_K.Checked = true;

                // cap phat toi thieu
                LuuLuongCPTT LL_CPTT = LuuLuongCPTT_BUS.Xem_LuuLuongCPTT(txt_tim.Text);
                txtVFD_CP.Text = LL_CPTT.vfd_lltt.ToString();
                txtVREF_CP.Text = LL_CPTT.vref_lltt.ToString();
                txtE.Text = LL_CPTT.e_lltt.ToString();
                if (LL_CPTT.kl_lltt == "Đạt")
                {
                    rbtD1DAT.Checked = true;
                }
                else
                {
                    rbtD1KDAT.Checked = true;
                }
                if (LL_CPTT.kt_cocauTK == "Đạt")
                {
                    rbtThietBiDAT.Checked = true;
                    rbtD2ThietBi.Checked = true;
                }
                else
                {
                    rbtThietBiKDAT.Checked = true;
                    rbtD2ThietBi.Checked = true;
                }
                if (LL_CPTT.kt_bangmat == "Đạt")
                {
                    rbtMatDAT.Checked = true;
                    rbtD2MAT.Checked = true;
                }
                else
                {
                    rbtMatKDAT.Checked = true;
                    rbtD2MAT.Checked = true;
                }

                txtQA.Text = LL_CPTT.qa_tk.ToString();
                txtVFDThietBi.Text = LL_CPTT.vfd_tk.ToString();
                txtVREFThietBi.Text = LL_CPTT.vtef_tk.ToString();
                txtEFDThietBi.Text = LL_CPTT.efd_tk.ToString();
                txtEDThietBi.Text = LL_CPTT.ed_tk.ToString();
            }


           
        }

        private void txt_tim_TextChanged(object sender, EventArgs e)
        {

        }

        private void radketluandat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtPCtt_Click_1(object sender, EventArgs e)
        {
            VFD_TT = float.Parse(txtVFDtt.Text);
            PU_TT = float.Parse(txtPUtt.Text);
            PC_TT = (VFD_TT * PU_TT);
            txtPCtt.Text = PC_TT.ToString();
        }

        private void txtEPtt_Click_1(object sender, EventArgs e)
        {
            PFD_TT = float.Parse(txtPFDtt.Text);
            PC_TT = float.Parse(txtPCtt.Text);
            EP_TT = (PFD_TT - PC_TT);
            txtEPtt.Text = EP_TT.ToString();
        }

        private void rad_KL_CSD_Đ_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtEFD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEFD_Click(object sender, EventArgs e)
        {
            VFD_DT = float.Parse(txtVFD.Text);
            VREF_DT = float.Parse(txtVREF.Text);
            EFD_DT = 100 * (VFD_DT - VREF_DT) / VREF_DT;
            txtEFD.Text = EFD_DT.ToString();

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearTextBoxesRadio();
            ma = TangMa.matutang();
            btn_Edit.Enabled = true;
        }

        private void txtVPR_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtE_Click(object sender, EventArgs e)
        {
            VFD_LLTT = float.Parse(txtVFD_CP.Text);
            VREF_LLTT = float.Parse(txtVREF_CP.Text);
            // float KQ = VFD_LLTT - VREF_LLTT;
            E_LLTT = VFD_LLTT - VREF_LLTT;
            txtE.Text = E_LLTT.ToString();
        }

        private void txtEFDThietBi_Click(object sender, EventArgs e)
        {
            VFD_TK = float.Parse(txtVFDThietBi.Text);
            VTEF_TK = float.Parse(txtVREFThietBi.Text);
            float KQEFD;
            // Math.Round(KQEFD, 2); 
            EFD_TK = KQEFD = 100 * (VFD_TK - VTEF_TK) / VTEF_TK;
            double two1 = Math.Round(EFD_TK, 2);
            txtEFDThietBi.Text = two1.ToString();
        }

        private void txtEDThietBi_Click(object sender, EventArgs e)
        {
            ED = (E_LLTT + EFD_TK) / 2;
            double two2 = Math.Round(ED, 2);
            txtEDThietBi.Text = two2.ToString();
        }

        private void txtVREF_CP_TextChanged(object sender, EventArgs e)
        {

        }


        
    }
}
