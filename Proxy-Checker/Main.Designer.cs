
namespace Proxy_Checker
{
    partial class Main
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
            this.file_path_tx = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radio_http = new System.Windows.Forms.RadioButton();
            this.radio_socks4 = new System.Windows.Forms.RadioButton();
            this.radio_socks5 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.good = new System.Windows.Forms.Label();
            this.bad = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File :";
            // 
            // file_path_tx
            // 
            this.file_path_tx.Location = new System.Drawing.Point(66, 33);
            this.file_path_tx.Name = "file_path_tx";
            this.file_path_tx.Size = new System.Drawing.Size(334, 20);
            this.file_path_tx.TabIndex = 1;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(425, 31);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 2;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.file_path_tx);
            this.groupBox1.Controls.Add(this.btn_browse);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proxy File";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_socks5);
            this.groupBox2.Controls.Add(this.radio_socks4);
            this.groupBox2.Controls.Add(this.radio_http);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bad);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.good);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(283, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Proxy Type :";
            // 
            // radio_http
            // 
            this.radio_http.AutoSize = true;
            this.radio_http.Checked = true;
            this.radio_http.Location = new System.Drawing.Point(138, 19);
            this.radio_http.Name = "radio_http";
            this.radio_http.Size = new System.Drawing.Size(54, 17);
            this.radio_http.TabIndex = 4;
            this.radio_http.TabStop = true;
            this.radio_http.Text = "HTTP";
            this.radio_http.UseVisualStyleBackColor = true;
            // 
            // radio_socks4
            // 
            this.radio_socks4.AutoSize = true;
            this.radio_socks4.Location = new System.Drawing.Point(138, 40);
            this.radio_socks4.Name = "radio_socks4";
            this.radio_socks4.Size = new System.Drawing.Size(61, 17);
            this.radio_socks4.TabIndex = 5;
            this.radio_socks4.TabStop = true;
            this.radio_socks4.Text = "Socks4";
            this.radio_socks4.UseVisualStyleBackColor = true;
            // 
            // radio_socks5
            // 
            this.radio_socks5.AutoSize = true;
            this.radio_socks5.Location = new System.Drawing.Point(138, 63);
            this.radio_socks5.Name = "radio_socks5";
            this.radio_socks5.Size = new System.Drawing.Size(61, 17);
            this.radio_socks5.TabIndex = 6;
            this.radio_socks5.TabStop = true;
            this.radio_socks5.Text = "Socks5";
            this.radio_socks5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Good :";
            // 
            // good
            // 
            this.good.AutoSize = true;
            this.good.ForeColor = System.Drawing.Color.LimeGreen;
            this.good.Location = new System.Drawing.Point(108, 33);
            this.good.Name = "good";
            this.good.Size = new System.Drawing.Size(13, 13);
            this.good.TabIndex = 8;
            this.good.Text = "0";
            // 
            // bad
            // 
            this.bad.AutoSize = true;
            this.bad.ForeColor = System.Drawing.Color.Red;
            this.bad.Location = new System.Drawing.Point(108, 60);
            this.bad.Name = "bad";
            this.bad.Size = new System.Drawing.Size(13, 13);
            this.bad.TabIndex = 10;
            this.bad.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Bad :";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 209);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(527, 23);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 248);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Proxy Checker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox file_path_tx;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_socks5;
        private System.Windows.Forms.RadioButton radio_socks4;
        private System.Windows.Forms.RadioButton radio_http;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label bad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label good;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_start;
    }
}

