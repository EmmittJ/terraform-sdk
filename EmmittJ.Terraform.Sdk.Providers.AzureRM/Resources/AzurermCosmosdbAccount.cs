using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_cosmosdb_account resource.
/// </summary>
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
    public bool? AccessKeyMetadataWritesEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("access_key_metadata_writes_enabled")?.Value;
        set => this.WithProperty("access_key_metadata_writes_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The analytical_storage_enabled attribute.
    /// </summary>
    public bool? AnalyticalStorageEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("analytical_storage_enabled")?.Value;
        set => this.WithProperty("analytical_storage_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    public bool? AutomaticFailoverEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("automatic_failover_enabled")?.Value;
        set => this.WithProperty("automatic_failover_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The burst_capacity_enabled attribute.
    /// </summary>
    public bool? BurstCapacityEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("burst_capacity_enabled")?.Value;
        set => this.WithProperty("burst_capacity_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public string? CreateMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("create_mode")?.Value;
        set => this.WithProperty("create_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_identity_type attribute.
    /// </summary>
    public string? DefaultIdentityType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_identity_type")?.Value;
        set => this.WithProperty("default_identity_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The free_tier_enabled attribute.
    /// </summary>
    public bool? FreeTierEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("free_tier_enabled")?.Value;
        set => this.WithProperty("free_tier_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ip_range_filter attribute.
    /// </summary>
    public HashSet<string>? IpRangeFilter
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("ip_range_filter")?.Value;
        set => this.WithProperty("ip_range_filter", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The is_virtual_network_filter_enabled attribute.
    /// </summary>
    public bool? IsVirtualNetworkFilterEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_virtual_network_filter_enabled")?.Value;
        set => this.WithProperty("is_virtual_network_filter_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public string? KeyVaultKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_key_id")?.Value;
        set => this.WithProperty("key_vault_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public string? Kind
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kind")?.Value;
        set => this.WithProperty("kind", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The local_authentication_disabled attribute.
    /// </summary>
    public bool? LocalAuthenticationDisabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("local_authentication_disabled")?.Value;
        set => this.WithProperty("local_authentication_disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    public string? ManagedHsmKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_hsm_key_id")?.Value;
        set => this.WithProperty("managed_hsm_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The minimal_tls_version attribute.
    /// </summary>
    public string? MinimalTlsVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("minimal_tls_version")?.Value;
        set => this.WithProperty("minimal_tls_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The mongo_server_version attribute.
    /// </summary>
    public string? MongoServerVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mongo_server_version")?.Value;
        set => this.WithProperty("mongo_server_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The multiple_write_locations_enabled attribute.
    /// </summary>
    public bool? MultipleWriteLocationsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("multiple_write_locations_enabled")?.Value;
        set => this.WithProperty("multiple_write_locations_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network_acl_bypass_for_azure_services attribute.
    /// </summary>
    public bool? NetworkAclBypassForAzureServices
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("network_acl_bypass_for_azure_services")?.Value;
        set => this.WithProperty("network_acl_bypass_for_azure_services", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The network_acl_bypass_ids attribute.
    /// </summary>
    public List<string>? NetworkAclBypassIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("network_acl_bypass_ids")?.Value;
        set => this.WithProperty("network_acl_bypass_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The offer_type attribute.
    /// </summary>
    public string? OfferType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("offer_type")?.Value;
        set => this.WithProperty("offer_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The partition_merge_enabled attribute.
    /// </summary>
    public bool? PartitionMergeEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("partition_merge_enabled")?.Value;
        set => this.WithProperty("partition_merge_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public bool? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled")?.Value;
        set => this.WithProperty("public_network_access_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
