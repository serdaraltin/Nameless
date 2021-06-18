namespace nameless
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.speak = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.online = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.NotifyIcon(this.components);
            this.speaking = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seçeneklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.küçültToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.yenidenBaşlatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veritabanıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bağlantıTestiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.durumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonksiyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arayüzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelişmişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soru";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "İlet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(53, 63);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Sesli Cevap";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // speak
            // 
            this.speak.Interval = 1000;
            this.speak.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(53, 86);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(355, 119);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cevap";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(353, 216);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sorun Çöz";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // online
            // 
            this.online.Enabled = true;
            this.online.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "...";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 18);
            this.button2.TabIndex = 10;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // minimize
            // 
            this.minimize.Icon = ((System.Drawing.Icon)(resources.GetObject("minimize.Icon")));
            this.minimize.Text = "nameless";
            this.minimize.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // speaking
            // 
            this.speaking.Tick += new System.EventHandler(this.speaking_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçeneklerToolStripMenuItem,
            this.veritabanıToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(420, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seçeneklerToolStripMenuItem
            // 
            this.seçeneklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.küçültToolStripMenuItem,
            this.toolStripSeparator1,
            this.yenidenBaşlatToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.seçeneklerToolStripMenuItem.Name = "seçeneklerToolStripMenuItem";
            this.seçeneklerToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.seçeneklerToolStripMenuItem.Text = "Seçenekler";
            // 
            // küçültToolStripMenuItem
            // 
            this.küçültToolStripMenuItem.Name = "küçültToolStripMenuItem";
            this.küçültToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.küçültToolStripMenuItem.Text = "Küçült";
            this.küçültToolStripMenuItem.Click += new System.EventHandler(this.küçültToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // yenidenBaşlatToolStripMenuItem
            // 
            this.yenidenBaşlatToolStripMenuItem.Name = "yenidenBaşlatToolStripMenuItem";
            this.yenidenBaşlatToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.yenidenBaşlatToolStripMenuItem.Text = "Yeniden Başlat";
            this.yenidenBaşlatToolStripMenuItem.Click += new System.EventHandler(this.yenidenBaşlatToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // veritabanıToolStripMenuItem
            // 
            this.veritabanıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bağlantıTestiToolStripMenuItem,
            this.toolStripSeparator2,
            this.durumToolStripMenuItem,
            this.toolStripSeparator3,
            this.ekleToolStripMenuItem});
            this.veritabanıToolStripMenuItem.Name = "veritabanıToolStripMenuItem";
            this.veritabanıToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.veritabanıToolStripMenuItem.Text = "Veritabanı";
            // 
            // bağlantıTestiToolStripMenuItem
            // 
            this.bağlantıTestiToolStripMenuItem.Name = "bağlantıTestiToolStripMenuItem";
            this.bağlantıTestiToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.bağlantıTestiToolStripMenuItem.Text = "Bağlantı Testi";
            this.bağlantıTestiToolStripMenuItem.Click += new System.EventHandler(this.bağlantıTestiToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(141, 6);
            // 
            // durumToolStripMenuItem
            // 
            this.durumToolStripMenuItem.Name = "durumToolStripMenuItem";
            this.durumToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.durumToolStripMenuItem.Text = "Durum";
            this.durumToolStripMenuItem.Click += new System.EventHandler(this.durumToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standartToolStripMenuItem,
            this.fonksiyonToolStripMenuItem,
            this.işlemToolStripMenuItem});
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            // 
            // standartToolStripMenuItem
            // 
            this.standartToolStripMenuItem.Name = "standartToolStripMenuItem";
            this.standartToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.standartToolStripMenuItem.Text = "Standart";
            // 
            // fonksiyonToolStripMenuItem
            // 
            this.fonksiyonToolStripMenuItem.Name = "fonksiyonToolStripMenuItem";
            this.fonksiyonToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.fonksiyonToolStripMenuItem.Text = "Fonksiyon";
            this.fonksiyonToolStripMenuItem.Click += new System.EventHandler(this.fonksiyonToolStripMenuItem_Click);
            // 
            // işlemToolStripMenuItem
            // 
            this.işlemToolStripMenuItem.Name = "işlemToolStripMenuItem";
            this.işlemToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.işlemToolStripMenuItem.Text = "İşlem";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arayüzToolStripMenuItem,
            this.gelişmişToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // arayüzToolStripMenuItem
            // 
            this.arayüzToolStripMenuItem.Name = "arayüzToolStripMenuItem";
            this.arayüzToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.arayüzToolStripMenuItem.Text = "Arayüz";
            // 
            // gelişmişToolStripMenuItem
            // 
            this.gelişmişToolStripMenuItem.Name = "gelişmişToolStripMenuItem";
            this.gelişmişToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.gelişmişToolStripMenuItem.Text = "Gelişmiş";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(420, 238);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nameless";
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer speak;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Timer online;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NotifyIcon minimize;
        private System.Windows.Forms.Timer speaking;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seçeneklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem küçültToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem yenidenBaşlatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veritabanıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bağlantıTestiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem durumToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonksiyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arayüzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelişmişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
    }
}

