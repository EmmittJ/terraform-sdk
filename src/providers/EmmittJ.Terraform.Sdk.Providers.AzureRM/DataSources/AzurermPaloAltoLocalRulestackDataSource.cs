using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPaloAltoLocalRulestackDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_palo_alto_local_rulestack.
/// </summary>
public partial class AzurermPaloAltoLocalRulestackDataSource : TerraformDataSource
{
    public AzurermPaloAltoLocalRulestackDataSource(string name) : base("azurerm_palo_alto_local_rulestack", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermPaloAltoLocalRulestackDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The anti_spyware_profile attribute.
    /// </summary>
    [TerraformProperty("anti_spyware_profile")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AntiSpywareProfile { get; }

    /// <summary>
    /// The anti_virus_profile attribute.
    /// </summary>
    [TerraformProperty("anti_virus_profile")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AntiVirusProfile { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The dns_subscription attribute.
    /// </summary>
    [TerraformProperty("dns_subscription")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DnsSubscription { get; }

    /// <summary>
    /// The file_blocking_profile attribute.
    /// </summary>
    [TerraformProperty("file_blocking_profile")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FileBlockingProfile { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The outbound_trust_certificate attribute.
    /// </summary>
    [TerraformProperty("outbound_trust_certificate")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OutboundTrustCertificate { get; }

    /// <summary>
    /// The outbound_untrust_certificate attribute.
    /// </summary>
    [TerraformProperty("outbound_untrust_certificate")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OutboundUntrustCertificate { get; }

    /// <summary>
    /// The url_filtering_profile attribute.
    /// </summary>
    [TerraformProperty("url_filtering_profile")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UrlFilteringProfile { get; }

    /// <summary>
    /// The vulnerability_profile attribute.
    /// </summary>
    [TerraformProperty("vulnerability_profile")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VulnerabilityProfile { get; }

}
