using AbstractFactory.Models.Cpu;
using AbstractFactory.Models.Gpu;
using AbstractFactory.Models.Ram;

namespace AbstractFactory.Factories
{
    class GamingComputersFactory : ComputersFactory
    {
        public override Cpu CreateCpu()
        {
            return new IntelCpu();
        }

        public override Gpu CreateGpu()
        {
            return new NvidiaGeforce();
        }

        public override Ram CreateRam()
        {
            return new KingstonRam();
        }
    }
}
