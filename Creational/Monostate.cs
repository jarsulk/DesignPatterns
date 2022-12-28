Monostate m1 = new Monostate();
Monostate m2 = new Monostate();
m1.Data = 1;
Console.WriteLine(m2.Data); // 1
Console.ReadKey();

class Monostate {
	private static int data = 0;
	public int Data { get { return data; } set { data = value; } }
}
