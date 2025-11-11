using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for analytical_storage in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCosmosdbAccountAnalyticalStorageBlock : TerraformBlockBase
{
    /// <summary>
    /// The schema_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaType is required")]
    [TerraformProperty("schema_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SchemaType { get; set; }

}

/// <summary>
/// Block type for backup in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCosmosdbAccountBackupBlock : TerraformBlockBase
{
    /// <summary>
    /// The interval_in_minutes attribute.
    /// </summary>
    [TerraformProperty("interval_in_minutes")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> IntervalInMinutes { get; set; }

    /// <summary>
    /// The retention_in_hours attribute.
    /// </summary>
    [TerraformProperty("retention_in_hours")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> RetentionInHours { get; set; }

    /// <summary>
    /// The storage_redundancy attribute.
    /// </summary>
    [TerraformProperty("storage_redundancy")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> StorageRedundancy { get; set; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [TerraformProperty("tier")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Tier { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for capabilities in .
/// Nesting mode: set
/// </summary>
public partial class AzurermCosmosdbAccountCapabilitiesBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for capacity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCosmosdbAccountCapacityBlock : TerraformBlockBase
{
    /// <summary>
    /// The total_throughput_limit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalThroughputLimit is required")]
    [TerraformProperty("total_throughput_limit")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> TotalThroughputLimit { get; set; }

}

/// <summary>
/// Block type for consistency_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCosmosdbAccountConsistencyPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The consistency_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsistencyLevel is required")]
    [TerraformProperty("consistency_level")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ConsistencyLevel { get; set; }

    /// <summary>
    /// The max_interval_in_seconds attribute.
    /// </summary>
    [TerraformProperty("max_interval_in_seconds")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxIntervalInSeconds { get; set; }

    /// <summary>
    /// The max_staleness_prefix attribute.
    /// </summary>
    [TerraformProperty("max_staleness_prefix")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxStalenessPrefix { get; set; }

}

/// <summary>
/// Block type for cors_rule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCosmosdbAccountCorsRuleBlock : TerraformBlockBase
{
    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedHeaders is required")]
    [TerraformProperty("allowed_headers")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? AllowedHeaders { get; set; }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    [TerraformProperty("allowed_methods")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? AllowedMethods { get; set; }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    [TerraformProperty("allowed_origins")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? AllowedOrigins { get; set; }

    /// <summary>
    /// The exposed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExposedHeaders is required")]
    [TerraformProperty("exposed_headers")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? ExposedHeaders { get; set; }

    /// <summary>
    /// The max_age_in_seconds attribute.
    /// </summary>
    [TerraformProperty("max_age_in_seconds")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxAgeInSeconds { get; set; }

}

/// <summary>
/// Block type for geo_location in .
/// Nesting mode: set
/// </summary>
public partial class AzurermCosmosdbAccountGeoLocationBlock : TerraformBlockBase
{
    /// <summary>
    /// The failover_priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailoverPriority is required")]
    [TerraformProperty("failover_priority")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> FailoverPriority { get; set; }


    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformProperty("zone_redundant")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ZoneRedundant { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCosmosdbAccountIdentityBlock : TerraformBlockBase
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
/// Block type for restore in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCosmosdbAccountRestoreBlock : TerraformBlockBase
{
    /// <summary>
    /// The restore_timestamp_in_utc attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestoreTimestampInUtc is required")]
    [TerraformProperty("restore_timestamp_in_utc")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RestoreTimestampInUtc { get; set; }

    /// <summary>
    /// The source_cosmosdb_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceCosmosdbAccountId is required")]
    [TerraformProperty("source_cosmosdb_account_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SourceCosmosdbAccountId { get; set; }

    /// <summary>
    /// The tables_to_restore attribute.
    /// </summary>
    [TerraformProperty("tables_to_restore")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? TablesToRestore { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCosmosdbAccountTimeoutsBlock : TerraformBlockBase
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
/// Block type for virtual_network_rule in .
/// Nesting mode: set
/// </summary>
public partial class AzurermCosmosdbAccountVirtualNetworkRuleBlock : TerraformBlockBase
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ignore_missing_vnet_service_endpoint attribute.
    /// </summary>
    [TerraformProperty("ignore_missing_vnet_service_endpoint")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IgnoreMissingVnetServiceEndpoint { get; set; }

}

/// <summary>
/// Manages a azurerm_cosmosdb_account resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermCosmosdbAccount : TerraformResource
{
    public AzurermCosmosdbAccount(string name) : base("azurerm_cosmosdb_account", name)
    {
    }

    /// <summary>
    /// The access_key_metadata_writes_enabled attribute.
    /// </summary>
    [TerraformProperty("access_key_metadata_writes_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AccessKeyMetadataWritesEnabled { get; set; }

    /// <summary>
    /// The analytical_storage_enabled attribute.
    /// </summary>
    [TerraformProperty("analytical_storage_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AnalyticalStorageEnabled { get; set; }

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    [TerraformProperty("automatic_failover_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AutomaticFailoverEnabled { get; set; }

    /// <summary>
    /// The burst_capacity_enabled attribute.
    /// </summary>
    [TerraformProperty("burst_capacity_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? BurstCapacityEnabled { get; set; }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    [TerraformProperty("create_mode")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> CreateMode { get; set; }

    /// <summary>
    /// The default_identity_type attribute.
    /// </summary>
    [TerraformProperty("default_identity_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DefaultIdentityType { get; set; }

    /// <summary>
    /// The free_tier_enabled attribute.
    /// </summary>
    [TerraformProperty("free_tier_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? FreeTierEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ip_range_filter attribute.
    /// </summary>
    [TerraformProperty("ip_range_filter")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? IpRangeFilter { get; set; }

    /// <summary>
    /// The is_virtual_network_filter_enabled attribute.
    /// </summary>
    [TerraformProperty("is_virtual_network_filter_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IsVirtualNetworkFilterEnabled { get; set; }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_key_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KeyVaultKeyId { get; set; }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformProperty("kind")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Kind { get; set; }

    /// <summary>
    /// The local_authentication_disabled attribute.
    /// </summary>
    [TerraformProperty("local_authentication_disabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? LocalAuthenticationDisabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    [TerraformProperty("managed_hsm_key_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ManagedHsmKeyId { get; set; }

    /// <summary>
    /// The minimal_tls_version attribute.
    /// </summary>
    [TerraformProperty("minimal_tls_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MinimalTlsVersion { get; set; }

    /// <summary>
    /// The mongo_server_version attribute.
    /// </summary>
    [TerraformProperty("mongo_server_version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> MongoServerVersion { get; set; }

    /// <summary>
    /// The multiple_write_locations_enabled attribute.
    /// </summary>
    [TerraformProperty("multiple_write_locations_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? MultipleWriteLocationsEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_acl_bypass_for_azure_services attribute.
    /// </summary>
    [TerraformProperty("network_acl_bypass_for_azure_services")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? NetworkAclBypassForAzureServices { get; set; }

    /// <summary>
    /// The network_acl_bypass_ids attribute.
    /// </summary>
    [TerraformProperty("network_acl_bypass_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? NetworkAclBypassIds { get; set; }

    /// <summary>
    /// The offer_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OfferType is required")]
    [TerraformProperty("offer_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> OfferType { get; set; }

    /// <summary>
    /// The partition_merge_enabled attribute.
    /// </summary>
    [TerraformProperty("partition_merge_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PartitionMergeEnabled { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for analytical_storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnalyticalStorage block(s) allowed")]
    [TerraformProperty("analytical_storage")]
    public TerraformList<TerraformBlock<AzurermCosmosdbAccountAnalyticalStorageBlock>>? AnalyticalStorage { get; set; }

    /// <summary>
    /// Block for backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    [TerraformProperty("backup")]
    public TerraformList<TerraformBlock<AzurermCosmosdbAccountBackupBlock>>? Backup { get; set; }

    /// <summary>
    /// Block for capabilities.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("capabilities")]
    public TerraformSet<TerraformBlock<AzurermCosmosdbAccountCapabilitiesBlock>>? Capabilities { get; set; }

    /// <summary>
    /// Block for capacity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Capacity block(s) allowed")]
    [TerraformProperty("capacity")]
    public TerraformList<TerraformBlock<AzurermCosmosdbAccountCapacityBlock>>? Capacity { get; set; }

    /// <summary>
    /// Block for consistency_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsistencyPolicy is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConsistencyPolicy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConsistencyPolicy block(s) allowed")]
    [TerraformProperty("consistency_policy")]
    public TerraformList<TerraformBlock<AzurermCosmosdbAccountConsistencyPolicyBlock>>? ConsistencyPolicy { get; set; }

    /// <summary>
    /// Block for cors_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsRule block(s) allowed")]
    [TerraformProperty("cors_rule")]
    public TerraformList<TerraformBlock<AzurermCosmosdbAccountCorsRuleBlock>>? CorsRule { get; set; }

    /// <summary>
    /// Block for geo_location.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GeoLocation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GeoLocation block(s) required")]
    [TerraformProperty("geo_location")]
    public TerraformSet<TerraformBlock<AzurermCosmosdbAccountGeoLocationBlock>>? GeoLocation { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<TerraformBlock<AzurermCosmosdbAccountIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for restore.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Restore block(s) allowed")]
    [TerraformProperty("restore")]
    public TerraformList<TerraformBlock<AzurermCosmosdbAccountRestoreBlock>>? Restore { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermCosmosdbAccountTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for virtual_network_rule.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("virtual_network_rule")]
    public TerraformSet<TerraformBlock<AzurermCosmosdbAccountVirtualNetworkRuleBlock>>? VirtualNetworkRule { get; set; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [TerraformProperty("primary_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryKey { get; }

    /// <summary>
    /// The primary_mongodb_connection_string attribute.
    /// </summary>
    [TerraformProperty("primary_mongodb_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryMongodbConnectionString { get; }

    /// <summary>
    /// The primary_readonly_key attribute.
    /// </summary>
    [TerraformProperty("primary_readonly_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryReadonlyKey { get; }

    /// <summary>
    /// The primary_readonly_mongodb_connection_string attribute.
    /// </summary>
    [TerraformProperty("primary_readonly_mongodb_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryReadonlyMongodbConnectionString { get; }

    /// <summary>
    /// The primary_readonly_sql_connection_string attribute.
    /// </summary>
    [TerraformProperty("primary_readonly_sql_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryReadonlySqlConnectionString { get; }

    /// <summary>
    /// The primary_sql_connection_string attribute.
    /// </summary>
    [TerraformProperty("primary_sql_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimarySqlConnectionString { get; }

    /// <summary>
    /// The read_endpoints attribute.
    /// </summary>
    [TerraformProperty("read_endpoints")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ReadEndpoints { get; }

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    [TerraformProperty("secondary_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryKey { get; }

    /// <summary>
    /// The secondary_mongodb_connection_string attribute.
    /// </summary>
    [TerraformProperty("secondary_mongodb_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryMongodbConnectionString { get; }

    /// <summary>
    /// The secondary_readonly_key attribute.
    /// </summary>
    [TerraformProperty("secondary_readonly_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryReadonlyKey { get; }

    /// <summary>
    /// The secondary_readonly_mongodb_connection_string attribute.
    /// </summary>
    [TerraformProperty("secondary_readonly_mongodb_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryReadonlyMongodbConnectionString { get; }

    /// <summary>
    /// The secondary_readonly_sql_connection_string attribute.
    /// </summary>
    [TerraformProperty("secondary_readonly_sql_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryReadonlySqlConnectionString { get; }

    /// <summary>
    /// The secondary_sql_connection_string attribute.
    /// </summary>
    [TerraformProperty("secondary_sql_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondarySqlConnectionString { get; }

    /// <summary>
    /// The write_endpoints attribute.
    /// </summary>
    [TerraformProperty("write_endpoints")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> WriteEndpoints { get; }

}
