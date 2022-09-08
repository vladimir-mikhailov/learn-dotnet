// Задача 52.Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] GetAverageOfEachColumnElements(int[,] arr)
{
  int numberOfRows = arr.GetLength(0);
  int numberOfColumns = arr.GetLength(1);
  double[] averagesOfColumns = new double[numberOfColumns];

  for (int i = 0; i < numberOfColumns; i++)
  {
    int sum = 0;

    for (int j = 0; j < numberOfRows; j++)
    {
      sum += arr[j, i];
    }

    averagesOfColumns[i] = (double)sum / numberOfRows;
  }

  return averagesOfColumns;
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");
Console.WriteLine("Массив случайных целых чисел:");
Console.WriteLine("");
int[,] arr = GetArray(rows, columns);
ShowArray(arr);

Console.WriteLine("");
Console.WriteLine("Среднее арифметическое каждого столбца:");
Console.WriteLine("");
double[] avgArr = GetAverageOfEachColumnElements(arr);
for (int i = 0; i < avgArr.Length; i++)
{
  Console.Write($"Столбец {Convert.ToString(i + 1)}: {avgArr[i]:N1}\n");
}
Console.WriteLine("");
