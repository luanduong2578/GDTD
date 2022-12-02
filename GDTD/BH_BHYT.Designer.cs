
namespace GDBH
{
    partial class BH_BHYT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_get_token = new System.Windows.Forms.Button();
            this.txb_token = new System.Windows.Forms.TextBox();
            this.txb_token_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_mabn = new System.Windows.Forms.TextBox();
            this.txb_hoten = new System.Windows.Forms.TextBox();
            this.txb_namsinh = new System.Windows.Forms.TextBox();
            this.txb_gioitinh = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txb_id = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1_MABN = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3_HOTEN = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(71, 9);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(40, 20);
            this.maskedTextBox1.TabIndex = 7;
            this.maskedTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox1_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1235, 397);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tháng năm:";
            // 
            // btn_get_token
            // 
            this.btn_get_token.Location = new System.Drawing.Point(199, 9);
            this.btn_get_token.Name = "btn_get_token";
            this.btn_get_token.Size = new System.Drawing.Size(75, 23);
            this.btn_get_token.TabIndex = 9;
            this.btn_get_token.Text = "Get_API";
            this.btn_get_token.UseVisualStyleBackColor = true;
            this.btn_get_token.Click += new System.EventHandler(this.button2_Click);
            // 
            // txb_token
            // 
            this.txb_token.Enabled = false;
            this.txb_token.Location = new System.Drawing.Point(1182, 5);
            this.txb_token.Name = "txb_token";
            this.txb_token.Size = new System.Drawing.Size(25, 20);
            this.txb_token.TabIndex = 10;
            this.txb_token.Visible = false;
            // 
            // txb_token_id
            // 
            this.txb_token_id.Enabled = false;
            this.txb_token_id.Location = new System.Drawing.Point(1213, 5);
            this.txb_token_id.Name = "txb_token_id";
            this.txb_token_id.Size = new System.Drawing.Size(25, 20);
            this.txb_token_id.TabIndex = 10;
            this.txb_token_id.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "MABN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Họ tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Năm sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Giới tính:";
            // 
            // txb_mabn
            // 
            this.txb_mabn.Location = new System.Drawing.Point(41, 51);
            this.txb_mabn.Name = "txb_mabn";
            this.txb_mabn.Size = new System.Drawing.Size(75, 20);
            this.txb_mabn.TabIndex = 12;
            // 
            // txb_hoten
            // 
            this.txb_hoten.Location = new System.Drawing.Point(165, 49);
            this.txb_hoten.Name = "txb_hoten";
            this.txb_hoten.Size = new System.Drawing.Size(230, 20);
            this.txb_hoten.TabIndex = 12;
            // 
            // txb_namsinh
            // 
            this.txb_namsinh.Location = new System.Drawing.Point(458, 49);
            this.txb_namsinh.Name = "txb_namsinh";
            this.txb_namsinh.Size = new System.Drawing.Size(75, 20);
            this.txb_namsinh.TabIndex = 12;
            // 
            // txb_gioitinh
            // 
            this.txb_gioitinh.Location = new System.Drawing.Point(595, 49);
            this.txb_gioitinh.Name = "txb_gioitinh";
            this.txb_gioitinh.Size = new System.Drawing.Size(75, 20);
            this.txb_gioitinh.TabIndex = 12;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(7, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1210, 76);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(713, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Hs đúng";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1101, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cập nhật";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txb_id
            // 
            this.txb_id.Enabled = false;
            this.txb_id.Location = new System.Drawing.Point(1101, 5);
            this.txb_id.Name = "txb_id";
            this.txb_id.Size = new System.Drawing.Size(75, 20);
            this.txb_id.TabIndex = 12;
            this.txb_id.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Không lỗi",
            "KCB BĐ",
            "Giới tính",
            "Năm sinh",
            "Mã thẻ",
            "Hạn thẻ"});
            this.comboBox1.Location = new System.Drawing.Point(786, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(309, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // textBox1_MABN
            // 
            this.textBox1_MABN.Location = new System.Drawing.Point(803, 5);
            this.textBox1_MABN.Name = "textBox1_MABN";
            this.textBox1_MABN.Size = new System.Drawing.Size(75, 20);
            this.textBox1_MABN.TabIndex = 12;
            this.textBox1_MABN.TextChanged += new System.EventHandler(this.txb_mabn_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1525, -39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.txb_mabn_TextChanged);
            // 
            // textBox3_HOTEN
            // 
            this.textBox3_HOTEN.Location = new System.Drawing.Point(887, 5);
            this.textBox3_HOTEN.Name = "textBox3_HOTEN";
            this.textBox3_HOTEN.Size = new System.Drawing.Size(230, 20);
            this.textBox3_HOTEN.TabIndex = 12;
            this.textBox3_HOTEN.TextChanged += new System.EventHandler(this.txb_hoten_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(280, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Thoat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BH_BHYT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 561);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txb_gioitinh);
            this.Controls.Add(this.txb_namsinh);
            this.Controls.Add(this.textBox3_HOTEN);
            this.Controls.Add(this.txb_hoten);
            this.Controls.Add(this.txb_id);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1_MABN);
            this.Controls.Add(this.txb_mabn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_token_id);
            this.Controls.Add(this.txb_token);
            this.Controls.Add(this.btn_get_token);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "BH_BHYT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin hành chính - Thẻ bhyt";
            this.Load += new System.EventHandler(this.Fthebhyt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_get_token;
        private System.Windows.Forms.TextBox txb_token;
        private System.Windows.Forms.TextBox txb_token_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_mabn;
        private System.Windows.Forms.TextBox txb_hoten;
        private System.Windows.Forms.TextBox txb_namsinh;
        private System.Windows.Forms.TextBox txb_gioitinh;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txb_id;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1_MABN;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3_HOTEN;
        private System.Windows.Forms.Button button3;
    }
}