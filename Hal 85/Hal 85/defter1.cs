using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hal_85
{
    class defter1 : malisınıf
    {
       
        public string Alıcı
        {
            get { return alıcı; }
            set { alıcı = value; }
        }
        public string Cins
        {
            get { return cins; }
            set { cins = value; }
        }
        public int Adet
        {   
            get { return adet; }
            set { adet = value; }
        }
        public double Kilo
        {
            get { return kilo; }
            set { kilo = value; }
        }
        public double Fiyat
        {
            get { return fiyat; }
            set { fiyat = value; }
        }
        public double Tutar
        {
            get { return tutar; }
            set { tutar = value; }
        }


    }
}
