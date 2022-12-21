
namespace GDBH
{
    partial class Fmain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ngàyGiườngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngàyGiờĐiềuTrịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìnhTrạngRaViệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìnhTrạngRaViệnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ngàyGiườngĐiềuTrịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngàyGiườngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchBsKhámToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânCôngGiờKhámToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thẻBHYTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kCBBĐToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiTínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hạnThẻToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thẻBáoGiảmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bHYTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pTTTSaiSốLượngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiệnÍchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sốLượngCôngKhámToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thứTựCôngKhámToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giáCôngKhámToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcMãGiườngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ngàyGiườngToolStripMenuItem,
            this.lịchBsKhámToolStripMenuItem,
            this.thẻBHYTToolStripMenuItem,
            this.pTTTSaiSốLượngToolStripMenuItem,
            this.tiệnÍchToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ngàyGiườngToolStripMenuItem
            // 
            this.ngàyGiườngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ngàyGiờĐiềuTrịToolStripMenuItem,
            this.tìnhTrạngRaViệnToolStripMenuItem,
            this.tìnhTrạngRaViệnToolStripMenuItem1,
            this.ngàyGiườngĐiềuTrịToolStripMenuItem,
            this.ngàyGiườngToolStripMenuItem1});
            this.ngàyGiườngToolStripMenuItem.Name = "ngàyGiườngToolStripMenuItem";
            this.ngàyGiườngToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.ngàyGiườngToolStripMenuItem.Text = "Ngày giường";
            // 
            // ngàyGiờĐiềuTrịToolStripMenuItem
            // 
            this.ngàyGiờĐiềuTrịToolStripMenuItem.Name = "ngàyGiờĐiềuTrịToolStripMenuItem";
            this.ngàyGiờĐiềuTrịToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.ngàyGiờĐiềuTrịToolStripMenuItem.Text = "Ngày giờ điều trị < 4h tính sai giường";
            this.ngàyGiờĐiềuTrịToolStripMenuItem.Click += new System.EventHandler(this.Nhohon4hToolStripMenuItem_Click);
            // 
            // tìnhTrạngRaViệnToolStripMenuItem
            // 
            this.tìnhTrạngRaViệnToolStripMenuItem.Name = "tìnhTrạngRaViệnToolStripMenuItem";
            this.tìnhTrạngRaViệnToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.tìnhTrạngRaViệnToolStripMenuItem.Text = "4h < ngày giờ điệu trị < 24h tính sai giường";
            this.tìnhTrạngRaViệnToolStripMenuItem.Click += new System.EventHandler(this.Nhohon24hToolStripMenuItem_Click);
            // 
            // tìnhTrạngRaViệnToolStripMenuItem1
            // 
            this.tìnhTrạngRaViệnToolStripMenuItem1.Name = "tìnhTrạngRaViệnToolStripMenuItem1";
            this.tìnhTrạngRaViệnToolStripMenuItem1.Size = new System.Drawing.Size(302, 22);
            this.tìnhTrạngRaViệnToolStripMenuItem1.Text = "Tình trạng ra viện";
            this.tìnhTrạngRaViệnToolStripMenuItem1.Click += new System.EventHandler(this.TinhtrangravienToolStripMenuItem1_Click);
            // 
            // ngàyGiườngĐiềuTrịToolStripMenuItem
            // 
            this.ngàyGiườngĐiềuTrịToolStripMenuItem.Name = "ngàyGiườngĐiềuTrịToolStripMenuItem";
            this.ngàyGiườngĐiềuTrịToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.ngàyGiườngĐiềuTrịToolStripMenuItem.Text = "Ngày giường điều trị";
            this.ngàyGiườngĐiềuTrịToolStripMenuItem.Click += new System.EventHandler(this.NgayGiuongDieuTriToolStripMenuItem_Click);
            // 
            // ngàyGiườngToolStripMenuItem1
            // 
            this.ngàyGiườngToolStripMenuItem1.Name = "ngàyGiườngToolStripMenuItem1";
            this.ngàyGiườngToolStripMenuItem1.Size = new System.Drawing.Size(302, 22);
            this.ngàyGiườngToolStripMenuItem1.Text = "Ngày giường";
            this.ngàyGiườngToolStripMenuItem1.Click += new System.EventHandler(this.ngàyGiườngToolStripMenuItem1_Click);
            // 
            // lịchBsKhámToolStripMenuItem
            // 
            this.lịchBsKhámToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phânCôngGiờKhámToolStripMenuItem});
            this.lịchBsKhámToolStripMenuItem.Name = "lịchBsKhámToolStripMenuItem";
            this.lịchBsKhámToolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.lịchBsKhámToolStripMenuItem.Text = "Phân công giờ khám bệnh";
            // 
            // phânCôngGiờKhámToolStripMenuItem
            // 
            this.phânCôngGiờKhámToolStripMenuItem.Name = "phânCôngGiờKhámToolStripMenuItem";
            this.phânCôngGiờKhámToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.phânCôngGiờKhámToolStripMenuItem.Text = "Phân công giờ khám";
            this.phânCôngGiờKhámToolStripMenuItem.Click += new System.EventHandler(this.LichBsKhamToolStripMenuItem_Click);
            // 
            // thẻBHYTToolStripMenuItem
            // 
            this.thẻBHYTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kCBBĐToolStripMenuItem,
            this.giớiTínhToolStripMenuItem,
            this.hạnThẻToolStripMenuItem,
            this.thẻBáoGiảmToolStripMenuItem,
            this.bHYTToolStripMenuItem});
            this.thẻBHYTToolStripMenuItem.Name = "thẻBHYTToolStripMenuItem";
            this.thẻBHYTToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.thẻBHYTToolStripMenuItem.Text = "Thông tin hành chính";
            // 
            // kCBBĐToolStripMenuItem
            // 
            this.kCBBĐToolStripMenuItem.Name = "kCBBĐToolStripMenuItem";
            this.kCBBĐToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.kCBBĐToolStripMenuItem.Text = "KCB BĐ";
            this.kCBBĐToolStripMenuItem.Click += new System.EventHandler(this.kCBBĐToolStripMenuItem_Click);
            // 
            // giớiTínhToolStripMenuItem
            // 
            this.giớiTínhToolStripMenuItem.Name = "giớiTínhToolStripMenuItem";
            this.giớiTínhToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.giớiTínhToolStripMenuItem.Text = "Giới tính";
            this.giớiTínhToolStripMenuItem.Click += new System.EventHandler(this.giớiTínhToolStripMenuItem_Click);
            // 
            // hạnThẻToolStripMenuItem
            // 
            this.hạnThẻToolStripMenuItem.Name = "hạnThẻToolStripMenuItem";
            this.hạnThẻToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.hạnThẻToolStripMenuItem.Text = "Hạn thẻ";
            this.hạnThẻToolStripMenuItem.Click += new System.EventHandler(this.hạnThẻToolStripMenuItem_Click);
            // 
            // thẻBáoGiảmToolStripMenuItem
            // 
            this.thẻBáoGiảmToolStripMenuItem.Name = "thẻBáoGiảmToolStripMenuItem";
            this.thẻBáoGiảmToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.thẻBáoGiảmToolStripMenuItem.Text = "Thẻ báo giảm";
            this.thẻBáoGiảmToolStripMenuItem.Click += new System.EventHandler(this.thẻBáoGiảmToolStripMenuItem_Click);
            // 
            // bHYTToolStripMenuItem
            // 
            this.bHYTToolStripMenuItem.Name = "bHYTToolStripMenuItem";
            this.bHYTToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.bHYTToolStripMenuItem.Text = "BHYT";
            this.bHYTToolStripMenuItem.Click += new System.EventHandler(this.TheBHYTToolStripMenuItem_Click);
            // 
            // pTTTSaiSốLượngToolStripMenuItem
            // 
            this.pTTTSaiSốLượngToolStripMenuItem.Name = "pTTTSaiSốLượngToolStripMenuItem";
            this.pTTTSaiSốLượngToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.pTTTSaiSốLượngToolStripMenuItem.Text = "Phẫu thuật thủ thuật";
            this.pTTTSaiSốLượngToolStripMenuItem.Click += new System.EventHandler(this.pTTTSaiSốLượngToolStripMenuItem_Click);
            // 
            // tiệnÍchToolStripMenuItem
            // 
            this.tiệnÍchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sốLượngCôngKhámToolStripMenuItem,
            this.thứTựCôngKhámToolStripMenuItem,
            this.giáCôngKhámToolStripMenuItem});
            this.tiệnÍchToolStripMenuItem.Name = "tiệnÍchToolStripMenuItem";
            this.tiệnÍchToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.tiệnÍchToolStripMenuItem.Text = "Công khám";
            // 
            // sốLượngCôngKhámToolStripMenuItem
            // 
            this.sốLượngCôngKhámToolStripMenuItem.Name = "sốLượngCôngKhámToolStripMenuItem";
            this.sốLượngCôngKhámToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.sốLượngCôngKhámToolStripMenuItem.Text = "Số lượng công khám";
            // 
            // thứTựCôngKhámToolStripMenuItem
            // 
            this.thứTựCôngKhámToolStripMenuItem.Name = "thứTựCôngKhámToolStripMenuItem";
            this.thứTựCôngKhámToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.thứTựCôngKhámToolStripMenuItem.Text = "Thứ tự công khám";
            // 
            // giáCôngKhámToolStripMenuItem
            // 
            this.giáCôngKhámToolStripMenuItem.Name = "giáCôngKhámToolStripMenuItem";
            this.giáCôngKhámToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.giáCôngKhámToolStripMenuItem.Text = "Giá công khám";
            this.giáCôngKhámToolStripMenuItem.Click += new System.EventHandler(this.giáCôngKhámToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.thoátToolStripMenuItem1});
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.thoátToolStripMenuItem.Text = "Tiện ích";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcMãGiườngToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // danhMụcMãGiườngToolStripMenuItem
            // 
            this.danhMụcMãGiườngToolStripMenuItem.Name = "danhMụcMãGiườngToolStripMenuItem";
            this.danhMụcMãGiườngToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.danhMụcMãGiườngToolStripMenuItem.Text = "Danh mục mã giường";
            // 
            // thoátToolStripMenuItem1
            // 
            this.thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
            this.thoátToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.thoátToolStripMenuItem1.Text = "Thoát";
            this.thoátToolStripMenuItem1.Click += new System.EventHandler(this.ThoatToolStripMenuItem_Click);
            // 
            // Fmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::GDBH.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giám định tự động BHYT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fmain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ngàyGiườngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchBsKhámToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thẻBHYTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiệnÍchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pTTTSaiSốLượngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngàyGiườngĐiềuTrịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngàyGiờĐiềuTrịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìnhTrạngRaViệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânCôngGiờKhámToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kCBBĐToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giớiTínhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hạnThẻToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thẻBáoGiảmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sốLượngCôngKhámToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thứTựCôngKhámToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tìnhTrạngRaViệnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bHYTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngàyGiườngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcMãGiườngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giáCôngKhámToolStripMenuItem;
    }
}

