using Newtonsoft.Json;
using System.Text.Json;
using System.Xml.Linq;

namespace _31_JSON_Serializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(111, "Toyota", 2.3);
            Car car1 = new Car(112, "Ford", 1.8);
            Car car2 = new Car(113, "Audi", 2.8);
            Car car3 = new Car(114, "BMW", 3.0);

            string fname = "car_json.json";
            //string json = JsonSerializer.Serialize<Car>(car);
            //Console.WriteLine(json);
            //File.WriteAllText(fname, json);
            //Car res = JsonSerializer.Deserialize<Car>(File.ReadAllText(fname));
            //Console.WriteLine(res);
            string json = JsonConvert.SerializeObject(car);
            File.WriteAllText(fname, json);
            Console.WriteLine(JsonConvert.DeserializeObject<Car>(File.ReadAllText(fname))); // і поля і проперті 



            Dictionary <int, Car> salon_list = new Dictionary<int, Car>();
            salon_list.Add(car.id, car);
            salon_list.Add(car1.id, car1);
            salon_list.Add(car2.id, car2);
            salon_list.Add(car3.id, car3);

            string fname2 = "salon.json";
            File.WriteAllText(fname2, JsonConvert.SerializeObject(salon_list));
            foreach (var item in JsonConvert.DeserializeObject<Dictionary<int, Car>>(File.ReadAllText(fname2)))
            {
                Console.WriteLine(item.Value);
            }

            //List<Car> salon_List = new List<Car>()
            //{ car, car1,car2, car3 };
            //File.WriteAllText(fname2, JsonConvert.SerializeObject(salon_List));
            //Console.WriteLine(String.Join<Car>("\n", JsonConvert.DeserializeObject<List<Car>>(File.ReadAllText(fname2))!));

            //string salon = JsonSerializer.Serialize<Dictionary<int, Car>>(SalonList);
            //Console.WriteLine(salon);
            //File.WriteAllText(fname, salon);
            //Dictionary<int, Car> res = JsonSerializer.Deserialize<Dictionary<int, Car>>(File.ReadAllText(fname));
            ////Console.WriteLine(String.Join<Car>("\n", res));
            //foreach (var item in res)
            //{
            //    item.Value.id = item.Key;
            //    Console.WriteLine($"{item.Value}");
            //}


        }
    }
}
