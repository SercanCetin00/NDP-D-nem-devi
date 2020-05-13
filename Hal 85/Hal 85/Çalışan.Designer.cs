namespace Hal_85
{
    partial class Çalışan
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.kişiler1 = new System.Windows.Forms.DomainUpDown();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.borç = new System.Windows.Forms.Label();
            this.giriş = new System.Windows.Forms.Label();
            this.ücret = new System.Windows.Forms.Label();
            this.Gün1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.işgir1 = new System.Windows.Forms.TextBox();
            this.alüc1 = new System.Windows.Forms.TextBox();
            this.çalış1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::Hal_85.Properties.Resources.Ofise_Meyve_Sepeti_9d68;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = global::Hal_85.Properties.Resources.Ofise_Meyve_Sepeti_9d68;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.borç);
            this.splitContainer1.Panel2.Controls.Add(this.giriş);
            this.splitContainer1.Panel2.Controls.Add(this.ücret);
            this.splitContainer1.Panel2.Controls.Add(this.Gün1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox4);
            this.splitContainer1.Panel2.Controls.Add(this.işgir1);
            this.splitContainer1.Panel2.Controls.Add(this.alüc1);
            this.splitContainer1.Panel2.Controls.Add(this.çalış1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(804, 452);
            this.splitContainer1.SplitterDistance = 276;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Hal_85.Properties.Resources.meyve_resimleri_01;
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.kişiler1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Location = new System.Drawing.Point(32, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 355);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çalışana dair seçenekler";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 65);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Çalışıyor";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.kişiler1_SelectedItemChanged);
            // 
            // kişiler1
            // 
            this.kişiler1.Items.Add("Ahmet Koza");
            this.kişiler1.Items.Add("Murat Dalkılıç");
            this.kişiler1.Items.Add("Osman Kel");
            this.kişiler1.Items.Add("Evren Ölüm");
            this.kişiler1.Items.Add("Demirci Oğlu");
            this.kişiler1.Items.Add("Eren Yalçın");
            this.kişiler1.Items.Add("Berke Purde");
            this.kişiler1.Items.Add("Canberk Karahan");
            this.kişiler1.Items.Add("Baran Rusçuklu");
            this.kişiler1.Items.Add("Ulaş Bozdağ");
            this.kişiler1.Location = new System.Drawing.Point(14, 39);
            this.kişiler1.Name = "kişiler1";
            this.kişiler1.ReadOnly = true;
            this.kişiler1.Size = new System.Drawing.Size(158, 20);
            this.kişiler1.TabIndex = 0;
            this.kişiler1.SelectedItemChanged += new System.EventHandler(this.kişiler1_SelectedItemChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(92, 65);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Çalışmıyor";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // borç
            // 
            this.borç.AutoSize = true;
            this.borç.Location = new System.Drawing.Point(215, 101);
            this.borç.Name = "borç";
            this.borç.Size = new System.Drawing.Size(69, 13);
            this.borç.TabIndex = 7;
            this.borç.Text = "Borç Durumu";
            // 
            // giriş
            // 
            this.giriş.AutoSize = true;
            this.giriş.Location = new System.Drawing.Point(215, 55);
            this.giriş.Name = "giriş";
            this.giriş.Size = new System.Drawing.Size(73, 13);
            this.giriş.TabIndex = 6;
            this.giriş.Text = "İşe Giriş Tarihi";
            // 
            // ücret
            // 
            this.ücret.AutoSize = true;
            this.ücret.Location = new System.Drawing.Point(81, 98);
            this.ücret.Name = "ücret";
            this.ücret.Size = new System.Drawing.Size(61, 13);
            this.ücret.TabIndex = 5;
            this.ücret.Text = "Aldığı Ücret";
            // 
            // Gün1
            // 
            this.Gün1.AutoSize = true;
            this.Gün1.Location = new System.Drawing.Point(81, 52);
            this.Gün1.Name = "Gün1";
            this.Gün1.Size = new System.Drawing.Size(93, 13);
            this.Gün1.TabIndex = 4;
            this.Gün1.Text = "Çalıştığı Gün sayısı";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(218, 120);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // işgir1
            // 
            this.işgir1.Location = new System.Drawing.Point(218, 71);
            this.işgir1.Name = "işgir1";
            this.işgir1.Size = new System.Drawing.Size(100, 20);
            this.işgir1.TabIndex = 2;
            this.işgir1.TextChanged += new System.EventHandler(this.işgir1_TextChanged);
            // 
            // alüc1
            // 
            this.alüc1.Location = new System.Drawing.Point(81, 120);
            this.alüc1.Name = "alüc1";
            this.alüc1.Size = new System.Drawing.Size(100, 20);
            this.alüc1.TabIndex = 1;
            this.alüc1.TextChanged += new System.EventHandler(this.alüc1_TextChanged);
            // 
            // çalış1
            // 
            this.çalış1.Location = new System.Drawing.Point(81, 71);
            this.çalış1.Name = "çalış1";
            this.çalış1.Size = new System.Drawing.Size(100, 20);
            this.çalış1.TabIndex = 0;
            this.çalış1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Çalışan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hal_85.Properties.Resources.Ofise_Meyve_Sepeti_9d68;
            this.ClientSize = new System.Drawing.Size(804, 452);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Çalışan";
            this.Text = "Çalışan";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DomainUpDown kişiler1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox işgir1;
        private System.Windows.Forms.TextBox alüc1;
        private System.Windows.Forms.TextBox çalış1;
        private System.Windows.Forms.Label borç;
        private System.Windows.Forms.Label giriş;
        private System.Windows.Forms.Label ücret;
        private System.Windows.Forms.Label Gün1;
    }
}