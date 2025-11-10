using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_machine_types.
/// </summary>
public class GoogleComputeMachineTypesDataSource : TerraformDataSource
{
    public GoogleComputeMachineTypesDataSource(string name) : base("google_compute_machine_types", name)
    {
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [TerraformPropertyName("filter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Project ID for this request.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The name of the zone for this request.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Zone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "zone");

    /// <summary>
    /// The list of machine types
    /// </summary>
    [TerraformPropertyName("machine_types")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MachineTypes => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "machine_types");

}
