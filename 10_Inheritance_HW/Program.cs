using _10_Inheritance_HW;

namespace _11_Inheritance_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("\t\tN1");
            _1_Money money = new _1_Money();
            Console.WriteLine(money);
            _1_Product product = new _1_Product("bread", 1, 103);
            Console.WriteLine(product);
            product.ChangePrice(1.05);
            Console.WriteLine(product);
            product.ChangePrice(-5.05);
            Console.WriteLine(product);
            Console.WriteLine();
            
            Console.WriteLine("\t\tN2");
            //_2_Device device = new _2_Device();
            //device.Print();'
            _2_Kettle kettle = new _2_Kettle("electric kettle", "Bosch", "Black", 1.8, 2);
            _2_Microwave microwave = new _2_Microwave("smart microwave", "Sumsung", "Silver", 34, "ceramic");
            _2_Car car = new _2_Car("car", "Audi", "Black", "disel");
            _2_Steamboat steamboat = new _2_Steamboat("steamboat \"Titanic\"", "John Brown & Company", "White", 30);
            Console.WriteLine($"{new string('*',100)}");
            kettle.Show();
            kettle.Sound();
            kettle.Desc();
            Console.WriteLine($"{new string('*',100)}");
            microwave.Show();
            microwave.Sound();
            microwave.Desc();
            Console.WriteLine($"{new string('*',100)}");
            car.Show();
            car.Sound();
            car.Desc();
            Console.WriteLine($"{new string('*',100)}");
            steamboat.Show();
            steamboat.Sound();
            steamboat.Desc();
            Console.WriteLine($"{new string('*',100)}");
            
            Console.WriteLine();

            Console.WriteLine("\t\tN3");

            Console.WriteLine($"{new string('*', 100)}");
            _3_Violin violin = new _3_Violin("violin");
            violin.Show();
            violin.Sound();
            violin.Desc();
            violin.History();

            Console.WriteLine($"{new string('*', 100)}");
            _3_Trombone trombone = new _3_Trombone("trombone");
            trombone.Show();
            trombone.Sound();
            trombone.Desc();
            trombone.History();

            Console.WriteLine($"{new string('*', 100)}");
            _3_Ukulele ukulele = new _3_Ukulele("ukulele");
            ukulele.Show();
            ukulele.Sound();
            ukulele.Desc();
            ukulele.History();
            Console.WriteLine($"{new string('*', 100)}");
            _3_Cello cello = new _3_Cello("cello");
            cello.Show();
            cello.Sound();
            cello.Desc();
            cello.History();
            Console.WriteLine($"{new string('*', 100)}");
            */
            Console.WriteLine();

            Console.WriteLine("\t\tN4");
            //_4_Worker worker = new _4_Worker();
            //worker.Print();
            Console.WriteLine($"{new string('*', 100)}");

            _4_President president = new _4_President();
            president.Print();
            Console.WriteLine($"{new string('*', 100)}");

            _4_Security security = new _4_Security();
            security.Print();
            Console.WriteLine($"{new string('*', 100)}");

            _4_Manager manager = new _4_Manager();
            manager.Print();
            Console.WriteLine($"{new string('*', 100)}");

            _4_Engineer engineer = new _4_Engineer();
            engineer.Print();
            Console.WriteLine($"{new string('*', 100)}");

        }
    }
}
