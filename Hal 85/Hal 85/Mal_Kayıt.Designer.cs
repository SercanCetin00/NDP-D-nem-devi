namespace Hal_85
{
    partial class Mal_Kayıt
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
            this.Fatura = new System.Windows.Forms.GroupBox();
            this.isimtelefon = new System.Windows.Forms.ListBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.isim = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.kaydet = new System.Windows.Forms.Button();
            this.Sıfırla = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Ekle = new System.Windows.Forms.Button();
            this.künye1 = new System.Windows.Forms.TextBox();
            this.cins1 = new System.Windows.Forms.ComboBox();
            this.adet1 = new System.Windows.Forms.TextBox();
            this.fiyat1 = new System.Windows.Forms.TextBox();
            this.tutar1 = new System.Windows.Forms.TextBox();
            this.kilo1 = new System.Windows.Forms.TextBox();
            this.kaydet1 = new System.Windows.Forms.Button();
            this.ekran = new System.Windows.Forms.ListBox();
            this.tutar11 = new System.Windows.Forms.TextBox();
            this.TL = new System.Windows.Forms.Label();
            this.TL1 = new System.Windows.Forms.Label();
            this.yazdır2 = new System.Windows.Forms.RadioButton();
            this.Fatura.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fatura
            // 
            this.Fatura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Fatura.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Fatura.Controls.Add(this.isimtelefon);
            this.Fatura.Controls.Add(this.telefon);
            this.Fatura.Controls.Add(this.isim);
            this.Fatura.Controls.Add(this.listBox1);
            this.Fatura.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Fatura.Location = new System.Drawing.Point(6, 44);
            this.Fatura.Name = "Fatura";
            this.Fatura.Size = new System.Drawing.Size(782, 96);
            this.Fatura.TabIndex = 0;
            this.Fatura.TabStop = false;
            this.Fatura.Text = "                                                                                 " +
    "                E-Arşiv Fatura";
            this.Fatura.Enter += new System.EventHandler(this.Künye_Enter);
            // 
            // isimtelefon
            // 
            this.isimtelefon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.isimtelefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.isimtelefon.FormattingEnabled = true;
            this.isimtelefon.ItemHeight = 15;
            this.isimtelefon.Items.AddRange(new object[] {
            "İsim",
            "Telefon"});
            this.isimtelefon.Location = new System.Drawing.Point(22, 14);
            this.isimtelefon.Name = "isimtelefon";
            this.isimtelefon.Size = new System.Drawing.Size(81, 30);
            this.isimtelefon.TabIndex = 10;
            // 
            // telefon
            // 
            this.telefon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.telefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefon.Location = new System.Drawing.Point(109, 33);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(113, 15);
            this.telefon.TabIndex = 9;
            this.telefon.Text = ":";
            // 
            // isim
            // 
            this.isim.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.isim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.isim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.isim.Location = new System.Drawing.Point(109, 12);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(100, 15);
            this.isim.TabIndex = 8;
            this.isim.Text = "sercan çetin";
            this.isim.TextChanged += new System.EventHandler(this.isim_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Items.AddRange(new object[] {
            "Künye                          Cins                   Kap.\\AD.            Kilo   " +
                "              Fiyat                    Tutar       "});
            this.listBox1.Location = new System.Drawing.Point(6, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(770, 24);
            this.listBox1.TabIndex = 7;
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(299, 397);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(85, 46);
            this.kaydet.TabIndex = 1;
            this.kaydet.Text = "Yazdır";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // Sıfırla
            // 
            this.Sıfırla.Location = new System.Drawing.Point(160, 397);
            this.Sıfırla.Name = "Sıfırla";
            this.Sıfırla.Size = new System.Drawing.Size(83, 41);
            this.Sıfırla.TabIndex = 2;
            this.Sıfırla.Text = "Sil";
            this.Sıfırla.UseVisualStyleBackColor = true;
            this.Sıfırla.Click += new System.EventHandler(this.Sıfırla_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.MenuBar;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDark;
            this.dateTimePicker1.Location = new System.Drawing.Point(588, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(42, 397);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(75, 41);
            this.Ekle.TabIndex = 5;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // künye1
            // 
            this.künye1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.künye1.Location = new System.Drawing.Point(12, 163);
            this.künye1.Multiline = true;
            this.künye1.Name = "künye1";
            this.künye1.ReadOnly = true;
            this.künye1.Size = new System.Drawing.Size(105, 20);
            this.künye1.TabIndex = 7;
            this.künye1.TextChanged += new System.EventHandler(this.künye1_TextChanged);
            // 
            // cins1
            // 
            this.cins1.FormattingEnabled = true;
            this.cins1.Items.AddRange(new object[] {
            "Elma Granny",
            "Elma Golden",
            "Limon",
            "Çilek",
            "Armut",
            "Şeftali",
            "Portakal",
            "Kivi",
            "Mandalina",
            "İthal Muz",
            "Yerli Muz"});
            this.cins1.Location = new System.Drawing.Point(160, 163);
            this.cins1.Name = "cins1";
            this.cins1.Size = new System.Drawing.Size(115, 21);
            this.cins1.TabIndex = 8;
            this.cins1.TextChanged += new System.EventHandler(this.cins1_TextChanged);
            // 
            // adet1
            // 
            this.adet1.Location = new System.Drawing.Point(335, 163);
            this.adet1.Name = "adet1";
            this.adet1.Size = new System.Drawing.Size(49, 20);
            this.adet1.TabIndex = 9;
            this.adet1.Text = "0";
            this.adet1.TextChanged += new System.EventHandler(this.adet1_TextChanged);
            // 
            // fiyat1
            // 
            this.fiyat1.Location = new System.Drawing.Point(575, 163);
            this.fiyat1.Name = "fiyat1";
            this.fiyat1.Size = new System.Drawing.Size(70, 20);
            this.fiyat1.TabIndex = 11;
            // 
            // tutar1
            // 
            this.tutar1.Enabled = false;
            this.tutar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tutar1.Location = new System.Drawing.Point(713, 164);
            this.tutar1.Name = "tutar1";
            this.tutar1.Size = new System.Drawing.Size(69, 20);
            this.tutar1.TabIndex = 12;
            this.tutar1.TextChanged += new System.EventHandler(this.hesapla1_Click);
            // 
            // kilo1
            // 
            this.kilo1.Location = new System.Drawing.Point(439, 163);
            this.kilo1.Name = "kilo1";
            this.kilo1.Size = new System.Drawing.Size(89, 20);
            this.kilo1.TabIndex = 10;
            this.kilo1.Text = "0";
            // 
            // kaydet1
            // 
            this.kaydet1.Location = new System.Drawing.Point(520, 321);
            this.kaydet1.Name = "kaydet1";
            this.kaydet1.Size = new System.Drawing.Size(85, 42);
            this.kaydet1.TabIndex = 13;
            this.kaydet1.Text = "Hesapla";
            this.kaydet1.UseVisualStyleBackColor = true;
            this.kaydet1.Click += new System.EventHandler(this.cins1_TextChanged);
            // 
            // ekran
            // 
            this.ekran.FormattingEnabled = true;
            this.ekran.Location = new System.Drawing.Point(12, 258);
            this.ekran.Name = "ekran";
            this.ekran.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ekran.Size = new System.Drawing.Size(372, 95);
            this.ekran.TabIndex = 6;
            // 
            // tutar11
            // 
            this.tutar11.Location = new System.Drawing.Point(507, 369);
            this.tutar11.Name = "tutar11";
            this.tutar11.Size = new System.Drawing.Size(114, 20);
            this.tutar11.TabIndex = 14;
            this.tutar11.Text = "0";
            // 
            // TL
            // 
            this.TL.AutoSize = true;
            this.TL.Enabled = false;
            this.TL.Location = new System.Drawing.Point(653, 166);
            this.TL.Name = "TL";
            this.TL.Size = new System.Drawing.Size(20, 13);
            this.TL.TabIndex = 15;
            this.TL.Text = "TL";
            // 
            // TL1
            // 
            this.TL1.AutoSize = true;
            this.TL1.Enabled = false;
            this.TL1.Location = new System.Drawing.Point(627, 372);
            this.TL1.Name = "TL1";
            this.TL1.Size = new System.Drawing.Size(20, 13);
            this.TL1.TabIndex = 16;
            this.TL1.Text = "TL";
            this.TL1.Click += new System.EventHandler(this.TL1_Click);
            // 
            // yazdır2
            // 
            this.yazdır2.AutoSize = true;
            this.yazdır2.Location = new System.Drawing.Point(391, 412);
            this.yazdır2.Name = "yazdır2";
            this.yazdır2.Size = new System.Drawing.Size(92, 17);
            this.yazdır2.TabIndex = 17;
            this.yazdır2.TabStop = true;
            this.yazdır2.Text = "Hepsini Yazdır";
            this.yazdır2.UseVisualStyleBackColor = true;
            // 
            // Mal_Kayıt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Hal_85.Properties.Resources.sebzeler_1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yazdır2);
            this.Controls.Add(this.TL1);
            this.Controls.Add(this.TL);
            this.Controls.Add(this.tutar11);
            this.Controls.Add(this.kaydet1);
            this.Controls.Add(this.kilo1);
            this.Controls.Add(this.tutar1);
            this.Controls.Add(this.fiyat1);
            this.Controls.Add(this.adet1);
            this.Controls.Add(this.cins1);
            this.Controls.Add(this.künye1);
            this.Controls.Add(this.ekran);
            this.Controls.Add(this.Fatura);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Sıfırla);
            this.Controls.Add(this.kaydet);
            this.Name = "Mal_Kayıt";
            this.Text = "Mal_Kayıt";
            this.Fatura.ResumeLayout(false);
            this.Fatura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Fatura;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Button Sıfırla;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.ListBox isimtelefon;
        private System.Windows.Forms.TextBox künye1;
        private System.Windows.Forms.ComboBox cins1;
        private System.Windows.Forms.TextBox adet1;
        private System.Windows.Forms.TextBox fiyat1;
        private System.Windows.Forms.TextBox tutar1;
        private System.Windows.Forms.TextBox kilo1;
        private System.Windows.Forms.Button kaydet1;
        private System.Windows.Forms.ListBox ekran;
        private System.Windows.Forms.TextBox tutar11;
        private System.Windows.Forms.Label TL;
        private System.Windows.Forms.Label TL1;
        private System.Windows.Forms.RadioButton yazdır2;
    }
}