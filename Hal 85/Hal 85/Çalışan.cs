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
    public partial class Çalışan : Form
    {
        public Çalışan()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kişiler1_SelectedItemChanged(object sender, EventArgs e)
        {
            if(kişiler1.Text == "Ahmet Koza")
            {
                çalış1.Text = "1578";
                işgir1.Text = "29.03.1994";
                textBox4.Text = "2100 TL";
                alüc1.Text = "156.000 TL";
                checkBox1.Checked = true;
                checkBox2.Checked = false;
            }
            if (kişiler1.Text == "Murat Dalkılıç")
            {
                çalış1.Text = "578";
                işgir1.Text = "19.12.1999";
                textBox4.Text = "0 TL";
                alüc1.Text = "12.000 TL";
                checkBox1.Checked = true;
                checkBox2.Checked = false;
            }
            if (kişiler1.Text == "Osman Kel")
            {
                çalış1.Text = "3000";
                işgir1.Text = "21.09.1992";
                textBox4.Text = "1300 TL";
                alüc1.Text = "182.678 TL";
                checkBox1.Checked = false;
                checkBox2.Checked = true;
            }
            if (kişiler1.Text == "Evren Ölüm")
            {
                çalış1.Text = "102";
                işgir1.Text = "09.04.2001";
                textBox4.Text = "1100 TL";
                alüc1.Text = "8.000 TL";
                checkBox1.Checked = false;
                checkBox2.Checked = true;
            }
            if (kişiler1.Text == "Demirci Oğlu")
            {
                çalış1.Text = "300";
                işgir1.Text = "02.05.1999";
                textBox4.Text = "100 TL";
                alüc1.Text = "5.000 TL";
                checkBox1.Checked = true;
                checkBox2.Checked = false;
            }
            if (kişiler1.Text == "Eren Yalçın")
            {
                çalış1.Text = "700";
                işgir1.Text = "31.01.1997";
                textBox4.Text = "0 TL";
                alüc1.Text = "70.000 TL";
                checkBox1.Checked = true;
                checkBox2.Checked = false;
            }
            if (kişiler1.Text == "Canberk Karahan")
            {
                çalış1.Text = "80";
                işgir1.Text = "11.01.2001";
                textBox4.Text = "0 TL";
                alüc1.Text = "10.000 TL";
                checkBox1.Checked = true;
                checkBox2.Checked = false;
            }
            if (kişiler1.Text == "Baran Rusçuklu")
            {
                çalış1.Text = "150";
                işgir1.Text = "18.03.2001";
                textBox4.Text = "560 TL";
                alüc1.Text = "14.000 TL";
                checkBox1.Checked = false;
                checkBox2.Checked = true;
            }
            if (kişiler1.Text == "Berke Purde")
            {
                çalış1.Text = "19";
                işgir1.Text = "09.07.2001";
                textBox4.Text = " 0 TL";
                alüc1.Text = "3.000 TL";
                checkBox1.Checked = true;
                checkBox2.Checked = false;
            }
            if (kişiler1.Text == "Ulaş Bozdağ")
            {
                çalış1.Text = "100";
                işgir1.Text = "16.05.2000";
                textBox4.Text = "0 TL";
                alüc1.Text = "8.000 TL";
                checkBox1.Checked = false; 
                checkBox2.Checked = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void işgir1_TextChanged(object sender, EventArgs e)
        {

        }

        private void alüc1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
