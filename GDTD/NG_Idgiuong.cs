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
    public partial class NG_IdGiuong: Form
    {
        public NG_IdGiuong()
        {
            InitializeComponent();
            richTextBox1.Text = DAO.Load_DA0.Instance.Load_magiuong();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
