// Задача 34: Задайте массив заполненный
// случайными положительными трёхзначными
// числами. Напишите программу, которая
// покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GenerateArray(int size)
{
  Random rnd = new Random();

  int[] arr = new int[size];

  for (int i = 0; i <= arr.Length - 1; i++)
  {
    arr[i] = rnd.Next(100, 1000);
  }

  return arr;
}

int CountEven(int[] arr)
{
  int count = 0;

  foreach (int item in arr)
  {
    if (item % 2 == 0) count++;
  }

  return count;
}

int[] arr = GenerateArray(4);

Console.Clear();

System.Console.WriteLine($"Исходный массив: [ {string.Join(", ", arr)} ]");

System.Console.WriteLine($"Количество чётных чисел в массиве: {CountEven(arr)}");
