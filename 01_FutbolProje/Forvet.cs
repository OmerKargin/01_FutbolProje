using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FutbolProje
{
    class Forvet:Futbol
    {
        public int Bitiricilik { get; set; }
        public int IlkDokunus { get; set; }
        public int Kafa { get; set; }
        public int OzelYetenek { get; set; }
        public int SogukKanlilik { get; set; }

        public Forvet(string ADSoyad, int FOrmano)
        {
            this.AdSoyad = ADSoyad;
            this.FormaNo = FOrmano;
            Hiz = rastgeleSayi.Next(70, 100);  //rastgele 70-100 arasında oluşturdu
            Dayaniklilik = rastgeleSayi.Next(70, 100);  //rastgele 70-100 arasında oluşturdu
            Pas = rastgeleSayi.Next(70, 100);  //rastgele 70-100 arasında oluşturdu
            Sut = rastgeleSayi.Next(70, 100);  //rastgele 70-100 arasında oluşturdu
            Yetenek = rastgeleSayi.Next(70, 100);  //rastgele 70-100 arasında oluşturdu
            Kararlilik = rastgeleSayi.Next(70, 100);  //rastgele 70-100 arasında oluşturdu
            DogalForm = rastgeleSayi.Next(70, 100);  //rastgele 70-100 arasında oluşturdu
            Sans = rastgeleSayi.Next(70, 100);        //rastgele 70-100 arasında oluşturdu
            Bitiricilik = rastgeleSayi.Next(70,100); //rastgele 70-100 arasında oluşturdu
            IlkDokunus = rastgeleSayi.Next(70,100); //rastgele 70-100 arasında oluşturdu
            Kafa = rastgeleSayi.Next(70,100);       //rastgele 70-100 arasında oluşturdu
            OzelYetenek = rastgeleSayi.Next(70,100); //rastgele 70-100 arasında oluşturdu
            SogukKanlilik = rastgeleSayi.Next(70,100); //rastgele 70-100 arasında oluşturdu
        }
        public override Boolean PasVer()
        {
            int pasSkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.2 +OzelYetenek*0.2+ Dayaniklilik * 0.1 + DogalForm * 0.1 + Sans * 0.1);
            if (pasSkor > 60)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public override Boolean GolVurusu()
        {
            int GolSkor = Convert.ToInt32(Yetenek * 0.2 +OzelYetenek * 0.2 + Sut * 0.1 + Kafa * 0.1 +IlkDokunus *Bitiricilik * 0.1+SogukKanlilik *0.1+Kararlilik *0.1+ DogalForm * 0.1 + Sans * 0.1);
            if (GolSkor > 70)
                return true;
            else
                return false;
        }
    }
}
