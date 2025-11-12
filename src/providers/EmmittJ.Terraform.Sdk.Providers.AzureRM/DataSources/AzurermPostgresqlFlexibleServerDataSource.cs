using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPostgresqlFlexibleServerDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_postgresql_flexible_server.
/// </summary>
public partial class AzurermPostgresqlFlexibleServerDataSource : TerraformDataSource
{
    public AzurermPostgresqlFlexibleServerDataSource(string name) : base("azurerm_postgresql_flexible_server", name)
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
    public AzurermPostgresqlFlexibleServerDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [TerraformProperty("administrator_login")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AdministratorLogin { get; }

    /// <summary>
    /// The auto_grow_enabled attribute.
    /// </summary>
    [TerraformProperty("auto_grow_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> AutoGrowEnabled { get; }

    /// <summary>
    /// The backup_retention_days attribute.
    /// </summary>
    [TerraformProperty("backup_retention_days")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> BackupRetentionDays { get; }

    /// <summary>
    /// The delegated_subnet_id attribute.
    /// </summary>
    [TerraformProperty("delegated_subnet_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DelegatedSubnetId { get; }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformProperty("fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Fqdn { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> PublicNetworkAccessEnabled { get; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformProperty("sku_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SkuName { get; }

    /// <summary>
    /// The storage_mb attribute.
    /// </summary>
    [TerraformProperty("storage_mb")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> StorageMb { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Version { get; }

}
