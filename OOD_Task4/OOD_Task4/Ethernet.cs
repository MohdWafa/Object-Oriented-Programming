using System;
using Problems;

namespace Solvers
{
    class Ethernet : NetworkDevice
    {
        public Ethernet(string model, int dataLimit) : base(model, dataLimit)
        {
            DeviceType = "Ethernet";
        }
       
        public override void networkvi(NetworkProblem prob)
        {
            Console.Write($"Solving {model} for {prob.Name}: ");
            base.networkvi(prob);
            Console.WriteLine();
        }
    }
}