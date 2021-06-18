using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace nameless
{
    public partial class reply_add : Form
    {
        public reply_add()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "/data/data.db;Persist Security Info=False;Jet OLEDB:Database Password=deadsound");
        string datawat = Application.StartupPath + "/data/data.db";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                OleDbCommand komut = new OleDbCommand("insert into sorular (soru,cevap) values(@soru,@cevap)", baglan);
                komut.Parameters.AddWithValue("@soru", textBox1.Text);
                komut.Parameters.AddWithValue("@cevap", richTextBox1.Text);
                komut.ExecuteNonQuery();
                baglan.Close();
                main main = Application.OpenForms["main"] as main;
                main.soru = textBox1.Text;
                main.cevap = richTextBox1.Text;
                main.data_input = textBox1.Text + " -=- " + richTextBox1.Text;
                main.network_data_add();
                this.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message.ToString(), "nameless", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
