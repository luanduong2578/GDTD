using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GDBH
{
    public partial class Fmain : Form
    {
        public Fmain()
        {
            InitializeComponent();
        }

        private bool CheckExitForm(string fName)
        {
            bool Check = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == fName)
                {
                    Check = true;
                    break;
                }
            }
            return Check;
        }
        // Active form đang mở
        private void ActiveChildForm(string fName)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == fName)
                {
                    f.Activate();
                    break;
                }
            }
        }

        
        private void LichBsKhamToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!CheckExitForm("Fbskham"))
            {
                Fbskham f = new Fbskham();
                f.MdiParent = this;
                f.Show();
            }
            else
                ActiveChildForm("Fbskham");
        }


        private void TheBHYTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitForm("BH_BHYT"))
            {
                BH_BHYT f = new BH_BHYT();
                f.MdiParent = this;
                f.Show();
            }
            else
                ActiveChildForm("BH_BHYT");
        }

   
        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pTTTSaiSốLượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitForm("Fpttt"))
            {
                Fpttt f = new Fpttt();
                f.MdiParent = this;
                f.Show();
            }
            else
                ActiveChildForm("Fpttt");
        }

        private void NgayGiuongDieuTriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitForm("NgayGiuongDieuTri"))
            {
                NG_Ngaygiuongdieutri f = new NG_Ngaygiuongdieutri();
                f.MdiParent = this;
                f.Show();
            }
            else
                ActiveChildForm("NgayGiuongDieuTri");

        }

        private void Fmain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Nhohon4hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitForm("Nhohon4h"))
            {
                NG_Nhohon4h f = new NG_Nhohon4h();
                f.MdiParent = this;
                f.Show();
            }
            else
                ActiveChildForm("Nhohon4h");
        }

        private void Nhohon24hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitForm("Nhohon24h"))
            {
                NG_Nhohon24h f = new NG_Nhohon24h();
                f.MdiParent = this;
                f.Show();
            }
            else
                ActiveChildForm("Nhohon24h");
        }

        private void TinhtrangravienToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!CheckExitForm("Tinhtrangravien"))
            {
                NG_Tinhtrangravien f = new NG_Tinhtrangravien();
                f.MdiParent = this;
                f.Show();
            }
            else
                ActiveChildForm("Tinhtrangravien");
        }

        private void kCBBĐToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitForm("BH_KCBBD"))
            {
                BH_KCBBD f = new BH_KCBBD();
                f.MdiParent = this;
                f.Show();
            }
            else
                ActiveChildForm("BH_KCBBD");
        }

        private void giớiTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitForm("BH_GioiTinh"))
            {
                BH_GioiTinh f = new BH_GioiTinh();
                f.MdiParent = this;
                f.Show();
            }
            else
                ActiveChildForm("BH_GioiTinh");
        }

        private void thẻBáoGiảmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitForm("BH_BaoGiam"))
            {
                BH_BaoGiam f = new BH_BaoGiam();
                f.MdiParent = this;
                f.Show();
            }
            else
                ActiveChildForm("BH_BaoGiam");
        }

        private void ngàyGiườngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!CheckExitForm("NG_Ngaygiuong"))
            {
                NG_Ngaygiuong f = new NG_Ngaygiuong();
                f.MdiParent = this;
                f.Show();
            }
            else
                ActiveChildForm("NG_Ngaygiuong");
        }

        private void hạnThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitForm("BH_Hanthe"))
            {
                BH_Hanthe f = new BH_Hanthe();
                f.MdiParent = this;
                f.Show();
            }
            else
                ActiveChildForm("BH_Hanthe");
        }

        private void danhMụcMãGiườngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void giáCôngKhámToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitForm("CK_CongKham"))
            {
                CK_CongKham f = new CK_CongKham();
                f.MdiParent = this;
                f.Show();
            }
            else
                ActiveChildForm("CK_CongKham");
        }
    }
}
