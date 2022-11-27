Context context = new Context();
Expression expression = new Expression();
string s = expression.Interpret(context);
Console.WriteLine(s);
Console.ReadKey();

abstract class IExpression {
	public abstract string Interpret(Context context);
}
class Expression : IExpression {
	public override string Interpret(Context context) => "";
}
class Context {}
