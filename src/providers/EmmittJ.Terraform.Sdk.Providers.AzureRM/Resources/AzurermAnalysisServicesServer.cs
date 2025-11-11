using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ipv4_firewall_rule in .
/// Nesting mode: set
/// </summary>
public class AzurermAnalysisServicesServerIpv4FirewallRuleBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The range_end attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RangeEnd is required")]
    [TerraformPropertyName("range_end")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RangeEnd { get; set; }

    /// <summary>
    /// The range_start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RangeStart is required")]
    [TerraformPropertyName("range_start")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RangeStart { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAnalysisServicesServerTimeoutsBlock
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
/// Manages a azurerm_analysis_services_server resource.
/// </summary>
public class AzurermAnalysisServicesServer : TerraformResource
{
    public AzurermAnalysisServicesServer(string name) : base("azurerm_analysis_services_server", name)
    {
    }

    /// <summary>
    /// The admin_users attribute.
    /// </summary>
    [TerraformPropertyName("admin_users")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? AdminUsers { get; set; }

    /// <summary>
    /// The backup_blob_container_uri attribute.
    /// </summary>
    [TerraformPropertyName("backup_blob_container_uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BackupBlobContainerUri { get; set; }

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
    /// The power_bi_service_enabled attribute.
    /// </summary>
    [TerraformPropertyName("power_bi_service_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PowerBiServiceEnabled { get; set; }

    /// <summary>
    /// The querypool_connection_mode attribute.
    /// </summary>
    [TerraformPropertyName("querypool_connection_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? QuerypoolConnectionMode { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformPropertyName("sku")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Sku { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for ipv4_firewall_rule.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("ipv4_firewall_rule")]
    public TerraformSet<TerraformBlock<AzurermAnalysisServicesServerIpv4FirewallRuleBlock>>? Ipv4FirewallRule { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAnalysisServicesServerTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The server_full_name attribute.
    /// </summary>
    [TerraformPropertyName("server_full_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServerFullName => new TerraformReference(this, "server_full_name");

}
