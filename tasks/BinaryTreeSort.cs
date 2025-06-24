using System;
using System.Collections.Generic;

class TreeNode
{
  public int Value { get; set; }
  public TreeNode LeftChild { get; set; }
  public TreeNode RightChild { get; set; }

  public TreeNode(int value)
  {
    Value = value;
    LeftChild = null;
    RightChild = null;
  }
}

class BinaryTreeSortProgram
{
  static void Main()
  {
    Console.WriteLine("Введите элементы массива через пробел:");

    string userInput = Console.ReadLine();
    string[] inputTokens = userInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    List<int> numbersToSort = new List<int>();
    for (int tokenIndex = 0; tokenIndex < inputTokens.Length; ++tokenIndex)
    {
      if (int.TryParse(inputTokens[tokenIndex], out int parsedNumber))
      {
        numbersToSort.Add(parsedNumber);
      }
      else
      {
        Console.WriteLine($"Ошибка: '{inputTokens[tokenIndex]}' не является числом. Элемент будет пропущен.");
      }
    }

    Console.WriteLine("\nИсходный массив:");
    PrintNumbers(numbersToSort);

    List<int> sortedNumbers = PerformTreeSort(numbersToSort);

    Console.WriteLine("\nОтсортированный массив:");
    PrintNumbers(sortedNumbers);
  }

  static List<int> PerformTreeSort(List<int> inputNumbers)
  {
    if (inputNumbers.Count == 0) return new List<int>();

    TreeNode rootNode = new TreeNode(inputNumbers[0]);

    for (int numberIndex = 1; numberIndex < inputNumbers.Count; ++numberIndex)
    {
      InsertValueIntoTree(rootNode, inputNumbers[numberIndex]);
    }

    List<int> sortedResult = new List<int>();
    TraverseTreeInOrder(rootNode, sortedResult);
    return sortedResult;
  }

  static void InsertValueIntoTree(TreeNode currentNode, int valueToInsert)
  {
    if (valueToInsert < currentNode.Value)
    {
      if (currentNode.LeftChild == null)
      {
        currentNode.LeftChild = new TreeNode(valueToInsert);
      }
      else
      {
        InsertValueIntoTree(currentNode.LeftChild, valueToInsert);
      }
    }
    else
    {
      if (currentNode.RightChild == null)
      {
        currentNode.RightChild = new TreeNode(valueToInsert);
      }
      else
      {
        InsertValueIntoTree(currentNode.RightChild, valueToInsert);
      }
    }
  }

  static void TraverseTreeInOrder(TreeNode currentNode, List<int> resultCollection)
  {
    if (currentNode != null)
    {
      TraverseTreeInOrder(currentNode.LeftChild, resultCollection);
      resultCollection.Add(currentNode.Value);
      TraverseTreeInOrder(currentNode.RightChild, resultCollection);
    }
  }

  static void PrintNumbers(List<int> numbers)
  {
    for (int position = 0; position < numbers.Count; ++position)
    {
      Console.Write(numbers[position] + " ");
    }
    Console.WriteLine();
  }
}
