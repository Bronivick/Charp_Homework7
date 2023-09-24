Console.WriteLine("первая размерность массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("вторая размерность массива");
int colomns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, colomns];

int sum = 0;
double mid = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int m = 0; m < matrix.GetLength(1); m++)
    {
        matrix[i,m] = new Random().Next(0,10);
        Console.Write(matrix[i,m]+ " ");
    }
    Console.WriteLine();
}


for (int m = 0; m < matrix.GetLength(1); m++)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i,m];
        
    }
    mid = (double)sum/rows;
    Console.WriteLine();
    Console.WriteLine($"Среднее арифмическое столбца {m + 1} равно {mid}");
    sum = 0;
}

