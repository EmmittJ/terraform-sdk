using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorDataCollectionEndpointDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_monitor_data_collection_endpoint.
/// </summary>
public class AzurermMonitorDataCollectionEndpointDataSource : TerraformDataSource
{
    public AzurermMonitorDataCollectionEndpointDataSource(string name) : base("azurerm_monitor_data_collection_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("configuration_access_endpoint");
        this.WithOutput("description");
        this.WithOutput("immutable_id");
        this.WithOutput("kind");
        this.WithOutput("location");
        this.WithOutput("logs_ingestion_endpoint");
        this.WithOutput("metrics_ingestion_endpoint");
        this.WithOutput("public_network_access_enabled");
        this.WithOutput("tags");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMonitorDataCollectionEndpointDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMonitorDataCollectionEndpointDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The configuration_access_endpoint attribute.
    /// </summary>
    public TerraformExpression ConfigurationAccessEndpoint => this["configuration_access_endpoint"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The immutable_id attribute.
    /// </summary>
    public TerraformExpression ImmutableId => this["immutable_id"];

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The logs_ingestion_endpoint attribute.
    /// </summary>
    public TerraformExpression LogsIngestionEndpoint => this["logs_ingestion_endpoint"];

    /// <summary>
    /// The metrics_ingestion_endpoint attribute.
    /// </summary>
    public TerraformExpression MetricsIngestionEndpoint => this["metrics_ingestion_endpoint"];

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformExpression PublicNetworkAccessEnabled => this["public_network_access_enabled"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
