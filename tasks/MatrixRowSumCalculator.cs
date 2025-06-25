using System;

class MatrixRowSumCalculator
{
  static void Main()
  {
    Console.WriteLine("Введите количество строк матрицы:");
    int rowCount = GetPositiveInteger();

    Console.WriteLine("Введите количество столбцов матрицы:");
    int columnCount = GetPositiveInteger();

    int[,] matrix = new int[rowCount, columnCount];

    FillMatrix(matrix);
    PrintMatrixWithRowSums(matrix);
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

  static void PrintMatrixWithRowSums(int[,] matrix)
  {
    Console.WriteLine("\nМатрица с суммами строк:");

    for (int rowIndex = 0; rowIndex < matrix.GetLength(0); ++rowIndex)
    {
      int rowSum = 0;

      for (int colIndex = 0; colIndex < matrix.GetLength(1); ++colIndex)
      {
        Console.Write($"{matrix[rowIndex, colIndex],5}");
        rowSum += matrix[rowIndex, colIndex];
      }

      Console.WriteLine($"   | Сумма: {rowSum}");
    }
  }
}
