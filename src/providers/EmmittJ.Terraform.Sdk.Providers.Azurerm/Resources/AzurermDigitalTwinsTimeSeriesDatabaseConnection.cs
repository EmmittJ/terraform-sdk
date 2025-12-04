using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDigitalTwinsTimeSeriesDatabaseConnection.
/// Nesting mode: single
/// </summary>
public class AzurermDigitalTwinsTimeSeriesDatabaseConnectionTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a azurerm_digital_twins_time_series_database_connection Terraform resource.
/// Manages a azurerm_digital_twins_time_series_database_connection resource.
/// </summary>
public partial class AzurermDigitalTwinsTimeSeriesDatabaseConnection(string name) : TerraformResource("azurerm_digital_twins_time_series_database_connection", name)
{
    /// <summary>
    /// The digital_twins_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DigitalTwinsId is required")]
    public required TerraformValue<string> DigitalTwinsId
    {
        get => GetArgument<TerraformValue<string>>("digital_twins_id");
        set => SetArgument("digital_twins_id", value);
    }

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    public TerraformValue<string>? EventhubConsumerGroupName
    {
        get => GetArgument<TerraformValue<string>>("eventhub_consumer_group_name");
        set => SetArgument("eventhub_consumer_group_name", value);
    }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubName is required")]
    public required TerraformValue<string> EventhubName
    {
        get => GetArgument<TerraformValue<string>>("eventhub_name");
        set => SetArgument("eventhub_name", value);
    }

    /// <summary>
    /// The eventhub_namespace_endpoint_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubNamespaceEndpointUri is required")]
    public required TerraformValue<string> EventhubNamespaceEndpointUri
    {
        get => GetArgument<TerraformValue<string>>("eventhub_namespace_endpoint_uri");
        set => SetArgument("eventhub_namespace_endpoint_uri", value);
    }

    /// <summary>
    /// The eventhub_namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubNamespaceId is required")]
    public required TerraformValue<string> EventhubNamespaceId
    {
        get => GetArgument<TerraformValue<string>>("eventhub_namespace_id");
        set => SetArgument("eventhub_namespace_id", value);
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
    /// The kusto_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KustoClusterId is required")]
    public required TerraformValue<string> KustoClusterId
    {
        get => GetArgument<TerraformValue<string>>("kusto_cluster_id");
        set => SetArgument("kusto_cluster_id", value);
    }

    /// <summary>
    /// The kusto_cluster_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KustoClusterUri is required")]
    public required TerraformValue<string> KustoClusterUri
    {
        get => GetArgument<TerraformValue<string>>("kusto_cluster_uri");
        set => SetArgument("kusto_cluster_uri", value);
    }

    /// <summary>
    /// The kusto_database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KustoDatabaseName is required")]
    public required TerraformValue<string> KustoDatabaseName
    {
        get => GetArgument<TerraformValue<string>>("kusto_database_name");
        set => SetArgument("kusto_database_name", value);
    }

    /// <summary>
    /// The kusto_table_name attribute.
    /// </summary>
    public TerraformValue<string>? KustoTableName
    {
        get => GetArgument<TerraformValue<string>>("kusto_table_name");
        set => SetArgument("kusto_table_name", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDigitalTwinsTimeSeriesDatabaseConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDigitalTwinsTimeSeriesDatabaseConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
