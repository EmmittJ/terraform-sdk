using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDigitalTwinsTimeSeriesDatabaseConnectionTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Manages a azurerm_digital_twins_time_series_database_connection resource.
/// </summary>
public class AzurermDigitalTwinsTimeSeriesDatabaseConnection : TerraformResource
{
    public AzurermDigitalTwinsTimeSeriesDatabaseConnection(string name) : base("azurerm_digital_twins_time_series_database_connection", name)
    {
    }

    /// <summary>
    /// The digital_twins_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DigitalTwinsId is required")]
    [TerraformPropertyName("digital_twins_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DigitalTwinsId { get; set; }

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    [TerraformPropertyName("eventhub_consumer_group_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EventhubConsumerGroupName { get; set; }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubName is required")]
    [TerraformPropertyName("eventhub_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EventhubName { get; set; }

    /// <summary>
    /// The eventhub_namespace_endpoint_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubNamespaceEndpointUri is required")]
    [TerraformPropertyName("eventhub_namespace_endpoint_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EventhubNamespaceEndpointUri { get; set; }

    /// <summary>
    /// The eventhub_namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubNamespaceId is required")]
    [TerraformPropertyName("eventhub_namespace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EventhubNamespaceId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kusto_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KustoClusterId is required")]
    [TerraformPropertyName("kusto_cluster_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KustoClusterId { get; set; }

    /// <summary>
    /// The kusto_cluster_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KustoClusterUri is required")]
    [TerraformPropertyName("kusto_cluster_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KustoClusterUri { get; set; }

    /// <summary>
    /// The kusto_database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KustoDatabaseName is required")]
    [TerraformPropertyName("kusto_database_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KustoDatabaseName { get; set; }

    /// <summary>
    /// The kusto_table_name attribute.
    /// </summary>
    [TerraformPropertyName("kusto_table_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KustoTableName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDigitalTwinsTimeSeriesDatabaseConnectionTimeoutsBlock>? Timeouts { get; set; } = new();

}
