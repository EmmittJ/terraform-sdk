using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for host_pool in AzurermVirtualDesktopScalingPlan.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualDesktopScalingPlanHostPoolBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "host_pool";

    /// <summary>
    /// The hostpool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostpoolId is required")]
    public required TerraformValue<string> HostpoolId
    {
        get => new TerraformReference<string>(this, "hostpool_id");
        set => SetArgument("hostpool_id", value);
    }

    /// <summary>
    /// The scaling_plan_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingPlanEnabled is required")]
    public required TerraformValue<bool> ScalingPlanEnabled
    {
        get => new TerraformReference<bool>(this, "scaling_plan_enabled");
        set => SetArgument("scaling_plan_enabled", value);
    }

}


/// <summary>
/// Block type for schedule in AzurermVirtualDesktopScalingPlan.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualDesktopScalingPlanScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule";

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DaysOfWeek is required")]
    public required TerraformSet<string> DaysOfWeek
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "days_of_week").ResolveNodes(ctx));
        set => SetArgument("days_of_week", value);
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
    /// The off_peak_load_balancing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OffPeakLoadBalancingAlgorithm is required")]
    public required TerraformValue<string> OffPeakLoadBalancingAlgorithm
    {
        get => new TerraformReference<string>(this, "off_peak_load_balancing_algorithm");
        set => SetArgument("off_peak_load_balancing_algorithm", value);
    }

    /// <summary>
    /// The off_peak_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OffPeakStartTime is required")]
    public required TerraformValue<string> OffPeakStartTime
    {
        get => new TerraformReference<string>(this, "off_peak_start_time");
        set => SetArgument("off_peak_start_time", value);
    }

    /// <summary>
    /// The peak_load_balancing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeakLoadBalancingAlgorithm is required")]
    public required TerraformValue<string> PeakLoadBalancingAlgorithm
    {
        get => new TerraformReference<string>(this, "peak_load_balancing_algorithm");
        set => SetArgument("peak_load_balancing_algorithm", value);
    }

    /// <summary>
    /// The peak_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeakStartTime is required")]
    public required TerraformValue<string> PeakStartTime
    {
        get => new TerraformReference<string>(this, "peak_start_time");
        set => SetArgument("peak_start_time", value);
    }

    /// <summary>
    /// The ramp_down_capacity_threshold_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownCapacityThresholdPercent is required")]
    public required TerraformValue<double> RampDownCapacityThresholdPercent
    {
        get => new TerraformReference<double>(this, "ramp_down_capacity_threshold_percent");
        set => SetArgument("ramp_down_capacity_threshold_percent", value);
    }

    /// <summary>
    /// The ramp_down_force_logoff_users attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownForceLogoffUsers is required")]
    public required TerraformValue<bool> RampDownForceLogoffUsers
    {
        get => new TerraformReference<bool>(this, "ramp_down_force_logoff_users");
        set => SetArgument("ramp_down_force_logoff_users", value);
    }

    /// <summary>
    /// The ramp_down_load_balancing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownLoadBalancingAlgorithm is required")]
    public required TerraformValue<string> RampDownLoadBalancingAlgorithm
    {
        get => new TerraformReference<string>(this, "ramp_down_load_balancing_algorithm");
        set => SetArgument("ramp_down_load_balancing_algorithm", value);
    }

    /// <summary>
    /// The ramp_down_minimum_hosts_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownMinimumHostsPercent is required")]
    public required TerraformValue<double> RampDownMinimumHostsPercent
    {
        get => new TerraformReference<double>(this, "ramp_down_minimum_hosts_percent");
        set => SetArgument("ramp_down_minimum_hosts_percent", value);
    }

    /// <summary>
    /// The ramp_down_notification_message attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownNotificationMessage is required")]
    public required TerraformValue<string> RampDownNotificationMessage
    {
        get => new TerraformReference<string>(this, "ramp_down_notification_message");
        set => SetArgument("ramp_down_notification_message", value);
    }

    /// <summary>
    /// The ramp_down_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownStartTime is required")]
    public required TerraformValue<string> RampDownStartTime
    {
        get => new TerraformReference<string>(this, "ramp_down_start_time");
        set => SetArgument("ramp_down_start_time", value);
    }

    /// <summary>
    /// The ramp_down_stop_hosts_when attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownStopHostsWhen is required")]
    public required TerraformValue<string> RampDownStopHostsWhen
    {
        get => new TerraformReference<string>(this, "ramp_down_stop_hosts_when");
        set => SetArgument("ramp_down_stop_hosts_when", value);
    }

    /// <summary>
    /// The ramp_down_wait_time_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownWaitTimeMinutes is required")]
    public required TerraformValue<double> RampDownWaitTimeMinutes
    {
        get => new TerraformReference<double>(this, "ramp_down_wait_time_minutes");
        set => SetArgument("ramp_down_wait_time_minutes", value);
    }

    /// <summary>
    /// The ramp_up_capacity_threshold_percent attribute.
    /// </summary>
    public TerraformValue<double>? RampUpCapacityThresholdPercent
    {
        get => new TerraformReference<double>(this, "ramp_up_capacity_threshold_percent");
        set => SetArgument("ramp_up_capacity_threshold_percent", value);
    }

    /// <summary>
    /// The ramp_up_load_balancing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampUpLoadBalancingAlgorithm is required")]
    public required TerraformValue<string> RampUpLoadBalancingAlgorithm
    {
        get => new TerraformReference<string>(this, "ramp_up_load_balancing_algorithm");
        set => SetArgument("ramp_up_load_balancing_algorithm", value);
    }

    /// <summary>
    /// The ramp_up_minimum_hosts_percent attribute.
    /// </summary>
    public TerraformValue<double>? RampUpMinimumHostsPercent
    {
        get => new TerraformReference<double>(this, "ramp_up_minimum_hosts_percent");
        set => SetArgument("ramp_up_minimum_hosts_percent", value);
    }

    /// <summary>
    /// The ramp_up_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampUpStartTime is required")]
    public required TerraformValue<string> RampUpStartTime
    {
        get => new TerraformReference<string>(this, "ramp_up_start_time");
        set => SetArgument("ramp_up_start_time", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermVirtualDesktopScalingPlan.
/// Nesting mode: single
/// </summary>
public class AzurermVirtualDesktopScalingPlanTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_virtual_desktop_scaling_plan Terraform resource.
/// Manages a azurerm_virtual_desktop_scaling_plan resource.
/// </summary>
public partial class AzurermVirtualDesktopScalingPlan(string name) : TerraformResource("azurerm_virtual_desktop_scaling_plan", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The exclusion_tag attribute.
    /// </summary>
    public TerraformValue<string>? ExclusionTag
    {
        get => new TerraformReference<string>(this, "exclusion_tag");
        set => SetArgument("exclusion_tag", value);
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public TerraformValue<string>? FriendlyName
    {
        get => new TerraformReference<string>(this, "friendly_name");
        set => SetArgument("friendly_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The time_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    public required TerraformValue<string> TimeZone
    {
        get => new TerraformReference<string>(this, "time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// HostPool block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermVirtualDesktopScalingPlanHostPoolBlock>? HostPool
    {
        get => GetArgument<TerraformList<AzurermVirtualDesktopScalingPlanHostPoolBlock>>("host_pool");
        set => SetArgument("host_pool", value);
    }

    /// <summary>
    /// Schedule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    public required TerraformList<AzurermVirtualDesktopScalingPlanScheduleBlock> Schedule
    {
        get => GetRequiredArgument<TerraformList<AzurermVirtualDesktopScalingPlanScheduleBlock>>("schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualDesktopScalingPlanTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualDesktopScalingPlanTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
