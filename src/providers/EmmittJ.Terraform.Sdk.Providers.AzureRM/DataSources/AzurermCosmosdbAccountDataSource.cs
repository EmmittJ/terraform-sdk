using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbAccountDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermCosmosdbAccountDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    [TerraformPropertyName("automatic_failover_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AutomaticFailoverEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "automatic_failover_enabled");

    /// <summary>
    /// The capabilities attribute.
    /// </summary>
    [TerraformPropertyName("capabilities")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Capabilities => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "capabilities");

    /// <summary>
    /// The consistency_policy attribute.
    /// </summary>
    [TerraformPropertyName("consistency_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ConsistencyPolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "consistency_policy");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The free_tier_enabled attribute.
    /// </summary>
    [TerraformPropertyName("free_tier_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> FreeTierEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "free_tier_enabled");

    /// <summary>
    /// The geo_location attribute.
    /// </summary>
    [TerraformPropertyName("geo_location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> GeoLocation => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "geo_location");

    /// <summary>
    /// The ip_range_filter attribute.
    /// </summary>
    [TerraformPropertyName("ip_range_filter")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpRangeFilter => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip_range_filter");

    /// <summary>
    /// The is_virtual_network_filter_enabled attribute.
    /// </summary>
    [TerraformPropertyName("is_virtual_network_filter_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IsVirtualNetworkFilterEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "is_virtual_network_filter_enabled");

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_key_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KeyVaultKeyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_vault_key_id");

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformPropertyName("kind")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Kind => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kind");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The multiple_write_locations_enabled attribute.
    /// </summary>
    [TerraformPropertyName("multiple_write_locations_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> MultipleWriteLocationsEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "multiple_write_locations_enabled");

    /// <summary>
    /// The offer_type attribute.
    /// </summary>
    [TerraformPropertyName("offer_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OfferType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "offer_type");

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_key");

    /// <summary>
    /// The primary_mongodb_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("primary_mongodb_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryMongodbConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_mongodb_connection_string");

    /// <summary>
    /// The primary_readonly_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_readonly_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryReadonlyKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_readonly_key");

    /// <summary>
    /// The primary_readonly_mongodb_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("primary_readonly_mongodb_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryReadonlyMongodbConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_readonly_mongodb_connection_string");

    /// <summary>
    /// The primary_readonly_sql_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("primary_readonly_sql_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryReadonlySqlConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_readonly_sql_connection_string");

    /// <summary>
    /// The primary_sql_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("primary_sql_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimarySqlConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_sql_connection_string");

    /// <summary>
    /// The read_endpoints attribute.
    /// </summary>
    [TerraformPropertyName("read_endpoints")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ReadEndpoints => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "read_endpoints");

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_key");

    /// <summary>
    /// The secondary_mongodb_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("secondary_mongodb_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryMongodbConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_mongodb_connection_string");

    /// <summary>
    /// The secondary_readonly_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_readonly_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryReadonlyKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_readonly_key");

    /// <summary>
    /// The secondary_readonly_mongodb_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("secondary_readonly_mongodb_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryReadonlyMongodbConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_readonly_mongodb_connection_string");

    /// <summary>
    /// The secondary_readonly_sql_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("secondary_readonly_sql_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryReadonlySqlConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_readonly_sql_connection_string");

    /// <summary>
    /// The secondary_sql_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("secondary_sql_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondarySqlConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_sql_connection_string");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The virtual_network_rule attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_rule")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> VirtualNetworkRule => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "virtual_network_rule");

    /// <summary>
    /// The write_endpoints attribute.
    /// </summary>
    [TerraformPropertyName("write_endpoints")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> WriteEndpoints => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "write_endpoints");

}
