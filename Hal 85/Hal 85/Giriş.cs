using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hal_85
{
    public partial class Giriş : Form
    {
        int kontrol = 0;
        public Giriş()
        {
            InitializeComponent();
            
        }

        private void Tuş1_Click(object sender, EventArgs e)
        {   
            if (isim.Text == "sercan" && şifre.Text == "1903") {


                MessageBox.Show("Giriş Kabul\n Edildi...");

                this.Close();

                
               
            }
            else
            {
               
                 MessageBox.Show("Yanlış Giriş!");
                yanlıs.Visible = true;
                errorProvider1.SetError(isim, "Yanlış Kullanıcı İsmi");
                MessageBox.Show("Program kapatılıyor");

                Environment.Exit(0);
            }

        }
private void isim_TextChanged(object sender, EventArgs e)
        {
            yanlıs.Visible = false;
        }

        private void şifre_TextChanged(object sender, EventArgs e)
        {
            yanlıs.Visible = false;
            kontrol = kontrol + 1;
            
        }
    }
}
