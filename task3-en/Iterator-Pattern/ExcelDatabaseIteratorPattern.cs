using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace Task3
{
    class ExcelDatabaseIteratorPattern : IteratorPattern
    {
        private List<SimpleDatabaseRow> row;
        private List<GenomeData> gdata;
        public ExcelDatabaseIteratorPattern(ExcellDatabase exceldatabase, SimpleGenomeDatabase simplegenomdatabase)
        {
            NumberFormatInfo provider = new NumberFormatInfo
            {
                NumberDecimalSeparator = ".",
                NumberGroupSeparator = ","
            };
            //Here we are seperating all the different values from the ExcelDatabase because, according to the task, the data is seperated using semi-colons in a string..
            string[] InfectionRates = exceldatabase.InfectionRates.Split(new char[] { ';' });
            string[] GenomeIds = exceldatabase.GenomeIds.Split(new char[] { ';' });
            string[] Names = exceldatabase.Names.Split(new char[] { ';' });
            string[] DeathRates = exceldatabase.DeathRates.Split(new char[] { ';' });
            row = new List<SimpleDatabaseRow>();

            //assigning the data received from the databases in Lists so easier to iterate!!
            for (int i = 0; i < Names.Length; i++)
            {
                SimpleDatabaseRow simpleDatabaseRow = new SimpleDatabaseRow();
                simpleDatabaseRow.VirusName = Names[i];
                simpleDatabaseRow.DeathRate = Convert.ToDouble(DeathRates[i], provider);//need this data in double, thats why
                simpleDatabaseRow.InfectionRate = Convert.ToDouble(InfectionRates[i], provider);//need this data in double, thats why
                simpleDatabaseRow.GenomeId = Guid.Parse(GenomeIds[i]);
                row.Add(simpleDatabaseRow);
            }

            gdata = new List<GenomeData>();
            gdata.AddRange(simplegenomdatabase.genomeDatas);
        }
        //getnextdata for excell database iterator pattern
        public VirusData getnextdata()
        {
            if (!hasnextdata()) return null;//checks if the element is the last in the list

            SimpleDatabaseRow simpleDatabaseRow = row.First();
            row.RemoveAt(0);
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
        //hasnextdata for excell database iterator pattern
        public bool hasnextdata()
        {
            if (row.Count > 0) return true;
            else return false;
        }
    }
}

