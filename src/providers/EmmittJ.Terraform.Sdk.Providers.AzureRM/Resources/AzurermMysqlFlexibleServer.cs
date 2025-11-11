using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for customer_managed_key in .
/// Nesting mode: list
/// </summary>
public class AzurermMysqlFlexibleServerCustomerManagedKeyBlock
{
    /// <summary>
    /// The geo_backup_key_vault_key_id attribute.
    /// </summary>
    [TerraformPropertyName("geo_backup_key_vault_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GeoBackupKeyVaultKeyId { get; set; }

    /// <summary>
    /// The geo_backup_user_assigned_identity_id attribute.
    /// </summary>
    [TerraformPropertyName("geo_backup_user_assigned_identity_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GeoBackupUserAssignedIdentityId { get; set; }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KeyVaultKeyId { get; set; }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_hsm_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ManagedHsmKeyId { get; set; }

    /// <summary>
    /// The primary_user_assigned_identity_id attribute.
    /// </summary>
    [TerraformPropertyName("primary_user_assigned_identity_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrimaryUserAssignedIdentityId { get; set; }

}

/// <summary>
/// Block type for high_availability in .
/// Nesting mode: list
/// </summary>
public class AzurermMysqlFlexibleServerHighAvailabilityBlock
{
    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformPropertyName("mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Mode { get; set; }

    /// <summary>
    /// The standby_availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("standby_availability_zone")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StandbyAvailabilityZone { get; set; } = default!;

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermMysqlFlexibleServerIdentityBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    [TerraformPropertyName("identity_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> IdentityIds { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class AzurermMysqlFlexibleServerMaintenanceWindowBlock
{
    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [TerraformPropertyName("day_of_week")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DayOfWeek { get; set; }

    /// <summary>
    /// The start_hour attribute.
    /// </summary>
    [TerraformPropertyName("start_hour")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? StartHour { get; set; }

    /// <summary>
    /// The start_minute attribute.
    /// </summary>
    [TerraformPropertyName("start_minute")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? StartMinute { get; set; }

}

/// <summary>
/// Block type for storage in .
/// Nesting mode: list
/// </summary>
public class AzurermMysqlFlexibleServerStorageBlock
{
    /// <summary>
    /// The auto_grow_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auto_grow_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutoGrowEnabled { get; set; }

    /// <summary>
    /// The io_scaling_enabled attribute.
    /// </summary>
    [TerraformPropertyName("io_scaling_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IoScalingEnabled { get; set; }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformPropertyName("iops")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Iops { get; set; } = default!;

    /// <summary>
    /// The log_on_disk_enabled attribute.
    /// </summary>
    [TerraformPropertyName("log_on_disk_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? LogOnDiskEnabled { get; set; }

    /// <summary>
    /// The size_gb attribute.
    /// </summary>
    [TerraformPropertyName("size_gb")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> SizeGb { get; set; } = default!;

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMysqlFlexibleServerTimeoutsBlock
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
/// Manages a azurerm_mysql_flexible_server resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMysqlFlexibleServer : TerraformResource
{
    public AzurermMysqlFlexibleServer(string name) : base("azurerm_mysql_flexible_server", name)
    {
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [TerraformPropertyName("administrator_login")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AdministratorLogin { get; set; } = default!;

    /// <summary>
    /// The administrator_password attribute.
    /// </summary>
    [TerraformPropertyName("administrator_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AdministratorPassword { get; set; }

    /// <summary>
    /// The administrator_password_wo attribute.
    /// </summary>
    [TerraformPropertyName("administrator_password_wo")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AdministratorPasswordWo { get; set; }

    /// <summary>
    /// The administrator_password_wo_version attribute.
    /// </summary>
    [TerraformPropertyName("administrator_password_wo_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? AdministratorPasswordWoVersion { get; set; }

    /// <summary>
    /// The backup_retention_days attribute.
    /// </summary>
    [TerraformPropertyName("backup_retention_days")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BackupRetentionDays { get; set; }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    [TerraformPropertyName("create_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CreateMode { get; set; }

    /// <summary>
    /// The delegated_subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("delegated_subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DelegatedSubnetId { get; set; }

    /// <summary>
    /// The geo_redundant_backup_enabled attribute.
    /// </summary>
    [TerraformPropertyName("geo_redundant_backup_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? GeoRedundantBackupEnabled { get; set; }

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
    /// The point_in_time_restore_time_in_utc attribute.
    /// </summary>
    [TerraformPropertyName("point_in_time_restore_time_in_utc")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PointInTimeRestoreTimeInUtc { get; set; }

    /// <summary>
    /// The private_dns_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("private_dns_zone_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrivateDnsZoneId { get; set; }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PublicNetworkAccess { get; set; } = default!;

    /// <summary>
    /// The replication_role attribute.
    /// </summary>
    [TerraformPropertyName("replication_role")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ReplicationRole { get; set; } = default!;

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SkuName { get; set; } = default!;

    /// <summary>
    /// The source_server_id attribute.
    /// </summary>
    [TerraformPropertyName("source_server_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceServerId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Version { get; set; } = default!;

    /// <summary>
    /// The zone attribute.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Zone { get; set; } = default!;

    /// <summary>
    /// Block for customer_managed_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    [TerraformPropertyName("customer_managed_key")]
    public TerraformList<TerraformBlock<AzurermMysqlFlexibleServerCustomerManagedKeyBlock>>? CustomerManagedKey { get; set; }

    /// <summary>
    /// Block for high_availability.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HighAvailability block(s) allowed")]
    [TerraformPropertyName("high_availability")]
    public TerraformList<TerraformBlock<AzurermMysqlFlexibleServerHighAvailabilityBlock>>? HighAvailability { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermMysqlFlexibleServerIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    [TerraformPropertyName("maintenance_window")]
    public TerraformList<TerraformBlock<AzurermMysqlFlexibleServerMaintenanceWindowBlock>>? MaintenanceWindow { get; set; }

    /// <summary>
    /// Block for storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Storage block(s) allowed")]
    [TerraformPropertyName("storage")]
    public TerraformList<TerraformBlock<AzurermMysqlFlexibleServerStorageBlock>>? Storage { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMysqlFlexibleServerTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Fqdn => new TerraformReference(this, "fqdn");

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

}
