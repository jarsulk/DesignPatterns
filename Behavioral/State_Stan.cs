Context context = new Context(new State1());
Console.WriteLine(context.State); // State1
context.Request();
Console.WriteLine(context.State); // State2
context.Request();
Console.WriteLine(context.State); // State1
Console.ReadKey();

class Context {
	public Context(AState state) => this.State = state;
	public AState State { get; set; }
	public void Request() => State.Handle(this);
}
abstract class AState {
	public abstract void Handle(Context context);
}
class State1 : AState {
	public override void Handle(Context context) {
		context.State = new State2();
	}
}
class State2 : AState {
	public override void Handle(Context context) {
		context.State = new State1();
	}
}
