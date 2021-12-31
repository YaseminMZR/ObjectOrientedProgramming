
namespace Soru2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.devamEtButton = new System.Windows.Forms.Button();
            this.matrisTranspoz = new System.Windows.Forms.RadioButton();
            this.matrisİzBul = new System.Windows.Forms.RadioButton();
            this.matrisTersAl = new System.Windows.Forms.RadioButton();
            this.matrisOkuma = new System.Windows.Forms.RadioButton();
            this.matrisÇarp = new System.Windows.Forms.RadioButton();
            this.matrisTopla = new System.Windows.Forms.RadioButton();
            this.matrisYazdir = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.matrisBoyut = new System.Windows.Forms.ComboBox();
            this.SonuçLabel = new System.Windows.Forms.Label();
            this.matris1SS = new System.Windows.Forms.Label();
            this.hesaplaButton = new System.Windows.Forms.Button();
            this.matris2 = new System.Windows.Forms.GroupBox();
            this.matris1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dosyaYolu = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelSonuç = new System.Windows.Forms.Panel();
            this.sonuçGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelSonuç.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.devamEtButton);
            this.groupBox1.Controls.Add(this.matrisTranspoz);
            this.groupBox1.Controls.Add(this.matrisİzBul);
            this.groupBox1.Controls.Add(this.matrisTersAl);
            this.groupBox1.Controls.Add(this.matrisOkuma);
            this.groupBox1.Controls.Add(this.matrisÇarp);
            this.groupBox1.Controls.Add(this.matrisTopla);
            this.groupBox1.Controls.Add(this.matrisYazdir);
            this.groupBox1.Location = new System.Drawing.Point(389, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İŞLEMLER";
            // 
            // devamEtButton
            // 
            this.devamEtButton.BackColor = System.Drawing.Color.AliceBlue;
            this.devamEtButton.Location = new System.Drawing.Point(83, 281);
            this.devamEtButton.Name = "devamEtButton";
            this.devamEtButton.Size = new System.Drawing.Size(213, 60);
            this.devamEtButton.TabIndex = 7;
            this.devamEtButton.Text = "DEVAM ET";
            this.devamEtButton.UseVisualStyleBackColor = false;
            this.devamEtButton.Click += new System.EventHandler(this.devamEtButton_Click);
            // 
            // matrisTranspoz
            // 
            this.matrisTranspoz.AutoSize = true;
            this.matrisTranspoz.Location = new System.Drawing.Point(61, 234);
            this.matrisTranspoz.Name = "matrisTranspoz";
            this.matrisTranspoz.Size = new System.Drawing.Size(264, 28);
            this.matrisTranspoz.TabIndex = 6;
            this.matrisTranspoz.TabStop = true;
            this.matrisTranspoz.Text = "Matrisin Transpozunu Bul";
            this.matrisTranspoz.UseVisualStyleBackColor = true;
            // 
            // matrisİzBul
            // 
            this.matrisİzBul.AutoSize = true;
            this.matrisİzBul.Location = new System.Drawing.Point(61, 200);
            this.matrisİzBul.Name = "matrisİzBul";
            this.matrisİzBul.Size = new System.Drawing.Size(188, 28);
            this.matrisİzBul.TabIndex = 5;
            this.matrisİzBul.TabStop = true;
            this.matrisİzBul.Text = "Matrisin İzini Bul";
            this.matrisİzBul.UseVisualStyleBackColor = true;
            // 
            // matrisTersAl
            // 
            this.matrisTersAl.AutoSize = true;
            this.matrisTersAl.Location = new System.Drawing.Point(61, 166);
            this.matrisTersAl.Name = "matrisTersAl";
            this.matrisTersAl.Size = new System.Drawing.Size(201, 28);
            this.matrisTersAl.TabIndex = 4;
            this.matrisTersAl.TabStop = true;
            this.matrisTersAl.Text = "Matrisin Tersini Al";
            this.matrisTersAl.UseVisualStyleBackColor = true;
            // 
            // matrisOkuma
            // 
            this.matrisOkuma.AutoSize = true;
            this.matrisOkuma.Location = new System.Drawing.Point(61, 132);
            this.matrisOkuma.Name = "matrisOkuma";
            this.matrisOkuma.Size = new System.Drawing.Size(138, 28);
            this.matrisOkuma.TabIndex = 3;
            this.matrisOkuma.TabStop = true;
            this.matrisOkuma.Text = "Matrisi Oku";
            this.matrisOkuma.UseVisualStyleBackColor = true;
            // 
            // matrisÇarp
            // 
            this.matrisÇarp.AutoSize = true;
            this.matrisÇarp.Location = new System.Drawing.Point(61, 98);
            this.matrisÇarp.Name = "matrisÇarp";
            this.matrisÇarp.Size = new System.Drawing.Size(171, 28);
            this.matrisÇarp.TabIndex = 2;
            this.matrisÇarp.TabStop = true;
            this.matrisÇarp.Text = "Matrisleri Çarp";
            this.matrisÇarp.UseVisualStyleBackColor = true;
            // 
            // matrisTopla
            // 
            this.matrisTopla.AutoSize = true;
            this.matrisTopla.Location = new System.Drawing.Point(64, 64);
            this.matrisTopla.Name = "matrisTopla";
            this.matrisTopla.Size = new System.Drawing.Size(177, 28);
            this.matrisTopla.TabIndex = 1;
            this.matrisTopla.TabStop = true;
            this.matrisTopla.Text = "Matrisleri Topla";
            this.matrisTopla.UseVisualStyleBackColor = true;
            // 
            // matrisYazdir
            // 
            this.matrisYazdir.AutoSize = true;
            this.matrisYazdir.Location = new System.Drawing.Point(64, 30);
            this.matrisYazdir.Name = "matrisYazdir";
            this.matrisYazdir.Size = new System.Drawing.Size(159, 28);
            this.matrisYazdir.TabIndex = 0;
            this.matrisYazdir.TabStop = true;
            this.matrisYazdir.Text = "Matrisi Yazdır";
            this.matrisYazdir.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 513);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.matrisBoyut);
            this.panel2.Controls.Add(this.SonuçLabel);
            this.panel2.Controls.Add(this.matris1SS);
            this.panel2.Controls.Add(this.hesaplaButton);
            this.panel2.Controls.Add(this.matris2);
            this.panel2.Controls.Add(this.matris1);
            this.panel2.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1091, 513);
            this.panel2.TabIndex = 1;
            // 
            // matrisBoyut
            // 
            this.matrisBoyut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matrisBoyut.FormattingEnabled = true;
            this.matrisBoyut.Items.AddRange(new object[] {
            "1x1",
            "2x2",
            "3x3",
            "4x4",
            "5x5",
            "6x6",
            "7x7"});
            this.matrisBoyut.Location = new System.Drawing.Point(224, 38);
            this.matrisBoyut.Name = "matrisBoyut";
            this.matrisBoyut.Size = new System.Drawing.Size(121, 32);
            this.matrisBoyut.TabIndex = 1;
            this.matrisBoyut.SelectedIndexChanged += new System.EventHandler(this.matrisBoyut_SelectedIndexChanged);
            // 
            // SonuçLabel
            // 
            this.SonuçLabel.AutoSize = true;
            this.SonuçLabel.Location = new System.Drawing.Point(363, 41);
            this.SonuçLabel.Name = "SonuçLabel";
            this.SonuçLabel.Size = new System.Drawing.Size(84, 24);
            this.SonuçLabel.TabIndex = 2;
            this.SonuçLabel.Text = "Sonuç : ";
            this.SonuçLabel.Visible = false;
            // 
            // matris1SS
            // 
            this.matris1SS.AutoSize = true;
            this.matris1SS.Location = new System.Drawing.Point(87, 41);
            this.matris1SS.Name = "matris1SS";
            this.matris1SS.Size = new System.Drawing.Size(131, 24);
            this.matris1SS.TabIndex = 0;
            this.matris1SS.Text = "Satır x Sütun";
            // 
            // hesaplaButton
            // 
            this.hesaplaButton.BackColor = System.Drawing.Color.AliceBlue;
            this.hesaplaButton.Location = new System.Drawing.Point(450, 454);
            this.hesaplaButton.Name = "hesaplaButton";
            this.hesaplaButton.Size = new System.Drawing.Size(160, 53);
            this.hesaplaButton.TabIndex = 2;
            this.hesaplaButton.Text = "HESAPLA";
            this.hesaplaButton.UseVisualStyleBackColor = false;
            this.hesaplaButton.Click += new System.EventHandler(this.hesaplaButton_Click);
            // 
            // matris2
            // 
            this.matris2.Location = new System.Drawing.Point(567, 83);
            this.matris2.Name = "matris2";
            this.matris2.Size = new System.Drawing.Size(402, 341);
            this.matris2.TabIndex = 1;
            this.matris2.TabStop = false;
            this.matris2.Text = "İKİNCİ MATRİS";
            // 
            // matris1
            // 
            this.matris1.Location = new System.Drawing.Point(90, 83);
            this.matris1.Name = "matris1";
            this.matris1.Size = new System.Drawing.Size(402, 341);
            this.matris1.TabIndex = 0;
            this.matris1.TabStop = false;
            this.matris1.Text = "İLK MATRİS";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dosyaYolu);
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1091, 513);
            this.panel3.TabIndex = 3;
            // 
            // dosyaYolu
            // 
            this.dosyaYolu.AutoSize = true;
            this.dosyaYolu.Location = new System.Drawing.Point(34, 26);
            this.dosyaYolu.Name = "dosyaYolu";
            this.dosyaYolu.Size = new System.Drawing.Size(129, 24);
            this.dosyaYolu.TabIndex = 1;
            this.dosyaYolu.Text = "Dosya Yolu : ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(29, 62);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1035, 417);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panelSonuç
            // 
            this.panelSonuç.Controls.Add(this.sonuçGroupBox);
            this.panelSonuç.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelSonuç.Location = new System.Drawing.Point(12, 12);
            this.panelSonuç.Name = "panelSonuç";
            this.panelSonuç.Size = new System.Drawing.Size(1091, 513);
            this.panelSonuç.TabIndex = 3;
            // 
            // sonuçGroupBox
            // 
            this.sonuçGroupBox.Location = new System.Drawing.Point(334, 124);
            this.sonuçGroupBox.Name = "sonuçGroupBox";
            this.sonuçGroupBox.Size = new System.Drawing.Size(402, 341);
            this.sonuçGroupBox.TabIndex = 1;
            this.sonuçGroupBox.TabStop = false;
            this.sonuçGroupBox.Text = "SONUÇ MATRİS";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 60);
            this.button1.TabIndex = 8;
            this.button1.Text = "Başa Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(890, 531);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 60);
            this.button2.TabIndex = 9;
            this.button2.Text = "Programı Kapat";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1115, 593);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelSonuç);
            this.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MATRİS UYGULAMASI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelSonuç.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton matrisTranspoz;
        private System.Windows.Forms.RadioButton matrisİzBul;
        private System.Windows.Forms.RadioButton matrisTersAl;
        private System.Windows.Forms.RadioButton matrisOkuma;
        private System.Windows.Forms.RadioButton matrisÇarp;
        private System.Windows.Forms.RadioButton matrisTopla;
        private System.Windows.Forms.RadioButton matrisYazdir;
        private System.Windows.Forms.Button devamEtButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox matris1;
        private System.Windows.Forms.ComboBox matrisBoyut;
        private System.Windows.Forms.Label matris1SS;
        private System.Windows.Forms.Button hesaplaButton;
        private System.Windows.Forms.GroupBox matris2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label SonuçLabel;
        private System.Windows.Forms.Panel panelSonuç;
        private System.Windows.Forms.GroupBox sonuçGroupBox;
        private System.Windows.Forms.Label dosyaYolu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

