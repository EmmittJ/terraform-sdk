using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermServicebusNamespaceDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_servicebus_namespace.
/// </summary>
public partial class AzurermServicebusNamespaceDataSource : TerraformDataSource
{
    public AzurermServicebusNamespaceDataSource(string name) : base("azurerm_servicebus_namespace", name)
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
    public AzurermServicebusNamespaceDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformProperty("capacity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Capacity { get; }

    /// <summary>
    /// The default_primary_connection_string attribute.
    /// </summary>
    [TerraformProperty("default_primary_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultPrimaryConnectionString { get; }

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
    /// The default_secondary_key attribute.
    /// </summary>
    [TerraformProperty("default_secondary_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultSecondaryKey { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The premium_messaging_partitions attribute.
    /// </summary>
    [TerraformProperty("premium_messaging_partitions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> PremiumMessagingPartitions { get; }

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
