int N = 5, M = 10;
Random r = new Random();

int[,] matr = new int[N,M];


for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
        matr[i,j] = r.Next(100);  
}



for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
        Console.Write($"{matr[i, j],3} ");
    Console.WriteLine();
}