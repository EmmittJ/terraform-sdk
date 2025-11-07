namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Base class for all Terraform expressions (AST nodes).
/// Expressions are syntax trees that can be rendered to HCL strings.
/// They support optional context for indentation in multi-line structures.
/// Implements ITerraformResolvable to support two-phase resolution (Prepare → Resolve).
/// </summary>
public abstract class TerraformExpression : ITerraformResolvable<string>
{
    /// <summary>
    /// The assignment operator used when rendering properties.
    /// Default is " = " for object expressions.
    /// Override to " " (space) for block expressions (no equals sign).
    /// </summary>
    public virtual string AssignmentOperator => " = ";

    /// <summary>
    /// Preparation phase - prepares nested expressions and records dependencies.
    /// Override this in derived classes that contain nested resolvable expressions.
    /// </summary>
    public virtual void Prepare(ITerraformContext context)
    {
        // Base implementation does nothing - leaf expressions don't need preparation
    }

    /// <summary>
    /// Resolution phase - converts expression to HCL string.
    /// By default, this calls ToHcl() for backward compatibility.
    /// Derived classes should implement ToHcl() - Resolve() delegates to it.
    /// </summary>
    public abstract string Resolve(ITerraformContext? context = null);

    /// <summary>
    /// Converts expression to HCL string with optional context for indentation.
    /// Context provides indentation level for multi-line structures like objects and lists.
    /// When context is null, renders without indentation tracking.
    /// Derived classes must implement this method to provide HCL rendering.
    /// </summary>
    public virtual string ToHcl(ITerraformContext? context = null)
        => Resolve(context);

    public override string ToString()
        => throw new NotImplementedException("Use ToHcl() to render the expression to HCL string.");

    /// <summary>
    /// Creates a literal expression from a value.
    /// </summary>
    public static TerraformExpression Literal<T>(T value) => new LiteralExpression<T>(value);

    /// <summary>
    /// Creates an identifier expression with deferred resolution based on a value's state.
    /// The resolver function is called during the Resolve phase, not at construction time.
    /// Example: Identifier(provider, p => p.Alias?.LiteralValue != null ? $"aws.{p.Alias.LiteralValue}" : "aws")
    /// </summary>
    public static TerraformExpression Identifier<T>(T value, Func<T, string>? resolver = null)
        => new IdentifierExpression<T>(value, resolver);

    /// <summary>
    /// Creates a raw HCL expression (use sparingly - prefer typed expressions).
    /// </summary>
    public static TerraformExpression Raw(string hcl) => new RawExpression(hcl);

    /// <summary>
    /// Creates a list literal expression.
    /// </summary>
    public static TerraformExpression List(params TerraformExpression[] elements) => new ListExpression(elements);

    /// <summary>
    /// Creates a list literal expression.
    /// </summary>
    public static TerraformExpression List(IEnumerable<TerraformExpression> elements) => new ListExpression(elements);

    /// <summary>
    /// Creates an object/map literal expression.
    /// Returns TerraformExpression to avoid overload resolution issues.
    /// </summary>
    public static TerraformExpression Object() => new TerraformObjectExpression();

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
