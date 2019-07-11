using System;

namespace LearnCSharp
{
    public class Arrays
    {
        /// <summary>
        /// Initializing an array
        /// </summary>
        public void ArrayDeclarationAndInitilization()
        {
            //multiple variable declaration of same datatype
            //int num1, num2, num3, num4, num5, num6, ..., num1000;

            //to overcome the above limitation we have arrays
            int[] num = new int[100];

            int[] intArray = new int[6];

            //storing values inside the array
            intArray[0] = 2;
            intArray[1] = 4;
            intArray[2] = 5;
            intArray[3] = 6;
            intArray[4] = 7;
            intArray[5] = 8;

            //accessing the value stored inside the array
            Console.WriteLine("the value available at index 0: {0}", intArray[0]);
            Console.WriteLine("the value available at index 1: {0}", intArray[1]);
            Console.WriteLine("the value available at index 2: {0}", intArray[2]);
            Console.WriteLine("the value available at index 3: {0}", intArray[3]);
            Console.WriteLine("the value available at index 4: {0}", intArray[4]);
            Console.WriteLine("the value available at index 5: {0}", intArray[5]);
        }

        /// <summary>
        /// Storing values to an array
        /// </summary>
        public void StoringValuesUsingInlineApproach()
        {
            //inline approach
            int[] num = new int[5] { 1, 2, 3, 4, 5 };
        }

        /// <summary>
        /// Array to accept value from user
        /// </summary>
        public void AcceptValuesFromUserAndDisplayOutput()
        {
            //create an interger array of size 5
            int[] arr = new int[5];
            //used in for.loop incrementer
            int iCount;

            //Accept values from the user
            for (iCount= 0; iCount < 5; iCount++)
            {
                // \n -- newline char
                // \t -- tab key (spaces)

                Console.Write("\nEnter the number to store inside array: \t");
                //storing the values inside the array
                arr[iCount] = Convert.ToInt32(Console.ReadLine());
            }
        }

        /// <summary>
        /// Store data in two arrays and using the data in first array identify the data in second array
        /// </summary>
        public void AccessingValuesFromArray()
        {
            /*  1st array as integer    --> age
             *  2nd array as string     --> name
             *  
             *  accpet name from the user and find the corresponding age from the second array
             *  
             *  for no entry about the user --> user not found
             */

            int[] age = new int[6];
            string[] name = new string[6];
            int i, j = 0;
            string find = string.Empty;

            //gather the input from user: name and age in two arrays
            for (i = 0; i < 6; i++)
            {
                Console.Write("\n\nEnter your name:\t");
                name[i] = Console.ReadLine();
                Console.Write("Enter your age:\t\t");
                age[i] = Convert.ToInt32(Console.ReadLine());
            }

            //accept name from the user and then try to find their corresponding age in the 'age' array

            //receive the student name from user 
            Console.Write("\n\nEnter the name of the student to find its age:\t");
            find = Console.ReadLine();

            for (i = 0; i < 6; i++)
            {
                if (name[i] == find)
                {
                    Console.WriteLine("\n\nStudent Name\t: {0}", name[i]);
                    Console.WriteLine("Student Age\t: {0}", age[i]);
                    j++;
                }
            }

            if (j == 0)
            {
                Console.WriteLine("Student not found in the class !!!");
            }

            Console.ReadLine();
        }
        
        /// <summary>
        /// Creating and Understanding multidiamentional array
        /// use variables a and b instead of i and j
        /// name the array as school (used as Books)
        /// example is [3,3] array [4,4]
        /// </summary>
        public void MultiDiamentionalArray()
        {
            //declare two integer variables i, j
            int i, j;
            //lets declare a multi diamentional array
            //[] -- single diamention
            //[,] -- 2d array
            //[,,] -- 3d array
            //[,,,] -- 4d array
            //[,....] --nd array
            string[,] Books = new string[3, 3];

            //string[,] -- the data type of array is string
            //[,] -- 2d array
            //Books -- name of the array
            //string[3, 3] -- this array will have 3 rows and 3 columns

            //store values to the 2D Books array
            for (i = 0; i < 3; i++) //--> for rows
            {
                for (j = 0; j < 3; j++)  //--> for column
                {
                    //cw tab tab                    
                    Console.Write("\nEnter Book name for {0}. Row and {1}. column:\t", i, j);
                    //cr tab tab
                    Books[i, j] = Console.ReadLine();
                }
            }

            //\n --> adds a new line to the output/console 
            /*
             * 
             * ===================================
             * All the elements of Books array is:
             * 
             * 
             */

            Console.WriteLine("\n\n==============================");
            Console.WriteLine("All the elements of Books array is:\n\n");

            //Formatting output
            //\t --> adds a tab to the output/console (4 or 8 spaces)
            //\t1\t2\t3\n\n  -->    0   1   2
            //
            //
            //_
            Console.Write("\t0\t1\t2\n\n");
            //Outer loop for accessing rows
            for (i = 0; i < 3; i++)
            {
                Console.Write("{0}.\t", i);
                //inner or nested loop for accesing column of each row
                for (j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", Books[i, j]);    //C#   Java     C++         i(0)
                                                            //C    VB.Net   C#.Net      i(1)
                                                            //XML  HTML     SQL         i(2)
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n\n==============================");
            Console.ReadLine();
        }
    }
}
