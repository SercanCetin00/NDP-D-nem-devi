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
    public partial class defter11 : Form
    {
        public defter11()
        {
            InitializeComponent();
        }

        private void yazdır11_Click(object sender, EventArgs e)
        {
            ekran11.Text = Mal_Kayıt.gönderilicek;
        }
    }
}
