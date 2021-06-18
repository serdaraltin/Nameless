using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Diagnostics;
namespace nameless
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "/data/data.db;Persist Security Info=False;Jet OLEDB:Database Password=deadsound");
        string datawat=Application.StartupPath + "/data/data.db";
        int loaded_browser = 0;
        string reply = "";
        string function = "";
        string speak_text = "";
        public string soru = "";
        public string cevap = "";
        public string data_input = "";
        WebBrowser browser = new WebBrowser();
        ListView musiclist = new ListView();
        WebBrowser network = new WebBrowser();
        public bool InternetKontrol()
        {
            try
            {
                System.Net.Sockets.TcpClient kontrol_client = new System.Net.Sockets.TcpClient("www.google.com.tr", 80);
                kontrol_client.Close();
                return true;
            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void network_data_add()
        {
            try
            {
                HtmlElementCollection bilgi = network.Document.All;
                foreach (HtmlElement element in bilgi)
                {
                    if (element.GetAttribute("classname").Contains("area"))
                    {
                        element.InnerText += soru + " -=- " + cevap+" -+- ";
                    }
                }
            }
            catch { }
        }
        public void browser_navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.Text = "nameless...";
        }
        public void browser_complated(object sender,WebBrowserDocumentCompletedEventArgs e)
        {
            this.Text = "nameless";
            switch (function)
            {
              
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                case "arastir":
                    string veri = "";
                    HtmlElementCollection viki = browser.Document.All;
                    foreach (HtmlElement bilgi in viki)
                    {
                        if (bilgi.GetAttribute("classname") == "_cgc kno-fb-ctx")
                        {
                            veri += bilgi.InnerText+Environment.NewLine;
                        }
                    }
                    if (veri.IndexOf("Vikipedi") > 0)
                    {
                        veri = veri.Substring(0, veri.IndexOf("Vikipedi") - 1);
                    }
                    if (veri != "")
                    {
                        reply = veri;
                        browser.Navigate("https://translate.google.com/#tr/en/" + reply); function = "genel-cevap"; 
                    }
                    else
                        richTextBox1.Text = "Malesef aradığını bulamadım.";
                    break;
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                case "music-list":
                    HtmlElementCollection musics = browser.Document.All;
                    foreach (HtmlElement linkler in musics)
                    {
                        if (linkler.GetAttribute("classname") == "pl-video-title-link yt-uix-tile-link yt-uix-sessionlink  spf-link ")
                        {
                            string[] row={linkler.InnerText,linkler.GetAttribute("href").ToString()};
                            var music = new ListViewItem(row);
                            musiclist.Items.Add(music);
                            richTextBox1.Text = "";                       
                        }
                    }
                     
                    break;
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                case "hava-durumu":
                    string adres = "";
                    string durum = "";
                    HtmlElementCollection derece = browser.Document.All;
                    foreach (HtmlElement element in derece)
                    {
                        if (element.GetAttribute("id") == "wob_dc")
                            durum = element.InnerText;
                        if (element.GetAttribute("id") == "wob_loc")
                        {
                            adres = element.InnerText;
                            for (int i = 0; i <= adres.Length - 1; i++)
                            {
                                adres = adres.Remove(0, adres.IndexOf("/") + 1);
                            }
                        }
                        if (element.GetAttribute("id") == "wob_tm")
                        {
                            reply = adres + " hava " + durum + " " + element.InnerText + "°";
                            browser.Navigate("https://translate.google.com/#tr/en/" + reply); function = "genel-cevap";
                        }
                    }
                    break;
                case "sozluk":
                    HtmlElementCollection anlam = browser.Document.All;
                    foreach (HtmlElement anlamı in anlam)
                    {
                        if (anlamı.GetAttribute("classname") == "_Jig")
                        {
                            //browser.Navigate("https://translate.google.com/#tr/en/" + "aa"); function = "genel-cevap";
                            reply = anlamı.InnerText;
                            richTextBox1.Text = reply;
                       
                        }
                    }
                    break;
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                case "genel-cevap":
                    HtmlElementCollection ses = browser.Document.All;
                    foreach (HtmlElement element in ses)
                    {
                        if (element.GetAttribute("classname") == "trans-listen-button goog-toolbar-button")
                        {
                            if (checkBox1.Checked == true)
                            {
                                if (reply != "")
                                {
                                    loaded_browser += 1;
                                    if (loaded_browser == 4)
                                    {
                                        loaded_browser = 0;
                                        speak.Start();
                                    }
                                }
                            }
                        }
                    }
                    break;
                  ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            }
        }
        private void main_Load(object sender, EventArgs e)
        {
            /*bool kontrol = InternetKontrol();
            if (kontrol == false)
            {
                MessageBox.Show("Malesef internet bağlantısını bulamadım.", "nameless", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }*/
            try
            {
                baglan.Open();
                FileInfo info = new FileInfo(datawat);
                string dtdr = "..." + info.Directory.ToString().Remove(0, info.Directory.ToString().Length - 20).ToString() + @"\";
                /*   richTextBox1.Text= "Veritabanı Boyut : " + (info.Length / 1024).ToString() + " kb\n" +
                                 "Veritabanı Dizin  : " + dtdr + "\n" +
                                 "Veritabanı Giriş   :" + info.LastWriteTime.ToString();*/
                //richTextBox1.Text = "Veritabanına bağlandım.";
                baglan.Close();
                //  function = "hava-durumu"; functions();
            }
            catch
            {
                baglan.Close();
                MessageBox.Show("Veritabanı hatası\nVeritabanı taşınmış,silinmiş veya değiştirilmiş.", "nameless", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            network.ScriptErrorsSuppressed = true;
            network.Visible = false;
            network.Navigate("https://notepad.pw/e1alx82x");
            browser.ScriptErrorsSuppressed = true;
            browser.Visible = false;
            browser.DocumentCompleted += browser_complated;
            browser.Navigating += browser_navigating;
            Controls.Add(browser);
            browser.Navigate("https://www.youtube.com/playlist?list=PLzBgi-bjxcqLi-y-C6PkrxLt5fum8rAOn"); function = "music-list"; 
            richTextBox1.Text = "Bağlantılarımı güncelliyorum..."; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                speaking.Enabled = false;
                baglan.Open();
                OleDbCommand komut = new OleDbCommand("Select *From sorular where soru like'" + textBox1.Text + "'", baglan);
                OleDbDataReader oku = komut.ExecuteReader();
                reply = "";
                while (oku.Read())
                {
                    if (oku["cevap"].ToString() != null)
                    {
                        reply = oku["cevap"].ToString();
                        browser.Navigate("https://translate.google.com/#tr/en/" + reply); function = "genel-cevap";
                    }
                }
                baglan.Close();
                if (reply == "")
                {
                    string sorgu = textBox1.Text.ToLower();
                    sorgu = sorgu.Replace("ü", "u").Replace("ö", "o").Replace("ç", "c").Replace("ş", "s").Replace("ı", "i").Replace("ğ", "g");
                    if (sorgu.IndexOf("arastir") > 0 || sorgu.IndexOf("hakkinda") > 0 || sorgu.IndexOf("bilgi") > 0)
                    {
                        if (sorgu.IndexOf("arastir") > 0)
                            sorgu = sorgu.Substring(0, sorgu.IndexOf("arastir"));
                        if (sorgu.IndexOf("hakkinda") > 0)
                            sorgu = sorgu.Substring(0, sorgu.IndexOf("hakkinda"));
                        if (sorgu.IndexOf("bilgi") > 0)
                            sorgu = sorgu.Substring(0, sorgu.IndexOf("bilgi"));
                        browser.Navigate("https://www.google.com.tr/search?&q=" + sorgu); function = "arastir";
                    }
                    else if (sorgu.IndexOf("sozluk") > 0 && reply=="")
                    {
                        sorgu = sorgu.Substring(0, sorgu.IndexOf("sozluk"));
                        reply = sorgu;
                        browser.Navigate("https://www.google.com.tr/search?source=hp&q=sözlük#dobs=" + sorgu); function = "sozluk";
                    }
                    else
                    {
                        switch (sorgu)
                        {
                            case "veritabani durumu":
                                FileInfo info = new FileInfo(Application.StartupPath+"/data/data.db");
                                string boyut = "Veritabanı boyutu : "+info.Length.ToString();
                                string son = "Son veri girisi : " + info.LastWriteTime.ToShortDateString();
                                baglan.Open();
                                OleDbCommand sınır = new OleDbCommand("Select count(*) from sorular", baglan);
                                string kapasite ="Öğrenilmiş Veri : "+ sınır.ExecuteScalar().ToString();
                                baglan.Close();
                                richTextBox1.Text = boyut + Environment.NewLine + son + Environment.NewLine + kapasite;
                                break;
                            case "hava durumu":
                                browser.Navigate("https://www.google.com.tr/search?&q=hava+durumu"); function = "hava-durumu";
                                break;
                            case "youtubeyi ac":
                                Process.Start("http://www.youtube.com");
                                break;
                            case "tarayiciyi ac":
                                Process.Start("http://www.google.com");
                                break;
                            case "sarki cal":
                                Random salla = new Random();
                                int secmusic = salla.Next(0, musiclist.Items.Count - 1);
                                richTextBox1.Text = "Çaldığım şarkı > " + musiclist.Items[secmusic].SubItems[0].Text;
                                browser.Navigate(musiclist.Items[secmusic].SubItems[1].Text);
                                break;
                            case "saat kac":
                                browser.Navigate("https://translate.google.com/#tr/en/" + "Saat " + DateTime.Now.Hour.ToString() + "%3A" + DateTime.Now.Minute.ToString()); function = "genel-cevap";
                                break;
                            default:
                                browser.Navigate("");
                                DialogResult ekle = MessageBox.Show("Bu soruya cavap bulamadım,sen ekler misin?", "nameless", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (ekle == DialogResult.Yes)
                                {
                                    reply_add replyadd = new reply_add();
                                    TextBox ques = replyadd.Controls["textBox1"] as TextBox;
                                    ques.Text = textBox1.Text;
                                    replyadd.ShowDialog();
                                }
                                break;
                        }
                    }
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            speaking.Interval =60 * 9;
            speaking.Enabled = true;
            try
            {
                HtmlDocument doc = browser.Document;
                HtmlElement button = doc.GetElementById("gt-src-listen");
                button.InvokeMember("click");
                richTextBox1.Text = "";
                this.Text = "nameless";
                speak.Stop();
                textBox1.Text = "";
            }
            catch { speak.Start(); }
      
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
                button1.PerformClick();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*problem pr = new problem();
            WebBrowser br = pr.Controls["webBrowser1"] as WebBrowser;
                br.Navigate("https://www.google.com.tr/search?&q=hava+durumu");
            pr.ShowDialog();*/
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                HtmlElementCollection bilgi = network.Document.All;
                foreach (HtmlElement element in bilgi)
                {
                    if (element.GetAttribute("classname").Contains("footer-share text-center"))
                    {
                        string vieews = element.InnerText;
                        vieews = vieews.Remove(0, vieews.IndexOf("Views:") + 6);
                        label3.Text ="Kullanıcılar : " +vieews;

                    }
                }
            }
            catch { }
            try
            {

                HtmlElementCollection bilgi = network.Document.All;
                foreach (HtmlElement element in bilgi)
                {
                    if (element.GetAttribute("classname").Contains("area"))
                    {
                        if (data_input != element.InnerText)
                        {
                            data_input = element.InnerText;
                          
                            if (element.InnerText.IndexOf(" -+- ") > 0)
                            {
                                string data_online = element.InnerText;
                                for (int i = 0; i <= data_online.Length - 1; i++)
                                {
                                    richTextBox1.Text = "Veritabanımı güncelliyorum";
                                    string question = data_online;
                                    question = question.Substring(0, question.IndexOf(" -=- "));
                                    string reply = data_online;
                                    reply = reply.Remove(0, reply.IndexOf(" -=- ") + 5);
                                    reply = reply.Substring(0, reply.IndexOf(" -+- "));
                                    string control = "";
                                    string control2 = "";
                                    baglan.Open();
                                    OleDbCommand ara = new OleDbCommand("Select *From sorular where soru like'" + question + "'", baglan);
                                    OleDbDataReader oku = ara.ExecuteReader();
                                    while (oku.Read())
                                    {
                                        control = oku["cevap"].ToString();
                                        control2 = oku["soru"].ToString();
                                    }
                                    baglan.Close();
                                    if (control != reply)
                                    {
                                        baglan.Open();
                                        OleDbCommand sil = new OleDbCommand("Delete from sorular where soru='" + question + "'", baglan);
                                        sil.ExecuteNonQuery();
                                        OleDbCommand komut = new OleDbCommand("insert into sorular (soru,cevap) values(@soru,@cevap)", baglan);
                                        komut.Parameters.AddWithValue("@soru", question);
                                        komut.Parameters.AddWithValue("@cevap", reply);
                                        komut.ExecuteNonQuery();
                                        baglan.Close();
                                    }
                                    data_online = data_online.Remove(0, data_online.IndexOf(" -+- ") + 5);
                                 
                                }
                                richTextBox1.Text = "";
                            }
                        }
                    }
                }
            }
            catch { this.Enabled = true; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            minimize.Visible = true;
            minimize.BalloonTipIcon = ToolTipIcon.Info;
            minimize.BalloonTipTitle = "namless";
            minimize.BalloonTipText = "nameless dinleme kipinde";
            minimize.ShowBalloonTip(2000);
            this.Visible = false;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            minimize.Visible = false;
        }

        private void speaking_Tick(object sender, EventArgs e)
        {
            string part ="";
            if (reply.IndexOf(" ") > 0 && reply!="")
            {
                label2.ForeColor = Color.Red;
                part = reply.Substring(0, reply.IndexOf(" ") + 1);
                reply = reply.Remove(0, reply.IndexOf(" ") + 1);
                richTextBox1.Text += part;
                
            }
            else if (reply != "")
            {
                label2.ForeColor = Color.Red;
                part = reply;
                reply="";
                richTextBox1.Text += part;
                label2.ForeColor = Color.Black;
                speaking.Enabled = false;
            }
            /*if (reply == "")
            {
                
                browser.Navigate("https://translate.google.com");
                label2.ForeColor = Color.Black;
            }*/
         
        }

        private void küçültToolStripMenuItem_Click(object sender, EventArgs e)
        {
            minimize.Visible = true;
            minimize.BalloonTipIcon = ToolTipIcon.Info;
            minimize.BalloonTipTitle = "namless";
            minimize.BalloonTipText = "nameless dinleme kipinde.";
            minimize.ShowBalloonTip(2000);
            this.Visible = false;
        }

        private void yenidenBaşlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bağlantıTestiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                baglan.Close();
                MessageBox.Show("Bağlantı başarılı.", "nameless", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception hata)
            {
                MessageBox.Show(hata.Message.ToString(), "nameless", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void durumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo info = new FileInfo(Application.StartupPath + "/data/data.db");
            string boyut = "Veritabanı boyutu : " + (info.Length / 1024).ToString() + " kb";
            string son = "Son veri girisi : " + info.LastWriteTime.ToShortDateString();
            baglan.Open();
            OleDbCommand sınır = new OleDbCommand("Select count(*) from sorular", baglan);
            string kapasite = "Öğrenilmiş Veri : " + sınır.ExecuteScalar().ToString();
            baglan.Close();
            MessageBox.Show(boyut + Environment.NewLine + kapasite + Environment.NewLine + son, "nameles", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fonksiyonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            function_add func = new function_add();
            func.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

    }
}
