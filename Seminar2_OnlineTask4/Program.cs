// Напишите программу, которая принимает на вход два числа и
// проверяет, является ли одно число квадратом другого.

int GetNumber()
{
  if (!int.TryParse(Console.ReadLine(), out int number))
  {
    System.Console.WriteLine("Введите корректное целое число");
  }
  return number;
}

bool Check(int a, int b) => a == b * b || a * a == b;

System.Console.Write("Введите число a: ");
int a = GetNumber();

System.Console.Write("Введите число b: ");
int b = GetNumber();

System.Console.WriteLine(Check(a, b));
