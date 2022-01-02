using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    static class Generators
    {
        public static SimpleDatabase PrepareSimpleDatabase(SimpleGenomeDatabase simpleGenomeDatabase)
        {
            var list = new List<SimpleDatabaseRow>();

            var row = new SimpleDatabaseRow
            {
                GenomeId = simpleGenomeDatabase.genomeDatas.First().Id,
                VirusName = "flu",
                DeathRate = 0.01,
                InfectionRate = 90.01,
            };

            var row2 = new SimpleDatabaseRow
            {
                GenomeId = simpleGenomeDatabase.genomeDatas.Skip(1).First().Id,
                VirusName = "bird-flu",
                DeathRate = 0.1,
                InfectionRate = 80.0,
            };

            return new SimpleDatabase(new List<SimpleDatabaseRow> { row, row2 });
        }

        public static SimpleGenomeDatabase PrepareGenomes()
        {
            var r = new Random(123);
            var genomeDatas = new List<GenomeData>();
            var tags = new string[] { "virus", "deadly", "china", "poland", "usa", "measles", "sars", "rubella" };
            var genomes = new string[] { "ACTAG", "GACAT", "ACTAGA", "GGGG", "ACAC", "GACA", "AGGAC", "GACACAGA", "GACCA", "AAA", "TATAGA", "GAGATA" };

            for (int i = 0; i < 15; ++i)
            {
                var noTags = r.Next(1, 4);
                var listOfTags = new List<string>();
                for (int j = 0; j < noTags; ++j)
                {
                    listOfTags.Add(tags[r.Next(0, tags.Length)]);
                }
                var genomeData = new GenomeData(Guid.NewGuid(), listOfTags, genomes[r.Next(0, genomes.Length)], r.NextDouble() * 100);
                genomeDatas.Add(genomeData);
            }

            return new SimpleGenomeDatabase(genomeDatas);
        }

        public static ExcellDatabase PrepareExcellDatabase(SimpleGenomeDatabase simpleGenomeDatabase)
        {
            var ids = simpleGenomeDatabase.genomeDatas.Skip(9).Select(g => g.Id.ToString());
            var names = "measles;sars;rubella;chickenpox;smallpox;chikungunya";
            var deathRates = "20.0;12.321;33.33;0;05.0;1";
            var infectionRates = "90.0;72.321;1.33;100.00;10.0;0";
            var genomeIds = string.Join(";", ids);

            return new ExcellDatabase(names, deathRates, infectionRates, genomeIds);
        }

        public static OvercomplicatedDatabase PrepareOvercomplicatedDatabase(SimpleGenomeDatabase simpleGenomeDatabase)
        {
            var a = new StructuredDataNode("Influenza", 1.0, 20.0, "virus");
            var b = new StructuredDataNode("Herpes", 7.7, 12.0, "poland");
            var c = new StructuredDataNode("Ebola", 6.0, 20.0, "china");
            var d = new StructuredDataNode("Covid", 12.2, 3.0, "sars");
            var e = new StructuredDataNode("Mumps", 1.0, 23.0, "usa");
            var f = new StructuredDataNode("Rabies", 33.3, 70.0, "virus");
            var g = new StructuredDataNode("Rubella", 13.0, 90.0, "rubella");

            a.Children.Add(b);
            a.Children.Add(c);
            b.Children.Add(d);
            b.Children.Add(e);
            b.Children.Add(f);
            f.Children.Add(g);

            return new OvercomplicatedDatabase(a);
        }
    }
}
