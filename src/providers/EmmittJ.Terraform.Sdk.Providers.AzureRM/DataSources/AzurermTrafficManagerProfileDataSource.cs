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
public class AzurermTrafficManagerProfileDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_traffic_manager_profile.
/// </summary>
public class AzurermTrafficManagerProfileDataSource : TerraformDataSource
{
    public AzurermTrafficManagerProfileDataSource(string name) : base("azurerm_traffic_manager_profile", name)
    {
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
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
    /// The traffic_view_enabled attribute.
    /// </summary>
    [TerraformArgument("traffic_view_enabled")]
    public TerraformValue<bool>? TrafficViewEnabled
    {
        get => new TerraformReference<bool>(this, "traffic_view_enabled");
        set => SetArgument("traffic_view_enabled", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermTrafficManagerProfileDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The dns_config attribute.
    /// </summary>
    [TerraformArgument("dns_config")]
    public TerraformList<object> DnsConfig
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "dns_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformArgument("fqdn")]
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

    /// <summary>
    /// The monitor_config attribute.
    /// </summary>
    [TerraformArgument("monitor_config")]
    public TerraformList<object> MonitorConfig
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "monitor_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The profile_status attribute.
    /// </summary>
    [TerraformArgument("profile_status")]
    public TerraformValue<string> ProfileStatus
    {
        get => new TerraformReference<string>(this, "profile_status");
    }

    /// <summary>
    /// The traffic_routing_method attribute.
    /// </summary>
    [TerraformArgument("traffic_routing_method")]
    public TerraformValue<string> TrafficRoutingMethod
    {
        get => new TerraformReference<string>(this, "traffic_routing_method");
    }

}
