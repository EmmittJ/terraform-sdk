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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
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
    /// The traffic_view_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TrafficViewEnabled
    {
        get => GetArgument<TerraformValue<bool>>("traffic_view_enabled");
        set => SetArgument("traffic_view_enabled", value);
    }

    /// <summary>
    /// The dns_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DnsConfig
        => CreateReference("dns_config");

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
        => CreateReference("fqdn");

    /// <summary>
    /// The monitor_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MonitorConfig
        => CreateReference("monitor_config");

    /// <summary>
    /// The profile_status attribute.
    /// </summary>
    public TerraformValue<string> ProfileStatus
        => CreateReference("profile_status");

    /// <summary>
    /// The traffic_routing_method attribute.
    /// </summary>
    public TerraformValue<string> TrafficRoutingMethod
        => CreateReference("traffic_routing_method");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermTrafficManagerProfileDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermTrafficManagerProfileDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
