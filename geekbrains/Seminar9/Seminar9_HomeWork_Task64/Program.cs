// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

int GetNumber(string what)
{
  int number;
  Console.Write($"Введите число {what}: ");
  while (!int.TryParse(Console.ReadLine(), out number))
  {
    Console.Write("Введите корректное целое число. Попробуйте ещё: ");
  }
  return number;
}

string GetNaturalsRec(int m, int n)
{
  if (m == n) return Convert.ToString(n);
  return m + ", " + GetNaturalsRec(m + 1, n);
}

int[] GetNaturals(int m, int n)
{
  int size = n - m + 1;
  int[] arr = new int[size];
  int value = m;

  for (int i = 0; i < size; i++)
  {
    arr[i] = value++;
  }

  return arr;
}

Console.WriteLine("");
int m = GetNumber("m");
int n = GetNumber("n");

Console.WriteLine("");
Console.WriteLine($"{"Натуральные числа от m до n:".PadRight(35)} [ {string.Join(", ", GetNaturals(m, n))} ]");
Console.WriteLine("");
Console.WriteLine($"{"А теперь с рекурсией:".PadRight(35)} [ {GetNaturalsRec(m, n)} ]");
Console.WriteLine("");
