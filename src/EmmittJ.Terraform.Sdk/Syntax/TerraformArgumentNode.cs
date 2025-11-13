namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents an argument assignment in HCL: key = value
/// </summary>
/// <example>
/// ami           = "ami-123456"
/// instance_type = "t2.micro"
/// count         = 5
/// </example>
public sealed class TerraformArgumentNode : TerraformSyntaxNode
{
    /// <summary>
    /// The argument key (left side of =)
    /// </summary>
    public string Key { get; }

    /// <summary>
    /// The argument value expression (right side of =)
    /// </summary>
    public TerraformExpression Value { get; }

    /// <summary>
    /// Creates a new argument node.
    /// </summary>
    /// <param name="key">The argument key (left side of =)</param>
    /// <param name="value">The argument value expression (right side of =)</param>
    public TerraformArgumentNode(string key, TerraformExpression value)
    {
        Key = key ?? throw new ArgumentNullException(nameof(key));
        Value = value ?? throw new ArgumentNullException(nameof(value));
    }

    /// <summary>
    /// Renders this argument node to HCL format: key = value
    /// </summary>
    public override string ToHcl(ITerraformContext context)
    {
        // Format: key = value
        return $"{Key} = {Value.ToHcl(context)}";
    }
}
