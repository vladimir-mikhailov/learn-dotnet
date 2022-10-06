// Задача 36: Задайте одномерный массив,
//  заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6]-> 0

int[] GenerateArray(int size)
{
  Random rnd = new Random();
  int[] arr = new int[size];
  for (int i = 0; i <= arr.Length - 1; i++)
  {
    arr[i] = rnd.Next(-100, 101);
  }
  return arr;
}

int SumOddElements(int[] arr)
{
  if (arr.Length == 1) return 0;

  if (arr.Length == 2) return arr[1];

  int sum = arr[1];

  for (int i = 3; i <= arr.Length - 1; i = i + 2)
  {
    sum += arr[i];
  }

  return sum;
}

int[] arr = GenerateArray(4);

Console.Clear();

System.Console.WriteLine($"Исходный массив: [ {string.Join(", ", arr)} ]");

System.Console.WriteLine($"Сумма чисел на нечётных позициях: {SumOddElements(arr)}");
