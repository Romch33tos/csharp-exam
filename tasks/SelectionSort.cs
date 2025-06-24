using System;

class SelectionSortProgram
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
        Console.WriteLine($"Ошибка: '{inputValues[inputIndex]}' не является числом.");
        numbers[inputIndex] = 0;
      }
    }

    Console.WriteLine("\nИсходный массив:");
    PrintArray(numbers);

    PerformSelectionSort(numbers);

    Console.WriteLine("\nОтсортированный массив:");
    PrintArray(numbers);
  }

  static void PerformSelectionSort(int[] array)
  {
    for (int unsortedStart = 0; unsortedStart < array.Length - 1; ++unsortedStart)
    {
      int minIndex = unsortedStart;

      for (int searchIndex = unsortedStart + 1; searchIndex < array.Length; ++searchIndex)
      {
        if (array[searchIndex] < array[minIndex])
        {
          minIndex = searchIndex;
        }
      }

      if (minIndex != unsortedStart)
      {
        int temp = array[unsortedStart];
        array[unsortedStart] = array[minIndex];
        array[minIndex] = temp;
      }
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
