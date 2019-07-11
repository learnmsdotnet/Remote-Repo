using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    public class StringManipulations
    {
        /// <summary>
        /// Unserstanding string and String
        /// </summary>
        public void StringIntroduction()
        {
            string a = "india"; //reserved keyword to represent a string datatype (work with string)

            String b = "india"; //name of the class

            Console.WriteLine(a + "-" + b);
        }

        /// <summary>
        /// String methods
        /// </summary>
        public void StringFunctions()
        {
            string firstName;
            string lastName;

            firstName = "Steven Clark";
            lastName = "Clark";

            //Clone - Make clone/copy of the given string
            Console.WriteLine("Clone Method: " + firstName.Clone());
            Console.WriteLine("Clone Method: " + lastName.Clone());

            //Compare - Compares two string and returns 0 for true and 1 for false
            Console.WriteLine("Compare: " + firstName.CompareTo(lastName));     //1
            Console.WriteLine("Compare: " + firstName.CompareTo(firstName));    //0

            //Contains - Checks whether specified value exists or not (in the given string)
            Console.WriteLine("Contains: " + firstName.Contains("ven"));
            Console.WriteLine("Contains: " + firstName.Contains("xyz"));

            //EndsWith - Checks whether the last character of the string ends with n
            Console.WriteLine("Contains: " + firstName.EndsWith("n"));
            Console.WriteLine("Contains: " + firstName.EndsWith("k"));

            //Equals - Checks firstName and lastName are equal
            Console.WriteLine("Equals: " + firstName.Equals(lastName));
            Console.WriteLine("Equals: " + firstName.Equals(firstName));

            //IndexOf - returns the first index position of the specified value
            Console.WriteLine("IndexOf: " + firstName.IndexOf("e")); //2

            //ToLower - Converts string to lowercase
            Console.WriteLine("ToLower: " + firstName.ToLower()); //steven clark

            //ToUppper - Converts string to uppercase
            Console.WriteLine("ToUpper: " + firstName.ToUpper()); //STEVEN CLARK

            //Insert - Insert a substring to the string
            Console.WriteLine("Insert: " + firstName.Insert(0, "Hello")); //HelloSteven Clark
            Console.WriteLine("Insert: " + firstName.Insert(2, "Hello")); //StHelloeven Clark

            //LastIndexOf - Returns the last index position of the specified value
            Console.WriteLine("LastIndexOf: " + firstName.LastIndexOf("e")); //Steven Clark - 4

            //Length - Returns the length of the string
            Console.WriteLine("Length: " + firstName.Length); //Steven Clark - 12

            //Remove - Removes all the characters from the beginning to specified index
            Console.WriteLine("Remove: " + firstName.Remove(5)); //Steven Clark - Steve

            //Replace - Repalces the given char in the string
            Console.WriteLine("Replace: " + firstName.Replace('e', 'i')); //Steven Clark - Stivin Clark

            //Split - Splits the string based on the specified character
            string[] split = firstName.Split(new char[] {'e'});
            Console.WriteLine(split[0]);    //St
            Console.WriteLine(split[1]);    //v
            Console.WriteLine(split[2]);    //n Clark
            /*
             Steven Clark
             Output:   St
                       v
                       n Clark
            */

            split = firstName.Split(new char[] { ' ' });
            Console.WriteLine(split[0]);    //Steven
            Console.WriteLine(split[1]);    //Clark
            /*
            Output:   Steven
                      Clark
            */

            //StartsWith - Check whether the first char of the string is same as that of the specified value
            Console.WriteLine("StartsWith: " + firstName.StartsWith("S"));  //true
            Console.WriteLine("StartsWith: " + firstName.StartsWith("C"));  //false

            //Substring - Returns a part of string from the given string
            Console.WriteLine("Substring: " + firstName.Substring(2, 5));   //Steven Clark -- even

            //ToCharArray - Returns the string into character array
            Console.WriteLine(firstName.ToCharArray());
            /*
             Steven Clark
             S
             t
             e
             v
             e
             n

             C
             l
             a
             r
             k
             */

            //Trim - It removes starting and ending whitespaces from the string
            firstName = "             Steven Clark            ";
            Console.WriteLine("Trim: " + firstName.Trim());   //Steven Clark
        }
    }
}
