using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CallBackMultiple
{
    class CRefri
    {
        //Aqui guardamos todos los sinks con los que se comunicara el refir
        private ArrayList listaSinks = new ArrayList();

        private int kilosAlimentos = 0;
        private int grados = 0;

        public CRefri(int pKilos, int pGrados)
        {
            //Coloca los valores iniciales del refri
            kilosAlimentos = pKilos;
            grados = pGrados;
        }

        //Con este metodo adicionamos un sink
        public void AgregarSink(IEventosRefri pSink)
        {
            if (pSink != null)
                listaSinks.Add(pSink);
        }

        //Con este metodo eliminamos un sink
        public void EliminarSink(IEventosRefri pSink)
        {
            if (listaSinks.Contains(pSink))
                listaSinks.Remove(pSink);
        }

        //Propiedades necesarias
        public int Kilos { get { return kilosAlimentos; } }
        public int Grados { get { return grados; } }

        public void Trabajar(int pConsumo)
        {
            //Actualizamos los kilos del refri
            kilosAlimentos -= pConsumo;

            //Subimos la temperatura
            grados += 1;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0} kilos, {1} grados", kilosAlimentos, grados);

            //Verificamos si se cumple la condicion para invocare los handlers del evento
            if (kilosAlimentos < 10)
            {
                //Invocamois a los handlers de cada sink
                foreach (IEventosRefri handler in listaSinks)
                {
                    handler.EReservasBajas(kilosAlimentos);
                }
            }

            //Condicion para el evento de descongelado
            if (grados >= 0)
            {
                //Invocamos los handlers de cada sink
                foreach(IEventosRefri handler in listaSinks)
                {
                    handler.EDescongelado(grados);
                }
            }
        }
    }
}
