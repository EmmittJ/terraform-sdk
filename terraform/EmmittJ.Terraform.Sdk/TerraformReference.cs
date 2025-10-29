namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a semantic reference to another Terraform construct.
/// This tracks relationships between constructs for dependency analysis and validation.
/// </summary>
public class TerraformReference(ITerraformConstruct source, string? propertyPath = null)
{
    /// <summary>
    /// Gets the construct being referenced.
    /// </summary>
    public ITerraformConstruct Source { get; } = source ?? throw new ArgumentNullException(nameof(source));

    /// <summary>
    /// Gets the optional property path (e.g., "endpoints.primary").
    /// </summary>
    public string? PropertyPath { get; } = propertyPath;

    /// <summary>
    /// Converts this reference to a TerraformExpression.
    /// Delegates to the source construct to build its own reference expression (polymorphism!).
    /// </summary>
    public TerraformExpression ToExpression()
    {
        // Ask the source construct how to reference itself
        TerraformExpression expr = Source.GetReferenceExpression();

        // If there's a property path, append it as member access
        if (!string.IsNullOrEmpty(PropertyPath))
        {
            foreach (var segment in PropertyPath.Split('.', StringSplitOptions.RemoveEmptyEntries))
            {
                expr = expr.Member(segment);
            }
        }

        return expr;
    }

    /// <summary>
    /// Implicit conversion from TerraformReference to TerraformExpression.
    /// </summary>
    public static implicit operator TerraformExpression(TerraformReference reference)
        => reference.ToExpression();
}
