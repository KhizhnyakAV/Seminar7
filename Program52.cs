// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце");

int[,] array = new int [3, 4];
Random rand = new Random();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
    array[i,j] = rand.Next(-100,100);
    }
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
    System.Console.Write($"{array[i,j]}  ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine();

double arith = 0;
for (int j = 0; j < 4; j++)
{
    for (int i = 0; i < 3; i++)
    {
    arith = arith + array[i,j];
    }
    arith = arith / 3;
    arith = Math.Round(arith, 2);
    System.Console.Write(arith);
    System.Console.Write("  ");
}