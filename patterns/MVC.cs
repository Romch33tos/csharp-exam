public class Model
{
  public string Data { get; set; }
}

public class View
{
  public void Display(string message) => Console.WriteLine(message);
}

public class Controller
{
  private readonly Model _model;
  private readonly View _view;

  public Controller(Model model, View view)
  {
    _model = model;
    _view = view;
  }

  public void UpdateView() => _view.Display(_model.Data);
}