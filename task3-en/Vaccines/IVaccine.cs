using System;
using System.Collections.Generic;
using System.Text;
using Task3.Subjects;

namespace Task3.Vaccines
{
    interface IVaccine
    {
        public string Immunity { get; }
        public double DeathRate { get; }
        //public int VisitDog(Dog dog);

        //public int VisitCat(Cat cat);

        //public int VisitPig(Pig pig);
    }
}
