using System;
using System.Collections.Generic;
using Solvers;
using Problems;
using ResultsCombiners;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var solvers = new List<ISolver>()
            {
                new CPU("Intel i3", 2),
                new CPU("Ryzen 1600", 12),
                new CPU("Intel i9", 16),
                new CPU("Ryzen Threadripper", 24),
                new GPU("RTX 2080", 30, 8),
                new GPU("GTX 560", 40, 2),
                new WiFi("Airport", 30, 0.9),
                new WiFi("Home", 1000, 0.01),
                new Ethernet("Home", 1000)
            };


            var rng = new Random(1234);
            Func<int> getRandomResult = rng.Next;
            var problems = new List<Problem>()
            {
                new CPUProblem("Graph traversal", () => 42, 1),
                new CPUProblem("Bitcoin mining", getRandomResult, 50),
                new CPUProblem("Easy bitcoin mining", getRandomResult, 5),
                new GPUProblem("Dogecoin mining", getRandomResult, 5),
                new GPUProblem("Ethereum mining", getRandomResult, 8),
                new GPUProblem("Playerunknown's battlegrounds", getRandomResult, 5000),
                new GPUProblem("Crysis 3", getRandomResult, 10),
                new NetworkProblem("Web scraping", getRandomResult, 100),
                new NetworkProblem("Torrents", getRandomResult, 10000),
                new CompositeProblem("Distributed neural network", new List<Problem>(){
                    new CPUProblem("Data cleanup", () => 1, 5),
                    new GPUProblem("Learning", () => 5, 8),
                    new NetworkProblem("Synchronization", () => 8, 50),
                }, new SumResultsCombiner())
            };

            foreach (var problem in problems)
                TrySolveProblem(problem, solvers);
        }

        static void TrySolveProblem(Problem problem, IEnumerable<ISolver> solvers)
        {
            foreach (var solver in solvers)
            {
                
                problem.Accept(solver);
               
                if (problem.Solved)
                    break;
            }

            if (problem.Solved)
                Console.WriteLine($"Result of {problem.Name}: {problem.Result}");
            else
                Console.WriteLine($"{problem.Name} was not solved");

            Console.WriteLine(string.Empty);
        }
    }
}
