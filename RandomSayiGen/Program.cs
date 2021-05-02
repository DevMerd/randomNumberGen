using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSayiGen
{
    class Program
    {
        static void Main(string[] args)
        {
            int zar1, zar2;
            string isim,isimm;

            Console.Write("Birinci oyuncu ismi:");
            isim = Console.ReadLine();

            Console.Write("İkinci oyuncu ismi:");
            isimm=Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Birinci oyuncu ismi {0}, ikinci oyuncu ismi {1} HOŞGELDİNİZ\n", isim, isimm);

            Random sayiGen = new Random();
            zar1 = sayiGen.Next(1, 7);
            zar2= sayiGen.Next(1, 7);

            Console.Write("{0}={1}\n{2}={3}\n\n",isim,zar1,isimm,zar2);

            if (zar1 == zar2)
                Console.WriteLine("Berabere");
            else if (zar1 > zar2)
                Console.WriteLine("Birinci oyuncu kazandı");
            else
                Console.WriteLine("İkinci oyuncu kazandı");

            Console.ReadKey();

        }
    }
}
