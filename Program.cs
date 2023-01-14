/* Задача 54: Задайте двумерный массив. Напишите программу,  
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 

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
*/

/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int[,] array = new int[4, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    int summ = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        summ += array[i, j];
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine($"сумма = {summ}");
}

int minstring = 1;
int minimum = 0;

for (int i = 0; i < array.GetLength(1); i++)
    minimum += array[0, i];

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        sum += array[i, j];
    if (sum < minimum)
    {
        minimum = sum;
        minstring = i + 1;
    }
}
Console.WriteLine();
Console.WriteLine($"строка № {minstring}");


