using System.Globalization;
using System.Xml.Serialization;

namespace _30_XML_Serializers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(111, "Toyota", 2.3);
            Car car1 = new Car(112, "Ford", 1.8);
            Car car2 = new Car(112, "Audi", 2.8);
            Car car3 = new Car(112, "BMW", 3.0);
            //Console.WriteLine($"Origin :: {car}");
            //XmlSerializer xs = new XmlSerializer(typeof(Car));

            //string fname = "car.xml";
            //using (FileStream fs = new FileStream(fname, FileMode.Create))
            //{
            //    xs.Serialize(fs, car);
            //    fs.Position = 0;
            //    Car res = (xs.Deserialize(fs) as Car)!;
            //    Console.WriteLine(res);

            //}
            string fname = "salon.xml";
            List<Car> salonList = new List<Car>()
            { car, car1,car2, car3 };
            XmlSerializer xs = new XmlSerializer(typeof(List<Car>));
            using (TextWriter tw = new StreamWriter(fname))
            {
                xs.Serialize(tw, salonList);
            }
            using(TextReader tr = new StreamReader(fname))
            {
                var ListCar = xs.Deserialize(tr) as List<Car>;
                Console.WriteLine($"Recover cars :: \n{String.Join<Car>("\n", ListCar)}");
            }
        }
    }
}
