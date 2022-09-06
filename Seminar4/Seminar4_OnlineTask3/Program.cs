//Напишите программу, которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке.

//[1,0,1,1,0,1,0,0]

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
  int[] arr = new int[arrLength];

  Random rnd = new Random();

  for (int i = 0; i <= arr.Length - 1; i++)
  {
    arr[i] = rnd.Next(2);
  }

  return arr;
}

void ShowArray()
{
  Console.Clear();
  Console.WriteLine($"[{string.Join(',', GenerateArr(GetNumber()))}]");
}

ShowArray();
