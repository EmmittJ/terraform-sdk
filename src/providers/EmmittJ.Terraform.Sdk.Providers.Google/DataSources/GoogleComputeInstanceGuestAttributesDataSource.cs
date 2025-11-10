using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_instance_guest_attributes.
/// </summary>
public class GoogleComputeInstanceGuestAttributesDataSource : TerraformDataSource
{
    public GoogleComputeInstanceGuestAttributesDataSource(string name) : base("google_compute_instance_guest_attributes", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The query_path attribute.
    /// </summary>
    [TerraformPropertyName("query_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? QueryPath { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The variable_key attribute.
    /// </summary>
    [TerraformPropertyName("variable_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VariableKey { get; set; }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Zone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "zone");

    /// <summary>
    /// The query_value attribute.
    /// </summary>
    [TerraformPropertyName("query_value")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> QueryValue => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "query_value");

    /// <summary>
    /// The variable_value attribute.
    /// </summary>
    [TerraformPropertyName("variable_value")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VariableValue => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "variable_value");

}
