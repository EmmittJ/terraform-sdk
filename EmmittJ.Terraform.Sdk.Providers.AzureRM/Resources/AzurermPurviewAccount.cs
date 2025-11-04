using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_purview_account resource.
/// </summary>
public class AzurermPurviewAccount : TerraformResource
{
    public AzurermPurviewAccount(string name) : base("azurerm_purview_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("atlas_kafka_endpoint_primary_connection_string");
        this.DeclareOutput("atlas_kafka_endpoint_secondary_connection_string");
        this.DeclareOutput("aws_external_id");
        this.DeclareOutput("catalog_endpoint");
        this.DeclareOutput("guardian_endpoint");
        this.DeclareOutput("managed_resources");
        this.DeclareOutput("scan_endpoint");
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The managed_event_hub_enabled attribute.
    /// </summary>
    public bool? ManagedEventHubEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("managed_event_hub_enabled")?.Value;
        set => this.WithProperty("managed_event_hub_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    public string? ManagedResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_resource_group_name")?.Value;
        set => this.WithProperty("managed_resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The public_network_enabled attribute.
    /// </summary>
    public bool? PublicNetworkEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_enabled")?.Value;
        set => this.WithProperty("public_network_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The atlas_kafka_endpoint_primary_connection_string attribute.
    /// </summary>
    public TerraformExpression AtlasKafkaEndpointPrimaryConnectionString => this["atlas_kafka_endpoint_primary_connection_string"];

    /// <summary>
    /// The atlas_kafka_endpoint_secondary_connection_string attribute.
    /// </summary>
    public TerraformExpression AtlasKafkaEndpointSecondaryConnectionString => this["atlas_kafka_endpoint_secondary_connection_string"];

    /// <summary>
    /// The aws_external_id attribute.
    /// </summary>
    public TerraformExpression AwsExternalId => this["aws_external_id"];

    /// <summary>
    /// The catalog_endpoint attribute.
    /// </summary>
    public TerraformExpression CatalogEndpoint => this["catalog_endpoint"];

    /// <summary>
    /// The guardian_endpoint attribute.
    /// </summary>
    public TerraformExpression GuardianEndpoint => this["guardian_endpoint"];

    /// <summary>
    /// The managed_resources attribute.
    /// </summary>
    public TerraformExpression ManagedResources => this["managed_resources"];

    /// <summary>
    /// The scan_endpoint attribute.
    /// </summary>
    public TerraformExpression ScanEndpoint => this["scan_endpoint"];

}
