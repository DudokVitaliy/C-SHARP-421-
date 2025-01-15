using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Structure_Demo
{
    struct City : IComparable, IComparable<City> // для порівняння та сортування
    {
        const int DefaultPopulation = 10_000; // неявно static - один екземпляр для всіх, займає менше пам`яті
        const int MaxPopulation = 100_000_000;
        private int population;
        public int Population { get => population ; set => population = value <= MaxPopulation ? value : MaxPopulation; }
        public string Name { get; set; } // = "Noname" - error
        public City(string name, int population = DefaultPopulation)
        {
            Name = name;
            Population = population;
        }
        public override string ToString()
        {
            return $"Name:: {Name, -10} Population:: {Population, -15}";
        }

        public int CompareTo(object? obj) // краще для референс типів
        {
            if (!(obj is City))
                throw new ArgumentException("Object is not City!");
            City city = (City)obj;
            //return this.population - city.population ;
            return this.population.CompareTo(city.population) ;
        }

        public int CompareTo(City other)
        {
            return this.population.CompareTo(other.population);
        }
    }
}
