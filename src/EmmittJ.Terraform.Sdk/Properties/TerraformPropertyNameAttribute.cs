namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Specifies the Terraform property name for a C# property.
/// Used during serialization to map C# property names to HCL property names.
/// </summary>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
public class TerraformPropertyNameAttribute : Attribute
{
    /// <summary>
    /// Gets the Terraform property name (e.g., "instance_type", "availability_zone").
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformPropertyNameAttribute"/> class.
    /// </summary>
    /// <param name="name">The Terraform property name.</param>
    public TerraformPropertyNameAttribute(string name)
    {
        Name = name;
    }
}
