using System;
using System.Collections.Generic;

namespace LearnCollection
{
    class SortedSetLst
    {
        //generic SortedSet<T> class that stores elements using Add() method
        public void GenericSortedSetUsingAddMethod()
        {
            // Create a set of strings  
            var names = new SortedSet<string>();  
            names.Add("Sonoo");  
            names.Add("Ankit");  
            names.Add("Peter");  
            names.Add("Irfan");  
            names.Add("Ankit"); //will not be added  
            
            // Iterate SortedSet elements using foreach loop  
            foreach (var name in names)  
            {  
                Console.WriteLine(name);  
            } 

            /*  OP: 
                 Ankit
                 Irfan
                 Peter
                 Sonoo
             */ 
        }

        //generic SortedSet<T> class that stores elements using Collection initializer
        public void GenericStoredSetUsingCollectionInitializer()
        {
             // Create a set of strings  
            var names = new SortedSet<string>() { "Sonoo", "Ankit", "Peter", "Irfan" };  
            
            // Iterate SortedSet elements using foreach loop  
            foreach (var name in names)  
            {  
                Console.WriteLine(name);  
            } 

            /* OP:
                Ankit
                Irfan
                Peter
                Sonoo
            */
        }
    }
}