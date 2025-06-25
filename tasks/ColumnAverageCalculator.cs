using System;

class ColumnAverageCalculator
{
  static void Main()
  {
    Console.WriteLine("Введите количество строк матрицы:");
    int rowCount = GetPositiveInteger();

    Console.WriteLine("Введите количество столбцов матрицы:");
    int colCount = GetPositiveInteger();

    int[,] matrix = new int[rowCount, colCount];

    FillMatrix(matrix);
    CalculateAndPrintColumnAverages(matrix);
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
    for (int row = 0; row < matrix.GetLength(0); ++row)
    {
      for (int col = 0; col < matrix.GetLength(1); ++col)
      {
        Console.WriteLine($"Введите элемент [{row},{col}]:");
        while (!int.TryParse(Console.ReadLine(), out matrix[row, col]))
        {
          Console.WriteLine("Ошибка: введите целое число.");
        }
      }
    }
  }

  static void CalculateAndPrintColumnAverages(int[,] matrix)
  {
    Console.WriteLine("\nМатрица:");
    PrintMatrix(matrix);

    Console.WriteLine("\nСредние значения по столбцам:");
    for (int col = 0; col < matrix.GetLength(1); ++col)
    {
      int columnSum = 0;
      for (int row = 0; row < matrix.GetLength(0); ++row)
      {
        columnSum += matrix[row, col];
      }
      double average = (double)columnSum / matrix.GetLength(0);
      Console.WriteLine($"Столбец {col}: {average:F2}");
    }
  }

  static void PrintMatrix(int[,] matrix)
  {
    for (int row = 0; row < matrix.GetLength(0); ++row)
    {
      for (int col = 0; col < matrix.GetLength(1); ++col)
      {
        Console.Write($"{matrix[row, col],5}");
      }
      Console.WriteLine();
    }
  }
}
