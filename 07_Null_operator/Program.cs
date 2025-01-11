namespace _07_Null_operator
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string LastName { get; set; }
        }

        static void Main(string[] args)
        {
            //int value = null;
            //Console.WriteLine(str);
            //Console.WriteLine(value);
            //Console.WriteLine(default(string));
            //Console.WriteLine(default(int[]));
            //Console.WriteLine(default(int));
            //Console.WriteLine(default(bool));
            //str = "Lorem ipsum";

            //if (str == null)
            //{
            //    Console.WriteLine("default text");
            //}
            //else
            //{
            //    Console.WriteLine(str);
            //}
            // унарний : ++i !true
            // бінарний : x+y a==b
            // тернарний a?b:c
            //Console.WriteLine();
            //Console.WriteLine(str!=null ? str : "default text");
            //Console.WriteLine(str??"default text");

            Person person = new Person() { Name = "Kolya" };
            Console.WriteLine(person.Name?? "NoName");

            Person nullPerson = null;
            Console.WriteLine(nullPerson?.Name?? "NoName");

            string str = null;
            Console.WriteLine(str?.Length);
            Console.WriteLine(str?.Replace('m', '@'));
            Nullable<int> value = null;
            Console.WriteLine(value.GetValueOrDefault());
            int?number = null;
            int[]arr = null;
            Console.WriteLine(arr?[0]?? -1);
            arr ??= new int[6] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(arr?[0]?? -1);

        }
    }
}
