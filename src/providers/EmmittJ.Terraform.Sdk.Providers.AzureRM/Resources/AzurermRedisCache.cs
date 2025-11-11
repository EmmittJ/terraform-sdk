using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermRedisCacheIdentityBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for patch_schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermRedisCachePatchScheduleBlock
{
    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    [TerraformPropertyName("day_of_week")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DayOfWeek { get; set; }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MaintenanceWindow { get; set; }

    /// <summary>
    /// The start_hour_utc attribute.
    /// </summary>
    [TerraformPropertyName("start_hour_utc")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? StartHourUtc { get; set; }

}

/// <summary>
/// Block type for redis_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermRedisCacheRedisConfigurationBlock
{
    /// <summary>
    /// The active_directory_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("active_directory_authentication_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ActiveDirectoryAuthenticationEnabled { get; set; }

    /// <summary>
    /// The aof_backup_enabled attribute.
    /// </summary>
    [TerraformPropertyName("aof_backup_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AofBackupEnabled { get; set; }

    /// <summary>
    /// The aof_storage_connection_string_0 attribute.
    /// </summary>
    [TerraformPropertyName("aof_storage_connection_string_0")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AofStorageConnectionString0 { get; set; }

    /// <summary>
    /// The aof_storage_connection_string_1 attribute.
    /// </summary>
    [TerraformPropertyName("aof_storage_connection_string_1")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AofStorageConnectionString1 { get; set; }

    /// <summary>
    /// The authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("authentication_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AuthenticationEnabled { get; set; }

    /// <summary>
    /// The data_persistence_authentication_method attribute.
    /// </summary>
    [TerraformPropertyName("data_persistence_authentication_method")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DataPersistenceAuthenticationMethod { get; set; }


    /// <summary>
    /// The maxfragmentationmemory_reserved attribute.
    /// </summary>
    [TerraformPropertyName("maxfragmentationmemory_reserved")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxfragmentationmemoryReserved { get; set; } = default!;

    /// <summary>
    /// The maxmemory_delta attribute.
    /// </summary>
    [TerraformPropertyName("maxmemory_delta")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxmemoryDelta { get; set; } = default!;

    /// <summary>
    /// The maxmemory_policy attribute.
    /// </summary>
    [TerraformPropertyName("maxmemory_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MaxmemoryPolicy { get; set; }

    /// <summary>
    /// The maxmemory_reserved attribute.
    /// </summary>
    [TerraformPropertyName("maxmemory_reserved")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxmemoryReserved { get; set; } = default!;

    /// <summary>
    /// The notify_keyspace_events attribute.
    /// </summary>
    [TerraformPropertyName("notify_keyspace_events")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NotifyKeyspaceEvents { get; set; }

    /// <summary>
    /// The rdb_backup_enabled attribute.
    /// </summary>
    [TerraformPropertyName("rdb_backup_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RdbBackupEnabled { get; set; }

    /// <summary>
    /// The rdb_backup_frequency attribute.
    /// </summary>
    [TerraformPropertyName("rdb_backup_frequency")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RdbBackupFrequency { get; set; }

    /// <summary>
    /// The rdb_backup_max_snapshot_count attribute.
    /// </summary>
    [TerraformPropertyName("rdb_backup_max_snapshot_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RdbBackupMaxSnapshotCount { get; set; }

    /// <summary>
    /// The rdb_storage_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("rdb_storage_connection_string")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RdbStorageConnectionString { get; set; }

    /// <summary>
    /// The storage_account_subscription_id attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_subscription_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StorageAccountSubscriptionId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRedisCacheTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    [TerraformPropertyName("access_keys_authentication_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AccessKeysAuthenticationEnabled { get; set; }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    [TerraformPropertyName("capacity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Capacity { get; set; }

    /// <summary>
    /// The family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Family is required")]
    [TerraformPropertyName("family")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Family { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    [TerraformPropertyName("minimum_tls_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MinimumTlsVersion { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The non_ssl_port_enabled attribute.
    /// </summary>
    [TerraformPropertyName("non_ssl_port_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? NonSslPortEnabled { get; set; }

    /// <summary>
    /// The private_static_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("private_static_ip_address")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PrivateStaticIpAddress { get; set; } = default!;

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The redis_version attribute.
    /// </summary>
    [TerraformPropertyName("redis_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RedisVersion { get; set; }

    /// <summary>
    /// The replicas_per_master attribute.
    /// </summary>
    [TerraformPropertyName("replicas_per_master")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> ReplicasPerMaster { get; set; } = default!;

    /// <summary>
    /// The replicas_per_primary attribute.
    /// </summary>
    [TerraformPropertyName("replicas_per_primary")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> ReplicasPerPrimary { get; set; } = default!;

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The shard_count attribute.
    /// </summary>
    [TerraformPropertyName("shard_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ShardCount { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformPropertyName("sku_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SkuName { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tenant_settings attribute.
    /// </summary>
    [TerraformPropertyName("tenant_settings")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? TenantSettings { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Zones { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermRedisCacheIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for patch_schedule.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("patch_schedule")]
    public TerraformList<TerraformBlock<AzurermRedisCachePatchScheduleBlock>>? PatchSchedule { get; set; }

    /// <summary>
    /// Block for redis_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedisConfiguration block(s) allowed")]
    [TerraformPropertyName("redis_configuration")]
    public TerraformList<TerraformBlock<AzurermRedisCacheRedisConfigurationBlock>>? RedisConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermRedisCacheTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [TerraformPropertyName("hostname")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Hostname => new TerraformReference(this, "hostname");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Port => new TerraformReference(this, "port");

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryAccessKey => new TerraformReference(this, "primary_access_key");

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("primary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryConnectionString => new TerraformReference(this, "primary_connection_string");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryAccessKey => new TerraformReference(this, "secondary_access_key");

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("secondary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryConnectionString => new TerraformReference(this, "secondary_connection_string");

    /// <summary>
    /// The ssl_port attribute.
    /// </summary>
    [TerraformPropertyName("ssl_port")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> SslPort => new TerraformReference(this, "ssl_port");

}
