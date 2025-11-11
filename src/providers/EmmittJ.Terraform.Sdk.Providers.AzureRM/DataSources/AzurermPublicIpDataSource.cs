using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPublicIpDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_public_ip.
/// </summary>
public partial class AzurermPublicIpDataSource : TerraformDataSource
{
    public AzurermPublicIpDataSource(string name) : base("azurerm_public_ip", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermPublicIpDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The allocation_method attribute.
    /// </summary>
    [TerraformProperty("allocation_method")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AllocationMethod { get; }

    /// <summary>
    /// The ddos_protection_mode attribute.
    /// </summary>
    [TerraformProperty("ddos_protection_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DdosProtectionMode { get; }

    /// <summary>
    /// The ddos_protection_plan_id attribute.
    /// </summary>
    [TerraformProperty("ddos_protection_plan_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DdosProtectionPlanId { get; }

    /// <summary>
    /// The domain_name_label attribute.
    /// </summary>
    [TerraformProperty("domain_name_label")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DomainNameLabel { get; }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformProperty("fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Fqdn { get; }

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    [TerraformProperty("idle_timeout_in_minutes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> IdleTimeoutInMinutes { get; }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpAddress { get; }

    /// <summary>
    /// The ip_tags attribute.
    /// </summary>
    [TerraformProperty("ip_tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> IpTags { get; }

    /// <summary>
    /// The ip_version attribute.
    /// </summary>
    [TerraformProperty("ip_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpVersion { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The reverse_fqdn attribute.
    /// </summary>
    [TerraformProperty("reverse_fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ReverseFqdn { get; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Sku { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformProperty("zones")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Zones { get; }

}
