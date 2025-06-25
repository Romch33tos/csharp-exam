public abstract class Prototype
{
  public abstract Prototype Clone();
}

public class ConcretePrototype : Prototype
{
  public string Name { get; set; }

  public override Prototype Clone()
  {
    return new ConcretePrototype { Name = this.Name };
  }
}