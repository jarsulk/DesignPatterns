Collection collection = new Collection();
collection.AddItem("a");
collection.AddItem("b");
Iterator iterator = new Iterator(collection);
for (string? s = iterator.First(); !iterator.IsDone(); s = iterator.Next())
	Console.WriteLine(s);
Console.ReadKey();

interface ICollection {
	public IIterator CreateIterator();
}
class Collection : ICollection {
	private List<string> items = new List<string>();
	public IIterator CreateIterator() => new Iterator(this);
	public int Count() => items.Count;
	public void AddItem(string item) => items.Add(item);
	public List<string> GetItems() => items;
}
interface IIterator {
	public string First();
	public string? Next();
	public bool IsDone();
}
class Iterator : IIterator {
	private int current;
	private readonly Collection collection;
	public Iterator(Collection collection) {
		this.collection = collection;
	}
	public string First() {
		current = 0;
		return collection.GetItems()[current];
	}
	public string? Next() {
		current++;
		if (!IsDone())
			return collection.GetItems()[current];
		else
			return null;
	}
	public bool IsDone() => current >= collection.Count();
}
