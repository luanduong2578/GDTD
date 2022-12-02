using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GDBH.DAO
{
    class BH_Hanthe_DAO
    {

        private static BH_Hanthe_DAO instance;

        public static BH_Hanthe_DAO Instance
        {
            get { if (instance == null) instance = new BH_Hanthe_DAO(); return BH_Hanthe_DAO.instance; }
            private set { BH_Hanthe_DAO.instance = value; }
        }
        private BH_Hanthe_DAO() { }

        public DataTable Load_TheBhyt(string datathang)
        {
            string query = string.Format("SELECT LOI, Thang,TENKP,MABN, NGVAO ,NGRA ,HOTEN, NAMSINH ,PHAI ,TUNGAY ,TUNGAY_TC , DENNGAY ,DENNGAY_TC , MAKQ_TC ,GHICHU_TC,  ID, CHECK_OK  FROM HSOFTDKBD.CDT_CHECKBHYT " +
                "WHERE " +
                "(SUBSTR(MATHE,0,2) NOT IN ('QN','CA') AND THANG = '" + datathang + "' AND TENKP != 'Khoa Sơ Sinh' AND CHECK_OK = '0' AND TUNGAY != TUNGAY_TC)" +
                "OR (SUBSTR(MATHE,0,2) NOT IN ('QN','CA') AND THANG = '" + datathang + "' AND TENKP != 'Khoa Sơ Sinh' AND CHECK_OK = '0' AND DENNGAY != DENNGAY_TC)" +
   
                "ORDER BY LOI ASC"); 
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable Load_Search_MABN(string datathang, string mabn)
        {
            string query = string.Format("SELECT LOI, Thang,TENKP,MABN, NGVAO ,NGRA ,HOTEN, NAMSINH ,PHAI ,TUNGAY ,TUNGAY_TC , DENNGAY ,DENNGAY_TC , MAKQ_TC ,GHICHU_TC,  ID, CHECK_OK  FROM HSOFTDKBD.CDT_CHECKBHYT " +
                "WHERE  THANG = '" + datathang + "' AND MABN LIKE '%" + mabn + "%'" +            
                "" +
                "ORDER BY LOI ASC");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable Load_Search_Hoten(string datathang, string mabn)
        {
            string query = string.Format("SELECT LOI, Thang,TENKP,MABN, NGVAO ,NGRA ,HOTEN, NAMSINH ,PHAI ,TUNGAY ,TUNGAY_TC , DENNGAY ,DENNGAY_TC , MAKQ_TC ,GHICHU_TC,  ID, CHECK_OK  FROM HSOFTDKBD.CDT_CHECKBHYT  " +
                "WHERE  THANG = '" + datathang + "' AND HOTEN LIKE '%" + mabn + "%'" +
                "" +
                "ORDER BY LOI ASC");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable Load_Tracuu(string datathang)
        {
            string query = string.Format("SELECT ID, HOTEN ,NAMSINH, MATHE FROM HSOFTDKBD.CDT_CHECKBHYT " +
                "WHERE THANG = '" + datathang + "'" +
                " AND MAKQ_TC  = '401' " +
                "");
            return DataProvider.Instance.ExecuteQuery(query);
        }


        public bool Insert_TheBhyt(string datathang)
        {
            string query = string.Format("insert into hsoftdkbd.CDT_CHECKBHYT (ID,MABN,HOTEN,NAMSINH,PHAI,NGVAO,NGRA, MATHE,KCBBD, TUNGAY, DENNGAY, TENKP, HOTENKHONGDAU) (select LL.ID, BN.MABN, BN.HOTEN, BN.NAMSINH, BN.PHAI, TO_CHAR(LL.NGAYVAO, 'DD_MM_YYYY_HH24:MI'), TO_CHAR(LL.NGAYRA, 'DD_MM_YYYY_HH24:MI'), SUBSTR(LL.SOTHE, 1, 15), SUBSTR(LL.SOTHE, 16, 20), TO_CHAR(LL.TUNGAY, 'DD/MM/YYYY'), TO_CHAR(LL.DENNGAY, 'DD/MM/YYYY'), LL.TENKP, BN.HOTENKDAU from HSOFTDKBD" + datathang +".v_m38ll LL INNER JOIN hsoftdkbd.BTDBN BN ON BN.MABN = LL.MABN where LL.ID NOT IN(SELECT ID FROM hsoftdkbd.CDT_CHECKBHYT))");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool Update_Thang_TheBhyt(string datathang)
        {
            string query = string.Format("UPDATE HSOFTDKBD.CDT_CHECKBHYT SET MAKQ_TC = '401', CHECK_OK = '0', THANG = '" + datathang +"' where THANG is null");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool Update_Tracuu_TheBhyt(string MAKQ_TC,string GHICHU_TC,string HOTEN_TC,string NAMSINH_TC,string GIOITINH_TC,string MATHE_TC,string KCBBD_TC, string TUNGAY_TC, string DENNGAY_TC, string HOTENKHONGDAU_TC, string id)
        {
            string query = string.Format("UPDATE HSOFTDKBD.CDT_CHECKBHYT SET MAKQ_TC ='{0}', GHICHU_TC ='{1}', HOTEN_TC ='{2}', NAMSINH_TC ='{3}', GIOITINH_TC ='{4}', MATHE_TC ='{5}', KCBBD_TC ='{6}', TUNGAY_TC='{7}', DENNGAY_TC='{8}', HOTENKHONGDAU_TC = '{9}' where id = '{10}'", MAKQ_TC, GHICHU_TC, HOTEN_TC, NAMSINH_TC, GIOITINH_TC, MATHE_TC, KCBBD_TC, TUNGAY_TC, DENNGAY_TC, HOTENKHONGDAU_TC, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool Update_Tracuu_check(string id)
        {
            string query = string.Format("UPDATE HSOFTDKBD.CDT_CHECKBHYT SET CHECK_OK = '1' where id = '{0}'", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool Update_Tracuu_Loi(string loi, string id)
        {
            string query = string.Format("UPDATE HSOFTDKBD.CDT_CHECKBHYT SET LOI = '{0}' where id = '{1}'",loi, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
