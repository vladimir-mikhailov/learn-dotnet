// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21

double[] GetDotCoords(char dotName)
{
  System.Console.WriteLine($"Введите координаты точки {dotName}:");

  double GetCoord(char coordName)
  {
    System.Console.Write($"Введите {coordName}: ");
    if (!double.TryParse(Console.ReadLine(), out double coord))
    {
      System.Console.WriteLine("Введите корректное целое число");
    }
    return coord;
  }

  double x = GetCoord('X');
  double y = GetCoord('Y');
  double[] result = { x, y };
  return result;
}

double GetDistanceBetweenDots(double[] a, double[] b)
{
  return Math.Round(Math.Sqrt(Math.Pow((a[1] - b[1]), 2) + Math.Pow((a[0] - b[0]), 2)), 2);
}

System.Console.WriteLine(GetDistanceBetweenDots(a: GetDotCoords('a'), b: GetDotCoords('b')));
