using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMysqlFlexibleServerDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_mysql_flexible_server.
/// </summary>
public class AzurermMysqlFlexibleServerDataSource : TerraformDataSource
{
    public AzurermMysqlFlexibleServerDataSource(string name) : base("azurerm_mysql_flexible_server", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMysqlFlexibleServerDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [TerraformPropertyName("administrator_login")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AdministratorLogin => new TerraformReference(this, "administrator_login");

    /// <summary>
    /// The backup_retention_days attribute.
    /// </summary>
    [TerraformPropertyName("backup_retention_days")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> BackupRetentionDays => new TerraformReference(this, "backup_retention_days");

    /// <summary>
    /// The delegated_subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("delegated_subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DelegatedSubnetId => new TerraformReference(this, "delegated_subnet_id");

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Fqdn => new TerraformReference(this, "fqdn");

    /// <summary>
    /// The geo_redundant_backup_enabled attribute.
    /// </summary>
    [TerraformPropertyName("geo_redundant_backup_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> GeoRedundantBackupEnabled => new TerraformReference(this, "geo_redundant_backup_enabled");

    /// <summary>
    /// The high_availability attribute.
    /// </summary>
    [TerraformPropertyName("high_availability")]
    // Output-only attribute - read-only reference
    public TerraformList<object> HighAvailability => new TerraformReference(this, "high_availability");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MaintenanceWindow => new TerraformReference(this, "maintenance_window");

    /// <summary>
    /// The private_dns_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("private_dns_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateDnsZoneId => new TerraformReference(this, "private_dns_zone_id");

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PublicNetworkAccessEnabled => new TerraformReference(this, "public_network_access_enabled");

    /// <summary>
    /// The replica_capacity attribute.
    /// </summary>
    [TerraformPropertyName("replica_capacity")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ReplicaCapacity => new TerraformReference(this, "replica_capacity");

    /// <summary>
    /// The replication_role attribute.
    /// </summary>
    [TerraformPropertyName("replication_role")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ReplicationRole => new TerraformReference(this, "replication_role");

    /// <summary>
    /// The restore_point_in_time attribute.
    /// </summary>
    [TerraformPropertyName("restore_point_in_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RestorePointInTime => new TerraformReference(this, "restore_point_in_time");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SkuName => new TerraformReference(this, "sku_name");

    /// <summary>
    /// The storage attribute.
    /// </summary>
    [TerraformPropertyName("storage")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Storage => new TerraformReference(this, "storage");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Version => new TerraformReference(this, "version");

    /// <summary>
    /// The zone attribute.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Zone => new TerraformReference(this, "zone");

}
