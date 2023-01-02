// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintArray(double[,] array)
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

double[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    double[,] array = new double[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = Math.Round(rand.Next(leftRange, rightRange) + rand.NextDouble(), 1);
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

// запросить у пользователя размер двумерного массива(кол-во строк и столбцов)
int m = EnterNumber("Введите количество строк: ");
int n = EnterNumber("Введите количество столбцов: ");
// создаем вещественный массив - рандомно
double[,] matrix = CreateRandomArray(m, n, -9, 10);
//вывод массива
PrintArray(matrix);