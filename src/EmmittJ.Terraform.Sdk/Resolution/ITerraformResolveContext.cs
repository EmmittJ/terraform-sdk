namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Context provided during Terraform value resolution.
/// </summary>
public interface ITerraformResolveContext
{
    /// <summary>
    /// The current scope being resolved.
    /// </summary>
    object Scope { get; }
}
