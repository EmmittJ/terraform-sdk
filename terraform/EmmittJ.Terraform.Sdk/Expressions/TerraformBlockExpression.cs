namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform nested block body (container structure).
/// Blocks don't use '=' assignment syntax, unlike object expressions.
/// Example: default_tags { tags = {...} } not default_tags = { tags = {...} }
/// Inherits from TerraformObject but overrides ToHcl() to generate block syntax.
/// </summary>
public class TerraformBlockExpression : TerraformObjectExpression
{
}
