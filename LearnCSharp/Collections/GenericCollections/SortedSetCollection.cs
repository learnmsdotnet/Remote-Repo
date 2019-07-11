using System.Collections.Generic;

namespace LearnCSharp.Collections.GenericCollections
{
    class SortedSetCollection
    {
        //generic SortedSet<T> class that stores elements using Add() method
        public void GenericSortedSetUsingAddMethod()
        {
            //Create a SortedSet of students
            var names = new SortedSet<string>();
            names.Add("Sonoo");
            names.Add("Ankit");
            names.Add("Peter");
            names.Add("Irfan");
            names.Add("Ankit"); //this will not be allowed in SortedSet<T>

            //iterate elements of the SortedSet using for..each loop
            foreach (var name in names)
                System.Console.WriteLine(name);

            /*
             Ankit
             Irfan
             Peter
             Sonoo
             */
        }

        public void GenericSortedSetUsingCollectionInitializer()
        {
            //Declaring and Initializing the SortedSet
            var names = new SortedSet<string>() { "Sonoo", "Ankit", "Peter", "Irfan", "Ankit" };

            //iterate elements of the SortedSet using for..each loop
            foreach (var name in names)
                System.Console.WriteLine(name);
        }

    }
}
