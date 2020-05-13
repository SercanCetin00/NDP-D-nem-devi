namespace Hal_85
{
    partial class defter11
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
            this.yazdır11 = new System.Windows.Forms.Button();
            this.ekran11 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // yazdır11
            // 
            this.yazdır11.Location = new System.Drawing.Point(334, 315);
            this.yazdır11.Name = "yazdır11";
            this.yazdır11.Size = new System.Drawing.Size(152, 55);
            this.yazdır11.TabIndex = 0;
            this.yazdır11.Text = "Yazdır";
            this.yazdır11.UseVisualStyleBackColor = true;
            this.yazdır11.Click += new System.EventHandler(this.yazdır11_Click);
            // 
            // ekran11
            // 
            this.ekran11.Location = new System.Drawing.Point(174, 75);
            this.ekran11.Multiline = true;
            this.ekran11.Name = "ekran11";
            this.ekran11.Size = new System.Drawing.Size(454, 200);
            this.ekran11.TabIndex = 1;
            // 
            // defter11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hal_85.Properties.Resources._5c8d6e1245d2a09e0097f3e0;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ekran11);
            this.Controls.Add(this.yazdır11);
            this.Name = "defter11";
            this.Text = "defter11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yazdır11;
        private System.Windows.Forms.TextBox ekran11;
    }
}