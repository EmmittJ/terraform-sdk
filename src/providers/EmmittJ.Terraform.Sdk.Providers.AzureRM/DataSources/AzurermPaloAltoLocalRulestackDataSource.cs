using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPaloAltoLocalRulestackDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermPaloAltoLocalRulestackDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The anti_spyware_profile attribute.
    /// </summary>
    [TerraformPropertyName("anti_spyware_profile")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AntiSpywareProfile => new TerraformReference(this, "anti_spyware_profile");

    /// <summary>
    /// The anti_virus_profile attribute.
    /// </summary>
    [TerraformPropertyName("anti_virus_profile")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AntiVirusProfile => new TerraformReference(this, "anti_virus_profile");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The dns_subscription attribute.
    /// </summary>
    [TerraformPropertyName("dns_subscription")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DnsSubscription => new TerraformReference(this, "dns_subscription");

    /// <summary>
    /// The file_blocking_profile attribute.
    /// </summary>
    [TerraformPropertyName("file_blocking_profile")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FileBlockingProfile => new TerraformReference(this, "file_blocking_profile");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The outbound_trust_certificate attribute.
    /// </summary>
    [TerraformPropertyName("outbound_trust_certificate")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OutboundTrustCertificate => new TerraformReference(this, "outbound_trust_certificate");

    /// <summary>
    /// The outbound_untrust_certificate attribute.
    /// </summary>
    [TerraformPropertyName("outbound_untrust_certificate")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OutboundUntrustCertificate => new TerraformReference(this, "outbound_untrust_certificate");

    /// <summary>
    /// The url_filtering_profile attribute.
    /// </summary>
    [TerraformPropertyName("url_filtering_profile")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UrlFilteringProfile => new TerraformReference(this, "url_filtering_profile");

    /// <summary>
    /// The vulnerability_profile attribute.
    /// </summary>
    [TerraformPropertyName("vulnerability_profile")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VulnerabilityProfile => new TerraformReference(this, "vulnerability_profile");

}
