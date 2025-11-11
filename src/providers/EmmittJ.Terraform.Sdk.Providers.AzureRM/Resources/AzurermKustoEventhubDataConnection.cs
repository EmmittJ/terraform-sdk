using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKustoEventhubDataConnectionTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_kusto_eventhub_data_connection resource.
/// </summary>
public partial class AzurermKustoEventhubDataConnection : TerraformResource
{
    public AzurermKustoEventhubDataConnection(string name) : base("azurerm_kusto_eventhub_data_connection", name)
    {
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformProperty("cluster_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterName { get; set; }

    /// <summary>
    /// The compression attribute.
    /// </summary>
    [TerraformProperty("compression")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Compression { get; set; }

    /// <summary>
    /// The consumer_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerGroup is required")]
    [TerraformProperty("consumer_group")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConsumerGroup { get; set; }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    [TerraformProperty("data_format")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DataFormat { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformProperty("database_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The database_routing_type attribute.
    /// </summary>
    [TerraformProperty("database_routing_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DatabaseRoutingType { get; set; }

    /// <summary>
    /// The event_system_properties attribute.
    /// </summary>
    [TerraformProperty("event_system_properties")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> EventSystemProperties { get; set; }

    /// <summary>
    /// The eventhub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubId is required")]
    [TerraformProperty("eventhub_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EventhubId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The identity_id attribute.
    /// </summary>
    [TerraformProperty("identity_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IdentityId { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The mapping_rule_name attribute.
    /// </summary>
    [TerraformProperty("mapping_rule_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MappingRuleName { get; set; }

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
    /// The table_name attribute.
    /// </summary>
    [TerraformProperty("table_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TableName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermKustoEventhubDataConnectionTimeoutsBlock>? Timeouts { get; set; }

}
