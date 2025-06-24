using System;

class Smoothsort
{
  static void Main()
  {
    Console.WriteLine("Введите числа для сортировки через пробел:");
    string[] input = Console.ReadLine().Split(' ');
    int[] numbers = new int[input.Length];
    
    for (int inputIndex = 0; inputIndex < input.Length; inputIndex++)
    {
      if (!int.TryParse(input[inputIndex], out numbers[inputIndex]))
      {
        Console.WriteLine($"Ошибка: '{input[inputIndex]}' не является числом. Будет заменено на 0.");
        numbers[inputIndex] = 0;
      }
    }
    
    PerformSmoothSort(numbers);
    
    Console.WriteLine("\nОтсортированный массив:");
    for (int outputIndex = 0; outputIndex < numbers.Length; outputIndex++)
    {
      Console.Write(numbers[outputIndex] + " ");
    }
  }
  
  static void PerformSmoothSort(int[] array)
  {
    int heapSize = array.Length;
    
    for (int heapIndex = 0; heapIndex < heapSize; heapIndex++)
    {
      Heapify(array, heapIndex);
    }
    
    for (int sortIndex = heapSize - 1; sortIndex > 0; sortIndex--)
    {
      Swap(ref array[0], ref array[sortIndex]);
      RestoreHeap(array, 0, sortIndex);
    }
  }
  
  static void Heapify(int[] array, int rootIndex)
  {
    int current = rootIndex;
    while (current > 0)
    {
      int parentIndex = (current - 1) / 2;
      if (array[current] > array[parentIndex])
      {
        Swap(ref array[current], ref array[parentIndex]);
        current = parentIndex;
      }
      else
      {
        break;
      }
    }
  }
  
  static void RestoreHeap(int[] array, int rootIndex, int heapSize)
  {
    int current = rootIndex;
    while (true)
    {
      int leftChildIndex = 2 * current + 1;
      int rightChildIndex = 2 * current + 2;
      int largestIndex = current;
      
      if (leftChildIndex < heapSize && array[leftChildIndex] > array[largestIndex])
      {
        largestIndex = leftChildIndex;
      }
      
      if (rightChildIndex < heapSize && array[rightChildIndex] > array[largestIndex])
      {
        largestIndex = rightChildIndex;
      }
      
      if (largestIndex != current)
      {
        Swap(ref array[current], ref array[largestIndex]);
        current = largestIndex;
      }
      else
      {
        break;
      }
    }
  }
  
  static void Swap(ref int first, ref int second)
  {
    int temporary = first;
    first = second;
    second = temporary;
  }
}
