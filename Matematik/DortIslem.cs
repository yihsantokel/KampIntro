using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplama Sonucu : " + toplam);
        }

        public void SpecialAdd(int number1, int number2)
        {
            int sum1 = number1 + (2 * number2);
            Console.WriteLine(number1 + " + (2 * " + number2 + ") = " + sum1);
        }

        public void Cikarma(int sayi1, int sayi2)
        {
            int cikarma = sayi1 - sayi2;
            Console.WriteLine("Çıkarma Sonucu : " + cikarma);
        }
    }
}
