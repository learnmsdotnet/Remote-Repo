using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    public class Collection
    {
        #region         "ArrayList"

        /// <summary>
        /// Declare an ArrayList
        /// </summary>
        public void DeclarArrayList()
        {
            ArrayList arrayList = new ArrayList();
        }

        /// <summary>
        /// Operations in ArrayList
        /// </summary>
        public void ArraysListOperations()
        {
            ArrayList arrayList = new ArrayList();

            //arrayList.Add(<element>)

            arrayList.Add(1);
            arrayList.Add("Example");
            arrayList.Add(true);

            Console.WriteLine(arrayList.Count);

            Console.WriteLine(arrayList.Contains(1));
            Console.WriteLine(arrayList.Contains(2));

            Console.WriteLine(arrayList[1]);

            arrayList.RemoveAt(1);
            Console.WriteLine(arrayList[1]);

            ArrayList arrayListEven = new ArrayList();
            arrayListEven.Add("2");
            arrayListEven.Add("4");
            arrayListEven.Add("6");
            arrayListEven.Add("8");
            arrayListEven.Add("10");
            arrayListEven.Add("12");
            arrayListEven.Add("14");
            arrayListEven.Add("16");
            arrayListEven.Add("20");

            foreach (int i in arrayListEven)
            {
                Console.WriteLine(i);
            }

            //RemoveRange - remove 4 elements starting from index 0
            arrayListEven.RemoveRange(0, 4);
            
        }

        #endregion
    }
}
