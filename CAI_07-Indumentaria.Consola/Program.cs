using System;
using CAI_07_Indumentaria.Dominio;

namespace CAI_07_Indumentaria.Consola
{
    class MainClass
    {
        static TipoIndumentaria _tipoIndumentariaTemp;
        static Indumentaria _indumentariaTemp;
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            _tipoIndumentariaTemp = new TipoIndumentariaCasual("China", 20.3);

            _indumentariaTemp = new IndumentariaPantalon(123, 20, "grande", 12.45, null, true, "Jean");

            Console.WriteLine(_indumentariaTemp);
            Console.WriteLine(_indumentariaTemp.GetType());
            

            _tipoIndumentariaTemp = new TipoIndumentariaDeportiva("India", 20);

            _indumentariaTemp = new IndumentariaCamisa(123, 20, "grande", 12.45, _tipoIndumentariaTemp, true, "Jean");
            
            if (_indumentariaTemp.GetType() == typeof(Indumentaria))
            {
                Console.WriteLine("Es camisa");
            }
            else { Console.WriteLine("No es camisa"); }

            Console.ReadKey();

            Console.WriteLine(_indumentariaTemp);
            Console.WriteLine(_indumentariaTemp.GetType());



            Console.ReadKey();
        }
    }
}
