using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FutbolProje
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Futbol> takim = new List<Futbol>();
            takim.Add(new Futbol("Kaleci",1));
            takim.Add(new Futbol("Defans1",2));
            takim.Add(new Futbol("Defans2",3));
            takim.Add(new Futbol("Defans3",4));
            takim.Add(new Futbol("Defans4",5));
            takim.Add(new Futbol("OrtaSaha1",6));
            takim.Add(new Futbol("OrtaSaha2",7));
            takim.Add(new Futbol("OrtaSaha3",8));
            takim.Add(new Futbol("OrtaSaha4",9));
            takim.Add(new Futbol("Forvet1",10));
            takim.Add(new Futbol("Forvet2",11));

            Random rastgele = new Random();
            int FormaNo ;
            int paskontrol =12;
            Boolean gololabilir = true;
            FormaNo = rastgele.Next(1, 12);

            for (int i = 1; i < 12; i++)
            {
                while (paskontrol ==FormaNo)
                {
                FormaNo = rastgele.Next(1, 12);
                }
                paskontrol = FormaNo;
                if (!takim[FormaNo-1].PasVer())
                {
                    Console.WriteLine(FormaNo + "Numaralı oyuncunun pası başarısız !");
                    gololabilir = false;
                    break;
                }
                else
                {
                    Console.WriteLine(FormaNo + "Numaralı oyuncunun pası tam isabet.");
                    System.Threading.Thread.Sleep(1000);
                }
            
            }
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(FormaNo + "numaralı oyuncu kaleci  ile karşı karşıya");
            if (gololabilir =true)
            {
                if (takim[FormaNo -1 ].GolVurusu())
                {
                    Console.WriteLine("GOOOOOOOOOOLLLLLLLLLLLLLL !!...");
                }
            }
            else
            {
                Console.WriteLine("Az Farkla kaçırdı");
            }

            Console.ReadKey();
        }
    }
}
