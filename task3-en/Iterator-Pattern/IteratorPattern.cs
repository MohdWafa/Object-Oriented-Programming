using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public interface IteratorPattern
    {//basic interface for the different types of iterators
        VirusData getnextdata(); //gets the next element of VirusData from the respective Databases
        bool hasnextdata(); //checks whether the VirusData has a data after it, if not, i.e., it is the last element in the database, it returns false.
    }
}

