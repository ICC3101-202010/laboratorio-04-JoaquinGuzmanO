using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorio4
{
    abstract class CentralComputer
    {
        
        abstract public string TurnOn();
        abstract public string Reebot();
        abstract public string TurnOff();

        public void TurnOnAll()
        {
            Console.WriteLine(TurnOn());
        }
        public void TurnOffAll()
        {
            Console.WriteLine(TurnOff());
        }
        public void reebotAll()
        {
            Console.WriteLine(Reebot());
        }

    }
}
