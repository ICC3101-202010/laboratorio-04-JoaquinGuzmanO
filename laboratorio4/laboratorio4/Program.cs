using System;
using System.Collections.Generic;

namespace laboratorio4
{
    class Program
    {

        static void Main(string[] args)
        {
            Random Num = new Random();
            int piezas = Num.Next(1, 20);

            Reception recepcion = new Reception(Num.Next(1, 20));
            Storage almacenamiento = new Storage(Num.Next(1, 20));
            Assembly ensamblaje = new Assembly(Num.Next(1, 20));
            Check verificacion = new Check(Num.Next(1, 20));
            Packing empaque = new Packing(Num.Next(1, 20));

            Console.WriteLine("pasaran un total de " + piezas + " piezas");
            Console.WriteLine("recepcion tiene una memoria de: " + recepcion.getMemory());
            Console.WriteLine("almacenamiento tiene una memoria de: " + almacenamiento.getMemory());
            Console.WriteLine("ensamblaje tiene una memoria de: " + ensamblaje.getMemory());
            Console.WriteLine("verificacion tiene una memoria de: " + verificacion.getMemory());
            Console.WriteLine("empaque tiene una memoria de: " + empaque.getMemory());
            Console.WriteLine("##################################################");
            Console.WriteLine("##################################################");

            CentralComputer[] Mlist = { recepcion, almacenamiento, ensamblaje, verificacion, empaque };

            for (int j = 0; j < Mlist.Length; j++)
            {
                Mlist[j].TurnOnAll();
            }
            Console.WriteLine("##################################################");
            Console.WriteLine("##################################################");

            for (int i = 1; i < piezas + 1; i++)
            {
                Console.WriteLine("esta pasando la pieza: " + i);

                recepcion.SumMemory();
                almacenamiento.SumMemory();
                ensamblaje.SumMemory();
                verificacion.SumMemory();
                empaque.SumMemory();


                if (recepcion.getMemoryUsed() == recepcion.getMemory())
                {
                    Console.WriteLine("la memoria de recepcion se ha llenado,¿desea reiniciarla? escriba [si],[no]");
                    string decision1 = Console.ReadLine();
                    if (decision1 == "si")
                    {
                        recepcion.reebotAll();
                    }
                    if (decision1 == "no")
                    {
                        Console.WriteLine("al no reiniciar la memoria se ha detenido el prceso");
                        break;
                    }
                }
                if (almacenamiento.getMemoryUsed() == almacenamiento.getMemory())
                {
                    Console.WriteLine("la memoria de almacenamiento se ha llenado,¿desea reiniciarla? escriba [si],[no]");
                    string decision2 = Console.ReadLine();
                    if (decision2 == "si")
                    {
                        almacenamiento.reebotAll();
                    }
                    if (decision2 == "no")
                    {
                        Console.WriteLine("al no reiniciar la memoria se ha detenido el prceso");
                        break;
                    }
                }
                if (ensamblaje.getMemoryUsed() == ensamblaje.getMemory())
                {
                    Console.WriteLine("la memoria de ensamblaje se ha llenado,¿desea reiniciarla? escriba [si],[no]");
                    string decision3 = Console.ReadLine();
                    if (decision3 == "si")
                    {
                        ensamblaje.reebotAll();
                    }
                    if (decision3 == "no")
                    {
                        Console.WriteLine("al no reiniciar la memoria se ha detenido el prceso");
                        break;
                    }
                }
                if (verificacion.getMemoryUsed() == verificacion.getMemory())
                {
                    Console.WriteLine("la memoria de verificacion se ha llenado,¿desea reiniciarla? escriba [si],[no]");
                    string decision4 = Console.ReadLine();
                    if (decision4 == "si")
                    {
                        verificacion.reebotAll();
                    }
                    if (decision4 == "no")
                    {
                        Console.WriteLine("al no reiniciar la memoria se ha detenido el prceso");
                        break;
                    }
                }
                if (empaque.getMemoryUsed() == empaque.getMemory())
                {
                    Console.WriteLine("la memoria de empaque se ha llenado,¿desea reiniciarla? escriba [si],[no]");
                    string decision5 = Console.ReadLine();
                    if (decision5 == "si")
                    {
                        empaque.reebotAll();
                    }
                    if (decision5 == "no")
                    {
                        Console.WriteLine("al no reiniciar la memoria se ha detenido el prceso");
                        break;
                    }
                }
            }
            Console.WriteLine("##################################################");
            Console.WriteLine("##################################################");
            for (int j = 0; j < Mlist.Length; j++)
            {
                    Mlist[j].TurnOffAll();
            }
            

        }
    }
}
