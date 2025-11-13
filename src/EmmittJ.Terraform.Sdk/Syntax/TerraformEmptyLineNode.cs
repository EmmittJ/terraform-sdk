namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents an empty line for formatting/readability
/// </summary>
public sealed class TerraformEmptyLineNode : TerraformSyntaxNode
{
    /// <summary>
    /// Singleton instance of the empty line node.
    /// </summary>
    public static readonly TerraformEmptyLineNode Instance = new();

    private TerraformEmptyLineNode()
    {
    }

    /// <summary>
    /// Renders this empty line node (returns empty string).
    /// </summary>
    public override string ToHcl(ITerraformContext context)
    {
        return string.Empty;
    }
}
