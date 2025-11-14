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
/// Block type for timeouts in .
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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_cosmosdb_account.
/// </summary>
public class AzurermCosmosdbAccountDataSource : TerraformDataSource
{
    public AzurermCosmosdbAccountDataSource(string name) : base("azurerm_cosmosdb_account", name)
    {
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermCosmosdbAccountDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    [TerraformArgument("automatic_failover_enabled")]
    public TerraformValue<bool> AutomaticFailoverEnabled
    {
        get => new TerraformReference<bool>(this, "automatic_failover_enabled");
    }

    /// <summary>
    /// The capabilities attribute.
    /// </summary>
    [TerraformArgument("capabilities")]
    public TerraformList<object> Capabilities
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "capabilities").ResolveNodes(ctx));
    }

    /// <summary>
    /// The consistency_policy attribute.
    /// </summary>
    [TerraformArgument("consistency_policy")]
    public TerraformList<object> ConsistencyPolicy
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "consistency_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformArgument("endpoint")]
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// The free_tier_enabled attribute.
    /// </summary>
    [TerraformArgument("free_tier_enabled")]
    public TerraformValue<bool> FreeTierEnabled
    {
        get => new TerraformReference<bool>(this, "free_tier_enabled");
    }

    /// <summary>
    /// The geo_location attribute.
    /// </summary>
    [TerraformArgument("geo_location")]
    public TerraformList<object> GeoLocation
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "geo_location").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ip_range_filter attribute.
    /// </summary>
    [TerraformArgument("ip_range_filter")]
    public TerraformValue<string> IpRangeFilter
    {
        get => new TerraformReference<string>(this, "ip_range_filter");
    }

    /// <summary>
    /// The is_virtual_network_filter_enabled attribute.
    /// </summary>
    [TerraformArgument("is_virtual_network_filter_enabled")]
    public TerraformValue<bool> IsVirtualNetworkFilterEnabled
    {
        get => new TerraformReference<bool>(this, "is_virtual_network_filter_enabled");
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [TerraformArgument("key_vault_key_id")]
    public TerraformValue<string> KeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "key_vault_key_id");
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformArgument("kind")]
    public TerraformValue<string> Kind
    {
        get => new TerraformReference<string>(this, "kind");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The multiple_write_locations_enabled attribute.
    /// </summary>
    [TerraformArgument("multiple_write_locations_enabled")]
    public TerraformValue<bool> MultipleWriteLocationsEnabled
    {
        get => new TerraformReference<bool>(this, "multiple_write_locations_enabled");
    }

    /// <summary>
    /// The offer_type attribute.
    /// </summary>
    [TerraformArgument("offer_type")]
    public TerraformValue<string> OfferType
    {
        get => new TerraformReference<string>(this, "offer_type");
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
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The virtual_network_rule attribute.
    /// </summary>
    [TerraformArgument("virtual_network_rule")]
    public TerraformList<object> VirtualNetworkRule
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "virtual_network_rule").ResolveNodes(ctx));
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
