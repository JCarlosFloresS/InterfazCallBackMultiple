using System;
using System.Collections.Generic;
using System.Text;

namespace CallBackMultiple
{
    class CRefriSink : IEventosRefri
    {
        private bool paro = false;
        public bool Paro { get { return paro; } }

        //Aqui colocamos los handlers de los eventos definidos en la interfaz
        public void EReservasBajas(int pKilos)
        {
            //Aqui colocamos todo el codigo necesario para ejecuar cuando suceda el evento

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Reservas bajas de alimentos");
            Console.WriteLine("Quedan {0} kilos", pKilos);
        }

        public void EDescongelado(int pGrados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("El refri se descongela");

            if (pGrados > 0)
                paro = true;
        }
    }
}
