using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPublicIpDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_public_ip.
/// </summary>
public class AzurermPublicIpDataSource : TerraformDataSource
{
    public AzurermPublicIpDataSource(string name) : base("azurerm_public_ip", name)
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
    public TerraformBlock<AzurermPublicIpDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The allocation_method attribute.
    /// </summary>
    [TerraformPropertyName("allocation_method")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AllocationMethod => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "allocation_method");

    /// <summary>
    /// The ddos_protection_mode attribute.
    /// </summary>
    [TerraformPropertyName("ddos_protection_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DdosProtectionMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ddos_protection_mode");

    /// <summary>
    /// The ddos_protection_plan_id attribute.
    /// </summary>
    [TerraformPropertyName("ddos_protection_plan_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DdosProtectionPlanId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ddos_protection_plan_id");

    /// <summary>
    /// The domain_name_label attribute.
    /// </summary>
    [TerraformPropertyName("domain_name_label")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DomainNameLabel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain_name_label");

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Fqdn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fqdn");

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("idle_timeout_in_minutes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> IdleTimeoutInMinutes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "idle_timeout_in_minutes");

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformPropertyName("ip_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip_address");

    /// <summary>
    /// The ip_tags attribute.
    /// </summary>
    [TerraformPropertyName("ip_tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> IpTags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "ip_tags");

    /// <summary>
    /// The ip_version attribute.
    /// </summary>
    [TerraformPropertyName("ip_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip_version");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The reverse_fqdn attribute.
    /// </summary>
    [TerraformPropertyName("reverse_fqdn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ReverseFqdn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "reverse_fqdn");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Sku => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Zones => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "zones");

}
