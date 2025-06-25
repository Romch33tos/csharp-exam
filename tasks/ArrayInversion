using System;

class Program
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
        Console.WriteLine($"Элемент '{inputValues[inputIndex]}' некорректен и будет заменён на 0.");
        numbers[inputIndex] = 0;
      }
    }

    Console.WriteLine("\nИсходный массив:");
    PrintArray(numbers);

    InvertArray(numbers);

    Console.WriteLine("\nИнвертированный массив:");
    PrintArray(numbers);
  }

  static void InvertArray(int[] arrayToInvert)
  {
    int leftIndex = 0;
    int rightIndex = arrayToInvert.Length - 1;

    while (leftIndex < rightIndex)
    {
      int temporaryValue = arrayToInvert[leftIndex];
      arrayToInvert[leftIndex] = arrayToInvert[rightIndex];
      arrayToInvert[rightIndex] = temporaryValue;

      ++leftIndex;
      --rightIndex;
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
