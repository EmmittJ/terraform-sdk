namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Marks a property as a Terraform attribute that should be source-generated.
/// The source generator will create the property implementation where:
/// - Getter returns a TerraformReference (for cross-resource references)
/// - Setter stores the value (for serialization to HCL)
/// </summary>
/// <example>
/// <code>
/// public partial class AzurermResourceGroup : TerraformResource
/// {
///     [TerraformProperty("name")]
///     public required partial TerraformValue&lt;string&gt; Name { get; set; }
/// }
/// </code>
/// </example>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public sealed class TerraformPropertyAttribute : Attribute
{
    /// <summary>
    /// Gets the Terraform attribute name (as it appears in HCL).
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformPropertyAttribute"/> class.
    /// </summary>
    /// <param name="name">The Terraform attribute name (e.g., "resource_group_name").</param>
    public TerraformPropertyAttribute(string name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }
}
