
namespace ConsoleApp1
{
    partial class SifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttum));
            this.label11 = new System.Windows.Forms.Label();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnSifremiUnuttum = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(16, 142);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 25);
            this.label11.TabIndex = 34;
            this.label11.Text = "E-posta Adresi";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtEposta
            // 
            this.txtEposta.BackColor = System.Drawing.Color.Beige;
            this.txtEposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEposta.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEposta.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEposta.Location = new System.Drawing.Point(181, 134);
            this.txtEposta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(279, 33);
            this.txtEposta.TabIndex = 33;
            this.txtEposta.TextChanged += new System.EventHandler(this.txtEposta_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(30, 99);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 25);
            this.label12.TabIndex = 32;
            this.label12.Text = "Kullanıcı Adı";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.Beige;
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(181, 91);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(279, 33);
            this.txtKullaniciAdi.TabIndex = 31;
            this.txtKullaniciAdi.TextChanged += new System.EventHandler(this.txtKullaniciAdi_TextChanged);
            // 
            // btnSifremiUnuttum
            // 
            this.btnSifremiUnuttum.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSifremiUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifremiUnuttum.Location = new System.Drawing.Point(291, 175);
            this.btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            this.btnSifremiUnuttum.Size = new System.Drawing.Size(169, 63);
            this.btnSifremiUnuttum.TabIndex = 35;
            this.btnSifremiUnuttum.Text = "Şifremi Unuttum";
            this.btnSifremiUnuttum.UseVisualStyleBackColor = false;
            this.btnSifremiUnuttum.Click += new System.EventHandler(this.btnSifremiUnuttum_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BurlyWood;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(20, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 60);
            this.button1.TabIndex = 36;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.Tag = "";
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(483, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(652, 335);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSifremiUnuttum);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Name = "SifremiUnuttum";
            this.Text = "SifremiUnuttum";
            this.Load += new System.EventHandler(this.SifremiUnuttum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Button btnSifremiUnuttum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}