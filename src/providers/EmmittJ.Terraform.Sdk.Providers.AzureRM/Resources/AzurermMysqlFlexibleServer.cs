using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for customer_managed_key in .
/// Nesting mode: list
/// </summary>
public class AzurermMysqlFlexibleServerCustomerManagedKeyBlock : TerraformBlock
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
    public TerraformProperty<string>? KeyVaultKeyId
    {
        set => SetProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedHsmKeyId
    {
        set => SetProperty("managed_hsm_key_id", value);
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
public class AzurermMysqlFlexibleServerHighAvailabilityBlock : TerraformBlock
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
public class AzurermMysqlFlexibleServerIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        set => SetProperty("identity_ids", value);
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
public class AzurermMysqlFlexibleServerMaintenanceWindowBlock : TerraformBlock
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
/// Block type for storage in .
/// Nesting mode: list
/// </summary>
public class AzurermMysqlFlexibleServerStorageBlock : TerraformBlock
{
    /// <summary>
    /// The auto_grow_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoGrowEnabled
    {
        set => SetProperty("auto_grow_enabled", value);
    }

    /// <summary>
    /// The io_scaling_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? IoScalingEnabled
    {
        set => SetProperty("io_scaling_enabled", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformProperty<double>? Iops
    {
        set => SetProperty("iops", value);
    }

    /// <summary>
    /// The log_on_disk_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LogOnDiskEnabled
    {
        set => SetProperty("log_on_disk_enabled", value);
    }

    /// <summary>
    /// The size_gb attribute.
    /// </summary>
    public TerraformProperty<double>? SizeGb
    {
        set => SetProperty("size_gb", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMysqlFlexibleServerTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_mysql_flexible_server resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMysqlFlexibleServer : TerraformResource
{
    public AzurermMysqlFlexibleServer(string name) : base("azurerm_mysql_flexible_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("fqdn");
        SetOutput("public_network_access_enabled");
        SetOutput("replica_capacity");
        SetOutput("administrator_login");
        SetOutput("administrator_password");
        SetOutput("administrator_password_wo");
        SetOutput("administrator_password_wo_version");
        SetOutput("backup_retention_days");
        SetOutput("create_mode");
        SetOutput("delegated_subnet_id");
        SetOutput("geo_redundant_backup_enabled");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("point_in_time_restore_time_in_utc");
        SetOutput("private_dns_zone_id");
        SetOutput("public_network_access");
        SetOutput("replication_role");
        SetOutput("resource_group_name");
        SetOutput("sku_name");
        SetOutput("source_server_id");
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
    /// The public_network_access attribute.
    /// </summary>
    public TerraformProperty<string> PublicNetworkAccess
    {
        get => GetRequiredOutput<TerraformProperty<string>>("public_network_access");
        set => SetProperty("public_network_access", value);
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
    /// Block for customer_managed_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    public List<AzurermMysqlFlexibleServerCustomerManagedKeyBlock>? CustomerManagedKey
    {
        set => SetProperty("customer_managed_key", value);
    }

    /// <summary>
    /// Block for high_availability.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HighAvailability block(s) allowed")]
    public List<AzurermMysqlFlexibleServerHighAvailabilityBlock>? HighAvailability
    {
        set => SetProperty("high_availability", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermMysqlFlexibleServerIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    public List<AzurermMysqlFlexibleServerMaintenanceWindowBlock>? MaintenanceWindow
    {
        set => SetProperty("maintenance_window", value);
    }

    /// <summary>
    /// Block for storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Storage block(s) allowed")]
    public List<AzurermMysqlFlexibleServerStorageBlock>? Storage
    {
        set => SetProperty("storage", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMysqlFlexibleServerTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformExpression PublicNetworkAccessEnabled => this["public_network_access_enabled"];

    /// <summary>
    /// The replica_capacity attribute.
    /// </summary>
    public TerraformExpression ReplicaCapacity => this["replica_capacity"];

}
