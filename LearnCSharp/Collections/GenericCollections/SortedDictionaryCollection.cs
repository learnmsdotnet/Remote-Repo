using System.Collections.Generic;

namespace LearnCSharp.Collections.GenericCollections
{
    class SortedDictionaryCollection
    {
        public void GenericSortedDictionary()
        {
            //Create a Sorted Dictionary
            SortedDictionary<string, string> names = new SortedDictionary<string, string>();
            names.Add("1", "Sonoo");
            names.Add("4", "Peter");
            names.Add("5", "James");
            names.Add("3", "Ratan");
            names.Add("2", "Irfan");

            foreach(KeyValuePair<string, string> kv in names)
            {
                System.Console.WriteLine(kv.Key + " " + kv.Value);
            }

            /*
             * OP:
             * 1 Sonoo
             * 2 Irfan
             * 3 Ratan
             * 4 Peter
             * 5 James
             */

        }
    }
}
