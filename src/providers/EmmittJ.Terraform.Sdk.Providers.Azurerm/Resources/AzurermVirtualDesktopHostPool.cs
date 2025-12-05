using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for scheduled_agent_updates in AzurermVirtualDesktopHostPool.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualDesktopHostPoolScheduledAgentUpdatesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scheduled_agent_updates";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformValue<string>? Timezone
    {
        get => GetArgument<TerraformValue<string>>("timezone");
        set => SetArgument("timezone", value);
    }

    /// <summary>
    /// The use_session_host_timezone attribute.
    /// </summary>
    public TerraformValue<bool>? UseSessionHostTimezone
    {
        get => GetArgument<TerraformValue<bool>>("use_session_host_timezone");
        set => SetArgument("use_session_host_timezone", value);
    }

    /// <summary>
    /// Schedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 Schedule block(s) allowed")]
    public TerraformList<AzurermVirtualDesktopHostPoolScheduledAgentUpdatesBlockScheduleBlock>? Schedule
    {
        get => GetArgument<TerraformList<AzurermVirtualDesktopHostPoolScheduledAgentUpdatesBlockScheduleBlock>>("schedule");
        set => SetArgument("schedule", value);
    }

}

/// <summary>
/// Block type for schedule in AzurermVirtualDesktopHostPoolScheduledAgentUpdatesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualDesktopHostPoolScheduledAgentUpdatesBlockScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule";

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    public required TerraformValue<string> DayOfWeek
    {
        get => GetRequiredArgument<TerraformValue<string>>("day_of_week");
        set => SetArgument("day_of_week", value);
    }

    /// <summary>
    /// The hour_of_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HourOfDay is required")]
    public required TerraformValue<double> HourOfDay
    {
        get => GetRequiredArgument<TerraformValue<double>>("hour_of_day");
        set => SetArgument("hour_of_day", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermVirtualDesktopHostPool.
/// Nesting mode: single
/// </summary>
public class AzurermVirtualDesktopHostPoolTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_virtual_desktop_host_pool Terraform resource.
/// Manages a azurerm_virtual_desktop_host_pool resource.
/// </summary>
public partial class AzurermVirtualDesktopHostPool(string name) : TerraformResource("azurerm_virtual_desktop_host_pool", name)
{
    /// <summary>
    /// The custom_rdp_properties attribute.
    /// </summary>
    public TerraformValue<string>? CustomRdpProperties
    {
        get => GetArgument<TerraformValue<string>>("custom_rdp_properties");
        set => SetArgument("custom_rdp_properties", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public TerraformValue<string>? FriendlyName
    {
        get => GetArgument<TerraformValue<string>>("friendly_name");
        set => SetArgument("friendly_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerType is required")]
    public required TerraformValue<string> LoadBalancerType
    {
        get => GetRequiredArgument<TerraformValue<string>>("load_balancer_type");
        set => SetArgument("load_balancer_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The maximum_sessions_allowed attribute.
    /// </summary>
    public TerraformValue<double>? MaximumSessionsAllowed
    {
        get => GetArgument<TerraformValue<double>>("maximum_sessions_allowed");
        set => SetArgument("maximum_sessions_allowed", value);
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
    /// The personal_desktop_assignment_type attribute.
    /// </summary>
    public TerraformValue<string>? PersonalDesktopAssignmentType
    {
        get => GetArgument<TerraformValue<string>>("personal_desktop_assignment_type");
        set => SetArgument("personal_desktop_assignment_type", value);
    }

    /// <summary>
    /// Preferred App Group type to display
    /// </summary>
    public TerraformValue<string>? PreferredAppGroupType
    {
        get => GetArgument<TerraformValue<string>>("preferred_app_group_type");
        set => SetArgument("preferred_app_group_type", value);
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public TerraformValue<string>? PublicNetworkAccess
    {
        get => GetArgument<TerraformValue<string>>("public_network_access");
        set => SetArgument("public_network_access", value);
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
    /// The start_vm_on_connect attribute.
    /// </summary>
    public TerraformValue<bool>? StartVmOnConnect
    {
        get => GetArgument<TerraformValue<bool>>("start_vm_on_connect");
        set => SetArgument("start_vm_on_connect", value);
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The validate_environment attribute.
    /// </summary>
    public TerraformValue<bool>? ValidateEnvironment
    {
        get => GetArgument<TerraformValue<bool>>("validate_environment");
        set => SetArgument("validate_environment", value);
    }

    /// <summary>
    /// The vm_template attribute.
    /// </summary>
    public TerraformValue<string>? VmTemplate
    {
        get => GetArgument<TerraformValue<string>>("vm_template");
        set => SetArgument("vm_template", value);
    }

    /// <summary>
    /// ScheduledAgentUpdates block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduledAgentUpdates block(s) allowed")]
    public TerraformList<AzurermVirtualDesktopHostPoolScheduledAgentUpdatesBlock>? ScheduledAgentUpdates
    {
        get => GetArgument<TerraformList<AzurermVirtualDesktopHostPoolScheduledAgentUpdatesBlock>>("scheduled_agent_updates");
        set => SetArgument("scheduled_agent_updates", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualDesktopHostPoolTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualDesktopHostPoolTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
