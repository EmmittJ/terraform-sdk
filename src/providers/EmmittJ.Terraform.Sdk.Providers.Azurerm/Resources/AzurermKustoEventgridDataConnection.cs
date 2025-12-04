using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermKustoEventgridDataConnection.
/// Nesting mode: single
/// </summary>
public class AzurermKustoEventgridDataConnectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_kusto_eventgrid_data_connection Terraform resource.
/// Manages a azurerm_kusto_eventgrid_data_connection resource.
/// </summary>
public partial class AzurermKustoEventgridDataConnection(string name) : TerraformResource("azurerm_kusto_eventgrid_data_connection", name)
{
    /// <summary>
    /// The blob_storage_event_type attribute.
    /// </summary>
    public TerraformValue<string>? BlobStorageEventType
    {
        get => GetArgument<TerraformValue<string>>("blob_storage_event_type");
        set => SetArgument("blob_storage_event_type", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformValue<string> ClusterName
    {
        get => GetArgument<TerraformValue<string>>("cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    public TerraformValue<string>? DataFormat
    {
        get => GetArgument<TerraformValue<string>>("data_format");
        set => SetArgument("data_format", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => GetArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The database_routing_type attribute.
    /// </summary>
    public TerraformValue<string>? DatabaseRoutingType
    {
        get => GetArgument<TerraformValue<string>>("database_routing_type");
        set => SetArgument("database_routing_type", value);
    }

    /// <summary>
    /// The eventgrid_event_subscription_id attribute.
    /// </summary>
    public TerraformValue<string>? EventgridEventSubscriptionId
    {
        get => GetArgument<TerraformValue<string>>("eventgrid_event_subscription_id");
        set => SetArgument("eventgrid_event_subscription_id", value);
    }

    /// <summary>
    /// The eventgrid_resource_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? EventgridResourceId
    {
        get => GetArgument<TerraformValue<string>>("eventgrid_resource_id");
        set => SetArgument("eventgrid_resource_id", value);
    }

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubConsumerGroupName is required")]
    public required TerraformValue<string> EventhubConsumerGroupName
    {
        get => GetArgument<TerraformValue<string>>("eventhub_consumer_group_name");
        set => SetArgument("eventhub_consumer_group_name", value);
    }

    /// <summary>
    /// The eventhub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubId is required")]
    public required TerraformValue<string> EventhubId
    {
        get => GetArgument<TerraformValue<string>>("eventhub_id");
        set => SetArgument("eventhub_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The managed_identity_id attribute.
    /// </summary>
    public TerraformValue<string>? ManagedIdentityId
    {
        get => GetArgument<TerraformValue<string>>("managed_identity_id");
        set => SetArgument("managed_identity_id", value);
    }

    /// <summary>
    /// The managed_identity_resource_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? ManagedIdentityResourceId
    {
        get => GetArgument<TerraformValue<string>>("managed_identity_resource_id");
        set => SetArgument("managed_identity_resource_id", value);
    }

    /// <summary>
    /// The mapping_rule_name attribute.
    /// </summary>
    public TerraformValue<string>? MappingRuleName
    {
        get => GetArgument<TerraformValue<string>>("mapping_rule_name");
        set => SetArgument("mapping_rule_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The skip_first_record attribute.
    /// </summary>
    public TerraformValue<bool>? SkipFirstRecord
    {
        get => GetArgument<TerraformValue<bool>>("skip_first_record");
        set => SetArgument("skip_first_record", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformValue<string> StorageAccountId
    {
        get => GetArgument<TerraformValue<string>>("storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    public TerraformValue<string>? TableName
    {
        get => GetArgument<TerraformValue<string>>("table_name");
        set => SetArgument("table_name", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKustoEventgridDataConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKustoEventgridDataConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
