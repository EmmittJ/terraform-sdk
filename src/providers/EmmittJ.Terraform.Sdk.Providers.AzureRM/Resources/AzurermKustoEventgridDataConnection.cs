using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKustoEventgridDataConnectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_kusto_eventgrid_data_connection resource.
/// </summary>
public class AzurermKustoEventgridDataConnection : TerraformResource
{
    public AzurermKustoEventgridDataConnection(string name) : base("azurerm_kusto_eventgrid_data_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("blob_storage_event_type");
        SetOutput("cluster_name");
        SetOutput("data_format");
        SetOutput("database_name");
        SetOutput("database_routing_type");
        SetOutput("eventgrid_event_subscription_id");
        SetOutput("eventgrid_resource_id");
        SetOutput("eventhub_consumer_group_name");
        SetOutput("eventhub_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("managed_identity_id");
        SetOutput("managed_identity_resource_id");
        SetOutput("mapping_rule_name");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("skip_first_record");
        SetOutput("storage_account_id");
        SetOutput("table_name");
    }

    /// <summary>
    /// The blob_storage_event_type attribute.
    /// </summary>
    public TerraformProperty<string> BlobStorageEventType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("blob_storage_event_type");
        set => SetProperty("blob_storage_event_type", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformProperty<string> ClusterName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_name");
        set => SetProperty("cluster_name", value);
    }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    public TerraformProperty<string> DataFormat
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_format");
        set => SetProperty("data_format", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_name");
        set => SetProperty("database_name", value);
    }

    /// <summary>
    /// The database_routing_type attribute.
    /// </summary>
    public TerraformProperty<string> DatabaseRoutingType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_routing_type");
        set => SetProperty("database_routing_type", value);
    }

    /// <summary>
    /// The eventgrid_event_subscription_id attribute.
    /// </summary>
    public TerraformProperty<string> EventgridEventSubscriptionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eventgrid_event_subscription_id");
        set => SetProperty("eventgrid_event_subscription_id", value);
    }

    /// <summary>
    /// The eventgrid_resource_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string> EventgridResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eventgrid_resource_id");
        set => SetProperty("eventgrid_resource_id", value);
    }

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubConsumerGroupName is required")]
    public required TerraformProperty<string> EventhubConsumerGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eventhub_consumer_group_name");
        set => SetProperty("eventhub_consumer_group_name", value);
    }

    /// <summary>
    /// The eventhub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubId is required")]
    public required TerraformProperty<string> EventhubId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eventhub_id");
        set => SetProperty("eventhub_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The managed_identity_id attribute.
    /// </summary>
    public TerraformProperty<string> ManagedIdentityId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_identity_id");
        set => SetProperty("managed_identity_id", value);
    }

    /// <summary>
    /// The managed_identity_resource_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string> ManagedIdentityResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_identity_resource_id");
        set => SetProperty("managed_identity_resource_id", value);
    }

    /// <summary>
    /// The mapping_rule_name attribute.
    /// </summary>
    public TerraformProperty<string> MappingRuleName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mapping_rule_name");
        set => SetProperty("mapping_rule_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The skip_first_record attribute.
    /// </summary>
    public TerraformProperty<bool> SkipFirstRecord
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_first_record");
        set => SetProperty("skip_first_record", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_id");
        set => SetProperty("storage_account_id", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    public TerraformProperty<string> TableName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("table_name");
        set => SetProperty("table_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKustoEventgridDataConnectionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
