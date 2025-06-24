using System;

class QuickSortProgram
{
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
        Console.WriteLine($"Ошибка: '{inputValues[inputIndex]}' не является числом");
        numbers[inputIndex] = 0;
      }
    }

    Console.WriteLine("\nИсходный массив:");
    PrintArray(numbers);

    PerformQuickSort(numbers, 0, numbers.Length - 1);

    Console.WriteLine("\nОтсортированный массив:");
    PrintArray(numbers);
  }

  static void PerformQuickSort(int[] array, int startIndex, int endIndex)
  {
    if (startIndex < endIndex)
    {
      int partitionIndex = PartitionArray(array, startIndex, endIndex);

      PerformQuickSort(array, startIndex, partitionIndex - 1);
      PerformQuickSort(array, partitionIndex + 1, endIndex);
    }
  }

  static int PartitionArray(int[] array, int startIndex, int endIndex)
  {
    int pivotValue = array[endIndex];
    int smallerElementIndex = startIndex - 1;

    for (int currentIndex = startIndex; currentIndex < endIndex; ++currentIndex)
    {
      if (array[currentIndex] <= pivotValue)
      {
        ++smallerElementIndex;
        SwapElements(array, smallerElementIndex, currentIndex);
      }
    }

    SwapElements(array, smallerElementIndex + 1, endIndex);
    return smallerElementIndex + 1;
  }

  static void SwapElements(int[] array, int firstIndex, int secondIndex)
  {
    if (firstIndex != secondIndex)
    {
      int temp = array[firstIndex];
      array[firstIndex] = array[secondIndex];
      array[secondIndex] = temp;
    }
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
