namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents an argument assignment in HCL: key = value
/// </summary>
/// <example>
/// ami           = "ami-123456"
/// instance_type = "t2.micro"
/// count         = 5
/// </example>
public sealed class TerraformArgumentNode(string key, TerraformSyntaxNode value, int? alignmentColumn = null) : TerraformSyntaxNode
{
    /// <summary>
    /// The argument key (left side of =)
    /// </summary>
    public string Key { get; } = key;

    /// <summary>
    /// The argument value expression (right side of =)
    /// </summary>
    public TerraformSyntaxNode Value { get; } = value;

    /// <summary>
    /// Optional alignment column for equals sign alignment per Terraform style guide.
    /// When set, the key is padded to align the equals sign with other arguments.
    /// </summary>
    public int? AlignmentColumn { get; } = alignmentColumn;

    /// <summary>
    /// Renders this argument node to HCL format: key = value
    /// Applies equals sign alignment if AlignmentColumn is set.
    /// </summary>
    public override string ToHcl(ITerraformContext context)
    {
        // Format with alignment: key.PadRight(column) = value
        // Format without alignment: key = value
        return AlignmentColumn.HasValue
            ? $"{Key.PadRight(AlignmentColumn.Value)}= {Value.ToHcl(context)}"
            : $"{Key} = {Value.ToHcl(context)}";
    }
}
