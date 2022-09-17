// **Задача 49:**Задайте двумерный массив.Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Например, изначально массив выглядел вот так:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// Новый массив будет выглядеть вот так:

// 1 4 7 2

// 5 **81** 2 **9**

// 8 4 2 4

int[,] GetArray(int rows, int columns)
{
  int[,] result = new int[rows, columns];

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      result[i, j] = new Random().Next(1, 11);
    }
  }

  return result;
}

int[,] PowerArray(int[,] arr)

{
  int rows = arr.GetLength(0);
  int columns = arr.GetLength(1);

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      if (i % 2 == 0 && j % 2 == 0)
      {
        arr[i, j] = arr[i, j] * arr[i, j];
      }
    }
  }

  return arr;
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

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] arr = GetArray(rows, columns);

System.Console.WriteLine("Исходный массив:");
ShowArray(arr);

System.Console.WriteLine("Изменённый массив:");
ShowArray(PowerArray(arr));
