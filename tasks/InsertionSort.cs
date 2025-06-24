using System;

class InsertionSortProgram
{
  static void Main()
  {
    Console.WriteLine("Введите элементы массива через пробел:");

    string userInput = Console.ReadLine();
    string[] inputValues = userInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    int[] numbers = new int[inputValues.Length];
    for (int valueIndex = 0; valueIndex < inputValues.Length; ++valueIndex)
    {
      if (!int.TryParse(inputValues[valueIndex], out numbers[valueIndex]))
      {
        Console.WriteLine($"Ошибка: '{inputValues[valueIndex]}' не является числом.");
        numbers[valueIndex] = 0;
      }
    }

    Console.WriteLine("\nИсходный массив:");
    PrintArray(numbers);

    PerformInsertionSort(numbers);

    Console.WriteLine("\nОтсортированный массив:");
    PrintArray(numbers);
  }

  static void PerformInsertionSort(int[] array)
  {
    for (int unsortedIndex = 1; unsortedIndex < array.Length; ++unsortedIndex)
    {
      int currentValue = array[unsortedIndex];
      int sortedIndex = unsortedIndex - 1;

      while (sortedIndex >= 0 && array[sortedIndex] > currentValue)
      {
        array[sortedIndex + 1] = array[sortedIndex];
        --sortedIndex;
      }

      array[sortedIndex + 1] = currentValue;
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
