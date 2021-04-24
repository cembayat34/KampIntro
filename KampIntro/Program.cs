using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Dizi = new string[]
            {
                "1.eleman",
                "2.eleman",
                "3.eleman"
            };
            foreach (var item in Dizi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
