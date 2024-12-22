using System.Drawing;

namespace _03_Mylty_Array_and_String_HW
{
    internal class Program
    {
        static string Encrypt(string text)
        {
            char[] CharText = text.ToCharArray();
            for (int i = 0; i < CharText.Length; i++)
            {
                CharText[i] = (char)(CharText[i] + 5);
            }
            return new string(CharText);
        }
        static string Decrypt(string text)
        {
            char[] CharText = text.ToCharArray();
            for (int i = 0; i < CharText.Length; i++)
            {
                CharText[i] = (char)(CharText[i] - 5);
            }
            return new string(CharText);
        }
        static int[,] FillMatrix(int size)
        {
            int [,] matrix = new int[size,size];
            for (int i = 0; i < size; i ++)
            {
                for (int j = 0; j < size; j ++)
                {
                    matrix[i,j] = new Random().Next(-10, 10);
                }
            }
            return matrix;
        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + ";\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void MatrixByNumber(int[,] matrix, int number)
        {
            for (int i = 0;i < matrix.GetLength(0);i++)
            {
                for(int j = 0;j < matrix.GetLength(1);j++)
                {
                    matrix[i,j] *= number;
                }
            }
        }
        static int[,] AdditioOfMatrices (int[,] matrix1, int[,] matrix2)
        {
            int[,] sum_matrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    sum_matrix[i,j] = matrix1[i,j] + matrix2[i,j];
                }
            }
            return sum_matrix;
        }
        static int [,] MatrixMulty(int[,] matrix1, int[,] matrix2)
        {
            int[,] multy_matrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
            for(int i = 0; i < multy_matrix.GetLength(0); i++)
            {
                for (int j = 0; j < multy_matrix.GetLength(1); j++)
                {
                    for (int f = 0; f < multy_matrix.GetLength(1); f++)
                    {
                        multy_matrix[i, j] += matrix1[i, f] * matrix2[f, j];
                    }
                }
            }
            return multy_matrix;
        }
        static void Main(string[] args)
        {
            
            {
                Console.WriteLine("\tN1");
                int count = 5;
                int[] A = new int[count];
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"\t{i + 1}-th elem: ");
                    string count_elem = Console.ReadLine();
                    int elem = int.Parse(count_elem);
                    A[i] = elem;
                }
                Console.WriteLine("All elements A: ");
                foreach (var item in A)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
                Random random = new Random();
                double[,] B = new double[3, 4];
                Console.WriteLine("All elements B: ");
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        B[i, j] = Math.Round(random.Next(10) + random.NextDouble(), 2);
                        Console.Write(B[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                double max = A[0];
                double min = A[0];
                double sum = 0;
                double prod = 1;
                foreach (var item in A)
                {
                    if (item > max)
                    {
                        max = item;
                    }
                    if (item < min)
                    {
                        min = item;
                    }
                    sum += item;
                    prod *= item;
                }
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        if (B[i, j] > max)
                        {
                            max = B[i, j];
                        }
                        if (B[i, j] < min)
                        {
                            min = B[i, j];
                        }
                        sum += B[i, j];
                        prod *= B[i, j];

                    }
                }
                double even_sum = 0;
                double odd_col_sum = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        even_sum += A[i];
                    }
                }
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        if (j % 2 != 0)
                        {
                            odd_col_sum += B[i, j];
                        }
                    }
                }
                sum = Math.Round(sum, 2);
                prod = Math.Round(prod, 2);
                Console.WriteLine("All max: " + max);
                Console.WriteLine("All min: " + min);
                Console.WriteLine("All sum: " + sum);
                Console.WriteLine("All prod: " + prod);
                Console.WriteLine("Sum even A : " + even_sum);
                Console.WriteLine("Sum odd col B: " + odd_col_sum);
            }
            {
                Console.WriteLine("\tN2");
                Random random = new Random();
                int[,] arr = new int[5, 5];
                Console.WriteLine("All elements: ");
                int max = arr[0, 0];
                int max_i = 0;
                int max_j = 0;

                int min = arr[0, 0];
                int min_i = 0;
                int min_j = 0;

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = (random.Next(200) - 100);
                        Console.Write("\t" + arr[i, j]);
                        if (arr[i, j] > max)
                        {
                            max = arr[i, j];
                            max_i = i;
                            max_j = j;
                        }
                        if (arr[i, j] < min)
                        {
                            min = arr[i, j];
                            min_i = i;
                            min_j = j;
                        }
                    }
                    Console.WriteLine();
                }
                int summa = 0;
                Console.WriteLine("Max: [" + max + "] " + max_i + ":" + max_j);
                Console.WriteLine("Min: [" + min + "] " + min_i + ":" + min_j);
                if (max_i == min_i)
                {
                    if (max_j > min_j)
                    {
                        for (int j = min_j + 1; j < max_j; j++)
                        {
                            summa += arr[max_i, j];
                        }
                    }
                    else if (max_j < min_j)
                    {
                        for (int j = max_j + 1; j < min_j; j++)
                        {
                            summa += arr[max_i, j];
                        }
                    }
                }
                else if (max_i > min_i)
                {
                    for (int j = min_j + 1; j < arr.GetLength(1); j++)
                    {
                        summa += arr[min_i, j];
                    }
                    for (int j = 0; j < max_j; j++)
                    {
                        summa += arr[max_i, j];
                    }
                    for (int i = min_i + 1; i < max_i; i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            summa += arr[i, j];
                        }
                    }
                }
                else if (min_i > max_i)
                {
                    for (int j = max_j + 1; j < arr.GetLength(1); j++)
                    {
                        summa += arr[max_i, j];
                    }
                    for (int j = 0; j < min_j; j++)
                    {
                        summa += arr[min_i, j];
                    }
                    for (int i = max_i + 1; i < min_i; i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            summa += arr[i, j];
                        }
                    }
                }
                Console.WriteLine("Summa elements from min to max = " + summa);


            }
            
            {
                Console.WriteLine("\tN3");
                Console.Write("Enter text: ");
                string text = Console.ReadLine();
                string encrypted_text = Encrypt(text);
                Console.WriteLine($"Encrypted text :: {encrypted_text}");
                string decrypted_text = Decrypt(encrypted_text);
                Console.WriteLine($"Decrypted text :: {decrypted_text}");
            }
            
            {
                Console.WriteLine("\tN4");
                Console.WriteLine("1 - Multiplying a matrix by a number");
                Console.Write("Enter size of matrix: ");
                int size = int.Parse(Console.ReadLine());
                Console.WriteLine();
                int[,] matrix = FillMatrix(size);
                PrintMatrix(matrix);
                Console.Write("Enter number: ");
                int number = int.Parse(Console.ReadLine());
                MatrixByNumber(matrix, number);
                Console.WriteLine();
                Console.WriteLine("\tResalt: ");
                PrintMatrix(matrix);

                Console.WriteLine("2 - Addition of matrices");
                Console.Write("Enter size of matrices: ");
                int sum_size = int.Parse(Console.ReadLine());
                int[,] matrix2 = FillMatrix(sum_size);
                int[,] matrix3 = FillMatrix(sum_size);
                int[,] sum_matrix = AdditioOfMatrices(matrix2, matrix3);
                Console.WriteLine("\tFirst matrix: ");
                PrintMatrix(matrix2);
                Console.WriteLine("\tSecond matrix: ");
                PrintMatrix(matrix3);
                Console.WriteLine("\tSum matrix: ");
                PrintMatrix(sum_matrix);

                Console.WriteLine("3 - Matrix multiplication");
                Console.Write("Enter size of matrices: ");
                int product_size = int.Parse(Console.ReadLine());
                int[,] matrix4 = FillMatrix(product_size);
                int[,] matrix5 = FillMatrix(product_size);
                int[,] product_matrix = MatrixMulty(matrix4, matrix5);
                Console.WriteLine("\tFirst matrix: ");
                PrintMatrix(matrix4);
                Console.WriteLine("\tSecond matrix: ");
                PrintMatrix(matrix5);
                Console.WriteLine("\tMatrix product: ");
                PrintMatrix(product_matrix);


            }
        }
    }
}
