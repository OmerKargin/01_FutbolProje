using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FutbolProje
{
    class Futbol
    {
      public  Random rastgeleSayi = new Random();
        public string AdSoyad { get; set; }
        public int FormaNo { get; set; }
        public int Hiz { get; set; }
        public int Dayaniklilik { get; set; }
        public int Pas { get; set; }
        public int Sut { get; set; }
        public int Yetenek { get; set; }
        public int Kararlilik { get; set; }
        public int DogalForm { get; set; }
        public int Sans { get; set; }
        public Futbol(string ADSoyad,int FOrmano)
        {
            Hiz = rastgeleSayi.Next(50, 100);  //rastgele 50-100 arasında oluşturdu
            Dayaniklilik = rastgeleSayi.Next(50, 100);  //rastgele 50-100 arasında oluşturdu
            Pas = rastgeleSayi.Next(50, 100);  //rastgele 50-100 arasında oluşturdu
            Sut = rastgeleSayi.Next(50, 100);  //rastgele 50-100 arasında oluşturdu
            Yetenek = rastgeleSayi.Next(50, 100);  //rastgele 50-100 arasında oluşturdu
            Kararlilik = rastgeleSayi.Next(50, 100);  //rastgele 50-100 arasında oluşturdu
            DogalForm = rastgeleSayi.Next(50, 100);  //rastgele 50-100 arasında oluşturdu
            Sans = rastgeleSayi.Next(50, 100);  //rastgele 50-100 arasında oluşturdu
            
           
        }
        public Futbol()
        {

        }
    
      public virtual Boolean PasVer()
      {
            int pasSkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.3 + Dayaniklilik * 0.1 + DogalForm * 0.1 + Sans * 0.2);
            if (pasSkor>60)
            {
                return true;
            }
            else
            {
                return false;
            }
        
      }
        public virtual Boolean GolVurusu()
        {
            int GolSkor = Convert.ToInt32(Yetenek * 0.3 + Sut * 0.2 + Kararlilik * 0.1 + DogalForm * 0.1 + Hiz * 0.1 + Sans * 0.2);
            if(GolSkor >70)
            return true;
            else
            return false;
        }

    }
}
