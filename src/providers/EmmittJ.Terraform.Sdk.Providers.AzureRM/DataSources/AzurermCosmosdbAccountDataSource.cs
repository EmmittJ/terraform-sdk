using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbAccountDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermCosmosdbAccountDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    [TerraformPropertyName("automatic_failover_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AutomaticFailoverEnabled => new TerraformReference(this, "automatic_failover_enabled");

    /// <summary>
    /// The capabilities attribute.
    /// </summary>
    [TerraformPropertyName("capabilities")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Capabilities => new TerraformReference(this, "capabilities");

    /// <summary>
    /// The consistency_policy attribute.
    /// </summary>
    [TerraformPropertyName("consistency_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ConsistencyPolicy => new TerraformReference(this, "consistency_policy");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Endpoint => new TerraformReference(this, "endpoint");

    /// <summary>
    /// The free_tier_enabled attribute.
    /// </summary>
    [TerraformPropertyName("free_tier_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> FreeTierEnabled => new TerraformReference(this, "free_tier_enabled");

    /// <summary>
    /// The geo_location attribute.
    /// </summary>
    [TerraformPropertyName("geo_location")]
    // Output-only attribute - read-only reference
    public TerraformList<object> GeoLocation => new TerraformReference(this, "geo_location");

    /// <summary>
    /// The ip_range_filter attribute.
    /// </summary>
    [TerraformPropertyName("ip_range_filter")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpRangeFilter => new TerraformReference(this, "ip_range_filter");

    /// <summary>
    /// The is_virtual_network_filter_enabled attribute.
    /// </summary>
    [TerraformPropertyName("is_virtual_network_filter_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> IsVirtualNetworkFilterEnabled => new TerraformReference(this, "is_virtual_network_filter_enabled");

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_key_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KeyVaultKeyId => new TerraformReference(this, "key_vault_key_id");

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformPropertyName("kind")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Kind => new TerraformReference(this, "kind");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The multiple_write_locations_enabled attribute.
    /// </summary>
    [TerraformPropertyName("multiple_write_locations_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> MultipleWriteLocationsEnabled => new TerraformReference(this, "multiple_write_locations_enabled");

    /// <summary>
    /// The offer_type attribute.
    /// </summary>
    [TerraformPropertyName("offer_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OfferType => new TerraformReference(this, "offer_type");

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryKey => new TerraformReference(this, "primary_key");

    /// <summary>
    /// The primary_mongodb_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("primary_mongodb_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryMongodbConnectionString => new TerraformReference(this, "primary_mongodb_connection_string");

    /// <summary>
    /// The primary_readonly_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_readonly_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryReadonlyKey => new TerraformReference(this, "primary_readonly_key");

    /// <summary>
    /// The primary_readonly_mongodb_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("primary_readonly_mongodb_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryReadonlyMongodbConnectionString => new TerraformReference(this, "primary_readonly_mongodb_connection_string");

    /// <summary>
    /// The primary_readonly_sql_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("primary_readonly_sql_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryReadonlySqlConnectionString => new TerraformReference(this, "primary_readonly_sql_connection_string");

    /// <summary>
    /// The primary_sql_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("primary_sql_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimarySqlConnectionString => new TerraformReference(this, "primary_sql_connection_string");

    /// <summary>
    /// The read_endpoints attribute.
    /// </summary>
    [TerraformPropertyName("read_endpoints")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ReadEndpoints => new TerraformReference(this, "read_endpoints");

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryKey => new TerraformReference(this, "secondary_key");

    /// <summary>
    /// The secondary_mongodb_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("secondary_mongodb_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryMongodbConnectionString => new TerraformReference(this, "secondary_mongodb_connection_string");

    /// <summary>
    /// The secondary_readonly_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_readonly_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryReadonlyKey => new TerraformReference(this, "secondary_readonly_key");

    /// <summary>
    /// The secondary_readonly_mongodb_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("secondary_readonly_mongodb_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryReadonlyMongodbConnectionString => new TerraformReference(this, "secondary_readonly_mongodb_connection_string");

    /// <summary>
    /// The secondary_readonly_sql_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("secondary_readonly_sql_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryReadonlySqlConnectionString => new TerraformReference(this, "secondary_readonly_sql_connection_string");

    /// <summary>
    /// The secondary_sql_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("secondary_sql_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondarySqlConnectionString => new TerraformReference(this, "secondary_sql_connection_string");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The virtual_network_rule attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_rule")]
    // Output-only attribute - read-only reference
    public TerraformList<object> VirtualNetworkRule => new TerraformReference(this, "virtual_network_rule");

    /// <summary>
    /// The write_endpoints attribute.
    /// </summary>
    [TerraformPropertyName("write_endpoints")]
    // Output-only attribute - read-only reference
    public TerraformList<string> WriteEndpoints => new TerraformReference(this, "write_endpoints");

}
