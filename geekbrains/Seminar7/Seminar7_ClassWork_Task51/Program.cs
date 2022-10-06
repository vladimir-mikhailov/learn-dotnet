// **Задача 51:**Задайте двумерный массив.Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1; 1) и т.д.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Сумма элементов главной диагонали: 1 + 9 + 2 = 12

int[,] GetArray(int rows, int columns)
{
  int[,] result = new int[rows, columns];
  Random rnd = new Random();

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      result[i, j] = rnd.Next(0, 10);
    }
  }

  return result;
}

int GetSumOfDiagonalElements(int[,] arr)

{
  int rows = arr.GetLength(0);
  int sum = 0;

  for (int i = 0; i < rows; i++)
  {
    sum += arr[i, i];
  }

  return sum;
}

void ShowArray(int[,] arr)
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

Console.Write("Введите количество строк и столбцов: ");
int rows = Convert.ToInt32(Console.ReadLine());
int[,] arr = GetArray(rows, rows);

Console.WriteLine("Исходный массив:");
ShowArray(arr);

Console.Write("Сумма элементов главной диагонали: ");
Console.Write(GetSumOfDiagonalElements(arr));
Console.WriteLine("");
