// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
Console.Write("Задайте количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
Console.WriteLine();
Console.WriteLine("Получился массив:");
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,100));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j]+ "\t  " );
        Console.WriteLine();
}
 
Console.WriteLine();
Console.Write("Введите координату х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату у: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > m && y > n)
    Console.WriteLine("На таких координатах числа нет");
else
{
    object z = array.GetValue(x, y);
    Console.WriteLine($"На таких координатах находится число: " + z);
}