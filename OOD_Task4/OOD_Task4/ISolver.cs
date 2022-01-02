using Problems;
using System;

namespace Solvers
{
    interface ISolver
    {
      
        void CPUvi(CPUProblem prob);
        void GPUvi(GPUProblem prob);
        void networkvi(NetworkProblem prob);
    }

}

