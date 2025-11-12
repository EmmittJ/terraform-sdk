using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermEventhubNamespaceDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_eventhub_namespace.
/// </summary>
public partial class AzurermEventhubNamespaceDataSource : TerraformDataSource
{
    public AzurermEventhubNamespaceDataSource(string name) : base("azurerm_eventhub_namespace", name)
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
    public AzurermEventhubNamespaceDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The auto_inflate_enabled attribute.
    /// </summary>
    [TerraformProperty("auto_inflate_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> AutoInflateEnabled { get; }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformProperty("capacity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Capacity { get; }

    /// <summary>
    /// The dedicated_cluster_id attribute.
    /// </summary>
    [TerraformProperty("dedicated_cluster_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DedicatedClusterId { get; }

    /// <summary>
    /// The default_primary_connection_string attribute.
    /// </summary>
    [TerraformProperty("default_primary_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultPrimaryConnectionString { get; }

    /// <summary>
    /// The default_primary_connection_string_alias attribute.
    /// </summary>
    [TerraformProperty("default_primary_connection_string_alias")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultPrimaryConnectionStringAlias { get; }

    /// <summary>
    /// The default_primary_key attribute.
    /// </summary>
    [TerraformProperty("default_primary_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultPrimaryKey { get; }

    /// <summary>
    /// The default_secondary_connection_string attribute.
    /// </summary>
    [TerraformProperty("default_secondary_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultSecondaryConnectionString { get; }

    /// <summary>
    /// The default_secondary_connection_string_alias attribute.
    /// </summary>
    [TerraformProperty("default_secondary_connection_string_alias")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultSecondaryConnectionStringAlias { get; }

    /// <summary>
    /// The default_secondary_key attribute.
    /// </summary>
    [TerraformProperty("default_secondary_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultSecondaryKey { get; }

    /// <summary>
    /// The kafka_enabled attribute.
    /// </summary>
    [TerraformProperty("kafka_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> KafkaEnabled { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The maximum_throughput_units attribute.
    /// </summary>
    [TerraformProperty("maximum_throughput_units")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaximumThroughputUnits { get; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Sku { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

}
