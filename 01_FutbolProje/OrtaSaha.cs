using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FutbolProje
{
    class OrtaSaha : Futbol
    {
        public int UzunTop { get; set; }
        public int IlkDokunus { get; set; }
        public int Uretkenlik { get; set; }
        public int TopSurme { get; set; }
        public int OzelYetenek { get; set; }
        public OrtaSaha(string ADSoyad, int FOrmano)
        {
            this.AdSoyad = ADSoyad;
            this.FormaNo = FOrmano;
            Hiz = rastgeleSayi.Next(60, 100);  //rastgele 60-100 arasında oluşturdu
            Dayaniklilik = rastgeleSayi.Next(60, 100);  //rastgele 60-100 arasında oluşturdu
            Pas = rastgeleSayi.Next(60, 100);  //rastgele 60-100 arasında oluşturdu
            Sut = rastgeleSayi.Next(60, 100);  //rastgele 60-100 arasında oluşturdu
            Yetenek = rastgeleSayi.Next(60, 100);  //rastgele 60-100 arasında oluşturdu
            Kararlilik = rastgeleSayi.Next(60, 100);  //rastgele 60-100 arasında oluşturdu
            DogalForm = rastgeleSayi.Next(60, 100);  //rastgele 60-100 arasında oluşturdu
            Sans = rastgeleSayi.Next(60, 100);     //rastgele 60-100 arasında oluşturdu

        }
        public override Boolean PasVer()
        {
            int pasSkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.2 +OzelYetenek*0.2+ Dayaniklilik * 0.1 + DogalForm * 0.1+UzunTop *0.1+TopSurme*0.1 + Sans * 0.1);
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
            int GolSkor = Convert.ToInt32(Yetenek * 0.3 +OzelYetenek * 0.2+ Sut * 0.2 +IlkDokunus *0.1+ Kararlilik * 0.1 + DogalForm * 0.1  + Sans * 0.1);
            if (GolSkor > 70)
                return true;
            else
                return false;
        }
    }
}
