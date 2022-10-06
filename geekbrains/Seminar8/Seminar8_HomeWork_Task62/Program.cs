// Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] GetSpiralArray(int size)
{
  int[,] arr = new int[size, size];

  int lastIndex = size - 1;
  int row = 0;
  int column = 0;
  arr[0, 0] = 1;
  int elem = 1;

  for (int diameter = lastIndex; diameter >= size / 2; diameter--)
  {
    while (row == lastIndex - diameter && column < diameter)
    {
      arr[row, ++column] = ++elem;
    }

    while (column == diameter && row < diameter)
    {
      arr[++row, column] = ++elem;
    }

    while (row == diameter && column > lastIndex - diameter)
    {
      arr[row, --column] = ++elem;
    }

    while (column == size - 1 - diameter && row > size - diameter)
    {
      arr[--row, column] = ++elem;
    }
  }

  return arr;
}

void PrintArray(int[,] arr)
{
  int rows = arr.GetLength(0);
  int columns = arr.GetLength(1);

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      Console.Write($"{arr[i, j]:d2}  ");
    }
    Console.WriteLine("\n");
  }
}

int[,] arr = GetSpiralArray(4);
Console.WriteLine("");
Console.WriteLine("Спиральный массив:\n");
PrintArray(arr);
Console.WriteLine("");
