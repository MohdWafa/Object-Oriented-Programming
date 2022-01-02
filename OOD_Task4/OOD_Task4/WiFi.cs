using System;
using Problems;

namespace Solvers
{
    class WiFi : NetworkDevice
    {
        private readonly double packetLossChance;
        private static readonly Random rng = new Random(1597);

        public WiFi(string model, int dataLimit, double packetLossChance) : base(model, dataLimit)
        {
            DeviceType = "WiFi";
            this.packetLossChance = packetLossChance;
        }

        public override void networkvi(NetworkProblem prob)
        {
            Console.Write($"Solving {model} for {prob.Name}: ");
            if (rng.NextDouble() < packetLossChance)
            {
                base.networkvi(prob);
            }
            else
            {
                Console.WriteLine($"Wifi disconnects");
            }
        }
    }
}