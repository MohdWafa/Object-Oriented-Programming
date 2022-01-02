using System;
using System.Collections.Generic;
using System.Text;
using Task3.Subjects;

namespace Task3.Vaccines
{
    class ReverseVaccine : IVaccine
    {
        public string Immunity => "ACTGAGACAT";

        public double DeathRate => 0.05f;

        private Random randomElement = new Random(0);
        public override string ToString()
        {
            return "ReverseVaccine";
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
