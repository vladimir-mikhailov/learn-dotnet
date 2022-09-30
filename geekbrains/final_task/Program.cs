// Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine();
string[] arr = GetArray(GetNumber("Задайте размер массива"));

Console.WriteLine();
int maxElemLength = GetNumber("Введите ограничение длины элемента для подсчёта");

Console.WriteLine();
Console.Write($"Исходный массив: ");
PrintArray(arr);

Console.WriteLine();
Console.Write($"Итоговый массив: ");
PrintArray(TrimArray(arr, maxElemLength));
Console.WriteLine("\n");

string[] TrimArray(string[] arr, int maxElemLength)
{
  int count = CountElems(arr, maxElemLength);

  string[] result = new string[count];
  int i = 0;
  foreach (var item in arr)
  {
    if (item.Length <= maxElemLength)
    {
      result[i] = item;
      i++;
    }
  }

  return result;
}

int CountElems(string[] arr, int maxElemLength)
{
  int count = 0;
  foreach (var item in arr)
  {
    if (item.Length <= maxElemLength)
    {
      count++;
    }
  }

  return count;
}

string[] GetArray(int size)
{
  string[] arr = new string[size];

  for (int i = 0; i < size; i++)
  {
    Console.Write($"Введите {i + 1}-й элемент:");
    arr[i] = Console.ReadLine(); //FIXME: Исключить возможность NULL
  }

  return arr;
}

int GetNumber(string message)
{
  int num;
  Console.Write($"{message}: ");
  while (!int.TryParse(Console.ReadLine(), out num))
  {
    Console.WriteLine("Введено что угодно, но не целое число. Попробуйте ещё.");
    Console.Write("Введите целое число: ");
  }
  return num;
}

void PrintArray(string[] arr)
{
  Console.WriteLine($"[\"{string.Join("\", \"", arr)}\"]");
}
