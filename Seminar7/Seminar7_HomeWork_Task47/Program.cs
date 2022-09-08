// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 - 2 - 0,2

// 1 - 3,3 8 - 9,9

// 8 7,8 - 7,1 9



double[,] GetArrayOfDoubles(int rows, int columns)
{
  double[,] result = new double[rows, columns];
  Random rnd = new Random();

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      result[i, j] = rnd.NextDouble() * 10;
    }
  }

  return result;
}

void ShowArray(double[,] arr)
{
  int rows = arr.GetLength(0);
  int columns = arr.GetLength(1);

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      Console.Write($"{arr[i, j]:N2}   ");
    }
    Console.Write("\n\n");
  }
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");
Console.WriteLine("Массив чисел с плавающей запятой:");
Console.WriteLine("");
double[,] arr = GetArrayOfDoubles(rows, columns);
ShowArray(arr);
