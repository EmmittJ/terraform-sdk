namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Interface for Terraform properties that resolve to expressions.
/// Used by the property system to convert property values into Terraform expression trees.
/// This is distinct from HCL serialization - properties resolve to expressions,
/// expressions then serialize to HCL strings.
/// </summary>
public interface ITerraformProperty : ITerraformPreparable
{
    /// <summary>
    /// Resolves this property to a Terraform expression.
    /// The expression can then be serialized to HCL via its ToHcl() method.
    /// </summary>
    /// <param name="context">Optional context for resolution.</param>
    /// <returns>A Terraform expression representing this property's value.</returns>
    TerraformExpression Resolve(ITerraformContext? context = null);
}
