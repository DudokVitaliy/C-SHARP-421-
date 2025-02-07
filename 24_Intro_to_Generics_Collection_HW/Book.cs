using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Intro_to_Generics_Collection_HW
{
    internal class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public int id = 0;
        public Book(string name = "empty", string author = "empty", string genre = "empty", int year = 0)
        {
            Name = name;
            Author = author;
            Genre = genre;
            Year = year;
            id++;
        }
        public override string ToString()
        {
            return $"id:::::: {id}\nname  :: {Name}\nauthor:: {Author}\ngenre :: {Genre}\nyear of publication:: {Year}";
        }
    } 
} 