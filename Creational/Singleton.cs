Singleton s1 = Singleton.GetInstance();
s1.UserFieldOrMethod = 2;
Singleton s2 = Singleton.GetInstance();
Console.WriteLine(s2.UserFieldOrMethod);
Console.ReadKey();

sealed class Singleton {
	private static Singleton? instance;
	private Singleton() { }		// ukryty konstruktor
	public static Singleton GetInstance() => instance ?? (instance = new Singleton());
	public int UserFieldOrMethod;
}
