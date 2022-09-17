// Задача 50.Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7->такого числа в массиве нет



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

string GetElementByPosition(int row, int column, int[,] arr)
{
  if (row < arr.GetLength(0) && column < arr.GetLength(1))
    return Convert.ToString(arr[row, column]);
  else return string.Empty;
}

int GetNumber(string paramName)
{
  int result;
  Console.Write($"Введите {paramName}: ");

  while (!int.TryParse(Console.ReadLine(), out result))
  {
    Console.WriteLine("Некорректное число. Попробуйте ещё.");
  }

  return result;
}

Console.WriteLine("");
int rows = GetNumber("количество строк"); ;
int columns = GetNumber("количество столбцов"); ;

Console.WriteLine("");
Console.WriteLine("Массив случайных целых чисел:");
Console.WriteLine("");
int[,] arr = GetArray(rows, columns);
ShowArray(arr);
Console.WriteLine("");

int row = GetNumber("номер строки элемента") - 1;
int column = GetNumber("номер столбца элемента") - 1;
Console.WriteLine("");

string element = GetElementByPosition(row, column, arr);
if (element == string.Empty) Console.WriteLine("Такого элемента нет");
else Console.WriteLine($"Значение искомого элемента: {element}");
Console.WriteLine("");
