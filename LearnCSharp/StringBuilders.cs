using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    public class StringBuilders
    {
        /// <summary>
        /// Understanding StringBuilder types
        /// </summary>
        public void UnderstandingStringBuilders()
        {
            //Declaring a string builder
            StringBuilder sbName = new StringBuilder();

            //Declaring and assigning value to string builder
            StringBuilder sbFirstName = new StringBuilder("Hello World");

            //Declaring and assigning value to string builder
            sbFirstName = new StringBuilder("Reference Type: Unlike value types reference type don't store the _" +
                "values directly. Instead it stores the addess when the value is eing stored. (ref type contains pointer to another memory that holds the data)");
        }

        /// <summary>
        /// Functions available in string builder
        /// </summary>
        public void StringBuilderFunctions()
        {
            /* Append and AppendLine */

            StringBuilder sb = new StringBuilder("Hello");  //string sb = "Hello";
            sb.Append("Hello World");                       //sb = sb + "Hello World"; --> Hello Hello World (sb += "Hello World")
            sb.AppendLine("Hello World India");

            Console.WriteLine(sb);

            /* Output:
             * HelloHello World
             * Hello World India
             */

            /* AppendFormat() */
            //Output: Your total amount is: $ 25.00

            StringBuilder totalAmount = new StringBuilder("Your total amount is: ");
            totalAmount.AppendFormat("{0:C}", 25);
            Console.WriteLine(totalAmount);             //Your total amount is $ 25.00

            /* Insert() */
            //Output: Hello World
            //          Hello C# World (expected output)
            StringBuilder sbInsert = new StringBuilder("Hello World", 50);
            StringBuilder sbInsert1 = new StringBuilder(null);  //max size

            sbInsert.Insert(5, " C#");  //OP --> Hello C# World  

            /* Remove() */
            StringBuilder sbRemove = new StringBuilder("Hello World", 50);
            sb.Remove(6, 5);            //OP --> Hello

            /* Replace() */ //to replace all the occurances of a specified string
            StringBuilder sbReplace = new StringBuilder("Hello World", 50);
            //replace the word 'World' with 'C#'
            sbReplace.Replace("World", "C#");
            sbReplace.Replace("India", "C#");   //Output: Hello World

            Console.WriteLine(sbReplace);   //Output: Hello C#

            /* Indexer */ //to get or set a character at a specified index
            StringBuilder sbIndexer = new StringBuilder("Hello World!!", 50);

            //we will use the indexer to get all the characters of a stringbuilder using forloop
            for (int iCount = 0; iCount < sbIndexer.Length; iCount++)
            {
                Console.Write(sbIndexer[iCount]);
            }

            //Output: Hello World!!
        }
    }
}
