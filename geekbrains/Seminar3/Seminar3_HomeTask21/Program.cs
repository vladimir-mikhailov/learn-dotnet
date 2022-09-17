// Задача 21

// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B(2, 1, -7), -> 15.84

// A(7, -5, 0); B(1, -1, 9)-> 11.53

double[] GetDotCoords(char dotName)
{
  System.Console.WriteLine($"Введите координаты точки {dotName}:");

  double GetCoord(char coordName)
  {
    System.Console.Write($"Введите {coordName}: ");
    if (!double.TryParse(Console.ReadLine(), out double coord))
    {
      System.Console.WriteLine("Введите корректное число");
    }
    return coord;
  }

  double x = GetCoord('X');
  double y = GetCoord('Y');
  double z = GetCoord('Z');

  double[] result = { x, y, z };

  return result;
}

double GetDistanceBetweenDots(double[] a, double[] b)
{
  return Math.Round(
    Math.Sqrt(
      Math.Pow((a[0] - b[0]), 2) +
      Math.Pow((a[1] - b[1]), 2) +
      Math.Pow((a[2] - b[2]), 2)
    )
  , 2);
}

System.Console.WriteLine($"Расстояние между точками: {GetDistanceBetweenDots(a: GetDotCoords('a'), b: GetDotCoords('b'))}"
);
