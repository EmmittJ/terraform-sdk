using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for customer_managed_key in AzurermMysqlFlexibleServer.
/// Nesting mode: list
/// </summary>
public class AzurermMysqlFlexibleServerCustomerManagedKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "customer_managed_key";

    /// <summary>
    /// The geo_backup_key_vault_key_id attribute.
    /// </summary>
    public TerraformValue<string>? GeoBackupKeyVaultKeyId
    {
        get => GetArgument<TerraformValue<string>>("geo_backup_key_vault_key_id");
        set => SetArgument("geo_backup_key_vault_key_id", value);
    }

    /// <summary>
    /// The geo_backup_user_assigned_identity_id attribute.
    /// </summary>
    public TerraformValue<string>? GeoBackupUserAssignedIdentityId
    {
        get => GetArgument<TerraformValue<string>>("geo_backup_user_assigned_identity_id");
        set => SetArgument("geo_backup_user_assigned_identity_id", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyVaultKeyId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    public TerraformValue<string>? ManagedHsmKeyId
    {
        get => GetArgument<TerraformValue<string>>("managed_hsm_key_id");
        set => SetArgument("managed_hsm_key_id", value);
    }

    /// <summary>
    /// The primary_user_assigned_identity_id attribute.
    /// </summary>
    public TerraformValue<string>? PrimaryUserAssignedIdentityId
    {
        get => GetArgument<TerraformValue<string>>("primary_user_assigned_identity_id");
        set => SetArgument("primary_user_assigned_identity_id", value);
    }

}


/// <summary>
/// Block type for high_availability in AzurermMysqlFlexibleServer.
/// Nesting mode: list
/// </summary>
public class AzurermMysqlFlexibleServerHighAvailabilityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "high_availability";

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The standby_availability_zone attribute.
    /// </summary>
    public TerraformValue<string>? StandbyAvailabilityZone
    {
        get => GetArgument<TerraformValue<string>>("standby_availability_zone");
        set => SetArgument("standby_availability_zone", value);
    }

}


/// <summary>
/// Block type for identity in AzurermMysqlFlexibleServer.
/// Nesting mode: list
/// </summary>
public class AzurermMysqlFlexibleServerIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    public required TerraformSet<string> IdentityIds
    {
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for maintenance_window in AzurermMysqlFlexibleServer.
/// Nesting mode: list
/// </summary>
public class AzurermMysqlFlexibleServerMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_window";

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    public TerraformValue<double>? DayOfWeek
    {
        get => GetArgument<TerraformValue<double>>("day_of_week");
        set => SetArgument("day_of_week", value);
    }

    /// <summary>
    /// The start_hour attribute.
    /// </summary>
    public TerraformValue<double>? StartHour
    {
        get => GetArgument<TerraformValue<double>>("start_hour");
        set => SetArgument("start_hour", value);
    }

    /// <summary>
    /// The start_minute attribute.
    /// </summary>
    public TerraformValue<double>? StartMinute
    {
        get => GetArgument<TerraformValue<double>>("start_minute");
        set => SetArgument("start_minute", value);
    }

}


/// <summary>
/// Block type for storage in AzurermMysqlFlexibleServer.
/// Nesting mode: list
/// </summary>
public class AzurermMysqlFlexibleServerStorageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage";

    /// <summary>
    /// The auto_grow_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutoGrowEnabled
    {
        get => GetArgument<TerraformValue<bool>>("auto_grow_enabled");
        set => SetArgument("auto_grow_enabled", value);
    }

    /// <summary>
    /// The io_scaling_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? IoScalingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("io_scaling_enabled");
        set => SetArgument("io_scaling_enabled", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double>? Iops
    {
        get => GetArgument<TerraformValue<double>>("iops");
        set => SetArgument("iops", value);
    }

    /// <summary>
    /// The log_on_disk_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LogOnDiskEnabled
    {
        get => GetArgument<TerraformValue<bool>>("log_on_disk_enabled");
        set => SetArgument("log_on_disk_enabled", value);
    }

    /// <summary>
    /// The size_gb attribute.
    /// </summary>
    public TerraformValue<double>? SizeGb
    {
        get => GetArgument<TerraformValue<double>>("size_gb");
        set => SetArgument("size_gb", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMysqlFlexibleServer.
/// Nesting mode: single
/// </summary>
public class AzurermMysqlFlexibleServerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_mysql_flexible_server Terraform resource.
/// Manages a azurerm_mysql_flexible_server resource.
/// </summary>
public partial class AzurermMysqlFlexibleServer(string name) : TerraformResource("azurerm_mysql_flexible_server", name)
{
    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    public TerraformValue<string>? AdministratorLogin
    {
        get => GetArgument<TerraformValue<string>>("administrator_login");
        set => SetArgument("administrator_login", value);
    }

    /// <summary>
    /// The administrator_password attribute.
    /// </summary>
    public TerraformValue<string>? AdministratorPassword
    {
        get => GetArgument<TerraformValue<string>>("administrator_password");
        set => SetArgument("administrator_password", value);
    }

    /// <summary>
    /// The administrator_password_wo attribute.
    /// </summary>
    public TerraformValue<string>? AdministratorPasswordWo
    {
        get => GetArgument<TerraformValue<string>>("administrator_password_wo");
        set => SetArgument("administrator_password_wo", value);
    }

    /// <summary>
    /// The administrator_password_wo_version attribute.
    /// </summary>
    public TerraformValue<double>? AdministratorPasswordWoVersion
    {
        get => GetArgument<TerraformValue<double>>("administrator_password_wo_version");
        set => SetArgument("administrator_password_wo_version", value);
    }

    /// <summary>
    /// The backup_retention_days attribute.
    /// </summary>
    public TerraformValue<double>? BackupRetentionDays
    {
        get => GetArgument<TerraformValue<double>>("backup_retention_days");
        set => SetArgument("backup_retention_days", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public TerraformValue<string>? CreateMode
    {
        get => GetArgument<TerraformValue<string>>("create_mode");
        set => SetArgument("create_mode", value);
    }

    /// <summary>
    /// The delegated_subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? DelegatedSubnetId
    {
        get => GetArgument<TerraformValue<string>>("delegated_subnet_id");
        set => SetArgument("delegated_subnet_id", value);
    }

    /// <summary>
    /// The geo_redundant_backup_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? GeoRedundantBackupEnabled
    {
        get => GetArgument<TerraformValue<bool>>("geo_redundant_backup_enabled");
        set => SetArgument("geo_redundant_backup_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The point_in_time_restore_time_in_utc attribute.
    /// </summary>
    public TerraformValue<string>? PointInTimeRestoreTimeInUtc
    {
        get => GetArgument<TerraformValue<string>>("point_in_time_restore_time_in_utc");
        set => SetArgument("point_in_time_restore_time_in_utc", value);
    }

    /// <summary>
    /// The private_dns_zone_id attribute.
    /// </summary>
    public TerraformValue<string>? PrivateDnsZoneId
    {
        get => GetArgument<TerraformValue<string>>("private_dns_zone_id");
        set => SetArgument("private_dns_zone_id", value);
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public TerraformValue<string>? PublicNetworkAccess
    {
        get => GetArgument<TerraformValue<string>>("public_network_access");
        set => SetArgument("public_network_access", value);
    }

    /// <summary>
    /// The replication_role attribute.
    /// </summary>
    public TerraformValue<string>? ReplicationRole
    {
        get => GetArgument<TerraformValue<string>>("replication_role");
        set => SetArgument("replication_role", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string>? SkuName
    {
        get => GetArgument<TerraformValue<string>>("sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The source_server_id attribute.
    /// </summary>
    public TerraformValue<string>? SourceServerId
    {
        get => GetArgument<TerraformValue<string>>("source_server_id");
        set => SetArgument("source_server_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => GetArgument<TerraformValue<string>>("zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
        => AsReference("fqdn");

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PublicNetworkAccessEnabled
        => AsReference("public_network_access_enabled");

    /// <summary>
    /// The replica_capacity attribute.
    /// </summary>
    public TerraformValue<double> ReplicaCapacity
        => AsReference("replica_capacity");

    /// <summary>
    /// CustomerManagedKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    public TerraformList<AzurermMysqlFlexibleServerCustomerManagedKeyBlock>? CustomerManagedKey
    {
        get => GetArgument<TerraformList<AzurermMysqlFlexibleServerCustomerManagedKeyBlock>>("customer_managed_key");
        set => SetArgument("customer_managed_key", value);
    }

    /// <summary>
    /// HighAvailability block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HighAvailability block(s) allowed")]
    public TerraformList<AzurermMysqlFlexibleServerHighAvailabilityBlock>? HighAvailability
    {
        get => GetArgument<TerraformList<AzurermMysqlFlexibleServerHighAvailabilityBlock>>("high_availability");
        set => SetArgument("high_availability", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermMysqlFlexibleServerIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermMysqlFlexibleServerIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// MaintenanceWindow block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    public TerraformList<AzurermMysqlFlexibleServerMaintenanceWindowBlock>? MaintenanceWindow
    {
        get => GetArgument<TerraformList<AzurermMysqlFlexibleServerMaintenanceWindowBlock>>("maintenance_window");
        set => SetArgument("maintenance_window", value);
    }

    /// <summary>
    /// Storage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Storage block(s) allowed")]
    public TerraformList<AzurermMysqlFlexibleServerStorageBlock>? Storage
    {
        get => GetArgument<TerraformList<AzurermMysqlFlexibleServerStorageBlock>>("storage");
        set => SetArgument("storage", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMysqlFlexibleServerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMysqlFlexibleServerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
