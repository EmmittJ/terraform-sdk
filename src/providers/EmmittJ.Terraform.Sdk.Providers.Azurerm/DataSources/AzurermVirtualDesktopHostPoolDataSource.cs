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
        get => GetArgument<TerraformValue<string>>("read");
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
    /// The custom_rdp_properties attribute.
    /// </summary>
    public TerraformValue<string> CustomRdpProperties
        => CreateReference("custom_rdp_properties");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public TerraformValue<string> FriendlyName
        => CreateReference("friendly_name");

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    public TerraformValue<string> LoadBalancerType
        => CreateReference("load_balancer_type");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The maximum_sessions_allowed attribute.
    /// </summary>
    public TerraformValue<double> MaximumSessionsAllowed
        => CreateReference("maximum_sessions_allowed");

    /// <summary>
    /// The personal_desktop_assignment_type attribute.
    /// </summary>
    public TerraformValue<string> PersonalDesktopAssignmentType
        => CreateReference("personal_desktop_assignment_type");

    /// <summary>
    /// The preferred_app_group_type attribute.
    /// </summary>
    public TerraformValue<string> PreferredAppGroupType
        => CreateReference("preferred_app_group_type");

    /// <summary>
    /// The scheduled_agent_updates attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ScheduledAgentUpdates
        => CreateReference("scheduled_agent_updates");

    /// <summary>
    /// The start_vm_on_connect attribute.
    /// </summary>
    public TerraformValue<bool> StartVmOnConnect
        => CreateReference("start_vm_on_connect");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => CreateReference("type");

    /// <summary>
    /// The validate_environment attribute.
    /// </summary>
    public TerraformValue<bool> ValidateEnvironment
        => CreateReference("validate_environment");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualDesktopHostPoolDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualDesktopHostPoolDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
