using System;
using RegexMath.Calculation.Operation;

namespace RegexMath.Calculation.Binary.Arithmetic;

public sealed class MultiplyDivide : BinaryCalculation
{
    public MultiplyDivide()
        : base(Pattern) { }

    private static string Operation { get; } =
        $@"(?({Token.Operator})
                (?(Multiplication)([*]|(?<Bracket>[(])+) | \k<{Token.Operator}>) | 
                (?<{Token.Operator}>  
                  ([/%]            |
                   rem(ain(der)?)? |
                   mod(ul(o|us))?) |
                  (?<Multiplication>[*]|(?<Bracket>[(])+)))";

    private static string Pattern { get; } =
        $"(?>{Number}) ({Operation} {Number})+ (?({Token.Bracket})(?!))";

    protected override Func<double, double, double> GetOperation(string operation) => operation switch
    {
        "/"       => Divide,
        "rem"     => Remainder,
        "%"       => Remainder,
        "mod"     => Modulo,
        "modulo"  => Modulo,
        "modulus" => Modulo,
        _         => Multiply
    };

    private static double Divide(double x, double y) => x / y;

    private static double Modulo(double x, double y)
    {
        var result = x % y;
        if ((result < 0 && y > 0) || (result > 0 && y < 0))
            result += y;
        return result;
    }

    private static double Multiply(double x, double y) => x * y;

    private static double Remainder(double x, double y) => x % y;
}