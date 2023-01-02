// Задача 50. Напишите программу, которая на вход принимает число, 
// и возвращает позицию этого числа или что такого числа нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

bool FindPosition(int[,] array, int userDigit)
{
    bool flag = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] == userDigit)
            {    
                if(array[i,j] == userDigit) 
                {
                    Console.WriteLine($"Позиция числа {userDigit} -> [{i+1}, {j+1}]");
                    flag = true; 
                } 
            }   
        }
    }
    if(flag == false) Console.WriteLine($"{userDigit} -> такого числа не существует");
    return flag; 
}

int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
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

// запрашиваем у пользователя размер массива
int rows = EnterNumber("Введите количество строк: ");
int columns = EnterNumber("Введите количество столбцов: ");
// создаем массив
int[,] matrix = CreateRandomArray(rows, columns, 1, 10);
// запрашиваем у пользователя произвольное число
int userDigit = EnterNumber("Введите произвольное число: ");
// выводим массив
PrintArray(matrix);
// проверяем массив на наличие этого числа и вывод результата
bool findPosition = FindPosition(matrix, userDigit);



