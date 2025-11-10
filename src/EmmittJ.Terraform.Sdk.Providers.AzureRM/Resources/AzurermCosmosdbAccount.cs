using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for analytical_storage in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbAccountAnalyticalStorageBlock : TerraformBlock
{
    /// <summary>
    /// The schema_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaType is required")]
    public required TerraformProperty<string> SchemaType
    {
        get => GetProperty<TerraformProperty<string>>("schema_type");
        set => WithProperty("schema_type", value);
    }

}

/// <summary>
/// Block type for backup in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbAccountBackupBlock : TerraformBlock
{
    /// <summary>
    /// The interval_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? IntervalInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("interval_in_minutes");
        set => WithProperty("interval_in_minutes", value);
    }

    /// <summary>
    /// The retention_in_hours attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionInHours
    {
        get => GetProperty<TerraformProperty<double>>("retention_in_hours");
        set => WithProperty("retention_in_hours", value);
    }

    /// <summary>
    /// The storage_redundancy attribute.
    /// </summary>
    public TerraformProperty<string>? StorageRedundancy
    {
        get => GetProperty<TerraformProperty<string>>("storage_redundancy");
        set => WithProperty("storage_redundancy", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformProperty<string>? Tier
    {
        get => GetProperty<TerraformProperty<string>>("tier");
        set => WithProperty("tier", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for capabilities in .
/// Nesting mode: set
/// </summary>
public class AzurermCosmosdbAccountCapabilitiesBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for capacity in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbAccountCapacityBlock : TerraformBlock
{
    /// <summary>
    /// The total_throughput_limit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalThroughputLimit is required")]
    public required TerraformProperty<double> TotalThroughputLimit
    {
        get => GetProperty<TerraformProperty<double>>("total_throughput_limit");
        set => WithProperty("total_throughput_limit", value);
    }

}

/// <summary>
/// Block type for consistency_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbAccountConsistencyPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The consistency_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsistencyLevel is required")]
    public required TerraformProperty<string> ConsistencyLevel
    {
        get => GetProperty<TerraformProperty<string>>("consistency_level");
        set => WithProperty("consistency_level", value);
    }

    /// <summary>
    /// The max_interval_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? MaxIntervalInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("max_interval_in_seconds");
        set => WithProperty("max_interval_in_seconds", value);
    }

    /// <summary>
    /// The max_staleness_prefix attribute.
    /// </summary>
    public TerraformProperty<double>? MaxStalenessPrefix
    {
        get => GetProperty<TerraformProperty<double>>("max_staleness_prefix");
        set => WithProperty("max_staleness_prefix", value);
    }

}

/// <summary>
/// Block type for cors_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbAccountCorsRuleBlock : TerraformBlock
{
    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedHeaders is required")]
    public List<TerraformProperty<string>>? AllowedHeaders
    {
        get => GetProperty<List<TerraformProperty<string>>>("allowed_headers");
        set => WithProperty("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    public List<TerraformProperty<string>>? AllowedMethods
    {
        get => GetProperty<List<TerraformProperty<string>>>("allowed_methods");
        set => WithProperty("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    public List<TerraformProperty<string>>? AllowedOrigins
    {
        get => GetProperty<List<TerraformProperty<string>>>("allowed_origins");
        set => WithProperty("allowed_origins", value);
    }

    /// <summary>
    /// The exposed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExposedHeaders is required")]
    public List<TerraformProperty<string>>? ExposedHeaders
    {
        get => GetProperty<List<TerraformProperty<string>>>("exposed_headers");
        set => WithProperty("exposed_headers", value);
    }

    /// <summary>
    /// The max_age_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? MaxAgeInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("max_age_in_seconds");
        set => WithProperty("max_age_in_seconds", value);
    }

}

/// <summary>
/// Block type for geo_location in .
/// Nesting mode: set
/// </summary>
public class AzurermCosmosdbAccountGeoLocationBlock : TerraformBlock
{
    /// <summary>
    /// The failover_priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailoverPriority is required")]
    public required TerraformProperty<double> FailoverPriority
    {
        get => GetProperty<TerraformProperty<double>>("failover_priority");
        set => WithProperty("failover_priority", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => WithProperty("location", value);
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformProperty<bool>? ZoneRedundant
    {
        get => GetProperty<TerraformProperty<bool>>("zone_redundant");
        set => WithProperty("zone_redundant", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbAccountIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for restore in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbAccountRestoreBlock : TerraformBlock
{
    /// <summary>
    /// The restore_timestamp_in_utc attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestoreTimestampInUtc is required")]
    public required TerraformProperty<string> RestoreTimestampInUtc
    {
        get => GetProperty<TerraformProperty<string>>("restore_timestamp_in_utc");
        set => WithProperty("restore_timestamp_in_utc", value);
    }

    /// <summary>
    /// The source_cosmosdb_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceCosmosdbAccountId is required")]
    public required TerraformProperty<string> SourceCosmosdbAccountId
    {
        get => GetProperty<TerraformProperty<string>>("source_cosmosdb_account_id");
        set => WithProperty("source_cosmosdb_account_id", value);
    }

    /// <summary>
    /// The tables_to_restore attribute.
    /// </summary>
    public List<TerraformProperty<string>>? TablesToRestore
    {
        get => GetProperty<List<TerraformProperty<string>>>("tables_to_restore");
        set => WithProperty("tables_to_restore", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbAccountTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for virtual_network_rule in .
/// Nesting mode: set
/// </summary>
public class AzurermCosmosdbAccountVirtualNetworkRuleBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The ignore_missing_vnet_service_endpoint attribute.
    /// </summary>
    public TerraformProperty<bool>? IgnoreMissingVnetServiceEndpoint
    {
        get => GetProperty<TerraformProperty<bool>>("ignore_missing_vnet_service_endpoint");
        set => WithProperty("ignore_missing_vnet_service_endpoint", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("endpoint");
        this.DeclareOutput("primary_key");
        this.DeclareOutput("primary_mongodb_connection_string");
        this.DeclareOutput("primary_readonly_key");
        this.DeclareOutput("primary_readonly_mongodb_connection_string");
        this.DeclareOutput("primary_readonly_sql_connection_string");
        this.DeclareOutput("primary_sql_connection_string");
        this.DeclareOutput("read_endpoints");
        this.DeclareOutput("secondary_key");
        this.DeclareOutput("secondary_mongodb_connection_string");
        this.DeclareOutput("secondary_readonly_key");
        this.DeclareOutput("secondary_readonly_mongodb_connection_string");
        this.DeclareOutput("secondary_readonly_sql_connection_string");
        this.DeclareOutput("secondary_sql_connection_string");
        this.DeclareOutput("write_endpoints");
    }

    /// <summary>
    /// The access_key_metadata_writes_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AccessKeyMetadataWritesEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("access_key_metadata_writes_enabled");
        set => this.WithProperty("access_key_metadata_writes_enabled", value);
    }

    /// <summary>
    /// The analytical_storage_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AnalyticalStorageEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("analytical_storage_enabled");
        set => this.WithProperty("analytical_storage_enabled", value);
    }

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutomaticFailoverEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("automatic_failover_enabled");
        set => this.WithProperty("automatic_failover_enabled", value);
    }

    /// <summary>
    /// The burst_capacity_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BurstCapacityEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("burst_capacity_enabled");
        set => this.WithProperty("burst_capacity_enabled", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public TerraformProperty<string>? CreateMode
    {
        get => GetProperty<TerraformProperty<string>>("create_mode");
        set => this.WithProperty("create_mode", value);
    }

    /// <summary>
    /// The default_identity_type attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultIdentityType
    {
        get => GetProperty<TerraformProperty<string>>("default_identity_type");
        set => this.WithProperty("default_identity_type", value);
    }

    /// <summary>
    /// The free_tier_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FreeTierEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("free_tier_enabled");
        set => this.WithProperty("free_tier_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ip_range_filter attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IpRangeFilter
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("ip_range_filter");
        set => this.WithProperty("ip_range_filter", value);
    }

    /// <summary>
    /// The is_virtual_network_filter_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? IsVirtualNetworkFilterEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("is_virtual_network_filter_enabled");
        set => this.WithProperty("is_virtual_network_filter_enabled", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultKeyId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_key_id");
        set => this.WithProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformProperty<string>? Kind
    {
        get => GetProperty<TerraformProperty<string>>("kind");
        set => this.WithProperty("kind", value);
    }

    /// <summary>
    /// The local_authentication_disabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LocalAuthenticationDisabled
    {
        get => GetProperty<TerraformProperty<bool>>("local_authentication_disabled");
        set => this.WithProperty("local_authentication_disabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedHsmKeyId
    {
        get => GetProperty<TerraformProperty<string>>("managed_hsm_key_id");
        set => this.WithProperty("managed_hsm_key_id", value);
    }

    /// <summary>
    /// The minimal_tls_version attribute.
    /// </summary>
    public TerraformProperty<string>? MinimalTlsVersion
    {
        get => GetProperty<TerraformProperty<string>>("minimal_tls_version");
        set => this.WithProperty("minimal_tls_version", value);
    }

    /// <summary>
    /// The mongo_server_version attribute.
    /// </summary>
    public TerraformProperty<string>? MongoServerVersion
    {
        get => GetProperty<TerraformProperty<string>>("mongo_server_version");
        set => this.WithProperty("mongo_server_version", value);
    }

    /// <summary>
    /// The multiple_write_locations_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? MultipleWriteLocationsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("multiple_write_locations_enabled");
        set => this.WithProperty("multiple_write_locations_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_acl_bypass_for_azure_services attribute.
    /// </summary>
    public TerraformProperty<bool>? NetworkAclBypassForAzureServices
    {
        get => GetProperty<TerraformProperty<bool>>("network_acl_bypass_for_azure_services");
        set => this.WithProperty("network_acl_bypass_for_azure_services", value);
    }

    /// <summary>
    /// The network_acl_bypass_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? NetworkAclBypassIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("network_acl_bypass_ids");
        set => this.WithProperty("network_acl_bypass_ids", value);
    }

    /// <summary>
    /// The offer_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OfferType is required")]
    public required TerraformProperty<string> OfferType
    {
        get => GetProperty<TerraformProperty<string>>("offer_type");
        set => this.WithProperty("offer_type", value);
    }

    /// <summary>
    /// The partition_merge_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PartitionMergeEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("partition_merge_enabled");
        set => this.WithProperty("partition_merge_enabled", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for analytical_storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnalyticalStorage block(s) allowed")]
    public List<AzurermCosmosdbAccountAnalyticalStorageBlock>? AnalyticalStorage
    {
        get => GetProperty<List<AzurermCosmosdbAccountAnalyticalStorageBlock>>("analytical_storage");
        set => this.WithProperty("analytical_storage", value);
    }

    /// <summary>
    /// Block for backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    public List<AzurermCosmosdbAccountBackupBlock>? Backup
    {
        get => GetProperty<List<AzurermCosmosdbAccountBackupBlock>>("backup");
        set => this.WithProperty("backup", value);
    }

    /// <summary>
    /// Block for capabilities.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermCosmosdbAccountCapabilitiesBlock>? Capabilities
    {
        get => GetProperty<HashSet<AzurermCosmosdbAccountCapabilitiesBlock>>("capabilities");
        set => this.WithProperty("capabilities", value);
    }

    /// <summary>
    /// Block for capacity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Capacity block(s) allowed")]
    public List<AzurermCosmosdbAccountCapacityBlock>? Capacity
    {
        get => GetProperty<List<AzurermCosmosdbAccountCapacityBlock>>("capacity");
        set => this.WithProperty("capacity", value);
    }

    /// <summary>
    /// Block for consistency_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConsistencyPolicy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConsistencyPolicy block(s) allowed")]
    public List<AzurermCosmosdbAccountConsistencyPolicyBlock>? ConsistencyPolicy
    {
        get => GetProperty<List<AzurermCosmosdbAccountConsistencyPolicyBlock>>("consistency_policy");
        set => this.WithProperty("consistency_policy", value);
    }

    /// <summary>
    /// Block for cors_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsRule block(s) allowed")]
    public List<AzurermCosmosdbAccountCorsRuleBlock>? CorsRule
    {
        get => GetProperty<List<AzurermCosmosdbAccountCorsRuleBlock>>("cors_rule");
        set => this.WithProperty("cors_rule", value);
    }

    /// <summary>
    /// Block for geo_location.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GeoLocation block(s) required")]
    public HashSet<AzurermCosmosdbAccountGeoLocationBlock>? GeoLocation
    {
        get => GetProperty<HashSet<AzurermCosmosdbAccountGeoLocationBlock>>("geo_location");
        set => this.WithProperty("geo_location", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermCosmosdbAccountIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermCosmosdbAccountIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for restore.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Restore block(s) allowed")]
    public List<AzurermCosmosdbAccountRestoreBlock>? Restore
    {
        get => GetProperty<List<AzurermCosmosdbAccountRestoreBlock>>("restore");
        set => this.WithProperty("restore", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCosmosdbAccountTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermCosmosdbAccountTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for virtual_network_rule.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermCosmosdbAccountVirtualNetworkRuleBlock>? VirtualNetworkRule
    {
        get => GetProperty<HashSet<AzurermCosmosdbAccountVirtualNetworkRuleBlock>>("virtual_network_rule");
        set => this.WithProperty("virtual_network_rule", value);
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    public TerraformExpression PrimaryKey => this["primary_key"];

    /// <summary>
    /// The primary_mongodb_connection_string attribute.
    /// </summary>
    public TerraformExpression PrimaryMongodbConnectionString => this["primary_mongodb_connection_string"];

    /// <summary>
    /// The primary_readonly_key attribute.
    /// </summary>
    public TerraformExpression PrimaryReadonlyKey => this["primary_readonly_key"];

    /// <summary>
    /// The primary_readonly_mongodb_connection_string attribute.
    /// </summary>
    public TerraformExpression PrimaryReadonlyMongodbConnectionString => this["primary_readonly_mongodb_connection_string"];

    /// <summary>
    /// The primary_readonly_sql_connection_string attribute.
    /// </summary>
    public TerraformExpression PrimaryReadonlySqlConnectionString => this["primary_readonly_sql_connection_string"];

    /// <summary>
    /// The primary_sql_connection_string attribute.
    /// </summary>
    public TerraformExpression PrimarySqlConnectionString => this["primary_sql_connection_string"];

    /// <summary>
    /// The read_endpoints attribute.
    /// </summary>
    public TerraformExpression ReadEndpoints => this["read_endpoints"];

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    public TerraformExpression SecondaryKey => this["secondary_key"];

    /// <summary>
    /// The secondary_mongodb_connection_string attribute.
    /// </summary>
    public TerraformExpression SecondaryMongodbConnectionString => this["secondary_mongodb_connection_string"];

    /// <summary>
    /// The secondary_readonly_key attribute.
    /// </summary>
    public TerraformExpression SecondaryReadonlyKey => this["secondary_readonly_key"];

    /// <summary>
    /// The secondary_readonly_mongodb_connection_string attribute.
    /// </summary>
    public TerraformExpression SecondaryReadonlyMongodbConnectionString => this["secondary_readonly_mongodb_connection_string"];

    /// <summary>
    /// The secondary_readonly_sql_connection_string attribute.
    /// </summary>
    public TerraformExpression SecondaryReadonlySqlConnectionString => this["secondary_readonly_sql_connection_string"];

    /// <summary>
    /// The secondary_sql_connection_string attribute.
    /// </summary>
    public TerraformExpression SecondarySqlConnectionString => this["secondary_sql_connection_string"];

    /// <summary>
    /// The write_endpoints attribute.
    /// </summary>
    public TerraformExpression WriteEndpoints => this["write_endpoints"];

}
