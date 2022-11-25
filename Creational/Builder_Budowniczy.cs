Director director = new Director();
ABuilder carBuilder1 = new CarBuilder1();
Car car1 = director.ConstructCar1(carBuilder1);
ABuilder carBuilder2 = new CarBuilder2();
Car car2 = director.ConstructCar2(carBuilder2);

class Car { }
abstract class ABuilder
{
	private Car car;
	public ABuilder() => Reset();
	public void Reset() => car = new Car();
	public abstract void BuildPartA();
	public abstract void BuildPartB();
	public Car GetResult() => car;
}
class CarBuilder1 : ABuilder
{
	public override void BuildPartA() { Console.WriteLine("Part A1"); }
	public override void BuildPartB() { Console.WriteLine("Part B1"); }
}
class CarBuilder2 : ABuilder
{
	public override void BuildPartA() { Console.WriteLine("Part A2"); }
	public override void BuildPartB() { Console.WriteLine("Part B2"); }
}
class Director
{
	public Car ConstructCar1(ABuilder builder)
	{
		builder.BuildPartA();
		builder.BuildPartB();
		return builder.GetResult();
	}
	public Car ConstructCar2(ABuilder builder)
	{
		builder.BuildPartB();
		builder.BuildPartA();
		return builder.GetResult();
	}
}
