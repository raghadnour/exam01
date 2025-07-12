using System;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace exam01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //Write a program that asks the user to enter their age and nationality. If the age is 18 or above 
            //and nationality is "Egyptian", print "Eligible to vote", otherwise print "Not eligible".

            //Console.Write("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.Write("Enter your nationality: ");
            //string s= Console.ReadLine();
            //s=s.ToLower();
            //if (age >= 18 && s == "egyptian")
            //{
            //    Console.WriteLine("Eligible to vote");
            //}
            //else
            //{
            //    Console.WriteLine("Not eligible");
            //}

            #endregion
            #region q2
            //Create a calculator function that takes two numbers and an operator (+, -, *, /) as input. Use a 
            //switch statement to perform the operation and return the result.Handle division by zero.

            //int n1, n2;
            //Console.WriteLine("Enter the first number: ");
            //n1 =int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second number: ");
            //n2 =int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the operator (+, -, *, /): ");
            //char op = char.Parse(Console.ReadLine());
            //switch (op)
            //{
            //    case '+':
            //        Console.WriteLine($"Result: {n1 + n2}");
            //        break;
            //    case '-':
            //        Console.WriteLine($"Result: {n1 - n2}");
            //        break;
            //    case '*':
            //        Console.WriteLine($"Result: {n1 * n2}");
            //        break;
            //    case '/':
            //        if (n2 != 0)
            //        {
            //            Console.WriteLine($"Result: {n1 / n2}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Error: Division by zero is not allowed.");
            //        }
            //        break;
            //}
            #endregion
            #region q3
            //Write a method that takes an integer n and prints the multiplication table from 1 to n. Each row 
            //should show the result of multiplying the current number by 1 through 10.

            //Console.Write("Enter an num: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{

            //    for(int j = 1; j <= 10; j++)
            //    {
            //        Console.Write($"{{{i}*{j}={i * j}}},");
            //    }
            //    Console.WriteLine(); 

            //}
            #endregion
            #region q4
            //Write a program that accepts an array of integers and counts how many of them are prime 
            //numbers.

            //Console.Write("Enter the size of the array: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //Console.WriteLine("Enter array element:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int cnt = 0;
            //for(int i = 0; i < n; i++)
            //{
            //    cnt+= IsPrime(arr[i]) ? 1 : 0;
            //}
            //Console.WriteLine($"The number of prime numbers in the array is: {cnt}");
            #endregion
            #region q5
            //Ask the user to input 10 integers and store them in an array. Find and print the maximum value 
            //and its index.

            //int n = 10;
            //int[] arr = new int[n];
            //Console.WriteLine("Enter 10 values:");
            //int mx= int.MinValue;
            //int idx = -1;
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //    if (arr[i] > mx)
            //    {
            //        mx = arr[i];
            //        idx = i;
            //    }

            //}
            //Console.WriteLine($"Max value = {mx} , index = {idx}");

            #endregion
            #region q6
            //Create a function that checks whether a given word (as a string) is a palindrome (same forward 
            //and backward). Ignore casing.

            //Console.WriteLine("enter string: ");
            //string s=Console.ReadLine();
            //int n = s.Length;
            //bool b = false;
            //for(int i = 0; i < n / 2; i++)
            //{
            //    if(char.ToLower(s[i]) != char.ToLower(s[n - 1 - i]))
            //    {
            //        b = true;
            //        Console.WriteLine("Not Palindrome");
            //        break;
            //    }
            //}
            //if (!b)
            //{
            //    Console.WriteLine("Palindrome");
            //}

            #endregion
            #region q7
            //Write a function that takes two int? values (nullable integers). If both are not null, return their 
            //division result. If either is null, return null.Also, avoid division by zero.

            //string? n1, n2;
            //Console.WriteLine("Enter the first number: ");
            //n1 = Console.ReadLine();
            //Console.WriteLine("Enter the second number: ");
            //n2 =Console.ReadLine();
            //Console.WriteLine(!(div(n1, n2).HasValue) ?"null":div(n1,n2));

            #endregion
            #region q8
            //Create a function that accepts an array of integers and returns the sum of all even numbers

            //Console.WriteLine("Enter the size of the array: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //Console.WriteLine("Enter array element:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int res = sum(arr);
            //Console.WriteLine($"The sum of even numbers in the array is: {res}");
            #endregion
            #region q9
            //Write a program that reads student scores (as integers from 0–100) for 5 students. For each 
            //student, use a switch with ranges(use when) to assign grades:

            //int[] arr= new int[5];
            //Console.WriteLine("Enter the scores of 5 students (0-100):");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"Student {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    char c = arr[i] switch
            //    {
            //         >= 90 and <= 100 => 'A',
            //         >= 80 and < 90 => 'B',
            //         >= 70 and < 80 => 'C',
            //         >= 60 and < 70 => 'D',
            //         >= 0 and < 60 => 'F',
            //         _=>'X'
            //    };
            //    Console.WriteLine($"Student {i + 1} score: {arr[i]}, Grade: {c}");
            //}
            #endregion
            #region q10
            //Create a function that accepts an array of int? (nullable scores). Return the average of all non
            //null scores.If all scores are null, return null.

            Console.WriteLine("Enter the size of the array: ");
            int n = int.Parse(Console.ReadLine());
            int?[] arr = new int?[n];
            Console.WriteLine("Enter array element:");
            for (int i = 0; i < n; i++)
            {
                string ?r= Console.ReadLine();
                if(string.IsNullOrEmpty(r))
                {
                    arr[i] = null;
                }
                else
                {
                    arr[i] = int.Parse(r);
                }
            }
            double? res = average(arr);
            if (res.HasValue)
            {
                Console.WriteLine(res.Value);
            }
            else
            {
                Console.WriteLine("null");
            }
            #endregion

        }
        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
        static int? div(string? n1, string? n2)
        {
            int? num1 = null;
            int? num2 = null;
            if (!(string.IsNullOrEmpty(n1)))
            {
                num1 = int.Parse(n1);
            }
            if (!string.IsNullOrEmpty(n2))
            {
                num2 = int.Parse(n2);
            }
            if (num1.HasValue && num2.HasValue)
            {
                if (num2.Value == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return null;
                }
                return num1.Value / num2.Value;
            }

            return null;

        }
        static int sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        static double? average(int?[] arr)
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].HasValue)
                {
                    sum += arr[i].Value;
                    count++;
                }
            }
            if (count == 0)
            {
                return null;
            }
            return (double)sum / count;
        }
    }
}
