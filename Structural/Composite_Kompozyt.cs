Composite tree = new Composite();
tree.Add(new Leaf());
string s = tree.Operation();

abstract class AComponent {
	public abstract string Operation();
	public virtual void Add(AComponent leaf) { }
	public virtual void Remove(AComponent leaf) { }
	public virtual AComponent? Get(int i) => null;
}
class Leaf : AComponent {
	public override string Operation() => "LeafOperation";
}
class Composite : AComponent {
	protected List<AComponent> children = new List<AComponent>();
	public override string Operation() => "CompositeOperation";
	public override void Add(AComponent leaf) => children.Add(leaf);
	public override void Remove(AComponent leaf) => children.Remove(leaf);
	public override AComponent? Get(int i) => children[i];
}
