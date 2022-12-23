Director director = new Director();
ABuilder productBuilder1 = new ProductBuilder1();
Product product1 = director.ConstructProduct1(productBuilder1);
ABuilder productBuilder2 = new ProductBuilder2();
Product product2 = director.ConstructProduct2(productBuilder2);
Console.ReadKey();

class Product { }
abstract class ABuilder {
	private Product product;
	public ABuilder() => Reset();
	public void Reset() => product = new Product();
	public abstract void BuildPartA();
	public abstract void BuildPartB();
	public Product GetResult() => product;
}
class ProductBuilder1 : ABuilder {
	public override void BuildPartA() { Console.WriteLine("Part A1"); }
	public override void BuildPartB() { Console.WriteLine("Part B1"); }
}
class ProductBuilder2 : ABuilder {
	public override void BuildPartA() { Console.WriteLine("Part A2"); }
	public override void BuildPartB() { Console.WriteLine("Part B2"); }
}
class Director {
	public Product ConstructProduct1(ABuilder builder) {
		builder.BuildPartA();
		builder.BuildPartB();
		return builder.GetResult();
	}
	public Product ConstructProduct2(ABuilder builder) {
		builder.BuildPartB();
		builder.BuildPartA();
		return builder.GetResult();
	}
}
