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
        set => SetProperty("day_of_week", value);
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string>? MaintenanceWindow
    {
        set => SetProperty("maintenance_window", value);
    }

    /// <summary>
    /// The start_hour_utc attribute.
    /// </summary>
    public TerraformProperty<double>? StartHourUtc
    {
        set => SetProperty("start_hour_utc", value);
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
        set => SetProperty("active_directory_authentication_enabled", value);
    }

    /// <summary>
    /// The aof_backup_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AofBackupEnabled
    {
        set => SetProperty("aof_backup_enabled", value);
    }

    /// <summary>
    /// The aof_storage_connection_string_0 attribute.
    /// </summary>
    public TerraformProperty<string>? AofStorageConnectionString0
    {
        set => SetProperty("aof_storage_connection_string_0", value);
    }

    /// <summary>
    /// The aof_storage_connection_string_1 attribute.
    /// </summary>
    public TerraformProperty<string>? AofStorageConnectionString1
    {
        set => SetProperty("aof_storage_connection_string_1", value);
    }

    /// <summary>
    /// The authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AuthenticationEnabled
    {
        set => SetProperty("authentication_enabled", value);
    }

    /// <summary>
    /// The data_persistence_authentication_method attribute.
    /// </summary>
    public TerraformProperty<string>? DataPersistenceAuthenticationMethod
    {
        set => SetProperty("data_persistence_authentication_method", value);
    }

    /// <summary>
    /// The maxclients attribute.
    /// </summary>
    public TerraformProperty<double>? Maxclients
    {
        set => SetProperty("maxclients", value);
    }

    /// <summary>
    /// The maxfragmentationmemory_reserved attribute.
    /// </summary>
    public TerraformProperty<double>? MaxfragmentationmemoryReserved
    {
        set => SetProperty("maxfragmentationmemory_reserved", value);
    }

    /// <summary>
    /// The maxmemory_delta attribute.
    /// </summary>
    public TerraformProperty<double>? MaxmemoryDelta
    {
        set => SetProperty("maxmemory_delta", value);
    }

    /// <summary>
    /// The maxmemory_policy attribute.
    /// </summary>
    public TerraformProperty<string>? MaxmemoryPolicy
    {
        set => SetProperty("maxmemory_policy", value);
    }

    /// <summary>
    /// The maxmemory_reserved attribute.
    /// </summary>
    public TerraformProperty<double>? MaxmemoryReserved
    {
        set => SetProperty("maxmemory_reserved", value);
    }

    /// <summary>
    /// The notify_keyspace_events attribute.
    /// </summary>
    public TerraformProperty<string>? NotifyKeyspaceEvents
    {
        set => SetProperty("notify_keyspace_events", value);
    }

    /// <summary>
    /// The rdb_backup_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RdbBackupEnabled
    {
        set => SetProperty("rdb_backup_enabled", value);
    }

    /// <summary>
    /// The rdb_backup_frequency attribute.
    /// </summary>
    public TerraformProperty<double>? RdbBackupFrequency
    {
        set => SetProperty("rdb_backup_frequency", value);
    }

    /// <summary>
    /// The rdb_backup_max_snapshot_count attribute.
    /// </summary>
    public TerraformProperty<double>? RdbBackupMaxSnapshotCount
    {
        set => SetProperty("rdb_backup_max_snapshot_count", value);
    }

    /// <summary>
    /// The rdb_storage_connection_string attribute.
    /// </summary>
    public TerraformProperty<string>? RdbStorageConnectionString
    {
        set => SetProperty("rdb_storage_connection_string", value);
    }

    /// <summary>
    /// The storage_account_subscription_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountSubscriptionId
    {
        set => SetProperty("storage_account_subscription_id", value);
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
/// Manages a azurerm_redis_cache resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermRedisCache : TerraformResource
{
    public AzurermRedisCache(string name) : base("azurerm_redis_cache", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("hostname");
        SetOutput("port");
        SetOutput("primary_access_key");
        SetOutput("primary_connection_string");
        SetOutput("secondary_access_key");
        SetOutput("secondary_connection_string");
        SetOutput("ssl_port");
        SetOutput("access_keys_authentication_enabled");
        SetOutput("capacity");
        SetOutput("family");
        SetOutput("id");
        SetOutput("location");
        SetOutput("minimum_tls_version");
        SetOutput("name");
        SetOutput("non_ssl_port_enabled");
        SetOutput("private_static_ip_address");
        SetOutput("public_network_access_enabled");
        SetOutput("redis_version");
        SetOutput("replicas_per_master");
        SetOutput("replicas_per_primary");
        SetOutput("resource_group_name");
        SetOutput("shard_count");
        SetOutput("sku_name");
        SetOutput("subnet_id");
        SetOutput("tags");
        SetOutput("tenant_settings");
        SetOutput("zones");
    }

    /// <summary>
    /// The access_keys_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AccessKeysAuthenticationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("access_keys_authentication_enabled");
        set => SetProperty("access_keys_authentication_enabled", value);
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    public required TerraformProperty<double> Capacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("capacity");
        set => SetProperty("capacity", value);
    }

    /// <summary>
    /// The family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Family is required")]
    public required TerraformProperty<string> Family
    {
        get => GetRequiredOutput<TerraformProperty<string>>("family");
        set => SetProperty("family", value);
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
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformProperty<string> MinimumTlsVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("minimum_tls_version");
        set => SetProperty("minimum_tls_version", value);
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
    /// The non_ssl_port_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> NonSslPortEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("non_ssl_port_enabled");
        set => SetProperty("non_ssl_port_enabled", value);
    }

    /// <summary>
    /// The private_static_ip_address attribute.
    /// </summary>
    public TerraformProperty<string> PrivateStaticIpAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("private_static_ip_address");
        set => SetProperty("private_static_ip_address", value);
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
    /// The redis_version attribute.
    /// </summary>
    public TerraformProperty<string> RedisVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("redis_version");
        set => SetProperty("redis_version", value);
    }

    /// <summary>
    /// The replicas_per_master attribute.
    /// </summary>
    public TerraformProperty<double> ReplicasPerMaster
    {
        get => GetRequiredOutput<TerraformProperty<double>>("replicas_per_master");
        set => SetProperty("replicas_per_master", value);
    }

    /// <summary>
    /// The replicas_per_primary attribute.
    /// </summary>
    public TerraformProperty<double> ReplicasPerPrimary
    {
        get => GetRequiredOutput<TerraformProperty<double>>("replicas_per_primary");
        set => SetProperty("replicas_per_primary", value);
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
    /// The shard_count attribute.
    /// </summary>
    public TerraformProperty<double> ShardCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("shard_count");
        set => SetProperty("shard_count", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformProperty<string> SkuName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku_name");
        set => SetProperty("sku_name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string> SubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subnet_id");
        set => SetProperty("subnet_id", value);
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
    /// The tenant_settings attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TenantSettings
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tenant_settings");
        set => SetProperty("tenant_settings", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Zones
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("zones");
        set => SetProperty("zones", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermRedisCacheIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for patch_schedule.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermRedisCachePatchScheduleBlock>? PatchSchedule
    {
        set => SetProperty("patch_schedule", value);
    }

    /// <summary>
    /// Block for redis_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedisConfiguration block(s) allowed")]
    public List<AzurermRedisCacheRedisConfigurationBlock>? RedisConfiguration
    {
        set => SetProperty("redis_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermRedisCacheTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
