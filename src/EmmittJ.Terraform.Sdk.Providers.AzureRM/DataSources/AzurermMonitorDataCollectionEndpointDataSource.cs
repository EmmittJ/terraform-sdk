using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("configuration_access_endpoint");
        this.DeclareOutput("description");
        this.DeclareOutput("immutable_id");
        this.DeclareOutput("kind");
        this.DeclareOutput("location");
        this.DeclareOutput("logs_ingestion_endpoint");
        this.DeclareOutput("metrics_ingestion_endpoint");
        this.DeclareOutput("public_network_access_enabled");
        this.DeclareOutput("tags");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
