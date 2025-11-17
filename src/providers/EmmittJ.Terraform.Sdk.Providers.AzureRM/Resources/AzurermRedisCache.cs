using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermRedisCache.
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
/// Block type for patch_schedule in AzurermRedisCache.
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
    public required TerraformValue<string> DayOfWeek
    {
        get => new TerraformReference<string>(this, "day_of_week");
        set => SetArgument("day_of_week", value);
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformValue<string>? MaintenanceWindow
    {
        get => new TerraformReference<string>(this, "maintenance_window");
        set => SetArgument("maintenance_window", value);
    }

    /// <summary>
    /// The start_hour_utc attribute.
    /// </summary>
    public TerraformValue<double>? StartHourUtc
    {
        get => new TerraformReference<double>(this, "start_hour_utc");
        set => SetArgument("start_hour_utc", value);
    }

}


/// <summary>
/// Block type for redis_configuration in AzurermRedisCache.
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
    public TerraformValue<bool>? ActiveDirectoryAuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "active_directory_authentication_enabled");
        set => SetArgument("active_directory_authentication_enabled", value);
    }

    /// <summary>
    /// The aof_backup_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AofBackupEnabled
    {
        get => new TerraformReference<bool>(this, "aof_backup_enabled");
        set => SetArgument("aof_backup_enabled", value);
    }

    /// <summary>
    /// The aof_storage_connection_string_0 attribute.
    /// </summary>
    public TerraformValue<string>? AofStorageConnectionString0
    {
        get => new TerraformReference<string>(this, "aof_storage_connection_string_0");
        set => SetArgument("aof_storage_connection_string_0", value);
    }

    /// <summary>
    /// The aof_storage_connection_string_1 attribute.
    /// </summary>
    public TerraformValue<string>? AofStorageConnectionString1
    {
        get => new TerraformReference<string>(this, "aof_storage_connection_string_1");
        set => SetArgument("aof_storage_connection_string_1", value);
    }

    /// <summary>
    /// The authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "authentication_enabled");
        set => SetArgument("authentication_enabled", value);
    }

    /// <summary>
    /// The data_persistence_authentication_method attribute.
    /// </summary>
    public TerraformValue<string>? DataPersistenceAuthenticationMethod
    {
        get => new TerraformReference<string>(this, "data_persistence_authentication_method");
        set => SetArgument("data_persistence_authentication_method", value);
    }

    /// <summary>
    /// The maxclients attribute.
    /// </summary>
    public TerraformValue<double> Maxclients
    {
        get => new TerraformReference<double>(this, "maxclients");
    }

    /// <summary>
    /// The maxfragmentationmemory_reserved attribute.
    /// </summary>
    public TerraformValue<double> MaxfragmentationmemoryReserved
    {
        get => new TerraformReference<double>(this, "maxfragmentationmemory_reserved");
        set => SetArgument("maxfragmentationmemory_reserved", value);
    }

    /// <summary>
    /// The maxmemory_delta attribute.
    /// </summary>
    public TerraformValue<double> MaxmemoryDelta
    {
        get => new TerraformReference<double>(this, "maxmemory_delta");
        set => SetArgument("maxmemory_delta", value);
    }

    /// <summary>
    /// The maxmemory_policy attribute.
    /// </summary>
    public TerraformValue<string>? MaxmemoryPolicy
    {
        get => new TerraformReference<string>(this, "maxmemory_policy");
        set => SetArgument("maxmemory_policy", value);
    }

    /// <summary>
    /// The maxmemory_reserved attribute.
    /// </summary>
    public TerraformValue<double> MaxmemoryReserved
    {
        get => new TerraformReference<double>(this, "maxmemory_reserved");
        set => SetArgument("maxmemory_reserved", value);
    }

    /// <summary>
    /// The notify_keyspace_events attribute.
    /// </summary>
    public TerraformValue<string>? NotifyKeyspaceEvents
    {
        get => new TerraformReference<string>(this, "notify_keyspace_events");
        set => SetArgument("notify_keyspace_events", value);
    }

    /// <summary>
    /// The rdb_backup_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RdbBackupEnabled
    {
        get => new TerraformReference<bool>(this, "rdb_backup_enabled");
        set => SetArgument("rdb_backup_enabled", value);
    }

    /// <summary>
    /// The rdb_backup_frequency attribute.
    /// </summary>
    public TerraformValue<double>? RdbBackupFrequency
    {
        get => new TerraformReference<double>(this, "rdb_backup_frequency");
        set => SetArgument("rdb_backup_frequency", value);
    }

    /// <summary>
    /// The rdb_backup_max_snapshot_count attribute.
    /// </summary>
    public TerraformValue<double>? RdbBackupMaxSnapshotCount
    {
        get => new TerraformReference<double>(this, "rdb_backup_max_snapshot_count");
        set => SetArgument("rdb_backup_max_snapshot_count", value);
    }

    /// <summary>
    /// The rdb_storage_connection_string attribute.
    /// </summary>
    public TerraformValue<string>? RdbStorageConnectionString
    {
        get => new TerraformReference<string>(this, "rdb_storage_connection_string");
        set => SetArgument("rdb_storage_connection_string", value);
    }

    /// <summary>
    /// The storage_account_subscription_id attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountSubscriptionId
    {
        get => new TerraformReference<string>(this, "storage_account_subscription_id");
        set => SetArgument("storage_account_subscription_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermRedisCache.
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
/// Represents a azurerm_redis_cache Terraform resource.
/// Manages a azurerm_redis_cache resource.
/// </summary>
public partial class AzurermRedisCache(string name) : TerraformResource("azurerm_redis_cache", name)
{
    /// <summary>
    /// The access_keys_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AccessKeysAuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "access_keys_authentication_enabled");
        set => SetArgument("access_keys_authentication_enabled", value);
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    public required TerraformValue<double> Capacity
    {
        get => new TerraformReference<double>(this, "capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// The family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Family is required")]
    public required TerraformValue<string> Family
    {
        get => new TerraformReference<string>(this, "family");
        set => SetArgument("family", value);
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
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformValue<string>? MinimumTlsVersion
    {
        get => new TerraformReference<string>(this, "minimum_tls_version");
        set => SetArgument("minimum_tls_version", value);
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
    /// The non_ssl_port_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? NonSslPortEnabled
    {
        get => new TerraformReference<bool>(this, "non_ssl_port_enabled");
        set => SetArgument("non_ssl_port_enabled", value);
    }

    /// <summary>
    /// The private_static_ip_address attribute.
    /// </summary>
    public TerraformValue<string> PrivateStaticIpAddress
    {
        get => new TerraformReference<string>(this, "private_static_ip_address");
        set => SetArgument("private_static_ip_address", value);
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
    /// The redis_version attribute.
    /// </summary>
    public TerraformValue<string>? RedisVersion
    {
        get => new TerraformReference<string>(this, "redis_version");
        set => SetArgument("redis_version", value);
    }

    /// <summary>
    /// The replicas_per_master attribute.
    /// </summary>
    public TerraformValue<double> ReplicasPerMaster
    {
        get => new TerraformReference<double>(this, "replicas_per_master");
        set => SetArgument("replicas_per_master", value);
    }

    /// <summary>
    /// The replicas_per_primary attribute.
    /// </summary>
    public TerraformValue<double> ReplicasPerPrimary
    {
        get => new TerraformReference<double>(this, "replicas_per_primary");
        set => SetArgument("replicas_per_primary", value);
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
    /// The shard_count attribute.
    /// </summary>
    public TerraformValue<double>? ShardCount
    {
        get => new TerraformReference<double>(this, "shard_count");
        set => SetArgument("shard_count", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
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
    /// The tenant_settings attribute.
    /// </summary>
    public TerraformMap<string>? TenantSettings
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tenant_settings").ResolveNodes(ctx));
        set => SetArgument("tenant_settings", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformSet<string>? Zones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "zones").ResolveNodes(ctx));
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformValue<string> Hostname
    {
        get => new TerraformReference<string>(this, "hostname");
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
    }

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryAccessKey
    {
        get => new TerraformReference<string>(this, "primary_access_key");
    }

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimaryConnectionString
    {
        get => new TerraformReference<string>(this, "primary_connection_string");
    }

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryAccessKey
    {
        get => new TerraformReference<string>(this, "secondary_access_key");
    }

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondaryConnectionString
    {
        get => new TerraformReference<string>(this, "secondary_connection_string");
    }

    /// <summary>
    /// The ssl_port attribute.
    /// </summary>
    public TerraformValue<double> SslPort
    {
        get => new TerraformReference<double>(this, "ssl_port");
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermRedisCacheIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermRedisCacheIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// PatchSchedule block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermRedisCachePatchScheduleBlock>? PatchSchedule
    {
        get => GetArgument<TerraformList<AzurermRedisCachePatchScheduleBlock>>("patch_schedule");
        set => SetArgument("patch_schedule", value);
    }

    /// <summary>
    /// RedisConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedisConfiguration block(s) allowed")]
    public TerraformList<AzurermRedisCacheRedisConfigurationBlock>? RedisConfiguration
    {
        get => GetArgument<TerraformList<AzurermRedisCacheRedisConfigurationBlock>>("redis_configuration");
        set => SetArgument("redis_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermRedisCacheTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermRedisCacheTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
