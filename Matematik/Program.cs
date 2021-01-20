using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6);
            dortIslem.Cikarma(5, 6);
            dortIslem.Topla(44, 51);
            dortIslem.Cikarma(44, 51);
            dortIslem.SpecialAdd(15, 40);
            dortIslem.SpecialAdd(29, 35);

        }
    }
}


