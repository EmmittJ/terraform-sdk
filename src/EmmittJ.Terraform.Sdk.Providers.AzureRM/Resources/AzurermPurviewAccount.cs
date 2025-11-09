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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The managed_event_hub_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ManagedEventHubEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("managed_event_hub_enabled");
        set => this.WithProperty("managed_event_hub_enabled", value);
    }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("managed_resource_group_name");
        set => this.WithProperty("managed_resource_group_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_network_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_enabled");
        set => this.WithProperty("public_network_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
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
