using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace _09_Matrix
{
    internal class Matrix
    {
        int[,] matrix;
        public Matrix(int row, int col)
        {
            matrix = new int[row, col];
        }
        public int this[int r, int c]
        {
            get => matrix[r, c];
            set => matrix[r, c] = value;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder(100);
            for (int i = 0; i < matrix.GetLength(0); i ++)
            {
                for (int j = 0; j < matrix.GetLength(1); j ++)
                {
                    stringBuilder.Append($"{ matrix[i, j], -5}");
                }
                stringBuilder.AppendLine();
            }
            return stringBuilder.ToString();
        }

    }
}
