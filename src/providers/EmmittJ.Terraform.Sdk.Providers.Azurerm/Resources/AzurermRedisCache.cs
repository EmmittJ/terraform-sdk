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
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

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
        get => GetArgument<TerraformValue<string>>("day_of_week");
        set => SetArgument("day_of_week", value);
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformValue<string>? MaintenanceWindow
    {
        get => GetArgument<TerraformValue<string>>("maintenance_window");
        set => SetArgument("maintenance_window", value);
    }

    /// <summary>
    /// The start_hour_utc attribute.
    /// </summary>
    public TerraformValue<double>? StartHourUtc
    {
        get => GetArgument<TerraformValue<double>>("start_hour_utc");
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
        get => GetArgument<TerraformValue<bool>>("active_directory_authentication_enabled");
        set => SetArgument("active_directory_authentication_enabled", value);
    }

    /// <summary>
    /// The aof_backup_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AofBackupEnabled
    {
        get => GetArgument<TerraformValue<bool>>("aof_backup_enabled");
        set => SetArgument("aof_backup_enabled", value);
    }

    /// <summary>
    /// The aof_storage_connection_string_0 attribute.
    /// </summary>
    public TerraformValue<string>? AofStorageConnectionString0
    {
        get => GetArgument<TerraformValue<string>>("aof_storage_connection_string_0");
        set => SetArgument("aof_storage_connection_string_0", value);
    }

    /// <summary>
    /// The aof_storage_connection_string_1 attribute.
    /// </summary>
    public TerraformValue<string>? AofStorageConnectionString1
    {
        get => GetArgument<TerraformValue<string>>("aof_storage_connection_string_1");
        set => SetArgument("aof_storage_connection_string_1", value);
    }

    /// <summary>
    /// The authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AuthenticationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("authentication_enabled");
        set => SetArgument("authentication_enabled", value);
    }

    /// <summary>
    /// The data_persistence_authentication_method attribute.
    /// </summary>
    public TerraformValue<string>? DataPersistenceAuthenticationMethod
    {
        get => GetArgument<TerraformValue<string>>("data_persistence_authentication_method");
        set => SetArgument("data_persistence_authentication_method", value);
    }

    /// <summary>
    /// The maxclients attribute.
    /// </summary>
    public TerraformValue<double> Maxclients
        => AsReference("maxclients");

    /// <summary>
    /// The maxfragmentationmemory_reserved attribute.
    /// </summary>
    public TerraformValue<double>? MaxfragmentationmemoryReserved
    {
        get => GetArgument<TerraformValue<double>>("maxfragmentationmemory_reserved");
        set => SetArgument("maxfragmentationmemory_reserved", value);
    }

    /// <summary>
    /// The maxmemory_delta attribute.
    /// </summary>
    public TerraformValue<double>? MaxmemoryDelta
    {
        get => GetArgument<TerraformValue<double>>("maxmemory_delta");
        set => SetArgument("maxmemory_delta", value);
    }

    /// <summary>
    /// The maxmemory_policy attribute.
    /// </summary>
    public TerraformValue<string>? MaxmemoryPolicy
    {
        get => GetArgument<TerraformValue<string>>("maxmemory_policy");
        set => SetArgument("maxmemory_policy", value);
    }

    /// <summary>
    /// The maxmemory_reserved attribute.
    /// </summary>
    public TerraformValue<double>? MaxmemoryReserved
    {
        get => GetArgument<TerraformValue<double>>("maxmemory_reserved");
        set => SetArgument("maxmemory_reserved", value);
    }

    /// <summary>
    /// The notify_keyspace_events attribute.
    /// </summary>
    public TerraformValue<string>? NotifyKeyspaceEvents
    {
        get => GetArgument<TerraformValue<string>>("notify_keyspace_events");
        set => SetArgument("notify_keyspace_events", value);
    }

    /// <summary>
    /// The rdb_backup_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RdbBackupEnabled
    {
        get => GetArgument<TerraformValue<bool>>("rdb_backup_enabled");
        set => SetArgument("rdb_backup_enabled", value);
    }

    /// <summary>
    /// The rdb_backup_frequency attribute.
    /// </summary>
    public TerraformValue<double>? RdbBackupFrequency
    {
        get => GetArgument<TerraformValue<double>>("rdb_backup_frequency");
        set => SetArgument("rdb_backup_frequency", value);
    }

    /// <summary>
    /// The rdb_backup_max_snapshot_count attribute.
    /// </summary>
    public TerraformValue<double>? RdbBackupMaxSnapshotCount
    {
        get => GetArgument<TerraformValue<double>>("rdb_backup_max_snapshot_count");
        set => SetArgument("rdb_backup_max_snapshot_count", value);
    }

    /// <summary>
    /// The rdb_storage_connection_string attribute.
    /// </summary>
    public TerraformValue<string>? RdbStorageConnectionString
    {
        get => GetArgument<TerraformValue<string>>("rdb_storage_connection_string");
        set => SetArgument("rdb_storage_connection_string", value);
    }

    /// <summary>
    /// The storage_account_subscription_id attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountSubscriptionId
    {
        get => GetArgument<TerraformValue<string>>("storage_account_subscription_id");
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
        get => GetArgument<TerraformValue<bool>>("access_keys_authentication_enabled");
        set => SetArgument("access_keys_authentication_enabled", value);
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    public required TerraformValue<double> Capacity
    {
        get => GetArgument<TerraformValue<double>>("capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// The family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Family is required")]
    public required TerraformValue<string> Family
    {
        get => GetArgument<TerraformValue<string>>("family");
        set => SetArgument("family", value);
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
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformValue<string>? MinimumTlsVersion
    {
        get => GetArgument<TerraformValue<string>>("minimum_tls_version");
        set => SetArgument("minimum_tls_version", value);
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
    /// The non_ssl_port_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? NonSslPortEnabled
    {
        get => GetArgument<TerraformValue<bool>>("non_ssl_port_enabled");
        set => SetArgument("non_ssl_port_enabled", value);
    }

    /// <summary>
    /// The private_static_ip_address attribute.
    /// </summary>
    public TerraformValue<string>? PrivateStaticIpAddress
    {
        get => GetArgument<TerraformValue<string>>("private_static_ip_address");
        set => SetArgument("private_static_ip_address", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The redis_version attribute.
    /// </summary>
    public TerraformValue<string>? RedisVersion
    {
        get => GetArgument<TerraformValue<string>>("redis_version");
        set => SetArgument("redis_version", value);
    }

    /// <summary>
    /// The replicas_per_master attribute.
    /// </summary>
    public TerraformValue<double>? ReplicasPerMaster
    {
        get => GetArgument<TerraformValue<double>>("replicas_per_master");
        set => SetArgument("replicas_per_master", value);
    }

    /// <summary>
    /// The replicas_per_primary attribute.
    /// </summary>
    public TerraformValue<double>? ReplicasPerPrimary
    {
        get => GetArgument<TerraformValue<double>>("replicas_per_primary");
        set => SetArgument("replicas_per_primary", value);
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
    /// The shard_count attribute.
    /// </summary>
    public TerraformValue<double>? ShardCount
    {
        get => GetArgument<TerraformValue<double>>("shard_count");
        set => SetArgument("shard_count", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformValue<string> SkuName
    {
        get => GetArgument<TerraformValue<string>>("sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
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
    /// The tenant_settings attribute.
    /// </summary>
    public TerraformMap<string>? TenantSettings
    {
        get => GetArgument<TerraformMap<string>>("tenant_settings");
        set => SetArgument("tenant_settings", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformSet<string>? Zones
    {
        get => GetArgument<TerraformSet<string>>("zones");
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformValue<string> Hostname
        => AsReference("hostname");

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
        => AsReference("port");

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryAccessKey
        => AsReference("primary_access_key");

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimaryConnectionString
        => AsReference("primary_connection_string");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryAccessKey
        => AsReference("secondary_access_key");

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondaryConnectionString
        => AsReference("secondary_connection_string");

    /// <summary>
    /// The ssl_port attribute.
    /// </summary>
    public TerraformValue<double> SslPort
        => AsReference("ssl_port");

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
