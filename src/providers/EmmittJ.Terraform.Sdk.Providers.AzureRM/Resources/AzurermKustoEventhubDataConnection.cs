using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKustoEventhubDataConnectionTimeoutsBlock : ITerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_kusto_eventhub_data_connection resource.
/// </summary>
public class AzurermKustoEventhubDataConnection : TerraformResource
{
    public AzurermKustoEventhubDataConnection(string name) : base("azurerm_kusto_eventhub_data_connection", name)
    {
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformPropertyName("cluster_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterName { get; set; }

    /// <summary>
    /// The compression attribute.
    /// </summary>
    [TerraformPropertyName("compression")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Compression { get; set; }

    /// <summary>
    /// The consumer_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerGroup is required")]
    [TerraformPropertyName("consumer_group")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ConsumerGroup { get; set; }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    [TerraformPropertyName("data_format")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DataFormat { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformPropertyName("database_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DatabaseName { get; set; }

    /// <summary>
    /// The database_routing_type attribute.
    /// </summary>
    [TerraformPropertyName("database_routing_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DatabaseRoutingType { get; set; }

    /// <summary>
    /// The event_system_properties attribute.
    /// </summary>
    [TerraformPropertyName("event_system_properties")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> EventSystemProperties { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "event_system_properties");

    /// <summary>
    /// The eventhub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubId is required")]
    [TerraformPropertyName("eventhub_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EventhubId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The identity_id attribute.
    /// </summary>
    [TerraformPropertyName("identity_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IdentityId { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The mapping_rule_name attribute.
    /// </summary>
    [TerraformPropertyName("mapping_rule_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MappingRuleName { get; set; }

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
    /// The table_name attribute.
    /// </summary>
    [TerraformPropertyName("table_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TableName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKustoEventhubDataConnectionTimeoutsBlock>? Timeouts { get; set; } = new();

}
