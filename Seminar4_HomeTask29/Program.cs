//Задача 29: Напишите программу, которая
//задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33-> [6, 1, 33]


int GetNumber()
{
  Console.Write("Введите число элементов массива: ");
  if (!int.TryParse(Console.ReadLine(), out int number))
  {
    Console.WriteLine("Введите корректное целое число");
  }
  return number;
}

int[] GenerateArr(int arrLength)
{
  int[] arr = new int[Math.Abs(arrLength)];

  Random rnd = new Random();

  for (int i = 0; i <= arr.Length - 1; i++)
  {
    arr[i] = rnd.Next(100);
  }

  return arr;
}

void ShowArray()
{
  Console.WriteLine($"[{string.Join(", ", GenerateArr(GetNumber()))}]");

  ShowArray();
}

Console.Clear();
ShowArray();
