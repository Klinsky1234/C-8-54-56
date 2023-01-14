/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int[,] array = new int[4, 4];
for (int i = 0; i < array.GetLength(0); i++) //1
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

for (int s = 0; s < array.GetLength(0); s++)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int x = array[s, i];
        int y = i - 1;
        while (y >= 0 && array[s, y] > x)
        {
            array[s, y + 1] = array[s, y];
            y--;
        }
        array[s, y + 1] = x;
    }
}
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++) //3
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
