
namespace ProjeÖdevi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.meyvePictureBox = new System.Windows.Forms.PictureBox();
            this.başla = new System.Windows.Forms.Button();
            this.NarenciyeSeç = new System.Windows.Forms.Button();
            this.KatıMeyveSeç = new System.Windows.Forms.Button();
            this.katımeyveGroupBox = new System.Windows.Forms.GroupBox();
            this.katımeyveBilgi = new System.Windows.Forms.Label();
            this.katımeyvePictureBox = new System.Windows.Forms.PictureBox();
            this.narenciyeGroupBox = new System.Windows.Forms.GroupBox();
            this.narenciyeBilgi = new System.Windows.Forms.Label();
            this.narenciyePictureBox = new System.Windows.Forms.PictureBox();
            this.ToplamA = new System.Windows.Forms.Label();
            this.ToplamC = new System.Windows.Forms.Label();
            this.ToplamG = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.varsayılanDeger = new System.Windows.Forms.Label();
            this.meyveDeğerleri = new System.Windows.Forms.Label();
            this.sure = new System.Windows.Forms.Label();
            this.toplamVA = new System.Windows.Forms.Label();
            this.toplamVC = new System.Windows.Forms.Label();
            this.toplamGR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.meyvePictureBox)).BeginInit();
            this.katımeyveGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.katımeyvePictureBox)).BeginInit();
            this.narenciyeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.narenciyePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // meyvePictureBox
            // 
            this.meyvePictureBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.meyvePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.meyvePictureBox.Location = new System.Drawing.Point(29, 23);
            this.meyvePictureBox.Name = "meyvePictureBox";
            this.meyvePictureBox.Size = new System.Drawing.Size(281, 211);
            this.meyvePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.meyvePictureBox.TabIndex = 0;
            this.meyvePictureBox.TabStop = false;
            // 
            // başla
            // 
            this.başla.BackColor = System.Drawing.Color.PaleVioletRed;
            this.başla.Location = new System.Drawing.Point(29, 403);
            this.başla.Name = "başla";
            this.başla.Size = new System.Drawing.Size(100, 53);
            this.başla.TabIndex = 1;
            this.başla.Text = "BAŞLA";
            this.başla.UseVisualStyleBackColor = false;
            this.başla.Click += new System.EventHandler(this.başla_Click);
            // 
            // NarenciyeSeç
            // 
            this.NarenciyeSeç.BackColor = System.Drawing.Color.PaleVioletRed;
            this.NarenciyeSeç.Location = new System.Drawing.Point(212, 242);
            this.NarenciyeSeç.Name = "NarenciyeSeç";
            this.NarenciyeSeç.Size = new System.Drawing.Size(100, 30);
            this.NarenciyeSeç.TabIndex = 2;
            this.NarenciyeSeç.Text = "SEÇ";
            this.NarenciyeSeç.UseVisualStyleBackColor = false;
            this.NarenciyeSeç.Click += new System.EventHandler(this.NarenciyeSeç_Click);
            // 
            // KatıMeyveSeç
            // 
            this.KatıMeyveSeç.BackColor = System.Drawing.Color.PaleVioletRed;
            this.KatıMeyveSeç.Location = new System.Drawing.Point(212, 257);
            this.KatıMeyveSeç.Name = "KatıMeyveSeç";
            this.KatıMeyveSeç.Size = new System.Drawing.Size(100, 30);
            this.KatıMeyveSeç.TabIndex = 3;
            this.KatıMeyveSeç.Text = "SEÇ";
            this.KatıMeyveSeç.UseVisualStyleBackColor = false;
            this.KatıMeyveSeç.Click += new System.EventHandler(this.KatıMeyveSeç_Click);
            // 
            // katımeyveGroupBox
            // 
            this.katımeyveGroupBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.katımeyveGroupBox.Controls.Add(this.katımeyveBilgi);
            this.katımeyveGroupBox.Controls.Add(this.katımeyvePictureBox);
            this.katımeyveGroupBox.Controls.Add(this.KatıMeyveSeç);
            this.katımeyveGroupBox.Location = new System.Drawing.Point(337, 355);
            this.katımeyveGroupBox.Name = "katımeyveGroupBox";
            this.katımeyveGroupBox.Size = new System.Drawing.Size(519, 310);
            this.katımeyveGroupBox.TabIndex = 7;
            this.katımeyveGroupBox.TabStop = false;
            this.katımeyveGroupBox.Text = "Katı Meyve Sıkacağı";
            // 
            // katımeyveBilgi
            // 
            this.katımeyveBilgi.AutoSize = true;
            this.katımeyveBilgi.Location = new System.Drawing.Point(53, 234);
            this.katımeyveBilgi.Name = "katımeyveBilgi";
            this.katımeyveBilgi.Size = new System.Drawing.Size(0, 17);
            this.katımeyveBilgi.TabIndex = 5;
            // 
            // katımeyvePictureBox
            // 
            this.katımeyvePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("katımeyvePictureBox.Image")));
            this.katımeyvePictureBox.Location = new System.Drawing.Point(93, 44);
            this.katımeyvePictureBox.Name = "katımeyvePictureBox";
            this.katımeyvePictureBox.Size = new System.Drawing.Size(333, 175);
            this.katımeyvePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.katımeyvePictureBox.TabIndex = 4;
            this.katımeyvePictureBox.TabStop = false;
            // 
            // narenciyeGroupBox
            // 
            this.narenciyeGroupBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.narenciyeGroupBox.Controls.Add(this.narenciyeBilgi);
            this.narenciyeGroupBox.Controls.Add(this.narenciyePictureBox);
            this.narenciyeGroupBox.Controls.Add(this.NarenciyeSeç);
            this.narenciyeGroupBox.Location = new System.Drawing.Point(337, 23);
            this.narenciyeGroupBox.Name = "narenciyeGroupBox";
            this.narenciyeGroupBox.Size = new System.Drawing.Size(519, 288);
            this.narenciyeGroupBox.TabIndex = 8;
            this.narenciyeGroupBox.TabStop = false;
            this.narenciyeGroupBox.Text = "Narenciye Sıkacağı";
            // 
            // narenciyeBilgi
            // 
            this.narenciyeBilgi.AutoSize = true;
            this.narenciyeBilgi.Location = new System.Drawing.Point(53, 217);
            this.narenciyeBilgi.Name = "narenciyeBilgi";
            this.narenciyeBilgi.Size = new System.Drawing.Size(0, 17);
            this.narenciyeBilgi.TabIndex = 5;
            // 
            // narenciyePictureBox
            // 
            this.narenciyePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("narenciyePictureBox.Image")));
            this.narenciyePictureBox.Location = new System.Drawing.Point(93, 40);
            this.narenciyePictureBox.Name = "narenciyePictureBox";
            this.narenciyePictureBox.Size = new System.Drawing.Size(333, 171);
            this.narenciyePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.narenciyePictureBox.TabIndex = 3;
            this.narenciyePictureBox.TabStop = false;
            // 
            // ToplamA
            // 
            this.ToplamA.BackColor = System.Drawing.Color.LavenderBlush;
            this.ToplamA.Location = new System.Drawing.Point(26, 485);
            this.ToplamA.Name = "ToplamA";
            this.ToplamA.Size = new System.Drawing.Size(100, 53);
            this.ToplamA.TabIndex = 12;
            this.ToplamA.Text = "Toplam Vitamin A (iu)";
            this.ToplamA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToplamC
            // 
            this.ToplamC.BackColor = System.Drawing.Color.LavenderBlush;
            this.ToplamC.Location = new System.Drawing.Point(26, 556);
            this.ToplamC.Name = "ToplamC";
            this.ToplamC.Size = new System.Drawing.Size(100, 54);
            this.ToplamC.TabIndex = 13;
            this.ToplamC.Text = "Toplam Vitamin C (mg)";
            this.ToplamC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToplamG
            // 
            this.ToplamG.BackColor = System.Drawing.Color.LavenderBlush;
            this.ToplamG.Location = new System.Drawing.Point(26, 632);
            this.ToplamG.Name = "ToplamG";
            this.ToplamG.Size = new System.Drawing.Size(100, 54);
            this.ToplamG.TabIndex = 14;
            this.ToplamG.Text = "Toplam Gramaj (gr)";
            this.ToplamG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // varsayılanDeger
            // 
            this.varsayılanDeger.BackColor = System.Drawing.Color.LavenderBlush;
            this.varsayılanDeger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.varsayılanDeger.Location = new System.Drawing.Point(29, 254);
            this.varsayılanDeger.Name = "varsayılanDeger";
            this.varsayılanDeger.Size = new System.Drawing.Size(281, 52);
            this.varsayılanDeger.TabIndex = 15;
            this.varsayılanDeger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // meyveDeğerleri
            // 
            this.meyveDeğerleri.BackColor = System.Drawing.Color.LavenderBlush;
            this.meyveDeğerleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.meyveDeğerleri.Location = new System.Drawing.Point(29, 322);
            this.meyveDeğerleri.Name = "meyveDeğerleri";
            this.meyveDeğerleri.Size = new System.Drawing.Size(281, 52);
            this.meyveDeğerleri.TabIndex = 16;
            this.meyveDeğerleri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sure
            // 
            this.sure.BackColor = System.Drawing.Color.LavenderBlush;
            this.sure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sure.Location = new System.Drawing.Point(138, 403);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(172, 53);
            this.sure.TabIndex = 17;
            this.sure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toplamVA
            // 
            this.toplamVA.BackColor = System.Drawing.Color.LavenderBlush;
            this.toplamVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toplamVA.Location = new System.Drawing.Point(142, 484);
            this.toplamVA.Name = "toplamVA";
            this.toplamVA.Size = new System.Drawing.Size(168, 54);
            this.toplamVA.TabIndex = 18;
            this.toplamVA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toplamVC
            // 
            this.toplamVC.BackColor = System.Drawing.Color.LavenderBlush;
            this.toplamVC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toplamVC.Location = new System.Drawing.Point(142, 556);
            this.toplamVC.Name = "toplamVC";
            this.toplamVC.Size = new System.Drawing.Size(168, 54);
            this.toplamVC.TabIndex = 19;
            this.toplamVC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toplamGR
            // 
            this.toplamGR.BackColor = System.Drawing.Color.LavenderBlush;
            this.toplamGR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toplamGR.Location = new System.Drawing.Point(142, 632);
            this.toplamGR.Name = "toplamGR";
            this.toplamGR.Size = new System.Drawing.Size(168, 54);
            this.toplamGR.TabIndex = 20;
            this.toplamGR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(898, 698);
            this.Controls.Add(this.toplamGR);
            this.Controls.Add(this.toplamVC);
            this.Controls.Add(this.toplamVA);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.meyveDeğerleri);
            this.Controls.Add(this.varsayılanDeger);
            this.Controls.Add(this.ToplamG);
            this.Controls.Add(this.ToplamC);
            this.Controls.Add(this.ToplamA);
            this.Controls.Add(this.narenciyeGroupBox);
            this.Controls.Add(this.katımeyveGroupBox);
            this.Controls.Add(this.başla);
            this.Controls.Add(this.meyvePictureBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OYUN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.meyvePictureBox)).EndInit();
            this.katımeyveGroupBox.ResumeLayout(false);
            this.katımeyveGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.katımeyvePictureBox)).EndInit();
            this.narenciyeGroupBox.ResumeLayout(false);
            this.narenciyeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.narenciyePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox meyvePictureBox;
        private System.Windows.Forms.Button başla;
        private System.Windows.Forms.Button NarenciyeSeç;
        private System.Windows.Forms.Button KatıMeyveSeç;
        private System.Windows.Forms.GroupBox katımeyveGroupBox;
        private System.Windows.Forms.PictureBox katımeyvePictureBox;
        private System.Windows.Forms.GroupBox narenciyeGroupBox;
        private System.Windows.Forms.PictureBox narenciyePictureBox;
        private System.Windows.Forms.Label ToplamA;
        private System.Windows.Forms.Label ToplamC;
        private System.Windows.Forms.Label ToplamG;
        private System.Windows.Forms.Label katımeyveBilgi;
        private System.Windows.Forms.Label narenciyeBilgi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label varsayılanDeger;
        private System.Windows.Forms.Label meyveDeğerleri;
        private System.Windows.Forms.Label sure;
        private System.Windows.Forms.Label toplamVA;
        private System.Windows.Forms.Label toplamVC;
        private System.Windows.Forms.Label toplamGR;
    }
}

