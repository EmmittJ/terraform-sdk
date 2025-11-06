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
    public string? GrafanaId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("grafana_id")?.Value;
        set => this.WithProperty("grafana_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The group_ids attribute.
    /// </summary>
    public List<string>? GroupIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("group_ids")?.Value;
        set => this.WithProperty("group_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The private_link_resource_id attribute.
    /// </summary>
    public string? PrivateLinkResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_link_resource_id")?.Value;
        set => this.WithProperty("private_link_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The private_link_resource_region attribute.
    /// </summary>
    public string? PrivateLinkResourceRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_link_resource_region")?.Value;
        set => this.WithProperty("private_link_resource_region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The private_link_service_url attribute.
    /// </summary>
    public string? PrivateLinkServiceUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_link_service_url")?.Value;
        set => this.WithProperty("private_link_service_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The request_message attribute.
    /// </summary>
    public string? RequestMessage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("request_message")?.Value;
        set => this.WithProperty("request_message", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
