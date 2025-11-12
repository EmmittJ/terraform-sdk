namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Base class for Terraform nested block objects.
/// Provides property storage infrastructure for source-generated properties.
/// Inherits from TerraformMap&lt;object&gt; which provides map storage and resolution infrastructure.
/// All generated block classes should inherit from this.
/// </summary>
/// <remarks>
/// Note: While blocks inherit from TerraformMap&lt;object&gt;, they are primarily used for their
/// property storage and resolution capabilities. The map-like interface (indexer, Add methods)
/// is not typically used directly in block classes. This design allows maximum code reuse
/// of the existing TerraformMap infrastructure without duplicating property storage logic.
/// TerraformConstruct uses a different approach (direct Dictionary storage) which will be
/// unified in a future refactoring.
/// </remarks>
public abstract class TerraformBlock : TerraformMap<object>
{
    /// <summary>
    /// Gets the Terraform block label (e.g., "timeouts", "tags").
    /// This is set during construction and used during HCL serialization.
    /// For top-level constructs, this may be empty.
    /// </summary>
    public string BlockLabel { get; }

    /// <summary>
    /// Initializes a new instance of TerraformBlock.
    /// </summary>
    /// <param name="blockLabel">The Terraform block label (e.g., "timeouts"). Can be empty for top-level constructs.</param>
    protected TerraformBlock(string blockLabel = "") : base()
    {
        BlockLabel = blockLabel;
    }

    /// <summary>
    /// Called by source-generated property setters to store values.
    /// Uses the base TerraformMap&lt;object&gt; indexer to store values in the _elements dictionary.
    /// </summary>
    /// <param name="terraformName">The Terraform property name (from [TerraformProperty("name")] attribute).</param>
    /// <param name="value">The value to store (TerraformValue&lt;T&gt;, TerraformList&lt;T&gt;, nested blocks, etc.).</param>
    protected void SetPropertyValue(string terraformName, object? value)
    {
        // Use the indexer from base TerraformMap<object>
        // The indexer expects TerraformValue<object>, and there's an implicit conversion from object to TerraformValue<object>
        // So we can pass the value directly and it will be wrapped automatically
        if (value != null)
        {
            this[terraformName] = value;
        }
    }

    /// <summary>
    /// Called by source-generated property getters to retrieve stored values.
    /// Returns null if the property was never set.
    /// Uses the base TerraformMap&lt;object&gt; indexer to retrieve values from the _elements dictionary.
    /// </summary>
    /// <typeparam name="T">The property type.</typeparam>
    /// <param name="terraformName">The Terraform property name.</param>
    /// <returns>The stored value or null.</returns>
    protected T? GetPropertyValue<T>(string terraformName)
    {
        try
        {
            // Use the indexer from base TerraformMap<object>
            // The indexer returns a TerraformValue<object>
            var terraformValue = this[terraformName];

            // The TerraformValue<object> is just a wrapper around the actual value
            // We need to unwrap it to get the original value back
            // Since TerraformValue<T> doesn't expose its inner value directly,
            // and we stored the value as-is (which got wrapped), we can cast the wrapper itself
            return terraformValue is T directValue ? directValue : default;
        }
        catch (KeyNotFoundException)
        {
            return default;
        }
    }

    /// <summary>
    /// Called by source-generated property getters for required properties.
    /// Throws if the property was never set.
    /// </summary>
    /// <typeparam name="T">The property type.</typeparam>
    /// <param name="terraformName">The Terraform property name.</param>
    /// <returns>The stored value.</returns>
    /// <exception cref="InvalidOperationException">Thrown when a required property has not been set.</exception>
    protected T GetRequiredPropertyValue<T>(string terraformName)
    {
        return GetPropertyValue<T>(terraformName)
            ?? throw new InvalidOperationException($"Required property '{terraformName}' has not been set.");
    }

    /// <summary>
    /// Creates a reference expression to this block.
    /// Default implementation returns a simple identifier.
    /// Override in derived classes to provide specific reference formats (e.g., "resource.type.name").
    /// </summary>
    public virtual TerraformExpression AsReference()
        => TerraformExpression.Identifier(BlockLabel);

    // Note: Resolve() is inherited from TerraformMap<object> and handles resolution automatically.
    // The base implementation iterates the _elements dictionary and resolves each value to a TerraformExpression,
    // then returns a MapExpression containing all the key-value pairs.
}
