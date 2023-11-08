using System.Data;

int[,] GenerateMatr(int size)
{ 
    Random r = new Random();
    int[,] matr = new int[size,size];
    for (int i = 0; i < size; i++)
        for (int j = 0; j < size; j++)
            matr[i,j] = r.Next(3);
    return matr;
}


void ShowMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($"{matr[i, j],3} ");
        Console.WriteLine();
    }
}


int[,] MultMatrix(int[,] m1, int[,] m2)
{
    if (m1.GetLength(1) != m2.GetLength(0))
        throw new ArgumentException("Размеры матриц не подходят!");

    var rows = m1.GetLength(0);
    var cols = m2.GetLength(1);
    var l = m1.GetLength(1);
    var res = new int[rows, cols];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0;j < cols; j++)
            for(int k = 0; k < l; k++)
                res[i, j] += m1[i, k] * m2[k, j];
            
    return res;
}



int N = 2;

var a = GenerateMatr(N);

var b = GenerateMatr(N);


ShowMatrix(a);
Console.WriteLine("**********************************");
ShowMatrix(b);
Console.WriteLine("**********************************");
ShowMatrix(MultMatrix(a,b));