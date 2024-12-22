using static System.Console;
using System;
using System.Linq;
namespace _02_Array_HW
{
    internal class Program
    {
        static int [] CreateArray(int size)
        {
            return new int [size];
        }
        static void FillRand(int[] arr, int start = 0, int end = 100)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(start, end);
            }
        }
        static void Print(int[] arr)
        {
            WriteLine("\t\tYour Array: ");
            foreach (int i in arr) Write(i+ ";\t");
            WriteLine();
        }
        static void Swap(int[] arr)
        {
            int temp;
            for(int i = 0;i < arr.Length - 1; i += 2)
            {
                temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
            }
        }
        static bool IsPositive (int x)
        {
            return x > 0;
        }
        static int FirstPositive(int[] arr)
        {
            int index = Array.FindIndex(arr, IsPositive);
            if (index >= 0)
                return arr[index];
            else
            {
                return 0;
            }
        }
        static bool IsEven(int x)
        {
            return x % 2 == 0;
        }
        static int CountOfEven(int[] arr)
        {
            return arr.Count(IsEven);

        }
        static int IndexMultipleOfSeven(int[] arr)
        {
            return Array.FindIndex(arr, x => x % 7 == 0);
        }
        static void Main(string[] args)
        {

            int[] array = new int[0];
            int size = 0;

            while(true)
            {
                WriteLine("\t\tMenu");
                WriteLine("\t1 - Create new array");
                WriteLine("\t2 - Fill new array");
                WriteLine("\t3 - Print");
                WriteLine("\t4 - Swap elements");
                WriteLine("\t5 - First element > 0 ");
                WriteLine("\t6 - Count of even ");
                WriteLine("\t7 - Index number % 7");
                WriteLine("\t0 - Exit");
                Write("\t\tchoise -> ");
                int choise = int.Parse(ReadLine());
                switch (choise)
                {
                    case 1:
                        Clear();
                        Write("\tEnter size of yor array: ");
                        size = int.Parse(ReadLine());
                        array = CreateArray(size);
                        WriteLine("New array created");
                        WriteLine();
                        break;
                    case 2:
                        Clear();
                        if (size <= 0)
                            WriteLine("First you need to create a new array (1 point)");
                        else
                        {
                            FillRand(array);
                            WriteLine("New array filled");
                            WriteLine();
                        }

                        break;
                    case 3:
                        Clear();
                        Print(array);
                        WriteLine();
                        break;
                    case 4:
                        Clear();
                        Swap(array);
                        WriteLine("Elements swapped");
                        Print(array);
                        WriteLine();
                        break;
                    case 5:
                        Clear();
                        Print(array);
                        WriteLine($"First element > 0 :: {FirstPositive(array)}");
                        WriteLine();
                        break;
                    case 6:
                        Clear();
                        Print(array);
                        WriteLine($"Count of even :: {CountOfEven(array)}");
                        WriteLine();
                        break;
                    case 7:
                        Clear();
                        Print(array);
                        if (IndexMultipleOfSeven(array) >= 0)
                        {
                            WriteLine($"Number % 7 was found :: index = {IndexMultipleOfSeven(array)} :: number = {array[IndexMultipleOfSeven(array)]}");
                            WriteLine();
                        }
                        else
                        {
                            WriteLine("Number % 7 not found");
                            WriteLine();
                        }
                        break;
                    default:
                        break;
                }
                if (choise == 0) 
                {
                    Clear();
                    break;
                }

            }
            WriteLine("\t\tGoodBye!!!");
        }
    }
}
