public abstract class Handler
{
  protected Handler next;

  public void SetNext(Handler handler)
  {
    next = handler;
  }

  public virtual void HandleRequest(string request)
  {
    next?.HandleRequest(request);
  }
}

public class ConcreteHandlerA : Handler
{
  public override void HandleRequest(string request)
  {
    if (request == "A")
    {
      Console.WriteLine("Handled by ConcreteHandlerA");
    }
    else
    {
      base.HandleRequest(request);
    }
  }
}
