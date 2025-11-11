using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventhubNamespaceDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    public TerraformBlock<AzurermEventhubNamespaceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The auto_inflate_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auto_inflate_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AutoInflateEnabled => new TerraformReference(this, "auto_inflate_enabled");

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformPropertyName("capacity")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Capacity => new TerraformReference(this, "capacity");

    /// <summary>
    /// The dedicated_cluster_id attribute.
    /// </summary>
    [TerraformPropertyName("dedicated_cluster_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DedicatedClusterId => new TerraformReference(this, "dedicated_cluster_id");

    /// <summary>
    /// The default_primary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("default_primary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultPrimaryConnectionString => new TerraformReference(this, "default_primary_connection_string");

    /// <summary>
    /// The default_primary_connection_string_alias attribute.
    /// </summary>
    [TerraformPropertyName("default_primary_connection_string_alias")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultPrimaryConnectionStringAlias => new TerraformReference(this, "default_primary_connection_string_alias");

    /// <summary>
    /// The default_primary_key attribute.
    /// </summary>
    [TerraformPropertyName("default_primary_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultPrimaryKey => new TerraformReference(this, "default_primary_key");

    /// <summary>
    /// The default_secondary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("default_secondary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultSecondaryConnectionString => new TerraformReference(this, "default_secondary_connection_string");

    /// <summary>
    /// The default_secondary_connection_string_alias attribute.
    /// </summary>
    [TerraformPropertyName("default_secondary_connection_string_alias")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultSecondaryConnectionStringAlias => new TerraformReference(this, "default_secondary_connection_string_alias");

    /// <summary>
    /// The default_secondary_key attribute.
    /// </summary>
    [TerraformPropertyName("default_secondary_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultSecondaryKey => new TerraformReference(this, "default_secondary_key");

    /// <summary>
    /// The kafka_enabled attribute.
    /// </summary>
    [TerraformPropertyName("kafka_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> KafkaEnabled => new TerraformReference(this, "kafka_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The maximum_throughput_units attribute.
    /// </summary>
    [TerraformPropertyName("maximum_throughput_units")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaximumThroughputUnits => new TerraformReference(this, "maximum_throughput_units");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Sku => new TerraformReference(this, "sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

}
