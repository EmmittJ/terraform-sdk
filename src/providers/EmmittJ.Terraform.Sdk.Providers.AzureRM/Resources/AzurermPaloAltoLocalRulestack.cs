using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPaloAltoLocalRulestackTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_palo_alto_local_rulestack resource.
/// </summary>
public class AzurermPaloAltoLocalRulestack : TerraformResource
{
    public AzurermPaloAltoLocalRulestack(string name) : base("azurerm_palo_alto_local_rulestack", name)
    {
    }

    /// <summary>
    /// The anti_spyware_profile attribute.
    /// </summary>
    [TerraformPropertyName("anti_spyware_profile")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AntiSpywareProfile { get; set; }

    /// <summary>
    /// The anti_virus_profile attribute.
    /// </summary>
    [TerraformPropertyName("anti_virus_profile")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AntiVirusProfile { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The dns_subscription attribute.
    /// </summary>
    [TerraformPropertyName("dns_subscription")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DnsSubscription { get; set; }

    /// <summary>
    /// The file_blocking_profile attribute.
    /// </summary>
    [TerraformPropertyName("file_blocking_profile")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FileBlockingProfile { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

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
    /// The url_filtering_profile attribute.
    /// </summary>
    [TerraformPropertyName("url_filtering_profile")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UrlFilteringProfile { get; set; }

    /// <summary>
    /// The vulnerability_profile attribute.
    /// </summary>
    [TerraformPropertyName("vulnerability_profile")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VulnerabilityProfile { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermPaloAltoLocalRulestackTimeoutsBlock>? Timeouts { get; set; }

}
