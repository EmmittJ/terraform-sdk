using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "digital_twins_id");
        set => SetArgument("digital_twins_id", value);
    }

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    public TerraformValue<string>? EventhubConsumerGroupName
    {
        get => new TerraformReference<string>(this, "eventhub_consumer_group_name");
        set => SetArgument("eventhub_consumer_group_name", value);
    }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubName is required")]
    public required TerraformValue<string> EventhubName
    {
        get => new TerraformReference<string>(this, "eventhub_name");
        set => SetArgument("eventhub_name", value);
    }

    /// <summary>
    /// The eventhub_namespace_endpoint_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubNamespaceEndpointUri is required")]
    public required TerraformValue<string> EventhubNamespaceEndpointUri
    {
        get => new TerraformReference<string>(this, "eventhub_namespace_endpoint_uri");
        set => SetArgument("eventhub_namespace_endpoint_uri", value);
    }

    /// <summary>
    /// The eventhub_namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubNamespaceId is required")]
    public required TerraformValue<string> EventhubNamespaceId
    {
        get => new TerraformReference<string>(this, "eventhub_namespace_id");
        set => SetArgument("eventhub_namespace_id", value);
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
    /// The kusto_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KustoClusterId is required")]
    public required TerraformValue<string> KustoClusterId
    {
        get => new TerraformReference<string>(this, "kusto_cluster_id");
        set => SetArgument("kusto_cluster_id", value);
    }

    /// <summary>
    /// The kusto_cluster_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KustoClusterUri is required")]
    public required TerraformValue<string> KustoClusterUri
    {
        get => new TerraformReference<string>(this, "kusto_cluster_uri");
        set => SetArgument("kusto_cluster_uri", value);
    }

    /// <summary>
    /// The kusto_database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KustoDatabaseName is required")]
    public required TerraformValue<string> KustoDatabaseName
    {
        get => new TerraformReference<string>(this, "kusto_database_name");
        set => SetArgument("kusto_database_name", value);
    }

    /// <summary>
    /// The kusto_table_name attribute.
    /// </summary>
    public TerraformValue<string>? KustoTableName
    {
        get => new TerraformReference<string>(this, "kusto_table_name");
        set => SetArgument("kusto_table_name", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDigitalTwinsTimeSeriesDatabaseConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDigitalTwinsTimeSeriesDatabaseConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
