using System;

namespace CallBackMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos un refri
            CRefri Refri = new CRefri(70, -20);
            Random rnd = new Random();

            //Creamos el sink
            CRefriSink sink1 = new CRefriSink();
            CTiendaSink sink2 = new CTiendaSink();

            //Adicionamos el sink al refri
            Refri.AgregarSink(sink1);
            Refri.AgregarSink(sink2);

            //El refri hace su trabajo
            while (Refri.Kilos > 0 && sink1.Paro==false)
            {
                //El refri trabaja y le quitamos kilos al azar
                Refri.Trabajar(rnd.Next(1, 5));
            }
        }
    }
}
