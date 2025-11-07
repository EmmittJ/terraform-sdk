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
    public TerraformLiteralProperty<bool>? AccessKeyMetadataWritesEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("access_key_metadata_writes_enabled");
        set => this.WithProperty("access_key_metadata_writes_enabled", value);
    }

    /// <summary>
    /// The analytical_storage_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AnalyticalStorageEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("analytical_storage_enabled");
        set => this.WithProperty("analytical_storage_enabled", value);
    }

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AutomaticFailoverEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("automatic_failover_enabled");
        set => this.WithProperty("automatic_failover_enabled", value);
    }

    /// <summary>
    /// The burst_capacity_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? BurstCapacityEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("burst_capacity_enabled");
        set => this.WithProperty("burst_capacity_enabled", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CreateMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("create_mode");
        set => this.WithProperty("create_mode", value);
    }

    /// <summary>
    /// The default_identity_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DefaultIdentityType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_identity_type");
        set => this.WithProperty("default_identity_type", value);
    }

    /// <summary>
    /// The free_tier_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? FreeTierEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("free_tier_enabled");
        set => this.WithProperty("free_tier_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ip_range_filter attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? IpRangeFilter
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("ip_range_filter");
        set => this.WithProperty("ip_range_filter", value);
    }

    /// <summary>
    /// The is_virtual_network_filter_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? IsVirtualNetworkFilterEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_virtual_network_filter_enabled");
        set => this.WithProperty("is_virtual_network_filter_enabled", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KeyVaultKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_key_id");
        set => this.WithProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Kind
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kind");
        set => this.WithProperty("kind", value);
    }

    /// <summary>
    /// The local_authentication_disabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? LocalAuthenticationDisabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("local_authentication_disabled");
        set => this.WithProperty("local_authentication_disabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ManagedHsmKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_hsm_key_id");
        set => this.WithProperty("managed_hsm_key_id", value);
    }

    /// <summary>
    /// The minimal_tls_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MinimalTlsVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("minimal_tls_version");
        set => this.WithProperty("minimal_tls_version", value);
    }

    /// <summary>
    /// The mongo_server_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MongoServerVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mongo_server_version");
        set => this.WithProperty("mongo_server_version", value);
    }

    /// <summary>
    /// The multiple_write_locations_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? MultipleWriteLocationsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("multiple_write_locations_enabled");
        set => this.WithProperty("multiple_write_locations_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_acl_bypass_for_azure_services attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? NetworkAclBypassForAzureServices
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("network_acl_bypass_for_azure_services");
        set => this.WithProperty("network_acl_bypass_for_azure_services", value);
    }

    /// <summary>
    /// The network_acl_bypass_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? NetworkAclBypassIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("network_acl_bypass_ids");
        set => this.WithProperty("network_acl_bypass_ids", value);
    }

    /// <summary>
    /// The offer_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OfferType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("offer_type");
        set => this.WithProperty("offer_type", value);
    }

    /// <summary>
    /// The partition_merge_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PartitionMergeEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("partition_merge_enabled");
        set => this.WithProperty("partition_merge_enabled", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
