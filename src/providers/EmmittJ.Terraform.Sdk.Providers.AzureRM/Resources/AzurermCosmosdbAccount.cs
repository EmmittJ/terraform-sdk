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
        set => SetProperty("schema_type", value);
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
        set => SetProperty("interval_in_minutes", value);
    }

    /// <summary>
    /// The retention_in_hours attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionInHours
    {
        set => SetProperty("retention_in_hours", value);
    }

    /// <summary>
    /// The storage_redundancy attribute.
    /// </summary>
    public TerraformProperty<string>? StorageRedundancy
    {
        set => SetProperty("storage_redundancy", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformProperty<string>? Tier
    {
        set => SetProperty("tier", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("name", value);
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
        set => SetProperty("total_throughput_limit", value);
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
        set => SetProperty("consistency_level", value);
    }

    /// <summary>
    /// The max_interval_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? MaxIntervalInSeconds
    {
        set => SetProperty("max_interval_in_seconds", value);
    }

    /// <summary>
    /// The max_staleness_prefix attribute.
    /// </summary>
    public TerraformProperty<double>? MaxStalenessPrefix
    {
        set => SetProperty("max_staleness_prefix", value);
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
        set => SetProperty("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    public List<TerraformProperty<string>>? AllowedMethods
    {
        set => SetProperty("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    public List<TerraformProperty<string>>? AllowedOrigins
    {
        set => SetProperty("allowed_origins", value);
    }

    /// <summary>
    /// The exposed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExposedHeaders is required")]
    public List<TerraformProperty<string>>? ExposedHeaders
    {
        set => SetProperty("exposed_headers", value);
    }

    /// <summary>
    /// The max_age_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? MaxAgeInSeconds
    {
        set => SetProperty("max_age_in_seconds", value);
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
        set => SetProperty("failover_priority", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformProperty<bool>? ZoneRedundant
    {
        set => SetProperty("zone_redundant", value);
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
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("restore_timestamp_in_utc", value);
    }

    /// <summary>
    /// The source_cosmosdb_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceCosmosdbAccountId is required")]
    public required TerraformProperty<string> SourceCosmosdbAccountId
    {
        set => SetProperty("source_cosmosdb_account_id", value);
    }

    /// <summary>
    /// The tables_to_restore attribute.
    /// </summary>
    public List<TerraformProperty<string>>? TablesToRestore
    {
        set => SetProperty("tables_to_restore", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The ignore_missing_vnet_service_endpoint attribute.
    /// </summary>
    public TerraformProperty<bool>? IgnoreMissingVnetServiceEndpoint
    {
        set => SetProperty("ignore_missing_vnet_service_endpoint", value);
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
        SetOutput("endpoint");
        SetOutput("primary_key");
        SetOutput("primary_mongodb_connection_string");
        SetOutput("primary_readonly_key");
        SetOutput("primary_readonly_mongodb_connection_string");
        SetOutput("primary_readonly_sql_connection_string");
        SetOutput("primary_sql_connection_string");
        SetOutput("read_endpoints");
        SetOutput("secondary_key");
        SetOutput("secondary_mongodb_connection_string");
        SetOutput("secondary_readonly_key");
        SetOutput("secondary_readonly_mongodb_connection_string");
        SetOutput("secondary_readonly_sql_connection_string");
        SetOutput("secondary_sql_connection_string");
        SetOutput("write_endpoints");
        SetOutput("access_key_metadata_writes_enabled");
        SetOutput("analytical_storage_enabled");
        SetOutput("automatic_failover_enabled");
        SetOutput("burst_capacity_enabled");
        SetOutput("create_mode");
        SetOutput("default_identity_type");
        SetOutput("free_tier_enabled");
        SetOutput("id");
        SetOutput("ip_range_filter");
        SetOutput("is_virtual_network_filter_enabled");
        SetOutput("key_vault_key_id");
        SetOutput("kind");
        SetOutput("local_authentication_disabled");
        SetOutput("location");
        SetOutput("managed_hsm_key_id");
        SetOutput("minimal_tls_version");
        SetOutput("mongo_server_version");
        SetOutput("multiple_write_locations_enabled");
        SetOutput("name");
        SetOutput("network_acl_bypass_for_azure_services");
        SetOutput("network_acl_bypass_ids");
        SetOutput("offer_type");
        SetOutput("partition_merge_enabled");
        SetOutput("public_network_access_enabled");
        SetOutput("resource_group_name");
        SetOutput("tags");
    }

    /// <summary>
    /// The access_key_metadata_writes_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AccessKeyMetadataWritesEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("access_key_metadata_writes_enabled");
        set => SetProperty("access_key_metadata_writes_enabled", value);
    }

    /// <summary>
    /// The analytical_storage_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AnalyticalStorageEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("analytical_storage_enabled");
        set => SetProperty("analytical_storage_enabled", value);
    }

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AutomaticFailoverEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("automatic_failover_enabled");
        set => SetProperty("automatic_failover_enabled", value);
    }

    /// <summary>
    /// The burst_capacity_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> BurstCapacityEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("burst_capacity_enabled");
        set => SetProperty("burst_capacity_enabled", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public TerraformProperty<string> CreateMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("create_mode");
        set => SetProperty("create_mode", value);
    }

    /// <summary>
    /// The default_identity_type attribute.
    /// </summary>
    public TerraformProperty<string> DefaultIdentityType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_identity_type");
        set => SetProperty("default_identity_type", value);
    }

    /// <summary>
    /// The free_tier_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> FreeTierEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("free_tier_enabled");
        set => SetProperty("free_tier_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The ip_range_filter attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> IpRangeFilter
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("ip_range_filter");
        set => SetProperty("ip_range_filter", value);
    }

    /// <summary>
    /// The is_virtual_network_filter_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> IsVirtualNetworkFilterEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("is_virtual_network_filter_enabled");
        set => SetProperty("is_virtual_network_filter_enabled", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KeyVaultKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_vault_key_id");
        set => SetProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformProperty<string> Kind
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kind");
        set => SetProperty("kind", value);
    }

    /// <summary>
    /// The local_authentication_disabled attribute.
    /// </summary>
    public TerraformProperty<bool> LocalAuthenticationDisabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("local_authentication_disabled");
        set => SetProperty("local_authentication_disabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    public TerraformProperty<string> ManagedHsmKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_hsm_key_id");
        set => SetProperty("managed_hsm_key_id", value);
    }

    /// <summary>
    /// The minimal_tls_version attribute.
    /// </summary>
    public TerraformProperty<string> MinimalTlsVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("minimal_tls_version");
        set => SetProperty("minimal_tls_version", value);
    }

    /// <summary>
    /// The mongo_server_version attribute.
    /// </summary>
    public TerraformProperty<string> MongoServerVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mongo_server_version");
        set => SetProperty("mongo_server_version", value);
    }

    /// <summary>
    /// The multiple_write_locations_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> MultipleWriteLocationsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("multiple_write_locations_enabled");
        set => SetProperty("multiple_write_locations_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The network_acl_bypass_for_azure_services attribute.
    /// </summary>
    public TerraformProperty<bool> NetworkAclBypassForAzureServices
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("network_acl_bypass_for_azure_services");
        set => SetProperty("network_acl_bypass_for_azure_services", value);
    }

    /// <summary>
    /// The network_acl_bypass_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>> NetworkAclBypassIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("network_acl_bypass_ids");
        set => SetProperty("network_acl_bypass_ids", value);
    }

    /// <summary>
    /// The offer_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OfferType is required")]
    public required TerraformProperty<string> OfferType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("offer_type");
        set => SetProperty("offer_type", value);
    }

    /// <summary>
    /// The partition_merge_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PartitionMergeEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("partition_merge_enabled");
        set => SetProperty("partition_merge_enabled", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PublicNetworkAccessEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("public_network_access_enabled");
        set => SetProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for analytical_storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnalyticalStorage block(s) allowed")]
    public List<AzurermCosmosdbAccountAnalyticalStorageBlock>? AnalyticalStorage
    {
        set => SetProperty("analytical_storage", value);
    }

    /// <summary>
    /// Block for backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    public List<AzurermCosmosdbAccountBackupBlock>? Backup
    {
        set => SetProperty("backup", value);
    }

    /// <summary>
    /// Block for capabilities.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermCosmosdbAccountCapabilitiesBlock>? Capabilities
    {
        set => SetProperty("capabilities", value);
    }

    /// <summary>
    /// Block for capacity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Capacity block(s) allowed")]
    public List<AzurermCosmosdbAccountCapacityBlock>? Capacity
    {
        set => SetProperty("capacity", value);
    }

    /// <summary>
    /// Block for consistency_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsistencyPolicy is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConsistencyPolicy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConsistencyPolicy block(s) allowed")]
    public List<AzurermCosmosdbAccountConsistencyPolicyBlock>? ConsistencyPolicy
    {
        set => SetProperty("consistency_policy", value);
    }

    /// <summary>
    /// Block for cors_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsRule block(s) allowed")]
    public List<AzurermCosmosdbAccountCorsRuleBlock>? CorsRule
    {
        set => SetProperty("cors_rule", value);
    }

    /// <summary>
    /// Block for geo_location.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GeoLocation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GeoLocation block(s) required")]
    public HashSet<AzurermCosmosdbAccountGeoLocationBlock>? GeoLocation
    {
        set => SetProperty("geo_location", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermCosmosdbAccountIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for restore.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Restore block(s) allowed")]
    public List<AzurermCosmosdbAccountRestoreBlock>? Restore
    {
        set => SetProperty("restore", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCosmosdbAccountTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for virtual_network_rule.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermCosmosdbAccountVirtualNetworkRuleBlock>? VirtualNetworkRule
    {
        set => SetProperty("virtual_network_rule", value);
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
