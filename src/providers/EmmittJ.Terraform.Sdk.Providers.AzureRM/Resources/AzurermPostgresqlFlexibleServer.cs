using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for authentication in .
/// Nesting mode: list
/// </summary>
public class AzurermPostgresqlFlexibleServerAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authentication";

    /// <summary>
    /// The active_directory_auth_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ActiveDirectoryAuthEnabled
    {
        get => new TerraformReference<bool>(this, "active_directory_auth_enabled");
        set => SetArgument("active_directory_auth_enabled", value);
    }

    /// <summary>
    /// The password_auth_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PasswordAuthEnabled
    {
        get => new TerraformReference<bool>(this, "password_auth_enabled");
        set => SetArgument("password_auth_enabled", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string>? TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
        set => SetArgument("tenant_id", value);
    }

}

/// <summary>
/// Block type for customer_managed_key in .
/// Nesting mode: list
/// </summary>
public class AzurermPostgresqlFlexibleServerCustomerManagedKeyBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "geo_backup_key_vault_key_id");
        set => SetArgument("geo_backup_key_vault_key_id", value);
    }

    /// <summary>
    /// The geo_backup_user_assigned_identity_id attribute.
    /// </summary>
    public TerraformValue<string>? GeoBackupUserAssignedIdentityId
    {
        get => new TerraformReference<string>(this, "geo_backup_user_assigned_identity_id");
        set => SetArgument("geo_backup_user_assigned_identity_id", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    public required TerraformValue<string> KeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

    /// <summary>
    /// The primary_user_assigned_identity_id attribute.
    /// </summary>
    public TerraformValue<string>? PrimaryUserAssignedIdentityId
    {
        get => new TerraformReference<string>(this, "primary_user_assigned_identity_id");
        set => SetArgument("primary_user_assigned_identity_id", value);
    }

}

/// <summary>
/// Block type for high_availability in .
/// Nesting mode: list
/// </summary>
public class AzurermPostgresqlFlexibleServerHighAvailabilityBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The standby_availability_zone attribute.
    /// </summary>
    public TerraformValue<string>? StandbyAvailabilityZone
    {
        get => new TerraformReference<string>(this, "standby_availability_zone");
        set => SetArgument("standby_availability_zone", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermPostgresqlFlexibleServerIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class AzurermPostgresqlFlexibleServerMaintenanceWindowBlock : TerraformBlock
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
        get => new TerraformReference<double>(this, "day_of_week");
        set => SetArgument("day_of_week", value);
    }

    /// <summary>
    /// The start_hour attribute.
    /// </summary>
    public TerraformValue<double>? StartHour
    {
        get => new TerraformReference<double>(this, "start_hour");
        set => SetArgument("start_hour", value);
    }

    /// <summary>
    /// The start_minute attribute.
    /// </summary>
    public TerraformValue<double>? StartMinute
    {
        get => new TerraformReference<double>(this, "start_minute");
        set => SetArgument("start_minute", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPostgresqlFlexibleServerTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_postgresql_flexible_server Terraform resource.
/// Manages a azurerm_postgresql_flexible_server resource.
/// </summary>
public partial class AzurermPostgresqlFlexibleServer(string name) : TerraformResource("azurerm_postgresql_flexible_server", name)
{
    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    public TerraformValue<string> AdministratorLogin
    {
        get => new TerraformReference<string>(this, "administrator_login");
        set => SetArgument("administrator_login", value);
    }

    /// <summary>
    /// The administrator_password attribute.
    /// </summary>
    public TerraformValue<string>? AdministratorPassword
    {
        get => new TerraformReference<string>(this, "administrator_password");
        set => SetArgument("administrator_password", value);
    }

    /// <summary>
    /// The administrator_password_wo attribute.
    /// </summary>
    public TerraformValue<string>? AdministratorPasswordWo
    {
        get => new TerraformReference<string>(this, "administrator_password_wo");
        set => SetArgument("administrator_password_wo", value);
    }

    /// <summary>
    /// The administrator_password_wo_version attribute.
    /// </summary>
    public TerraformValue<double>? AdministratorPasswordWoVersion
    {
        get => new TerraformReference<double>(this, "administrator_password_wo_version");
        set => SetArgument("administrator_password_wo_version", value);
    }

    /// <summary>
    /// The auto_grow_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutoGrowEnabled
    {
        get => new TerraformReference<bool>(this, "auto_grow_enabled");
        set => SetArgument("auto_grow_enabled", value);
    }

    /// <summary>
    /// The backup_retention_days attribute.
    /// </summary>
    public TerraformValue<double> BackupRetentionDays
    {
        get => new TerraformReference<double>(this, "backup_retention_days");
        set => SetArgument("backup_retention_days", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public TerraformValue<string>? CreateMode
    {
        get => new TerraformReference<string>(this, "create_mode");
        set => SetArgument("create_mode", value);
    }

    /// <summary>
    /// The delegated_subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? DelegatedSubnetId
    {
        get => new TerraformReference<string>(this, "delegated_subnet_id");
        set => SetArgument("delegated_subnet_id", value);
    }

    /// <summary>
    /// The geo_redundant_backup_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? GeoRedundantBackupEnabled
    {
        get => new TerraformReference<bool>(this, "geo_redundant_backup_enabled");
        set => SetArgument("geo_redundant_backup_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The point_in_time_restore_time_in_utc attribute.
    /// </summary>
    public TerraformValue<string>? PointInTimeRestoreTimeInUtc
    {
        get => new TerraformReference<string>(this, "point_in_time_restore_time_in_utc");
        set => SetArgument("point_in_time_restore_time_in_utc", value);
    }

    /// <summary>
    /// The private_dns_zone_id attribute.
    /// </summary>
    public TerraformValue<string> PrivateDnsZoneId
    {
        get => new TerraformReference<string>(this, "private_dns_zone_id");
        set => SetArgument("private_dns_zone_id", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The replication_role attribute.
    /// </summary>
    public TerraformValue<string>? ReplicationRole
    {
        get => new TerraformReference<string>(this, "replication_role");
        set => SetArgument("replication_role", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The source_server_id attribute.
    /// </summary>
    public TerraformValue<string>? SourceServerId
    {
        get => new TerraformReference<string>(this, "source_server_id");
        set => SetArgument("source_server_id", value);
    }

    /// <summary>
    /// The storage_mb attribute.
    /// </summary>
    public TerraformValue<double> StorageMb
    {
        get => new TerraformReference<double>(this, "storage_mb");
        set => SetArgument("storage_mb", value);
    }

    /// <summary>
    /// The storage_tier attribute.
    /// </summary>
    public TerraformValue<string> StorageTier
    {
        get => new TerraformReference<string>(this, "storage_tier");
        set => SetArgument("storage_tier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

    /// <summary>
    /// Authentication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authentication block(s) allowed")]
    public TerraformList<AzurermPostgresqlFlexibleServerAuthenticationBlock>? Authentication
    {
        get => GetArgument<TerraformList<AzurermPostgresqlFlexibleServerAuthenticationBlock>>("authentication");
        set => SetArgument("authentication", value);
    }

    /// <summary>
    /// CustomerManagedKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    public TerraformList<AzurermPostgresqlFlexibleServerCustomerManagedKeyBlock>? CustomerManagedKey
    {
        get => GetArgument<TerraformList<AzurermPostgresqlFlexibleServerCustomerManagedKeyBlock>>("customer_managed_key");
        set => SetArgument("customer_managed_key", value);
    }

    /// <summary>
    /// HighAvailability block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HighAvailability block(s) allowed")]
    public TerraformList<AzurermPostgresqlFlexibleServerHighAvailabilityBlock>? HighAvailability
    {
        get => GetArgument<TerraformList<AzurermPostgresqlFlexibleServerHighAvailabilityBlock>>("high_availability");
        set => SetArgument("high_availability", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermPostgresqlFlexibleServerIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermPostgresqlFlexibleServerIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// MaintenanceWindow block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    public TerraformList<AzurermPostgresqlFlexibleServerMaintenanceWindowBlock>? MaintenanceWindow
    {
        get => GetArgument<TerraformList<AzurermPostgresqlFlexibleServerMaintenanceWindowBlock>>("maintenance_window");
        set => SetArgument("maintenance_window", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPostgresqlFlexibleServerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPostgresqlFlexibleServerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
