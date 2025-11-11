using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMysqlFlexibleServerDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_mysql_flexible_server.
/// </summary>
public partial class AzurermMysqlFlexibleServerDataSource : TerraformDataSource
{
    public AzurermMysqlFlexibleServerDataSource(string name) : base("azurerm_mysql_flexible_server", name)
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
    public TerraformBlock<AzurermMysqlFlexibleServerDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [TerraformProperty("administrator_login")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AdministratorLogin { get; }

    /// <summary>
    /// The backup_retention_days attribute.
    /// </summary>
    [TerraformProperty("backup_retention_days")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> BackupRetentionDays { get; }

    /// <summary>
    /// The delegated_subnet_id attribute.
    /// </summary>
    [TerraformProperty("delegated_subnet_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DelegatedSubnetId { get; }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformProperty("fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Fqdn { get; }

    /// <summary>
    /// The geo_redundant_backup_enabled attribute.
    /// </summary>
    [TerraformProperty("geo_redundant_backup_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> GeoRedundantBackupEnabled { get; }

    /// <summary>
    /// The high_availability attribute.
    /// </summary>
    [TerraformProperty("high_availability")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> HighAvailability { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformProperty("maintenance_window")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MaintenanceWindow { get; }

    /// <summary>
    /// The private_dns_zone_id attribute.
    /// </summary>
    [TerraformProperty("private_dns_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrivateDnsZoneId { get; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> PublicNetworkAccessEnabled { get; }

    /// <summary>
    /// The replica_capacity attribute.
    /// </summary>
    [TerraformProperty("replica_capacity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ReplicaCapacity { get; }

    /// <summary>
    /// The replication_role attribute.
    /// </summary>
    [TerraformProperty("replication_role")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ReplicationRole { get; }

    /// <summary>
    /// The restore_point_in_time attribute.
    /// </summary>
    [TerraformProperty("restore_point_in_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RestorePointInTime { get; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformProperty("sku_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SkuName { get; }

    /// <summary>
    /// The storage attribute.
    /// </summary>
    [TerraformProperty("storage")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Storage { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Version { get; }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    [TerraformProperty("zone")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Zone { get; }

}
