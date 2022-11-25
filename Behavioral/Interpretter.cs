Context context = new Context();
Expression expression = new Expression();
expression.Interpret(context);

abstract class IExpression {
	public abstract string Interpret(Context context);
}
class Expression : IExpression {
	public override string Interpret(Context context) => "";
}
class Context {}
