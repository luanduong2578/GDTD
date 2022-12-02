using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GDBH.DAO
{
    class NG_Ngaygiuongdieutri_DA0
    {

        private static NG_Ngaygiuongdieutri_DA0 instance;

        public static NG_Ngaygiuongdieutri_DA0 Instance
        {
            get { if (instance == null) instance = new NG_Ngaygiuongdieutri_DA0(); return NG_Ngaygiuongdieutri_DA0.instance; }
            private set { NG_Ngaygiuongdieutri_DA0.instance = value; }
        }
        private NG_Ngaygiuongdieutri_DA0() { }

        public DataTable Load_Ngaygiuong(string datathang)
        {
            string dmgiuong = "(140113,140112,140111,140110,140109,140108,140106,140105,140104,140103,140102,140101,140100,140099,140098,140057,140056,140055,140054,140053,139336,139335,139334,139333,139244,139243,139242,139241,139240,139072,139058,139337,139240,139241,139242,139243,139244,139072,139058,128816,128814,128813,128812,128811,128810,128809,128807,128806,128805, 124277,94487, 2715, 	2716, 	2717, 	2718, 	2719, 	2720, 	2721, 	2722, 	2723, 	2724, 	2725, 	2726, 	2727, 	2728, 	2729, 	2730, 	2731, 	2732, 	2733, 	2734, 	2735, 	2736, 	2737, 	2738, 	2739, 	2740, 	2741, 	2742, 	2743, 	2744, 	2745, 	2746, 	2747, 	2748, 	2749, 	2750, 	2751, 	2752, 	2753, 	2754, 	2755, 	2756, 	2757, 	2758, 	2759, 	2760, 	2761, 	2762, 	2763, 	2764, 	2765, 	2766, 	2767, 	2768, 	2769, 	2770, 	2771, 	2772, 	2773, 	2774, 	2775, 	2776, 	2777, 	2778, 	2779, 	2780, 	2781, 	2782, 	2783, 	2784, 	2785, 	2786, 	2787, 	2788, 	2789, 	2790, 	2791, 	2792, 	2793, 	2794, 	106489, 	106490, 	106491, 	106492, 	106494, 106495, 	106496, 	106497, 	106498, 	106499, 	106503, 	106504, 	106505, 	106506, 	106507, 	106508, 	106509, 	106510, 	106511, 	106674, 	106675, 	106676, 	106677, 	106680, 	106681, 	106682, 	106683, 	106684, 	106685, 	106686, 	106687, 	106688, 	106689, 	106690, 	106691, 	112153)";

            string query = string.Format("select distinct    ll.mabn,     BN.HOTEN,KP.TENKP KHOAXV, TO_CHAR(LL.NGAYVAO,'DD_MM_YYYY_HH24:MI') NGAYVAO,TO_CHAR(LL.NGAYRA,'DD_MM_YYYY_HH24:MI') NGAYRA,     (trunc(ll.NGAYRA-ll.NGAYVAO)*24 + to_number(to_char(trunc(sysdate)+(ll.NGAYRA-ll.NGAYVAO),'HH24.MI'))) GIO_PHUT,    ll.ketqua,    ll.tinhtrang,    (trunc(ll.ngayra)- trunc(ll.ngayvao) +1) NGAYDT,    sum(ct.soluong) NGAYGIUONG from " + datathang + ".v_m38ct ct inner join " + datathang + ".v_m38ll ll on ct.id = ll.id INNER JOIN hsoftdkbd.btdkp_bv KP ON KP.MAKP = LL.MAKP INNER JOIN HSOFTDKBD.BTDBN BN ON BN.MABN = LL.MABN where ct.mavp in " + dmgiuong + " AND LL.ID NOT IN(SELECT ID FROM hsoftdkbd.CDT_CHECKNGAYGIUONG) group by ll.mabn, ll.id,BN.HOTEN,KP.TENKP, TO_CHAR(LL.NGAYVAO,'DD_MM_YYYY_HH24:MI'),TO_CHAR(LL.NGAYRA,'DD_MM_YYYY_HH24:MI'), (trunc(ll.NGAYRA-ll.NGAYVAO)*24 + to_number(to_char(trunc(sysdate)+(ll.NGAYRA-ll.NGAYVAO),'HH24.MI'))),ll.ketqua,ll.tinhtrang, (trunc(ll.ngayra)- trunc(ll.ngayvao) +1)" +
                "having ((ll.ketqua = 1 and (ll.tinhtrang = 1 or ll.tinhtrang = 3)) and ( sum(ct.soluong) >= (trunc(ll.ngayra)- trunc(ll.ngayvao) +1)))"+
                    "or ((ll.ketqua = 2 and (ll.tinhtrang = 1 or ll.tinhtrang = 3)) and ( sum(ct.soluong) >= (trunc(ll.ngayra)- trunc(ll.ngayvao) +1))) and (trunc(ll.NGAYRA-ll.NGAYVAO)*24 + to_number(to_char(trunc(sysdate)+(ll.NGAYRA-ll.NGAYVAO),'HH24.MI'))) > 24" +
                    "or ((ll.ketqua = 2 and (ll.tinhtrang = 1 or ll.tinhtrang = 3)) and ( sum(ct.soluong) >= (trunc(ll.ngayra)- trunc(ll.ngayvao) +1))) and (trunc(ll.NGAYRA-ll.NGAYVAO)*24 + to_number(to_char(trunc(sysdate)+(ll.NGAYRA-ll.NGAYVAO),'HH24.MI'))) > 24" +
                    "or ((ll.ketqua = 2 and (ll.tinhtrang = 1 or ll.tinhtrang = 3)) and ( sum(ct.soluong) > (trunc(ll.ngayra)- trunc(ll.ngayvao) +1))) and ((trunc(ll.NGAYRA-ll.NGAYVAO)*24 + to_number(to_char(trunc(sysdate)+(ll.NGAYRA-ll.NGAYVAO),'HH24.MI'))) < =4)" +
                    "or ((ll.ketqua = 3 and (ll.tinhtrang = 1 or ll.tinhtrang = 3)) and ( sum(ct.soluong) >= (trunc(ll.ngayra)- trunc(ll.ngayvao) +1))) and (trunc(ll.NGAYRA-ll.NGAYVAO)*24 + to_number(to_char(trunc(sysdate)+(ll.NGAYRA-ll.NGAYVAO),'HH24.MI'))) > 24" +
                    "or ((ll.ketqua = 3 and (ll.tinhtrang = 1 or ll.tinhtrang = 3)) and ( sum(ct.soluong) >= (trunc(ll.ngayra)- trunc(ll.ngayvao) +1))) and (trunc(ll.NGAYRA-ll.NGAYVAO)*24 + to_number(to_char(trunc(sysdate)+(ll.NGAYRA-ll.NGAYVAO),'HH24.MI'))) > 24" +
                    "or ((ll.ketqua = 3 and (ll.tinhtrang = 1 or ll.tinhtrang = 3)) and ( sum(ct.soluong) > (trunc(ll.ngayra)- trunc(ll.ngayvao) +1))) and ((trunc(ll.NGAYRA-ll.NGAYVAO)*24 + to_number(to_char(trunc(sysdate)+(ll.NGAYRA-ll.NGAYVAO),'HH24.MI'))) < =4)" + 
                    "or ((ll.ketqua = 3 and (ll.tinhtrang = 2 or ll.tinhtrang = 4)) and ( sum(ct.soluong) > (trunc(ll.ngayra)- trunc(ll.ngayvao) +1)))    " +
                    "or ((ll.ketqua = 4 and (ll.tinhtrang = 2 or ll.tinhtrang = 4)) and ( sum(ct.soluong) > (trunc(ll.ngayra)- trunc(ll.ngayvao) +1)))" +
                    "or ((ll.ketqua = 4 and ll.tinhtrang = 3) and ( sum(ct.soluong) >= (trunc(ll.ngayra)- trunc(ll.ngayvao) +1)))" +
                    "or ((ll.ketqua = 5 and ll.tinhtrang = 4) and ( sum(ct.soluong) > (trunc(ll.ngayra)- trunc(ll.ngayvao) +1)))" +
                ""); 
                
            return DataProvider.Instance.ExecuteQuery(query);
        }



    }
}
