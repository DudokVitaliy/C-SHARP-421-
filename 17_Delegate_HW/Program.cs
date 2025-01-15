using System;

namespace _17_Delegate_HW
{
    delegate bool Condition(int numb);
    internal class Program
    {
        static int[] ArrayCheak(int[] arr, Condition myfunc)
        {
            int [] array = new int[0];
            foreach (int item in arr)
            {
                if (myfunc(item))
                {
                    Array.Resize(ref array, array.Length + 1);
                    array[array.Length - 1] = item;
                }
            }
            return array;
        }
        static bool IsSimple(int x)
        {
            if (x <= 1) return false;
            if (x <= 3) return true;
            if (x % 2 == 0 || x % 3 == 0) return false;
            for (int i = 5; i <= x/2; i += 1)
            {
                if (x % i == 0 || x % (i + 2) == 0)
                    return false;
            }
            return true;
        }
        public static bool IsFibonacciNumber(int x)
        {
            if (x < 0) return false;
            bool IsPerfectSquare(int y)
            {
                int z = (int)Math.Sqrt(y);
                return z * z == y;
            }
            return IsPerfectSquare(5 * x * x + 4) || IsPerfectSquare(5 * x * x - 4);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tN1");
            Console.WriteLine("\tRandom array:");
            int [] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = new Random().Next(-10,10);
            foreach (int item in arr)
                Console.Write($"{item, 5};");

            Console.WriteLine($"All even elements      :: {String.Join(", ",ArrayCheak(arr, x => x % 2 == 0))}");
            Console.WriteLine($"All odd elements       :: {String.Join(", ", ArrayCheak(arr, x => x % 2 != 0))}");
            // спробував використати і мультикаст-делегат:
            Condition other_condition = IsSimple;
            other_condition += IsFibonacciNumber;
            Console.WriteLine($"All simple elements    :: {String.Join(", ", ArrayCheak(arr, x => (other_condition.GetInvocationList()[0] as Condition)!.Invoke(x)))}"); 
            Console.WriteLine($"All fibonacci elements :: {String.Join(", ", ArrayCheak(arr, x => (other_condition.GetInvocationList()[1] as Condition)!.Invoke(x)))}");
            
            Console.WriteLine();
            Console.WriteLine("\t\tN2");
            Action current_time = () => Console.WriteLine($"current time :: {DateTime.Now.ToShortTimeString()}");
            Action current_date = () => Console.WriteLine($"current date :: {DateTime.Now.ToShortDateString()}");
            Action current_day = () => Console.WriteLine($"current day  :: {DateTime.Now.DayOfWeek}");
            current_time();
            current_date();
            current_day();

            Func <double, double, double> area_triangle = (double a, double h) => (a * h)/2.0;
            Func <double, double, double> area_rectangle = (double a, double b) => a * b;
            double a = 5;
            double b = 10;
            double h = 7;
            Console.WriteLine($"area of triangle with side 'a' and height 'h' drawn to it :: {area_triangle(a,h)}");
            Console.WriteLine($"area of rectangle with side 'a' and side 'b' :: {area_rectangle(a,b)}");
        }
    }
}
