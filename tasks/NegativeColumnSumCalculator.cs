using System;

class NegativeColumnSumCalculator
{
  static void Main()
  {
    Console.WriteLine("Введите количество строк матрицы:");
    int rowCount = GetPositiveInteger();

    Console.WriteLine("Введите количество столбцов матрицы:");
    int columnCount = GetPositiveInteger();

    int[,] matrix = new int[rowCount, columnCount];

    FillMatrix(matrix);
    CalculateAndPrintNegativeColumnSums(matrix);
  }

  static int GetPositiveInteger()
  {
    while (true)
    {
      if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
      {
        return number;
      }
      Console.WriteLine("Ошибка: введите целое положительное число.");
    }
  }

  static void FillMatrix(int[,] matrix)
  {
    for (int rowIndex = 0; rowIndex < matrix.GetLength(0); ++rowIndex)
    {
      for (int colIndex = 0; colIndex < matrix.GetLength(1); ++colIndex)
      {
        Console.WriteLine($"Введите элемент [{rowIndex},{colIndex}]:");
        while (!int.TryParse(Console.ReadLine(), out matrix[rowIndex, colIndex]))
        {
          Console.WriteLine("Ошибка: введите целое число.");
        }
      }
    }
  }

  static void CalculateAndPrintNegativeColumnSums(int[,] matrix)
  {
    Console.WriteLine("\nСуммы отрицательных элементов по столбцам:");

    for (int colIndex = 0; colIndex < matrix.GetLength(1); ++colIndex)
    {
      int negativeSum = 0;

      for (int rowIndex = 0; rowIndex < matrix.GetLength(0); ++rowIndex)
      {
        if (matrix[rowIndex, colIndex] < 0)
        {
          negativeSum += matrix[rowIndex, colIndex];
        }
      }

      Console.WriteLine($"Столбец {colIndex}: {negativeSum}");
    }
  }
}
