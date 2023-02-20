
namespace ConsoleApp1
{
    partial class Iletisim
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
            this.btnGonder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMailAdresi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.Tan;
            this.btnGonder.Location = new System.Drawing.Point(300, 259);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(100, 34);
            this.btnGonder.TabIndex = 0;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adınız :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(220, 141);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(330, 112);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(220, 36);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(311, 29);
            this.txtAd.TabIndex = 4;
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(220, 71);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(311, 29);
            this.txtKonu.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Konu :";
            // 
            // txtMailAdresi
            // 
            this.txtMailAdresi.Location = new System.Drawing.Point(220, 106);
            this.txtMailAdresi.Name = "txtMailAdresi";
            this.txtMailAdresi.Size = new System.Drawing.Size(311, 29);
            this.txtMailAdresi.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mail Adresiniz :";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.Tan;
            this.btnGeriDon.Location = new System.Drawing.Point(463, 296);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(100, 34);
            this.btnGeriDon.TabIndex = 9;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Şikayetiniz / Öneriniz :";
            // 
            // Iletisim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(575, 342);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.txtMailAdresi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGonder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Iletisim";
            this.Text = "Iletisim";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Iletisim_FormClosed);
            this.Load += new System.EventHandler(this.Iletisim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMailAdresi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}