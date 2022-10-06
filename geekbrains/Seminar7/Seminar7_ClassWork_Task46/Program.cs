// Задача 46: Задайте двумерный массив размером MxN, заполненный случайными целыми числами

int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int rows, int columns)
{
  int[,] result = new int[rows, columns];

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      result[i, j] = new Random().Next(100);
    }
  }

  return result;
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

int[,] arr = GetArray(rows, columns);
ShowArray(arr);
