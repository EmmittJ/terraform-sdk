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
        get => GetProperty<TerraformProperty<string>>("geo_backup_key_vault_key_id");
        set => WithProperty("geo_backup_key_vault_key_id", value);
    }

    /// <summary>
    /// The geo_backup_user_assigned_identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? GeoBackupUserAssignedIdentityId
    {
        get => GetProperty<TerraformProperty<string>>("geo_backup_user_assigned_identity_id");
        set => WithProperty("geo_backup_user_assigned_identity_id", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultKeyId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_key_id");
        set => WithProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedHsmKeyId
    {
        get => GetProperty<TerraformProperty<string>>("managed_hsm_key_id");
        set => WithProperty("managed_hsm_key_id", value);
    }

    /// <summary>
    /// The primary_user_assigned_identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrimaryUserAssignedIdentityId
    {
        get => GetProperty<TerraformProperty<string>>("primary_user_assigned_identity_id");
        set => WithProperty("primary_user_assigned_identity_id", value);
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
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

    /// <summary>
    /// The standby_availability_zone attribute.
    /// </summary>
    public TerraformProperty<string>? StandbyAvailabilityZone
    {
        get => GetProperty<TerraformProperty<string>>("standby_availability_zone");
        set => WithProperty("standby_availability_zone", value);
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
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
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
        get => GetProperty<TerraformProperty<double>>("day_of_week");
        set => WithProperty("day_of_week", value);
    }

    /// <summary>
    /// The start_hour attribute.
    /// </summary>
    public TerraformProperty<double>? StartHour
    {
        get => GetProperty<TerraformProperty<double>>("start_hour");
        set => WithProperty("start_hour", value);
    }

    /// <summary>
    /// The start_minute attribute.
    /// </summary>
    public TerraformProperty<double>? StartMinute
    {
        get => GetProperty<TerraformProperty<double>>("start_minute");
        set => WithProperty("start_minute", value);
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
        get => GetProperty<TerraformProperty<bool>>("auto_grow_enabled");
        set => WithProperty("auto_grow_enabled", value);
    }

    /// <summary>
    /// The io_scaling_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? IoScalingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("io_scaling_enabled");
        set => WithProperty("io_scaling_enabled", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformProperty<double>? Iops
    {
        get => GetProperty<TerraformProperty<double>>("iops");
        set => WithProperty("iops", value);
    }

    /// <summary>
    /// The log_on_disk_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LogOnDiskEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("log_on_disk_enabled");
        set => WithProperty("log_on_disk_enabled", value);
    }

    /// <summary>
    /// The size_gb attribute.
    /// </summary>
    public TerraformProperty<double>? SizeGb
    {
        get => GetProperty<TerraformProperty<double>>("size_gb");
        set => WithProperty("size_gb", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_mysql_flexible_server resource.
/// </summary>
public class AzurermMysqlFlexibleServer : TerraformResource
{
    public AzurermMysqlFlexibleServer(string name) : base("azurerm_mysql_flexible_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("fqdn");
        this.DeclareOutput("public_network_access_enabled");
        this.DeclareOutput("replica_capacity");
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    public TerraformProperty<string>? AdministratorLogin
    {
        get => GetProperty<TerraformProperty<string>>("administrator_login");
        set => this.WithProperty("administrator_login", value);
    }

    /// <summary>
    /// The administrator_password attribute.
    /// </summary>
    public TerraformProperty<string>? AdministratorPassword
    {
        get => GetProperty<TerraformProperty<string>>("administrator_password");
        set => this.WithProperty("administrator_password", value);
    }

    /// <summary>
    /// The administrator_password_wo attribute.
    /// </summary>
    public TerraformProperty<string>? AdministratorPasswordWo
    {
        get => GetProperty<TerraformProperty<string>>("administrator_password_wo");
        set => this.WithProperty("administrator_password_wo", value);
    }

    /// <summary>
    /// The administrator_password_wo_version attribute.
    /// </summary>
    public TerraformProperty<double>? AdministratorPasswordWoVersion
    {
        get => GetProperty<TerraformProperty<double>>("administrator_password_wo_version");
        set => this.WithProperty("administrator_password_wo_version", value);
    }

    /// <summary>
    /// The backup_retention_days attribute.
    /// </summary>
    public TerraformProperty<double>? BackupRetentionDays
    {
        get => GetProperty<TerraformProperty<double>>("backup_retention_days");
        set => this.WithProperty("backup_retention_days", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public TerraformProperty<string>? CreateMode
    {
        get => GetProperty<TerraformProperty<string>>("create_mode");
        set => this.WithProperty("create_mode", value);
    }

    /// <summary>
    /// The delegated_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? DelegatedSubnetId
    {
        get => GetProperty<TerraformProperty<string>>("delegated_subnet_id");
        set => this.WithProperty("delegated_subnet_id", value);
    }

    /// <summary>
    /// The geo_redundant_backup_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? GeoRedundantBackupEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("geo_redundant_backup_enabled");
        set => this.WithProperty("geo_redundant_backup_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The point_in_time_restore_time_in_utc attribute.
    /// </summary>
    public TerraformProperty<string>? PointInTimeRestoreTimeInUtc
    {
        get => GetProperty<TerraformProperty<string>>("point_in_time_restore_time_in_utc");
        set => this.WithProperty("point_in_time_restore_time_in_utc", value);
    }

    /// <summary>
    /// The private_dns_zone_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateDnsZoneId
    {
        get => GetProperty<TerraformProperty<string>>("private_dns_zone_id");
        set => this.WithProperty("private_dns_zone_id", value);
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public TerraformProperty<string>? PublicNetworkAccess
    {
        get => GetProperty<TerraformProperty<string>>("public_network_access");
        set => this.WithProperty("public_network_access", value);
    }

    /// <summary>
    /// The replication_role attribute.
    /// </summary>
    public TerraformProperty<string>? ReplicationRole
    {
        get => GetProperty<TerraformProperty<string>>("replication_role");
        set => this.WithProperty("replication_role", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string>? SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The source_server_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceServerId
    {
        get => GetProperty<TerraformProperty<string>>("source_server_id");
        set => this.WithProperty("source_server_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

    /// <summary>
    /// Block for customer_managed_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    public List<AzurermMysqlFlexibleServerCustomerManagedKeyBlock>? CustomerManagedKey
    {
        get => GetProperty<List<AzurermMysqlFlexibleServerCustomerManagedKeyBlock>>("customer_managed_key");
        set => this.WithProperty("customer_managed_key", value);
    }

    /// <summary>
    /// Block for high_availability.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HighAvailability block(s) allowed")]
    public List<AzurermMysqlFlexibleServerHighAvailabilityBlock>? HighAvailability
    {
        get => GetProperty<List<AzurermMysqlFlexibleServerHighAvailabilityBlock>>("high_availability");
        set => this.WithProperty("high_availability", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermMysqlFlexibleServerIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermMysqlFlexibleServerIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    public List<AzurermMysqlFlexibleServerMaintenanceWindowBlock>? MaintenanceWindow
    {
        get => GetProperty<List<AzurermMysqlFlexibleServerMaintenanceWindowBlock>>("maintenance_window");
        set => this.WithProperty("maintenance_window", value);
    }

    /// <summary>
    /// Block for storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Storage block(s) allowed")]
    public List<AzurermMysqlFlexibleServerStorageBlock>? Storage
    {
        get => GetProperty<List<AzurermMysqlFlexibleServerStorageBlock>>("storage");
        set => this.WithProperty("storage", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMysqlFlexibleServerTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMysqlFlexibleServerTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
