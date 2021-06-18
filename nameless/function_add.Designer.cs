namespace nameless
{
    partial class function_add
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
            this.label1 = new System.Windows.Forms.Label();
            this.question_tx = new System.Windows.Forms.TextBox();
            this.site_tx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.join_cb = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.data_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.okey_btn = new System.Windows.Forms.Button();
            this.cancel_tx = new System.Windows.Forms.Button();
            this.data_tx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soru";
            // 
            // question_tx
            // 
            this.question_tx.Location = new System.Drawing.Point(61, 12);
            this.question_tx.Name = "question_tx";
            this.question_tx.Size = new System.Drawing.Size(208, 20);
            this.question_tx.TabIndex = 1;
            // 
            // site_tx
            // 
            this.site_tx.Location = new System.Drawing.Point(61, 38);
            this.site_tx.Name = "site_tx";
            this.site_tx.Size = new System.Drawing.Size(208, 20);
            this.site_tx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Birleştirme";
            // 
            // join_cb
            // 
            this.join_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.join_cb.FormattingEnabled = true;
            this.join_cb.Items.AddRange(new object[] {
            "a,a",
            "a/a"});
            this.join_cb.Location = new System.Drawing.Point(61, 91);
            this.join_cb.Name = "join_cb";
            this.join_cb.Size = new System.Drawing.Size(75, 21);
            this.join_cb.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(61, 118);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(208, 56);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // data_cb
            // 
            this.data_cb.FormattingEnabled = true;
            this.data_cb.Items.AddRange(new object[] {
            "id",
            "classname"});
            this.data_cb.Location = new System.Drawing.Point(61, 64);
            this.data_cb.Name = "data_cb";
            this.data_cb.Size = new System.Drawing.Size(75, 21);
            this.data_cb.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Veri";
            // 
            // okey_btn
            // 
            this.okey_btn.Location = new System.Drawing.Point(61, 180);
            this.okey_btn.Name = "okey_btn";
            this.okey_btn.Size = new System.Drawing.Size(75, 23);
            this.okey_btn.TabIndex = 13;
            this.okey_btn.Text = "Tamam";
            this.okey_btn.UseVisualStyleBackColor = true;
            // 
            // cancel_tx
            // 
            this.cancel_tx.Location = new System.Drawing.Point(142, 180);
            this.cancel_tx.Name = "cancel_tx";
            this.cancel_tx.Size = new System.Drawing.Size(75, 23);
            this.cancel_tx.TabIndex = 14;
            this.cancel_tx.Text = "İptal";
            this.cancel_tx.UseVisualStyleBackColor = true;
            // 
            // data_tx
            // 
            this.data_tx.Location = new System.Drawing.Point(142, 64);
            this.data_tx.Name = "data_tx";
            this.data_tx.Size = new System.Drawing.Size(90, 20);
            this.data_tx.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "→";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // function_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(279, 207);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.data_tx);
            this.Controls.Add(this.cancel_tx);
            this.Controls.Add(this.okey_btn);
            this.Controls.Add(this.data_cb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.join_cb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.site_tx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.question_tx);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "function_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fonksiyon Ekle";
            this.Load += new System.EventHandler(this.function_add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox question_tx;
        private System.Windows.Forms.TextBox site_tx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox join_cb;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox data_cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button okey_btn;
        private System.Windows.Forms.Button cancel_tx;
        private System.Windows.Forms.TextBox data_tx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}