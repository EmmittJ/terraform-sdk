using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDigitalTwinsTimeSeriesDatabaseConnectionTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azurerm_digital_twins_time_series_database_connection resource.
/// </summary>
public class AzurermDigitalTwinsTimeSeriesDatabaseConnection : TerraformResource
{
    public AzurermDigitalTwinsTimeSeriesDatabaseConnection(string name) : base("azurerm_digital_twins_time_series_database_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("digital_twins_id");
        SetOutput("eventhub_consumer_group_name");
        SetOutput("eventhub_name");
        SetOutput("eventhub_namespace_endpoint_uri");
        SetOutput("eventhub_namespace_id");
        SetOutput("id");
        SetOutput("kusto_cluster_id");
        SetOutput("kusto_cluster_uri");
        SetOutput("kusto_database_name");
        SetOutput("kusto_table_name");
        SetOutput("name");
    }

    /// <summary>
    /// The digital_twins_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DigitalTwinsId is required")]
    public required TerraformProperty<string> DigitalTwinsId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("digital_twins_id");
        set => SetProperty("digital_twins_id", value);
    }

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    public TerraformProperty<string> EventhubConsumerGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eventhub_consumer_group_name");
        set => SetProperty("eventhub_consumer_group_name", value);
    }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubName is required")]
    public required TerraformProperty<string> EventhubName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eventhub_name");
        set => SetProperty("eventhub_name", value);
    }

    /// <summary>
    /// The eventhub_namespace_endpoint_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubNamespaceEndpointUri is required")]
    public required TerraformProperty<string> EventhubNamespaceEndpointUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eventhub_namespace_endpoint_uri");
        set => SetProperty("eventhub_namespace_endpoint_uri", value);
    }

    /// <summary>
    /// The eventhub_namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubNamespaceId is required")]
    public required TerraformProperty<string> EventhubNamespaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eventhub_namespace_id");
        set => SetProperty("eventhub_namespace_id", value);
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
    /// The kusto_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KustoClusterId is required")]
    public required TerraformProperty<string> KustoClusterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kusto_cluster_id");
        set => SetProperty("kusto_cluster_id", value);
    }

    /// <summary>
    /// The kusto_cluster_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KustoClusterUri is required")]
    public required TerraformProperty<string> KustoClusterUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kusto_cluster_uri");
        set => SetProperty("kusto_cluster_uri", value);
    }

    /// <summary>
    /// The kusto_database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KustoDatabaseName is required")]
    public required TerraformProperty<string> KustoDatabaseName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kusto_database_name");
        set => SetProperty("kusto_database_name", value);
    }

    /// <summary>
    /// The kusto_table_name attribute.
    /// </summary>
    public TerraformProperty<string> KustoTableName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kusto_table_name");
        set => SetProperty("kusto_table_name", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDigitalTwinsTimeSeriesDatabaseConnectionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
