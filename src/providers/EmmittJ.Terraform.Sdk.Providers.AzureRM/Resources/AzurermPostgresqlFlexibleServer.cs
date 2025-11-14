using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("active_directory_auth_enabled")]
    public TerraformValue<bool>? ActiveDirectoryAuthEnabled
    {
        get => new TerraformReference<bool>(this, "active_directory_auth_enabled");
        set => SetArgument("active_directory_auth_enabled", value);
    }

    /// <summary>
    /// The password_auth_enabled attribute.
    /// </summary>
    [TerraformArgument("password_auth_enabled")]
    public TerraformValue<bool>? PasswordAuthEnabled
    {
        get => new TerraformReference<bool>(this, "password_auth_enabled");
        set => SetArgument("password_auth_enabled", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformArgument("tenant_id")]
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
    [TerraformArgument("geo_backup_key_vault_key_id")]
    public TerraformValue<string>? GeoBackupKeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "geo_backup_key_vault_key_id");
        set => SetArgument("geo_backup_key_vault_key_id", value);
    }

    /// <summary>
    /// The geo_backup_user_assigned_identity_id attribute.
    /// </summary>
    [TerraformArgument("geo_backup_user_assigned_identity_id")]
    public TerraformValue<string>? GeoBackupUserAssignedIdentityId
    {
        get => new TerraformReference<string>(this, "geo_backup_user_assigned_identity_id");
        set => SetArgument("geo_backup_user_assigned_identity_id", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    [TerraformArgument("key_vault_key_id")]
    public required TerraformValue<string> KeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

    /// <summary>
    /// The primary_user_assigned_identity_id attribute.
    /// </summary>
    [TerraformArgument("primary_user_assigned_identity_id")]
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
    [TerraformArgument("mode")]
    public required TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The standby_availability_zone attribute.
    /// </summary>
    [TerraformArgument("standby_availability_zone")]
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
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
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
    [TerraformArgument("day_of_week")]
    public TerraformValue<double>? DayOfWeek
    {
        get => new TerraformReference<double>(this, "day_of_week");
        set => SetArgument("day_of_week", value);
    }

    /// <summary>
    /// The start_hour attribute.
    /// </summary>
    [TerraformArgument("start_hour")]
    public TerraformValue<double>? StartHour
    {
        get => new TerraformReference<double>(this, "start_hour");
        set => SetArgument("start_hour", value);
    }

    /// <summary>
    /// The start_minute attribute.
    /// </summary>
    [TerraformArgument("start_minute")]
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_postgresql_flexible_server resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermPostgresqlFlexibleServer : TerraformResource
{
    public AzurermPostgresqlFlexibleServer(string name) : base("azurerm_postgresql_flexible_server", name)
    {
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [TerraformArgument("administrator_login")]
    public TerraformValue<string> AdministratorLogin
    {
        get => new TerraformReference<string>(this, "administrator_login");
        set => SetArgument("administrator_login", value);
    }

    /// <summary>
    /// The administrator_password attribute.
    /// </summary>
    [TerraformArgument("administrator_password")]
    public TerraformValue<string>? AdministratorPassword
    {
        get => new TerraformReference<string>(this, "administrator_password");
        set => SetArgument("administrator_password", value);
    }

    /// <summary>
    /// The administrator_password_wo attribute.
    /// </summary>
    [TerraformArgument("administrator_password_wo")]
    public TerraformValue<string>? AdministratorPasswordWo
    {
        get => new TerraformReference<string>(this, "administrator_password_wo");
        set => SetArgument("administrator_password_wo", value);
    }

    /// <summary>
    /// The administrator_password_wo_version attribute.
    /// </summary>
    [TerraformArgument("administrator_password_wo_version")]
    public TerraformValue<double>? AdministratorPasswordWoVersion
    {
        get => new TerraformReference<double>(this, "administrator_password_wo_version");
        set => SetArgument("administrator_password_wo_version", value);
    }

    /// <summary>
    /// The auto_grow_enabled attribute.
    /// </summary>
    [TerraformArgument("auto_grow_enabled")]
    public TerraformValue<bool>? AutoGrowEnabled
    {
        get => new TerraformReference<bool>(this, "auto_grow_enabled");
        set => SetArgument("auto_grow_enabled", value);
    }

    /// <summary>
    /// The backup_retention_days attribute.
    /// </summary>
    [TerraformArgument("backup_retention_days")]
    public TerraformValue<double> BackupRetentionDays
    {
        get => new TerraformReference<double>(this, "backup_retention_days");
        set => SetArgument("backup_retention_days", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    [TerraformArgument("create_mode")]
    public TerraformValue<string>? CreateMode
    {
        get => new TerraformReference<string>(this, "create_mode");
        set => SetArgument("create_mode", value);
    }

    /// <summary>
    /// The delegated_subnet_id attribute.
    /// </summary>
    [TerraformArgument("delegated_subnet_id")]
    public TerraformValue<string>? DelegatedSubnetId
    {
        get => new TerraformReference<string>(this, "delegated_subnet_id");
        set => SetArgument("delegated_subnet_id", value);
    }

    /// <summary>
    /// The geo_redundant_backup_enabled attribute.
    /// </summary>
    [TerraformArgument("geo_redundant_backup_enabled")]
    public TerraformValue<bool>? GeoRedundantBackupEnabled
    {
        get => new TerraformReference<bool>(this, "geo_redundant_backup_enabled");
        set => SetArgument("geo_redundant_backup_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The point_in_time_restore_time_in_utc attribute.
    /// </summary>
    [TerraformArgument("point_in_time_restore_time_in_utc")]
    public TerraformValue<string>? PointInTimeRestoreTimeInUtc
    {
        get => new TerraformReference<string>(this, "point_in_time_restore_time_in_utc");
        set => SetArgument("point_in_time_restore_time_in_utc", value);
    }

    /// <summary>
    /// The private_dns_zone_id attribute.
    /// </summary>
    [TerraformArgument("private_dns_zone_id")]
    public TerraformValue<string> PrivateDnsZoneId
    {
        get => new TerraformReference<string>(this, "private_dns_zone_id");
        set => SetArgument("private_dns_zone_id", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The replication_role attribute.
    /// </summary>
    [TerraformArgument("replication_role")]
    public TerraformValue<string>? ReplicationRole
    {
        get => new TerraformReference<string>(this, "replication_role");
        set => SetArgument("replication_role", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformArgument("sku_name")]
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The source_server_id attribute.
    /// </summary>
    [TerraformArgument("source_server_id")]
    public TerraformValue<string>? SourceServerId
    {
        get => new TerraformReference<string>(this, "source_server_id");
        set => SetArgument("source_server_id", value);
    }

    /// <summary>
    /// The storage_mb attribute.
    /// </summary>
    [TerraformArgument("storage_mb")]
    public TerraformValue<double> StorageMb
    {
        get => new TerraformReference<double>(this, "storage_mb");
        set => SetArgument("storage_mb", value);
    }

    /// <summary>
    /// The storage_tier attribute.
    /// </summary>
    [TerraformArgument("storage_tier")]
    public TerraformValue<string> StorageTier
    {
        get => new TerraformReference<string>(this, "storage_tier");
        set => SetArgument("storage_tier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformArgument("version")]
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    [TerraformArgument("zone")]
    public TerraformValue<string>? Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// Block for authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authentication block(s) allowed")]
    [TerraformArgument("authentication")]
    public TerraformList<AzurermPostgresqlFlexibleServerAuthenticationBlock> Authentication { get; set; } = new();

    /// <summary>
    /// Block for customer_managed_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    [TerraformArgument("customer_managed_key")]
    public TerraformList<AzurermPostgresqlFlexibleServerCustomerManagedKeyBlock> CustomerManagedKey { get; set; } = new();

    /// <summary>
    /// Block for high_availability.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HighAvailability block(s) allowed")]
    [TerraformArgument("high_availability")]
    public TerraformList<AzurermPostgresqlFlexibleServerHighAvailabilityBlock> HighAvailability { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermPostgresqlFlexibleServerIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    [TerraformArgument("maintenance_window")]
    public TerraformList<AzurermPostgresqlFlexibleServerMaintenanceWindowBlock> MaintenanceWindow { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermPostgresqlFlexibleServerTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformArgument("fqdn")]
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

}
