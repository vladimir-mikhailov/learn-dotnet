// Задача 43: Напишите программу, которая найдёт
// точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0,5; -0,5)

internal class Program
{
  private static void Main(string[] args)
  {
    Console.Clear();
    Console.WriteLine("y = k1 * x + b1\ny = k2 * x + b2\n");

    GetCrossPoint
    (
      k1: GetParam("k1"),
      b1: GetParam("b1"),
      k2: GetParam("k2"),
      b2: GetParam("b2")
    );
  }

  /// <summary>
  /// Gets Line params from console.
  /// </summary>
  /// <param name="varName">Name of the variable</param>
  /// <returns>int number</returns>
  private static double GetParam(string varName)
  {
    Console.Write($"Введите {varName}: ");
    double num;
    while (!double.TryParse(Console.ReadLine(), out num))
    {
      Console.WriteLine("Некорректное число, попробуйте ещё: ");
    }
    return num;
  }

  /// <summary>
  /// Defines the cross point's
  /// coords and writes it to console.
  /// </summary>
  /// <param name="k1">Line1 Angle Multiplier</param>
  /// <param name="b1">Line1 Parameter</param>
  /// <param name="k2">Line2 Angle Multiplier</param>
  /// <param name="b2">Line2 Parameter</param>
  private static void GetCrossPoint(double k1,
                                    double b1,
                                    double k2,
                                    double b2)
  {
    Console.WriteLine("");
    if (k1 == k2 && b2 == b1) Console.WriteLine("Прямые полностью совпадают.");
    else
    if (k1 == k2) Console.WriteLine("Прямые параллельны ||");
    else
    {
      double x, y;

      x = (b2 - b1) / (k1 - k2);
      y = k1 * x + b1;
      Console.WriteLine($"Точка пересечения: X: {x:N1} Y: {y:N1}");
    }
    Console.WriteLine("");
  }
}
