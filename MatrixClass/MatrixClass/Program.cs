// See https://aka.ms/new-console-template for more information
using MatrixClass;

Matrix m = new Matrix(5);

m.FillRandom();
m.Show();

Console.WriteLine(m[2, 0]);

m[3] = 66;
Console.WriteLine(m[3]);

m.Show();

Console.WriteLine("***************************");
Console.WriteLine(m);