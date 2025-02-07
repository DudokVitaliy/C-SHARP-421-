using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Intro_to_Generics_Collection_HW
{
    internal class Librery
    {
        List<Book> librery;
        static int last_id;
        public Librery()
        {
            librery = new List<Book>();
        }
        public void AddBook(Book book)
        {
            //book.id = librery.Count + 1;
            // якщо видалити а потім додати нову не працює коректно

            if (librery.Count == 0)
            {
                book.id = 1;
                last_id = 1;
            }
            else
            {
                book.id = librery[librery.Count - 1].id + 1;
                last_id = book.id;
            }
            librery.Add(book);
        }
        public void RemoveBookID(int id)
        {
            int x = librery.FindIndex(x => x.id == id);
            if (x != -1)
            {
                librery.RemoveAt(x);
                Console.WriteLine("Removed!");
            }
            else
            {
                Console.WriteLine("Error! Book is not found!");
            }
        }
        public void ChangeInfo(int id, Book change)
        {
            int x = librery.FindIndex(x => x.id == id);
            if (x != -1)
            {
                librery[x].Name = change.Name;
                librery[x].Author = change.Author;
                librery[x].Genre = change.Genre;
                librery[x].Year = change.Year;
                Console.WriteLine("Changed Successfully!");
            }
            else
            {
                Console.WriteLine("Error! Book is not found!");
            }
        }
        public void SearchName(string param)
        {
            List<Book> search = librery.FindAll(x => x.Name == param);
            if (search == null)
            {
                Console.WriteLine("Error! Not Found!");
            }
            else
            {

                foreach (Book book in search)
                {
                    Console.WriteLine(book);
                    Console.WriteLine($"{new string('*', 50)}");
                }
            }
        }
        public void SearchAuthor(string param)
        {
            List<Book> search = librery.FindAll(x => x.Author == param);
            if (search == null)
            {
                Console.WriteLine("Error! Not Found!");
            }
            else
            {

                foreach (Book book in search)
                {
                    Console.WriteLine(book);
                    Console.WriteLine($"{new string('*', 50)}");
                }
            }
        }
        public void SearchGenre(string param)
        {
            List<Book> search = librery.FindAll(x => x.Genre == param);
            if (search == null)
            {
                Console.WriteLine("Error! Not Found!");
            }
            else
            {

                foreach (Book book in search)
                {
                    Console.WriteLine(book);
                    Console.WriteLine($"{new string('*', 50)}");
                }
            }
        }
        public void Search(int select, string param)
        {
            if (select == 1)
                SearchName(param);
            else if (select == 2)
                SearchAuthor(param);
            else if(select == 3)
                SearchGenre(param);
        }
        public void InsertStart(Book NewBook)
        {
            NewBook.id = last_id + 1;
            last_id++;

            librery.Insert(0, NewBook);
        }
        public void InsertEnd(Book NewBook)
        {
            NewBook.id = last_id + 1;
            last_id++;
            librery.Insert(librery.Count, NewBook);
        }
        public void InsertIndex(Book NewBook)
        {
            NewBook.id = last_id + 1;
            last_id++;
            Console.Write("Enter index: "); int index = int.Parse(Console.ReadLine()!);
            librery.Insert(index -1, NewBook);
        }
        public void Insert(int select, Book NewBook)
        {
            if(select == 1)
                InsertStart(NewBook);
            else if( select == 3)
                InsertEnd(NewBook);
            else if (select == 2)
                InsertIndex(NewBook);
        }
        public void DeleteFromPos(int select)
        {
            if(select == 1)
            {
                librery.RemoveAt(0);
            }
            else if(select == 3)
            {
                librery.RemoveAt(librery.Count - 1);
            }
            else if (select == 2)
            {
                Console.Write("Enter index: "); int index = int.Parse(Console.ReadLine()!);
                librery.RemoveAt(index - 1);
            }
        }
        public void ShowAll()
        {
            for (int i = 0; i < librery.Count; i++)
            {
                Console.WriteLine(librery[i]);
                Console.WriteLine($"{new string('*', 50)}");
            }
        }
    }
}
