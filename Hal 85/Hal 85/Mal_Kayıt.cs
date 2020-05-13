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
    public partial class Mal_Kayıt : Form
    {  
        public Mal_Kayıt()
        {
            InitializeComponent();
           
        }
        public static string gönderilicek;
        private void Künye_Enter(object sender, EventArgs e)
        {

        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            
            defter1 alan1 = new defter1();
            alan1.alıcı = "sercan çetin";
            alan1.cins = cins1.Text;
            alan1.adet = Convert.ToInt32(adet1.Text);
            alan1.kilo = Convert.ToDouble(kilo1.Text);
            alan1.fiyat = Convert.ToDouble(fiyat1.Text);
            alan1.tutar = Convert.ToDouble(tutar1.Text);
             List<defter1> deftertutucu = new List<defter1>();
            deftertutucu.Add(alan1);
            if (yazdır2.Checked == true) {
                
                gönderilicek = Convert.ToString(ekran.SelectedItem);
                defter11 df = new defter11();
                df.Show();
            }
            else{gönderilicek= Convert.ToString(ekran.SelectedItem) ;
           
            defter11 df = new defter11();
            df.Show();
        } }
            

        private void isim_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void künye1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cins1_TextChanged(object sender, EventArgs e)
        {
            if(cins1.Text=="Elma Granny")
            {
                künye1.Text = "101";
                fiyat1.Text = "5,50";
               
                double kilo11 = Convert.ToDouble(kilo1.Text);
                double fiyat = Convert.ToDouble(fiyat1.Text);
                double tutar = (kilo11 * fiyat);
                tutar1.Text = Convert.ToString(tutar);
                

            }
            if (cins1.Text == "Elma Golden")
            {
                
                künye1.Text = "103";
                fiyat1.Text = "3,80";
                double kilo11 = Convert.ToDouble(kilo1.Text);
                double fiyat = Convert.ToDouble(fiyat1.Text);
                double tutar = (kilo11 * fiyat);
                tutar1.Text = Convert.ToString(tutar);

            }
            if (cins1.Text == "Limon")
            {

                künye1.Text = "105";
                fiyat1.Text = "6,35";
                double kilo11 = Convert.ToDouble(kilo1.Text);
                double fiyat = Convert.ToDouble(fiyat1.Text);
                double tutar = (kilo11 * fiyat);
                tutar1.Text = Convert.ToString(tutar);

            }
            if (cins1.Text == "Portakal")
            {

                künye1.Text = "106";
                fiyat1.Text = "2,60";
                double kilo11 = Convert.ToDouble(kilo1.Text);
                double fiyat = Convert.ToDouble(fiyat1.Text);
                double tutar = (kilo11 * fiyat);
                tutar1.Text = Convert.ToString(tutar);

            }
            if (cins1.Text == "Çilek")
            {

                künye1.Text = "45";
                fiyat1.Text = "11";
                double kilo11 = Convert.ToDouble(kilo1.Text);
                double fiyat = Convert.ToDouble(fiyat1.Text);
                double tutar = (kilo11 * fiyat);
                tutar1.Text = Convert.ToString(tutar);

            }
            if (cins1.Text == "Armut")
            {

                künye1.Text = "33";
                fiyat1.Text = "6";
                double kilo11 = Convert.ToDouble(kilo1.Text);
                double fiyat = Convert.ToDouble(fiyat1.Text);
                double tutar = (kilo11 * fiyat);
                tutar1.Text = Convert.ToString(tutar);

            }
            if (cins1.Text == "Şeftali")
            {

                künye1.Text = "16";
                fiyat1.Text = "4,5";
                double kilo11 = Convert.ToDouble(kilo1.Text);
                double fiyat = Convert.ToDouble(fiyat1.Text);
                double tutar = (kilo11 * fiyat);
                tutar1.Text = Convert.ToString(tutar);

            }
            if (cins1.Text == "Kivi")
            {

                künye1.Text = "148";
                fiyat1.Text = "7,5";
                double kilo11 = Convert.ToDouble(kilo1.Text);
                double fiyat = Convert.ToDouble(fiyat1.Text);
                double tutar = (kilo11 * fiyat);
                tutar1.Text = Convert.ToString(tutar);

            }
            if (cins1.Text == "Mandalina")
            {

                künye1.Text = "81";
                fiyat1.Text = "3,5";
                double kilo11 = Convert.ToDouble(kilo1.Text);
                double fiyat = Convert.ToDouble(fiyat1.Text);
                double tutar = (kilo11 * fiyat);
                tutar1.Text = Convert.ToString(tutar);

            }
            if (cins1.Text == "İthal Muz")
            {

                künye1.Text = "100";
                fiyat1.Text = "12";
                double kilo11 = Convert.ToDouble(kilo1.Text);
                double fiyat = Convert.ToDouble(fiyat1.Text);
                double tutar = (kilo11 * fiyat);
                tutar1.Text = Convert.ToString(tutar);

            }
            if (cins1.Text == "Yerli Muz")
            {

                künye1.Text = "01";
                fiyat1.Text = "6,5";
                double kilo11 = Convert.ToDouble(kilo1.Text);
                double fiyat = Convert.ToDouble(fiyat1.Text);
                double tutar = (kilo11 * fiyat);
                tutar1.Text = Convert.ToString(tutar);

            }
        }

        public void kaydet1_Click(object sender, EventArgs e)
        {
            double y;
            double a=Convert.ToDouble(tutar11.Text);
            double hesapla = Convert.ToDouble(tutar1.Text);
            y = hesapla + a;
            tutar11.Text = y.ToString();
           
        
        }

        public void Ekle_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(adet1.Text) != 0)
            {
                string cins, adet, kilo, fiyat, tutar;
                cins = cins1.Text;
                adet = adet1.Text;
                kilo = kilo1.Text;
                fiyat = fiyat1.Text;
                tutar = tutar1.Text;
                ekran.Items.Add(cins + "  |  " + adet + " Adet |  " + kilo + "KG  |  " + fiyat + "TL  |  " + tutar + "TL|");
            }
            else { MessageBox.Show("Adet '0' olamaz");
                
            }


            
        }

        private void Sıfırla_Click(object sender, EventArgs e)
        {
            ekran.Items.Remove(ekran.SelectedItem);
        }

        private void TL1_Click(object sender, EventArgs e)
        {

        }

        private void hesapla1_Click(object sender, EventArgs e)
        {
            double y;
            double a = Convert.ToDouble(tutar11.Text);
            double hesapla = Convert.ToDouble(tutar1.Text);
            y = hesapla + a;
            tutar11.Text = y.ToString();
        }

        private void adet1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ekran_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ekran_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
