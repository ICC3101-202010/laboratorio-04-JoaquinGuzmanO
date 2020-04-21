using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorio4
{
    class Storage : CentralComputer
    {
        private int memory;
        private int memoryUsed;
        public Storage(int memory)
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
            return "La maquina de almacenamiento esta prendida";
        }
        public override string Reebot()
        {
            memoryUsed = 0;
            return "la maquina de almacenamiento se reinicio debido a que se le lleno la memoria";
        }
        public override string TurnOff()
        {
            return "la maquina de almacenamiento se apago";
        }
        public void SumMemory()
        {
            memoryUsed++;
        }
    }
}
