namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// An identifier expression (e.g., "var.region", "aws_vpc.main").
/// </summary>
internal class IdentifierExpression(string name) : TerraformExpression
{
    private readonly string _name = name ?? throw new ArgumentNullException(nameof(name));

    public string Name => _name;

    public override string Resolve(ITerraformContext? context = null) => _name;
}

/// <summary>
/// A literal value expression with type-safe HCL formatting.
/// </summary>
internal class LiteralExpression<T>(T value) : TerraformExpression
{
    private readonly T _value = value;

    public override string Resolve(ITerraformContext? context = null)
    {
        return _value switch
        {
            null => "null",
            bool b => b ? "true" : "false",
            string s => $"\"{EscapeString(s)}\"",
            int or long or short or byte => _value.ToString()!,
            float or double or decimal => _value.ToString()!,
            _ => throw new NotSupportedException($"Literal type {typeof(T).Name} is not supported")
        };
    }

    private static string EscapeString(string value)
    {
        return value
            .Replace("\\", "\\\\")
            .Replace("\"", "\\\"")
            .Replace("\n", "\\n")
            .Replace("\r", "\\r")
            .Replace("\t", "\\t");
    }
}

/// <summary>
/// A raw HCL expression (use sparingly).
/// </summary>
internal class RawExpression(string hcl) : TerraformExpression
{
    private readonly string _hcl = hcl ?? throw new ArgumentNullException(nameof(hcl));

    public override string Resolve(ITerraformContext? context = null) => _hcl;
}

/// <summary>
/// Binary expression (e.g., "a + b", "x == y").
/// </summary>
internal class BinaryExpression(TerraformExpression left, BinaryOperator op, TerraformExpression right) : TerraformExpression
{
    private readonly TerraformExpression _left = left ?? throw new ArgumentNullException(nameof(left));
    private readonly BinaryOperator _operator = op;
    private readonly TerraformExpression _right = right ?? throw new ArgumentNullException(nameof(right));

    public override string Resolve(ITerraformContext? context = null)
    {
        var opString = _operator switch
        {
            BinaryOperator.Add => "+",
            BinaryOperator.Subtract => "-",
            BinaryOperator.Multiply => "*",
            BinaryOperator.Divide => "/",
            BinaryOperator.Modulo => "%",
            BinaryOperator.Equal => "==",
            BinaryOperator.NotEqual => "!=",
            BinaryOperator.LessThan => "<",
            BinaryOperator.LessThanOrEqual => "<=",
            BinaryOperator.GreaterThan => ">",
            BinaryOperator.GreaterThanOrEqual => ">=",
            BinaryOperator.And => "&&",
            BinaryOperator.Or => "||",
            _ => throw new NotSupportedException($"Operator {_operator} not supported")
        };

        return $"{_left.ToHcl(context)} {opString} {_right.ToHcl(context)}";
    }
}

/// <summary>
/// Member access expression (e.g., "vpc.id", "data.aws_ami.ubuntu.id").
/// </summary>
internal class MemberAccessExpression(TerraformExpression obj, string member) : TerraformExpression
{
    private readonly TerraformExpression _object = obj ?? throw new ArgumentNullException(nameof(obj));
    private readonly string _member = member ?? throw new ArgumentNullException(nameof(member));

    public override string Resolve(ITerraformContext? context = null) => $"{_object.ToHcl(context)}.{_member}";
}

/// <summary>
/// Function call expression (e.g., "cidrsubnet(vpc.cidr_block, 8, 1)").
/// </summary>
internal class FunctionCallExpression(string functionName, params TerraformExpression[] arguments) : TerraformExpression
{
    private readonly string _functionName = functionName ?? throw new ArgumentNullException(nameof(functionName));
    private readonly TerraformExpression[] _arguments = arguments ?? throw new ArgumentNullException(nameof(arguments));

    public override string Resolve(ITerraformContext? context = null)
    {
        var args = string.Join(", ", _arguments.Select(a => a.ToHcl(context)));
        return $"{_functionName}({args})";
    }
}

/// <summary>
/// List literal expression (e.g., ["a", "b", "c"]).
/// </summary>
internal class ListExpression : TerraformExpression
{
    private readonly List<TerraformExpression> _elements = new();

    public ListExpression() { }

    public ListExpression(params TerraformExpression[] elements)
    {
        _elements.AddRange(elements);
    }

    public ListExpression(IEnumerable<TerraformExpression> elements)
    {
        _elements.AddRange(elements);
    }

    public void Add(TerraformExpression element) => _elements.Add(element);

    public override string Resolve(ITerraformContext? context = null)
    {
        if (_elements.Count == 0)
            return "[]";

        var items = string.Join(", ", _elements.Select(e => e.ToHcl(context)));
        return $"[{items}]";
    }
}

/// <summary>
/// Object/Map literal expression (e.g., { key = value }).
/// </summary>
public class ObjectExpression : TerraformExpression
{
    private readonly Dictionary<string, TerraformExpression> _properties = new();

    public ObjectExpression() { }

    public ObjectExpression Set(string key, TerraformExpression value)
    {
        _properties[key] = value;
        return this;
    }

    public override string Resolve(ITerraformContext? context = null)
    {
        if (_properties.Count == 0)
            return "{}";

        var currentIndent = context?.Indent ?? "";
        var nextIndent = currentIndent + "  ";

        var sb = new System.Text.StringBuilder();
        sb.AppendLine("{");
        foreach (var kvp in _properties)
        {
            sb.AppendLine($"{nextIndent}{kvp.Key} = {kvp.Value.ToHcl(context)}");
        }
        sb.Append($"{currentIndent}}}");

        return sb.ToString();
    }
}

/// <summary>
/// String interpolation expression (e.g., "${var.name}-suffix").
/// </summary>
internal class StringInterpolationExpression : TerraformExpression
{
    private readonly List<object> _parts = new(); // string or TerraformExpression

    public StringInterpolationExpression(params object[] parts)
    {
        foreach (var part in parts)
        {
            if (part is string || part is TerraformExpression)
            {
                _parts.Add(part);
            }
            else
            {
                throw new ArgumentException($"Part must be string or TerraformExpression, got {part?.GetType().Name}");
            }
        }
    }

    public override string Resolve(ITerraformContext? context = null)
    {
        var sb = new System.Text.StringBuilder("\"");
        foreach (var part in _parts)
        {
            if (part is string str)
            {
                sb.Append(str.Replace("\\", "\\\\").Replace("\"", "\\\""));
            }
            else if (part is TerraformExpression expr)
            {
                sb.Append("${");
                sb.Append(expr.ToHcl(context));
                sb.Append("}");
            }
        }
        sb.Append("\"");
        return sb.ToString();
    }
}

/// <summary>
/// For expression (e.g., [for x in list : x.id] or { for k, v in map : k => v.id }).
/// </summary>
internal class ForExpression : TerraformExpression
{
    private readonly string _itemVar;
    private readonly string? _keyVar;
    private readonly TerraformExpression _collection;
    private readonly TerraformExpression _resultExpression;
    private readonly TerraformExpression? _keyExpression;
    private readonly TerraformExpression? _condition;
    private readonly bool _isMap;

    // List for expression: [for x in collection : result]
    public ForExpression(string itemVar, TerraformExpression collection, TerraformExpression resultExpression, TerraformExpression? condition = null)
    {
        _itemVar = itemVar;
        _collection = collection;
        _resultExpression = resultExpression;
        _condition = condition;
        _isMap = false;
    }

    // Map for expression: { for k, v in collection : key => value }
    public ForExpression(string keyVar, string itemVar, TerraformExpression collection, TerraformExpression keyExpression, TerraformExpression valueExpression, TerraformExpression? condition = null)
    {
        _keyVar = keyVar;
        _itemVar = itemVar;
        _collection = collection;
        _keyExpression = keyExpression;
        _resultExpression = valueExpression;
        _condition = condition;
        _isMap = true;
    }

    public override string Resolve(ITerraformContext? context = null)
    {
        var iteratorPart = _keyVar != null ? $"{_keyVar}, {_itemVar}" : _itemVar;
        var conditionPart = _condition != null ? $" if {_condition.ToHcl(context)}" : "";

        if (_isMap && _keyExpression != null)
        {
            return $"{{ for {iteratorPart} in {_collection.ToHcl(context)} : {_keyExpression.ToHcl(context)} => {_resultExpression.ToHcl(context)}{conditionPart} }}";
        }
        else
        {
            return $"[for {iteratorPart} in {_collection.ToHcl(context)} : {_resultExpression.ToHcl(context)}{conditionPart}]";
        }
    }
}

/// <summary>
/// Conditional expression (e.g., condition ? true_val : false_val).
/// </summary>
internal class ConditionalExpression(TerraformExpression condition, TerraformExpression trueValue, TerraformExpression falseValue) : TerraformExpression
{
    private readonly TerraformExpression _condition = condition;
    private readonly TerraformExpression _trueValue = trueValue;
    private readonly TerraformExpression _falseValue = falseValue;

    public override string Resolve(ITerraformContext? context = null)
    {
        return $"{_condition.ToHcl(context)} ? {_trueValue.ToHcl(context)} : {_falseValue.ToHcl(context)}";
    }
}

/// <summary>
/// Extension methods for building expressions.
/// </summary>
public static class TerraformExpressionExtensions
{
    /// <summary>
    /// Creates a member access expression.
    /// </summary>
    public static TerraformExpression Member(this TerraformExpression obj, string member)
        => obj[member];

    /// <summary>
    /// Creates a function call expression.
    /// </summary>
    public static TerraformExpression Call(string functionName, params TerraformExpression[] arguments)
        => new FunctionCallExpression(functionName, arguments);
}
