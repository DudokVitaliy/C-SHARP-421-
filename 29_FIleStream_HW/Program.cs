namespace _29_FIleStream_HW
{
    internal class Program
    {
        static void WriteTxt(string text, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(text);
            }
        }
        static string ReadTxt(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            { return sr.ReadToEnd(); }
        }
        static string[] ModerationText(string[] text_words, string[] mod_words)
        {
            Console.WriteLine("Text words: ");
            foreach (string word in text_words)
            {
                Console.Write($"{word}; ");
            }
            Console.WriteLine();
            Console.WriteLine("Moder words: ");
            foreach (string word in mod_words)
            {
                Console.Write($"{word}; ");
            }
            Console.WriteLine();
            for (int i = 0; i < text_words.Length; i++)
            {
                for (int j = 0; j < mod_words.Length; j++)
                {
                    if (text_words[i] == mod_words[j])
                    {
                        text_words[i] = new string('*', text_words[i].Length);
                    }
                }
            }
            Console.WriteLine("Result: ");
            foreach (string word in text_words)
            {
                Console.Write($"{word}; ");
            }
            Console.WriteLine();
            return text_words;
        }
        static void WorkWithLorem()
        {
            string ftext = "text.txt";
            string fmod = "mod.txt";
            string fres = "res.txt";

            string text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\r\n\r\nWhy do we use it?\r\nIt is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\r\n\r\n\r\nWhere does it come from?\r\nContrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.\r\n\r\nWhere can I get some?\r\nThere are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.";
            string mod = "simply been text Lorem";

            WriteTxt(text, ftext);
            WriteTxt(mod, fmod);
            char[] separator = { ' ', '.', ',', '!', '?', ':', '\n', '\r', '-' };
            string[] text_words = ReadTxt(ftext).Split(separator, StringSplitOptions.RemoveEmptyEntries);
            string[] mod_words = ReadTxt(fmod).Split(separator, StringSplitOptions.RemoveEmptyEntries);
            string [] res_words = ModerationText(text_words, mod_words);


            WriteTxt(String.Join(' ', res_words), fres);
        }
        static void CustomerData(string ftext, string fmod)
        {
            char[] separator = { ' ', '.', ',', '!', '?', ':', '\n', '\r', '-' };
            string[] text_words = ReadTxt(ftext).Split(separator, StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in text_words)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            string[] mod_words = ReadTxt(fmod).Split(separator, StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in text_words)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            string[] res_words = ModerationText(text_words, mod_words);
            string fres = "customer_res.txt";
            WriteTxt(String.Join(' ', res_words), fres);
            Console.WriteLine("\tResult saved to file :: customer_res.txt");
            Console.WriteLine("\tPress Enter to Return");
            Console.Write("\t-> "); Console.ReadLine();
        }

        static void Main(string[] args)
        {

            // Я то зробив що воно читає і занінює те що треба, і прочитає по суті будь-який текст,
            // але я не запишу його назад із тими самими розділовими знаками бо якщо їх забрати із сепаратора
            // у мене слова читатись будуть не коректно
            int choise = 0;
            while (true)
            {
                Console.WriteLine("\t\tMenu");
                Console.WriteLine("\t1 - Default Text (Lorem)");
                Console.WriteLine("\t2 - Customer Parameters");
                Console.WriteLine("\t0 - Exit");
                Console.Write("\t-> "); choise = int.Parse(Console.ReadLine()!);
                switch (choise)
                {
                    case 1:
                        WorkWithLorem();
                        Console.WriteLine("\tPress Enter to Return");
                        Console.Write("\t-> "); Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Enter the path to the text file in the format .txt (Example: ../../text.txt): ");
                            Console.Write("\t-> ");
                            string ftext = Console.ReadLine()!;
                            Console.WriteLine("Enter the path to the file with the words for moderation in the format .txt: ");
                            Console.Write("\t-> ");
                            string fmod = Console.ReadLine()!;
                            CustomerData(ftext, fmod);
                            Console.Clear();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("\tError! Incorect Data! Try Again!");
                        }
                        break;
                    default:
                        break;
                }
                if (choise == 0)
                    break;


            }


        }
    }
}
