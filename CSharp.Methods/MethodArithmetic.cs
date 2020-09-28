﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Methods
{
    public class MethodArithmetic
    {
        /// <summary>
        /// Write the expression-bodied method named "Hypotenuse" that calculates the length of the hypotenuse (double) of a right triangle when the length of the other two sides are given. The method should take two double argumetns and return the hypotenuse as a double. The hypotenuse can be calculates by Sqrt(a^2 + b^2) where Sqrt is the square root function and a^2 means a squared.
        /// The method should have a name Hypotenuse that accepts two double arguments, returning a double.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>




        /// <summary>
        /// Write expression-bodied method named "Multiple" that determines, for a pair of integers, whether the second integer is a multiple of the first.
        /// The method is named Multiple with two integer arguments, returning an integer.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>



        /// <summary>
        /// Write expression-bodied method named "IsEven" that uses the remainder operation (%) to determine whether an intreger is even.
        /// The method IsEven should accept an integer n argument, returning a boolean.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>




        /// <summary>
        /// Create a function named "RoundThreeAverages" that takes three integers from the input. The app will return the rounded average of these integers using only integer operations (e.g. integer division with / and modulus (the remainder operator) with %) to accomplish this, so do not use float, double, or decimal data types, functions, and operations.
        /// The method is named RoundThreeAverages that takes three integer arguments, returnning an integer.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <example>
        /// If your numbers are 1, 2, 4, the rounded average is 7/3 or 2. However, if your numbers are 1, 2, 5, the rounded average is 8/3 or 3. Likewise, if your numbers are -1, -2, -4, the rounded average is -7/3 or -2; and if your numbers are -1, -2, -5, the rounded average is -8/3 or -3.
        /// </example>



        /// <summary>
        /// This method named "DisplayBox" will display (with Console.Write*) a solid rectangle of fillCharacter whose number of rows and number of columns are specified in the arguments as row and column, respectively.
        /// The method with no return is named DisplayBox that accepts a row and column that are both integers and a fill character that's a char data type.
        /// </summary>
        /// <param name="row">number of rows</param>
        /// <param name="column">number of columns</param>
        /// <param name="fillCharacter">The character to be filled</param>



        /// <summary>
        /// Write an expression-bodied method named "DisplayDigits" that takes an integer n, accomplishing each of the following tasks. Do not use string operations.
        /// (a) Calcualte the integer part of the quotient when integer a is divided by integer b.
        /// (b) Calculate the integer remainder when integer a is divided by integer b.
        /// (c) Use the app pieces developed in parts (a) and (b) to add a body into this method that receives an integer and displays it as a sequence of digits, separating each pair of digits by two spaces.
        /// The method is named DisplayDigits that takes an integer n and doesn't return anything.
        /// </summary>
        /// <example>SeparateDigit(4562) should display 4  5  6  2.</example>
        /// <param name="n"></param>



        /// <summary>
        /// Create an expression-bodied method named "Power" that takes a decimal number and an integer. It then computes a to the n power. Note that if n is 0, their power is 1. If n is a negative number, the result is 1 over the power with a positive value of n. Assume that a cannot be 0.
        /// The method is named Power that takes a decimal and a integer argument. It returns a decimal.
        /// </summary>
        /// <param name="a">decimal value</param>
        /// <param name="n">to the power of n</param>
        /// <remarks>There are a few ways to write this method. The simplest way is to use a loop. The other way is to write in recursion. The third way is to use a smarter loop with bitwise operations. Do not use built-in functions such as Math.Pow().</remarks>
        /// <example>Power(3, 4) calculates 3*3*3*3</example>
        /// <remarks>The last assertion will require you to do a quicker way either with bit shifting or recursion because you will need to multiply to one billion times to approximate an e.</remarks>
        /// <returns></returns>



        /// <summary>
        /// Create a method named "Minimum3" that takes three integers and returns the smallest of the three integers. Do not use built-in functions.
        /// The method is named Minimum3 that takes three integer values and returns an integer value.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>



        /// <summary>
        ///  The method is named "IsPrime," accepting an integer value, returning a boolean value.
        ///  An integer number is said to be prime if it's greater than 1 and divisible by only 1 and itself. Write a method named IsPrime that determines whether a number is prime or not.
        /// </summary>
        /// <param name="number"></param>
        /// <example>For example, 2, 3, 5, 7 are prime but 4, 6, 8, 9 are not.</example>
        /// <remarks>
        ///  (b) Initially, you might think that n/2 is the upper limit for which you must test to see whether a number is prime, but you need to go only as high as the square root of n.
        /// </remarks>
        /// <returns></returns>




        /// <summary>
        /// The method is named "PerfectNumber," accepting an integer, returning a boolean value.
        /// An integer number is said to be a perfect number if its factors, including 1 (but not the number itself), sum up to the number. For example, 6 is a perfect number, because 6 = 1+ 2 + 3. Write a method named PerfectNumber that determines whether parameter value is a perfect number.
        /// </summary>
        /// <param name="number"></param>
        /// <seealso cref="IsPrime(int)"/>
        /// <returns></returns>




        /// <summary>
        /// The method is named "Gcd" that accepts two integer values, returning an integer.
        /// The greatest common divisor (GCD) of two integers is the largest integer that evenly divides each of the two numbers.
        /// Create an expression-bodied method named Gcd that calculates and returns the GCD of the two given integeres.
        /// </summary>
        /// <returns></returns>




        /// <summary>
        /// The method is named "Lcm" that takes two integer values and returns a long.
        /// The least common multiple is the smallest integer that is divisible by both a and b.
        /// Create an expression-bodied method named Lcm that calculates and returns the LCM of the two given integers.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>



        /// <summary>
        /// The method is named "ReverseBits" that takes an integer value, returning a string.
        /// Write a method named "ReverseBits" that takes an non-negative integer value and returns the string in ones and zeros with its bits reversed. Do not use any built-in function but bitwise shift. Also, do not prepend the zeros to your bits. For example, a reverse bit for 8 is "1" because 8 representing 1000 in binary reverses to "0001", which is essentially "1".
        /// </summary>
        /// <param name="n">non-negative</param>
        /// <returns>A string representation that contains 0's and 1's.</returns>
        /// <example>123 is written in 1111011 in binary, so its reversed bits is 1101111</example>




        /// <summary>
        /// Create a method named "Gpa" that accepts an integer points and an output parameter letterGrade. This function returns the GPA on a scale of 4 for the points, which is between 0% and 100%. In addition, this method also outputs the letter grade as the out letterGrade. 0-59: F (GPA=0), 60-63: D- (GPA=2/3), 64-66: D (GPA=1), 67-69: D+ (GPA=4/3), 70-73: C- (GPA=5/3), 74-76: C (GPA=2), 77-79 C+ (GPA=7/3),  80-83: B- (GPA=8/3), 84-86: B (GPA=3), 87-89 B+ (GPA=10/3), 90-93: A- (GPA=11/3), 94-96: A (GPA=4).
        /// The method is named Gpa that takes integer points and 'out's a letter Grade as a string. It returns a decimal value.
        /// </summary>
        /// <param name="points">a scale between 0 and 100</param>
        /// <param name="letterGrade">This is the second output that outputs the letter grade</param>
        /// <remarks>Try to see any pattern here to avoid a bunch of if-statements</remarks>
        /// <returns></returns>
    }
}