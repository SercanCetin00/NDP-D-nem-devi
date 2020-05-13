namespace Hal_85
{
    partial class KullanıcıArayüzü
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
            this.KayıtList = new System.Windows.Forms.Button();
            this.DefterList = new System.Windows.Forms.Button();
            this.maliç = new System.Windows.Forms.ListBox();
            this.ÇalışanList = new System.Windows.Forms.Button();
            this.çaliç = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // KayıtList
            // 
            this.KayıtList.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayıtList.Location = new System.Drawing.Point(289, 97);
            this.KayıtList.Name = "KayıtList";
            this.KayıtList.Size = new System.Drawing.Size(136, 23);
            this.KayıtList.TabIndex = 1;
            this.KayıtList.Text = "Mal Kayıt";
            this.KayıtList.UseVisualStyleBackColor = true;
            this.KayıtList.TabIndexChanged += new System.EventHandler(this.KayıtList_TabIndexChanged);
            this.KayıtList.Click += new System.EventHandler(this.KayıtList_Click);
            this.KayıtList.Enter += new System.EventHandler(this.KayıtList_Click);
            // 
            // DefterList
            // 
            this.DefterList.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DefterList.Location = new System.Drawing.Point(586, 97);
            this.DefterList.Name = "DefterList";
            this.DefterList.Size = new System.Drawing.Size(136, 23);
            this.DefterList.TabIndex = 0;
            this.DefterList.Text = "Defter";
            this.DefterList.UseVisualStyleBackColor = true;
            this.DefterList.Click += new System.EventHandler(this.DefterList_Click);
            // 
            // maliç
            // 
            this.maliç.FormattingEnabled = true;
            this.maliç.Items.AddRange(new object[] {
            "Künye",
            "Cins ",
            "KAP.\\AD.",
            "Fiyat",
            "Tutar"});
            this.maliç.Location = new System.Drawing.Point(289, 137);
            this.maliç.Name = "maliç";
            this.maliç.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.maliç.Size = new System.Drawing.Size(136, 95);
            this.maliç.TabIndex = 3;
            this.maliç.Visible = false;
            this.maliç.DoubleClick += new System.EventHandler(this.maliç_DoubleClick);
            // 
            // ÇalışanList
            // 
            this.ÇalışanList.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ÇalışanList.Location = new System.Drawing.Point(12, 97);
            this.ÇalışanList.Name = "ÇalışanList";
            this.ÇalışanList.Size = new System.Drawing.Size(136, 23);
            this.ÇalışanList.TabIndex = 2;
            this.ÇalışanList.Text = "Çalışan Listesi";
            this.ÇalışanList.UseVisualStyleBackColor = true;
            this.ÇalışanList.Click += new System.EventHandler(this.ÇalışanList_Click);
            this.ÇalışanList.Enter += new System.EventHandler(this.ÇalışanList_Click);
            // 
            // çaliç
            // 
            this.çaliç.FormattingEnabled = true;
            this.çaliç.Items.AddRange(new object[] {
            "Giriş Tarihi:",
            "Adı....:",
            "Soyadı.:",
            "Çalıştığı Gün Sayısı.:",
            "Aldığı Para.:",
            "Çalışma Durumu:"});
            this.çaliç.Location = new System.Drawing.Point(12, 137);
            this.çaliç.Name = "çaliç";
            this.çaliç.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.çaliç.Size = new System.Drawing.Size(136, 95);
            this.çaliç.TabIndex = 4;
            this.çaliç.Visible = false;
            this.çaliç.DoubleClick += new System.EventHandler(this.çaliç_DoubleClick);
            // 
            // KullanıcıArayüzü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hal_85.Properties.Resources.meyve_resimleri_01;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.çaliç);
            this.Controls.Add(this.maliç);
            this.Controls.Add(this.DefterList);
            this.Controls.Add(this.KayıtList);
            this.Controls.Add(this.ÇalışanList);
            this.Name = "KullanıcıArayüzü";
            this.ShowIcon = false;
            this.Text = "KullanıcıArayüzü";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button KayıtList;
        private System.Windows.Forms.Button DefterList;
        private System.Windows.Forms.ListBox maliç;
        private System.Windows.Forms.Button ÇalışanList;
        private System.Windows.Forms.ListBox çaliç;
    }
}