using System.Collections.Generic;

namespace LearnCSharp.Collections.GenericCollections
{
    public class ListCollection
    {
        public void ListT()
        {
            //Create a list of string
            var names = new List<string>();
            names.Add("Microsoft");
            names.Add("IBM");
            names.Add("CISCO");
            names.Add("Sun Micro Systems");
            names.Add("Apple");

            foreach (string name in names)
                System.Console.WriteLine(name);
        }

        public void ListTCollectionInitializar()
        {
            var names = new List<string>() { "Microsoft", "IBM", "CISCO", "Sun Microsystem", "Apple" };

            foreach (string name in names)
                System.Console.WriteLine(name);
        }
    }
}
