namespace _33_Directory_HW
{
    internal class Program
    {
        static string currentDirectory = Directory.GetCurrentDirectory();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                ShowMenu();
                string choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1":
                        CreateDirectory();
                        break;
                    case "2":
                        DeleteDirectory();
                        break;
                    case "3":
                        ListDirectoryContents();
                        break;
                    case "4":
                        CreateFile();
                        break;
                    case "5":
                        DeleteFile();
                        break;
                    case "6":
                        MoveFile();
                        break;
                    case "7":
                        ViewFileInfo();
                        break;
                    case "8":
                        NavigateDirectories();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        static void ShowMenu()
        {
            Console.WriteLine("\t\tMenu:");
            Console.WriteLine("\t1 - Create Directory");
            Console.WriteLine("\t2 - Delete Directory");
            Console.WriteLine("\t3 - View Directory Contents");
            Console.WriteLine("\t4 - Create File");
            Console.WriteLine("\t5 - Delete File");
            Console.WriteLine("\t6 - Move File");
            Console.WriteLine("\t7 - View File Information");
            Console.WriteLine("\t8 - Navigate Directories");
            Console.WriteLine("\t0 - Exit");
            Console.Write("\t--> ");
        }
        static void CreateDirectory()
        {
            Console.Write("Enter the name of the directory to create: ");
            string dirName = Console.ReadLine()!;
            string path = Path.Combine(currentDirectory, dirName);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("Directory created!");
            }
            else
            {
                Console.WriteLine("This directory already exists!");
            }
            Console.ReadLine();
        }
        static void DeleteDirectory()
        {
            Console.Write("Enter the name of the directory to delete: ");
            string dirName = Console.ReadLine()!;
            string path = Path.Combine(currentDirectory, dirName);

            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
                Console.WriteLine("Directory deleted!");
            }
            else
            {
                Console.WriteLine("Directory not found!");
            }
            Console.ReadLine();
        }
        static void ListDirectoryContents()
        {
            Console.WriteLine($"\tContents of \n{currentDirectory}:");

            var directories = Directory.GetDirectories(currentDirectory);
            var files = Directory.GetFiles(currentDirectory);

            Console.WriteLine("\tDirectories:");
            foreach (var dir in directories)
            {
                Console.WriteLine(Path.GetFileName(dir));
            }

            Console.WriteLine("\n\tFiles:");
            foreach (var file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
            }

            Console.ReadLine();
        }
        static void CreateFile()
        {
            Console.Write("Enter the name of the file to create: ");
            string fileName = Console.ReadLine()!;
            string filePath = Path.Combine(currentDirectory, fileName);

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
                Console.WriteLine("File created!");
            }
            else
            {
                Console.WriteLine("This file already exists!");
            }
            Console.ReadLine();
        }
        static void DeleteFile()
        {
            Console.Write("Enter the name of the file to delete: ");
            string fileName = Console.ReadLine()!;
            string filePath = Path.Combine(currentDirectory, fileName);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("File deleted!");
            }
            else
            {
                Console.WriteLine("File not found!");
            }
            Console.ReadLine();
        }
        static void MoveFile()
        {
            Console.Write("Enter the name of the file to move: ");
            string fileName = Console.ReadLine()!;
            string sourcePath = Path.Combine(currentDirectory, fileName);

            if (File.Exists(sourcePath))
            {
                Console.Write("Enter the directory path to move the file to: ");
                string targetDir = Console.ReadLine()!;
                string targetPath = Path.Combine(targetDir, fileName);

                if (Directory.Exists(targetDir))
                {
                    File.Move(sourcePath, targetPath);
                    Console.WriteLine("File moved!");
                }
                else
                {
                    Console.WriteLine("Target directory does not exist!");
                }
            }
            else
            {
                Console.WriteLine("File not found!");
            }
            Console.ReadLine();
        }
        static void ViewFileInfo()
        {
            Console.Write("Enter the name of the file to view: ");
            string fileName = Console.ReadLine()!;
            string filePath = Path.Combine(currentDirectory, fileName);

            if (File.Exists(filePath))
            {
                FileInfo fileInfo = new FileInfo(filePath);
                Console.WriteLine($"\tInformation about file {fileName}:");
                Console.WriteLine($"\tSize: {fileInfo.Length} bytes");
                Console.WriteLine($"\tCreation date: {fileInfo.CreationTime}");
                Console.WriteLine($"\tLast modification date: {fileInfo.LastWriteTime}");
            }
            else
            {
                Console.WriteLine("File not found!");
            }
            Console.ReadLine();
        }
        static void NavigateDirectories()
        {
            Console.WriteLine($"Current directory: {currentDirectory}");
            Console.WriteLine("Enter the path of the directory or 'back' to go back to the previous directory:");
            string newDir = Console.ReadLine()!;

            if (newDir.ToLower() == "back")
            {
                currentDirectory = Directory.GetParent(currentDirectory)?.FullName ?? currentDirectory;
            }
            else if (Directory.Exists(newDir))
            {
                currentDirectory = newDir;
            }
            else
            {
                Console.WriteLine("Directory does not exist!");
            }
            Console.ReadLine();
        }
    }
}
