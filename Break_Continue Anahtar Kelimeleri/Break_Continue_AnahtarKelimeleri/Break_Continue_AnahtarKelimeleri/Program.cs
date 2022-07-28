using System;

namespace Break_Continue_AnahtarKelimeleri
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)  //Break anahtar kelimesi koşul sağlanınca döngüden çıkmayı sağladı.
            {
                if (i==6)
                {
                    break;
                }
                Console.WriteLine("Break anahtar kelimesi ile say: "+i);
            }

            for (int i = 0; i < 10; i++) //Continue anahtar kelimesi koşul sağlanınca bir tur atladı sonra saymaya devam etti.
            {
                if (i==6)
                {
                    continue;
                }
                Console.WriteLine("Continue anahtar kelimesi ile say: "+i);
            }
        }
    }
}
