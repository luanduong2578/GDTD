using GDBH.DAO;
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
    public partial class NG_Nhohon4h : Form
    {
        public NG_Nhohon4h()
        {
            InitializeComponent();
            maskedTextBox1.Text = Load_DA0.Instance.Load_ThangNam_HienTai();
            string Datathang = "hsoftdkbd" + maskedTextBox1.Text;
            Load_Ngaygiuong(Datathang);
        }

        private void fngaygiuong_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        void Load_Ngaygiuong(string Datathang)
        {
            dataGridView1.DataSource = NG_Nhohon4h_DA0.Instance.Load_Ngaygiuong(Datathang);
        }

        private void txb_thangnam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
               if (Load_DA0.Instance.KiemtraThangnam(maskedTextBox1.Text))
               {
                   dataGridView1.DataSource = NG_Nhohon4h_DA0.Instance.Load_Ngaygiuong("hsoftdkbd" + maskedTextBox1.Text);

            }
            else
               {
                   MessageBox.Show("tháng năm không đúng");
               }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
