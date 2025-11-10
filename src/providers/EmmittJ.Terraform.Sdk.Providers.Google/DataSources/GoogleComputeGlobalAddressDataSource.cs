using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_global_address.
/// </summary>
public class GoogleComputeGlobalAddressDataSource : TerraformDataSource
{
    public GoogleComputeGlobalAddressDataSource(string name) : base("google_compute_global_address", name)
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
    /// The address attribute.
    /// </summary>
    [TerraformPropertyName("address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Address => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "address");

    /// <summary>
    /// The address_type attribute.
    /// </summary>
    [TerraformPropertyName("address_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AddressType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "address_type");

    /// <summary>
    /// The network attribute.
    /// </summary>
    [TerraformPropertyName("network")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Network => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network");

    /// <summary>
    /// The network_tier attribute.
    /// </summary>
    [TerraformPropertyName("network_tier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkTier => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_tier");

    /// <summary>
    /// The prefix_length attribute.
    /// </summary>
    [TerraformPropertyName("prefix_length")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> PrefixLength => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "prefix_length");

    /// <summary>
    /// The purpose attribute.
    /// </summary>
    [TerraformPropertyName("purpose")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Purpose => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "purpose");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The subnetwork attribute.
    /// </summary>
    [TerraformPropertyName("subnetwork")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Subnetwork => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subnetwork");

    /// <summary>
    /// The users attribute.
    /// </summary>
    [TerraformPropertyName("users")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Users => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "users");

}
