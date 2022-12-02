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
    public partial class Fbskham : Form
    {
        public Fbskham()
        {
            InitializeComponent();
            maskedTextBox1.Text = DAO.Load_DA0.Instance.Load_ThangNam_HienTai();
            Load_BsKham();

        }

        void Load_BsKham()
        {

            string Datathang = "hsoftdkbd" + maskedTextBox1.Text;
            dataGridView1.DataSource = BsKham_DAO.Instance.Load_BsKham(Datathang);
            
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
                dataGridView1.DataSource = BsKham_DAO.Instance.Load_BsKham("hsoftdkbd" + maskedTextBox1.Text);

            }
            else
            {
                MessageBox.Show("tháng năm không đúng");
            }

        }

        private void Fbskham_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
