using System.Collections;

namespace LearnCSharp.Collections.StandardCollections
{
    public class Empty { }

    public class ArrayListCollection
    {
        /// <summary>
        /// adding data to arraylist and retrieving them
        /// </summary>
        public void AddArrayListElement()
        {
            //ArrayList data = new ArrayList();

            var data1 = 2 + 2;                      //int
            var data2 = "Hello" + "world";          //string

            //defined an arraylist
            var data = new ArrayList();

            //adding data to the arrayList
            data.Add("Hello World");
            data.Add(344);
            data.Add(54);
            data.Add(new Empty());

            data.Remove(54);

            foreach (object ob in data)
            {
                System.Console.WriteLine(ob);
            }
             
        }
    }
}
