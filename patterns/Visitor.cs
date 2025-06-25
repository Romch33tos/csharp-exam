public interface IVisitor
{
  void Visit(ElementA element);
  void Visit(ElementB element);
}

public abstract class Element
{
  public abstract void Accept(IVisitor visitor);
}

public class ElementA : Element
{
  public override void Accept(IVisitor visitor)
  {
    visitor.Visit(this);
  }
}

public class ConcreteVisitor : IVisitor
{
  public void Visit(ElementA element)
  {
    Console.WriteLine("Visiting ElementA");
  }
}