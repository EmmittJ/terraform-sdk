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
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermRedisCacheIdentityBlock : TerraformBlock
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
/// Block type for patch_schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermRedisCachePatchScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "patch_schedule";

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    [TerraformArgument("day_of_week")]
    public required TerraformValue<string> DayOfWeek
    {
        get => new TerraformReference<string>(this, "day_of_week");
        set => SetArgument("day_of_week", value);
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformArgument("maintenance_window")]
    public TerraformValue<string>? MaintenanceWindow
    {
        get => new TerraformReference<string>(this, "maintenance_window");
        set => SetArgument("maintenance_window", value);
    }

    /// <summary>
    /// The start_hour_utc attribute.
    /// </summary>
    [TerraformArgument("start_hour_utc")]
    public TerraformValue<double>? StartHourUtc
    {
        get => new TerraformReference<double>(this, "start_hour_utc");
        set => SetArgument("start_hour_utc", value);
    }

}

/// <summary>
/// Block type for redis_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermRedisCacheRedisConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redis_configuration";

    /// <summary>
    /// The active_directory_authentication_enabled attribute.
    /// </summary>
    [TerraformArgument("active_directory_authentication_enabled")]
    public TerraformValue<bool>? ActiveDirectoryAuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "active_directory_authentication_enabled");
        set => SetArgument("active_directory_authentication_enabled", value);
    }

    /// <summary>
    /// The aof_backup_enabled attribute.
    /// </summary>
    [TerraformArgument("aof_backup_enabled")]
    public TerraformValue<bool>? AofBackupEnabled
    {
        get => new TerraformReference<bool>(this, "aof_backup_enabled");
        set => SetArgument("aof_backup_enabled", value);
    }

    /// <summary>
    /// The aof_storage_connection_string_0 attribute.
    /// </summary>
    [TerraformArgument("aof_storage_connection_string_0")]
    public TerraformValue<string>? AofStorageConnectionString0
    {
        get => new TerraformReference<string>(this, "aof_storage_connection_string_0");
        set => SetArgument("aof_storage_connection_string_0", value);
    }

    /// <summary>
    /// The aof_storage_connection_string_1 attribute.
    /// </summary>
    [TerraformArgument("aof_storage_connection_string_1")]
    public TerraformValue<string>? AofStorageConnectionString1
    {
        get => new TerraformReference<string>(this, "aof_storage_connection_string_1");
        set => SetArgument("aof_storage_connection_string_1", value);
    }

    /// <summary>
    /// The authentication_enabled attribute.
    /// </summary>
    [TerraformArgument("authentication_enabled")]
    public TerraformValue<bool>? AuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "authentication_enabled");
        set => SetArgument("authentication_enabled", value);
    }

    /// <summary>
    /// The data_persistence_authentication_method attribute.
    /// </summary>
    [TerraformArgument("data_persistence_authentication_method")]
    public TerraformValue<string>? DataPersistenceAuthenticationMethod
    {
        get => new TerraformReference<string>(this, "data_persistence_authentication_method");
        set => SetArgument("data_persistence_authentication_method", value);
    }


    /// <summary>
    /// The maxfragmentationmemory_reserved attribute.
    /// </summary>
    [TerraformArgument("maxfragmentationmemory_reserved")]
    public TerraformValue<double> MaxfragmentationmemoryReserved
    {
        get => new TerraformReference<double>(this, "maxfragmentationmemory_reserved");
        set => SetArgument("maxfragmentationmemory_reserved", value);
    }

    /// <summary>
    /// The maxmemory_delta attribute.
    /// </summary>
    [TerraformArgument("maxmemory_delta")]
    public TerraformValue<double> MaxmemoryDelta
    {
        get => new TerraformReference<double>(this, "maxmemory_delta");
        set => SetArgument("maxmemory_delta", value);
    }

    /// <summary>
    /// The maxmemory_policy attribute.
    /// </summary>
    [TerraformArgument("maxmemory_policy")]
    public TerraformValue<string>? MaxmemoryPolicy
    {
        get => new TerraformReference<string>(this, "maxmemory_policy");
        set => SetArgument("maxmemory_policy", value);
    }

    /// <summary>
    /// The maxmemory_reserved attribute.
    /// </summary>
    [TerraformArgument("maxmemory_reserved")]
    public TerraformValue<double> MaxmemoryReserved
    {
        get => new TerraformReference<double>(this, "maxmemory_reserved");
        set => SetArgument("maxmemory_reserved", value);
    }

    /// <summary>
    /// The notify_keyspace_events attribute.
    /// </summary>
    [TerraformArgument("notify_keyspace_events")]
    public TerraformValue<string>? NotifyKeyspaceEvents
    {
        get => new TerraformReference<string>(this, "notify_keyspace_events");
        set => SetArgument("notify_keyspace_events", value);
    }

    /// <summary>
    /// The rdb_backup_enabled attribute.
    /// </summary>
    [TerraformArgument("rdb_backup_enabled")]
    public TerraformValue<bool>? RdbBackupEnabled
    {
        get => new TerraformReference<bool>(this, "rdb_backup_enabled");
        set => SetArgument("rdb_backup_enabled", value);
    }

    /// <summary>
    /// The rdb_backup_frequency attribute.
    /// </summary>
    [TerraformArgument("rdb_backup_frequency")]
    public TerraformValue<double>? RdbBackupFrequency
    {
        get => new TerraformReference<double>(this, "rdb_backup_frequency");
        set => SetArgument("rdb_backup_frequency", value);
    }

    /// <summary>
    /// The rdb_backup_max_snapshot_count attribute.
    /// </summary>
    [TerraformArgument("rdb_backup_max_snapshot_count")]
    public TerraformValue<double>? RdbBackupMaxSnapshotCount
    {
        get => new TerraformReference<double>(this, "rdb_backup_max_snapshot_count");
        set => SetArgument("rdb_backup_max_snapshot_count", value);
    }

    /// <summary>
    /// The rdb_storage_connection_string attribute.
    /// </summary>
    [TerraformArgument("rdb_storage_connection_string")]
    public TerraformValue<string>? RdbStorageConnectionString
    {
        get => new TerraformReference<string>(this, "rdb_storage_connection_string");
        set => SetArgument("rdb_storage_connection_string", value);
    }

    /// <summary>
    /// The storage_account_subscription_id attribute.
    /// </summary>
    [TerraformArgument("storage_account_subscription_id")]
    public TerraformValue<string>? StorageAccountSubscriptionId
    {
        get => new TerraformReference<string>(this, "storage_account_subscription_id");
        set => SetArgument("storage_account_subscription_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRedisCacheTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_redis_cache resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermRedisCache : TerraformResource
{
    public AzurermRedisCache(string name) : base("azurerm_redis_cache", name)
    {
    }

    /// <summary>
    /// The access_keys_authentication_enabled attribute.
    /// </summary>
    [TerraformArgument("access_keys_authentication_enabled")]
    public TerraformValue<bool>? AccessKeysAuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "access_keys_authentication_enabled");
        set => SetArgument("access_keys_authentication_enabled", value);
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    [TerraformArgument("capacity")]
    public required TerraformValue<double> Capacity
    {
        get => new TerraformReference<double>(this, "capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// The family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Family is required")]
    [TerraformArgument("family")]
    public required TerraformValue<string> Family
    {
        get => new TerraformReference<string>(this, "family");
        set => SetArgument("family", value);
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
    /// The minimum_tls_version attribute.
    /// </summary>
    [TerraformArgument("minimum_tls_version")]
    public TerraformValue<string>? MinimumTlsVersion
    {
        get => new TerraformReference<string>(this, "minimum_tls_version");
        set => SetArgument("minimum_tls_version", value);
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
    /// The non_ssl_port_enabled attribute.
    /// </summary>
    [TerraformArgument("non_ssl_port_enabled")]
    public TerraformValue<bool>? NonSslPortEnabled
    {
        get => new TerraformReference<bool>(this, "non_ssl_port_enabled");
        set => SetArgument("non_ssl_port_enabled", value);
    }

    /// <summary>
    /// The private_static_ip_address attribute.
    /// </summary>
    [TerraformArgument("private_static_ip_address")]
    public TerraformValue<string> PrivateStaticIpAddress
    {
        get => new TerraformReference<string>(this, "private_static_ip_address");
        set => SetArgument("private_static_ip_address", value);
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
    /// The redis_version attribute.
    /// </summary>
    [TerraformArgument("redis_version")]
    public TerraformValue<string>? RedisVersion
    {
        get => new TerraformReference<string>(this, "redis_version");
        set => SetArgument("redis_version", value);
    }

    /// <summary>
    /// The replicas_per_master attribute.
    /// </summary>
    [TerraformArgument("replicas_per_master")]
    public TerraformValue<double> ReplicasPerMaster
    {
        get => new TerraformReference<double>(this, "replicas_per_master");
        set => SetArgument("replicas_per_master", value);
    }

    /// <summary>
    /// The replicas_per_primary attribute.
    /// </summary>
    [TerraformArgument("replicas_per_primary")]
    public TerraformValue<double> ReplicasPerPrimary
    {
        get => new TerraformReference<double>(this, "replicas_per_primary");
        set => SetArgument("replicas_per_primary", value);
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
    /// The shard_count attribute.
    /// </summary>
    [TerraformArgument("shard_count")]
    public TerraformValue<double>? ShardCount
    {
        get => new TerraformReference<double>(this, "shard_count");
        set => SetArgument("shard_count", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformArgument("sku_name")]
    public required TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformArgument("subnet_id")]
    public TerraformValue<string>? SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
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
    /// The tenant_settings attribute.
    /// </summary>
    [TerraformArgument("tenant_settings")]
    public TerraformMap<string>? TenantSettings
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tenant_settings").ResolveNodes(ctx));
        set => SetArgument("tenant_settings", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformArgument("zones")]
    public TerraformSet<string>? Zones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "zones").ResolveNodes(ctx));
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermRedisCacheIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for patch_schedule.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("patch_schedule")]
    public TerraformList<AzurermRedisCachePatchScheduleBlock> PatchSchedule { get; set; } = new();

    /// <summary>
    /// Block for redis_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedisConfiguration block(s) allowed")]
    [TerraformArgument("redis_configuration")]
    public TerraformList<AzurermRedisCacheRedisConfigurationBlock> RedisConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermRedisCacheTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [TerraformArgument("hostname")]
    public TerraformValue<string> Hostname
    {
        get => new TerraformReference<string>(this, "hostname");
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformArgument("port")]
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
    }

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformArgument("primary_access_key")]
    public TerraformValue<string> PrimaryAccessKey
    {
        get => new TerraformReference<string>(this, "primary_access_key");
    }

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    [TerraformArgument("primary_connection_string")]
    public TerraformValue<string> PrimaryConnectionString
    {
        get => new TerraformReference<string>(this, "primary_connection_string");
    }

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformArgument("secondary_access_key")]
    public TerraformValue<string> SecondaryAccessKey
    {
        get => new TerraformReference<string>(this, "secondary_access_key");
    }

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    [TerraformArgument("secondary_connection_string")]
    public TerraformValue<string> SecondaryConnectionString
    {
        get => new TerraformReference<string>(this, "secondary_connection_string");
    }

    /// <summary>
    /// The ssl_port attribute.
    /// </summary>
    [TerraformArgument("ssl_port")]
    public TerraformValue<double> SslPort
    {
        get => new TerraformReference<double>(this, "ssl_port");
    }

}
