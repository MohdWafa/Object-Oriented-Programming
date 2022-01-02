using System;
using Solvers;

namespace Problems
{
    abstract class Problem
    {
        public string Name { get; }
        public Func<int> Computation { get; }

        public bool Solved { get; private set; }
        public int? Result { get; private set; }

        protected Problem(string name, Func<int> computation)
        {
            Name = name;
            Computation = computation;
        }

        protected void TryMarkAsSolved(int? result)
        {
            if (result.HasValue)
                MarkAsSolved(result.Value);
        }

        private void MarkAsSolved(int result)
        {
            Solved = true;
            Result = result;
        }

        public abstract void Accept(ISolver solver);

        public void markSolved()
        {
            TryMarkAsSolved(Computation.Invoke());
        }

        public void markSolved(int result)
        {
            TryMarkAsSolved(result);
        }
    }
}