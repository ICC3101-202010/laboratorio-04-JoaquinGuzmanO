using System;
using System.Collections.Generic;

namespace laboratorio4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int piezas = 10;

            Reception recepcion = new Reception(7);
            Storage almacenamiento = new Storage(2);
            Assembly ensamblaje = new Assembly(10);
            Check verificacion = new Check(3);
            Packing empaque = new Packing(1);
           
            CentralComputer[] Mlist = { recepcion, almacenamiento, ensamblaje, verificacion, empaque};

            for (int j = 0; j < Mlist.Length ; j++)
            {
                Mlist[j].TurnOnAll();
            }

            for (int i = 1; i < piezas+1; i++)
            {
                Console.WriteLine("esta pasando la pieza: "+i);

                recepcion.SumMemory();
                almacenamiento.SumMemory();
                ensamblaje.SumMemory();
                verificacion.SumMemory();
                empaque.SumMemory();

                
                if (recepcion.getMemoryUsed() == recepcion.getMemory())
                {
                    recepcion.reebotAll();
                }
                if (almacenamiento.getMemoryUsed() == almacenamiento.getMemory())
                {
                    almacenamiento.reebotAll();
                }
                if (ensamblaje.getMemoryUsed() == ensamblaje.getMemory())
                {
                    ensamblaje.reebotAll();
                }
                if (verificacion.getMemoryUsed() == verificacion.getMemory())
                {
                    verificacion.reebotAll();
                }
                if (empaque.getMemoryUsed() == empaque.getMemory())
                {
                    empaque.reebotAll();
                }          
            }

            for (int j = 0; j < Mlist.Length; j++)
            {
                Mlist[j].TurnOffAll();
            }
        }

    }
}
