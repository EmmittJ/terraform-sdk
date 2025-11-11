using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermRedisCacheIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for patch_schedule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermRedisCachePatchScheduleBlock : TerraformBlockBase
{
    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    [TerraformProperty("day_of_week")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DayOfWeek { get; set; }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformProperty("maintenance_window")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MaintenanceWindow { get; set; }

    /// <summary>
    /// The start_hour_utc attribute.
    /// </summary>
    [TerraformProperty("start_hour_utc")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? StartHourUtc { get; set; }

}

/// <summary>
/// Block type for redis_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermRedisCacheRedisConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The active_directory_authentication_enabled attribute.
    /// </summary>
    [TerraformProperty("active_directory_authentication_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ActiveDirectoryAuthenticationEnabled { get; set; }

    /// <summary>
    /// The aof_backup_enabled attribute.
    /// </summary>
    [TerraformProperty("aof_backup_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AofBackupEnabled { get; set; }

    /// <summary>
    /// The aof_storage_connection_string_0 attribute.
    /// </summary>
    [TerraformProperty("aof_storage_connection_string_0")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AofStorageConnectionString0 { get; set; }

    /// <summary>
    /// The aof_storage_connection_string_1 attribute.
    /// </summary>
    [TerraformProperty("aof_storage_connection_string_1")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AofStorageConnectionString1 { get; set; }

    /// <summary>
    /// The authentication_enabled attribute.
    /// </summary>
    [TerraformProperty("authentication_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AuthenticationEnabled { get; set; }

    /// <summary>
    /// The data_persistence_authentication_method attribute.
    /// </summary>
    [TerraformProperty("data_persistence_authentication_method")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DataPersistenceAuthenticationMethod { get; set; }


    /// <summary>
    /// The maxfragmentationmemory_reserved attribute.
    /// </summary>
    [TerraformProperty("maxfragmentationmemory_reserved")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> MaxfragmentationmemoryReserved { get; set; }

    /// <summary>
    /// The maxmemory_delta attribute.
    /// </summary>
    [TerraformProperty("maxmemory_delta")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> MaxmemoryDelta { get; set; }

    /// <summary>
    /// The maxmemory_policy attribute.
    /// </summary>
    [TerraformProperty("maxmemory_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MaxmemoryPolicy { get; set; }

    /// <summary>
    /// The maxmemory_reserved attribute.
    /// </summary>
    [TerraformProperty("maxmemory_reserved")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> MaxmemoryReserved { get; set; }

    /// <summary>
    /// The notify_keyspace_events attribute.
    /// </summary>
    [TerraformProperty("notify_keyspace_events")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NotifyKeyspaceEvents { get; set; }

    /// <summary>
    /// The rdb_backup_enabled attribute.
    /// </summary>
    [TerraformProperty("rdb_backup_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RdbBackupEnabled { get; set; }

    /// <summary>
    /// The rdb_backup_frequency attribute.
    /// </summary>
    [TerraformProperty("rdb_backup_frequency")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? RdbBackupFrequency { get; set; }

    /// <summary>
    /// The rdb_backup_max_snapshot_count attribute.
    /// </summary>
    [TerraformProperty("rdb_backup_max_snapshot_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? RdbBackupMaxSnapshotCount { get; set; }

    /// <summary>
    /// The rdb_storage_connection_string attribute.
    /// </summary>
    [TerraformProperty("rdb_storage_connection_string")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RdbStorageConnectionString { get; set; }

    /// <summary>
    /// The storage_account_subscription_id attribute.
    /// </summary>
    [TerraformProperty("storage_account_subscription_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StorageAccountSubscriptionId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermRedisCacheTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_redis_cache resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermRedisCache : TerraformResource
{
    public AzurermRedisCache(string name) : base("azurerm_redis_cache", name)
    {
    }

    /// <summary>
    /// The access_keys_authentication_enabled attribute.
    /// </summary>
    [TerraformProperty("access_keys_authentication_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AccessKeysAuthenticationEnabled { get; set; }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    [TerraformProperty("capacity")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Capacity { get; set; }

    /// <summary>
    /// The family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Family is required")]
    [TerraformProperty("family")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Family { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    [TerraformProperty("minimum_tls_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MinimumTlsVersion { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The non_ssl_port_enabled attribute.
    /// </summary>
    [TerraformProperty("non_ssl_port_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? NonSslPortEnabled { get; set; }

    /// <summary>
    /// The private_static_ip_address attribute.
    /// </summary>
    [TerraformProperty("private_static_ip_address")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PrivateStaticIpAddress { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The redis_version attribute.
    /// </summary>
    [TerraformProperty("redis_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RedisVersion { get; set; }

    /// <summary>
    /// The replicas_per_master attribute.
    /// </summary>
    [TerraformProperty("replicas_per_master")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> ReplicasPerMaster { get; set; }

    /// <summary>
    /// The replicas_per_primary attribute.
    /// </summary>
    [TerraformProperty("replicas_per_primary")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> ReplicasPerPrimary { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The shard_count attribute.
    /// </summary>
    [TerraformProperty("shard_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ShardCount { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformProperty("sku_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SkuName { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tenant_settings attribute.
    /// </summary>
    [TerraformProperty("tenant_settings")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? TenantSettings { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformProperty("zones")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Zones { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<TerraformBlock<AzurermRedisCacheIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for patch_schedule.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("patch_schedule")]
    public TerraformList<TerraformBlock<AzurermRedisCachePatchScheduleBlock>>? PatchSchedule { get; set; }

    /// <summary>
    /// Block for redis_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedisConfiguration block(s) allowed")]
    [TerraformProperty("redis_configuration")]
    public TerraformList<TerraformBlock<AzurermRedisCacheRedisConfigurationBlock>>? RedisConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermRedisCacheTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [TerraformProperty("hostname")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Hostname { get; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> Port { get; }

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformProperty("primary_access_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryAccessKey { get; }

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    [TerraformProperty("primary_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryConnectionString { get; }

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformProperty("secondary_access_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryAccessKey { get; }

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    [TerraformProperty("secondary_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryConnectionString { get; }

    /// <summary>
    /// The ssl_port attribute.
    /// </summary>
    [TerraformProperty("ssl_port")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> SslPort { get; }

}
