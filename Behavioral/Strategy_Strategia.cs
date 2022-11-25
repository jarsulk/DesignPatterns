Context context;
context = new Context(new Strategy1());
context.ContextInterface();
context = new Context(new Strategy2());
context.ContextInterface();
Console.ReadKey();

interface IStrategy {
	public void Execute();
}
class Strategy1 : IStrategy {
	public void Execute() => Console.WriteLine("Strategy1");
}
class Strategy2 : IStrategy {
	public void Execute() => Console.WriteLine("Strategy2");
}
class Context {
	private IStrategy strategy;
	public Context(IStrategy strategy) {
		this.strategy = strategy;
	}
	public void ContextInterface() => strategy.Execute();
}
