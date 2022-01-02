using System;
using System.Collections.Generic;
using System.Text;
using Task3.Subjects;

namespace Task3.Vaccines
{
    class Vaccinator3000 : IVaccine
    {
        public string Immunity => "ACTG";
        public double DeathRate => 0.1f;

        private Random randomElement = new Random(0);
        public override string ToString()
        {
            return "Vaccinator3000";
        }
        //public override int VisitDog(Dog dog)
        //{

        //}
        //public override int VisitCat(Cat cat)
        //{

        //}
        //public override int VisitPig(Pig pig)
        //{

        //}
    }
}
