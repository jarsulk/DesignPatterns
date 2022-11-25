Originator originator = new Originator();
originator.State = "On";
Console.WriteLine(originator.State); // On
Caretaker caretaker = new Caretaker(originator.CreateMemento());
originator.State = "Off";            // Off
Console.WriteLine(originator.State);
originator.SetMemento(caretaker.Memento);
Console.WriteLine(originator.State); // On
Console.ReadKey();

class Memento {
	private readonly string state;
	public Memento(string state) => this.state = state;
	public string State { get { return state; } }
}
class Originator {
	public string State { get; set; } = string.Empty;
	public Memento CreateMemento() => new Memento(State);
	public void SetMemento(Memento memento) => State = memento.State;
}
class Caretaker {
	public Memento Memento { get; set; }
	public Caretaker(Memento memento) => Memento = memento;
}
