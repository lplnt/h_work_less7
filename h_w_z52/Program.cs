//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
Console.Write("Задайте количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
// int sum = 0;
Console.WriteLine();
Console.WriteLine("Получился массив:");
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(-9,10)); 
        
}
for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j]+ "\t " );
        Console.WriteLine();    
}
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    int sum = 0;
    for (int j = 0; j < n; j++)
    {
        sum += array[j, i];
    }
    Console.WriteLine("Сумма в {0} столбце: {1}", i, sum);
}