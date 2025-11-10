using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for authentication in .
/// Nesting mode: list
/// </summary>
public class AzurermPostgresqlFlexibleServerAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// The active_directory_auth_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ActiveDirectoryAuthEnabled
    {
        set => SetProperty("active_directory_auth_enabled", value);
    }

    /// <summary>
    /// The password_auth_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PasswordAuthEnabled
    {
        set => SetProperty("password_auth_enabled", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

}

/// <summary>
/// Block type for customer_managed_key in .
/// Nesting mode: list
/// </summary>
public class AzurermPostgresqlFlexibleServerCustomerManagedKeyBlock : TerraformBlock
{
    /// <summary>
    /// The geo_backup_key_vault_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? GeoBackupKeyVaultKeyId
    {
        set => SetProperty("geo_backup_key_vault_key_id", value);
    }

    /// <summary>
    /// The geo_backup_user_assigned_identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? GeoBackupUserAssignedIdentityId
    {
        set => SetProperty("geo_backup_user_assigned_identity_id", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    public required TerraformProperty<string> KeyVaultKeyId
    {
        set => SetProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The primary_user_assigned_identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrimaryUserAssignedIdentityId
    {
        set => SetProperty("primary_user_assigned_identity_id", value);
    }

}

/// <summary>
/// Block type for high_availability in .
/// Nesting mode: list
/// </summary>
public class AzurermPostgresqlFlexibleServerHighAvailabilityBlock : TerraformBlock
{
    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformProperty<string> Mode
    {
        set => SetProperty("mode", value);
    }

    /// <summary>
    /// The standby_availability_zone attribute.
    /// </summary>
    public TerraformProperty<string>? StandbyAvailabilityZone
    {
        set => SetProperty("standby_availability_zone", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermPostgresqlFlexibleServerIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class AzurermPostgresqlFlexibleServerMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    public TerraformProperty<double>? DayOfWeek
    {
        set => SetProperty("day_of_week", value);
    }

    /// <summary>
    /// The start_hour attribute.
    /// </summary>
    public TerraformProperty<double>? StartHour
    {
        set => SetProperty("start_hour", value);
    }

    /// <summary>
    /// The start_minute attribute.
    /// </summary>
    public TerraformProperty<double>? StartMinute
    {
        set => SetProperty("start_minute", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPostgresqlFlexibleServerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("fqdn");
        SetOutput("administrator_login");
        SetOutput("administrator_password");
        SetOutput("administrator_password_wo");
        SetOutput("administrator_password_wo_version");
        SetOutput("auto_grow_enabled");
        SetOutput("backup_retention_days");
        SetOutput("create_mode");
        SetOutput("delegated_subnet_id");
        SetOutput("geo_redundant_backup_enabled");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("point_in_time_restore_time_in_utc");
        SetOutput("private_dns_zone_id");
        SetOutput("public_network_access_enabled");
        SetOutput("replication_role");
        SetOutput("resource_group_name");
        SetOutput("sku_name");
        SetOutput("source_server_id");
        SetOutput("storage_mb");
        SetOutput("storage_tier");
        SetOutput("tags");
        SetOutput("version");
        SetOutput("zone");
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    public TerraformProperty<string> AdministratorLogin
    {
        get => GetRequiredOutput<TerraformProperty<string>>("administrator_login");
        set => SetProperty("administrator_login", value);
    }

    /// <summary>
    /// The administrator_password attribute.
    /// </summary>
    public TerraformProperty<string> AdministratorPassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("administrator_password");
        set => SetProperty("administrator_password", value);
    }

    /// <summary>
    /// The administrator_password_wo attribute.
    /// </summary>
    public TerraformProperty<string> AdministratorPasswordWo
    {
        get => GetRequiredOutput<TerraformProperty<string>>("administrator_password_wo");
        set => SetProperty("administrator_password_wo", value);
    }

    /// <summary>
    /// The administrator_password_wo_version attribute.
    /// </summary>
    public TerraformProperty<double> AdministratorPasswordWoVersion
    {
        get => GetRequiredOutput<TerraformProperty<double>>("administrator_password_wo_version");
        set => SetProperty("administrator_password_wo_version", value);
    }

    /// <summary>
    /// The auto_grow_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AutoGrowEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_grow_enabled");
        set => SetProperty("auto_grow_enabled", value);
    }

    /// <summary>
    /// The backup_retention_days attribute.
    /// </summary>
    public TerraformProperty<double> BackupRetentionDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("backup_retention_days");
        set => SetProperty("backup_retention_days", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public TerraformProperty<string> CreateMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("create_mode");
        set => SetProperty("create_mode", value);
    }

    /// <summary>
    /// The delegated_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string> DelegatedSubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("delegated_subnet_id");
        set => SetProperty("delegated_subnet_id", value);
    }

    /// <summary>
    /// The geo_redundant_backup_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> GeoRedundantBackupEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("geo_redundant_backup_enabled");
        set => SetProperty("geo_redundant_backup_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The point_in_time_restore_time_in_utc attribute.
    /// </summary>
    public TerraformProperty<string> PointInTimeRestoreTimeInUtc
    {
        get => GetRequiredOutput<TerraformProperty<string>>("point_in_time_restore_time_in_utc");
        set => SetProperty("point_in_time_restore_time_in_utc", value);
    }

    /// <summary>
    /// The private_dns_zone_id attribute.
    /// </summary>
    public TerraformProperty<string> PrivateDnsZoneId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("private_dns_zone_id");
        set => SetProperty("private_dns_zone_id", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PublicNetworkAccessEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("public_network_access_enabled");
        set => SetProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The replication_role attribute.
    /// </summary>
    public TerraformProperty<string> ReplicationRole
    {
        get => GetRequiredOutput<TerraformProperty<string>>("replication_role");
        set => SetProperty("replication_role", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string> SkuName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku_name");
        set => SetProperty("sku_name", value);
    }

    /// <summary>
    /// The source_server_id attribute.
    /// </summary>
    public TerraformProperty<string> SourceServerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_server_id");
        set => SetProperty("source_server_id", value);
    }

    /// <summary>
    /// The storage_mb attribute.
    /// </summary>
    public TerraformProperty<double> StorageMb
    {
        get => GetRequiredOutput<TerraformProperty<double>>("storage_mb");
        set => SetProperty("storage_mb", value);
    }

    /// <summary>
    /// The storage_tier attribute.
    /// </summary>
    public TerraformProperty<string> StorageTier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_tier");
        set => SetProperty("storage_tier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformProperty<string> Zone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zone");
        set => SetProperty("zone", value);
    }

    /// <summary>
    /// Block for authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authentication block(s) allowed")]
    public List<AzurermPostgresqlFlexibleServerAuthenticationBlock>? Authentication
    {
        set => SetProperty("authentication", value);
    }

    /// <summary>
    /// Block for customer_managed_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    public List<AzurermPostgresqlFlexibleServerCustomerManagedKeyBlock>? CustomerManagedKey
    {
        set => SetProperty("customer_managed_key", value);
    }

    /// <summary>
    /// Block for high_availability.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HighAvailability block(s) allowed")]
    public List<AzurermPostgresqlFlexibleServerHighAvailabilityBlock>? HighAvailability
    {
        set => SetProperty("high_availability", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermPostgresqlFlexibleServerIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    public List<AzurermPostgresqlFlexibleServerMaintenanceWindowBlock>? MaintenanceWindow
    {
        set => SetProperty("maintenance_window", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPostgresqlFlexibleServerTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

}
