// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0, 1, 0)
// 34(1, 0, 0) 41(1, 1, 0)
// 27(0, 0, 1) 90(0, 1, 1)
// 26(1, 0, 1) 55(1, 1, 1)

bool hasElement(int[,,] arr, int elem)
{
  foreach (var item in arr)
  {
    if (item == elem) return true;
  }

  return false;
}

int GetUniqueElement(int[,,] arr)
{
  Random rnd = new Random();
  int newElem;
  do
  {
    newElem = rnd.Next(10, 100);
  } while (hasElement(arr, newElem));

  return newElem;
}

int[,,] GetArrayOfUniqueElements(int rows, int columns, int dimension3)
{
  int[,,] result = new int[rows, columns, dimension3];

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      for (int k = 0; k < dimension3; k++)
      {
        result[i, j, k] = GetUniqueElement(result);
      }
    }
  }

  return result;
}

void PrintArrayWithIndexes(int[,,] arr)
{
  int rows = arr.GetLength(0);
  int columns = arr.GetLength(1);
  int dimension3 = arr.GetLength(2);

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      for (int k = 0; k < dimension3; k++)
      {
        Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
      }
      Console.Write("\n");
    }
  }
}

PrintArrayWithIndexes(GetArrayOfUniqueElements(2, 2, 2));
