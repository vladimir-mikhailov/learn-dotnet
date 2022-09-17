//Задача 45: Напишите программу, которая будет создавать
//копию заданного массива с помощью поэлементного копирования.

int[] CopyArray(int[] arr)
{
  int[] copy = new int[arr.Length];

  for (int i = 0; i < arr.Length; i++)
  {
    copy[i] = arr[i];
  }

  return copy;
}

int[] inputArr = { 1, 2, 5, 6, 3 };

Console.WriteLine($"Исходник: {String.Join(" ", inputArr)}");

Console.WriteLine($"Копия:    {String.Join(" ", CopyArray(inputArr))}");
