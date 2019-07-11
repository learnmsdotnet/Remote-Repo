using System;
using System.Collections.Generic;

namespace LearnCollection
{
    class HashSetCollections
    {
        //example of generic HashSet<T> class that stores elements using Add() method and iterates elements using for-each loop.
        public void StoreElementsToHashSet()
        {
            // Create a set of strings  
            var names = new HashSet<string>();  
            names.Add("Sonoo");  
            names.Add("Ankit");  
            names.Add("Peter");  
            names.Add("Irfan");  
            names.Add("Ankit"); //will not be added  
            
            // Iterate HashSet elements using foreach loop  
            foreach (var name in names)  
            {  
                Console.WriteLine(name);  
            }   

            /* OP: 
                Sonoo
                Ankit
                Peter
                Irfan            
             */
        }

        //generic HashSet<T> class that stores elements using Collection initializer
        public void HashSetCollectionInitializer()
        {
            // Create a set of strings  
            var names = new HashSet<string>(){ "Sonoo", "Ankit", "Peter", "Irfan" };  
            
            // Iterate HashSet elements using foreach loop  
            foreach (var name in names)  
            {  
                Console.WriteLine(name);  
            }  

            /* OP: 
                Sonoo
                Ankit
                Peter
                Irfan            
            */
        }
    }
}