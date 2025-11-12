using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ipv4_firewall_rule in .
/// Nesting mode: set
/// </summary>
public partial class AzurermAnalysisServicesServerIpv4FirewallRuleBlock() : TerraformBlock("ipv4_firewall_rule")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The range_end attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RangeEnd is required")]
    [TerraformProperty("range_end")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RangeEnd { get; set; }

    /// <summary>
    /// The range_start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RangeStart is required")]
    [TerraformProperty("range_start")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RangeStart { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAnalysisServicesServerTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_analysis_services_server resource.
/// </summary>
public partial class AzurermAnalysisServicesServer : TerraformResource
{
    public AzurermAnalysisServicesServer(string name) : base("azurerm_analysis_services_server", name)
    {
    }

    /// <summary>
    /// The admin_users attribute.
    /// </summary>
    [TerraformProperty("admin_users")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AdminUsers { get; set; }

    /// <summary>
    /// The backup_blob_container_uri attribute.
    /// </summary>
    [TerraformProperty("backup_blob_container_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BackupBlobContainerUri { get; set; }

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
    /// The power_bi_service_enabled attribute.
    /// </summary>
    [TerraformProperty("power_bi_service_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PowerBiServiceEnabled { get; set; }

    /// <summary>
    /// The querypool_connection_mode attribute.
    /// </summary>
    [TerraformProperty("querypool_connection_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? QuerypoolConnectionMode { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformProperty("sku")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Sku { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for ipv4_firewall_rule.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("ipv4_firewall_rule")]
    public TerraformSet<AzurermAnalysisServicesServerIpv4FirewallRuleBlock> Ipv4FirewallRule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermAnalysisServicesServerTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The server_full_name attribute.
    /// </summary>
    [TerraformProperty("server_full_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServerFullName { get; }

}
