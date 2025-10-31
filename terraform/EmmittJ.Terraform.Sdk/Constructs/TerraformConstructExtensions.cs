namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Extension methods for TerraformConstruct to enable fluent API with proper return types.
/// These methods work for all construct types: locals, providers, resources, and data sources.
/// </summary>
public static class TerraformConstructExtensions
{
    /// <summary>
    /// Fluent builder method with type-safe return - returns T instead of TerraformConstruct.
    /// </summary>
    public static T WithProperty<T>(this T construct, string key, TerraformProperty value)
        where T : TerraformConstruct
    {
        construct
            .WithPropertyInternal(key, value);
        return construct;
    }

    /// <summary>
    /// Fluent builder method with type-safe return and priority support.
    /// Lower priority values render first in HCL output.
    /// </summary>
    public static T WithProperty<T>(this T construct, string key, TerraformProperty value, int priority)
        where T : TerraformConstruct
    {
        construct
            .WithPropertyInternal(key, value, priority);
        return construct;
    }

    /// <summary>
    /// Convenience method for referencing other constructs.
    /// Type-safe return eliminates casting.
    /// </summary>
    public static T WithReference<T>(this T construct, string propertyName, TerraformConstruct reference)
        where T : TerraformConstruct
    {
        construct
            .WithPropertyInternal(propertyName, reference.AsReference());
        return construct;
    }

    /// <summary>
    /// Convenience method for referencing other constructs with priority support.
    /// Lower priority values render first in HCL output.
    /// </summary>
    public static T WithReference<T>(this T construct, string propertyName, TerraformConstruct reference, int priority)
        where T : TerraformConstruct
    {
        construct
            .WithPropertyInternal(propertyName, reference.AsReference(), priority);
        return construct;
    }
}
