namespace Hal_85
{
    partial class Giriş
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            this.şifre = new System.Windows.Forms.TextBox();
            this.Tuş1 = new System.Windows.Forms.Button();
            this.isim = new System.Windows.Forms.TextBox();
            this.yanlıs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.Info;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label1.Font = new System.Drawing.Font("Brush Script Std", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Image = global::Hal_85.Properties.Resources.lale_resimleri3;
            label1.Location = new System.Drawing.Point(200, 9);
            label1.Name = "label1";
            label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label1.Size = new System.Drawing.Size(260, 76);
            label1.TabIndex = 0;
            label1.Text = "Genç 85";
            // 
            // şifre
            // 
            this.şifre.Location = new System.Drawing.Point(340, 278);
            this.şifre.Name = "şifre";
            this.şifre.Size = new System.Drawing.Size(100, 20);
            this.şifre.TabIndex = 2;
            this.şifre.UseSystemPasswordChar = true;
            this.şifre.TextChanged += new System.EventHandler(this.şifre_TextChanged);
            // 
            // Tuş1
            // 
            this.Tuş1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tuş1.Location = new System.Drawing.Point(354, 304);
            this.Tuş1.Name = "Tuş1";
            this.Tuş1.Size = new System.Drawing.Size(75, 23);
            this.Tuş1.TabIndex = 3;
            this.Tuş1.Text = "Giriş";
            this.Tuş1.UseVisualStyleBackColor = true;
            this.Tuş1.Click += new System.EventHandler(this.Tuş1_Click);
            // 
            // isim
            // 
            this.isim.Location = new System.Drawing.Point(340, 246);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(100, 20);
            this.isim.TabIndex = 1;
            this.isim.TextChanged += new System.EventHandler(this.isim_TextChanged);
            // 
            // yanlıs
            // 
            this.yanlıs.AutoSize = true;
            this.yanlıs.BackColor = System.Drawing.SystemColors.Info;
            this.yanlıs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yanlıs.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yanlıs.ForeColor = System.Drawing.Color.Red;
            this.yanlıs.Location = new System.Drawing.Point(457, 358);
            this.yanlıs.Name = "yanlıs";
            this.yanlıs.Size = new System.Drawing.Size(179, 38);
            this.yanlıs.TabIndex = 4;
            this.yanlıs.Text = "Hatalı Giriş";
            this.yanlıs.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(228, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kullanıcı İsmi:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(265, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hal_85.Properties.Resources.prog;
            this.ClientSize = new System.Drawing.Size(666, 415);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yanlıs);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.Tuş1);
            this.Controls.Add(this.şifre);
            this.Controls.Add(label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Giriş";
            this.ShowIcon = false;
            this.Text = "Hal";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox şifre;
        private System.Windows.Forms.Button Tuş1;
        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.Label yanlıs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

