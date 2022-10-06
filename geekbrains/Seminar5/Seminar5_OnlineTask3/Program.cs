// **Задача 33:**Задайте массив.Напишите программу,
//которая определяет, присутствует ли заданное число в массиве.

// 4; массив[6, 7, 19, 345, 3]->нет

// 3; массив[6, 7, 19, 345, 3]->да



int GetNumber(string what)
{
  Console.Write($"Введите {what}: ");
  if (!int.TryParse(Console.ReadLine(), out int number))
  {
    Console.WriteLine("Введите корректное целое число");
  }
  return number;
}

int[] GenerateArr(int arrLength, int minValue, int maxValue)
{
  int[] arr = new int[arrLength];

  Random rnd = new Random();

  for (int i = 0; i <= arr.Length - 1; i++)
  {
    arr[i] = rnd.Next(minValue, maxValue + 1);
  }

  return arr;
}

bool Check(int[] arr, int num)
{
  foreach (var item in arr)
  {
    if (item == num) return true;
  }
  return false;
}

void ShowArray()
{
  int[] newArr = GenerateArr(GetNumber("число элементов массива"), GetNumber("минимальное значение"), GetNumber(" максимальное значение"));
  Console.Clear();
  Console.WriteLine($"{string.Join(',', newArr)}");
  Console.WriteLine($"{Check(newArr, GetNumber("число для поиска в массиве"))}");
}

ShowArray();
