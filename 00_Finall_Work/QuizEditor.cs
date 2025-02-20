using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _00_Finall_Work
{
    public class QuizEditor
    {
        private static string quizFilePath = "quizzes.json";
        public static void Start()
        {
            while (true)
            {
                Console.WriteLine("\n\t\tQuiz Editor Menu:");
                Console.WriteLine("\t1 - Add a new quiz");
                Console.WriteLine("\t2 - Add a question to a quiz");
                Console.WriteLine("\t3 - Delete a quiz");
                Console.WriteLine("\t4 - Delete a question from a quiz");
                Console.WriteLine("\t0 - Exit");
                Console.Write("\t--> ");

                int choice = int.Parse(Console.ReadLine()!);
                if (choice == 0) break;

                switch (choice)
                {
                    case 1:
                        AddQuiz();
                        break;
                    case 2:
                        AddQuestion();
                        break;
                    case 3:
                        DeleteQuiz();
                        break;
                    case 4:
                        DeleteQuestion();
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
        public static List<Quiz> LoadQuizzes()
        {
            if (File.Exists(quizFilePath))
            {
                var json = File.ReadAllText(quizFilePath);
                return JsonSerializer.Deserialize<List<Quiz>>(json) ?? new List<Quiz>();
            }
            return new List<Quiz>();
        }

        public static void SaveQuizzes(List<Quiz> quizzes)
        {
            var json = JsonSerializer.Serialize(quizzes, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(quizFilePath, json);
        }

        public static void AddQuiz()
        {
            Console.WriteLine("Enter quiz category: ");
            string category = Console.ReadLine()!;

            List<Quiz> quizzes = LoadQuizzes();
            if (quizzes.Any(q => q.Category.Equals(category, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("A quiz with this category already exists!");
                return;
            }

            var newQuiz = new Quiz(category);
            quizzes.Add(newQuiz);
            SaveQuizzes(quizzes);
            Console.WriteLine("Quiz added successfully!");
        }

        public static void AddQuestion()
        {
            List<Quiz> quizzes = LoadQuizzes();

            Console.WriteLine("Select quiz category to add a question:");
            for (int i = 0; i < quizzes.Count; i++)
            {
                Console.WriteLine($"\t{i + 1} - {quizzes[i].Category}");
            }
            Console.WriteLine("\t0 - Back");
            Console.Write("\t--> ");

            int choice = int.Parse(Console.ReadLine()!) - 1;
            if (choice == -1)
                return;
            if (choice < 0 || choice >= quizzes.Count)
            {
                Console.WriteLine("Invalid choice!");
                return;
            }

            Quiz selectedQuiz = quizzes[choice];

            Console.WriteLine("Enter the question: ");
            string questionText = Console.ReadLine()!;

            List<string> answers = new();
            Console.WriteLine("Enter possible answers (enter 'done' to finish): ");
            while (true)
            {
                string answer = Console.ReadLine()!;
                if (answer.ToLower() == "done") break;
                answers.Add(answer);
            }

            List<int> correctAnswers = new();
            Console.WriteLine("Enter correct answer numbers separated by commas: ");
            var input = Console.ReadLine()?.Split(',').Select(i => int.Parse(i.Trim()) - 1).ToList();
            if (input != null) correctAnswers = input;

            var newQuestion = new Question(questionText, answers, correctAnswers);
            selectedQuiz.AddQuestion(newQuestion);
            SaveQuizzes(quizzes);

            Console.WriteLine("Question added successfully!");
        }

        public static void DeleteQuiz()
        {
            List<Quiz> quizzes = LoadQuizzes();

            Console.WriteLine("Select quiz category to delete:");
            for (int i = 0; i < quizzes.Count; i++)
            {
                Console.WriteLine($"\t{i + 1} - {quizzes[i].Category}");
            }

            Console.WriteLine("\t0 - Back");
            Console.Write("\t--> ");

            int choice = int.Parse(Console.ReadLine()!) - 1;
            if (choice == -1)
                return;
            if (choice < 0 || choice >= quizzes.Count)
            {
                Console.WriteLine("Invalid choice!");
                return;
            }

            quizzes.RemoveAt(choice);
            SaveQuizzes(quizzes);
            Console.WriteLine("Quiz deleted successfully!");
        }

        public static void DeleteQuestion()
        {
            List<Quiz> quizzes = LoadQuizzes();

            Console.WriteLine("Select quiz category to delete a question from:");
            for (int i = 0; i < quizzes.Count; i++)
            {
                Console.WriteLine($"\t{i + 1} - {quizzes[i].Category}");
            }
            Console.WriteLine("\t0 - Back");
            Console.Write("\t--> ");

            int choice = int.Parse(Console.ReadLine()!) - 1;
            if (choice == -1)
                return;
            if (choice < 0 || choice >= quizzes.Count)
            {
                Console.WriteLine("Invalid choice!");
                return;
            }

            Quiz selectedQuiz = quizzes[choice];

            Console.WriteLine("Select question to delete:");
            for (int i = 0; i < selectedQuiz.Questions.Count; i++)
            {
                Console.WriteLine($"\t{i + 1} - {selectedQuiz.Questions[i].Text}");
            }
            Console.WriteLine("\t0 - Back");
            Console.Write("\t--> ");

            int questionChoice = int.Parse(Console.ReadLine()!) - 1;
            if (choice == -1)
                return;
            if (questionChoice < 0 || questionChoice >= selectedQuiz.Questions.Count)
            {
                Console.WriteLine("Invalid choice!");
                return;
            }

            selectedQuiz.Questions.RemoveAt(questionChoice);
            SaveQuizzes(quizzes);

            Console.WriteLine("Question deleted successfully!");
        }
        public static void Base()
        {
            List<Quiz> quizzes = LoadQuizzes();
            var historyQuestions = new List<Question>
{
    new Question("Who was the first president of the USA?", new List<string> { "Thomas Jefferson", "George Washington", "Abraham Lincoln" }, new List<int> { 1 }),
    new Question("In which year did World War II end?", new List<string> { "1939", "1945", "1918" }, new List<int> { 1 }),
    new Question("Which country was the first to land on the moon?", new List<string> { "USA", "USSR", "China" }, new List<int> { 0 }),
    new Question("Who invented the telephone?", new List<string> { "Alexander Graham Bell", "Nikola Tesla", "Thomas Edison" }, new List<int> { 0 }),
    new Question("In what year did the French Revolution begin?", new List<string> { "1789", "1799", "1804" }, new List<int> { 0 }),
    new Question("Who was the first emperor of China?", new List<string> { "Emperor Qin Shi Huang", "Emperor Taizong", "Emperor Kangxi" }, new List<int> { 0 }),
    new Question("Who was the first woman to fly solo across the Atlantic?", new List<string> { "Amelia Earhart", "Bessie Coleman", "Sally Ride" }, new List<int> { 0 }),
    new Question("Which country was the first to abolish slavery?", new List<string> { "USA", "Haiti", "England" }, new List<int> { 1 }),
    new Question("Which event triggered the start of World War I?", new List<string> { "The assassination of Archduke Franz Ferdinand", "The signing of the Treaty of Versailles", "The attack on Pearl Harbor" }, new List<int> { 0 }),
    new Question("Who was the leader of the Soviet Union during World War II?", new List<string> { "Joseph Stalin", "Leon Trotsky", "Vladimir Lenin" }, new List<int> { 0 }),
    new Question("Who was the first president of the Soviet Union?", new List<string> { "Leonid Brezhnev", "Mikhail Gorbachev", "Vladimir Lenin" }, new List<int> { 2 }),
    new Question("In what year did the Berlin Wall fall?", new List<string> { "1989", "1975", "1991" }, new List<int> { 0 }),
    new Question("Which Roman emperor famously declared 'Veni, Vidi, Vici'?", new List<string> { "Julius Caesar", "Augustus", "Nero" }, new List<int> { 0 }),
    new Question("In what year did the Titanic sink?", new List<string> { "1912", "1905", "1898" }, new List<int> { 0 }),
    new Question("Which empire was ruled by Genghis Khan?", new List<string> { "Mongol Empire", "Ottoman Empire", "Roman Empire" }, new List<int> { 0 }),
    new Question("Who was the first woman to become a prime minister?", new List<string> { "Margaret Thatcher", "Golda Meir", "Indira Gandhi" }, new List<int> { 1 }),
    new Question("What ancient civilization built the Pyramids of Giza?", new List<string> { "Egyptians", "Sumerians", "Greeks" }, new List<int> { 0 }),
    new Question("What was the name of the first human spaceflight?", new List<string> { "Apollo 11", "Vostok 1", "Space Shuttle Endeavour" }, new List<int> { 1 }),
    new Question("In what year was the United Nations founded?", new List<string> { "1945", "1950", "1939" }, new List<int> { 0 }),
    new Question("Which battle marked the turning point in the American Civil War?", new List<string> { "The Battle of Gettysburg", "The Battle of Antietam", "The Battle of Fort Sumter" }, new List<int> { 0 })
};

            var geographyQuestions = new List<Question>
{
    new Question("What is the capital of France?", new List<string> { "Rome", "Paris", "Berlin" }, new List<int> { 1 }),
    new Question("Which is the longest river in the world?", new List<string> { "Amazon", "Nile", "Yangtze" }, new List<int> { 1 }),
    new Question("Which country is the largest by area?", new List<string> { "Russia", "Canada", "USA" }, new List<int> { 0 }),
    new Question("What is the largest ocean on Earth?", new List<string> { "Atlantic", "Indian", "Pacific" }, new List<int> { 2 }),
    new Question("What is the highest mountain in the world?", new List<string> { "Mount Everest", "K2", "Mount Kilimanjaro" }, new List<int> { 0 }),
    new Question("Which continent is known as the 'Dark Continent'?", new List<string> { "Asia", "Africa", "South America" }, new List<int> { 1 }),
    new Question("Which country has the most official languages?", new List<string> { "India", "Switzerland", "South Africa" }, new List<int> { 2 }),
    new Question("Which country is the smallest in the world?", new List<string> { "Monaco", "Vatican City", "Nauru" }, new List<int> { 1 }),
    new Question("What is the largest country in Africa?", new List<string> { "Nigeria", "Algeria", "Sudan" }, new List<int> { 1 }),
    new Question("What is the capital of Canada?", new List<string> { "Toronto", "Ottawa", "Vancouver" }, new List<int> { 1 }),
    new Question("Which sea is the lowest point on Earth?", new List<string> { "Dead Sea", "Red Sea", "Caspians Sea" }, new List<int> { 0 }),
    new Question("Which city is known as the 'Eternal City'?", new List<string> { "Athens", "Rome", "Cairo" }, new List<int> { 1 }),
    new Question("Which country has the most volcanoes?", new List<string> { "Indonesia", "Italy", "Japan" }, new List<int> { 0 }),
    new Question("Which is the largest desert in the world?", new List<string> { "Sahara", "Kalahari", "Antarctic Desert" }, new List<int> { 2 }),
    new Question("Which country has the longest coastline?", new List<string> { "Australia", "Canada", "Russia" }, new List<int> { 1 }),
    new Question("Which river flows through Egypt?", new List<string> { "Amazon", "Nile", "Yangtze" }, new List<int> { 1 }),
    new Question("What is the capital of Japan?", new List<string> { "Beijing", "Seoul", "Tokyo" }, new List<int> { 2 }),
    new Question("Which country has the most islands?", new List<string> { "Sweden", "Finland", "Indonesia" }, new List<int> { 0 }),
    new Question("Which continent has the most countries?", new List<string> { "Asia", "Africa", "Europe" }, new List<int> { 1 })
};

            var scienceQuestions = new List<Question>
{
    new Question("What is the chemical symbol for water?", new List<string> { "H2O", "CO2", "O2" }, new List<int> { 0 }),
    new Question("What planet is known as the Red Planet?", new List<string> { "Mars", "Venus", "Earth" }, new List<int> { 0 }),
    new Question("What is the speed of light?", new List<string> { "3 x 10^8 m/s", "1 x 10^6 m/s", "3 x 10^5 m/s" }, new List<int> { 0 }),
    new Question("Who developed the theory of relativity?", new List<string> { "Isaac Newton", "Albert Einstein", "Nikolai Tesla" }, new List<int> { 1 }),
    new Question("What is the most abundant element in Earth's atmosphere?", new List<string> { "Oxygen", "Nitrogen", "Carbon dioxide" }, new List<int> { 1 }),
    new Question("What is the chemical symbol for gold?", new List<string> { "Au", "Ag", "Pb" }, new List<int> { 0 }),
    new Question("What organ is responsible for pumping blood?", new List<string> { "Heart", "Lungs", "Liver" }, new List<int> { 0 }),
    new Question("What is the powerhouse of the cell?", new List<string> { "Nucleus", "Mitochondria", "Ribosome" }, new List<int> { 1 }),
    new Question("Which element is represented by the symbol 'O'?", new List<string> { "Oxygen", "Osmium", "Ozone" }, new List<int> { 0 }),
    new Question("What is the boiling point of water in Celsius?", new List<string> { "100°C", "212°C", "50°C" }, new List<int> { 0 }),
    new Question("What gas do plants absorb for photosynthesis?", new List<string> { "Oxygen", "Carbon Dioxide", "Nitrogen" }, new List<int> { 1 }),
    new Question("What is the smallest unit of life?", new List<string> { "Atom", "Molecule", "Cell" }, new List<int> { 2 }),
    new Question("Which is the most common blood type?", new List<string> { "O", "A", "B" }, new List<int> { 0 }),
    new Question("What planet is closest to the sun?", new List<string> { "Mercury", "Venus", "Earth" }, new List<int> { 0 }),
    new Question("Which blood type is known as the universal donor?", new List<string> { "O-", "AB+", "A-" }, new List<int> { 0 }),
    new Question("Who is known for developing the laws of motion?", new List<string> { "Isaac Newton", "Albert Einstein", "Galileo Galilei" }, new List<int> { 0 }),
    new Question("Which organ in the human body produces insulin?", new List<string> { "Liver", "Pancreas", "Kidney" }, new List<int> { 1 }),
    new Question("What element is most abundant in the Earth's crust?", new List<string> { "Silicon", "Aluminum", "Iron" }, new List<int> { 0 }),
    new Question("What is the second planet from the sun?", new List<string> { "Mercury", "Venus", "Earth" }, new List<int> { 1 }),
    new Question("What is the chemical symbol for iron?", new List<string> { "Fe", "Ir", "I" }, new List<int> { 0 })
};

            var literatureQuestions = new List<Question>
{
    new Question("Who wrote 'Romeo and Juliet'?", new List<string> { "Shakespeare", "Dickens", "Hemingway" }, new List<int> { 0 }),
    new Question("Who wrote 'The Odyssey'?", new List<string> { "Homer", "Virgil", "Dante" }, new List<int> { 0 }),
    new Question("What is the name of the wizard in 'Harry Potter'?", new List<string> { "Harry Potter", "Gandalf", "Merlin" }, new List<int> { 0 }),
    new Question("Which novel is written by George Orwell?", new List<string> { "1984", "Brave New World", "Fahrenheit 451" }, new List<int> { 0 }),
    new Question("Who wrote 'Moby-Dick'?", new List<string> { "Herman Melville", "Mark Twain", "Ernest Hemingway" }, new List<int> { 0 }),
    new Question("Who wrote 'Pride and Prejudice'?", new List<string> { "Jane Austen", "Charlotte Bronte", "Mary Shelley" }, new List<int> { 0 }),
    new Question("Who is the author of 'The Catcher in the Rye'?", new List<string> { "J.D. Salinger", "F. Scott Fitzgerald", "John Steinbeck" }, new List<int> { 0 }),
    new Question("Which Shakespeare play features the character of Hamlet?", new List<string> { "Hamlet", "Macbeth", "Othello" }, new List<int> { 0 }),
    new Question("Who wrote 'The Great Gatsby'?", new List<string> { "F. Scott Fitzgerald", "Ernest Hemingway", "John Steinbeck" }, new List<int> { 0 }),
    new Question("Who wrote 'Frankenstein'?", new List<string> { "Mary Shelley", "Edgar Allan Poe", "Jane Austen" }, new List<int> { 0 }),
    new Question("Who is the author of '1984'?", new List<string> { "George Orwell", "Aldous Huxley", "Ray Bradbury" }, new List<int> { 0 }),
    new Question("Who wrote 'The Hobbit'?", new List<string> { "J.R.R. Tolkien", "C.S. Lewis", "J.K. Rowling" }, new List<int> { 0 }),
    new Question("Who wrote 'The Road'?", new List<string> { "Cormac McCarthy", "John Steinbeck", "Ernest Hemingway" }, new List<int> { 0 }),
    new Question("Who wrote 'To Kill a Mockingbird'?", new List<string> { "Harper Lee", "Mark Twain", "Toni Morrison" }, new List<int> { 0 }),
    new Question("Who is the author of 'Jane Eyre'?", new List<string> { "Charlotte Bronte", "Emily Bronte", "Louisa May Alcott" }, new List<int> { 0 }),
    new Question("Who wrote 'The Iliad'?", new List<string> { "Homer", "Virgil", "Sophocles" }, new List<int> { 0 }),
    new Question("Who wrote 'Wuthering Heights'?", new List<string> { "Emily Bronte", "Charlotte Bronte", "Jane Austen" }, new List<int> { 0 }),
    new Question("Who wrote 'Don Quixote'?", new List<string> { "Miguel de Cervantes", "Gabriel Garcia Marquez", "Jorge Luis Borges" }, new List<int> { 0 }),
    new Question("Who wrote 'The Divine Comedy'?", new List<string> { "Dante Alighieri", "Virgil", "Petrarch" }, new List<int> { 0 }),
    new Question("Who wrote 'The Grapes of Wrath'?", new List<string> { "John Steinbeck", "Ernest Hemingway", "F. Scott Fitzgerald" }, new List<int> { 0 })
};
            var technologyQuestions = new List<Question>
{
    new Question("Who is known as the father of the computer?", new List<string> { "Charles Babbage", "Alan Turing", "John von Neumann" }, new List<int> { 0 }),
    new Question("What company developed the first personal computer?", new List<string> { "IBM", "Apple", "Microsoft" }, new List<int> { 1 }),
    new Question("What is the most widely used programming language?", new List<string> { "Python", "JavaScript", "Java" }, new List<int> { 1 }),
    new Question("Who invented the World Wide Web?", new List<string> { "Tim Berners-Lee", "Vint Cerf", "Al Gore" }, new List<int> { 0 }),
    new Question("What does 'HTML' stand for?", new List<string> { "HyperText Markup Language", "HyperText Markup Locator", "Hyper Transfer Markup Language" }, new List<int> { 0 }),
    new Question("What year was the first iPhone released?", new List<string> { "2007", "2005", "2010" }, new List<int> { 0 }),
    new Question("Which company created the Android operating system?", new List<string> { "Apple", "Google", "Microsoft" }, new List<int> { 1 }),
    new Question("What does 'HTTP' stand for?", new List<string> { "HyperText Transfer Protocol", "HyperText Text Protocol", "High Transfer Text Protocol" }, new List<int> { 0 }),
    new Question("What is the main function of a CPU?", new List<string> { "Performing calculations", "Storing data", "Displaying graphics" }, new List<int> { 0 }),
    new Question("Who invented the first successful airplane?", new List<string> { "The Wright Brothers", "Henry Ford", "Charles Lindbergh" }, new List<int> { 0 }),
    new Question("What is the purpose of an operating system?", new List<string> { "Managing hardware resources", "Running web browsers", "Controlling the internet" }, new List<int> { 0 }),
    new Question("Which programming language is known as the 'mother of all languages'?", new List<string> { "C", "Fortran", "Assembly" }, new List<int> { 0 }),
    new Question("What does 'USB' stand for?", new List<string> { "Universal Serial Bus", "Universal Storage Bus", "Universal System Bus" }, new List<int> { 0 }),
    new Question("Who co-founded Microsoft with Bill Gates?", new List<string> { "Steve Jobs", "Steve Wozniak", "Paul Allen" }, new List<int> { 2 }),
    new Question("What is the primary function of RAM?", new List<string> { "Storing data permanently", "Temporarily storing data for quick access", "Running software applications" }, new List<int> { 1 }),
    new Question("What is the most popular search engine?", new List<string> { "Bing", "Yahoo", "Google" }, new List<int> { 2 }),
    new Question("What does 'IP' stand for in networking?", new List<string> { "Internet Protocol", "International Protocol", "Interface Protocol" }, new List<int> { 0 }),
    new Question("What is the first name of the founder of Facebook?", new List<string> { "Mark", "Steve", "Bill" }, new List<int> { 0 }),
    new Question("Which company developed the first video game console?", new List<string> { "Nintendo", "Atari", "Sony" }, new List<int> { 1 }),
    new Question("What does 'Wi-Fi' stand for?", new List<string> { "Wireless Fidelity", "Wide Frequency Internet", "Wireless Internet Frequency" }, new List<int> { 0 }),
    new Question("What was the first computer virus?", new List<string> { "Melissa", "Creeper", "ILOVEYOU" }, new List<int> { 1 })
};

            quizzes.Add(new Quiz("History", historyQuestions));
            quizzes.Add(new Quiz("Geography", geographyQuestions));
            quizzes.Add(new Quiz("Science", scienceQuestions));
            quizzes.Add(new Quiz("Literature", literatureQuestions));
            quizzes.Add(new Quiz("Technology", technologyQuestions));

            SaveQuizzes(quizzes);

        }
    }
}
