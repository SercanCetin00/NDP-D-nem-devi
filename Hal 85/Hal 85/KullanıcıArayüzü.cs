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
    public partial class KullanıcıArayüzü : Form
    {
        public KullanıcıArayüzü()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KayıtList_Click(object sender, EventArgs e)
        {
            
             maliç.Visible = true;

            
           
        }
       

        private void ÇalışanList_Click(object sender, EventArgs e)
        {
            çaliç.Visible = true;
        }

        private void KayıtList_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void maliç_DoubleClick(object sender, EventArgs e)
        {
            Mal_Kayıt göster = new Mal_Kayıt();
            göster.Show();

            
        }
        private void çaliç_DoubleClick(object sender, EventArgs e)
        {
            Çalışan göster1 = new Çalışan();
            göster1.Show();


        }

        private void DefterList_Click(object sender, EventArgs e)
        {
            defter11 göster11 = new defter11();
            göster11.Show();
        }
    }
}
