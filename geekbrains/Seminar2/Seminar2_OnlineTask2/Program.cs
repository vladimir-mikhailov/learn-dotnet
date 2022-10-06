// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если второе число не кратно числу первому,
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно



int GetNumber()
{
  if (!int.TryParse(Console.ReadLine(), out int number))
  {
    System.Console.WriteLine("Введите корректное целое число");
  }
  return number;
}

void Check(int a, int b)
{
  int remainder = a % b;

  if (remainder == 0)
  {
    System.Console.WriteLine($"{a}, {b} -> кратно");
  }
  else
  {
    System.Console.WriteLine($"{a}, {b} -> не кратно, остаток: {remainder}");
  }
}

System.Console.Write("Введите число а: ");
int a = GetNumber();

System.Console.Write("Введите число b: ");
int b = GetNumber();

Check(a, b);
