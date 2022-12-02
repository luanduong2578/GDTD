using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GDBH.DAO
{
    class BsKham_DAO
    {

        private static BsKham_DAO instance;

        public static BsKham_DAO Instance
        {
            get { if (instance == null) instance = new BsKham_DAO(); return BsKham_DAO.instance; }
            private set { BsKham_DAO.instance = value; }
        }
        private BsKham_DAO() { }

        public DataTable Load_BsKham(string datathang)
        {
            //---BS DO QUOC THIEN HUONG  0156"
            //-- NGUYEN THI KIM TUYEN 0163 (sang da lieu - chieu noi)" +
            //-- TRAN THI QUYNH 0163 (sang Noi - chieu dl)" +
            string query = string.Format("" +

                "select distinct ll.mabn, (select bn.hoten from hsoftdkbd.btdbn bn where bn.mabn = ll.mabn) tenbn, (select kp.tenkp from  hsoftdkbd.btdkp_bv kp where ct.makp = kp.makp) as khoa_phong, ct.mavp, (select ten from hsoftdkbd.v_giavp vp where vp.id = ct.mavp) as ten_dvkt, (select dmt.ten from hsoftdkbd.d_dmbd dmt where ct.mavp = dmt.id) tenthuoc, (select hoten from hsoftdkbd.dmbs bs where bs.ma = ct.mabs) as bs_chi_dinh, to_char(ct.ngay, 'dd/mm/yyyy hh24:mi') gio_chidinh from " + datathang + ".v_m38ct ct inner join " + datathang + ".v_m38ll ll on ll.id = ct.id where(ct.mabs = '0156' AND(to_number(TO_CHAR(CT.ngay, 'HH24') * 60) + to_number(TO_CHAR(CT.ngay, 'MI'))) >= 300 AND(to_number(TO_CHAR(CT.ngay, 'HH24') * 60) + to_number(TO_CHAR(CT.ngay, 'MI'))) < 510 AND CT.MAKP IN('132', '133') AND CT.ngay >= to_date('13/07/2022 00:00', 'dd/MM/yyyy hh24:mi')) OR(ct.mabs = '0156' AND(to_number(TO_CHAR(CT.ngay, 'HH24') * 60) + to_number(TO_CHAR(CT.ngay, 'MI'))) >= 570 AND(to_number(TO_CHAR(CT.ngay, 'HH24') * 60) + to_number(TO_CHAR(CT.ngay, 'MI'))) < 630 AND CT.MAKP IN('132', '133') AND CT.ngay >= to_date('13/07/2022 00:00', 'dd/MM/yyyy hh24:mi')) OR(ct.mabs = '0156' AND(to_number(TO_CHAR(CT.ngay, 'HH24') * 60) + to_number(TO_CHAR(CT.ngay, 'MI'))) >= 780 AND(to_number(TO_CHAR(CT.ngay, 'HH24') * 60) + to_number(TO_CHAR(CT.ngay, 'MI'))) < 840 AND CT.MAKP IN('132', '133') AND CT.ngay >= to_date('13/07/2022 00:00', 'dd/MM/yyyy hh24:mi')) OR(ct.mabs = '0156' AND(to_number(TO_CHAR(CT.ngay, 'HH24') * 60) + to_number(TO_CHAR(CT.ngay, 'MI'))) >= 900 AND(to_number(TO_CHAR(CT.ngay, 'HH24') * 60) + to_number(TO_CHAR(CT.ngay, 'MI'))) < 1100 AND CT.MAKP IN('132', '133') AND CT.ngay >= to_date('13/07/2022 00:00', 'dd/MM/yyyy hh24:mi')) OR(ct.mabs = '0156' AND(to_number(TO_CHAR(CT.ngay, 'HH24') * 60) + to_number(TO_CHAR(CT.ngay, 'MI'))) >= 510 AND(to_number(TO_CHAR(CT.ngay, 'HH24') * 60) + to_number(TO_CHAR(CT.ngay, 'MI'))) <= 570 AND CT.MAKP NOT IN('132', '133') AND CT.ngay >= to_date('13/07/2022 00:00', 'dd/MM/yyyy hh24:mi')) OR(ct.mabs = '0156' AND(to_number(TO_CHAR(CT.ngay, 'HH24') * 60) + to_number(TO_CHAR(CT.ngay, 'MI'))) >= 630 AND(to_number(TO_CHAR(CT.ngay, 'HH24') * 60) + to_number(TO_CHAR(CT.ngay, 'MI'))) <= 650 AND CT.MAKP NOT IN('132', '133') AND CT.ngay >= to_date('13/07/2022 00:00', 'dd/MM/yyyy hh24:mi')) OR(ct.mabs = '0156' AND(to_number(TO_CHAR(CT.ngay, 'HH24') * 60) + to_number(TO_CHAR(CT.ngay, 'MI'))) >= 840 AND(to_number(TO_CHAR(CT.ngay, 'HH24') * 60) + to_number(TO_CHAR(CT.ngay, 'MI'))) <= 900 AND CT.MAKP NOT IN('132', '133') AND CT.ngay >= to_date('13/07/2022 00:00', 'dd/MM/yyyy hh24:mi'))" +

                "UNION ALL select distinct ll.mabn,(select bn.hoten from hsoftdkbd.btdbn bn where bn.mabn = ll.mabn) tenbn, (select kp.tenkp from  hsoftdkbd.btdkp_bv kp where  ct.makp = kp.makp) as khoa_phong, ct.mavp, (select ten from hsoftdkbd.v_giavp vp where vp.id= ct.mavp) as ten_dvkt, (select dmt.ten from hsoftdkbd.d_dmbd dmt where ct.mavp = dmt.id) tenthuoc, (select hoten from hsoftdkbd.dmbs bs where bs.ma = ct.mabs) as bs_chi_dinh, to_char(ct.ngay,'dd/mm/yyyy hh24:mi') gio_chidinh from " + datathang + ".v_m38ct ct inner join " + datathang + ".v_m38ll ll on ll.id = ct.id where (ct.mabs = '0163' AND (to_number(TO_CHAR(CT.ngay,'HH24')*60) + to_number(TO_CHAR(CT.ngay,'MI'))) >= 300 AND (to_number(TO_CHAR(CT.ngay,'HH24')*60) + to_number(TO_CHAR(CT.ngay,'MI'))) <=750 AND CT.MAKP NOT IN ( '132', '133')) OR (ct.mabs = '0163' AND (to_number(TO_CHAR(CT.ngay,'HH24')*60) + to_number(TO_CHAR(CT.ngay,'MI'))) >= 780 AND (to_number(TO_CHAR(CT.ngay,'HH24')*60) + to_number(TO_CHAR(CT.ngay,'MI'))) <=990 AND CT.MAKP IN ( '132', '133'))" +

                "UNION ALL select distinct ll.mabn,(select bn.hoten from hsoftdkbd.btdbn bn where bn.mabn = ll.mabn) tenbn, (select kp.tenkp from  hsoftdkbd.btdkp_bv kp where  ct.makp = kp.makp) as khoa_phong, ct.mavp, (select ten from hsoftdkbd.v_giavp vp where vp.id= ct.mavp) as ten_dvkt, (select dmt.ten from hsoftdkbd.d_dmbd dmt where ct.mavp = dmt.id) tenthuoc, (select hoten from hsoftdkbd.dmbs bs where bs.ma = ct.mabs) as bs_chi_dinh, to_char(ct.ngay,'dd/mm/yyyy hh24:mi') gio_chidinh from " + datathang + ".v_m38ct ct inner join " + datathang + ".v_m38ll ll on ll.id = ct.id where (ct.mabs = '0161' AND (to_number(TO_CHAR(CT.ngay,'HH24')*60) + to_number(TO_CHAR(CT.ngay,'MI'))) >= 300 AND (to_number(TO_CHAR(CT.ngay,'HH24')*60) + to_number(TO_CHAR(CT.ngay,'MI'))) <=750 AND CT.MAKP  IN ( '132', '133') AND CT.ngay >= to_date('13/07/2022 00:00','dd/MM/yyyy hh24:mi')) OR (ct.mabs = '0161' AND (to_number(TO_CHAR(CT.ngay,'HH24')*60) + to_number(TO_CHAR(CT.ngay,'MI'))) >= 780 AND (to_number(TO_CHAR(CT.ngay,'HH24')*60) + to_number(TO_CHAR(CT.ngay,'MI'))) <=990 AND CT.MAKP  not IN ( '132', '133') AND CT.ngay >= to_date('13/07/2022 00:00','dd/MM/yyyy hh24:mi'))" +
                "" +
                "" +
                ""); 
            return DataProvider.Instance.ExecuteQuery(query);
        }

    }
}
