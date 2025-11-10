using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDashboardGrafanaManagedPrivateEndpointTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("grafana_id");
        SetOutput("group_ids");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("private_link_resource_id");
        SetOutput("private_link_resource_region");
        SetOutput("private_link_service_url");
        SetOutput("request_message");
        SetOutput("tags");
    }

    /// <summary>
    /// The grafana_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrafanaId is required")]
    public required TerraformProperty<string> GrafanaId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("grafana_id");
        set => SetProperty("grafana_id", value);
    }

    /// <summary>
    /// The group_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>> GroupIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("group_ids");
        set => SetProperty("group_ids", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// The private_link_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateLinkResourceId is required")]
    public required TerraformProperty<string> PrivateLinkResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("private_link_resource_id");
        set => SetProperty("private_link_resource_id", value);
    }

    /// <summary>
    /// The private_link_resource_region attribute.
    /// </summary>
    public TerraformProperty<string> PrivateLinkResourceRegion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("private_link_resource_region");
        set => SetProperty("private_link_resource_region", value);
    }

    /// <summary>
    /// The private_link_service_url attribute.
    /// </summary>
    public TerraformProperty<string> PrivateLinkServiceUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("private_link_service_url");
        set => SetProperty("private_link_service_url", value);
    }

    /// <summary>
    /// The request_message attribute.
    /// </summary>
    public TerraformProperty<string> RequestMessage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("request_message");
        set => SetProperty("request_message", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDashboardGrafanaManagedPrivateEndpointTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
