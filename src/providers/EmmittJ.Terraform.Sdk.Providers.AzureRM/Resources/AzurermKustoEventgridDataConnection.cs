using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKustoEventgridDataConnectionTimeoutsBlock : TerraformBlockBase
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_kusto_eventgrid_data_connection resource.
/// </summary>
public partial class AzurermKustoEventgridDataConnection : TerraformResource
{
    public AzurermKustoEventgridDataConnection(string name) : base("azurerm_kusto_eventgrid_data_connection", name)
    {
    }

    /// <summary>
    /// The blob_storage_event_type attribute.
    /// </summary>
    [TerraformProperty("blob_storage_event_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? BlobStorageEventType { get; set; }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformProperty("cluster_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClusterName { get; set; }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    [TerraformProperty("data_format")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DataFormat { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformProperty("database_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The database_routing_type attribute.
    /// </summary>
    [TerraformProperty("database_routing_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DatabaseRoutingType { get; set; }

    /// <summary>
    /// The eventgrid_event_subscription_id attribute.
    /// </summary>
    [TerraformProperty("eventgrid_event_subscription_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EventgridEventSubscriptionId { get; set; }

    /// <summary>
    /// The eventgrid_resource_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("eventgrid_resource_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EventgridResourceId { get; set; }

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubConsumerGroupName is required")]
    [TerraformProperty("eventhub_consumer_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EventhubConsumerGroupName { get; set; }

    /// <summary>
    /// The eventhub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubId is required")]
    [TerraformProperty("eventhub_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EventhubId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The managed_identity_id attribute.
    /// </summary>
    [TerraformProperty("managed_identity_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ManagedIdentityId { get; set; }

    /// <summary>
    /// The managed_identity_resource_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("managed_identity_resource_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ManagedIdentityResourceId { get; set; }

    /// <summary>
    /// The mapping_rule_name attribute.
    /// </summary>
    [TerraformProperty("mapping_rule_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MappingRuleName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The skip_first_record attribute.
    /// </summary>
    [TerraformProperty("skip_first_record")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SkipFirstRecord { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformProperty("storage_account_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageAccountId { get; set; }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [TerraformProperty("table_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TableName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermKustoEventgridDataConnectionTimeoutsBlock>? Timeouts { get; set; }

}
