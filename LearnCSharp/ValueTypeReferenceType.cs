using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    public class ValueTypeReferenceType
    {
        /// <summary>
        /// Understanding value type objects (this is the parent method)
        /// </summary>
        public void UnderstandingValueType()
        {
            int i = 100;

            //print the value of i
            Console.WriteLine(i);
            
            //passing the vale of i to another method with in the class 'changeValue'
            changeValue(i);
            
            //print the value of i again
            Console.WriteLine(i);
        }

        /// <summary>
        /// child variable
        /// </summary>
        /// <param name="x">x is an integer type for passing the value</param>
        private void changeValue(int i)
        {
            i = 200;

            Console.WriteLine(i);
        }

        /// <summary>
        /// Understanding reference type
        /// </summary>
        public void UnderstandingReferenceType()
        {
            String name = "Hello";

            Console.WriteLine(name);

            changeReferenceType(name);

            Console.WriteLine(name);
        }

        /// <summary>
        /// Child method for ref type
        /// </summary>
        /// <param name="name">ref type variable</param>
        private void changeReferenceType(String name)
        {
            name = "Hello World";

            Console.WriteLine(name);
        }

    }
}
