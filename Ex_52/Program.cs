// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void AvgColumn(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (i <= array.GetLength(0))
            {
                sum += array[i,j];
            }
        }
        Console.Write(Math.Round(sum / array.GetLength(0), 1) + "; ");
    }
}

int[,] CreateArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(leftRange, rightRange);
        }
    }
    return array;
}

int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
//получить от пользователя m & n
int rows = EnterNumber("Введите количество строк: ");
int columns = EnterNumber("Введите количество столбцов: ");
//задать массив 
int[,] matrix = CreateArray(rows, columns, 1, 10);
// вывести массив
PrintArray(matrix);
// посчитать среднее арифметическое столбцов массива и вывести
Console.WriteLine();
AvgColumn(matrix);



