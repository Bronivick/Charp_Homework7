int[,] matrix = new int[4, 5];


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int m = 0; m < matrix.GetLength(1); m++)
    {
        matrix[i,m] = new Random().Next(0,10);
        Console.Write(matrix[i,m]+ " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите номер строки 0 до 3");
int rows = Convert.ToInt32(Console.ReadLine());

if (rows >= 0 && rows <4)
{
    Console.WriteLine("Введите номер столбца 0 до 4");
    int columns = Convert.ToInt32(Console.ReadLine());

    if (columns>=0 && columns <5)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int m = 0; m < matrix.GetLength(1); m++)
            {
                if (i == rows && m == columns)
                {
                    Console.WriteLine($"Найденное число {matrix[i,m]}");
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Такого номера столбца нету");
        return;
    }
}
else
{
    Console.WriteLine("Такой строчки нету");
    return;
}
Console.WriteLine("");