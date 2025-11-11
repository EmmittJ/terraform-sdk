using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPublicIpTimeoutsBlock
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
/// Manages a azurerm_public_ip resource.
/// </summary>
public class AzurermPublicIp : TerraformResource
{
    public AzurermPublicIp(string name) : base("azurerm_public_ip", name)
    {
    }

    /// <summary>
    /// The allocation_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllocationMethod is required")]
    [TerraformPropertyName("allocation_method")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AllocationMethod { get; set; }

    /// <summary>
    /// The ddos_protection_mode attribute.
    /// </summary>
    [TerraformPropertyName("ddos_protection_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DdosProtectionMode { get; set; }

    /// <summary>
    /// The ddos_protection_plan_id attribute.
    /// </summary>
    [TerraformPropertyName("ddos_protection_plan_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DdosProtectionPlanId { get; set; }

    /// <summary>
    /// The domain_name_label attribute.
    /// </summary>
    [TerraformPropertyName("domain_name_label")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DomainNameLabel { get; set; }

    /// <summary>
    /// The domain_name_label_scope attribute.
    /// </summary>
    [TerraformPropertyName("domain_name_label_scope")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DomainNameLabelScope { get; set; }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformPropertyName("edge_zone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EdgeZone { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("idle_timeout_in_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? IdleTimeoutInMinutes { get; set; }

    /// <summary>
    /// The ip_tags attribute.
    /// </summary>
    [TerraformPropertyName("ip_tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? IpTags { get; set; }

    /// <summary>
    /// The ip_version attribute.
    /// </summary>
    [TerraformPropertyName("ip_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IpVersion { get; set; }

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
    /// The public_ip_prefix_id attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_prefix_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PublicIpPrefixId { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The reverse_fqdn attribute.
    /// </summary>
    [TerraformPropertyName("reverse_fqdn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ReverseFqdn { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Sku { get; set; }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    [TerraformPropertyName("sku_tier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SkuTier { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Zones { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermPublicIpTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Fqdn => new TerraformReference(this, "fqdn");

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformPropertyName("ip_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpAddress => new TerraformReference(this, "ip_address");

}
