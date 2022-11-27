ACreator creator1 = new Creator1();
string s1 = creator1.Create();
ACreator creator2 = new Creator2();
string s2 = creator2.Create();
Console.ReadKey();

interface IProduct {
	string Operation();
}
class Product1 : IProduct {
	public string Operation() => "Product1";
}
class Product2 : IProduct {
	public string Operation() => "Product2";
}
abstract class ACreator {
	protected abstract IProduct FactoryMethod();
	public string Create() {
		IProduct product = FactoryMethod();
		return product.Operation();
	}
}
class Creator1 : ACreator {
	protected override IProduct FactoryMethod() { 
		return new Product1();
	}
}
class Creator2 : ACreator {
	protected override IProduct FactoryMethod() { 
		return new Product2();
	}
}
