using System.Collections;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Marker interface for Terraform collection properties.
/// </summary>
public interface ITerraformCollection
{
    // Marker interface - used for serialization type checking
}

/// <summary>
/// Generic marker interface for Terraform collection properties with element type information.
/// </summary>
/// <typeparam name="TElement">The type of elements in the collection.</typeparam>
public interface ITerraformCollection<TElement> : ITerraformCollection
{
    // Marker interface - provides generic type information
}
