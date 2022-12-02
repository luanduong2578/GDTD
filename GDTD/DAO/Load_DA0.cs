using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GDBH.DAO
{
    class Load_DA0
    {

        private static Load_DA0 instance;

        public static Load_DA0 Instance
        {
            get { if (instance == null) instance = new Load_DA0(); return Load_DA0.instance; }
            private set { Load_DA0.instance = value; }
        }
        private Load_DA0() { }

        public string Load_ThangNam_HienTai()
        {
            DateTime now = DateTime.Now;
            string nam = (now.Year % 2000).ToString();
            string thang = now.Month.ToString();
            if (Convert.ToInt32(thang) < 10)
            {
                thang =  "0" + thang;
            }
            return thang + nam;
        }

        public bool KiemtraThangnam(string thangnam)
        {
            if (thangnam.Length == 4)
            {
                int thang = Convert.ToInt32(thangnam.Substring(0, 2));
                int nam = Convert.ToInt32(thangnam.Substring(2, 2));
                if (thang <= 12 & thang > 0)
                {
                    if (nam > 20 & nam < DateTime.Now.Year % 2000)
                    {
                        return true;
                    }
                    else if (nam == DateTime.Now.Year % 2000)
                    {
                        if (thang <= DateTime.Now.Month)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }



        public bool KiemtraThangnamBHYT(string thangnam)
        {
            if (thangnam.Length == 4)
            {
                int thang = Convert.ToInt32(thangnam.Substring(0, 2));
                int nam = Convert.ToInt32(thangnam.Substring(2, 2));
                if (thang <= 12 & thang > 0)
                {
                    if (nam > 20 & nam < DateTime.Now.Year % 2000)
                    {
                        return true;
                    }
                    else if (nam == DateTime.Now.Year % 2000)
                    {
                        if (thang <= DateTime.Now.Month)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

    }
}
