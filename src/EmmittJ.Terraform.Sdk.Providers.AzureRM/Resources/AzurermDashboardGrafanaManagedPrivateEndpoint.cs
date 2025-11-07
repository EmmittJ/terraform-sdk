using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_dashboard_grafana_managed_private_endpoint resource.
/// </summary>
public class AzurermDashboardGrafanaManagedPrivateEndpoint : TerraformResource
{
    public AzurermDashboardGrafanaManagedPrivateEndpoint(string name) : base("azurerm_dashboard_grafana_managed_private_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The grafana_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GrafanaId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("grafana_id");
        set => this.WithProperty("grafana_id", value);
    }

    /// <summary>
    /// The group_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? GroupIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("group_ids");
        set => this.WithProperty("group_ids", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The private_link_resource_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PrivateLinkResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_link_resource_id");
        set => this.WithProperty("private_link_resource_id", value);
    }

    /// <summary>
    /// The private_link_resource_region attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PrivateLinkResourceRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_link_resource_region");
        set => this.WithProperty("private_link_resource_region", value);
    }

    /// <summary>
    /// The private_link_service_url attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PrivateLinkServiceUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_link_service_url");
        set => this.WithProperty("private_link_service_url", value);
    }

    /// <summary>
    /// The request_message attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RequestMessage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("request_message");
        set => this.WithProperty("request_message", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
