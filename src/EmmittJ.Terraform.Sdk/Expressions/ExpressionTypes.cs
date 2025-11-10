namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// An identifier expression (e.g., "var.region", "aws_vpc.main").
/// Can be a static string or dynamically resolved from a value.
/// </summary>
internal class IdentifierExpression<T> : TerraformExpression
{
    private readonly T _value;
    private readonly Func<T, string> _resolver;

    public IdentifierExpression(T value, Func<T, string>? resolver = null)
    {
        _value = value ?? throw new ArgumentNullException(nameof(value));
        _resolver = resolver ?? (v => v?.ToString() ?? throw new InvalidOperationException("Value.ToString() returned null"));
    }

    public override void Prepare(ITerraformContext context)
    {
        // Ensure the value is prepared before we resolve (only for dynamic identifiers)
        if (_value is ITerraformPreparable preparable)
        {
            preparable.Prepare(context);
        }
    }

    public override string ToHcl(ITerraformContext? context = null)
    {
        // Dynamic identifier
        if (_resolver != null && _value != null)
        {
            return _resolver(_value);
        }

        throw new InvalidOperationException("IdentifierExpression is in an invalid state.");
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        return obj is IdentifierExpression<T> other
            && EqualityComparer<T>.Default.Equals(_value, other._value);
    }

    public override int GetHashCode()
    {
        return _value is null ? 0 : EqualityComparer<T>.Default.GetHashCode(_value);
    }
}

/// <summary>
/// A literal value expression with type-safe HCL formatting.
/// </summary>
internal class LiteralExpression<T>(T value) : TerraformExpression
{
    private readonly T _value = value;

    public override string ToHcl(ITerraformContext? context = null)
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

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        return obj is LiteralExpression<T> other
            && EqualityComparer<T>.Default.Equals(_value, other._value);
    }

    public override int GetHashCode()
    {
        // EqualityComparer<T>.Default handles both value and reference types.
        return _value is null
            ? 0
            : EqualityComparer<T>.Default.GetHashCode(_value);
    }
}

/// <summary>
/// A raw HCL expression (use sparingly).
/// </summary>
internal class RawExpression(string hcl) : TerraformExpression
{
    private readonly string _hcl = hcl ?? throw new ArgumentNullException(nameof(hcl));

    public override string ToHcl(ITerraformContext? context = null) => _hcl;

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        return obj is RawExpression other
            && string.Equals(_hcl, other._hcl, StringComparison.Ordinal);
    }

    public override int GetHashCode()
        => StringComparer.Ordinal.GetHashCode(_hcl);
}

/// <summary>
/// Binary expression (e.g., "a + b", "x == y").
/// </summary>
internal class BinaryExpression(TerraformExpression left, BinaryOperator op, TerraformExpression right) : TerraformExpression
{
    private readonly TerraformExpression _left = left ?? throw new ArgumentNullException(nameof(left));
    private readonly BinaryOperator _operator = op;
    private readonly TerraformExpression _right = right ?? throw new ArgumentNullException(nameof(right));

    public override string ToHcl(ITerraformContext? context = null)
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

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        return obj is BinaryExpression other
            && _operator == other._operator
            && Equals(_left, other._left)
            && Equals(_right, other._right);
    }

    public override int GetHashCode()
        => HashCode.Combine(_operator, _left, _right);
}

/// <summary>
/// Member access expression (e.g., "vpc.id", "data.aws_ami.ubuntu.id").
/// </summary>
internal class MemberAccessExpression(TerraformExpression obj, string member) : TerraformExpression
{
    private readonly TerraformExpression _object = obj ?? throw new ArgumentNullException(nameof(obj));
    private readonly string _member = member ?? throw new ArgumentNullException(nameof(member));

    public override string ToHcl(ITerraformContext? context = null) => $"{_object.ToHcl(context)}.{_member}";

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        return obj is MemberAccessExpression other
            && Equals(_object, other._object)
            && string.Equals(_member, other._member, StringComparison.Ordinal);
    }

    public override int GetHashCode()
        => HashCode.Combine(_object, StringComparer.Ordinal.GetHashCode(_member));
}

/// <summary>
/// Function call expression (e.g., "cidrsubnet(vpc.cidr_block, 8, 1)").
/// </summary>
internal class FunctionCallExpression(string functionName, params TerraformExpression[] arguments) : TerraformExpression
{
    private readonly string _functionName = functionName ?? throw new ArgumentNullException(nameof(functionName));
    private readonly TerraformExpression[] _arguments = arguments ?? throw new ArgumentNullException(nameof(arguments));

    public override string ToHcl(ITerraformContext? context = null)
    {
        var args = string.Join(", ", _arguments.Select(a => a.ToHcl(context)));
        return $"{_functionName}({args})";
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        return obj is FunctionCallExpression other
            && string.Equals(_functionName, other._functionName, StringComparison.Ordinal)
            && _arguments.SequenceEqual(other._arguments);
    }

    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(StringComparer.Ordinal.GetHashCode(_functionName));
        foreach (var argument in _arguments)
        {
            hash.Add(argument);
        }
        return hash.ToHashCode();
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

    public override string ToHcl(ITerraformContext? context = null)
    {
        if (_elements.Count == 0)
            return "[]";

        var items = string.Join(", ", _elements.Select(e => e.ToHcl(context)));
        return $"[{items}]";
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        return obj is ListExpression other
            && _elements.SequenceEqual(other._elements);
    }

    public override int GetHashCode()
    {
        var hash = new HashCode();
        foreach (var element in _elements)
        {
            hash.Add(element);
        }
        return hash.ToHashCode();
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

    public override string ToHcl(ITerraformContext? context = null)
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

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj is not StringInterpolationExpression other || _parts.Count != other._parts.Count)
        {
            return false;
        }

        for (var i = 0; i < _parts.Count; i++)
        {
            var thisPart = _parts[i];
            var otherPart = other._parts[i];

            if (thisPart is string thisString && otherPart is string otherString)
            {
                if (!string.Equals(thisString, otherString, StringComparison.Ordinal))
                {
                    return false;
                }
            }
            else if (thisPart is TerraformExpression thisExpr && otherPart is TerraformExpression otherExpr)
            {
                if (!Equals(thisExpr, otherExpr))
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        return true;
    }

    public override int GetHashCode()
    {
        var hash = new HashCode();
        foreach (var part in _parts)
        {
            hash.Add(part switch
            {
                string str => StringComparer.Ordinal.GetHashCode(str),
                TerraformExpression expr => expr.GetHashCode(),
                _ => 0
            });
        }
        return hash.ToHashCode();
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

    public override string ToHcl(ITerraformContext? context = null)
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

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj is not ForExpression other)
        {
            return false;
        }

        return string.Equals(_itemVar, other._itemVar, StringComparison.Ordinal)
            && string.Equals(_keyVar, other._keyVar, StringComparison.Ordinal)
            && Equals(_collection, other._collection)
            && Equals(_resultExpression, other._resultExpression)
            && Equals(_keyExpression, other._keyExpression)
            && Equals(_condition, other._condition)
            && _isMap == other._isMap;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(
            StringComparer.Ordinal.GetHashCode(_itemVar),
            _keyVar is null ? 0 : StringComparer.Ordinal.GetHashCode(_keyVar),
            _collection,
            _resultExpression,
            _keyExpression,
            _condition,
            _isMap);
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

    public override string ToHcl(ITerraformContext? context = null)
    {
        return $"{_condition.ToHcl(context)} ? {_trueValue.ToHcl(context)} : {_falseValue.ToHcl(context)}";
    }
}

/// <summary>
/// Splat expression for accessing attributes across all elements in a list.
/// Supports both full splat ([*]) and attribute splat ([*].attribute) operations.
/// Examples: aws_instance.example[*].id, var.list[*]
/// </summary>
internal class SplatExpression : TerraformExpression
{
    private readonly TerraformExpression _source;
    private readonly string? _attribute;

    /// <summary>
    /// Creates a splat expression that returns all elements.
    /// Example: var.list[*]
    /// </summary>
    public SplatExpression(TerraformExpression source)
    {
        _source = source ?? throw new ArgumentNullException(nameof(source));
        _attribute = null;
    }

    /// <summary>
    /// Creates a splat expression that accesses an attribute on all elements.
    /// Example: aws_instance.example[*].id
    /// </summary>
    public SplatExpression(TerraformExpression source, string attribute)
    {
        _source = source ?? throw new ArgumentNullException(nameof(source));
        _attribute = attribute ?? throw new ArgumentNullException(nameof(attribute));
    }

    public override string ToHcl(ITerraformContext? context = null)
    {
        var baseExpr = $"{_source.ToHcl(context)}[*]";
        return _attribute != null ? $"{baseExpr}.{_attribute}" : baseExpr;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        return obj is SplatExpression other
            && Equals(_source, other._source)
            && string.Equals(_attribute, other._attribute, StringComparison.Ordinal);
    }

    public override int GetHashCode()
        => HashCode.Combine(_source, _attribute is null ? 0 : StringComparer.Ordinal.GetHashCode(_attribute));
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

    /// <summary>
    /// Creates a splat expression that returns all elements.
    /// Example: Identifier("var.list").Splat() produces "var.list[*]"
    /// </summary>
    public static TerraformExpression Splat(this TerraformExpression source)
        => new SplatExpression(source);

    /// <summary>
    /// Creates a splat expression that accesses an attribute on all elements.
    /// Example: Identifier("aws_instance.example").Splat("id") produces "aws_instance.example[*].id"
    /// </summary>
    public static TerraformExpression Splat(this TerraformExpression source, string attribute)
        => new SplatExpression(source, attribute);
}
