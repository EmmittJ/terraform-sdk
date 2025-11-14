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
/// Block type for host_pool in .
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
    [TerraformArgument("hostpool_id")]
    public required TerraformValue<string> HostpoolId
    {
        get => new TerraformReference<string>(this, "hostpool_id");
        set => SetArgument("hostpool_id", value);
    }

    /// <summary>
    /// The scaling_plan_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingPlanEnabled is required")]
    [TerraformArgument("scaling_plan_enabled")]
    public required TerraformValue<bool> ScalingPlanEnabled
    {
        get => new TerraformReference<bool>(this, "scaling_plan_enabled");
        set => SetArgument("scaling_plan_enabled", value);
    }

}

/// <summary>
/// Block type for schedule in .
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
    [TerraformArgument("days_of_week")]
    public required TerraformSet<string> DaysOfWeek
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "days_of_week").ResolveNodes(ctx));
        set => SetArgument("days_of_week", value);
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
    /// The off_peak_load_balancing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OffPeakLoadBalancingAlgorithm is required")]
    [TerraformArgument("off_peak_load_balancing_algorithm")]
    public required TerraformValue<string> OffPeakLoadBalancingAlgorithm
    {
        get => new TerraformReference<string>(this, "off_peak_load_balancing_algorithm");
        set => SetArgument("off_peak_load_balancing_algorithm", value);
    }

    /// <summary>
    /// The off_peak_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OffPeakStartTime is required")]
    [TerraformArgument("off_peak_start_time")]
    public required TerraformValue<string> OffPeakStartTime
    {
        get => new TerraformReference<string>(this, "off_peak_start_time");
        set => SetArgument("off_peak_start_time", value);
    }

    /// <summary>
    /// The peak_load_balancing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeakLoadBalancingAlgorithm is required")]
    [TerraformArgument("peak_load_balancing_algorithm")]
    public required TerraformValue<string> PeakLoadBalancingAlgorithm
    {
        get => new TerraformReference<string>(this, "peak_load_balancing_algorithm");
        set => SetArgument("peak_load_balancing_algorithm", value);
    }

    /// <summary>
    /// The peak_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeakStartTime is required")]
    [TerraformArgument("peak_start_time")]
    public required TerraformValue<string> PeakStartTime
    {
        get => new TerraformReference<string>(this, "peak_start_time");
        set => SetArgument("peak_start_time", value);
    }

    /// <summary>
    /// The ramp_down_capacity_threshold_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownCapacityThresholdPercent is required")]
    [TerraformArgument("ramp_down_capacity_threshold_percent")]
    public required TerraformValue<double> RampDownCapacityThresholdPercent
    {
        get => new TerraformReference<double>(this, "ramp_down_capacity_threshold_percent");
        set => SetArgument("ramp_down_capacity_threshold_percent", value);
    }

    /// <summary>
    /// The ramp_down_force_logoff_users attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownForceLogoffUsers is required")]
    [TerraformArgument("ramp_down_force_logoff_users")]
    public required TerraformValue<bool> RampDownForceLogoffUsers
    {
        get => new TerraformReference<bool>(this, "ramp_down_force_logoff_users");
        set => SetArgument("ramp_down_force_logoff_users", value);
    }

    /// <summary>
    /// The ramp_down_load_balancing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownLoadBalancingAlgorithm is required")]
    [TerraformArgument("ramp_down_load_balancing_algorithm")]
    public required TerraformValue<string> RampDownLoadBalancingAlgorithm
    {
        get => new TerraformReference<string>(this, "ramp_down_load_balancing_algorithm");
        set => SetArgument("ramp_down_load_balancing_algorithm", value);
    }

    /// <summary>
    /// The ramp_down_minimum_hosts_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownMinimumHostsPercent is required")]
    [TerraformArgument("ramp_down_minimum_hosts_percent")]
    public required TerraformValue<double> RampDownMinimumHostsPercent
    {
        get => new TerraformReference<double>(this, "ramp_down_minimum_hosts_percent");
        set => SetArgument("ramp_down_minimum_hosts_percent", value);
    }

    /// <summary>
    /// The ramp_down_notification_message attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownNotificationMessage is required")]
    [TerraformArgument("ramp_down_notification_message")]
    public required TerraformValue<string> RampDownNotificationMessage
    {
        get => new TerraformReference<string>(this, "ramp_down_notification_message");
        set => SetArgument("ramp_down_notification_message", value);
    }

    /// <summary>
    /// The ramp_down_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownStartTime is required")]
    [TerraformArgument("ramp_down_start_time")]
    public required TerraformValue<string> RampDownStartTime
    {
        get => new TerraformReference<string>(this, "ramp_down_start_time");
        set => SetArgument("ramp_down_start_time", value);
    }

    /// <summary>
    /// The ramp_down_stop_hosts_when attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownStopHostsWhen is required")]
    [TerraformArgument("ramp_down_stop_hosts_when")]
    public required TerraformValue<string> RampDownStopHostsWhen
    {
        get => new TerraformReference<string>(this, "ramp_down_stop_hosts_when");
        set => SetArgument("ramp_down_stop_hosts_when", value);
    }

    /// <summary>
    /// The ramp_down_wait_time_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownWaitTimeMinutes is required")]
    [TerraformArgument("ramp_down_wait_time_minutes")]
    public required TerraformValue<double> RampDownWaitTimeMinutes
    {
        get => new TerraformReference<double>(this, "ramp_down_wait_time_minutes");
        set => SetArgument("ramp_down_wait_time_minutes", value);
    }

    /// <summary>
    /// The ramp_up_capacity_threshold_percent attribute.
    /// </summary>
    [TerraformArgument("ramp_up_capacity_threshold_percent")]
    public TerraformValue<double>? RampUpCapacityThresholdPercent
    {
        get => new TerraformReference<double>(this, "ramp_up_capacity_threshold_percent");
        set => SetArgument("ramp_up_capacity_threshold_percent", value);
    }

    /// <summary>
    /// The ramp_up_load_balancing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampUpLoadBalancingAlgorithm is required")]
    [TerraformArgument("ramp_up_load_balancing_algorithm")]
    public required TerraformValue<string> RampUpLoadBalancingAlgorithm
    {
        get => new TerraformReference<string>(this, "ramp_up_load_balancing_algorithm");
        set => SetArgument("ramp_up_load_balancing_algorithm", value);
    }

    /// <summary>
    /// The ramp_up_minimum_hosts_percent attribute.
    /// </summary>
    [TerraformArgument("ramp_up_minimum_hosts_percent")]
    public TerraformValue<double>? RampUpMinimumHostsPercent
    {
        get => new TerraformReference<double>(this, "ramp_up_minimum_hosts_percent");
        set => SetArgument("ramp_up_minimum_hosts_percent", value);
    }

    /// <summary>
    /// The ramp_up_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampUpStartTime is required")]
    [TerraformArgument("ramp_up_start_time")]
    public required TerraformValue<string> RampUpStartTime
    {
        get => new TerraformReference<string>(this, "ramp_up_start_time");
        set => SetArgument("ramp_up_start_time", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
/// Manages a azurerm_virtual_desktop_scaling_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermVirtualDesktopScalingPlan : TerraformResource
{
    public AzurermVirtualDesktopScalingPlan(string name) : base("azurerm_virtual_desktop_scaling_plan", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The exclusion_tag attribute.
    /// </summary>
    [TerraformArgument("exclusion_tag")]
    public TerraformValue<string>? ExclusionTag
    {
        get => new TerraformReference<string>(this, "exclusion_tag");
        set => SetArgument("exclusion_tag", value);
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    [TerraformArgument("friendly_name")]
    public TerraformValue<string>? FriendlyName
    {
        get => new TerraformReference<string>(this, "friendly_name");
        set => SetArgument("friendly_name", value);
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
    /// The time_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    [TerraformArgument("time_zone")]
    public required TerraformValue<string> TimeZone
    {
        get => new TerraformReference<string>(this, "time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// Block for host_pool.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("host_pool")]
    public TerraformList<AzurermVirtualDesktopScalingPlanHostPoolBlock> HostPool { get; set; } = new();

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    [TerraformArgument("schedule")]
    public required TerraformList<AzurermVirtualDesktopScalingPlanScheduleBlock> Schedule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermVirtualDesktopScalingPlanTimeoutsBlock Timeouts { get; set; } = new();

}
