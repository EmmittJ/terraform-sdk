using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPaloAltoLocalRulestackTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_palo_alto_local_rulestack resource.
/// </summary>
public partial class AzurermPaloAltoLocalRulestack : TerraformResource
{
    public AzurermPaloAltoLocalRulestack(string name) : base("azurerm_palo_alto_local_rulestack", name)
    {
    }

    /// <summary>
    /// The anti_spyware_profile attribute.
    /// </summary>
    [TerraformProperty("anti_spyware_profile")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AntiSpywareProfile { get; set; }

    /// <summary>
    /// The anti_virus_profile attribute.
    /// </summary>
    [TerraformProperty("anti_virus_profile")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AntiVirusProfile { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The dns_subscription attribute.
    /// </summary>
    [TerraformProperty("dns_subscription")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DnsSubscription { get; set; }

    /// <summary>
    /// The file_blocking_profile attribute.
    /// </summary>
    [TerraformProperty("file_blocking_profile")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FileBlockingProfile { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The url_filtering_profile attribute.
    /// </summary>
    [TerraformProperty("url_filtering_profile")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UrlFilteringProfile { get; set; }

    /// <summary>
    /// The vulnerability_profile attribute.
    /// </summary>
    [TerraformProperty("vulnerability_profile")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VulnerabilityProfile { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermPaloAltoLocalRulestackTimeoutsBlock Timeouts { get; set; } = new();

}
