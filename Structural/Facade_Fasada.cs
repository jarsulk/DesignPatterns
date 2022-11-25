Subsystem1 subsystem1 = new Subsystem1();
Subsystem2 subsystem2 = new Subsystem2();
Facade facade = new Facade(subsystem1, subsystem2);
string s = facade.Operation();
Console.WriteLine(s);
Console.ReadKey();

class Facade {
	protected Subsystem1 subsystem1;
	protected Subsystem2 subsystem2;
	public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2) { 
		this.subsystem1 = subsystem1;
		this.subsystem2 = subsystem2;
	}
	public string Operation() => subsystem1.Operation1() + " " + subsystem2.Operation1();
}
class Subsystem1 {
	public string Operation1() => "Operation11";
}
class Subsystem2 {
	public string Operation1() => "Operation21";
}
