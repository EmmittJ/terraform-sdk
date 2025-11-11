namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Base interface for anything that can be resolved to a TerraformExpression during synthesis.
/// All resolvables produce expressions that can be serialized to HCL.
/// </summary>
public interface ITerraformResolvable
{
    /// <summary>
    /// Resolve this object to a TerraformExpression.
    /// Called during the ToHcl phase.
    /// </summary>
    /// <param name="context">The context provided during resolution.</param>
    /// <returns>A TerraformExpression representing this resolvable value.</returns>
    TerraformExpression Resolve(ITerraformResolveContext context);
}
