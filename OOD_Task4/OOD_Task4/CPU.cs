using System;
using Problems;

namespace Solvers
{
    class CPU : ISolver
    {
        private readonly string model;
        private readonly int threads;

        public CPU(string model, int threads)
        {
            this.model = model;
            this.threads = threads;
        }

        public void CPUvi(CPUProblem prob)
        {
           
            Console.Write($"Solving {model} for {prob.Name}:");
            if (prob.RequiredThreads < threads)
            {
                Console.WriteLine($"Cpu can solve");
                prob.markSolved();
            }
            else
            {
                Console.WriteLine($"Cpu can NOT solve");
            }
        }

        public void GPUvi(GPUProblem prob)
        {
            Console.WriteLine($"The {prob.Name} is a gpu problem and cannot solve by {model}"); 
        }

        public void networkvi(NetworkProblem prob)
        {
            Console.WriteLine($"The {prob.Name} is a network problem and cannot solve by {model}");
        }

        
    }
}