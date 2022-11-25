FlyweightFactory flyweightFactory = new FlyweightFactory(new Dictionary<string, AFlyweight>());
AFlyweight flyweight1a = flyweightFactory.GetFlyweight("a", new { name = "name a" });
AFlyweight flyweight1b = flyweightFactory.GetFlyweight("a", new { name = "name a" });
Console.WriteLine(flyweight1a.GetState());
Console.WriteLine(flyweight1b.GetState());
Console.ReadKey();

abstract class AFlyweight {
	private readonly object state;
	public AFlyweight(object state) {
		this.state = state;
	}
	public object GetState() { return state; }
}
class Flyweight1 : AFlyweight {
	public Flyweight1(object state) : base(state) { }
}
class Flyweight2 : AFlyweight {
	public Flyweight2(object state) : base(state) { }
}
class FlyweightFactory {
	private readonly Dictionary<string, AFlyweight> flyweights;
	public FlyweightFactory(Dictionary<string, AFlyweight> flyweights) {
		this.flyweights = flyweights;
	}
	public AFlyweight GetFlyweight(string key, object state) {
		if (flyweights.ContainsKey(key))
			return flyweights[key];
		else {
			AFlyweight newFlyweight = new Flyweight1(state); // or Flyweight2()
			flyweights.Add(key, newFlyweight);
			return newFlyweight;
		}
	}
}
