using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.OleDb;
namespace nameless
{
    public partial class function_add : Form
    {
        public function_add()
        {
            InitializeComponent();
        }
        int loop = 0;
        string datum = "";

        public void funtion_add()
        {
            richTextBox1.Text = " -l- " + loop.ToString() + " -s- " + site_tx.Text + datum +" -b- "+ join_cb.Text;
        }

        private void function_add_Load(object sender, EventArgs e)
        {
            join_cb.Text = join_cb.Items[0].ToString();
        }

        private void test_btn_Click(object sender, EventArgs e)
        {
            Process.Start(site_tx.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datum += "\n"+" -d- " + data_cb.Text + " -c- " + data_tx.Text;
            loop += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            funtion_add();
        }
    }
}
