using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GDBH.DAO
{
    class CongKham_DAO
    {

        private static CongKham_DAO instance;

        public static CongKham_DAO Instance
        {
            get { if (instance == null) instance = new CongKham_DAO(); return CongKham_DAO.instance; }
            private set { CongKham_DAO.instance = value; }
        }
        private CongKham_DAO() { }

        public DataTable Load_GiaCongKham(string datathang)
        {
            string query = string.Format("select ll.tenkp,ll.mabn, bn.hoten, ct.id, to_char(ll.ngayvao,'dd/MM/yyyy hh24:mi') ngayvao,to_char(ll.ngayra,'dd/MM/yyyy hh24:mi') ngayra, to_char(ct.ngay,'dd/MM/yyyy hh24:mi') ngaygio,ct.dongia ,CT.MAVP, ct.soluong, (select ten from hsoftdkbd.v_giavp vp where vp.id= ct.mavp) as ten_dvkt" +
            " from hsoftdkbd" + datathang + ".v_m38ct ct inner join hsoftdkbd" + datathang + ".v_m38ll ll on ll.id = ct.id inner join hsoftdkbd.btdbn bn on bn.mabn = ll.mabn" +
            " where ct.mavp in (62695,62696,62697,62698,62699,62700,62701,62702,62703,62704,62705,62706,62707,62708,62709) and ct.dongia not in (38700,11610, 3870)"+
            " order by ll.tenkp ");             
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable Load_NhieuCongKhamCungLoai(string datathang)
        {
            string query = string.Format("select ll.tenkp, ll.mabn, bn.hoten, ct.id, to_char(ll.ngayvao,'dd/MM/yyyy hh24:mi') ngayvao,to_char(ll.ngayra,'dd/MM/yyyy hh24:mi') ngayra ,CT.MAVP,(select ten from hsoftdkbd.v_giavp vp where vp.id= ct.mavp) as ten_dvkt, sum(ct.soluong) " +
                                         "from hsoftdkbd" + datathang + ".v_m38ct ct inner join hsoftdkbd" + datathang + ".v_m38ll ll on ll.id = ct.id inner join hsoftdkbd.btdbn bn on bn.mabn = ll.mabn " +
                                         "where ct.mavp in (62695,62696,62697,62698,62699,62700,62701,62702,62703,62704,62705,62706,62707,62708,62709) " +
                                         "group by ll.tenkp, ll.mabn, bn.hoten, ct.id, ll.ngayvao,ll.ngayra, CT.MAVP " +
                                         "having sum(ct.soluong) > 1 " +
                                         "order by ll.tenkp");             
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
