// See https://aka.ms/new-console-template for more information
Console.WriteLine("Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет");

int[,] array = { {1,4,7,2}, {5,9,2,3}, {8,4,2,4}};

System.Console.WriteLine("Укажите позицию числа в массиве:");
System.Console.Write("Строка: ");
int x = int.Parse(Console.ReadLine());
System.Console.Write("Столбец: ");
int y = int.Parse(Console.ReadLine());

if (x<4 && y<3) {System.Console.WriteLine($"Искомый элемент: {array[x-1,y-1]}");} else {System.Console.WriteLine("Такого числа в массиве нет");}

