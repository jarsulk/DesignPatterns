Adapted adapted = new Adapted();
IAdapter adapter1 = new Adapter1(adapted);
string s1 = adapter1.Operation();

class Adapted { 
	public string AdaptedOperation() => "AdaptedOperation";
}
interface IAdapter {
	public string Operation();
}
class Adapter1 : IAdapter {
	private Adapted adapted;
	public Adapter1(Adapted adapted) {
		this.adapted = adapted;
	}
	public string Operation() {
		return adapted.AdaptedOperation();
	}
}
