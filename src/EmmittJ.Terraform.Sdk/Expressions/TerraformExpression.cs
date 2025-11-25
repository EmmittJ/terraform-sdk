namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Base class for all Terraform expressions (values, not structural elements).
/// Expressions represent values that can appear on the right-hand side of assignments.
/// They are a specialized type of syntax node.
/// </summary>
/// <remarks>
/// Examples: literals, references, function calls, operators, conditionals
/// Not examples: resource blocks, property assignments, nested blocks (those are BlockNode/ArgumentNode)
/// </remarks>
public abstract class TerraformExpression : TerraformSyntaxNode, ITerraformResolvable
{
    /// <summary>
    /// Expressions resolve to themselves (single node).
    /// Implements ITerraformResolvable - expressions are already resolved.
    /// </summary>
    /// <param name="context">The resolution context (unused for expressions).</param>
    /// <returns>Enumerable containing this expression as a single node.</returns>
    public virtual IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        yield return this;
    }

    /// <summary>
    /// Converts expression to HCL string with context for indentation.
    /// Context provides indentation level for multi-line structures like objects and lists.
    /// Derived classes must implement this method to provide HCL rendering.
    /// Overrides the abstract method from TerraformSyntaxNode.
    /// </summary>
    public abstract override string ToHcl(ITerraformContext context);

    /// <inheritdoc/>
    public override string ToString()
        => throw new NotSupportedException($"{GetType().Name}: Use ToHcl(context) to render this expression to HCL. Expression type requires a context for proper indentation and formatting.");

    /// <summary>
    /// Creates a literal expression from a value.
    /// </summary>
    public static TerraformExpression Literal<T>(T value) => new LiteralExpression<T>(value);

    /// <summary>
    /// Creates an identifier expression with deferred resolution based on a value's state.
    /// The resolver function is called during the Resolve phase, not at blockion time.
    /// Example: Identifier(provider, p => p.Alias?.LiteralValue != null ? $"aws.{p.Alias.LiteralValue}" : "aws")
    /// </summary>
    public static TerraformExpression Identifier<T>(T value, Func<T, string>? resolver = null)
        => new TerraformIdentifierExpression<T>(value, resolver);

    /// <summary>
    /// Creates a raw HCL expression (use sparingly - prefer typed expressions).
    /// </summary>
    public static TerraformExpression Raw(string hcl) => new RawExpression(hcl);

    /// <summary>
    /// Creates a list literal expression.
    /// </summary>
    public static TerraformExpression List(params TerraformSyntaxNode[] elements) => new ListExpression(elements);

    /// <summary>
    /// Creates a list literal expression.
    /// </summary>
    public static TerraformExpression List(IEnumerable<TerraformSyntaxNode> elements) => new ListExpression(elements);

    /// <summary>
    /// Creates a set literal expression.
    /// Terraform sets are unordered collections of unique values.
    /// </summary>
    public static TerraformExpression Set(params TerraformSyntaxNode[] elements) => new ListExpression(elements);

    /// <summary>
    /// Creates a set literal expression.
    /// Terraform sets are unordered collections of unique values.
    /// Note: In HCL, sets use the same syntax as lists. The type system distinguishes them.
    /// </summary>
    public static TerraformExpression Set(IEnumerable<TerraformSyntaxNode> elements) => new ListExpression(elements);

    /// <summary>
    /// Creates a map literal expression from key-value pairs.
    /// Example: Map(new[] { KeyValuePair.Create("key1", expr1), KeyValuePair.Create("key2", expr2) })
    /// </summary>
    public static TerraformExpression Map(IEnumerable<KeyValuePair<string, TerraformSyntaxNode>>? pairs = null)
    {
        var map = new TerraformMapExpression();
        if (pairs != null)
        {
            foreach (var (key, value) in pairs)
            {
                map[key] = value;
            }
        }
        return map;
    }

    /// <summary>
    /// Creates a map literal expression.
    /// Returns TerraformExpression to avoid overload resolution issues.
    /// </summary>
    public static TerraformExpression Object() => new TerraformMapExpression();

    /// <summary>
    /// Creates a string interpolation expression.
    /// Example: Interpolate("prefix-", variable, "-suffix")
    /// </summary>
    public static TerraformExpression Interpolate(params object[] parts) => new StringInterpolationExpression(parts);

    /// <summary>
    /// Creates a for expression that produces a list.
    /// Example: ForList("x", collection, x => x.Member("id"))
    /// </summary>
    public static TerraformExpression ForList(string itemVar, TerraformExpression collection, TerraformExpression resultExpression, TerraformExpression? condition = null)
        => new ForExpression(itemVar, collection, resultExpression, condition);

    /// <summary>
    /// Creates a for expression that produces a list using a callback to build the result expression.
    /// Example: ForList(collection, item => item["id"])
    /// </summary>
    public static TerraformExpression ForList(TerraformExpression collection, Func<TerraformExpression, TerraformExpression> resultBuilder, TerraformExpression? condition = null)
    {
        var itemVar = "item";
        var itemIdentifier = Identifier(itemVar);
        return new ForExpression(itemVar, collection, resultBuilder(itemIdentifier), condition);
    }

    /// <summary>
    /// Creates a for expression that produces a list using a callback to build the result expression.
    /// Example: ForList("i", collection, i => i["id"])
    /// </summary>
    public static TerraformExpression ForList(string itemVar, TerraformExpression collection, Func<TerraformExpression, TerraformExpression> resultBuilder, TerraformExpression? condition = null)
    {
        var itemIdentifier = Identifier(itemVar);
        return new ForExpression(itemVar, collection, resultBuilder(itemIdentifier), condition);
    }

    /// <summary>
    /// Creates a for expression that produces a map.
    /// Example: ForMap("k", "v", collection, k => ..., v => ...)
    /// </summary>
    public static TerraformExpression ForMap(string keyVar, string valueVar, TerraformExpression collection, TerraformExpression keyExpression, TerraformExpression valueExpression, TerraformExpression? condition = null)
        => new ForExpression(keyVar, valueVar, collection, keyExpression, valueExpression, condition);

    /// <summary>
    /// Creates a for expression that produces a map using a callback to build the key and value expressions.
    /// Example: ForMap("k", "v", collection, (key, value) => (key, value["id"]))
    /// </summary>
    public static TerraformExpression ForMap(string keyVar, string valueVar, TerraformExpression collection, Func<TerraformExpression, TerraformExpression, (TerraformExpression key, TerraformExpression value)> mapBuilder, TerraformExpression? condition = null)
    {
        var keyIdentifier = Identifier(keyVar);
        var valueIdentifier = Identifier(valueVar);
        var (keyExpr, valueExpr) = mapBuilder(keyIdentifier, valueIdentifier);
        return new ForExpression(keyVar, valueVar, collection, keyExpr, valueExpr, condition);
    }

    /// <summary>
    /// Creates a for expression that produces a map using a callback to build the key and value expressions.
    /// Example: ForMap(collection, (key, value) => (key, value["id"]))
    /// </summary>
    public static TerraformExpression ForMap(TerraformExpression collection, Func<TerraformExpression, TerraformExpression, (TerraformExpression key, TerraformExpression value)> mapBuilder, TerraformExpression? condition = null)
    {
        var keyVar = "key";
        var valueVar = "value";
        var keyIdentifier = Identifier(keyVar);
        var valueIdentifier = Identifier(valueVar);
        var (keyExpr, valueExpr) = mapBuilder(keyIdentifier, valueIdentifier);
        return new ForExpression(keyVar, valueVar, collection, keyExpr, valueExpr, condition);
    }

    /// <summary>
    /// Creates a conditional expression (ternary operator).
    /// </summary>
    public static TerraformExpression Conditional(TerraformExpression condition, TerraformExpression trueValue, TerraformExpression falseValue)
        => new ConditionalExpression(condition, trueValue, falseValue);

    /// <summary>
    /// Creates a splat expression that returns all elements.
    /// Example: Splat(Identifier("var.list")) produces "var.list[*]"
    /// </summary>
    public static TerraformExpression Splat(TerraformExpression source)
        => new SplatExpression(source);

    /// <summary>
    /// Creates a splat expression that accesses an attribute on all elements.
    /// Example: Splat(Identifier("aws_instance.example"), "id") produces "aws_instance.example[*].id"
    /// </summary>
    public static TerraformExpression Splat(TerraformExpression source, string attribute)
        => new SplatExpression(source, attribute);

    /// <summary>
    /// Creates an index access expression for lists and maps.
    /// Example: Index(Identifier("list"), Literal(0)) produces "list[0]"
    /// Example: Index(Identifier("map"), Literal("key")) produces "map['key']"
    /// </summary>
    public static TerraformExpression Index(TerraformExpression source, TerraformExpression index)
        => new IndexExpression(source, index);

    // Implicit conversions from common types
    public static implicit operator TerraformExpression(string value) => Literal(value);
    public static implicit operator TerraformExpression(int value) => Literal(value);
    public static implicit operator TerraformExpression(long value) => Literal(value);
    public static implicit operator TerraformExpression(bool value) => Literal(value);
    public static implicit operator TerraformExpression(double value) => Literal(value);
    public static implicit operator TerraformExpression(float value) => Literal(value);

    /// <summary>
    /// Converts an object to a TerraformExpression based on its runtime type.
    /// Useful for handling Dictionary&lt;string, object&gt; and similar scenarios.
    /// Note: Cannot be an implicit operator as C# doesn't allow conversions from object (base type).
    /// </summary>
    public static TerraformExpression FromObject(object value)
    {
        return value switch
        {
            TerraformExpression expr => expr,
            string s => Literal(s),
            int i => Literal(i),
            long l => Literal(l),
            bool b => Literal(b),
            double d => Literal(d),
            float f => Literal(f),
            _ => Literal(value.ToString() ?? "")
        };
    }

    // Implicit conversion from arrays and lists to list expressions
    public static implicit operator TerraformExpression(TerraformExpression[] values) => List(values);
    public static implicit operator TerraformExpression(string[] values) => List(values.Select(v => Literal(v)));
    public static implicit operator TerraformExpression(int[] values) => List(values.Select(v => Literal(v)));
    public static implicit operator TerraformExpression(bool[] values) => List(values.Select(v => Literal(v)));
    public static implicit operator TerraformExpression(List<string> values) => List(values.Select(v => Literal(v)));
    public static implicit operator TerraformExpression(List<int> values) => List(values.Select(v => Literal(v)));
    public static implicit operator TerraformExpression(List<bool> values) => List(values.Select(v => Literal(v)));
    public static implicit operator TerraformExpression(List<TerraformExpression> values) => List([.. values]);

    // Arithmetic operators
    public static TerraformExpression operator +(TerraformExpression left, TerraformExpression right)
        => new BinaryExpression(left, BinaryOperator.Add, right);

    public static TerraformExpression operator -(TerraformExpression left, TerraformExpression right)
        => new BinaryExpression(left, BinaryOperator.Subtract, right);

    public static TerraformExpression operator *(TerraformExpression left, TerraformExpression right)
        => new BinaryExpression(left, BinaryOperator.Multiply, right);

    public static TerraformExpression operator /(TerraformExpression left, TerraformExpression right)
        => new BinaryExpression(left, BinaryOperator.Divide, right);

    public virtual TerraformExpression this[string key]
    {
        get => new MemberAccessExpression(this, key);
        set => throw new NotSupportedException("Indexer set is not supported on TerraformExpression.");
    }
}

/// <summary>
/// Binary operators for Terraform expressions.
/// </summary>
public enum BinaryOperator
{
    Add,
    Subtract,
    Multiply,
    Divide,
    Modulo,
    Equal,
    NotEqual,
    LessThan,
    LessThanOrEqual,
    GreaterThan,
    GreaterThanOrEqual,
    And,
    Or
}
