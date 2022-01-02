using System;
using Problems;

namespace Solvers
{
    abstract class NetworkDevice : ISolver
    {
        protected string DeviceType { get; set; } = "NetworkDevice";

        protected readonly string model;
       
        private int dataLimit;

        protected NetworkDevice(string model, int dataLimit)
        {
            this.model = model;
            this.dataLimit = dataLimit;
        }

       
        
        public void CPUvi(CPUProblem prob)
        {
            Console.WriteLine($"the {prob.Name} is a CPU problem and cannot solve by {model}");
        }

        public void GPUvi(GPUProblem prob)
        {
            Console.WriteLine($"the {prob.Name} is a GPU problem and cannot solve by {model}");
        }

        public virtual void networkvi(NetworkProblem prob)
        {
            if (dataLimit <= prob.DataToTransfer)
            {
                Console.Write($"Network can solve ");
                prob.markSolved();
            }
            else
            {
                Console.Write($"Network can NOT solve");
            }
        }
    }
}