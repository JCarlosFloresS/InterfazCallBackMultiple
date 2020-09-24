using System;
using System.Collections.Generic;
using System.Text;

namespace CallBackMultiple
{
    interface IEventosRefri
    {
        //Definos los eventos que tendra el refri

        void EReservasBajas(int pKilos);

        //Adicionamos otro evento
        void EDescongelado(int pGrados);
    }
}
