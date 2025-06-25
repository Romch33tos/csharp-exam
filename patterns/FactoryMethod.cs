public abstract class Product
{
  public abstract string Operation();
}

public class ConcreteProductA : Product
{
  public override string Operation() => "Result of ConcreteProductA";
}

public class ConcreteProductB : Product
{
  public override string Operation() => "Result of ConcreteProductB";
}

public abstract class Creator
{
  public abstract Product FactoryMethod();
}

public class ConcreteCreatorA : Creator
{
  public override Product FactoryMethod() => new ConcreteProductA();
}

public class ConcreteCreatorB : Creator
{
  public override Product FactoryMethod() => new ConcreteProductB();
}