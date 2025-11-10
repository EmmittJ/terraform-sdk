using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermRedisCacheIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentityIds { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>("", "principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>("", "tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for patch_schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermRedisCachePatchScheduleBlock : ITerraformBlock
{
    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    [TerraformPropertyName("day_of_week")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DayOfWeek { get; set; }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaintenanceWindow { get; set; }

    /// <summary>
    /// The start_hour_utc attribute.
    /// </summary>
    [TerraformPropertyName("start_hour_utc")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? StartHourUtc { get; set; }

}

/// <summary>
/// Block type for redis_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermRedisCacheRedisConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The active_directory_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("active_directory_authentication_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ActiveDirectoryAuthenticationEnabled { get; set; }

    /// <summary>
    /// The aof_backup_enabled attribute.
    /// </summary>
    [TerraformPropertyName("aof_backup_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AofBackupEnabled { get; set; }

    /// <summary>
    /// The aof_storage_connection_string_0 attribute.
    /// </summary>
    [TerraformPropertyName("aof_storage_connection_string_0")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AofStorageConnectionString0 { get; set; }

    /// <summary>
    /// The aof_storage_connection_string_1 attribute.
    /// </summary>
    [TerraformPropertyName("aof_storage_connection_string_1")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AofStorageConnectionString1 { get; set; }

    /// <summary>
    /// The authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("authentication_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AuthenticationEnabled { get; set; }

    /// <summary>
    /// The data_persistence_authentication_method attribute.
    /// </summary>
    [TerraformPropertyName("data_persistence_authentication_method")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DataPersistenceAuthenticationMethod { get; set; }

    /// <summary>
    /// The maxclients attribute.
    /// </summary>
    [TerraformPropertyName("maxclients")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Maxclients => new TerraformReferenceProperty<TerraformProperty<double>>("", "maxclients");

    /// <summary>
    /// The maxfragmentationmemory_reserved attribute.
    /// </summary>
    [TerraformPropertyName("maxfragmentationmemory_reserved")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxfragmentationmemoryReserved { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "maxfragmentationmemory_reserved");

    /// <summary>
    /// The maxmemory_delta attribute.
    /// </summary>
    [TerraformPropertyName("maxmemory_delta")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxmemoryDelta { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "maxmemory_delta");

    /// <summary>
    /// The maxmemory_policy attribute.
    /// </summary>
    [TerraformPropertyName("maxmemory_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaxmemoryPolicy { get; set; }

    /// <summary>
    /// The maxmemory_reserved attribute.
    /// </summary>
    [TerraformPropertyName("maxmemory_reserved")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxmemoryReserved { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "maxmemory_reserved");

    /// <summary>
    /// The notify_keyspace_events attribute.
    /// </summary>
    [TerraformPropertyName("notify_keyspace_events")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NotifyKeyspaceEvents { get; set; }

    /// <summary>
    /// The rdb_backup_enabled attribute.
    /// </summary>
    [TerraformPropertyName("rdb_backup_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RdbBackupEnabled { get; set; }

    /// <summary>
    /// The rdb_backup_frequency attribute.
    /// </summary>
    [TerraformPropertyName("rdb_backup_frequency")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RdbBackupFrequency { get; set; }

    /// <summary>
    /// The rdb_backup_max_snapshot_count attribute.
    /// </summary>
    [TerraformPropertyName("rdb_backup_max_snapshot_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RdbBackupMaxSnapshotCount { get; set; }

    /// <summary>
    /// The rdb_storage_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("rdb_storage_connection_string")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RdbStorageConnectionString { get; set; }

    /// <summary>
    /// The storage_account_subscription_id attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_subscription_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageAccountSubscriptionId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRedisCacheTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    public TerraformProperty<TerraformProperty<bool>>? AccessKeysAuthenticationEnabled { get; set; }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    [TerraformPropertyName("capacity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Capacity { get; set; }

    /// <summary>
    /// The family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Family is required")]
    [TerraformPropertyName("family")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Family { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    [TerraformPropertyName("minimum_tls_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MinimumTlsVersion { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The non_ssl_port_enabled attribute.
    /// </summary>
    [TerraformPropertyName("non_ssl_port_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? NonSslPortEnabled { get; set; }

    /// <summary>
    /// The private_static_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("private_static_ip_address")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PrivateStaticIpAddress { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_static_ip_address");

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The redis_version attribute.
    /// </summary>
    [TerraformPropertyName("redis_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RedisVersion { get; set; }

    /// <summary>
    /// The replicas_per_master attribute.
    /// </summary>
    [TerraformPropertyName("replicas_per_master")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> ReplicasPerMaster { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "replicas_per_master");

    /// <summary>
    /// The replicas_per_primary attribute.
    /// </summary>
    [TerraformPropertyName("replicas_per_primary")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> ReplicasPerPrimary { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "replicas_per_primary");

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The shard_count attribute.
    /// </summary>
    [TerraformPropertyName("shard_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ShardCount { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformPropertyName("sku_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SkuName { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tenant_settings attribute.
    /// </summary>
    [TerraformPropertyName("tenant_settings")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? TenantSettings { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Zones { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermRedisCacheIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for patch_schedule.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("patch_schedule")]
    public TerraformList<TerraformBlock<AzurermRedisCachePatchScheduleBlock>>? PatchSchedule { get; set; } = new();

    /// <summary>
    /// Block for redis_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedisConfiguration block(s) allowed")]
    [TerraformPropertyName("redis_configuration")]
    public TerraformList<TerraformBlock<AzurermRedisCacheRedisConfigurationBlock>>? RedisConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermRedisCacheTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [TerraformPropertyName("hostname")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Hostname => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hostname");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Port => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "port");

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryAccessKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_access_key");

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("primary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_connection_string");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryAccessKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_access_key");

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("secondary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_connection_string");

    /// <summary>
    /// The ssl_port attribute.
    /// </summary>
    [TerraformPropertyName("ssl_port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SslPort => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "ssl_port");

}
