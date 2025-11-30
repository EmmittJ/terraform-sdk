using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermCosmosdbAccountDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbAccountDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_cosmosdb_account Terraform data source.
/// Retrieves information about a azurerm_cosmosdb_account.
/// </summary>
public partial class AzurermCosmosdbAccountDataSource(string name) : TerraformDataSource("azurerm_cosmosdb_account", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AutomaticFailoverEnabled
    {
        get => new TerraformReference<bool>(this, "automatic_failover_enabled");
    }

    /// <summary>
    /// The capabilities attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Capabilities
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "capabilities").ResolveNodes(ctx));
    }

    /// <summary>
    /// The consistency_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ConsistencyPolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "consistency_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// The free_tier_enabled attribute.
    /// </summary>
    public TerraformValue<bool> FreeTierEnabled
    {
        get => new TerraformReference<bool>(this, "free_tier_enabled");
    }

    /// <summary>
    /// The geo_location attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> GeoLocation
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "geo_location").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ip_range_filter attribute.
    /// </summary>
    public TerraformValue<string> IpRangeFilter
    {
        get => new TerraformReference<string>(this, "ip_range_filter");
    }

    /// <summary>
    /// The is_virtual_network_filter_enabled attribute.
    /// </summary>
    public TerraformValue<bool> IsVirtualNetworkFilterEnabled
    {
        get => new TerraformReference<bool>(this, "is_virtual_network_filter_enabled");
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "key_vault_key_id");
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string> Kind
    {
        get => new TerraformReference<string>(this, "kind");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The multiple_write_locations_enabled attribute.
    /// </summary>
    public TerraformValue<bool> MultipleWriteLocationsEnabled
    {
        get => new TerraformReference<bool>(this, "multiple_write_locations_enabled");
    }

    /// <summary>
    /// The offer_type attribute.
    /// </summary>
    public TerraformValue<string> OfferType
    {
        get => new TerraformReference<string>(this, "offer_type");
    }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryKey
    {
        get => new TerraformReference<string>(this, "primary_key");
    }

    /// <summary>
    /// The primary_mongodb_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimaryMongodbConnectionString
    {
        get => new TerraformReference<string>(this, "primary_mongodb_connection_string");
    }

    /// <summary>
    /// The primary_readonly_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryReadonlyKey
    {
        get => new TerraformReference<string>(this, "primary_readonly_key");
    }

    /// <summary>
    /// The primary_readonly_mongodb_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimaryReadonlyMongodbConnectionString
    {
        get => new TerraformReference<string>(this, "primary_readonly_mongodb_connection_string");
    }

    /// <summary>
    /// The primary_readonly_sql_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimaryReadonlySqlConnectionString
    {
        get => new TerraformReference<string>(this, "primary_readonly_sql_connection_string");
    }

    /// <summary>
    /// The primary_sql_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimarySqlConnectionString
    {
        get => new TerraformReference<string>(this, "primary_sql_connection_string");
    }

    /// <summary>
    /// The read_endpoints attribute.
    /// </summary>
    public TerraformList<string> ReadEndpoints
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "read_endpoints").ResolveNodes(ctx));
    }

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryKey
    {
        get => new TerraformReference<string>(this, "secondary_key");
    }

    /// <summary>
    /// The secondary_mongodb_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondaryMongodbConnectionString
    {
        get => new TerraformReference<string>(this, "secondary_mongodb_connection_string");
    }

    /// <summary>
    /// The secondary_readonly_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryReadonlyKey
    {
        get => new TerraformReference<string>(this, "secondary_readonly_key");
    }

    /// <summary>
    /// The secondary_readonly_mongodb_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondaryReadonlyMongodbConnectionString
    {
        get => new TerraformReference<string>(this, "secondary_readonly_mongodb_connection_string");
    }

    /// <summary>
    /// The secondary_readonly_sql_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondaryReadonlySqlConnectionString
    {
        get => new TerraformReference<string>(this, "secondary_readonly_sql_connection_string");
    }

    /// <summary>
    /// The secondary_sql_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondarySqlConnectionString
    {
        get => new TerraformReference<string>(this, "secondary_sql_connection_string");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The virtual_network_rule attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VirtualNetworkRule
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "virtual_network_rule").ResolveNodes(ctx));
    }

    /// <summary>
    /// The write_endpoints attribute.
    /// </summary>
    public TerraformList<string> WriteEndpoints
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "write_endpoints").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCosmosdbAccountDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCosmosdbAccountDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
