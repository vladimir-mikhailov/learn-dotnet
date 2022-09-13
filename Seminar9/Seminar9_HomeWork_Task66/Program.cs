// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

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

int GetSumOfNaturalsBetween(int m, int n)
{
  int sum = 0;

  for (int i = m; i <= n; i++)
  {
    sum += i;
  }

  return sum;
}

int GetSumOfNaturalsWithRecursion(int m, int n)
{
  if (m == n) return 0;
  return m + n + GetSumOfNaturalsWithRecursion(m + 1, n - 1);
}

Console.WriteLine("");
int m = GetNumber("m");
int n = GetNumber("n");

Console.WriteLine("");
Console.WriteLine($"Сумма натуральных чисел между ними равна: {GetSumOfNaturalsBetween(m, n)}");
Console.WriteLine($"А если через рекурсию, то: {GetSumOfNaturalsBetween(m, n)}");
Console.WriteLine("");
