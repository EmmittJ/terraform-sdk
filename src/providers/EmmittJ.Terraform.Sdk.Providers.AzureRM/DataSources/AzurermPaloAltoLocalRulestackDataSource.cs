using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPaloAltoLocalRulestackDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_palo_alto_local_rulestack.
/// </summary>
public class AzurermPaloAltoLocalRulestackDataSource : TerraformDataSource
{
    public AzurermPaloAltoLocalRulestackDataSource(string name) : base("azurerm_palo_alto_local_rulestack", name)
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermPaloAltoLocalRulestackDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The anti_spyware_profile attribute.
    /// </summary>
    [TerraformPropertyName("anti_spyware_profile")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AntiSpywareProfile => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "anti_spyware_profile");

    /// <summary>
    /// The anti_virus_profile attribute.
    /// </summary>
    [TerraformPropertyName("anti_virus_profile")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AntiVirusProfile => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "anti_virus_profile");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The dns_subscription attribute.
    /// </summary>
    [TerraformPropertyName("dns_subscription")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsSubscription => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_subscription");

    /// <summary>
    /// The file_blocking_profile attribute.
    /// </summary>
    [TerraformPropertyName("file_blocking_profile")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FileBlockingProfile => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "file_blocking_profile");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The outbound_trust_certificate attribute.
    /// </summary>
    [TerraformPropertyName("outbound_trust_certificate")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OutboundTrustCertificate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "outbound_trust_certificate");

    /// <summary>
    /// The outbound_untrust_certificate attribute.
    /// </summary>
    [TerraformPropertyName("outbound_untrust_certificate")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OutboundUntrustCertificate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "outbound_untrust_certificate");

    /// <summary>
    /// The url_filtering_profile attribute.
    /// </summary>
    [TerraformPropertyName("url_filtering_profile")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UrlFilteringProfile => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "url_filtering_profile");

    /// <summary>
    /// The vulnerability_profile attribute.
    /// </summary>
    [TerraformPropertyName("vulnerability_profile")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VulnerabilityProfile => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vulnerability_profile");

}
