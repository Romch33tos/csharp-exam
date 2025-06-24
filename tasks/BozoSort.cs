using System;
using System.Linq;

class BozoSortProgram
{
  private static readonly Random random = new Random();

  static void Main()
  {
    Console.WriteLine("Введите элементы массива через пробел:");

    string userInput = Console.ReadLine();
    string[] inputValues = userInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    int[] numbers = new int[inputValues.Length];
    for (int inputIndex = 0; inputIndex < inputValues.Length; ++inputIndex)
    {
      if (!int.TryParse(inputValues[inputIndex], out numbers[inputIndex]))
      {
        Console.WriteLine($"Ошибка: '{inputValues[inputIndex]}' не является числом.");
        numbers[inputIndex] = 0;
      }
    }

    Console.WriteLine("\nИсходный массив:");
    PrintArray(numbers);

    int swapCount = PerformBozoSort(numbers);

    Console.WriteLine("\nОтсортированный массив:");
    PrintArray(numbers);
    Console.WriteLine($"\nПотребовалось перестановок: {swapCount}");
  }

  static int PerformBozoSort(int[] array)
  {
    int swapCounter = 0;

    while (!IsArraySorted(array))
    {
      int firstIndex = random.Next(array.Length);
      int secondIndex;
      do
      {
        secondIndex = random.Next(array.Length);
      } 
      while (firstIndex == secondIndex);

      SwapElements(array, firstIndex, secondIndex);
      ++swapCounter;
    }

    return swapCounter;
  }

  static bool IsArraySorted(int[] array)
  {
    for (int checkIndex = 0; checkIndex < array.Length - 1; ++checkIndex)
    {
      if (array[checkIndex] > array[checkIndex + 1])
      {
        return false;
      }
    }
    return true;
  }

  static void SwapElements(int[] array, int firstIndex, int secondIndex)
  {
    int temp = array[firstIndex];
    array[firstIndex] = array[secondIndex];
    array[secondIndex] = temp;
  }

  static void PrintArray(int[] array)
  {
    for (int printIndex = 0; printIndex < array.Length; ++printIndex)
    {
      Console.Write(array[printIndex] + " ");
    }
    Console.WriteLine();
  }
}
