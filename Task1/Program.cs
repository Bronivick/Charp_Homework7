Console.WriteLine("первая размерность массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("вторая размерность массива");
int colomns = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[rows, colomns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int m = 0; m < matrix.GetLength(1); m++)
    {
        matrix[i,m] = Math.Round(new Random().Next(0,10) + new Random().NextDouble(), 2);
        Console.Write(matrix[i,m]+ " ");
    }
    Console.WriteLine();
}
