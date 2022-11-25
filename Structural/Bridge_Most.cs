AAbstraction abstraction;
abstraction = new Abstraction(new Implementation1());
string s1 = abstraction.Operation();
abstraction = new Abstraction(new Implementation2());
string s2 = abstraction.Operation();
Console.WriteLine(s1);
Console.WriteLine(s2);
Console.ReadKey();

abstract class AAbstraction {
	protected IImplementation implementation;
	public AAbstraction(IImplementation implementation) {
		this.implementation = implementation;
	}
	public abstract string Operation();
}
class Abstraction : AAbstraction {
	public Abstraction(IImplementation implementation) : base(implementation) { }
	public override string Operation() => implementation.OperationImplementation();
}
interface IImplementation {
	public string OperationImplementation();
}
class Implementation1 : IImplementation { 
	public string OperationImplementation() {
		return "OperationImplementation1";
	}
}
class Implementation2 : IImplementation { 
	public string OperationImplementation() {
		return "OperationImplementation2";
	}
}
