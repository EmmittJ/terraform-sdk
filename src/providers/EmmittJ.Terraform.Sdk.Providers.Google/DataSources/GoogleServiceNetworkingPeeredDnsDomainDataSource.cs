using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_service_networking_peered_dns_domain.
/// </summary>
public class GoogleServiceNetworkingPeeredDnsDomainDataSource : TerraformDataSource
{
    public GoogleServiceNetworkingPeeredDnsDomainDataSource(string name) : base("google_service_networking_peered_dns_domain", name)
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
    /// The network attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformPropertyName("network")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Network { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    [TerraformPropertyName("project")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Project { get; set; }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformPropertyName("service")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Service { get; set; }

    /// <summary>
    /// The dns_suffix attribute.
    /// </summary>
    [TerraformPropertyName("dns_suffix")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsSuffix => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_suffix");

    /// <summary>
    /// The parent attribute.
    /// </summary>
    [TerraformPropertyName("parent")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Parent => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "parent");

}
