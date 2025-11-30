using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermTrafficManagerProfileDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermTrafficManagerProfileDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_traffic_manager_profile Terraform data source.
/// Retrieves information about a azurerm_traffic_manager_profile.
/// </summary>
public partial class AzurermTrafficManagerProfileDataSource(string name) : TerraformDataSource("azurerm_traffic_manager_profile", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The traffic_view_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TrafficViewEnabled
    {
        get => new TerraformReference<bool>(this, "traffic_view_enabled");
        set => SetArgument("traffic_view_enabled", value);
    }

    /// <summary>
    /// The dns_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DnsConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "dns_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

    /// <summary>
    /// The monitor_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MonitorConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "monitor_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The profile_status attribute.
    /// </summary>
    public TerraformValue<string> ProfileStatus
    {
        get => new TerraformReference<string>(this, "profile_status");
    }

    /// <summary>
    /// The traffic_routing_method attribute.
    /// </summary>
    public TerraformValue<string> TrafficRoutingMethod
    {
        get => new TerraformReference<string>(this, "traffic_routing_method");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermTrafficManagerProfileDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermTrafficManagerProfileDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
