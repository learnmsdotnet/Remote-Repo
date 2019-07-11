using System.Collections;

namespace LearnCollection
{
    //An empty class
    class Empty { }

    class ArrayListCollections
    {
        //add various dataTypes to ArrayList
        public void AddArrayListElement()
        {
            var data = new ArrayList();
            
            data.Add("Visual Basic");
            data.Add(344);
            data.Add(55);
            data.Add(new Empty());
            data.Remove(55);

            foreach (object el in data)
            {
                System.Console.WriteLine(el);
            }
        }

    }
}