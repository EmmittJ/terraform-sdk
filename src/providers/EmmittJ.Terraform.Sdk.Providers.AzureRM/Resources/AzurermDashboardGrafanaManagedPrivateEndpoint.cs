using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_dashboard_grafana_managed_private_endpoint resource.
/// </summary>
public class AzurermDashboardGrafanaManagedPrivateEndpoint : TerraformResource
{
    public AzurermDashboardGrafanaManagedPrivateEndpoint(string name) : base("azurerm_dashboard_grafana_managed_private_endpoint", name)
    {
    }

    /// <summary>
    /// The grafana_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrafanaId is required")]
    [TerraformArgument("grafana_id")]
    public required TerraformValue<string> GrafanaId
    {
        get => new TerraformReference<string>(this, "grafana_id");
        set => SetArgument("grafana_id", value);
    }

    /// <summary>
    /// The group_ids attribute.
    /// </summary>
    [TerraformArgument("group_ids")]
    public TerraformList<string>? GroupIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "group_ids").ResolveNodes(ctx));
        set => SetArgument("group_ids", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_link_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateLinkResourceId is required")]
    [TerraformArgument("private_link_resource_id")]
    public required TerraformValue<string> PrivateLinkResourceId
    {
        get => new TerraformReference<string>(this, "private_link_resource_id");
        set => SetArgument("private_link_resource_id", value);
    }

    /// <summary>
    /// The private_link_resource_region attribute.
    /// </summary>
    [TerraformArgument("private_link_resource_region")]
    public TerraformValue<string>? PrivateLinkResourceRegion
    {
        get => new TerraformReference<string>(this, "private_link_resource_region");
        set => SetArgument("private_link_resource_region", value);
    }

    /// <summary>
    /// The private_link_service_url attribute.
    /// </summary>
    [TerraformArgument("private_link_service_url")]
    public TerraformValue<string>? PrivateLinkServiceUrl
    {
        get => new TerraformReference<string>(this, "private_link_service_url");
        set => SetArgument("private_link_service_url", value);
    }

    /// <summary>
    /// The request_message attribute.
    /// </summary>
    [TerraformArgument("request_message")]
    public TerraformValue<string>? RequestMessage
    {
        get => new TerraformReference<string>(this, "request_message");
        set => SetArgument("request_message", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermDashboardGrafanaManagedPrivateEndpointTimeoutsBlock Timeouts { get; set; } = new();

}
