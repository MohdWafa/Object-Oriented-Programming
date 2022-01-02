using System;
using Problems;

namespace Solvers
{
    class GPU : ISolver
    {
        static private int MaxTemperature { get; } = 100;
        static private int CPUProblemTemperatureMultiplier { get; } = 3;

        private readonly string model;
        private int temperature;
        private int coolingFactor;

        public GPU(string model, int temperature, int coolingFactor)
        {
            this.model = model;
            this.temperature = temperature;
            this.coolingFactor = coolingFactor;
        }
        private bool DidThermalThrottle()
        {
            if (temperature > MaxTemperature)
            {
                Console.WriteLine($"GPU {model} thermal throttled");
                CoolDown();
                return true;
            }

            return false;
        }

        private void CoolDown()
        {
            temperature -= coolingFactor;
        }

       
        public void CPUvi(CPUProblem prob)
        {
            Console.Write($"Solving {model} for {prob.Name}:");
            if (temperature <= MaxTemperature)
            {
                Console.Write($"CPU problem solved by GPU");
                prob.markSolved();
            }
            else
            {
                Console.Write($"CPU can NOT be solved by GPU");
                DidThermalThrottle();
            }
            temperature += prob.RequiredThreads * CPUProblemTemperatureMultiplier;
        }

        public void GPUvi(GPUProblem prob)
        {
            Console.Write($"Solving {model} for {prob.Name}:");
            if (temperature < MaxTemperature)
            {
                Console.WriteLine($"Gpu can solve");
                prob.markSolved();
            }
            else
            {
                Console.WriteLine($"Gpu can NOT solve");
                DidThermalThrottle();
            }
        }

        public void networkvi(NetworkProblem prob)
        {
            Console.WriteLine($"the {prob.Name} is a network problem and cannot solve by {model}");
        }
    }
}