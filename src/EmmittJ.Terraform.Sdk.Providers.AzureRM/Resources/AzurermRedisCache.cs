using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermRedisCacheIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
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
/// Block type for patch_schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermRedisCachePatchScheduleBlock : TerraformBlock
{
    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    public required TerraformProperty<string> DayOfWeek
    {
        get => GetProperty<TerraformProperty<string>>("day_of_week");
        set => WithProperty("day_of_week", value);
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string>? MaintenanceWindow
    {
        get => GetProperty<TerraformProperty<string>>("maintenance_window");
        set => WithProperty("maintenance_window", value);
    }

    /// <summary>
    /// The start_hour_utc attribute.
    /// </summary>
    public TerraformProperty<double>? StartHourUtc
    {
        get => GetProperty<TerraformProperty<double>>("start_hour_utc");
        set => WithProperty("start_hour_utc", value);
    }

}

/// <summary>
/// Block type for redis_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermRedisCacheRedisConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The active_directory_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ActiveDirectoryAuthenticationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("active_directory_authentication_enabled");
        set => WithProperty("active_directory_authentication_enabled", value);
    }

    /// <summary>
    /// The aof_backup_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AofBackupEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("aof_backup_enabled");
        set => WithProperty("aof_backup_enabled", value);
    }

    /// <summary>
    /// The aof_storage_connection_string_0 attribute.
    /// </summary>
    public TerraformProperty<string>? AofStorageConnectionString0
    {
        get => GetProperty<TerraformProperty<string>>("aof_storage_connection_string_0");
        set => WithProperty("aof_storage_connection_string_0", value);
    }

    /// <summary>
    /// The aof_storage_connection_string_1 attribute.
    /// </summary>
    public TerraformProperty<string>? AofStorageConnectionString1
    {
        get => GetProperty<TerraformProperty<string>>("aof_storage_connection_string_1");
        set => WithProperty("aof_storage_connection_string_1", value);
    }

    /// <summary>
    /// The authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AuthenticationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("authentication_enabled");
        set => WithProperty("authentication_enabled", value);
    }

    /// <summary>
    /// The data_persistence_authentication_method attribute.
    /// </summary>
    public TerraformProperty<string>? DataPersistenceAuthenticationMethod
    {
        get => GetProperty<TerraformProperty<string>>("data_persistence_authentication_method");
        set => WithProperty("data_persistence_authentication_method", value);
    }

    /// <summary>
    /// The maxclients attribute.
    /// </summary>
    public TerraformProperty<double>? Maxclients
    {
        get => GetProperty<TerraformProperty<double>>("maxclients");
        set => WithProperty("maxclients", value);
    }

    /// <summary>
    /// The maxfragmentationmemory_reserved attribute.
    /// </summary>
    public TerraformProperty<double>? MaxfragmentationmemoryReserved
    {
        get => GetProperty<TerraformProperty<double>>("maxfragmentationmemory_reserved");
        set => WithProperty("maxfragmentationmemory_reserved", value);
    }

    /// <summary>
    /// The maxmemory_delta attribute.
    /// </summary>
    public TerraformProperty<double>? MaxmemoryDelta
    {
        get => GetProperty<TerraformProperty<double>>("maxmemory_delta");
        set => WithProperty("maxmemory_delta", value);
    }

    /// <summary>
    /// The maxmemory_policy attribute.
    /// </summary>
    public TerraformProperty<string>? MaxmemoryPolicy
    {
        get => GetProperty<TerraformProperty<string>>("maxmemory_policy");
        set => WithProperty("maxmemory_policy", value);
    }

    /// <summary>
    /// The maxmemory_reserved attribute.
    /// </summary>
    public TerraformProperty<double>? MaxmemoryReserved
    {
        get => GetProperty<TerraformProperty<double>>("maxmemory_reserved");
        set => WithProperty("maxmemory_reserved", value);
    }

    /// <summary>
    /// The notify_keyspace_events attribute.
    /// </summary>
    public TerraformProperty<string>? NotifyKeyspaceEvents
    {
        get => GetProperty<TerraformProperty<string>>("notify_keyspace_events");
        set => WithProperty("notify_keyspace_events", value);
    }

    /// <summary>
    /// The rdb_backup_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RdbBackupEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("rdb_backup_enabled");
        set => WithProperty("rdb_backup_enabled", value);
    }

    /// <summary>
    /// The rdb_backup_frequency attribute.
    /// </summary>
    public TerraformProperty<double>? RdbBackupFrequency
    {
        get => GetProperty<TerraformProperty<double>>("rdb_backup_frequency");
        set => WithProperty("rdb_backup_frequency", value);
    }

    /// <summary>
    /// The rdb_backup_max_snapshot_count attribute.
    /// </summary>
    public TerraformProperty<double>? RdbBackupMaxSnapshotCount
    {
        get => GetProperty<TerraformProperty<double>>("rdb_backup_max_snapshot_count");
        set => WithProperty("rdb_backup_max_snapshot_count", value);
    }

    /// <summary>
    /// The rdb_storage_connection_string attribute.
    /// </summary>
    public TerraformProperty<string>? RdbStorageConnectionString
    {
        get => GetProperty<TerraformProperty<string>>("rdb_storage_connection_string");
        set => WithProperty("rdb_storage_connection_string", value);
    }

    /// <summary>
    /// The storage_account_subscription_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountSubscriptionId
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_subscription_id");
        set => WithProperty("storage_account_subscription_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRedisCacheTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_redis_cache resource.
/// </summary>
public class AzurermRedisCache : TerraformResource
{
    public AzurermRedisCache(string name) : base("azurerm_redis_cache", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("hostname");
        this.DeclareOutput("port");
        this.DeclareOutput("primary_access_key");
        this.DeclareOutput("primary_connection_string");
        this.DeclareOutput("secondary_access_key");
        this.DeclareOutput("secondary_connection_string");
        this.DeclareOutput("ssl_port");
    }

    /// <summary>
    /// The access_keys_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AccessKeysAuthenticationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("access_keys_authentication_enabled");
        set => this.WithProperty("access_keys_authentication_enabled", value);
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    public required TerraformProperty<double> Capacity
    {
        get => GetProperty<TerraformProperty<double>>("capacity");
        set => this.WithProperty("capacity", value);
    }

    /// <summary>
    /// The family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Family is required")]
    public required TerraformProperty<string> Family
    {
        get => GetProperty<TerraformProperty<string>>("family");
        set => this.WithProperty("family", value);
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
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformProperty<string>? MinimumTlsVersion
    {
        get => GetProperty<TerraformProperty<string>>("minimum_tls_version");
        set => this.WithProperty("minimum_tls_version", value);
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
    /// The non_ssl_port_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? NonSslPortEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("non_ssl_port_enabled");
        set => this.WithProperty("non_ssl_port_enabled", value);
    }

    /// <summary>
    /// The private_static_ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateStaticIpAddress
    {
        get => GetProperty<TerraformProperty<string>>("private_static_ip_address");
        set => this.WithProperty("private_static_ip_address", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The redis_version attribute.
    /// </summary>
    public TerraformProperty<string>? RedisVersion
    {
        get => GetProperty<TerraformProperty<string>>("redis_version");
        set => this.WithProperty("redis_version", value);
    }

    /// <summary>
    /// The replicas_per_master attribute.
    /// </summary>
    public TerraformProperty<double>? ReplicasPerMaster
    {
        get => GetProperty<TerraformProperty<double>>("replicas_per_master");
        set => this.WithProperty("replicas_per_master", value);
    }

    /// <summary>
    /// The replicas_per_primary attribute.
    /// </summary>
    public TerraformProperty<double>? ReplicasPerPrimary
    {
        get => GetProperty<TerraformProperty<double>>("replicas_per_primary");
        set => this.WithProperty("replicas_per_primary", value);
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
    /// The shard_count attribute.
    /// </summary>
    public TerraformProperty<double>? ShardCount
    {
        get => GetProperty<TerraformProperty<double>>("shard_count");
        set => this.WithProperty("shard_count", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformProperty<string> SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
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
    /// The tenant_settings attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TenantSettings
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tenant_settings");
        set => this.WithProperty("tenant_settings", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Zones
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermRedisCacheIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermRedisCacheIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for patch_schedule.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermRedisCachePatchScheduleBlock>? PatchSchedule
    {
        get => GetProperty<List<AzurermRedisCachePatchScheduleBlock>>("patch_schedule");
        set => this.WithProperty("patch_schedule", value);
    }

    /// <summary>
    /// Block for redis_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedisConfiguration block(s) allowed")]
    public List<AzurermRedisCacheRedisConfigurationBlock>? RedisConfiguration
    {
        get => GetProperty<List<AzurermRedisCacheRedisConfigurationBlock>>("redis_configuration");
        set => this.WithProperty("redis_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermRedisCacheTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermRedisCacheTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformExpression Hostname => this["hostname"];

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformExpression Port => this["port"];

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformExpression PrimaryAccessKey => this["primary_access_key"];

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    public TerraformExpression PrimaryConnectionString => this["primary_connection_string"];

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformExpression SecondaryAccessKey => this["secondary_access_key"];

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    public TerraformExpression SecondaryConnectionString => this["secondary_connection_string"];

    /// <summary>
    /// The ssl_port attribute.
    /// </summary>
    public TerraformExpression SslPort => this["ssl_port"];

}
