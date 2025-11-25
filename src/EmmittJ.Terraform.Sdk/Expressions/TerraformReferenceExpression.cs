namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a semantic reference to another Terraform block.
/// This tracks relationships between blocks for dependency analysis and validation.
/// Extends TerraformExpression so it can be stored directly while maintaining metadata.
/// Resolves to HCL identifier string during ToHcl.
/// </summary>
/// <remarks>
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/expressions/references"/></para>
/// </remarks>
public class TerraformReferenceExpression(ITerraformReferenceable source, string? propertyPath = null)
    : TerraformExpression
{
    /// <summary>
    /// Gets the block being referenced.
    /// </summary>
    public ITerraformReferenceable Source { get; } = source ?? throw new ArgumentNullException(nameof(source));

    /// <summary>
    /// Gets the optional property path (e.g., "endpoints.primary").
    /// </summary>
    public string? PropertyPath { get; } = propertyPath;

    /// <summary>
    /// Resolves this reference to a concrete TerraformExpression.
    /// Builds the reference expression by appending property path segments if present.
    /// </summary>
    private TerraformExpression ResolveSource()
    {
        // Ask the source block how to reference itself
        var expr = Source.AsReference();

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
    /// Generates HCL for this reference by resolving it to an expression.
    /// </summary>
    public override string ToHcl(ITerraformContext context)
    {
        return ResolveSource().ToHcl(context);
    }
}
