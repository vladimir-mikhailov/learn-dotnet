// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5-> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

internal class Program
{
  /// <summary>
  /// Gets an array of Fibonacci numbers
  /// </summary>
  /// <param name="size">Size of Fibonacci array</param>
  /// <returns>int[] array</returns>
  private static int[] getFibonacciArray(int size)
  {
    int[] arr = new int[size];
    if (size >= 1) arr[0] = 0;
    if (size >= 2) arr[1] = 1;

    for (int i = 2; i < size; i++)
    {
      arr[i] = arr[i - 1] + arr[i - 2];
    }

    return arr;
  }

  private static void Main(string[] args)
  {
    Console.Write(string.Join(", ", getFibonacciArray(10)));
  }
}


// ## Через рекурсию

// int GetNextFibonacci(int n)
// {
//   if (n == 0) return 0;
//   if (n == 1 || n == 2) return 1;
//   return GetNextFibonacci(n - 1) + GetNextFibonacci(n - 2);
// }

// int[] GetFibonacciArray(int size)
// {
//   int[] arr = new int[size];

//   for (int i = 0; i < size; i++)
//   {
//     arr[i] = GetNextFibonacci(i);
//   }

//   return arr;
// }

// System.Console.WriteLine($"{String.Join(", ", GetFibonacciArray(10))}");


// Рекурсия с кэшем (допилить, чтобы кэш создавался при первом обращении)

// double[] GetFiboArr(int size)
// {
//   double[] cache = new double[size];
//   cache[0] = 0;

//   double fibo(int n)
//   {
//     if (cache[n] == 0)
//     {
//       if (n == 0) cache[n] = 0;
//       if (n == 1 || n == 2) cache[n] = 1;
//       else
//       {
//         cache[n] = fibo(n - 1) + fibo(n - 2);
//       }
//     }
//     return cache[n];
//   }

//   if (size > 1) cache[1] = 1;
//   if (size > 2) cache[2] = 1;
//   if (size > 3)
//   {
//     for (int i = 3; i < size; i++)
//     {
//       cache[i] = fibo(i - 1) + fibo(i - 2);
//     }
//   }

//   return cache;
// }

// int GetSize()
// {
//   Console.Write($"Введите количетсво чисел Фибоначчи: ");
//   int size;
//   while (!int.TryParse(Console.ReadLine(), out size))
//   {
//     System.Console.WriteLine("Некорректное число, попробуйте ещё: ");
//   }
//   if (size == 0)
//   {
//     System.Console.WriteLine("Ноль нельзя, давай что-то положительное.");
//     return 1;
//   }
//   return size;
// }

// System.Console.WriteLine("");
// do
// {
//   System.Console.WriteLine($"{String.Join(", ", GetFiboArr(GetSize()))}");
//   System.Console.WriteLine("");
// } while (true);
