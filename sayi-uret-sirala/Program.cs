using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayi_uret_sirala
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Kaç Sayı Üretmek İstiyorsunuz ? =");
			byte adet = byte.Parse(Console.ReadLine());



			Random rnd = new Random();
			int[] sayilar = new int[adet];

			for (int i = 0; i < sayilar.Length; i++)
			{

				sayilar[i] = rnd.Next(1, 220);

			}

			//büyükten küçüğe sıralama

			Array.Sort(sayilar);
			Array.Reverse(sayilar);

			// diziyi yazdırıyoruz

			for (int i = 0; i < sayilar.Length; i++)
			{

				Console.WriteLine(sayilar[i]);

			}

			Console.ReadKey();
		}
    }
}
