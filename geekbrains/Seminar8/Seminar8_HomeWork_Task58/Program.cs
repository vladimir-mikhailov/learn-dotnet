// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18



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

int[,] GetProductOfTwoMatrices(int[,] arr1, int[,] arr2)
{
  int rows1 = arr1.GetLength(0);
  int columns1 = arr1.GetLength(1);

  int rows2 = arr2.GetLength(0);
  int columns2 = arr2.GetLength(1);

  int[,] resultMatrix = new int[rows1, columns2];

  if (columns1 != rows2)
  {
    Console.WriteLine("Ошибка: матрицы невозможно перемножить. Количество столбцов первой матрицы должно быть равно количеству строк второй.");
    return resultMatrix;
  }

  for (int i = 0; i < rows1; i++)
  {
    for (int k = 0; k < columns2; k++)
    {
      int sum = 0;
      for (int j = 0; j < columns1; j++)
      {
        sum += arr1[i, j] * arr2[j, k];
      }

      resultMatrix[i, k] = sum;
    }
  }

  return resultMatrix;
}

int[,] arr1 = GetArray(2, 2);
int[,] arr2 = GetArray(2, 2);
Console.WriteLine();
Console.WriteLine("Исходный массив 1:\n");
PrintArray(arr1);

Console.WriteLine();
Console.WriteLine("Исходный массив 2:\n");
PrintArray(arr2);

Console.WriteLine();
Console.WriteLine("Произведение матриц:\n");
PrintArray(GetProductOfTwoMatrices(arr1, arr2));
Console.WriteLine();
