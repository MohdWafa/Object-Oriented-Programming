using System;
using System.Collections.Generic;
using System.Text;
using Task3.Subjects;

namespace Task3.Vaccines
{
    class AvadaVaccine : IVaccine
    {
        public string Immunity => "ACTAGAACTAGGAGACCA";

        public double DeathRate => 0.2f;

        private Random randomElement = new Random(0);

        public override string ToString()
        {
            return "AvadaVaccine";
        }
        //public override Dog VisitDog(Dog dog)
        //{
        //    dog.Alive = true;
           
        //}
        //public override Cat VisitCat(Cat cat)
        //{

        //}
        //public override Pig VisitPig(Pig pig)
        //{
        //    pig.Alive = false;
        //    return pig;
        //}
    }
}
