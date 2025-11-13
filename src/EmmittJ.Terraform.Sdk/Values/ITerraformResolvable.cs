namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Interface for types that can be resolved to Terraform syntax nodes.
/// </summary>
/// <remarks>
/// Resolution is the second phase of two-phase compilation:
/// 1. Prepare: Collect dependencies, validate structure
/// 2. Resolve: Generate syntax nodes that will be rendered to HCL
///
/// Blocks return multiple nodes (properties + nested blocks).
/// Values/expressions return single nodes.
/// </remarks>
public interface ITerraformResolvable
{
    /// <summary>
    /// Resolves this object to one or more Terraform syntax nodes.
    /// </summary>
    /// <param name="context">The resolution context for dependency tracking and indentation.</param>
    /// <returns>Enumerable of syntax nodes representing this object's HCL structure.</returns>
    IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context);
}
