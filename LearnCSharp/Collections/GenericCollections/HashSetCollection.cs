using System.Collections.Generic;

namespace LearnCSharp.Collections.GenericCollections
{
    public class HashSetCollection
    {
        public void StoreElementsToHashSet()
        {
            //HashSet<T> class that stores elements using Add() method and iterates elements using for-each loop

            //Declaration of a HashSet
            var names = new HashSet<string>();

            //adding data to the HashSet
            names.Add("Sonoo");
            names.Add("Ankit");
            names.Add("Peter");
            names.Add("Irfan");
            names.Add("Ankit"); //this will not be allowed in HashSet<T>

            //iterate elements of the HashSet using for..each loop
            foreach(var name in names)
                System.Console.WriteLine(name);

            /*
             Sonoo
             Ankit
             Peter
             Irfan
             */
        }

        public void HashSetCollectionInitializer()
        {
            //Declaring and Initializing the HashSet
            var names = new HashSet<string>() { "Sonoo", "Ankit", "Peter", "Irfan" };

            //iterate elements of the HashSet using for..each loop
            foreach (var name in names)
                System.Console.WriteLine(name);
        }
    }
}
