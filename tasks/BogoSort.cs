using System;
using System.Linq;

class BogoSortProgram
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

    int attemptCount = PerformBogoSort(numbers);

    Console.WriteLine("\nОтсортированный массив:");
    PrintArray(numbers);
    Console.WriteLine($"\nПотребовалось попыток: {attemptCount}");
  }

  static int PerformBogoSort(int[] array)
  {
    int attemptCounter = 0;

    while (!IsArraySorted(array))
    {
      ShuffleArray(array);
      ++attemptCounter;

    }

    return attemptCounter;
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

  static void ShuffleArray(int[] array)
  {
    for (int shuffleIndex = array.Length - 1; shuffleIndex > 0; --shuffleIndex)
    {
      int randomIndex = random.Next(shuffleIndex + 1);
      if (shuffleIndex != randomIndex)
      {
        int temp = array[shuffleIndex];
        array[shuffleIndex] = array[randomIndex];
        array[randomIndex] = temp;
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
