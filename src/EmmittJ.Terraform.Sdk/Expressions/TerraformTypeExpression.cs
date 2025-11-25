namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform type constraint expression.
/// Type constraints are used in variable blocks to specify the expected type of values.
/// </summary>
/// <remarks>
/// Terraform supports several type constraints:
/// - Primitive types: string, number, bool
/// - Collection types: list(type), set(type), map(type)
/// - Structural types: object({...}), tuple([...])
/// - Special keyword: any
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/expressions/types"/></para>
/// </remarks>
public sealed class TerraformTypeExpression : TerraformExpression
{
    private readonly string _typeExpression;

    private TerraformTypeExpression(string typeExpression)
    {
        _typeExpression = typeExpression ?? throw new ArgumentNullException(nameof(typeExpression));
    }

    /// <inheritdoc/>
    public override string ToHcl(ITerraformContext context) => _typeExpression;

    /// <inheritdoc/>
    public override bool Equals(object? obj)
        => obj is TerraformTypeExpression other && _typeExpression == other._typeExpression;

    /// <inheritdoc/>
    public override int GetHashCode() => _typeExpression.GetHashCode();

    /// <inheritdoc/>
    public override string ToString() => $"TerraformTypeExpression: {_typeExpression}";

    #region Primitive Types

    /// <summary>
    /// The string type constraint.
    /// </summary>
    public static TerraformTypeExpression String { get; } = new("string");

    /// <summary>
    /// The number type constraint.
    /// </summary>
    public static TerraformTypeExpression Number { get; } = new("number");

    /// <summary>
    /// The bool type constraint.
    /// </summary>
    public static TerraformTypeExpression Bool { get; } = new("bool");

    /// <summary>
    /// The any type constraint. Accepts any type.
    /// </summary>
    public static TerraformTypeExpression Any { get; } = new("any");

    #endregion

    #region Collection Types

    /// <summary>
    /// Creates a list type constraint.
    /// </summary>
    /// <param name="elementType">The type of elements in the list.</param>
    /// <returns>A list type constraint.</returns>
    public static TerraformTypeExpression List(TerraformTypeExpression elementType)
        => new($"list({elementType._typeExpression})");

    /// <summary>
    /// Creates a set type constraint.
    /// </summary>
    /// <param name="elementType">The type of elements in the set.</param>
    /// <returns>A set type constraint.</returns>
    public static TerraformTypeExpression Set(TerraformTypeExpression elementType)
        => new($"set({elementType._typeExpression})");

    /// <summary>
    /// Creates a map type constraint.
    /// </summary>
    /// <param name="valueType">The type of values in the map.</param>
    /// <returns>A map type constraint.</returns>
    public static TerraformTypeExpression Map(TerraformTypeExpression valueType)
        => new($"map({valueType._typeExpression})");

    #endregion

    #region Structural Types

    /// <summary>
    /// Creates an object type constraint.
    /// </summary>
    /// <param name="attributes">The attributes of the object as (name, type) pairs.</param>
    /// <returns>An object type constraint.</returns>
    /// <example>
    /// <code>
    /// var personType = TerraformTypeExpression.Object(
    ///     ("name", TerraformTypeExpression.String),
    ///     ("age", TerraformTypeExpression.Number)
    /// );
    /// // Renders as: object({ name = string, age = number })
    /// </code>
    /// </example>
    public static TerraformTypeExpression Object(params (string Name, TerraformTypeExpression Type)[] attributes)
    {
        if (attributes.Length == 0)
        {
            return new("object({})");
        }

        var props = string.Join(", ", attributes.Select(a => $"{a.Name} = {a.Type._typeExpression}"));
        return new($"object({{ {props} }})");
    }

    /// <summary>
    /// Creates a tuple type constraint.
    /// </summary>
    /// <param name="elementTypes">The types of elements in the tuple, in order.</param>
    /// <returns>A tuple type constraint.</returns>
    /// <example>
    /// <code>
    /// var coordType = TerraformTypeExpression.Tuple(
    ///     TerraformTypeExpression.Number,
    ///     TerraformTypeExpression.Number
    /// );
    /// // Renders as: tuple([number, number])
    /// </code>
    /// </example>
    public static TerraformTypeExpression Tuple(params TerraformTypeExpression[] elementTypes)
    {
        var types = string.Join(", ", elementTypes.Select(t => t._typeExpression));
        return new($"tuple([{types}])");
    }

    #endregion

    #region Optional Modifier

    /// <summary>
    /// Wraps this type in an optional modifier for use in object attributes.
    /// </summary>
    /// <returns>An optional type constraint.</returns>
    /// <example>
    /// <code>
    /// var configType = TerraformTypeExpression.Object(
    ///     ("required_field", TerraformTypeExpression.String),
    ///     ("optional_field", TerraformTypeExpression.String.Optional())
    /// );
    /// // Renders as: object({ required_field = string, optional_field = optional(string) })
    /// </code>
    /// </example>
    public TerraformTypeExpression Optional()
        => new($"optional({_typeExpression})");

    /// <summary>
    /// Wraps this type in an optional modifier with a default value.
    /// </summary>
    /// <param name="defaultValue">The default value expression.</param>
    /// <returns>An optional type constraint with default.</returns>
    public TerraformTypeExpression Optional(TerraformExpression defaultValue)
    {
        // For default values, we need to render them - use a simple context
        var ctx = new TerraformContext(new TerraformStack());
        var defaultHcl = defaultValue.ToHcl(ctx);
        return new($"optional({_typeExpression}, {defaultHcl})");
    }

    #endregion

    #region Implicit Conversions

    /// <summary>
    /// Allows using a string directly as a type expression for convenience.
    /// </summary>
    /// <param name="typeString">The type string (e.g., "string", "list(number)").</param>
    public static implicit operator TerraformTypeExpression(string typeString)
        => new(typeString);

    #endregion
}
