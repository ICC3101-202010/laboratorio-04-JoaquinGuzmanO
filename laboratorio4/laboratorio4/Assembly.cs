using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorio4
{
    class Assembly : CentralComputer
    {
        private int memory;
        private int memoryUsed;
        public Assembly(int memory)
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
            return "La maquina de ensamblaje esta prendida";
        }
        public override string Reebot()
        {
            memoryUsed = 0;
            return "la maquina de ensamblaje se reinicio debido a que se le lleno la memoria";
        }
        public override string TurnOff()
        {
            return "la maquina de ensamblaje se apago";
        }
        public void SumMemory()
        {
            memoryUsed++;
        }
    }
}
