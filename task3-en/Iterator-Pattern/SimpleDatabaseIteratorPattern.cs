using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Task3
{
    public class SimpleDatabaseIteratorPattern : IteratorPattern
    {
        private List<SimpleDatabaseRow> Rows;
        private List<GenomeData> gdata;
        public SimpleDatabaseIteratorPattern(SimpleDatabase simpleDatabase, SimpleGenomeDatabase simpleGenomeDatabase)
        {
            Rows = new List<SimpleDatabaseRow>();
            Rows.AddRange(simpleDatabase.Rows);
            gdata = new List<GenomeData>();
            gdata.AddRange(simpleGenomeDatabase.genomeDatas);
        }
        //getnextdata for simple database iterator pattern
        public VirusData getnextdata()
        {
            if (!hasnextdata()) return null;  //checks if the element is the last in the list

            SimpleDatabaseRow simpleDatabaseRow = Rows.First();
            Rows.RemoveAt(0);
            List<GenomeData> genomes = new List<GenomeData>();

            foreach (var g in gdata)
            {
                if (simpleDatabaseRow.GenomeId == g.Id)
                {
                    GenomeData genome = new GenomeData(g.Id, g.Tags, g.Genome, g.Precision);
                    genomes.Add(genome);
                    break;
                }
            }
            //assigning all the important data from simpledatabase to virusdata variable.
            VirusData vdata = new VirusData(simpleDatabaseRow.VirusName, simpleDatabaseRow.DeathRate, simpleDatabaseRow.InfectionRate, genomes);
            return vdata;
        }
        //hasnextdata for simple database iterator pattern
        public bool hasnextdata()
        {
            if (Rows.Count > 0) return true;
            else return false;
        }

    }
}

