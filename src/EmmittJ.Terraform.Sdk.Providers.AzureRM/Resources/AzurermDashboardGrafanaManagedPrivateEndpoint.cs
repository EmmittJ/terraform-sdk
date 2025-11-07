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
    public TerraformProperty<string>? GrafanaId
    {
        get => GetProperty<TerraformProperty<string>>("grafana_id");
        set => this.WithProperty("grafana_id", value);
    }

    /// <summary>
    /// The group_ids attribute.
    /// </summary>
    public TerraformProperty<List<string>>? GroupIds
    {
        get => GetProperty<TerraformProperty<List<string>>>("group_ids");
        set => this.WithProperty("group_ids", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The private_link_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateLinkResourceId
    {
        get => GetProperty<TerraformProperty<string>>("private_link_resource_id");
        set => this.WithProperty("private_link_resource_id", value);
    }

    /// <summary>
    /// The private_link_resource_region attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateLinkResourceRegion
    {
        get => GetProperty<TerraformProperty<string>>("private_link_resource_region");
        set => this.WithProperty("private_link_resource_region", value);
    }

    /// <summary>
    /// The private_link_service_url attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateLinkServiceUrl
    {
        get => GetProperty<TerraformProperty<string>>("private_link_service_url");
        set => this.WithProperty("private_link_service_url", value);
    }

    /// <summary>
    /// The request_message attribute.
    /// </summary>
    public TerraformProperty<string>? RequestMessage
    {
        get => GetProperty<TerraformProperty<string>>("request_message");
        set => this.WithProperty("request_message", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
