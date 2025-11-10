using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventhubNamespaceDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_eventhub_namespace.
/// </summary>
public class AzurermEventhubNamespaceDataSource : TerraformDataSource
{
    public AzurermEventhubNamespaceDataSource(string name) : base("azurerm_eventhub_namespace", name)
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
    public TerraformBlock<AzurermEventhubNamespaceDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The auto_inflate_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auto_inflate_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AutoInflateEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "auto_inflate_enabled");

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformPropertyName("capacity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Capacity => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "capacity");

    /// <summary>
    /// The dedicated_cluster_id attribute.
    /// </summary>
    [TerraformPropertyName("dedicated_cluster_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DedicatedClusterId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dedicated_cluster_id");

    /// <summary>
    /// The default_primary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("default_primary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultPrimaryConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_primary_connection_string");

    /// <summary>
    /// The default_primary_connection_string_alias attribute.
    /// </summary>
    [TerraformPropertyName("default_primary_connection_string_alias")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultPrimaryConnectionStringAlias => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_primary_connection_string_alias");

    /// <summary>
    /// The default_primary_key attribute.
    /// </summary>
    [TerraformPropertyName("default_primary_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultPrimaryKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_primary_key");

    /// <summary>
    /// The default_secondary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("default_secondary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultSecondaryConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_secondary_connection_string");

    /// <summary>
    /// The default_secondary_connection_string_alias attribute.
    /// </summary>
    [TerraformPropertyName("default_secondary_connection_string_alias")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultSecondaryConnectionStringAlias => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_secondary_connection_string_alias");

    /// <summary>
    /// The default_secondary_key attribute.
    /// </summary>
    [TerraformPropertyName("default_secondary_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultSecondaryKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_secondary_key");

    /// <summary>
    /// The kafka_enabled attribute.
    /// </summary>
    [TerraformPropertyName("kafka_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> KafkaEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "kafka_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The maximum_throughput_units attribute.
    /// </summary>
    [TerraformPropertyName("maximum_throughput_units")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaximumThroughputUnits => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "maximum_throughput_units");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Sku => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

}
