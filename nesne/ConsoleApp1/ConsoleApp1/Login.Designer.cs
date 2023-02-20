
namespace ConsoleApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lnklblKayıtOl = new System.Windows.Forms.LinkLabel();
            this.Remember = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lnklblSifreUnuttm = new System.Windows.Forms.LinkLabel();
            this.btnIletisim = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(188, 130);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(181, 31);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(188, 168);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(181, 31);
            this.txtSifre.TabIndex = 3;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(114, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre :";
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(188, 247);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(142, 38);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lnklblKayıtOl
            // 
            this.lnklblKayıtOl.AutoSize = true;
            this.lnklblKayıtOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnklblKayıtOl.LinkColor = System.Drawing.Color.Black;
            this.lnklblKayıtOl.Location = new System.Drawing.Point(124, 288);
            this.lnklblKayıtOl.Name = "lnklblKayıtOl";
            this.lnklblKayıtOl.Size = new System.Drawing.Size(87, 25);
            this.lnklblKayıtOl.TabIndex = 5;
            this.lnklblKayıtOl.TabStop = true;
            this.lnklblKayıtOl.Text = "Kayıt Ol";
            this.lnklblKayıtOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblKayıtOl_LinkClicked);
            // 
            // Remember
            // 
            this.Remember.AutoSize = true;
            this.Remember.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Remember.Location = new System.Drawing.Point(188, 205);
            this.Remember.Name = "Remember";
            this.Remember.Size = new System.Drawing.Size(142, 29);
            this.Remember.TabIndex = 6;
            this.Remember.Text = "Beni Hatırla";
            this.Remember.UseVisualStyleBackColor = true;
            this.Remember.CheckedChanged += new System.EventHandler(this.Remember_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(375, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(375, 167);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(477, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(314, 477);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // lnklblSifreUnuttm
            // 
            this.lnklblSifreUnuttm.AutoSize = true;
            this.lnklblSifreUnuttm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnklblSifreUnuttm.LinkColor = System.Drawing.Color.Black;
            this.lnklblSifreUnuttm.Location = new System.Drawing.Point(275, 288);
            this.lnklblSifreUnuttm.Name = "lnklblSifreUnuttm";
            this.lnklblSifreUnuttm.Size = new System.Drawing.Size(164, 25);
            this.lnklblSifreUnuttm.TabIndex = 10;
            this.lnklblSifreUnuttm.TabStop = true;
            this.lnklblSifreUnuttm.Text = "Şifremi Unuttum";
            this.lnklblSifreUnuttm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblSifreUnuttm_LinkClicked);
            // 
            // btnIletisim
            // 
            this.btnIletisim.BackColor = System.Drawing.Color.Tan;
            this.btnIletisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIletisim.Location = new System.Drawing.Point(175, 316);
            this.btnIletisim.Name = "btnIletisim";
            this.btnIletisim.Size = new System.Drawing.Size(166, 53);
            this.btnIletisim.TabIndex = 11;
            this.btnIletisim.Text = "İletişim";
            this.btnIletisim.UseVisualStyleBackColor = false;
            this.btnIletisim.Click += new System.EventHandler(this.btnIletisim_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Tan;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdmin.Location = new System.Drawing.Point(280, 466);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(181, 38);
            this.btnAdmin.TabIndex = 12;
            this.btnAdmin.Text = "Admin Girişi";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(643, 516);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnIletisim);
            this.Controls.Add(this.lnklblSifreUnuttm);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Remember);
            this.Controls.Add(this.lnklblKayıtOl);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.LinkLabel lnklblKayıtOl;
        private System.Windows.Forms.CheckBox Remember;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel lnklblSifreUnuttm;
        private System.Windows.Forms.Button btnIletisim;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAdmin;
    }
}