using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPublicIpTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_public_ip resource.
/// </summary>
public partial class AzurermPublicIp : TerraformResource
{
    public AzurermPublicIp(string name) : base("azurerm_public_ip", name)
    {
    }

    /// <summary>
    /// The allocation_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllocationMethod is required")]
    [TerraformProperty("allocation_method")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AllocationMethod { get; set; }

    /// <summary>
    /// The ddos_protection_mode attribute.
    /// </summary>
    [TerraformProperty("ddos_protection_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DdosProtectionMode { get; set; }

    /// <summary>
    /// The ddos_protection_plan_id attribute.
    /// </summary>
    [TerraformProperty("ddos_protection_plan_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DdosProtectionPlanId { get; set; }

    /// <summary>
    /// The domain_name_label attribute.
    /// </summary>
    [TerraformProperty("domain_name_label")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DomainNameLabel { get; set; }

    /// <summary>
    /// The domain_name_label_scope attribute.
    /// </summary>
    [TerraformProperty("domain_name_label_scope")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DomainNameLabelScope { get; set; }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformProperty("edge_zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EdgeZone { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    [TerraformProperty("idle_timeout_in_minutes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? IdleTimeoutInMinutes { get; set; }

    /// <summary>
    /// The ip_tags attribute.
    /// </summary>
    [TerraformProperty("ip_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? IpTags { get; set; }

    /// <summary>
    /// The ip_version attribute.
    /// </summary>
    [TerraformProperty("ip_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IpVersion { get; set; }

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
    /// The public_ip_prefix_id attribute.
    /// </summary>
    [TerraformProperty("public_ip_prefix_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PublicIpPrefixId { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The reverse_fqdn attribute.
    /// </summary>
    [TerraformProperty("reverse_fqdn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ReverseFqdn { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Sku { get; set; }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    [TerraformProperty("sku_tier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SkuTier { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformProperty("zones")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Zones { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermPublicIpTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformProperty("fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Fqdn { get; }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpAddress { get; }

}
