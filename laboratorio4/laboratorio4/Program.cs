using System;
using System.Collections.Generic;

namespace laboratorio4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random Num = new Random();
            int piezas = Num.Next(1,50);

            Reception recepcion = new Reception(Num.Next(1, 50));
            Storage almacenamiento = new Storage(Num.Next(1, 50));
            Assembly ensamblaje = new Assembly(Num.Next(1, 50));
            Check verificacion = new Check(Num.Next(1, 50));
            Packing empaque = new Packing(Num.Next(1, 50));

            Console.WriteLine("pasaran un total de "+piezas+" piezas");
            Console.WriteLine("recepcion tiene una memoria de: "+recepcion.getMemory());
            Console.WriteLine("almacenamiento tiene una memoria de: " + almacenamiento.getMemory());
            Console.WriteLine("ensamblaje tiene una memoria de: " + ensamblaje.getMemory());
            Console.WriteLine("verificacion tiene una memoria de: " + verificacion.getMemory());
            Console.WriteLine("empaque tiene una memoria de: " + empaque.getMemory());

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
