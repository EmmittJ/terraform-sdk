using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermVirtualDesktopHostPoolDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermVirtualDesktopHostPoolDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_virtual_desktop_host_pool Terraform data source.
/// Retrieves information about a azurerm_virtual_desktop_host_pool.
/// </summary>
public partial class AzurermVirtualDesktopHostPoolDataSource(string name) : TerraformDataSource("azurerm_virtual_desktop_host_pool", name)
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
    /// The custom_rdp_properties attribute.
    /// </summary>
    public TerraformValue<string> CustomRdpProperties
    {
        get => new TerraformReference<string>(this, "custom_rdp_properties");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public TerraformValue<string> FriendlyName
    {
        get => new TerraformReference<string>(this, "friendly_name");
    }

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    public TerraformValue<string> LoadBalancerType
    {
        get => new TerraformReference<string>(this, "load_balancer_type");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The maximum_sessions_allowed attribute.
    /// </summary>
    public TerraformValue<double> MaximumSessionsAllowed
    {
        get => new TerraformReference<double>(this, "maximum_sessions_allowed");
    }

    /// <summary>
    /// The personal_desktop_assignment_type attribute.
    /// </summary>
    public TerraformValue<string> PersonalDesktopAssignmentType
    {
        get => new TerraformReference<string>(this, "personal_desktop_assignment_type");
    }

    /// <summary>
    /// The preferred_app_group_type attribute.
    /// </summary>
    public TerraformValue<string> PreferredAppGroupType
    {
        get => new TerraformReference<string>(this, "preferred_app_group_type");
    }

    /// <summary>
    /// The scheduled_agent_updates attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ScheduledAgentUpdates
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "scheduled_agent_updates").ResolveNodes(ctx));
    }

    /// <summary>
    /// The start_vm_on_connect attribute.
    /// </summary>
    public TerraformValue<bool> StartVmOnConnect
    {
        get => new TerraformReference<bool>(this, "start_vm_on_connect");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

    /// <summary>
    /// The validate_environment attribute.
    /// </summary>
    public TerraformValue<bool> ValidateEnvironment
    {
        get => new TerraformReference<bool>(this, "validate_environment");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualDesktopHostPoolDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualDesktopHostPoolDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
