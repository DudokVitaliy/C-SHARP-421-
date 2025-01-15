using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Intarface_HW
{
    internal class MyArray : ICalc, IOutput2, ICalc2
    {
        private int [] array;
        public MyArray(int x)
        {
            array = new int[x];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(-10,10);
            }
        }

        public int CountDistinct()
        {
            int distinct = 0;
            bool is_distinct = true;
            for (int i = 0;i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i == j)
                        continue;
                    if(array[i] == array[j])
                        is_distinct = false;
                }
                if (is_distinct)
                    distinct++;
                is_distinct = true;
            }
            return distinct;
        }

        public int EqualToValue(int valueToCompare)
        {
            return Array.FindAll(array, x => x == valueToCompare).Length;
        }

        public int Greater(int valueToCompare)
        {
            return Array.FindAll(array, x => x > valueToCompare).Length;
        }

        public int Less(int valueToCompare)
        {
            return Array.FindAll(array, x => x < valueToCompare).Length;
        }

        public void Show() 
        {
            foreach (int i in array)
            {
                Console.Write($"{i,5};");
            }
            Console.WriteLine();
        }

        public void ShowEven()
        {
            foreach (int item in (Array.FindAll(array, x => x % 2 == 0)))
            {
                Console.Write($"{item,5};");
            }
            Console.WriteLine();
        }

        public void ShowOdd()
        {
            foreach (int item in (Array.FindAll(array, x => x % 2 != 0)))
            {
                Console.Write($"{item,5};");
            }
            Console.WriteLine();
        }
    }
}
