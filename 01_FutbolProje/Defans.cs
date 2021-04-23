using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FutbolProje
{
    class Defans:Futbol
    {
       
        public int PozisonAlma { get; set; }
        public int Kafa { get; set; }
        public int Sicrama { get; set; }
        public Defans(string ADSoyad, int FOrmano)
        {
            this.AdSoyad = ADSoyad;
            this.FormaNo = FOrmano;
            Hiz = rastgeleSayi.Next(50, 90);  //rastgele 50-100 arasında oluşturdu
            Dayaniklilik = rastgeleSayi.Next(50, 90);  //rastgele 50-100 arasında oluşturdu
            Pas = rastgeleSayi.Next(50, 90);  //rastgele 50-100 arasında oluşturdu
            Sut = rastgeleSayi.Next(50, 90);  //rastgele 50-100 arasında oluşturdu
            Yetenek = rastgeleSayi.Next(50, 90);  //rastgele 50-100 arasında oluşturdu
            Kararlilik = rastgeleSayi.Next(50, 90);  //rastgele 50-100 arasında oluşturdu
            DogalForm = rastgeleSayi.Next(50, 90);  //rastgele 50-100 arasında oluşturdu
            Sans = rastgeleSayi.Next(50, 90);  //rastgele 50-100 arasında oluşturdu
            PozisonAlma = rastgeleSayi.Next(50, 90); //rastgele 50-100 arasında oluşturdu
            Kafa = rastgeleSayi.Next(50, 90); //rastgele 50-100 arasında oluşturdu
            Sicrama = rastgeleSayi.Next(50, 90); //rastgele 50-100 arasında oluşturdu
        }

        public override Boolean PasVer()
        {
            int pasSkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.3 + Dayaniklilik * 0.1 + DogalForm * 0.1 + Sans * 0.2);
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
            int GolSkor = Convert.ToInt32(Yetenek * 0.3 + Sut * 0.2 + Kararlilik * 0.1 + DogalForm * 0.1 + Kafa * 0.1 +Sicrama * 0.1+ Sans * 0.1);
            if (GolSkor > 70)
                return true;
            else
                return false;
        }
    }
}
