using System;

class BubbleSortProgram
{
  static void Main()
  {
    Console.WriteLine("Введите элементы массива через пробел:");

    string userInput = Console.ReadLine();
    string[] inputNumbers = userInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    int[] numbersToSort = new int[inputNumbers.Length];
    for (int inputIndex = 0; inputIndex < inputNumbers.Length; ++inputIndex)
    {
      if (int.TryParse(inputNumbers[inputIndex], out int parsedNumber))
      {
        numbersToSort[inputIndex] = parsedNumber;
      }
      else
      {
        Console.WriteLine($"Ошибка: '{inputNumbers[inputIndex]}' не является числом");
        numbersToSort[inputIndex] = 0;
      }
    }

    Console.WriteLine("\nИсходный массив:");
    PrintArray(numbersToSort);

    PerformBubbleSort(numbersToSort);

    Console.WriteLine("\nОтсортированный массив:");
    PrintArray(numbersToSort);
  }

  static void PerformBubbleSort(int[] arrayToSort)
  {
    int elementCount = arrayToSort.Length;
    bool swapped;

    for (int passNumber = 0; passNumber < elementCount - 1; ++passNumber)
    {
      swapped = false;

      for (int comparisonIndex = 0; comparisonIndex < elementCount - passNumber - 1; ++comparisonIndex)
      {
        if (arrayToSort[comparisonIndex] > arrayToSort[comparisonIndex + 1])
        {
          int temporaryStorage = arrayToSort[comparisonIndex];
          arrayToSort[comparisonIndex] = arrayToSort[comparisonIndex + 1];
          arrayToSort[comparisonIndex + 1] = temporaryStorage;
          swapped = true;
        }
      }

      if (!swapped)
      {
        break;
      }
    }
  }

  static void PrintArray(int[] arrayToPrint)
  {
    for (int elementIndex = 0; elementIndex < arrayToPrint.Length; ++elementIndex)
    {
      Console.Write(arrayToPrint[elementIndex] + " ");
    }
    Console.WriteLine();
  }
}
