using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
         float a = Convert.ToInt32(Console.ReadLine());
         float b = Convert.ToInt32(Console.ReadLine());
         float c = Convert.ToInt32(Console.ReadLine());
         float d = a*b/100;
         float e = a*c/100;
         float sonuc1 = a+d+e;
         object h = Math.Round(sonuc1);

         Console.WriteLine(h);

        }
    }
}
