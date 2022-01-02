using System;
using System.Collections.Generic;

namespace Task3
{
    public class ExcellDatabase
    {
        public string Names { get; }
        public string DeathRates { get; }
        public string InfectionRates { get; }
        public string GenomeIds { get; }

        public ExcellDatabase(string names, string deathRates, string infectionRates, string genomeIds)
        {
            Names = names;
            DeathRates = deathRates;
            InfectionRates = infectionRates;
            GenomeIds = genomeIds;
        }
    }

    public class SimpleDatabaseRow
    {
        public string VirusName { get; set; }
        public double DeathRate { get; set; }
        public double InfectionRate { get; set; }
        public Guid GenomeId { get; set; }
    }

    public class SimpleDatabase
    {
        public IReadOnlyList<SimpleDatabaseRow> Rows { get; }
        public SimpleDatabase(IEnumerable<SimpleDatabaseRow> simpleDatabaseRows)
        {
            var list = new List<SimpleDatabaseRow>();
            list.AddRange(simpleDatabaseRows);

            Rows = list;
        }
    }
}
