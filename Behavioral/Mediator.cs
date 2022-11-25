IMediator mediator = new Mediator();
AColleague colleague1 = new Colleague1(mediator);
AColleague colleague2 = new Colleague2(mediator);
colleague1.Send(colleague2, "a");
Console.ReadKey();

interface IMediator {
	public void Send(AColleague colleague, string message);
}
class Mediator : IMediator {
	public void Send(AColleague colleague, string message) {
		colleague.Notify(message);
	}
}
abstract class AColleague {
	protected readonly IMediator mediator;
	public AColleague(IMediator mediator) {
		this.mediator = mediator;
	}
	public abstract void Send(AColleague colleague, string message);
	public abstract void Notify(string message);
}
class Colleague1 : AColleague {
	public Colleague1(IMediator mediator) : base(mediator) { }
	public override void Send(AColleague colleague, string message) {
		mediator.Send(colleague, message);
	}
	public override void Notify(string message) {
		Console.WriteLine(message);
	}
}
class Colleague2 : AColleague {
	public Colleague2(IMediator mediator) : base(mediator) { }
	public override void Send(AColleague colleague, string message) {
		mediator.Send(colleague, message);
	}
	public override void Notify(string message) {
		Console.WriteLine(message);
	}
}
