namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Wraps a literal value and resolves it to a LiteralExpression.
/// Used internally by TerraformValue when a literal is assigned.
/// </summary>
/// <typeparam name="T">The type of the literal value (string, double, bool, etc.)</typeparam>
/// <remarks>
/// Creates a new TerraformLiteralValue with the specified value.
/// </remarks>
/// <param name="value">The literal value to wrap.</param>
internal class TerraformLiteralValue<T>(T? value) : TerraformValue<T>
{

    /// <summary>
    /// Resolves this literal value to a LiteralExpression.
    /// </summary>
    /// <param name="context">The resolution context (unused for literals).</param>
    /// <returns>A LiteralExpression containing the literal value.</returns>
    public override IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        yield return TerraformExpression.Literal(value);
    }
}
