ASubject subject = new Subject();
subject.Attach(new Observer());
subject.Attach(new Observer());
subject.Notify();
Console.ReadKey();

abstract class AObserver {
	public abstract void Update();
}
class Observer : AObserver {
	public override void Update() {
		Console.WriteLine("notify");
	}
}
abstract class ASubject {
	private readonly List<AObserver> observers = new List<AObserver>();
	public void Attach(AObserver observer) {
		observers.Add(observer);
	}
	public void Detach(AObserver observer) { 
		observers.Remove(observer);
	}
	public void Notify() {
		foreach (AObserver observer in observers)
			observer.Update();
	}
}
class Subject : ASubject {
	private string state;
}
