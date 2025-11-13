namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Base class for all Terraform syntax nodes.
/// Represents a single element in the HCL output (property, block, meta-argument, etc.).
/// </summary>
/// <remarks>
/// Syntax nodes are the output of the Resolve phase and input to the HCL generation phase.
/// Each node type knows how to render itself to HCL string format.
/// </remarks>
public abstract class TerraformSyntaxNode
{
    /// <summary>
    /// Renders this syntax node to HCL string format.
    /// </summary>
    /// <param name="context">Context providing indentation and other rendering settings.</param>
    /// <returns>HCL string representation of this node.</returns>
    public abstract string ToHcl(ITerraformContext context);
}
