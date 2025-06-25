using System;

class MatrixDiagonalSumCalculator
{
  static void Main()
  {
    Console.WriteLine("Введите размер квадратной матрицы:");
    int size = GetPositiveInteger();

    int[,] matrix = new int[size, size];

    FillMatrix(matrix);
    CalculateAndPrintDiagonalSums(matrix);
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

  static void CalculateAndPrintDiagonalSums(int[,] matrix)
  {
    int mainDiagonalSum = 0;
    int secondaryDiagonalSum = 0;
    int size = matrix.GetLength(0);

    for (int i = 0; i < size; ++i)
    {
      mainDiagonalSum += matrix[i, i];
      secondaryDiagonalSum += matrix[i, size - 1 - i];
    }

    Console.WriteLine("\nМатрица:");
    PrintMatrix(matrix);

    Console.WriteLine($"\nСумма главной диагонали: {mainDiagonalSum}");
    Console.WriteLine($"Сумма побочной диагонали: {secondaryDiagonalSum}");
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
