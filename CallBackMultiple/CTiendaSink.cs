using System;
using System.Collections.Generic;
using System.Text;

namespace CallBackMultiple
{
    class CTiendaSink:IEventosRefri
    {
        public void EReservasBajas(int pKilos)
        {
            //Qui colocasmos el codigo necesario para ejecutzar cuando suceda el evento

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enviariamos sus viveres");
            Console.WriteLine("Seran {0} kilos", pKilos);
        }

        public void EDescongelado(int pGrados)
        {
            //Metodo vacio (no es recomendable tener un metodo vacio, pero como se ve el callback es necesario tenerlo)
        }
    }
}
