using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorio4
{
    class Reception : CentralComputer
    {
        private int memory;
        private int memoryUsed;

        public Reception(int memory)
        {
            this.memory = memory;        
        }
        public int getMemory()
        {
            return memory;
        }
        public int getMemoryUsed()
        {
            return memoryUsed;
        }
        public override string TurnOn()
        {
            memoryUsed = 0;
            return "La maquina de recepción esta prendida";
        }
        public override string Reebot()
        {
            memoryUsed = 0;
            return "la maquina de recepcion se reinicio debido a que se le lleno la memoria";
        }
        public override string TurnOff()
        {
            return "la maquina de recepcion se apago";
        }
        public void SumMemory()
        {
            memoryUsed++;
        }

    }
}
