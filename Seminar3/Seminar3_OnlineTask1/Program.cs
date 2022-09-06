// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

int GetQuarterNumber()
{
  System.Console.Write("ВВедите номер четверти: ");
  if (!int.TryParse(Console.ReadLine(), out int number))
  {
    System.Console.WriteLine("Введите корректное целое число");
  }
  return number;
}

string GetXYRangeByQuarter(int quarterNumber)
{
  switch (quarterNumber)
  {
    case 1:
      return "x < 0, y > 0";
    case 2:
      return "x > 0, y > 0";
    case 3:
      return "x > 0, y < 0";
    case 4:
      return "x < 0, y < 0";
    default:
      return "чо-то не то";
  }
}

System.Console.WriteLine(GetXYRangeByQuarter(GetQuarterNumber()));
