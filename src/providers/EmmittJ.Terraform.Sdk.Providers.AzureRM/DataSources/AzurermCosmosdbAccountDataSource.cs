using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCosmosdbAccountDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_cosmosdb_account.
/// </summary>
public partial class AzurermCosmosdbAccountDataSource : TerraformDataSource
{
    public AzurermCosmosdbAccountDataSource(string name) : base("azurerm_cosmosdb_account", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermCosmosdbAccountDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    [TerraformProperty("automatic_failover_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> AutomaticFailoverEnabled { get; }

    /// <summary>
    /// The capabilities attribute.
    /// </summary>
    [TerraformProperty("capabilities")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Capabilities { get; }

    /// <summary>
    /// The consistency_policy attribute.
    /// </summary>
    [TerraformProperty("consistency_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ConsistencyPolicy { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The free_tier_enabled attribute.
    /// </summary>
    [TerraformProperty("free_tier_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> FreeTierEnabled { get; }

    /// <summary>
    /// The geo_location attribute.
    /// </summary>
    [TerraformProperty("geo_location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> GeoLocation { get; }

    /// <summary>
    /// The ip_range_filter attribute.
    /// </summary>
    [TerraformProperty("ip_range_filter")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpRangeFilter { get; }

    /// <summary>
    /// The is_virtual_network_filter_enabled attribute.
    /// </summary>
    [TerraformProperty("is_virtual_network_filter_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> IsVirtualNetworkFilterEnabled { get; }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_key_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KeyVaultKeyId { get; }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformProperty("kind")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Kind { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The multiple_write_locations_enabled attribute.
    /// </summary>
    [TerraformProperty("multiple_write_locations_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> MultipleWriteLocationsEnabled { get; }

    /// <summary>
    /// The offer_type attribute.
    /// </summary>
    [TerraformProperty("offer_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OfferType { get; }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [TerraformProperty("primary_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryKey { get; }

    /// <summary>
    /// The primary_mongodb_connection_string attribute.
    /// </summary>
    [TerraformProperty("primary_mongodb_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryMongodbConnectionString { get; }

    /// <summary>
    /// The primary_readonly_key attribute.
    /// </summary>
    [TerraformProperty("primary_readonly_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryReadonlyKey { get; }

    /// <summary>
    /// The primary_readonly_mongodb_connection_string attribute.
    /// </summary>
    [TerraformProperty("primary_readonly_mongodb_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryReadonlyMongodbConnectionString { get; }

    /// <summary>
    /// The primary_readonly_sql_connection_string attribute.
    /// </summary>
    [TerraformProperty("primary_readonly_sql_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryReadonlySqlConnectionString { get; }

    /// <summary>
    /// The primary_sql_connection_string attribute.
    /// </summary>
    [TerraformProperty("primary_sql_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimarySqlConnectionString { get; }

    /// <summary>
    /// The read_endpoints attribute.
    /// </summary>
    [TerraformProperty("read_endpoints")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ReadEndpoints { get; }

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    [TerraformProperty("secondary_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryKey { get; }

    /// <summary>
    /// The secondary_mongodb_connection_string attribute.
    /// </summary>
    [TerraformProperty("secondary_mongodb_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryMongodbConnectionString { get; }

    /// <summary>
    /// The secondary_readonly_key attribute.
    /// </summary>
    [TerraformProperty("secondary_readonly_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryReadonlyKey { get; }

    /// <summary>
    /// The secondary_readonly_mongodb_connection_string attribute.
    /// </summary>
    [TerraformProperty("secondary_readonly_mongodb_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryReadonlyMongodbConnectionString { get; }

    /// <summary>
    /// The secondary_readonly_sql_connection_string attribute.
    /// </summary>
    [TerraformProperty("secondary_readonly_sql_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryReadonlySqlConnectionString { get; }

    /// <summary>
    /// The secondary_sql_connection_string attribute.
    /// </summary>
    [TerraformProperty("secondary_sql_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondarySqlConnectionString { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The virtual_network_rule attribute.
    /// </summary>
    [TerraformProperty("virtual_network_rule")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> VirtualNetworkRule { get; }

    /// <summary>
    /// The write_endpoints attribute.
    /// </summary>
    [TerraformProperty("write_endpoints")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> WriteEndpoints { get; }

}
