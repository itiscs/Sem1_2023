using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixClass
{
    public class Matrix
    {
        private readonly int rows;
        private readonly int columns;
        private int[,] matr;

        public Matrix(int r, int c)
        {
            rows = r;
            columns = c;
            matr = new int[rows, columns];
        }

        public Matrix(int size) : this(size,size)
        {            
        }

        public int Rows
        {
            get { return rows; }
        }

        public int Columns
        {
            get { return columns; }
        }

        public int this[int i, int j]
        {
            get { return matr[i, j]; }
            set { matr[i, j] = value; }
        }

        public int this[int i]
        {
            get { return matr[i, i]; }
            set { matr[i, i] = value; }
        }

        public void FillRandom()
        {
            Random r = new Random();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    matr[i, j] = r.Next(-100,100);

        }


        public void Show()
        {
            for(int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < columns; j++)
                    Console.Write($"{matr[i, j],3} ");
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    sb.Append($"{matr[i, j],3} ");
                sb.AppendLine();
            }
            return sb.ToString();
        }

    }
}
