using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    public class VirusData
    {
        public string VirusName { get; }
        public double DeathRate { get; }
        public double InfectionRate { get; }
        public IReadOnlyList<GenomeData> Genomes { get; }

        public VirusData(string virusName, double deathRate, double infectionRate, IReadOnlyList<GenomeData> genomes)
        {
            VirusName = virusName;
            DeathRate = deathRate;
            InfectionRate = infectionRate;
            Genomes = genomes ?? new List<GenomeData>();
        }

        public override string ToString()
            => $"{VirusName}, death rate: {DeathRate}, infection rate: {InfectionRate}" +
                string.Join("", Genomes.Select(g => "\n\t" + g.ToString()));
    }
}
