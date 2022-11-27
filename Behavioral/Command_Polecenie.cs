Receiver receiver = new Receiver();
ACommand command = new Command1(receiver);
Invoker invoker = new Invoker(command); // or invoker.SetCommand(command);
invoker.ExecuteCommand();
Console.ReadKey();

abstract class ACommand {
	protected Receiver receiver;
	public ACommand(Receiver receiver) => this.receiver = receiver;
	public abstract void Execute();
}
class Command1 : ACommand {
	public Command1(Receiver receiver) : base(receiver) { }
	public override void Execute() => receiver.Action();
}
class Receiver {
	public void Action() => Console.WriteLine("ReceiverAction");
}
class Invoker {
	private readonly ACommand command;
	public Invoker(ACommand command) => this.command = command;
	public void ExecuteCommand() => command.Execute();
}
