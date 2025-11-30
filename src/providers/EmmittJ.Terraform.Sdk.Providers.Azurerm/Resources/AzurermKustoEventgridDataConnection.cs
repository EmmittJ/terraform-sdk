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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "blob_storage_event_type");
        set => SetArgument("blob_storage_event_type", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformValue<string> ClusterName
    {
        get => new TerraformReference<string>(this, "cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    public TerraformValue<string>? DataFormat
    {
        get => new TerraformReference<string>(this, "data_format");
        set => SetArgument("data_format", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => new TerraformReference<string>(this, "database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The database_routing_type attribute.
    /// </summary>
    public TerraformValue<string>? DatabaseRoutingType
    {
        get => new TerraformReference<string>(this, "database_routing_type");
        set => SetArgument("database_routing_type", value);
    }

    /// <summary>
    /// The eventgrid_event_subscription_id attribute.
    /// </summary>
    public TerraformValue<string> EventgridEventSubscriptionId
    {
        get => new TerraformReference<string>(this, "eventgrid_event_subscription_id");
        set => SetArgument("eventgrid_event_subscription_id", value);
    }

    /// <summary>
    /// The eventgrid_resource_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> EventgridResourceId
    {
        get => new TerraformReference<string>(this, "eventgrid_resource_id");
        set => SetArgument("eventgrid_resource_id", value);
    }

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubConsumerGroupName is required")]
    public required TerraformValue<string> EventhubConsumerGroupName
    {
        get => new TerraformReference<string>(this, "eventhub_consumer_group_name");
        set => SetArgument("eventhub_consumer_group_name", value);
    }

    /// <summary>
    /// The eventhub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubId is required")]
    public required TerraformValue<string> EventhubId
    {
        get => new TerraformReference<string>(this, "eventhub_id");
        set => SetArgument("eventhub_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The managed_identity_id attribute.
    /// </summary>
    public TerraformValue<string> ManagedIdentityId
    {
        get => new TerraformReference<string>(this, "managed_identity_id");
        set => SetArgument("managed_identity_id", value);
    }

    /// <summary>
    /// The managed_identity_resource_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> ManagedIdentityResourceId
    {
        get => new TerraformReference<string>(this, "managed_identity_resource_id");
        set => SetArgument("managed_identity_resource_id", value);
    }

    /// <summary>
    /// The mapping_rule_name attribute.
    /// </summary>
    public TerraformValue<string>? MappingRuleName
    {
        get => new TerraformReference<string>(this, "mapping_rule_name");
        set => SetArgument("mapping_rule_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The skip_first_record attribute.
    /// </summary>
    public TerraformValue<bool>? SkipFirstRecord
    {
        get => new TerraformReference<bool>(this, "skip_first_record");
        set => SetArgument("skip_first_record", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformValue<string> StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    public TerraformValue<string>? TableName
    {
        get => new TerraformReference<string>(this, "table_name");
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
