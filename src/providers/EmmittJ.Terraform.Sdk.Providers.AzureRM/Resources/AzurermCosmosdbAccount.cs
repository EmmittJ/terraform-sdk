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
/// Block type for analytical_storage in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbAccountAnalyticalStorageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "analytical_storage";

    /// <summary>
    /// The schema_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaType is required")]
    [TerraformArgument("schema_type")]
    public required TerraformValue<string> SchemaType
    {
        get => new TerraformReference<string>(this, "schema_type");
        set => SetArgument("schema_type", value);
    }

}

/// <summary>
/// Block type for backup in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbAccountBackupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backup";

    /// <summary>
    /// The interval_in_minutes attribute.
    /// </summary>
    [TerraformArgument("interval_in_minutes")]
    public TerraformValue<double> IntervalInMinutes
    {
        get => new TerraformReference<double>(this, "interval_in_minutes");
        set => SetArgument("interval_in_minutes", value);
    }

    /// <summary>
    /// The retention_in_hours attribute.
    /// </summary>
    [TerraformArgument("retention_in_hours")]
    public TerraformValue<double> RetentionInHours
    {
        get => new TerraformReference<double>(this, "retention_in_hours");
        set => SetArgument("retention_in_hours", value);
    }

    /// <summary>
    /// The storage_redundancy attribute.
    /// </summary>
    [TerraformArgument("storage_redundancy")]
    public TerraformValue<string> StorageRedundancy
    {
        get => new TerraformReference<string>(this, "storage_redundancy");
        set => SetArgument("storage_redundancy", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [TerraformArgument("tier")]
    public TerraformValue<string> Tier
    {
        get => new TerraformReference<string>(this, "tier");
        set => SetArgument("tier", value);
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
/// Block type for capabilities in .
/// Nesting mode: set
/// </summary>
public class AzurermCosmosdbAccountCapabilitiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capabilities";

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

}

/// <summary>
/// Block type for capacity in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbAccountCapacityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capacity";

    /// <summary>
    /// The total_throughput_limit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalThroughputLimit is required")]
    [TerraformArgument("total_throughput_limit")]
    public required TerraformValue<double> TotalThroughputLimit
    {
        get => new TerraformReference<double>(this, "total_throughput_limit");
        set => SetArgument("total_throughput_limit", value);
    }

}

/// <summary>
/// Block type for consistency_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbAccountConsistencyPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "consistency_policy";

    /// <summary>
    /// The consistency_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsistencyLevel is required")]
    [TerraformArgument("consistency_level")]
    public required TerraformValue<string> ConsistencyLevel
    {
        get => new TerraformReference<string>(this, "consistency_level");
        set => SetArgument("consistency_level", value);
    }

    /// <summary>
    /// The max_interval_in_seconds attribute.
    /// </summary>
    [TerraformArgument("max_interval_in_seconds")]
    public TerraformValue<double>? MaxIntervalInSeconds
    {
        get => new TerraformReference<double>(this, "max_interval_in_seconds");
        set => SetArgument("max_interval_in_seconds", value);
    }

    /// <summary>
    /// The max_staleness_prefix attribute.
    /// </summary>
    [TerraformArgument("max_staleness_prefix")]
    public TerraformValue<double>? MaxStalenessPrefix
    {
        get => new TerraformReference<double>(this, "max_staleness_prefix");
        set => SetArgument("max_staleness_prefix", value);
    }

}

/// <summary>
/// Block type for cors_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbAccountCorsRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors_rule";

    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedHeaders is required")]
    [TerraformArgument("allowed_headers")]
    public TerraformList<string>? AllowedHeaders
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_headers").ResolveNodes(ctx));
        set => SetArgument("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    [TerraformArgument("allowed_methods")]
    public TerraformList<string>? AllowedMethods
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_methods").ResolveNodes(ctx));
        set => SetArgument("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    [TerraformArgument("allowed_origins")]
    public TerraformList<string>? AllowedOrigins
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_origins").ResolveNodes(ctx));
        set => SetArgument("allowed_origins", value);
    }

    /// <summary>
    /// The exposed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExposedHeaders is required")]
    [TerraformArgument("exposed_headers")]
    public TerraformList<string>? ExposedHeaders
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "exposed_headers").ResolveNodes(ctx));
        set => SetArgument("exposed_headers", value);
    }

    /// <summary>
    /// The max_age_in_seconds attribute.
    /// </summary>
    [TerraformArgument("max_age_in_seconds")]
    public TerraformValue<double>? MaxAgeInSeconds
    {
        get => new TerraformReference<double>(this, "max_age_in_seconds");
        set => SetArgument("max_age_in_seconds", value);
    }

}

/// <summary>
/// Block type for geo_location in .
/// Nesting mode: set
/// </summary>
public class AzurermCosmosdbAccountGeoLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "geo_location";

    /// <summary>
    /// The failover_priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailoverPriority is required")]
    [TerraformArgument("failover_priority")]
    public required TerraformValue<double> FailoverPriority
    {
        get => new TerraformReference<double>(this, "failover_priority");
        set => SetArgument("failover_priority", value);
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
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformArgument("zone_redundant")]
    public TerraformValue<bool>? ZoneRedundant
    {
        get => new TerraformReference<bool>(this, "zone_redundant");
        set => SetArgument("zone_redundant", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbAccountIdentityBlock : TerraformBlock
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
/// Block type for restore in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbAccountRestoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "restore";

    /// <summary>
    /// The restore_timestamp_in_utc attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestoreTimestampInUtc is required")]
    [TerraformArgument("restore_timestamp_in_utc")]
    public required TerraformValue<string> RestoreTimestampInUtc
    {
        get => new TerraformReference<string>(this, "restore_timestamp_in_utc");
        set => SetArgument("restore_timestamp_in_utc", value);
    }

    /// <summary>
    /// The source_cosmosdb_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceCosmosdbAccountId is required")]
    [TerraformArgument("source_cosmosdb_account_id")]
    public required TerraformValue<string> SourceCosmosdbAccountId
    {
        get => new TerraformReference<string>(this, "source_cosmosdb_account_id");
        set => SetArgument("source_cosmosdb_account_id", value);
    }

    /// <summary>
    /// The tables_to_restore attribute.
    /// </summary>
    [TerraformArgument("tables_to_restore")]
    public TerraformList<string>? TablesToRestore
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "tables_to_restore").ResolveNodes(ctx));
        set => SetArgument("tables_to_restore", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbAccountTimeoutsBlock : TerraformBlock
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
/// Block type for virtual_network_rule in .
/// Nesting mode: set
/// </summary>
public class AzurermCosmosdbAccountVirtualNetworkRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_network_rule";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformArgument("id")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ignore_missing_vnet_service_endpoint attribute.
    /// </summary>
    [TerraformArgument("ignore_missing_vnet_service_endpoint")]
    public TerraformValue<bool>? IgnoreMissingVnetServiceEndpoint
    {
        get => new TerraformReference<bool>(this, "ignore_missing_vnet_service_endpoint");
        set => SetArgument("ignore_missing_vnet_service_endpoint", value);
    }

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
    [TerraformArgument("access_key_metadata_writes_enabled")]
    public TerraformValue<bool>? AccessKeyMetadataWritesEnabled
    {
        get => new TerraformReference<bool>(this, "access_key_metadata_writes_enabled");
        set => SetArgument("access_key_metadata_writes_enabled", value);
    }

    /// <summary>
    /// The analytical_storage_enabled attribute.
    /// </summary>
    [TerraformArgument("analytical_storage_enabled")]
    public TerraformValue<bool>? AnalyticalStorageEnabled
    {
        get => new TerraformReference<bool>(this, "analytical_storage_enabled");
        set => SetArgument("analytical_storage_enabled", value);
    }

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    [TerraformArgument("automatic_failover_enabled")]
    public TerraformValue<bool>? AutomaticFailoverEnabled
    {
        get => new TerraformReference<bool>(this, "automatic_failover_enabled");
        set => SetArgument("automatic_failover_enabled", value);
    }

    /// <summary>
    /// The burst_capacity_enabled attribute.
    /// </summary>
    [TerraformArgument("burst_capacity_enabled")]
    public TerraformValue<bool>? BurstCapacityEnabled
    {
        get => new TerraformReference<bool>(this, "burst_capacity_enabled");
        set => SetArgument("burst_capacity_enabled", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    [TerraformArgument("create_mode")]
    public TerraformValue<string> CreateMode
    {
        get => new TerraformReference<string>(this, "create_mode");
        set => SetArgument("create_mode", value);
    }

    /// <summary>
    /// The default_identity_type attribute.
    /// </summary>
    [TerraformArgument("default_identity_type")]
    public TerraformValue<string>? DefaultIdentityType
    {
        get => new TerraformReference<string>(this, "default_identity_type");
        set => SetArgument("default_identity_type", value);
    }

    /// <summary>
    /// The free_tier_enabled attribute.
    /// </summary>
    [TerraformArgument("free_tier_enabled")]
    public TerraformValue<bool>? FreeTierEnabled
    {
        get => new TerraformReference<bool>(this, "free_tier_enabled");
        set => SetArgument("free_tier_enabled", value);
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
    /// The ip_range_filter attribute.
    /// </summary>
    [TerraformArgument("ip_range_filter")]
    public TerraformSet<string>? IpRangeFilter
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ip_range_filter").ResolveNodes(ctx));
        set => SetArgument("ip_range_filter", value);
    }

    /// <summary>
    /// The is_virtual_network_filter_enabled attribute.
    /// </summary>
    [TerraformArgument("is_virtual_network_filter_enabled")]
    public TerraformValue<bool>? IsVirtualNetworkFilterEnabled
    {
        get => new TerraformReference<bool>(this, "is_virtual_network_filter_enabled");
        set => SetArgument("is_virtual_network_filter_enabled", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [TerraformArgument("key_vault_key_id")]
    public TerraformValue<string>? KeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformArgument("kind")]
    public TerraformValue<string>? Kind
    {
        get => new TerraformReference<string>(this, "kind");
        set => SetArgument("kind", value);
    }

    /// <summary>
    /// The local_authentication_disabled attribute.
    /// </summary>
    [TerraformArgument("local_authentication_disabled")]
    public TerraformValue<bool>? LocalAuthenticationDisabled
    {
        get => new TerraformReference<bool>(this, "local_authentication_disabled");
        set => SetArgument("local_authentication_disabled", value);
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
    /// The managed_hsm_key_id attribute.
    /// </summary>
    [TerraformArgument("managed_hsm_key_id")]
    public TerraformValue<string>? ManagedHsmKeyId
    {
        get => new TerraformReference<string>(this, "managed_hsm_key_id");
        set => SetArgument("managed_hsm_key_id", value);
    }

    /// <summary>
    /// The minimal_tls_version attribute.
    /// </summary>
    [TerraformArgument("minimal_tls_version")]
    public TerraformValue<string>? MinimalTlsVersion
    {
        get => new TerraformReference<string>(this, "minimal_tls_version");
        set => SetArgument("minimal_tls_version", value);
    }

    /// <summary>
    /// The mongo_server_version attribute.
    /// </summary>
    [TerraformArgument("mongo_server_version")]
    public TerraformValue<string> MongoServerVersion
    {
        get => new TerraformReference<string>(this, "mongo_server_version");
        set => SetArgument("mongo_server_version", value);
    }

    /// <summary>
    /// The multiple_write_locations_enabled attribute.
    /// </summary>
    [TerraformArgument("multiple_write_locations_enabled")]
    public TerraformValue<bool>? MultipleWriteLocationsEnabled
    {
        get => new TerraformReference<bool>(this, "multiple_write_locations_enabled");
        set => SetArgument("multiple_write_locations_enabled", value);
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
    /// The network_acl_bypass_for_azure_services attribute.
    /// </summary>
    [TerraformArgument("network_acl_bypass_for_azure_services")]
    public TerraformValue<bool>? NetworkAclBypassForAzureServices
    {
        get => new TerraformReference<bool>(this, "network_acl_bypass_for_azure_services");
        set => SetArgument("network_acl_bypass_for_azure_services", value);
    }

    /// <summary>
    /// The network_acl_bypass_ids attribute.
    /// </summary>
    [TerraformArgument("network_acl_bypass_ids")]
    public TerraformList<string>? NetworkAclBypassIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "network_acl_bypass_ids").ResolveNodes(ctx));
        set => SetArgument("network_acl_bypass_ids", value);
    }

    /// <summary>
    /// The offer_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OfferType is required")]
    [TerraformArgument("offer_type")]
    public required TerraformValue<string> OfferType
    {
        get => new TerraformReference<string>(this, "offer_type");
        set => SetArgument("offer_type", value);
    }

    /// <summary>
    /// The partition_merge_enabled attribute.
    /// </summary>
    [TerraformArgument("partition_merge_enabled")]
    public TerraformValue<bool>? PartitionMergeEnabled
    {
        get => new TerraformReference<bool>(this, "partition_merge_enabled");
        set => SetArgument("partition_merge_enabled", value);
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
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for analytical_storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnalyticalStorage block(s) allowed")]
    [TerraformArgument("analytical_storage")]
    public TerraformList<AzurermCosmosdbAccountAnalyticalStorageBlock> AnalyticalStorage { get; set; } = new();

    /// <summary>
    /// Block for backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    [TerraformArgument("backup")]
    public TerraformList<AzurermCosmosdbAccountBackupBlock> Backup { get; set; } = new();

    /// <summary>
    /// Block for capabilities.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("capabilities")]
    public TerraformSet<AzurermCosmosdbAccountCapabilitiesBlock> Capabilities { get; set; } = new();

    /// <summary>
    /// Block for capacity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Capacity block(s) allowed")]
    [TerraformArgument("capacity")]
    public TerraformList<AzurermCosmosdbAccountCapacityBlock> Capacity { get; set; } = new();

    /// <summary>
    /// Block for consistency_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsistencyPolicy is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConsistencyPolicy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConsistencyPolicy block(s) allowed")]
    [TerraformArgument("consistency_policy")]
    public required TerraformList<AzurermCosmosdbAccountConsistencyPolicyBlock> ConsistencyPolicy { get; set; } = new();

    /// <summary>
    /// Block for cors_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsRule block(s) allowed")]
    [TerraformArgument("cors_rule")]
    public TerraformList<AzurermCosmosdbAccountCorsRuleBlock> CorsRule { get; set; } = new();

    /// <summary>
    /// Block for geo_location.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GeoLocation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GeoLocation block(s) required")]
    [TerraformArgument("geo_location")]
    public required TerraformSet<AzurermCosmosdbAccountGeoLocationBlock> GeoLocation { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermCosmosdbAccountIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for restore.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Restore block(s) allowed")]
    [TerraformArgument("restore")]
    public TerraformList<AzurermCosmosdbAccountRestoreBlock> Restore { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermCosmosdbAccountTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for virtual_network_rule.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("virtual_network_rule")]
    public TerraformSet<AzurermCosmosdbAccountVirtualNetworkRuleBlock> VirtualNetworkRule { get; set; } = new();

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformArgument("endpoint")]
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [TerraformArgument("primary_key")]
    public TerraformValue<string> PrimaryKey
    {
        get => new TerraformReference<string>(this, "primary_key");
    }

    /// <summary>
    /// The primary_mongodb_connection_string attribute.
    /// </summary>
    [TerraformArgument("primary_mongodb_connection_string")]
    public TerraformValue<string> PrimaryMongodbConnectionString
    {
        get => new TerraformReference<string>(this, "primary_mongodb_connection_string");
    }

    /// <summary>
    /// The primary_readonly_key attribute.
    /// </summary>
    [TerraformArgument("primary_readonly_key")]
    public TerraformValue<string> PrimaryReadonlyKey
    {
        get => new TerraformReference<string>(this, "primary_readonly_key");
    }

    /// <summary>
    /// The primary_readonly_mongodb_connection_string attribute.
    /// </summary>
    [TerraformArgument("primary_readonly_mongodb_connection_string")]
    public TerraformValue<string> PrimaryReadonlyMongodbConnectionString
    {
        get => new TerraformReference<string>(this, "primary_readonly_mongodb_connection_string");
    }

    /// <summary>
    /// The primary_readonly_sql_connection_string attribute.
    /// </summary>
    [TerraformArgument("primary_readonly_sql_connection_string")]
    public TerraformValue<string> PrimaryReadonlySqlConnectionString
    {
        get => new TerraformReference<string>(this, "primary_readonly_sql_connection_string");
    }

    /// <summary>
    /// The primary_sql_connection_string attribute.
    /// </summary>
    [TerraformArgument("primary_sql_connection_string")]
    public TerraformValue<string> PrimarySqlConnectionString
    {
        get => new TerraformReference<string>(this, "primary_sql_connection_string");
    }

    /// <summary>
    /// The read_endpoints attribute.
    /// </summary>
    [TerraformArgument("read_endpoints")]
    public TerraformList<string> ReadEndpoints
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "read_endpoints").ResolveNodes(ctx));
    }

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    [TerraformArgument("secondary_key")]
    public TerraformValue<string> SecondaryKey
    {
        get => new TerraformReference<string>(this, "secondary_key");
    }

    /// <summary>
    /// The secondary_mongodb_connection_string attribute.
    /// </summary>
    [TerraformArgument("secondary_mongodb_connection_string")]
    public TerraformValue<string> SecondaryMongodbConnectionString
    {
        get => new TerraformReference<string>(this, "secondary_mongodb_connection_string");
    }

    /// <summary>
    /// The secondary_readonly_key attribute.
    /// </summary>
    [TerraformArgument("secondary_readonly_key")]
    public TerraformValue<string> SecondaryReadonlyKey
    {
        get => new TerraformReference<string>(this, "secondary_readonly_key");
    }

    /// <summary>
    /// The secondary_readonly_mongodb_connection_string attribute.
    /// </summary>
    [TerraformArgument("secondary_readonly_mongodb_connection_string")]
    public TerraformValue<string> SecondaryReadonlyMongodbConnectionString
    {
        get => new TerraformReference<string>(this, "secondary_readonly_mongodb_connection_string");
    }

    /// <summary>
    /// The secondary_readonly_sql_connection_string attribute.
    /// </summary>
    [TerraformArgument("secondary_readonly_sql_connection_string")]
    public TerraformValue<string> SecondaryReadonlySqlConnectionString
    {
        get => new TerraformReference<string>(this, "secondary_readonly_sql_connection_string");
    }

    /// <summary>
    /// The secondary_sql_connection_string attribute.
    /// </summary>
    [TerraformArgument("secondary_sql_connection_string")]
    public TerraformValue<string> SecondarySqlConnectionString
    {
        get => new TerraformReference<string>(this, "secondary_sql_connection_string");
    }

    /// <summary>
    /// The write_endpoints attribute.
    /// </summary>
    [TerraformArgument("write_endpoints")]
    public TerraformList<string> WriteEndpoints
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "write_endpoints").ResolveNodes(ctx));
    }

}
