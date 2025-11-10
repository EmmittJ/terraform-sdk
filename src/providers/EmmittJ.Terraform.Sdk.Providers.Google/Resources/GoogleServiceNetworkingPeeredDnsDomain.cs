using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleServiceNetworkingPeeredDnsDomainTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Manages a google_service_networking_peered_dns_domain resource.
/// </summary>
public class GoogleServiceNetworkingPeeredDnsDomain : TerraformResource
{
    public GoogleServiceNetworkingPeeredDnsDomain(string name) : base("google_service_networking_peered_dns_domain", name)
    {
    }

    /// <summary>
    /// The DNS domain name suffix of the peered DNS domain.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsSuffix is required")]
    [TerraformPropertyName("dns_suffix")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DnsSuffix { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Name of the peered DNS domain.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Network in the consumer project to peer with.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformPropertyName("network")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Network { get; set; }

    /// <summary>
    /// The ID of the project that the service account will be created in. Defaults to the provider project configuration.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The name of the service to create a peered DNS domain for, e.g. servicenetworking.googleapis.com
    /// </summary>
    [TerraformPropertyName("service")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Service { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleServiceNetworkingPeeredDnsDomainTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The parent attribute.
    /// </summary>
    [TerraformPropertyName("parent")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Parent => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "parent");

}
