// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int GetNumber()
{
  if (!int.TryParse(Console.ReadLine(), out int number))
  {
    System.Console.WriteLine("Введите корректное целое число");
  }
  return number;
}

bool isWeekDay(int dayNum) => (dayNum >= 1) && (dayNum <= 7);

bool isWeekend(int dayNum) => (dayNum == 6) || (dayNum == 7);

System.Console.Write("Введите номер дня недели: ");
int dayNumber = GetNumber();

if (!isWeekDay(dayNumber)) System.Console.WriteLine("Введите цифру от 1 до 7");
else
{
  if (isWeekend(dayNumber)) System.Console.WriteLine($"{dayNumber} -> Выходной");
  else System.Console.WriteLine($"{dayNumber} -> Трудовыебудни");
}
