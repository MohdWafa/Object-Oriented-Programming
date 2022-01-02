using System;
using System.Collections.Generic;

namespace Task3
{
    public class GenomeData
    {
        public Guid Id { get; }
        public IReadOnlyList<string> Tags { get; }
        public string Genome { get; }
        public double Precision { get; }

        public GenomeData(Guid id, IReadOnlyList<string> tags, string genome, double precision)
        {
            Id = id;
            Tags = tags;
            Genome = genome;
            Precision = precision;
        }

        public override string ToString()
            => $"Genome: {Id} {Genome}, {Precision}";
    }

}
