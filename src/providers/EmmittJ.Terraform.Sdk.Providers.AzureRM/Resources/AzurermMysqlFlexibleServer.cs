using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for customer_managed_key in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMysqlFlexibleServerCustomerManagedKeyBlock() : TerraformBlock("customer_managed_key")
{
    /// <summary>
    /// The geo_backup_key_vault_key_id attribute.
    /// </summary>
    [TerraformProperty("geo_backup_key_vault_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GeoBackupKeyVaultKeyId { get; set; }

    /// <summary>
    /// The geo_backup_user_assigned_identity_id attribute.
    /// </summary>
    [TerraformProperty("geo_backup_user_assigned_identity_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GeoBackupUserAssignedIdentityId { get; set; }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyVaultKeyId { get; set; }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    [TerraformProperty("managed_hsm_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ManagedHsmKeyId { get; set; }

    /// <summary>
    /// The primary_user_assigned_identity_id attribute.
    /// </summary>
    [TerraformProperty("primary_user_assigned_identity_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrimaryUserAssignedIdentityId { get; set; }

}

/// <summary>
/// Block type for high_availability in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMysqlFlexibleServerHighAvailabilityBlock() : TerraformBlock("high_availability")
{
    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformProperty("mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Mode { get; set; }

    /// <summary>
    /// The standby_availability_zone attribute.
    /// </summary>
    [TerraformProperty("standby_availability_zone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StandbyAvailabilityZone { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMysqlFlexibleServerIdentityBlock() : TerraformBlock("identity")
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    [TerraformProperty("identity_ids")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> IdentityIds { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMysqlFlexibleServerMaintenanceWindowBlock() : TerraformBlock("maintenance_window")
{
    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [TerraformProperty("day_of_week")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DayOfWeek { get; set; }

    /// <summary>
    /// The start_hour attribute.
    /// </summary>
    [TerraformProperty("start_hour")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? StartHour { get; set; }

    /// <summary>
    /// The start_minute attribute.
    /// </summary>
    [TerraformProperty("start_minute")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? StartMinute { get; set; }

}

/// <summary>
/// Block type for storage in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMysqlFlexibleServerStorageBlock() : TerraformBlock("storage")
{
    /// <summary>
    /// The auto_grow_enabled attribute.
    /// </summary>
    [TerraformProperty("auto_grow_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoGrowEnabled { get; set; }

    /// <summary>
    /// The io_scaling_enabled attribute.
    /// </summary>
    [TerraformProperty("io_scaling_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IoScalingEnabled { get; set; }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformProperty("iops")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Iops { get; set; }

    /// <summary>
    /// The log_on_disk_enabled attribute.
    /// </summary>
    [TerraformProperty("log_on_disk_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LogOnDiskEnabled { get; set; }

    /// <summary>
    /// The size_gb attribute.
    /// </summary>
    [TerraformProperty("size_gb")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> SizeGb { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMysqlFlexibleServerTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_mysql_flexible_server resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMysqlFlexibleServer : TerraformResource
{
    public AzurermMysqlFlexibleServer(string name) : base("azurerm_mysql_flexible_server", name)
    {
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [TerraformProperty("administrator_login")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AdministratorLogin { get; set; }

    /// <summary>
    /// The administrator_password attribute.
    /// </summary>
    [TerraformProperty("administrator_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdministratorPassword { get; set; }

    /// <summary>
    /// The administrator_password_wo attribute.
    /// </summary>
    [TerraformProperty("administrator_password_wo")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdministratorPasswordWo { get; set; }

    /// <summary>
    /// The administrator_password_wo_version attribute.
    /// </summary>
    [TerraformProperty("administrator_password_wo_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AdministratorPasswordWoVersion { get; set; }

    /// <summary>
    /// The backup_retention_days attribute.
    /// </summary>
    [TerraformProperty("backup_retention_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BackupRetentionDays { get; set; }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    [TerraformProperty("create_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CreateMode { get; set; }

    /// <summary>
    /// The delegated_subnet_id attribute.
    /// </summary>
    [TerraformProperty("delegated_subnet_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DelegatedSubnetId { get; set; }

    /// <summary>
    /// The geo_redundant_backup_enabled attribute.
    /// </summary>
    [TerraformProperty("geo_redundant_backup_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? GeoRedundantBackupEnabled { get; set; }

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
    /// The point_in_time_restore_time_in_utc attribute.
    /// </summary>
    [TerraformProperty("point_in_time_restore_time_in_utc")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PointInTimeRestoreTimeInUtc { get; set; }

    /// <summary>
    /// The private_dns_zone_id attribute.
    /// </summary>
    [TerraformProperty("private_dns_zone_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrivateDnsZoneId { get; set; }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    [TerraformProperty("public_network_access")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PublicNetworkAccess { get; set; }

    /// <summary>
    /// The replication_role attribute.
    /// </summary>
    [TerraformProperty("replication_role")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ReplicationRole { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformProperty("sku_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SkuName { get; set; }

    /// <summary>
    /// The source_server_id attribute.
    /// </summary>
    [TerraformProperty("source_server_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceServerId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Version { get; set; }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Zone { get; set; }

    /// <summary>
    /// Block for customer_managed_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    [TerraformProperty("customer_managed_key")]
    public TerraformList<AzurermMysqlFlexibleServerCustomerManagedKeyBlock> CustomerManagedKey { get; set; } = new();

    /// <summary>
    /// Block for high_availability.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HighAvailability block(s) allowed")]
    [TerraformProperty("high_availability")]
    public TerraformList<AzurermMysqlFlexibleServerHighAvailabilityBlock> HighAvailability { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermMysqlFlexibleServerIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    [TerraformProperty("maintenance_window")]
    public TerraformList<AzurermMysqlFlexibleServerMaintenanceWindowBlock> MaintenanceWindow { get; set; } = new();

    /// <summary>
    /// Block for storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Storage block(s) allowed")]
    [TerraformProperty("storage")]
    public TerraformList<AzurermMysqlFlexibleServerStorageBlock> Storage { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermMysqlFlexibleServerTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformProperty("fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Fqdn { get; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> PublicNetworkAccessEnabled { get; }

    /// <summary>
    /// The replica_capacity attribute.
    /// </summary>
    [TerraformProperty("replica_capacity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ReplicaCapacity { get; }

}
