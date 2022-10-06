// Задача 59: Из двумерного массива целых чисел удалить строку и столбец,
// на пересечении которых расположен наименьший элемент.


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

int[] GetIndexMin(int[,] arr)
{
  var result = new int[2];
  int min = arr[0, 0];
  int rows = arr.GetLength(0);
  int columns = arr.GetLength(1);

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      if (arr[i, j] < min)
      {
        min = arr[i, j];
        result[0] = i;
        result[1] = j;
      }
    }
  }

  return result;
}

int[,] GetResultArray(int[,] arr, int[] indexes)
{
  int rows = arr.GetLength(0);
  int columns = arr.GetLength(1);
  var result = new int[rows - 1, columns - 1];

  int row = 0;
  for (int i = 0; i < rows; i++)
  {
    if (i == indexes[0]) continue;

    int column = 0;
    for (int j = 0; j < columns; j++)
    {
      if (j == indexes[1]) continue;
      result[row, column] = arr[i, j];
      column++;
    }

    row++;
  }

  return result;
}


int[,] arr = GetArray(5, 6);
int[] indexMin = GetIndexMin(arr);

Console.WriteLine();
Console.WriteLine("Исходный массив:\n");
PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"Минимальный элемент: строка {indexMin[0] + 1}, столбец {indexMin[1] + 1}\n");
Console.WriteLine("Массив без строки и столбца с минимальным элементом:\n");
PrintArray(GetResultArray(arr, indexMin));
Console.WriteLine();
