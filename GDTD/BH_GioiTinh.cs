using Newtonsoft.Json;
using GDBH.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using xNet;

namespace GDBH
{
    public partial class BH_GioiTinh : Form
    {
        public BH_GioiTinh()
        {
            InitializeComponent();

            maskedTextBox1.Text = Load_DA0.Instance.Load_ThangNam_HienTai();
            BH_GioiTinh_DAO.Instance.Insert_TheBhyt(maskedTextBox1.Text);
            BH_GioiTinh_DAO.Instance.Update_Thang_TheBhyt(maskedTextBox1.Text);
            Load_TheBhyt(maskedTextBox1.Text);
        }

        private void Fthebhyt_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        void Load_TheBhyt(string Datathang)
        {
            dataGridView1.DataSource = BH_GioiTinh_DAO.Instance.Load_TheBhyt(Datathang);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Load_DA0.Instance.KiemtraThangnam(maskedTextBox1.Text))
            {
                dataGridView1.DataSource = BH_GioiTinh_DAO.Instance.Load_TheBhyt(maskedTextBox1.Text);
            }
            else
            {
                MessageBox.Show("tháng năm không đúng");
            }
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Get_token_tokenId();
            string accesstoken = txb_token.Text;
            string tokenid = txb_token_id.Text;
            HttpRequest http = new HttpRequest();
            DataTable dataTable = BH_GioiTinh_DAO.Instance.Load_Tracuu(Load_DA0.Instance.Load_ThangNam_HienTai());
            string id = "";
            string mathe = "CH4747410097754";
            string hoten = "DƯƠNG VĂN LUẬN";
            string namsinh = "1986";
            string data = "";
            string url = "";
            string jsontracuu = "";
            
            foreach (DataRow r in dataTable.Rows)
            {
                id = r["ID"].ToString();
                mathe = r["MATHE"].ToString();
                hoten = r["HOTEN"].ToString();
                namsinh = r["NAMSINH"].ToString();
                                          
                data = "{'maThe':'"+ mathe +"','hoTen':'"+ hoten +"','ngaySinh':'" + namsinh +"'}";
                url = "https://egw.baohiemxahoi.gov.vn/api/egw/nhanLichSuKCB2018?token=" + accesstoken + "&id_token=" + tokenid + "&username=74001_BV&password=bcd3b3505865dd5966c0301ba9367705";
                jsontracuu = http.Post(url, data, "application/json").ToString();
                BH_TraCuuThe jsontracuudata = JsonConvert.DeserializeObject<BH_TraCuuThe>(jsontracuu);
                

                string ghichu_tc = (jsontracuudata.GhiChu != null)? jsontracuudata.GhiChu.Replace("'", "''"): null;
                string hoten_tc = (jsontracuudata.HoTen != null)? jsontracuudata.HoTen.Replace("'", "''"): null;
                string PHAI = (jsontracuudata.GioiTinh == "Nam") ? "0" : "1";
                string NamSinh = (jsontracuudata.NgaySinh != null) ? jsontracuudata.NgaySinh.Substring((jsontracuudata.NgaySinh.Length - 4), 4) : null;
                string hotenkhongdau = (jsontracuudata.HoTen != null)? khongdau(jsontracuudata.HoTen.Replace("'", "''")): null;

                if (jsontracuudata.MaKetQua == "401")
                {
                    Get_token_tokenId();
                    accesstoken = txb_token.Text;
                    tokenid = txb_token_id.Text;
                    data = "{'maThe':'" + mathe + "','hoTen':'" + hoten + "','ngaySinh':'" + namsinh + "'}";
                    url = "https://egw.baohiemxahoi.gov.vn/api/egw/nhanLichSuKCB2018?token=" + accesstoken + "&id_token=" + tokenid + "&username=74001_BV&password=bcd3b3505865dd5966c0301ba9367705";
                    jsontracuu = http.Post(url, data, "application/json").ToString();
                    jsontracuudata = JsonConvert.DeserializeObject<BH_TraCuuThe>(jsontracuu);
                    ghichu_tc = (jsontracuudata.GhiChu != null) ? jsontracuudata.GhiChu.Replace("'", "''") : null;
                    hoten_tc = (jsontracuudata.HoTen != null) ? jsontracuudata.HoTen.Replace("'", "''") : null;
                    PHAI = (jsontracuudata.GioiTinh == "Nam") ? "0" : "1";
                    NamSinh = (jsontracuudata.NgaySinh != null) ? jsontracuudata.NgaySinh.Substring((jsontracuudata.NgaySinh.Length - 4), 4) : null;
                    hotenkhongdau = (jsontracuudata.HoTen != null) ? khongdau(jsontracuudata.HoTen.Replace("'", "''")) : null;
                    if (jsontracuudata.MaKetQua != "401")
                    {
                        BH_GioiTinh_DAO.Instance.Update_Tracuu_TheBhyt(jsontracuudata.MaKetQua, ghichu_tc, hoten_tc, NamSinh, PHAI, jsontracuudata.MaThe, jsontracuudata.MaDKBD, jsontracuudata.GtTheTu, jsontracuudata.GtTheDen, hotenkhongdau, id);

                    }
                }
                else
                {
                    BH_GioiTinh_DAO.Instance.Update_Tracuu_TheBhyt(jsontracuudata.MaKetQua, ghichu_tc, hoten_tc, NamSinh, PHAI, jsontracuudata.MaThe, jsontracuudata.MaDKBD, jsontracuudata.GtTheTu, jsontracuudata.GtTheDen, hotenkhongdau, id);

                }

            }



        }

        private void Get_token_tokenId()
        {

            HttpRequest http = new HttpRequest();
            string data = "{'username': '74001_BV', 'password':'bcd3b3505865dd5966c0301ba9367705'}";
            string json = http.Post("https://egw.baohiemxahoi.gov.vn/api/token/take", data, "application/json").ToString();
            json = json.Replace("\"APIKey\":{", "\"APIKey\":[{");
            json = json.Replace("}}", "}]}");
            Get_Token JsonData = JsonConvert.DeserializeObject<Get_Token>(json);
            txb_token_id.Text = JsonData.APIKey[0].IdToken;
            txb_token.Text = JsonData.APIKey[0].AccessToken;

        }

        private static readonly string[] VietNamChar = new string[]
            {
                "aAeEoOuUiIdDyY",
                "áàạảãâấầậẩẫăắằặẳẵ",
                "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
                "éèẹẻẽêếềệểễ",
                "ÉÈẸẺẼÊẾỀỆỂỄ",
                "óòọỏõôốồộổỗơớờợởỡ",
                "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
                "úùụủũưứừựửữ",
                "ÚÙỤỦŨƯỨỪỰỬỮ",
                "íìịỉĩ",
                "ÍÌỊỈĨ",
                "đ",
                "Đ",
                "ýỳỵỷỹ",
                "ÝỲỴỶỸ"
            };
        public static string khongdau(string str)
        {
            //Thay thế và lọc dấu từng char      
            for (int i = 1; i < VietNamChar.Length; i++)
            {
                for (int j = 0; j < VietNamChar[i].Length; j++)
                    str = str.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
            }
            return str.Replace(" ", "");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)

            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txb_id.Text = row.Cells["ID"].Value.ToString();
                txb_mabn.Text = row.Cells["MABN"].Value.ToString();
                txb_hoten.Text = row.Cells["HOTEN"].Value.ToString();
                txb_namsinh.Text = row.Cells["NAMSINH"].Value.ToString();
                txb_gioitinh.Text = (row.Cells["PHAI"].Value.ToString()=="1")?"Nữ": "Nam";
                richTextBox1.Text = row.Cells["GHICHU_TC"].Value.ToString();

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if(checkBox1.Checked == true)
            {
                BH_GioiTinh_DAO.Instance.Update_Tracuu_check(txb_id.Text);
            }
            else
            {
                if (comboBox1.SelectedItem.ToString() != "Không lỗi")
                {
                    BH_GioiTinh_DAO.Instance.Update_Tracuu_Loi(comboBox1.SelectedItem.ToString(), txb_id.Text);
                }
            }
            checkBox1.Checked = false;
            if (Load_DA0.Instance.KiemtraThangnam(maskedTextBox1.Text))
            {
                dataGridView1.DataSource = BH_GioiTinh_DAO.Instance.Load_TheBhyt(maskedTextBox1.Text);
            }
            else
            {
                MessageBox.Show("tháng năm không đúng");
            }
        }

        private void txb_mabn_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BH_GioiTinh_DAO.Instance.Load_Search_MABN(maskedTextBox1.Text, textBox1_MABN.Text);
        }

        private void txb_hoten_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BH_GioiTinh_DAO.Instance.Load_Search_Hoten(maskedTextBox1.Text, textBox3_HOTEN.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
