Factory1 factory1 = new Factory1();
IProductA productA1 = factory1.CreateProductA();
IProductB productB1 = factory1.CreateProductB();
Factory2 factory2 = new Factory2();
IProductA productA2 = factory2.CreateProductA();
IProductB productB2 = factory2.CreateProductB();

interface IProductA { }
interface IProductB { }
class ProductA1 : IProductA { }
class ProductA2 : IProductA { }
class ProductB1 : IProductB { }
class ProductB2 : IProductB { }
interface IFactory {
	IProductA CreateProductA();
	IProductB CreateProductB();
}
class Factory1 : IFactory {
	public IProductA CreateProductA() => new ProductA1();
	public IProductB CreateProductB() => new ProductB1();
}
class Factory2 : IFactory {
	public IProductA CreateProductA() => new ProductA2();
	public IProductB CreateProductB() => new ProductB2();
}
