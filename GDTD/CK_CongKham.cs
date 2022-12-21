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
    public partial class CK_CongKham : Form
    {
        public CK_CongKham()
        {
            InitializeComponent();
            maskedTextBox1.Text = DAO.Load_DA0.Instance.Load_ThangNam_HienTai();
            dataGridView1_giacongkham.DataSource = DAO.CongKham_DAO.Instance.Load_GiaCongKham(maskedTextBox1.Text);
            dataGridView1_NhieuCongKham.DataSource = DAO.CongKham_DAO.Instance.Load_NhieuCongKhamCungLoai(maskedTextBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DAO.Load_DA0.Instance.KiemtraThangnam(maskedTextBox1.Text))
            {
                dataGridView1_giacongkham.DataSource = DAO.CongKham_DAO.Instance.Load_GiaCongKham(maskedTextBox1.Text);
                dataGridView1_NhieuCongKham.DataSource = DAO.CongKham_DAO.Instance.Load_NhieuCongKhamCungLoai(maskedTextBox1.Text);
            }
            else
            {
                MessageBox.Show("tháng năm không đúng");
            }


        }
    }
}
