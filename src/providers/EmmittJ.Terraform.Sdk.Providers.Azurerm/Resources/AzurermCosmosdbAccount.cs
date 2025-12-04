using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for analytical_storage in AzurermCosmosdbAccount.
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
    public required TerraformValue<string> SchemaType
    {
        get => GetRequiredArgument<TerraformValue<string>>("schema_type");
        set => SetArgument("schema_type", value);
    }

}


/// <summary>
/// Block type for backup in AzurermCosmosdbAccount.
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
    public TerraformValue<double> IntervalInMinutes
    {
        get => GetArgument<TerraformValue<double>>("interval_in_minutes") ?? AsReference("interval_in_minutes");
        set => SetArgument("interval_in_minutes", value);
    }

    /// <summary>
    /// The retention_in_hours attribute.
    /// </summary>
    public TerraformValue<double> RetentionInHours
    {
        get => GetArgument<TerraformValue<double>>("retention_in_hours") ?? AsReference("retention_in_hours");
        set => SetArgument("retention_in_hours", value);
    }

    /// <summary>
    /// The storage_redundancy attribute.
    /// </summary>
    public TerraformValue<string> StorageRedundancy
    {
        get => GetArgument<TerraformValue<string>>("storage_redundancy") ?? AsReference("storage_redundancy");
        set => SetArgument("storage_redundancy", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformValue<string> Tier
    {
        get => GetArgument<TerraformValue<string>>("tier") ?? AsReference("tier");
        set => SetArgument("tier", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for capabilities in AzurermCosmosdbAccount.
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
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for capacity in AzurermCosmosdbAccount.
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
    public required TerraformValue<double> TotalThroughputLimit
    {
        get => GetRequiredArgument<TerraformValue<double>>("total_throughput_limit");
        set => SetArgument("total_throughput_limit", value);
    }

}


/// <summary>
/// Block type for consistency_policy in AzurermCosmosdbAccount.
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
    public required TerraformValue<string> ConsistencyLevel
    {
        get => GetRequiredArgument<TerraformValue<string>>("consistency_level");
        set => SetArgument("consistency_level", value);
    }

    /// <summary>
    /// The max_interval_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? MaxIntervalInSeconds
    {
        get => GetArgument<TerraformValue<double>>("max_interval_in_seconds");
        set => SetArgument("max_interval_in_seconds", value);
    }

    /// <summary>
    /// The max_staleness_prefix attribute.
    /// </summary>
    public TerraformValue<double>? MaxStalenessPrefix
    {
        get => GetArgument<TerraformValue<double>>("max_staleness_prefix");
        set => SetArgument("max_staleness_prefix", value);
    }

}


/// <summary>
/// Block type for cors_rule in AzurermCosmosdbAccount.
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
    public TerraformList<string>? AllowedHeaders
    {
        get => GetArgument<TerraformList<string>>("allowed_headers");
        set => SetArgument("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    public TerraformList<string>? AllowedMethods
    {
        get => GetArgument<TerraformList<string>>("allowed_methods");
        set => SetArgument("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    public TerraformList<string>? AllowedOrigins
    {
        get => GetArgument<TerraformList<string>>("allowed_origins");
        set => SetArgument("allowed_origins", value);
    }

    /// <summary>
    /// The exposed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExposedHeaders is required")]
    public TerraformList<string>? ExposedHeaders
    {
        get => GetArgument<TerraformList<string>>("exposed_headers");
        set => SetArgument("exposed_headers", value);
    }

    /// <summary>
    /// The max_age_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? MaxAgeInSeconds
    {
        get => GetArgument<TerraformValue<double>>("max_age_in_seconds");
        set => SetArgument("max_age_in_seconds", value);
    }

}


/// <summary>
/// Block type for geo_location in AzurermCosmosdbAccount.
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
    public required TerraformValue<double> FailoverPriority
    {
        get => GetRequiredArgument<TerraformValue<double>>("failover_priority");
        set => SetArgument("failover_priority", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformValue<bool>? ZoneRedundant
    {
        get => GetArgument<TerraformValue<bool>>("zone_redundant");
        set => SetArgument("zone_redundant", value);
    }

}


/// <summary>
/// Block type for identity in AzurermCosmosdbAccount.
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
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for restore in AzurermCosmosdbAccount.
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
    public required TerraformValue<string> RestoreTimestampInUtc
    {
        get => GetRequiredArgument<TerraformValue<string>>("restore_timestamp_in_utc");
        set => SetArgument("restore_timestamp_in_utc", value);
    }

    /// <summary>
    /// The source_cosmosdb_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceCosmosdbAccountId is required")]
    public required TerraformValue<string> SourceCosmosdbAccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("source_cosmosdb_account_id");
        set => SetArgument("source_cosmosdb_account_id", value);
    }

    /// <summary>
    /// The tables_to_restore attribute.
    /// </summary>
    public TerraformList<string>? TablesToRestore
    {
        get => GetArgument<TerraformList<string>>("tables_to_restore");
        set => SetArgument("tables_to_restore", value);
    }

    /// <summary>
    /// Database block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermCosmosdbAccountRestoreBlockDatabaseBlock>? Database
    {
        get => GetArgument<TerraformSet<AzurermCosmosdbAccountRestoreBlockDatabaseBlock>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// GremlinDatabase block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCosmosdbAccountRestoreBlockGremlinDatabaseBlock>? GremlinDatabase
    {
        get => GetArgument<TerraformList<AzurermCosmosdbAccountRestoreBlockGremlinDatabaseBlock>>("gremlin_database");
        set => SetArgument("gremlin_database", value);
    }

}

/// <summary>
/// Block type for database in AzurermCosmosdbAccountRestoreBlock.
/// Nesting mode: set
/// </summary>
public class AzurermCosmosdbAccountRestoreBlockDatabaseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "database";

    /// <summary>
    /// The collection_names attribute.
    /// </summary>
    public TerraformSet<string>? CollectionNames
    {
        get => GetArgument<TerraformSet<string>>("collection_names");
        set => SetArgument("collection_names", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for gremlin_database in AzurermCosmosdbAccountRestoreBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbAccountRestoreBlockGremlinDatabaseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gremlin_database";

    /// <summary>
    /// The graph_names attribute.
    /// </summary>
    public TerraformList<string>? GraphNames
    {
        get => GetArgument<TerraformList<string>>("graph_names");
        set => SetArgument("graph_names", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermCosmosdbAccount.
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
/// Block type for virtual_network_rule in AzurermCosmosdbAccount.
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
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ignore_missing_vnet_service_endpoint attribute.
    /// </summary>
    public TerraformValue<bool>? IgnoreMissingVnetServiceEndpoint
    {
        get => GetArgument<TerraformValue<bool>>("ignore_missing_vnet_service_endpoint");
        set => SetArgument("ignore_missing_vnet_service_endpoint", value);
    }

}


/// <summary>
/// Represents a azurerm_cosmosdb_account Terraform resource.
/// Manages a azurerm_cosmosdb_account resource.
/// </summary>
public partial class AzurermCosmosdbAccount(string name) : TerraformResource("azurerm_cosmosdb_account", name)
{
    /// <summary>
    /// The access_key_metadata_writes_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AccessKeyMetadataWritesEnabled
    {
        get => GetArgument<TerraformValue<bool>>("access_key_metadata_writes_enabled");
        set => SetArgument("access_key_metadata_writes_enabled", value);
    }

    /// <summary>
    /// The analytical_storage_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AnalyticalStorageEnabled
    {
        get => GetArgument<TerraformValue<bool>>("analytical_storage_enabled");
        set => SetArgument("analytical_storage_enabled", value);
    }

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutomaticFailoverEnabled
    {
        get => GetArgument<TerraformValue<bool>>("automatic_failover_enabled");
        set => SetArgument("automatic_failover_enabled", value);
    }

    /// <summary>
    /// The burst_capacity_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? BurstCapacityEnabled
    {
        get => GetArgument<TerraformValue<bool>>("burst_capacity_enabled");
        set => SetArgument("burst_capacity_enabled", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public TerraformValue<string> CreateMode
    {
        get => GetArgument<TerraformValue<string>>("create_mode") ?? AsReference("create_mode");
        set => SetArgument("create_mode", value);
    }

    /// <summary>
    /// The default_identity_type attribute.
    /// </summary>
    public TerraformValue<string>? DefaultIdentityType
    {
        get => GetArgument<TerraformValue<string>>("default_identity_type");
        set => SetArgument("default_identity_type", value);
    }

    /// <summary>
    /// The free_tier_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? FreeTierEnabled
    {
        get => GetArgument<TerraformValue<bool>>("free_tier_enabled");
        set => SetArgument("free_tier_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ip_range_filter attribute.
    /// </summary>
    public TerraformSet<string>? IpRangeFilter
    {
        get => GetArgument<TerraformSet<string>>("ip_range_filter");
        set => SetArgument("ip_range_filter", value);
    }

    /// <summary>
    /// The is_virtual_network_filter_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? IsVirtualNetworkFilterEnabled
    {
        get => GetArgument<TerraformValue<bool>>("is_virtual_network_filter_enabled");
        set => SetArgument("is_virtual_network_filter_enabled", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyVaultKeyId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string>? Kind
    {
        get => GetArgument<TerraformValue<string>>("kind");
        set => SetArgument("kind", value);
    }

    /// <summary>
    /// The local_authentication_disabled attribute.
    /// </summary>
    public TerraformValue<bool>? LocalAuthenticationDisabled
    {
        get => GetArgument<TerraformValue<bool>>("local_authentication_disabled");
        set => SetArgument("local_authentication_disabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    public TerraformValue<string>? ManagedHsmKeyId
    {
        get => GetArgument<TerraformValue<string>>("managed_hsm_key_id");
        set => SetArgument("managed_hsm_key_id", value);
    }

    /// <summary>
    /// The minimal_tls_version attribute.
    /// </summary>
    public TerraformValue<string>? MinimalTlsVersion
    {
        get => GetArgument<TerraformValue<string>>("minimal_tls_version");
        set => SetArgument("minimal_tls_version", value);
    }

    /// <summary>
    /// The mongo_server_version attribute.
    /// </summary>
    public TerraformValue<string> MongoServerVersion
    {
        get => GetArgument<TerraformValue<string>>("mongo_server_version") ?? AsReference("mongo_server_version");
        set => SetArgument("mongo_server_version", value);
    }

    /// <summary>
    /// The multiple_write_locations_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? MultipleWriteLocationsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("multiple_write_locations_enabled");
        set => SetArgument("multiple_write_locations_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_acl_bypass_for_azure_services attribute.
    /// </summary>
    public TerraformValue<bool>? NetworkAclBypassForAzureServices
    {
        get => GetArgument<TerraformValue<bool>>("network_acl_bypass_for_azure_services");
        set => SetArgument("network_acl_bypass_for_azure_services", value);
    }

    /// <summary>
    /// The network_acl_bypass_ids attribute.
    /// </summary>
    public TerraformList<string>? NetworkAclBypassIds
    {
        get => GetArgument<TerraformList<string>>("network_acl_bypass_ids");
        set => SetArgument("network_acl_bypass_ids", value);
    }

    /// <summary>
    /// The offer_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OfferType is required")]
    public required TerraformValue<string> OfferType
    {
        get => GetRequiredArgument<TerraformValue<string>>("offer_type");
        set => SetArgument("offer_type", value);
    }

    /// <summary>
    /// The partition_merge_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PartitionMergeEnabled
    {
        get => GetArgument<TerraformValue<bool>>("partition_merge_enabled");
        set => SetArgument("partition_merge_enabled", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
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
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryKey
        => AsReference("primary_key");

    /// <summary>
    /// The primary_mongodb_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimaryMongodbConnectionString
        => AsReference("primary_mongodb_connection_string");

    /// <summary>
    /// The primary_readonly_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryReadonlyKey
        => AsReference("primary_readonly_key");

    /// <summary>
    /// The primary_readonly_mongodb_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimaryReadonlyMongodbConnectionString
        => AsReference("primary_readonly_mongodb_connection_string");

    /// <summary>
    /// The primary_readonly_sql_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimaryReadonlySqlConnectionString
        => AsReference("primary_readonly_sql_connection_string");

    /// <summary>
    /// The primary_sql_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimarySqlConnectionString
        => AsReference("primary_sql_connection_string");

    /// <summary>
    /// The read_endpoints attribute.
    /// </summary>
    public TerraformList<string> ReadEndpoints
        => AsReference("read_endpoints");

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryKey
        => AsReference("secondary_key");

    /// <summary>
    /// The secondary_mongodb_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondaryMongodbConnectionString
        => AsReference("secondary_mongodb_connection_string");

    /// <summary>
    /// The secondary_readonly_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryReadonlyKey
        => AsReference("secondary_readonly_key");

    /// <summary>
    /// The secondary_readonly_mongodb_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondaryReadonlyMongodbConnectionString
        => AsReference("secondary_readonly_mongodb_connection_string");

    /// <summary>
    /// The secondary_readonly_sql_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondaryReadonlySqlConnectionString
        => AsReference("secondary_readonly_sql_connection_string");

    /// <summary>
    /// The secondary_sql_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondarySqlConnectionString
        => AsReference("secondary_sql_connection_string");

    /// <summary>
    /// The write_endpoints attribute.
    /// </summary>
    public TerraformList<string> WriteEndpoints
        => AsReference("write_endpoints");

    /// <summary>
    /// AnalyticalStorage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnalyticalStorage block(s) allowed")]
    public TerraformList<AzurermCosmosdbAccountAnalyticalStorageBlock>? AnalyticalStorage
    {
        get => GetArgument<TerraformList<AzurermCosmosdbAccountAnalyticalStorageBlock>>("analytical_storage");
        set => SetArgument("analytical_storage", value);
    }

    /// <summary>
    /// Backup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    public TerraformList<AzurermCosmosdbAccountBackupBlock>? Backup
    {
        get => GetArgument<TerraformList<AzurermCosmosdbAccountBackupBlock>>("backup");
        set => SetArgument("backup", value);
    }

    /// <summary>
    /// Capabilities block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermCosmosdbAccountCapabilitiesBlock>? Capabilities
    {
        get => GetArgument<TerraformSet<AzurermCosmosdbAccountCapabilitiesBlock>>("capabilities");
        set => SetArgument("capabilities", value);
    }

    /// <summary>
    /// Capacity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Capacity block(s) allowed")]
    public TerraformList<AzurermCosmosdbAccountCapacityBlock>? Capacity
    {
        get => GetArgument<TerraformList<AzurermCosmosdbAccountCapacityBlock>>("capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// ConsistencyPolicy block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsistencyPolicy is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConsistencyPolicy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConsistencyPolicy block(s) allowed")]
    public required TerraformList<AzurermCosmosdbAccountConsistencyPolicyBlock> ConsistencyPolicy
    {
        get => GetRequiredArgument<TerraformList<AzurermCosmosdbAccountConsistencyPolicyBlock>>("consistency_policy");
        set => SetArgument("consistency_policy", value);
    }

    /// <summary>
    /// CorsRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsRule block(s) allowed")]
    public TerraformList<AzurermCosmosdbAccountCorsRuleBlock>? CorsRule
    {
        get => GetArgument<TerraformList<AzurermCosmosdbAccountCorsRuleBlock>>("cors_rule");
        set => SetArgument("cors_rule", value);
    }

    /// <summary>
    /// GeoLocation block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GeoLocation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GeoLocation block(s) required")]
    public required TerraformSet<AzurermCosmosdbAccountGeoLocationBlock> GeoLocation
    {
        get => GetRequiredArgument<TerraformSet<AzurermCosmosdbAccountGeoLocationBlock>>("geo_location");
        set => SetArgument("geo_location", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermCosmosdbAccountIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermCosmosdbAccountIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Restore block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Restore block(s) allowed")]
    public TerraformList<AzurermCosmosdbAccountRestoreBlock>? Restore
    {
        get => GetArgument<TerraformList<AzurermCosmosdbAccountRestoreBlock>>("restore");
        set => SetArgument("restore", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCosmosdbAccountTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCosmosdbAccountTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VirtualNetworkRule block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermCosmosdbAccountVirtualNetworkRuleBlock>? VirtualNetworkRule
    {
        get => GetArgument<TerraformSet<AzurermCosmosdbAccountVirtualNetworkRuleBlock>>("virtual_network_rule");
        set => SetArgument("virtual_network_rule", value);
    }

}
