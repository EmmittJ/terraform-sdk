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
    public override string ToString()
    {
        if (_properties.Count == 0)
        {
            return "{}";
        }

        var sb = new System.Text.StringBuilder();
        sb.AppendLine("{");

        foreach (var (key, value) in _properties)
        {
            sb.AppendLine($"  {key} = {value}");
        }

        sb.AppendLine("}");

        return sb.ToString();
    }
}
