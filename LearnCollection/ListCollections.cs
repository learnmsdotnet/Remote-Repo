using System.Collections.Generic;

namespace LearnCollection
{
    class ListCollections
    {
        //C# List<T> example
        public void ListT()
        {
            //Create a list of string
            var names = new List<string>();
            names.Add("Microsoft");
            names.Add("IBM");
            names.Add("CISCO");
            names.Add("Sun Microsystems");
            names.Add("Apple");

            //iterate list elements using for..each loop
            foreach(string name in names)
                System.Console.WriteLine("Elements inside the list<string>: {0}", name);
        }

        //C# List<T> using collection initializer
        public void ListTCollectionInitializer()
        {
            //Create list of string using Collection Initializer
            var names = new List<string>() { "Microsoft", "Dell", "IBM", "CISCO", "Motorola" };

            //iterate list elements using for..each loop
            foreach(string name in names)
                System.Console.WriteLine("Elements inside the list<string>: {0}", name);
        }
    
        //C# List<T> and manipulations
        public void ListTManipulations()
        {
            var langs = new List<string>();

            langs.Add("Java");
            langs.Add("C#");
            langs.Add("C");
            langs.Add("C++");
            langs.Add("Ruby");
            langs.Add("Javascript");

            System.Console.WriteLine(langs.Contains("C#"));

            //displaying list data from an index position
            System.Console.WriteLine(langs[1]);
            System.Console.WriteLine(langs[2]);

            //using Remove method
            langs.Remove("C#");
            langs.Remove("C");

            //using Contains method
            System.Console.WriteLine(langs.Contains("C#"));

            //using Insert method
            langs.Insert(4, "Haskell");

            //using Sort method
            langs.Sort();

            //display the members of string variable
            foreach (string lang in langs)
            {
                System.Console.WriteLine(lang);
            }

            /*  OP:
            $ dotnet run
                True
                C#
                C
                False
                C++
                Haskell
                Java
                Javascript
                Ruby
            */
        }
    }
}