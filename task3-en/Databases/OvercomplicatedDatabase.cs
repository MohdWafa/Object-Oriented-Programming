using System.Collections.Generic;

namespace Task3
{
    public interface INode
    {
        public string VirusName { get; set; }
        public double DeathRate { get; set; }
        public double InfectionRate { get; set; }
        public string GenomeTag { get; set; }
        public List<INode> Children { get; }

    }

    public class StructuredDataNode : INode
    {
        public string VirusName { get; set; }
        public double DeathRate { get; set; }
        public double InfectionRate { get; set; }
        public string GenomeTag { get; set; }
        public List<INode> Children { get; } = new List<INode>();

        public StructuredDataNode(string virusName, double deathRate, double infectionRate, string genomeTag)
        {
            VirusName = virusName;
            DeathRate = deathRate;
            InfectionRate = infectionRate;
            GenomeTag = genomeTag;
        }
    }

    public class OvercomplicatedDatabase
    { 
        public INode Root { get; }

        public OvercomplicatedDatabase(INode root)
        {
            Root = root;
        }
    }
}
