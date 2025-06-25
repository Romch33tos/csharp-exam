public interface ISortingStrategy
{
  void Sort(List<int> list);
}

public class BubbleSort : ISortingStrategy
{
  public void Sort(List<int> list)
  {
    // Реализация сортировки пузырьком
  }
}

public class Context
{
  private ISortingStrategy _strategy;

  public void SetStrategy(ISortingStrategy strategy)
  {
    _strategy = strategy;
  }

  public void SortList(List<int> list)
  {
    _strategy.Sort(list);
  }
}