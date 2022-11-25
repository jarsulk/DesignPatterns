IElement element1 = new Element1();
IElement element2 = new Element2();
IVisitor visitor1 = new Visitor1();
IVisitor visitor2 = new Visitor2();
element1.Accept(visitor1);
element1.Accept(visitor2);
element2.Accept(visitor1);
element2.Accept(visitor2);
Console.ReadKey();

interface IElement {
	public void Accept(IVisitor visitor);
}
class Element1 : IElement {
	public void Accept(IVisitor visitor) {
		visitor.VisitElement1(this);
	}
}
class Element2 : IElement {
	public void Accept(IVisitor visitor) {
		visitor.VisitElement2(this);
	}
}
interface IVisitor {
	public void VisitElement1(Element1 Element2);
	public void VisitElement2(Element2 Element2);
}
class Visitor1 : IVisitor {
	public void VisitElement1(Element1 Element1) =>
			Console.WriteLine("{0} visited by {1}", Element1.GetType().Name, this.GetType().Name);
	public void VisitElement2(Element2 Element2) =>
			Console.WriteLine("{0} visited by {1}", Element2.GetType().Name, this.GetType().Name);
}
class Visitor2 : IVisitor {
	public void VisitElement1(Element1 Element1) =>
			Console.WriteLine("{0} visited by {1}", Element1.GetType().Name, this.GetType().Name);
	public void VisitElement2(Element2 Element2) =>
			Console.WriteLine("{0} visited by {1}", Element2.GetType().Name, this.GetType().Name);
}
