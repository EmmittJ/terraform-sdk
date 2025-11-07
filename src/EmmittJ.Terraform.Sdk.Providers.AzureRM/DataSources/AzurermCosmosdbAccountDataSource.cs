using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_cosmosdb_account.
/// </summary>
public class AzurermCosmosdbAccountDataSource : TerraformDataSource
{
    public AzurermCosmosdbAccountDataSource(string name) : base("azurerm_cosmosdb_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("automatic_failover_enabled");
        this.DeclareOutput("capabilities");
        this.DeclareOutput("consistency_policy");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("free_tier_enabled");
        this.DeclareOutput("geo_location");
        this.DeclareOutput("ip_range_filter");
        this.DeclareOutput("is_virtual_network_filter_enabled");
        this.DeclareOutput("key_vault_key_id");
        this.DeclareOutput("kind");
        this.DeclareOutput("location");
        this.DeclareOutput("multiple_write_locations_enabled");
        this.DeclareOutput("offer_type");
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
        this.DeclareOutput("tags");
        this.DeclareOutput("virtual_network_rule");
        this.DeclareOutput("write_endpoints");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    public TerraformExpression AutomaticFailoverEnabled => this["automatic_failover_enabled"];

    /// <summary>
    /// The capabilities attribute.
    /// </summary>
    public TerraformExpression Capabilities => this["capabilities"];

    /// <summary>
    /// The consistency_policy attribute.
    /// </summary>
    public TerraformExpression ConsistencyPolicy => this["consistency_policy"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The free_tier_enabled attribute.
    /// </summary>
    public TerraformExpression FreeTierEnabled => this["free_tier_enabled"];

    /// <summary>
    /// The geo_location attribute.
    /// </summary>
    public TerraformExpression GeoLocation => this["geo_location"];

    /// <summary>
    /// The ip_range_filter attribute.
    /// </summary>
    public TerraformExpression IpRangeFilter => this["ip_range_filter"];

    /// <summary>
    /// The is_virtual_network_filter_enabled attribute.
    /// </summary>
    public TerraformExpression IsVirtualNetworkFilterEnabled => this["is_virtual_network_filter_enabled"];

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformExpression KeyVaultKeyId => this["key_vault_key_id"];

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The multiple_write_locations_enabled attribute.
    /// </summary>
    public TerraformExpression MultipleWriteLocationsEnabled => this["multiple_write_locations_enabled"];

    /// <summary>
    /// The offer_type attribute.
    /// </summary>
    public TerraformExpression OfferType => this["offer_type"];

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
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The virtual_network_rule attribute.
    /// </summary>
    public TerraformExpression VirtualNetworkRule => this["virtual_network_rule"];

    /// <summary>
    /// The write_endpoints attribute.
    /// </summary>
    public TerraformExpression WriteEndpoints => this["write_endpoints"];

}
