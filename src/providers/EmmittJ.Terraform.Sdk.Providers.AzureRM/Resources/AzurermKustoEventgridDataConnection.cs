using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKustoEventgridDataConnectionTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_kusto_eventgrid_data_connection resource.
/// </summary>
public class AzurermKustoEventgridDataConnection : TerraformResource
{
    public AzurermKustoEventgridDataConnection(string name) : base("azurerm_kusto_eventgrid_data_connection", name)
    {
    }

    /// <summary>
    /// The blob_storage_event_type attribute.
    /// </summary>
    [TerraformPropertyName("blob_storage_event_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BlobStorageEventType { get; set; }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformPropertyName("cluster_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterName { get; set; }

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
    /// The eventgrid_event_subscription_id attribute.
    /// </summary>
    [TerraformPropertyName("eventgrid_event_subscription_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EventgridEventSubscriptionId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "eventgrid_event_subscription_id");

    /// <summary>
    /// The eventgrid_resource_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("eventgrid_resource_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EventgridResourceId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "eventgrid_resource_id");

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubConsumerGroupName is required")]
    [TerraformPropertyName("eventhub_consumer_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EventhubConsumerGroupName { get; set; }

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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The managed_identity_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_identity_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ManagedIdentityId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "managed_identity_id");

    /// <summary>
    /// The managed_identity_resource_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("managed_identity_resource_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ManagedIdentityResourceId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "managed_identity_resource_id");

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
    /// The skip_first_record attribute.
    /// </summary>
    [TerraformPropertyName("skip_first_record")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SkipFirstRecord { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformPropertyName("storage_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageAccountId { get; set; }

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
    public TerraformBlock<AzurermKustoEventgridDataConnectionTimeoutsBlock>? Timeouts { get; set; } = new();

}
