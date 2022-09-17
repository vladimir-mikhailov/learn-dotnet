// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

int GetNumber()
{
  if (!int.TryParse(Console.ReadLine(), out int number))
  {
    System.Console.WriteLine("Введите корректное целое число");
  }
  return number;
}

bool Check(int a) => a % 7 == 0 && a % 23 == 0;

System.Console.Write("Введите число: ");
int number = GetNumber();

if (Check(number)) System.Console.WriteLine($"{number} -> кратно");
else System.Console.WriteLine($"{number} -> не кратно");
