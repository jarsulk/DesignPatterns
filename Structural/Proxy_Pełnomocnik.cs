ISubject subject = new Subject();
Proxy proxy = new Proxy(subject);
proxy.Request();
Console.ReadKey();

interface ISubject {
	public void Request();
}
class Subject : ISubject {
	public void Request() => Console.WriteLine("SubjectRequest");
}
class Proxy : ISubject {
	private readonly ISubject subject;
	public Proxy(ISubject subject) {
		this.subject = subject;
	}
	public void Request() { 
		subject.Request();
		Console.WriteLine("ProxyRequest");
	}
}
