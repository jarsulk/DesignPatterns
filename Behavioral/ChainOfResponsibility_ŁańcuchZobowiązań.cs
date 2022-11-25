IHandler handler1 = new Handler1();
IHandler handler2 = new Handler2();
handler2.SetSuccessor(handler1);
string? s1 = handler2.HandleRequest(1);
string? s2 = handler2.HandleRequest(2);
Console.WriteLine(s1);
Console.WriteLine(s2);
Console.ReadKey();

interface IHandler {
	public void SetSuccessor(IHandler successor);
	public string? HandleRequest(int request);
}
abstract class AHandler : IHandler {
	private IHandler? successor;
	public void SetSuccessor(IHandler successor) { 
		this.successor = successor;
	}
	public virtual string? HandleRequest(int request) {
		if (successor != null)
			return successor.HandleRequest(request);
		return null;
	}
}
class Handler1 : AHandler { 
	public override string? HandleRequest(int request) {
		if (request == 1)
			return "1";
		return base.HandleRequest(request);
	}
}
class Handler2 : AHandler { 
	public override string? HandleRequest(int request) {
		if (request == 2)
			return "2";
		return base.HandleRequest(request);
	}
}
