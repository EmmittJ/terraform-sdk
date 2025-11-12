namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Wraps a literal value and resolves it to a LiteralExpression.
/// Used internally by TerraformValue when a literal is assigned.
/// </summary>
/// <typeparam name="T">The type of the literal value (string, double, bool, etc.)</typeparam>
internal class TerraformLiteralValue<T> : ITerraformResolvable
{
    private readonly T? _value;

    /// <summary>
    /// Creates a new TerraformLiteralValue with the specified value.
    /// </summary>
    /// <param name="value">The literal value to wrap.</param>
    public TerraformLiteralValue(T? value)
    {
        _value = value;
    }

    /// <summary>
    /// Resolves this literal value to a LiteralExpression.
    /// </summary>
    /// <param name="context">The resolution context (unused for literals).</param>
    /// <returns>A LiteralExpression containing the literal value.</returns>
    public TerraformExpression Resolve(ITerraformContext context)
    {
        return TerraformExpression.Literal(_value);
    }
}
