using System;
using System.Collections.Generic;

namespace LearnCollection
{
    class SortedDictionaryCollections
    {
        //generic SortedDictionary<TKey, TValue> class that stores elements (using KeyValuePair class to get key and value)
        public void GenericSortedDictionary()
        {
            SortedDictionary<string, string> names = new SortedDictionary<string, string>();  
            names.Add("1","Sonoo");    
            names.Add("4","Peter");    
            names.Add("5","James");    
            names.Add("3","Ratan");    
            names.Add("2","Irfan");  

            foreach (KeyValuePair<string, string> kv in names)  
            {  
                Console.WriteLine(kv.Key + " " + kv.Value);
            } 

            /* OP: 
                1 Sonoo
                2 Irfan
                3 Ratan
                4 Peter
                5 James            
             */ 
        }
    }
}