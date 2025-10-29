namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform nested block body (container structure).
/// Blocks don't use '=' assignment syntax, unlike object expressions.
/// Example: default_tags { tags = {...} } not default_tags = { tags = {...} }
/// Inherits from TerraformObject but overrides ToHcl() to generate block syntax.
/// </summary>
public class TerraformBlock : TerraformObject
{
    /// <summary>
    /// Converts the block to HCL syntax.
    /// Generates block body syntax with arguments inside.
    /// </summary>
    public override string ToHcl() => ToHcl(0);

    /// <summary>
    /// Converts the block to HCL syntax with indentation.
    /// The indent parameter represents the current nesting level.
    /// </summary>
    public string ToHcl(int indent)
    {
        if (_properties.Count == 0)
            return "{}";

        var baseIndent = new string(' ', indent * 2);
        var innerIndent = new string(' ', (indent + 1) * 2);
        var props = _properties.Select(kvp => $"{innerIndent}{kvp.Key} = {kvp.Value.ToHcl()}").ToList();

        return $"{{\n{string.Join("\n", props)}\n{baseIndent}}}";
    }
}
