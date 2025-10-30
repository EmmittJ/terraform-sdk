namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Extension methods for TerraformConstruct to enable fluent API with proper return types.
/// These methods work for all construct types: locals, providers, resources, and data sources.
/// </summary>
public static class TerraformConstructExtensions
{
    /// <summary>
    /// Sets a property value from a TerraformValue.
    /// </summary>
    public static TConstruct Set<TConstruct, TValue>(this TConstruct construct, string propertyName, TerraformValue<TValue> value)
        where TConstruct : TerraformConstruct
    {
        construct.SetInternal(propertyName, value);
        return construct;
    }

    /// <summary>
    /// Sets a property value from an expression.
    /// Handles all implicit conversions: string, int, bool, arrays, TerraformObject, TerraformReference, etc.
    /// </summary>
    public static TConstruct Set<TConstruct>(this TConstruct construct, string propertyName, TerraformExpression expression)
        where TConstruct : TerraformConstruct
    {
        construct.SetInternal(propertyName, new TerraformValue<object>(expression));
        return construct;
    }

    /// <summary>
    /// Gets a property value.
    /// </summary>
    public static TerraformValue<TValue> Get<TValue>(this TerraformConstruct construct, string propertyName)
    {
        return construct.GetInternal<TValue>(propertyName);
    }

    /// <summary>
    /// Creates a reference to this construct that can be used in expressions.
    /// Works for all construct types: variables, resources, data sources, locals, etc.
    /// </summary>
    /// <param name="construct">The construct to create a reference for.</param>
    /// <returns>A TerraformReference that can be implicitly converted to TerraformExpression.</returns>
    public static TerraformReferenceExpression AsReference(this ITerraformConstruct construct)
    {
        return new TerraformReferenceExpression(construct);
    }
}
