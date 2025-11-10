using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_networkmanager_link.
/// </summary>
public class AwsNetworkmanagerLinkDataSource : TerraformDataSource
{
    public AwsNetworkmanagerLinkDataSource(string name) : base("aws_networkmanager_link", name)
    {
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkId is required")]
    [TerraformPropertyName("global_network_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GlobalNetworkId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The link_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkId is required")]
    [TerraformPropertyName("link_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LinkId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The bandwidth attribute.
    /// </summary>
    [TerraformPropertyName("bandwidth")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Bandwidth => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "bandwidth");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [TerraformPropertyName("provider_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProviderName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "provider_name");

    /// <summary>
    /// The site_id attribute.
    /// </summary>
    [TerraformPropertyName("site_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SiteId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "site_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

}
