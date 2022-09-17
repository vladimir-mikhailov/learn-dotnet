// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetArray(int rows, int columns)
{
  int[,] result = new int[rows, columns];
  Random rnd = new Random();

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      result[i, j] = rnd.Next(10);
    }
  }

  return result;
}

void PrintArray(int[,] arr)
{
  int rows = arr.GetLength(0);
  int columns = arr.GetLength(1);

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      Console.Write($"{arr[i, j]} ");
    }
    Console.Write("\n");
  }
}

int GetRowNumberWithMinSumOfElements(int[,] arr)
{
  int rows = arr.GetLength(0);
  int columns = arr.GetLength(1);

  int minSum = int.MaxValue;
  int minSumIndex = -1;

  for (int i = 0; i < rows; i++)
  {
    int sum = arr[i, 0];
    for (int j = 1; j < columns; j++)
    {
      sum += arr[i, j];
    }
    if (sum < minSum)
    {
      minSum = sum;
      minSumIndex = i;
    }
  }

  return minSumIndex + 1;
}

int[,] arr = GetArray(3, 3);
Console.WriteLine();
Console.WriteLine("Исходный массив:\n");
PrintArray(arr);

Console.WriteLine();
Console.WriteLine(
  $"Номер строки с наименьшей суммой элементов: {GetRowNumberWithMinSumOfElements(arr)}\n"
  );
Console.WriteLine();
