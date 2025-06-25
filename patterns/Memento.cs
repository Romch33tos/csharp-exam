public class Memento
{
  public string State { get; private set; }

  public Memento(string state)
  {
    State = state;
  }
}

public class Originator
{
  public string State { get; set; }

  public Memento SaveState()
  {
    return new Memento(State);
  }

  public void RestoreState(Memento memento)
  {
    State = memento.State;
  }
}