using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Task3
{
    public class OvercomplicatedDatabaseIteratorPattern : IteratorPattern// since this database keeps the data in a tree format(according to the question), the best method to use the iterator pattern was with the usage of nodes!!! 
    {
        private List<INode> N;
        private List<GenomeData> gdata;
        public OvercomplicatedDatabaseIteratorPattern(OvercomplicatedDatabase overcomplicatedDatabase, SimpleGenomeDatabase simplegdatabase)
        {
            N = new List<INode>();
            N.Add(overcomplicatedDatabase.Root);
            N.AddRange(overcomplicatedDatabase.Root.Children);
            foreach (var n in overcomplicatedDatabase.Root.Children)
            {
                N.AddRange(n.Children);
            }
            foreach (var n in overcomplicatedDatabase.Root.Children)
            {
                foreach (var nn in n.Children)
                {
                    N.AddRange(nn.Children);
                }
            }
            gdata = new List<GenomeData>();
            gdata.AddRange(simplegdatabase.genomeDatas);
        }
        //getnextdata for overcomplicated database iterator pattern
        public VirusData getnextdata()
        {
            if (!hasnextdata()) return null; //checks if the element is the last in the list

            INode node = N.First();
            N.RemoveAt(0);
            List<GenomeData> genomes = new List<GenomeData>();

            foreach (var g in gdata)
            {
                foreach (var t in g.Tags)
                {
                    if (node.GenomeTag == t)
                    {
                        GenomeData genome = new GenomeData(g.Id, g.Tags, g.Genome, g.Precision);
                        genomes.Add(genome);
                    }
                }
            }
            //assigning all the important data from database to virusdata variable.
            VirusData vdata = new VirusData(node.VirusName, node.DeathRate, node.InfectionRate, genomes);
            return vdata;
        }
        //hasnextdata for overcomplicated database iterator pattern
        public bool hasnextdata()
        {
            if (N.Count > 0) return true;
            else return false;
        }

    }
}

