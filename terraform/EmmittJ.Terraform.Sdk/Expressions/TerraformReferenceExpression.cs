namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a semantic reference to another Terraform construct.
/// This tracks relationships between constructs for dependency analysis and validation.
/// Extends TerraformExpression so it can be stored directly while maintaining metadata.
/// Records dependencies during Prepare and resolves to HCL string during ToHcl.
/// </summary>
public class TerraformReferenceExpression(TerraformConstruct source, string? propertyPath = null)
    : TerraformExpression
{
    /// <summary>
    /// Gets the construct being referenced.
    /// </summary>
    public TerraformConstruct Source { get; } = source ?? throw new ArgumentNullException(nameof(source));

    /// <summary>
    /// Gets the optional property path (e.g., "endpoints.primary").
    /// </summary>
    public string? PropertyPath { get; } = propertyPath;

    /// <summary>
    /// Preparation phase - records the dependency.
    /// </summary>
    public override void Prepare(ITerraformContext context)
    {
        if (context is TerraformContext terraformContext)
        {
            terraformContext.RecordDependency(Source);
        }
    }

    /// <summary>
    /// Resolves this reference to a concrete TerraformExpression.
    /// Builds the reference expression by appending property path segments if present.
    /// </summary>
    private TerraformExpression ResolveSource()
    {
        // Ask the source construct how to reference itself
        TerraformExpression expr = Source.AsReference();

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
    public override string Resolve(ITerraformContext? context = null)
    {
        return ResolveSource().Resolve(context);
    }
}
