using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDigitalTwinsTimeSeriesDatabaseConnectionTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azurerm_digital_twins_time_series_database_connection resource.
/// </summary>
public partial class AzurermDigitalTwinsTimeSeriesDatabaseConnection : TerraformResource
{
    public AzurermDigitalTwinsTimeSeriesDatabaseConnection(string name) : base("azurerm_digital_twins_time_series_database_connection", name)
    {
    }

    /// <summary>
    /// The digital_twins_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DigitalTwinsId is required")]
    [TerraformProperty("digital_twins_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DigitalTwinsId { get; set; }

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    [TerraformProperty("eventhub_consumer_group_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EventhubConsumerGroupName { get; set; }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubName is required")]
    [TerraformProperty("eventhub_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EventhubName { get; set; }

    /// <summary>
    /// The eventhub_namespace_endpoint_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubNamespaceEndpointUri is required")]
    [TerraformProperty("eventhub_namespace_endpoint_uri")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EventhubNamespaceEndpointUri { get; set; }

    /// <summary>
    /// The eventhub_namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubNamespaceId is required")]
    [TerraformProperty("eventhub_namespace_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EventhubNamespaceId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kusto_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KustoClusterId is required")]
    [TerraformProperty("kusto_cluster_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KustoClusterId { get; set; }

    /// <summary>
    /// The kusto_cluster_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KustoClusterUri is required")]
    [TerraformProperty("kusto_cluster_uri")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KustoClusterUri { get; set; }

    /// <summary>
    /// The kusto_database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KustoDatabaseName is required")]
    [TerraformProperty("kusto_database_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KustoDatabaseName { get; set; }

    /// <summary>
    /// The kusto_table_name attribute.
    /// </summary>
    [TerraformProperty("kusto_table_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KustoTableName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermDigitalTwinsTimeSeriesDatabaseConnectionTimeoutsBlock>? Timeouts { get; set; }

}
