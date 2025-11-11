using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for analytical_storage in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbAccountAnalyticalStorageBlock
{
    /// <summary>
    /// The schema_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaType is required")]
    [TerraformPropertyName("schema_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SchemaType { get; set; }

}

/// <summary>
/// Block type for backup in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbAccountBackupBlock
{
    /// <summary>
    /// The interval_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("interval_in_minutes")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> IntervalInMinutes { get; set; } = default!;

    /// <summary>
    /// The retention_in_hours attribute.
    /// </summary>
    [TerraformPropertyName("retention_in_hours")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> RetentionInHours { get; set; } = default!;

    /// <summary>
    /// The storage_redundancy attribute.
    /// </summary>
    [TerraformPropertyName("storage_redundancy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StorageRedundancy { get; set; } = default!;

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [TerraformPropertyName("tier")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Tier { get; set; } = default!;

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for capabilities in .
/// Nesting mode: set
/// </summary>
public class AzurermCosmosdbAccountCapabilitiesBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for capacity in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbAccountCapacityBlock
{
    /// <summary>
    /// The total_throughput_limit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalThroughputLimit is required")]
    [TerraformPropertyName("total_throughput_limit")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> TotalThroughputLimit { get; set; }

}

/// <summary>
/// Block type for consistency_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbAccountConsistencyPolicyBlock
{
    /// <summary>
    /// The consistency_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsistencyLevel is required")]
    [TerraformPropertyName("consistency_level")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ConsistencyLevel { get; set; }

    /// <summary>
    /// The max_interval_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("max_interval_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxIntervalInSeconds { get; set; }

    /// <summary>
    /// The max_staleness_prefix attribute.
    /// </summary>
    [TerraformPropertyName("max_staleness_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxStalenessPrefix { get; set; }

}

/// <summary>
/// Block type for cors_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbAccountCorsRuleBlock
{
    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedHeaders is required")]
    [TerraformPropertyName("allowed_headers")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? AllowedHeaders { get; set; }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    [TerraformPropertyName("allowed_methods")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? AllowedMethods { get; set; }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    [TerraformPropertyName("allowed_origins")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? AllowedOrigins { get; set; }

    /// <summary>
    /// The exposed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExposedHeaders is required")]
    [TerraformPropertyName("exposed_headers")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? ExposedHeaders { get; set; }

    /// <summary>
    /// The max_age_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("max_age_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxAgeInSeconds { get; set; }

}

/// <summary>
/// Block type for geo_location in .
/// Nesting mode: set
/// </summary>
public class AzurermCosmosdbAccountGeoLocationBlock
{
    /// <summary>
    /// The failover_priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailoverPriority is required")]
    [TerraformPropertyName("failover_priority")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> FailoverPriority { get; set; }


    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformPropertyName("zone_redundant")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ZoneRedundant { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbAccountIdentityBlock
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
/// Block type for restore in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbAccountRestoreBlock
{
    /// <summary>
    /// The restore_timestamp_in_utc attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestoreTimestampInUtc is required")]
    [TerraformPropertyName("restore_timestamp_in_utc")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RestoreTimestampInUtc { get; set; }

    /// <summary>
    /// The source_cosmosdb_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceCosmosdbAccountId is required")]
    [TerraformPropertyName("source_cosmosdb_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SourceCosmosdbAccountId { get; set; }

    /// <summary>
    /// The tables_to_restore attribute.
    /// </summary>
    [TerraformPropertyName("tables_to_restore")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? TablesToRestore { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbAccountTimeoutsBlock
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
/// Block type for virtual_network_rule in .
/// Nesting mode: set
/// </summary>
public class AzurermCosmosdbAccountVirtualNetworkRuleBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ignore_missing_vnet_service_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("ignore_missing_vnet_service_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IgnoreMissingVnetServiceEndpoint { get; set; }

}

/// <summary>
/// Manages a azurerm_cosmosdb_account resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermCosmosdbAccount : TerraformResource
{
    public AzurermCosmosdbAccount(string name) : base("azurerm_cosmosdb_account", name)
    {
    }

    /// <summary>
    /// The access_key_metadata_writes_enabled attribute.
    /// </summary>
    [TerraformPropertyName("access_key_metadata_writes_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AccessKeyMetadataWritesEnabled { get; set; }

    /// <summary>
    /// The analytical_storage_enabled attribute.
    /// </summary>
    [TerraformPropertyName("analytical_storage_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AnalyticalStorageEnabled { get; set; }

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    [TerraformPropertyName("automatic_failover_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutomaticFailoverEnabled { get; set; }

    /// <summary>
    /// The burst_capacity_enabled attribute.
    /// </summary>
    [TerraformPropertyName("burst_capacity_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? BurstCapacityEnabled { get; set; }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    [TerraformPropertyName("create_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CreateMode { get; set; } = default!;

    /// <summary>
    /// The default_identity_type attribute.
    /// </summary>
    [TerraformPropertyName("default_identity_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultIdentityType { get; set; }

    /// <summary>
    /// The free_tier_enabled attribute.
    /// </summary>
    [TerraformPropertyName("free_tier_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? FreeTierEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ip_range_filter attribute.
    /// </summary>
    [TerraformPropertyName("ip_range_filter")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IpRangeFilter { get; set; }

    /// <summary>
    /// The is_virtual_network_filter_enabled attribute.
    /// </summary>
    [TerraformPropertyName("is_virtual_network_filter_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IsVirtualNetworkFilterEnabled { get; set; }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KeyVaultKeyId { get; set; }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformPropertyName("kind")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Kind { get; set; }

    /// <summary>
    /// The local_authentication_disabled attribute.
    /// </summary>
    [TerraformPropertyName("local_authentication_disabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? LocalAuthenticationDisabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_hsm_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ManagedHsmKeyId { get; set; }

    /// <summary>
    /// The minimal_tls_version attribute.
    /// </summary>
    [TerraformPropertyName("minimal_tls_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MinimalTlsVersion { get; set; }

    /// <summary>
    /// The mongo_server_version attribute.
    /// </summary>
    [TerraformPropertyName("mongo_server_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MongoServerVersion { get; set; } = default!;

    /// <summary>
    /// The multiple_write_locations_enabled attribute.
    /// </summary>
    [TerraformPropertyName("multiple_write_locations_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MultipleWriteLocationsEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_acl_bypass_for_azure_services attribute.
    /// </summary>
    [TerraformPropertyName("network_acl_bypass_for_azure_services")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? NetworkAclBypassForAzureServices { get; set; }

    /// <summary>
    /// The network_acl_bypass_ids attribute.
    /// </summary>
    [TerraformPropertyName("network_acl_bypass_ids")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? NetworkAclBypassIds { get; set; }

    /// <summary>
    /// The offer_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OfferType is required")]
    [TerraformPropertyName("offer_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> OfferType { get; set; }

    /// <summary>
    /// The partition_merge_enabled attribute.
    /// </summary>
    [TerraformPropertyName("partition_merge_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PartitionMergeEnabled { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for analytical_storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnalyticalStorage block(s) allowed")]
    [TerraformPropertyName("analytical_storage")]
    public TerraformList<TerraformBlock<AzurermCosmosdbAccountAnalyticalStorageBlock>>? AnalyticalStorage { get; set; }

    /// <summary>
    /// Block for backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    [TerraformPropertyName("backup")]
    public TerraformList<TerraformBlock<AzurermCosmosdbAccountBackupBlock>>? Backup { get; set; }

    /// <summary>
    /// Block for capabilities.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("capabilities")]
    public TerraformSet<TerraformBlock<AzurermCosmosdbAccountCapabilitiesBlock>>? Capabilities { get; set; }

    /// <summary>
    /// Block for capacity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Capacity block(s) allowed")]
    [TerraformPropertyName("capacity")]
    public TerraformList<TerraformBlock<AzurermCosmosdbAccountCapacityBlock>>? Capacity { get; set; }

    /// <summary>
    /// Block for consistency_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsistencyPolicy is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConsistencyPolicy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConsistencyPolicy block(s) allowed")]
    [TerraformPropertyName("consistency_policy")]
    public TerraformList<TerraformBlock<AzurermCosmosdbAccountConsistencyPolicyBlock>>? ConsistencyPolicy { get; set; }

    /// <summary>
    /// Block for cors_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsRule block(s) allowed")]
    [TerraformPropertyName("cors_rule")]
    public TerraformList<TerraformBlock<AzurermCosmosdbAccountCorsRuleBlock>>? CorsRule { get; set; }

    /// <summary>
    /// Block for geo_location.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GeoLocation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GeoLocation block(s) required")]
    [TerraformPropertyName("geo_location")]
    public TerraformSet<TerraformBlock<AzurermCosmosdbAccountGeoLocationBlock>>? GeoLocation { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermCosmosdbAccountIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for restore.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Restore block(s) allowed")]
    [TerraformPropertyName("restore")]
    public TerraformList<TerraformBlock<AzurermCosmosdbAccountRestoreBlock>>? Restore { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermCosmosdbAccountTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for virtual_network_rule.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("virtual_network_rule")]
    public TerraformSet<TerraformBlock<AzurermCosmosdbAccountVirtualNetworkRuleBlock>>? VirtualNetworkRule { get; set; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Endpoint => new TerraformReference(this, "endpoint");

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryKey => new TerraformReference(this, "primary_key");

    /// <summary>
    /// The primary_mongodb_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("primary_mongodb_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryMongodbConnectionString => new TerraformReference(this, "primary_mongodb_connection_string");

    /// <summary>
    /// The primary_readonly_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_readonly_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryReadonlyKey => new TerraformReference(this, "primary_readonly_key");

    /// <summary>
    /// The primary_readonly_mongodb_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("primary_readonly_mongodb_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryReadonlyMongodbConnectionString => new TerraformReference(this, "primary_readonly_mongodb_connection_string");

    /// <summary>
    /// The primary_readonly_sql_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("primary_readonly_sql_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryReadonlySqlConnectionString => new TerraformReference(this, "primary_readonly_sql_connection_string");

    /// <summary>
    /// The primary_sql_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("primary_sql_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimarySqlConnectionString => new TerraformReference(this, "primary_sql_connection_string");

    /// <summary>
    /// The read_endpoints attribute.
    /// </summary>
    [TerraformPropertyName("read_endpoints")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ReadEndpoints => new TerraformReference(this, "read_endpoints");

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryKey => new TerraformReference(this, "secondary_key");

    /// <summary>
    /// The secondary_mongodb_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("secondary_mongodb_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryMongodbConnectionString => new TerraformReference(this, "secondary_mongodb_connection_string");

    /// <summary>
    /// The secondary_readonly_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_readonly_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryReadonlyKey => new TerraformReference(this, "secondary_readonly_key");

    /// <summary>
    /// The secondary_readonly_mongodb_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("secondary_readonly_mongodb_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryReadonlyMongodbConnectionString => new TerraformReference(this, "secondary_readonly_mongodb_connection_string");

    /// <summary>
    /// The secondary_readonly_sql_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("secondary_readonly_sql_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryReadonlySqlConnectionString => new TerraformReference(this, "secondary_readonly_sql_connection_string");

    /// <summary>
    /// The secondary_sql_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("secondary_sql_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondarySqlConnectionString => new TerraformReference(this, "secondary_sql_connection_string");

    /// <summary>
    /// The write_endpoints attribute.
    /// </summary>
    [TerraformPropertyName("write_endpoints")]
    // Output-only attribute - read-only reference
    public TerraformList<string> WriteEndpoints => new TerraformReference(this, "write_endpoints");

}
