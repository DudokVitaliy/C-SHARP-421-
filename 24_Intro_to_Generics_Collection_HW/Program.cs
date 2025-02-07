using System.Diagnostics;

namespace _24_Intro_to_Generics_Collection_HW
{
    internal class Program
    {
        static Book CreateNewBook()
        {
            Book NewBook = new Book();
            Console.WriteLine("Fill all book Info: ");
            Console.Write("name  : ");
            NewBook.Name = Console.ReadLine()!;
            Console.Write("author: ");
            NewBook.Author = Console.ReadLine()!;
            Console.Write("genre : ");
            NewBook.Genre = Console.ReadLine()!;
            Console.Write("year of publication: ");
            NewBook.Year = int.Parse(Console.ReadLine()!);
            return NewBook;
        }
        static void Main(string[] args)
        {
            Librery librery = new Librery();
            librery.AddBook(new Book ("To Kill a Mockingbird", "Harper Lee", "Fiction", 1960));
            librery.AddBook(new Book ("1984", "George Orwell", "Dystopian", 1949));
            librery.AddBook(new Book ("Pride and Prejudice", "Jane Austen", "Romance", 1813));
            librery.AddBook(new Book ("Moby-Dick", "Herman Melville", "Adventure", 1851));
            librery.AddBook(new Book ("The Great Gatsby", "Scott Fitzgerald", "Tragedy", 1925));
            librery.AddBook(new Book ("Brave New World", "Aldous Huxley", "Dystopian", 1932));
            librery.AddBook(new Book ("Lord of the Flies", "William Golding", "Allegory", 1954));
            librery.AddBook(new Book ("Fahrenheit 451", "Ray Bradbury", "Dystopian", 1953));
            librery.AddBook(new Book ("The Hobbit", "John Tolkien", "Fantasy", 1937));
            librery.AddBook(new Book ("The Picture of Dorian Gray", "Oscar Wilde", "Philosophical novel", 1890));
            librery.AddBook(new Book ("Dracula", "Bram Stoker", "Gothic horror", 1897));
            librery.AddBook(new Book ("The Lord of the Rings", "John Tolkien", "Fantasy", 1954));

            int choise;
            while (true)
            {
                Console.WriteLine("\t\tMENU");
                Console.WriteLine("\t1 - Add Book");
                Console.WriteLine("\t2 - Show All");
                Console.WriteLine("\t3 - Remove Book");
                Console.WriteLine("\t4 - Change Book");
                Console.WriteLine("\t5 - Find Book");
                Console.WriteLine("\t6 - Insert Book");
                Console.WriteLine("\t7 - Delete from Position");
                Console.WriteLine("\t0 - Exit");
                Console.Write("\t-> "); choise = int.Parse(Console.ReadLine()!);
                switch (choise)
                {
                    case 1:
                        try
                        {
                            librery.AddBook(CreateNewBook());
                            Console.WriteLine("Added Successfully!");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Error! Incorect Info! Try Again!");
                        }
                        break;
                    case 2:
                        librery.ShowAll();
                        break;
                    case 3:
                        Console.Write("Enter book ID for remove: "); int id = int.Parse(Console.ReadLine()!);
                        librery.RemoveBookID(id);
                        break;
                    case 4:
                        Console.Write("Enter book ID for change info: "); id = int.Parse(Console.ReadLine()!);
                        try
                        {
                            // Є один нюанс, спочатку просить нову інформаці, а лише потім перевіряє
                            // чи є книга з такою ID але в решті все перевіряє нормально))
                            librery.ChangeInfo(id, CreateNewBook());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Error! Incorect Info! Try Again!");
                        }
                        break;
                    case 5:
                            Console.WriteLine("\tSelect search parameter");
                            Console.WriteLine("1 - Name");
                            Console.WriteLine("2 - Author");
                            Console.WriteLine("3 - Genre");
                            Console.WriteLine("-> "); int select = int.Parse(Console.ReadLine()!);
                            Console.Write("Enter info: "); string searchparam = Console.ReadLine()!;
                            librery.Search(select, searchparam);
                            
                        break;
                    case 6:
                        Console.WriteLine("\tSelect position");
                        Console.WriteLine("1 - Start");
                        Console.WriteLine("2 - Index");
                        Console.WriteLine("3 - End");
                        select = int.Parse(Console.ReadLine()!);
                        librery.Insert(select, CreateNewBook());
                        break;
                    case 7:
                        Console.WriteLine("\tSelect position");
                        Console.WriteLine("1 - Start");
                        Console.WriteLine("2 - Index");
                        Console.WriteLine("3 - End");
                        select = int.Parse(Console.ReadLine()!);
                        librery.DeleteFromPos(select);
                        break;
                    default:
                        break;
                }
                if (choise == 0)
                {
                    Console.WriteLine("\t\t~ Goodbye! ~");
                    break;
                }
            }
        }
    }
}
