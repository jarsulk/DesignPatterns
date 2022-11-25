AClass class1 = new Class1();
class1.TemplateMethod("a");
AClass class2 = new Class2();
class2.TemplateMethod("b");
Console.ReadKey();

abstract class AClass {
	public abstract void SubMethod(string s);
	public void TemplateMethod(string s) {
		SubMethod(s);
	}
}
class Class1 : AClass {
	public override void SubMethod(string s) {
		Console.WriteLine(s);
	}
}
class Class2 : AClass {
	public override void SubMethod(string s) {
		Console.WriteLine(s);
	}
}