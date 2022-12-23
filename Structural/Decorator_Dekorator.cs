IComponent component = new Component();
string s = component.Operation();
ADecorator decorator1 = new Decorator1(component);
string s1 = decorator1.Operation();
ADecorator decorator2 = new Decorator2(component);
string s2 = decorator2.Operation();
Console.WriteLine(s);
Console.WriteLine(s1);
Console.WriteLine(s2);
Console.ReadLine();

interface IComponent { 
	public string Operation();
}
class Component : IComponent {
	public virtual string Operation() => "IComponentOperation";
}
abstract class ADecorator : IComponent {
	private readonly IComponent component;
	public ADecorator(IComponent component) { 
		this.component = component;
	}
	public virtual string Operation() => "ADecoratorOperation " + component.Operation();
}
class Decorator1 : ADecorator {
	public Decorator1(IComponent component) : base(component) { }
	public override string Operation() => "Decorator1Operation " + base.Operation();
}
class Decorator2 : ADecorator {
	public Decorator2(IComponent component) : base(component) { }
	public override string Operation() => "Decorator2Operation " + base.Operation();
}
