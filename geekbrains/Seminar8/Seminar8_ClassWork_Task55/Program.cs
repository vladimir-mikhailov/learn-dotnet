// **Задача 55:** Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

int[,] transponeArray(int[,] arr)
{
  int rows = arr.GetLength(0);
  int columns = arr.GetLength(1);

  int[,] result = new int[columns, rows];

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      result[j, i] = arr[i, j];
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


int[,] arr = GetArray(4, 6);
int[,] reversedArr = transponeArray(arr);

PrintArray(arr);
System.Console.WriteLine();
PrintArray(reversedArr);
