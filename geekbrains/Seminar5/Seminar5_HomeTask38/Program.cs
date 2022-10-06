// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным
// и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// В задаче ошибка: вещественные числа невозможно
// представить существующими в C# типами данных,
// и наиболее близкие к урезанной версии вещественных чисел
// это типы с плавающей точкой. Но в примере задачи
// все элементы – целые числа, поэтому предполагаем,
// что автор имел в виду натуральные числа.

int[] GenerateArray(int size)
{
  Random rnd = new Random();
  int[] arr = new int[size];
  for (int i = 0; i <= arr.Length - 1; i++)
  {
    arr[i] = rnd.Next(0, 101);
  }
  return arr;
}

int getDif(int[] arr)
{
  int min = arr[0], max = arr[0];

  for (int i = 1; i <= arr.Length - 1; i++)
  {
    if (arr[i] > max) max = arr[i];
    else
    if (arr[i] < min) min = arr[i];
  }

  return max - min;
}

Console.Clear();

int[] arr = GenerateArray(5);

System.Console.WriteLine($"Исходный массив: [ {string.Join(", ", arr)} ]");

System.Console.WriteLine($"Разница между min и max: {getDif(arr)}");
