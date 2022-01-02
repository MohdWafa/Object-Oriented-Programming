using System;
using System.Collections.Generic;
using Task3.Subjects;
using Task3.Vaccines;

namespace Task3
{
    class Program
    {
        public class MediaOutlet
        {
            public void Publish()
            {//initializing the different particular databases
                SimpleGenomeDatabase SimpleGenomedatabase = Generators.PrepareGenomes();
                OvercomplicatedDatabase OverComplicateddatabase = Generators.PrepareOvercomplicatedDatabase(SimpleGenomedatabase);
                SimpleDatabase Simpledatabase = Generators.PrepareSimpleDatabase(SimpleGenomedatabase);
                ExcellDatabase Excelldatabase = Generators.PrepareExcellDatabase(SimpleGenomedatabase);
                
                //iterating through all the data in the OverComplicatedDatabase
                IteratorPattern OverComplicatedIteratorpattern = new OvercomplicatedDatabaseIteratorPattern(OverComplicateddatabase, SimpleGenomedatabase);
                while (OverComplicatedIteratorpattern.hasnextdata() != false)
                {
                    VirusData vdata = OverComplicatedIteratorpattern.getnextdata();
                    Console.WriteLine($"{vdata.ToString()}"); // displaying the data from the OverComplicatedDatabase
                }
                //iterating through all the data in the SimpleDatabase
                IteratorPattern SimpleIteratorpattern = new SimpleDatabaseIteratorPattern(Simpledatabase, SimpleGenomedatabase);
                while (SimpleIteratorpattern.hasnextdata() != false)
                {
                    VirusData vdata = SimpleIteratorpattern.getnextdata();
                    Console.WriteLine($"{vdata.ToString()}"); // displaying the data from the SimpleDatabase
                }
                //iterating through all the data in the ExcellDatabase
                IteratorPattern ExcelIteratorpattern = new ExcelDatabaseIteratorPattern(Excelldatabase, SimpleGenomedatabase);
                while (ExcelIteratorpattern.hasnextdata() != false)
                {
                    VirusData vdata = ExcelIteratorpattern.getnextdata();
                    Console.WriteLine($"{vdata.ToString()}");  // displaying the data from the ExcellDatabase
                }

                //ALL THE PARTICULAR DATA FROM THE DIFFERENT DATABASES IS STORED IN THE VARIABLE vdata!!
            }
        }

        public class Tester
        {
            public void Test()
            {
                var vaccines = new List<IVaccine>() { new AvadaVaccine(), new Vaccinator3000(), new ReverseVaccine() };

                foreach (var vaccine in vaccines)
                {
                    Console.WriteLine($"Testing {vaccine}");
                    var subjects = new List<ISubject>();
                    int n = 5;
                    for (int i = 0; i < n; i++)
                    {
                        subjects.Add(new Cat($"{i}"));
                        subjects.Add(new Dog($"{i}"));
                        subjects.Add(new Pig($"{i}"));
                    }

                    foreach (var subject in subjects)
                    {
                        // process of vaccination
                    }

                    var genomeDatabase = Generators.PrepareGenomes();
                    var Simpledatabase = Generators.PrepareSimpleDatabase(genomeDatabase);
                    // iteration over SimpleGenomeDatabase using solution from 1)
                    // subjects should be tested here using GetTested function


                    // iterating over Simpledatabase
                    //{
                    //foreach (var subject in subjects)
                    //{
                    //    subject.GetTested();
                    //}
                    //}

                    int aliveCount = 0;
                    foreach (var subject in subjects)
                    {
                        if (subject.Alive) aliveCount++;
                    }
                    Console.WriteLine($"{aliveCount} alive!");
                }
            }
        }
        public static void Main(string[] args)
        {
            var genomeDatabase = Generators.PrepareGenomes();
            var Simpledatabase = Generators.PrepareSimpleDatabase(genomeDatabase);
            var Excelldatabase = Generators.PrepareExcellDatabase(genomeDatabase);
            var OverComplicateddatabase = Generators.PrepareOvercomplicatedDatabase(genomeDatabase);
            var mediaOutlet = new MediaOutlet();
            mediaOutlet.Publish();




            // testing animals
            //var tester = new Tester();
            //tester.Test();
        }
    }
}
