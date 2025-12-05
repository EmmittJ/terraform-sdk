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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AutomaticFailoverEnabled
        => CreateReference("automatic_failover_enabled");

    /// <summary>
    /// The capabilities attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Capabilities
        => CreateReference("capabilities");

    /// <summary>
    /// The consistency_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ConsistencyPolicy
        => CreateReference("consistency_policy");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => CreateReference("endpoint");

    /// <summary>
    /// The free_tier_enabled attribute.
    /// </summary>
    public TerraformValue<bool> FreeTierEnabled
        => CreateReference("free_tier_enabled");

    /// <summary>
    /// The geo_location attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> GeoLocation
        => CreateReference("geo_location");

    /// <summary>
    /// The ip_range_filter attribute.
    /// </summary>
    public TerraformValue<string> IpRangeFilter
        => CreateReference("ip_range_filter");

    /// <summary>
    /// The is_virtual_network_filter_enabled attribute.
    /// </summary>
    public TerraformValue<bool> IsVirtualNetworkFilterEnabled
        => CreateReference("is_virtual_network_filter_enabled");

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultKeyId
        => CreateReference("key_vault_key_id");

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string> Kind
        => CreateReference("kind");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The multiple_write_locations_enabled attribute.
    /// </summary>
    public TerraformValue<bool> MultipleWriteLocationsEnabled
        => CreateReference("multiple_write_locations_enabled");

    /// <summary>
    /// The offer_type attribute.
    /// </summary>
    public TerraformValue<string> OfferType
        => CreateReference("offer_type");

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryKey
        => CreateReference("primary_key");

    /// <summary>
    /// The primary_mongodb_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimaryMongodbConnectionString
        => CreateReference("primary_mongodb_connection_string");

    /// <summary>
    /// The primary_readonly_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryReadonlyKey
        => CreateReference("primary_readonly_key");

    /// <summary>
    /// The primary_readonly_mongodb_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimaryReadonlyMongodbConnectionString
        => CreateReference("primary_readonly_mongodb_connection_string");

    /// <summary>
    /// The primary_readonly_sql_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimaryReadonlySqlConnectionString
        => CreateReference("primary_readonly_sql_connection_string");

    /// <summary>
    /// The primary_sql_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimarySqlConnectionString
        => CreateReference("primary_sql_connection_string");

    /// <summary>
    /// The read_endpoints attribute.
    /// </summary>
    public TerraformList<string> ReadEndpoints
        => CreateReference("read_endpoints");

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryKey
        => CreateReference("secondary_key");

    /// <summary>
    /// The secondary_mongodb_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondaryMongodbConnectionString
        => CreateReference("secondary_mongodb_connection_string");

    /// <summary>
    /// The secondary_readonly_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryReadonlyKey
        => CreateReference("secondary_readonly_key");

    /// <summary>
    /// The secondary_readonly_mongodb_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondaryReadonlyMongodbConnectionString
        => CreateReference("secondary_readonly_mongodb_connection_string");

    /// <summary>
    /// The secondary_readonly_sql_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondaryReadonlySqlConnectionString
        => CreateReference("secondary_readonly_sql_connection_string");

    /// <summary>
    /// The secondary_sql_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondarySqlConnectionString
        => CreateReference("secondary_sql_connection_string");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The virtual_network_rule attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VirtualNetworkRule
        => CreateReference("virtual_network_rule");

    /// <summary>
    /// The write_endpoints attribute.
    /// </summary>
    public TerraformList<string> WriteEndpoints
        => CreateReference("write_endpoints");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCosmosdbAccountDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCosmosdbAccountDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
