APrototype prototype1 = new Prototype1(1);
APrototype clone1 = prototype1.Clone();
Console.WriteLine(clone1.Id);		// 1
APrototype prototype2 = new Prototype2(2);
APrototype clone2 = prototype2.Clone();
Console.WriteLine(clone2.Id);		// 2
Console.ReadKey();

abstract class APrototype {
	protected int id;
	public int Id { get { return id; } }
	public APrototype(int id) {
		this.id = id;
	}
	public abstract APrototype Clone();
}
class Prototype1 : APrototype {
	public Prototype1(int id) : base(id) { }
	public override APrototype Clone() {
		return (APrototype)this.MemberwiseClone();		// C# only - shallow copy (płytka)
	}
}
class Prototype2 : APrototype {
	public Prototype2(int id) : base(id) { }
	public override APrototype Clone() {
		return new Prototype2(Id) {
			id = this.Id					// other languages
		};
	}
}
