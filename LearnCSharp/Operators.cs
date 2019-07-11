using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    public class Operators
    {
        /// <summary>
        /// Method to understand Arithmetic Operators in CSharp
        /// </summary>
        public void ArithmeticOperator()
        {
            /*  + 
             *  - 
             *  * 
             *  / 
             *  %
             *  ++
             *  --
             */

            //let consider two varible to use with operator
            int iDataA = 4;
            int iDataB = 2;
            int result = 0;

            //Add Operator (4 + 2) --> 6
            result = iDataA + iDataB;

            //Substract Operator (4 - 2) --> 2
            result = iDataA - iDataB;

            //Multiply Operator (4 * 2) --> 8
            result = iDataA * iDataB;

            //Divide Operator (B / A) --> 2 / 4 --> Dividing numerator with denominator --> 2
            result = iDataB / iDataA;

            //Modulus Operator (B % A) --> 2 / 4 --> remainder of the integer division --> 0
            result = iDataB % iDataA;

            //Increment Operator 
            result = iDataA++;
            //result = iDataA + 1; --> 5

            //Decrement Operator
            result = iDataA--;
            //result = iDataA - 1; --> 3


        }

        /// <summary>
        /// Method to understand Relational Operators in CSharp
        /// </summary>
        public void RelationalOperator()
        {
            /*
             *  ==
             *  !=
             *  >
             *  <
             *  >=
             *  <=
             *  
             */

            int iDataA = 10;
            int iDataB = 20;
            string result = string.Empty;

            //Equal To (Operator) --> Output Boolean type (true/false) --> (10 == 20) --> false
            if (iDataA == iDataB)
                result = "Value of iDataA and iDataB are equal - Check using equal to operator";
            else
                result = "Value of iDataA and iDataB are NOT equal - Check using equal to operator";

            //!= Checks if the operands are equal or not --> (10 != 20) --> true
            if (iDataA != iDataB)
                result = "Value of iDataA and iDataB are equal - Check using equal to operator";
            else
                result = "Value of iDataA and iDataB are NOT equal - Check using equal to operator";

            //> (greater than opertor) check if the value of the left side operand is greater than the value of right operand
            // (10 > 20) --> is not true --> else part of the stmt will be executed
            if (iDataA > iDataB)
                result = "Value of iDataA is greater than iDataB";
            else
                result = "Value of iDataA is NOT greater than iDataB";

            //< (less than opertor) check if the value of the left side operand is less than the value of right operand
            // (10 < 20) --> is true --> if part of the stmt will be executed
            if (iDataA < iDataB)
                result = "Value of iDataA is less than iDataB";
            else
                result = "Value of iDataA is NOT less than iDataB";

            //>= (greater than or equal to operator)
            //checks to see if the value of left operand is greater than or equal to the value of right side operand
            // (10 >= 20) --> is not true --> else part of the stmt will be executed

            // a = 10 and b = 10
            // (a > b) --> false (because a is equal to b)
            // (a >= b) --> true 
            // (10 >= 10) --> true

            // (10 >= 20) --> false 
            if (iDataA >= iDataB)
                result = "Value of iDataA is greater than or equal to the value of iDataB";
            else
                result = "Value of iDataA is NOT greater than or equal to the value of iDataB";

            //<= (less than or equal to operator)
            //checks to see if the value of left operand is less than or equal to the value of right side operand
            // (10 <= 20) --> is true --> if part of the stmt will be executed

            // a = 10 and b = 10
            // (a < b) --> false (because a is equal to b)
            // (a <= b) --> true 
            // (10 <= 10) --> true

            // (10 <= 20) --> true
            if (iDataA >= iDataB)
                result = "Value of iDataA is less than or equal to the value of iDataB";
            else
                result = "Value of iDataA is NOT less than or equal to the value of iDataB";

        }

        /// <summary>
        /// Method to understand Logical Operators in CSharp
        /// </summary>
        public void LogicalOperator()
        {
            /*  && --> Logical AND operator --> If both the operands are non zero then the condition becomes true
             *  || --> Logical OR operator
             *  !  --> Logical NOT operator
             */

            bool A = true;
            bool B = false;
            string result = string.Empty;

            if (A && B) //--> true and false --> false
                result = "Condition is true";
            else
                result = "Condition is NOT true (false)";

            A = true;
            B = true;
            if (A && B) //--> true and true --> true
                result = "Condition is true";
            else
                result = "Condition is NOT true (false)";

            //--> true and true --> true
            if ((4 > 2) && (2 < 4))
                Console.Write("Condition is true --> first and second condition are evaluated to true the entire output is true");
            else
                Console.Write("Condition is false --> first or second condition are not true the entire output is true");


            // || --> Logical OR operator

            A = true;
            B = false;
            result = string.Empty;

            if (A || B) //--> true or false --> true
                result = "Condition is true";
            else
                result = "Condition is NOT true (false)";

            // ! --> Logical NOT 
            // Used to reverse the logical state of its operator
            // if a condition is true then Logical NOT operator makes it as false

            A = true;
            B = true;
            result = string.Empty;

            if (!(A && B)) // true && true --> !true --> false
                result = "Condition is true";
            else
                result = "Condition is NOT true (false)";

            A = true;
            B = false;
            result = string.Empty;

            if (!(A && B)) // true && false --> !false --> true
                result = "Condition is true";
            else
                result = "Condition is NOT true (false)";
        }

        /// <summary>
        /// Method to understand Assignment Operators in CSharp
        /// </summary>
        public void AssignmentOperator()
        {
            /*  =   (Simple Assignment Opertor)
             *  
             *  +=  (Add AND Assignment operator)
             *  -=  (Sub AND Assignment operator)
             *  
             *  *=  (Mul AND Assignment operator)
             *  /=  (Div AND Assignment operator)
             *  %=  (Mod AND Assignment operator)
             *  <<= (Left Shift AND Assignment operator)
             *  >>= (Right Shift AND Assignment operator) 
             *  &=  (Bitwise AND Assignment operator)
             *  ^=  (Bitwise exclusive OR AND Assignment operator)
             *  |=  (Bitwise inclusive OR AND Assignment operator)
             */

            int a = 21; // --> 21
            int c;      // --> 0
            c = a; //we are assigning the value of a to c, now c and a will contain the same values

            Console.WriteLine("The value of c = {0}", c);
        }

        /// <summary>
        /// Understanding Assignment operators other than =
        /// </summary>
        public void OtherAssignmentOperator()
        {
            int a = 21;
            int c;
            c = a;

            //+= (Operator)
            c += a;     //c = c + a;    //c = 21 + 21   // c = 42
            Console.WriteLine("The value of c using (+=) Opertor = {0}", c);    //42

            //-= (Operator)
            c -= a;     //c = c - a;    //c = 42 - 21   // c = 21
            Console.WriteLine("The value of c using (-=) Opertor = {0}", c);    //21

            //*= (Operator)
            c *= a;     //c = c * a;    //c = 21 * 21   //c = 441
            Console.WriteLine("The value of c using (*=) Opertor = {0}", c);    //441

            //= (Operator)
            c /= a;     //c = c / a;    //c = 441 / 21  //c = 21
            Console.WriteLine("The value of c using (/=) Opertor = {0}", c);    //21

            //todo: <<to look back>>

            //%= (Operator) gets the remainder of a division
            c = 200;
            c %= a;     //c = c % a;    //c = 200 % 21  //c = 11 
            Console.WriteLine("The value of c using (%=) Opertor = {0}", c);    //11

            //Left shift AND assignment operator
            //<<= (Operator)
            //c <<= 2;    //c = c << 2;   //c = 11 << 2   //c = 44
            c = 5;        //5 = 00000101
            c = c << 1;   //c = 00001010
            c = 10;       //c = 10
            Console.WriteLine("The value of c using (<<=) Opertor = {0}", c);   //44

            //Right shift AND assignment operator
            //>>= (Operator)
            //c >>= 2;
            c = 5;        //5 = 00000101
            c = c >> 1;   //c = 00000010
            c = 2;        //c = 2  
            Console.WriteLine("The value of c using (>>=) Opertor = {0}", c);   //11

            //AND asignment operator
            //&= (Operator)
            //c &= 2;
            a = 12;     //12 = 00001100
            int b = 25; //25 = 00011001
            a = a & b;

            a &= 2;
            a = a & 2;    //8 = 00001000
                          //2 = 00000010

            //00001100
            //00011001  +
            //--------
            //0000 1000  8
            Console.WriteLine("The value of c using (&=) Opertor = {0}", c);    //2

            //^= (Operator)
            c ^= 2;
            Console.WriteLine("The value of c using (^=) Opertor = {0}", c);    //0

            //|= (Operator)
            c |= 2;
            Console.WriteLine("The value of c using (|=) Opertor = {0}", c);    //2
        }

        /// <summary>
        /// Understanding Bitwise operators 
        /// </summary>
        public void BitwiseOperator()
        {
            //It works on bit and performs operations bit by bit

            int a = 60;
            int b = 13;

            //Bitwise & operation
            Console.WriteLine("a & b: {0}", a&b);

            //Bitwise | operation
            Console.WriteLine("a | b: {0}", a|b);

            //Bitwise ^ (^ exclusive OR Operator)
            Console.WriteLine("a ^ b: {0}", a^b);

            //Bitwise ~ (~ negation Operator)
            Console.WriteLine("~ a: {0}", ~a);

            //Bitwise << (<< Binary left shift Operation)
            Console.WriteLine("a << 2: {0}", a<<2);

            //Bitwise >> (>> Binary right shift Operation)
            Console.WriteLine("a >> 2: {0}", a>>2);
        }
    }
}
