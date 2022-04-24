using System;
using CAI_07_Indumentaria.Dominio;

namespace CAI_07_Indumentaria.Consola
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TipoIndumentariaCasual induCasual = new TipoIndumentariaCasual("China", 20.3);

            Indumentaria indumentaria = new IndumentariaPantalon(123, 20, "grande", 12.45, induCasual, true, "Jean");

            Console.WriteLine(indumentaria);
            Console.ReadKey();
            
        }
    }
}
