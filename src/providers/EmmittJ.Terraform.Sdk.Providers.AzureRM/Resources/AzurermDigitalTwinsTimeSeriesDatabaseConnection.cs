using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

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
    [TerraformArgument("digital_twins_id")]
    public required TerraformValue<string> DigitalTwinsId
    {
        get => new TerraformReference<string>(this, "digital_twins_id");
        set => SetArgument("digital_twins_id", value);
    }

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    [TerraformArgument("eventhub_consumer_group_name")]
    public TerraformValue<string>? EventhubConsumerGroupName
    {
        get => new TerraformReference<string>(this, "eventhub_consumer_group_name");
        set => SetArgument("eventhub_consumer_group_name", value);
    }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubName is required")]
    [TerraformArgument("eventhub_name")]
    public required TerraformValue<string> EventhubName
    {
        get => new TerraformReference<string>(this, "eventhub_name");
        set => SetArgument("eventhub_name", value);
    }

    /// <summary>
    /// The eventhub_namespace_endpoint_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubNamespaceEndpointUri is required")]
    [TerraformArgument("eventhub_namespace_endpoint_uri")]
    public required TerraformValue<string> EventhubNamespaceEndpointUri
    {
        get => new TerraformReference<string>(this, "eventhub_namespace_endpoint_uri");
        set => SetArgument("eventhub_namespace_endpoint_uri", value);
    }

    /// <summary>
    /// The eventhub_namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubNamespaceId is required")]
    [TerraformArgument("eventhub_namespace_id")]
    public required TerraformValue<string> EventhubNamespaceId
    {
        get => new TerraformReference<string>(this, "eventhub_namespace_id");
        set => SetArgument("eventhub_namespace_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kusto_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KustoClusterId is required")]
    [TerraformArgument("kusto_cluster_id")]
    public required TerraformValue<string> KustoClusterId
    {
        get => new TerraformReference<string>(this, "kusto_cluster_id");
        set => SetArgument("kusto_cluster_id", value);
    }

    /// <summary>
    /// The kusto_cluster_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KustoClusterUri is required")]
    [TerraformArgument("kusto_cluster_uri")]
    public required TerraformValue<string> KustoClusterUri
    {
        get => new TerraformReference<string>(this, "kusto_cluster_uri");
        set => SetArgument("kusto_cluster_uri", value);
    }

    /// <summary>
    /// The kusto_database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KustoDatabaseName is required")]
    [TerraformArgument("kusto_database_name")]
    public required TerraformValue<string> KustoDatabaseName
    {
        get => new TerraformReference<string>(this, "kusto_database_name");
        set => SetArgument("kusto_database_name", value);
    }

    /// <summary>
    /// The kusto_table_name attribute.
    /// </summary>
    [TerraformArgument("kusto_table_name")]
    public TerraformValue<string>? KustoTableName
    {
        get => new TerraformReference<string>(this, "kusto_table_name");
        set => SetArgument("kusto_table_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermDigitalTwinsTimeSeriesDatabaseConnectionTimeoutsBlock Timeouts { get; set; } = new();

}
