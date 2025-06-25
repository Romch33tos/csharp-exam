public interface IIterator
{
  bool HasNext();
  object Next();
}

public class ConcreteIterator : IIterator
{
  private readonly List<string> _items;
  private int _position = 0;

  public ConcreteIterator(List<string> items)
  {
    _items = items;
  }

  public bool HasNext() => _position < _items.Count;

  public object Next() => HasNext() ? _items[_position++] : null;
}