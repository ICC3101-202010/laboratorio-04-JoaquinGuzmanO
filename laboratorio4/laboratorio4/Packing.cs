using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorio4
{
    class Packing: CentralComputer
    {
        private int memory;
        private int memoryUsed;
        public Packing(int memory)
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
            return "La maquina de packing esta prendida";
        }
        public override string Reebot()
        {
            memoryUsed = 0;
            return "la maquina de packing se reinicio debido a que se le lleno la memoria";
        }
        public override string TurnOff()
        {
            return "la maquina de packing se apago";
        }
        public void SumMemory()
        {
            memoryUsed++;
        }
    }
}
