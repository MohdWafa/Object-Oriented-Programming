using System.Collections.Generic;

namespace ResultsCombiners
{
    interface IResultsCombiner
    {
        int CombineResults(IEnumerable<int> results);
    }
}