using System.Collections.Generic;
using System.Linq;

namespace ResultsCombiners
{
    class SumResultsCombiner : IResultsCombiner
    {
        public int CombineResults(IEnumerable<int> results)
        {
            return results.Sum();
        }
    }
}