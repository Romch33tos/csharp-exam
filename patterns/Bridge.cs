public abstract class Abstraction
{
  protected IImplementor implementor;

  protected Abstraction(IImplementor implementor)
  {
    this.implementor = implementor;
  }

  public abstract void Operation();
}

public class RefinedAbstraction : Abstraction
{
  public RefinedAbstraction(IImplementor implementor) : base(implementor) { }

  public override void Operation()
  {
    implementor.Implement();
  }
}

public interface IImplementor
{
  void Implement();
}

public class ConcreteImplementorA : IImplementor
{
  public void Implement() => Console.WriteLine("ConcreteImplementorA Implementation");
}
