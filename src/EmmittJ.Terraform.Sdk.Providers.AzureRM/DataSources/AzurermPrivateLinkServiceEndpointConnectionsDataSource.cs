using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_private_link_service_endpoint_connections.
/// </summary>
public class AzurermPrivateLinkServiceEndpointConnectionsDataSource : TerraformDataSource
{
    public AzurermPrivateLinkServiceEndpointConnectionsDataSource(string name) : base("azurerm_private_link_service_endpoint_connections", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("location");
        this.DeclareOutput("private_endpoint_connections");
        this.DeclareOutput("service_name");
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceId
    {
        get => GetProperty<TerraformProperty<string>>("service_id");
        set => this.WithProperty("service_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The private_endpoint_connections attribute.
    /// </summary>
    public TerraformExpression PrivateEndpointConnections => this["private_endpoint_connections"];

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public TerraformExpression ServiceName => this["service_name"];

}
