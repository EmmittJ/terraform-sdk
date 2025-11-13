namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a comment in HCL
/// </summary>
/// <example>
/// # This is a comment
/// </example>
public sealed class TerraformCommentNode : TerraformSyntaxNode
{
    /// <summary>
    /// The comment text (without the # prefix)
    /// </summary>
    public string Text { get; }

    /// <summary>
    /// Creates a new comment node.
    /// </summary>
    /// <param name="text">The comment text (without the # prefix)</param>
    public TerraformCommentNode(string text)
    {
        Text = text ?? throw new ArgumentNullException(nameof(text));
    }

    /// <summary>
    /// Renders this comment node to HCL format.
    /// </summary>
    public override string ToHcl(ITerraformContext context)
    {
        return $"# {Text}";
    }
}
