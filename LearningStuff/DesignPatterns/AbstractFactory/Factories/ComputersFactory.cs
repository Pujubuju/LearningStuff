using AbstractFactory.Models.Cpu;
using AbstractFactory.Models.Gpu;
using AbstractFactory.Models.Ram;

namespace AbstractFactory.Factories
{
    public abstract class ComputersFactory
    {
        public abstract Cpu CreateCpu();
        public abstract Gpu CreateGpu();
        public abstract Ram CreateRam();
    }
}
