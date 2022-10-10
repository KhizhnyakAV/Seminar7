System.Console.WriteLine("Задайте двумерный массив размером m x n, заполненный случайными вещественными числами. m = 3, n = 4");

double[,] array = new double [3, 4];
Random rand = new Random();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
    array[i,j] = rand.NextDouble() * 100;
    array[i,j] = Math.Round(array[i,j], 2);
    }
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        System.Console.Write($"{array [i,j]}  ");
    }
    System.Console.WriteLine();
}