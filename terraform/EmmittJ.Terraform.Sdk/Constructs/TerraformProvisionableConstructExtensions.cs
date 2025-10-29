namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Extension methods for TerraformProvisionableConstruct (resources and data sources).
/// Provides output attribute management for constructs that support it.
/// </summary>
public static class TerraformProvisionableConstructExtensions
{
    /// <summary>
    /// Declares an output attribute for this construct.
    /// </summary>
    public static TConstruct DeclareOutput<TConstruct>(this TConstruct construct, string attributeName)
        where TConstruct : TerraformProvisionableConstruct
    {
        construct.DeclareOutputInternal(attributeName);
        return construct;
    }
}
