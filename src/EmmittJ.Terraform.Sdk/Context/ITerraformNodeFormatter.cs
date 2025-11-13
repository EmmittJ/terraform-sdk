namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Interface for formatting Terraform syntax nodes according to HCL conventions.
/// Handles both sorting and insertion of blank lines for readability.
/// </summary>
public interface ITerraformNodeFormatter
{
    /// <summary>
    /// Formats syntax nodes by sorting and inserting blank lines per HCL conventions.
    /// </summary>
    /// <param name="nodes">The nodes to format</param>
    /// <returns>Formatted nodes with proper ordering and blank lines</returns>
    IEnumerable<TerraformSyntaxNode> Format(IEnumerable<TerraformSyntaxNode> nodes);
}
