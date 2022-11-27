APrototype prototype1 = new Prototype1();
APrototype clone1 = prototype1.Clone();
APrototype prototype2 = new Prototype2();
APrototype clone2 = prototype2.Clone();
Console.ReadKey();

abstract class APrototype {
	public abstract APrototype Clone();
}
class Prototype1 : APrototype { 
	public override APrototype Clone() {
		return new Prototype1();
	}
}
class Prototype2 : APrototype { 
	public override APrototype Clone() {
		return new Prototype2();
	}
}