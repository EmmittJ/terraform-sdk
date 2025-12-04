using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDashboardGrafanaManagedPrivateEndpoint.
/// Nesting mode: single
/// </summary>
public class AzurermDashboardGrafanaManagedPrivateEndpointTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_dashboard_grafana_managed_private_endpoint Terraform resource.
/// Manages a azurerm_dashboard_grafana_managed_private_endpoint resource.
/// </summary>
public partial class AzurermDashboardGrafanaManagedPrivateEndpoint(string name) : TerraformResource("azurerm_dashboard_grafana_managed_private_endpoint", name)
{
    /// <summary>
    /// The grafana_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrafanaId is required")]
    public required TerraformValue<string> GrafanaId
    {
        get => GetArgument<TerraformValue<string>>("grafana_id");
        set => SetArgument("grafana_id", value);
    }

    /// <summary>
    /// The group_ids attribute.
    /// </summary>
    public TerraformList<string>? GroupIds
    {
        get => GetArgument<TerraformList<string>>("group_ids");
        set => SetArgument("group_ids", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_link_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateLinkResourceId is required")]
    public required TerraformValue<string> PrivateLinkResourceId
    {
        get => GetArgument<TerraformValue<string>>("private_link_resource_id");
        set => SetArgument("private_link_resource_id", value);
    }

    /// <summary>
    /// The private_link_resource_region attribute.
    /// </summary>
    public TerraformValue<string>? PrivateLinkResourceRegion
    {
        get => GetArgument<TerraformValue<string>>("private_link_resource_region");
        set => SetArgument("private_link_resource_region", value);
    }

    /// <summary>
    /// The private_link_service_url attribute.
    /// </summary>
    public TerraformValue<string>? PrivateLinkServiceUrl
    {
        get => GetArgument<TerraformValue<string>>("private_link_service_url");
        set => SetArgument("private_link_service_url", value);
    }

    /// <summary>
    /// The request_message attribute.
    /// </summary>
    public TerraformValue<string>? RequestMessage
    {
        get => GetArgument<TerraformValue<string>>("request_message");
        set => SetArgument("request_message", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDashboardGrafanaManagedPrivateEndpointTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDashboardGrafanaManagedPrivateEndpointTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
