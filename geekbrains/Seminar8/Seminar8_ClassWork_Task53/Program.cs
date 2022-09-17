
// **Задача 53:** Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.


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

int[,] reverseArray(int[,] arr)
{
  int rows = arr.GetLength(0);
  int columns = arr.GetLength(1);

  int[,] result = new int[rows, columns];

  for (int i = 0; i < columns; i++)
  {
    result[0, i] = arr[rows - 1, i];
    result[rows - 1, i] = arr[0, i];
  }

  for (int i = 1; i < rows - 1; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      result[i, j] = arr[i, j];
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


int[,] arr = GetArray(5, 5);
int[,] reversedArr = reverseArray(arr);

ShowArray(arr);
System.Console.WriteLine();
ShowArray(reversedArr);
