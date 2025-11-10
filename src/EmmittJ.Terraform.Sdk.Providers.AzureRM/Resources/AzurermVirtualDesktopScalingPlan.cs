using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for host_pool in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualDesktopScalingPlanHostPoolBlock : TerraformBlock
{
    /// <summary>
    /// The hostpool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostpoolId is required")]
    public required TerraformProperty<string> HostpoolId
    {
        get => GetProperty<TerraformProperty<string>>("hostpool_id");
        set => WithProperty("hostpool_id", value);
    }

    /// <summary>
    /// The scaling_plan_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingPlanEnabled is required")]
    public required TerraformProperty<bool> ScalingPlanEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("scaling_plan_enabled");
        set => WithProperty("scaling_plan_enabled", value);
    }

}

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualDesktopScalingPlanScheduleBlock : TerraformBlock
{
    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DaysOfWeek is required")]
    public HashSet<TerraformProperty<string>>? DaysOfWeek
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("days_of_week");
        set => WithProperty("days_of_week", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The off_peak_load_balancing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OffPeakLoadBalancingAlgorithm is required")]
    public required TerraformProperty<string> OffPeakLoadBalancingAlgorithm
    {
        get => GetProperty<TerraformProperty<string>>("off_peak_load_balancing_algorithm");
        set => WithProperty("off_peak_load_balancing_algorithm", value);
    }

    /// <summary>
    /// The off_peak_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OffPeakStartTime is required")]
    public required TerraformProperty<string> OffPeakStartTime
    {
        get => GetProperty<TerraformProperty<string>>("off_peak_start_time");
        set => WithProperty("off_peak_start_time", value);
    }

    /// <summary>
    /// The peak_load_balancing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeakLoadBalancingAlgorithm is required")]
    public required TerraformProperty<string> PeakLoadBalancingAlgorithm
    {
        get => GetProperty<TerraformProperty<string>>("peak_load_balancing_algorithm");
        set => WithProperty("peak_load_balancing_algorithm", value);
    }

    /// <summary>
    /// The peak_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeakStartTime is required")]
    public required TerraformProperty<string> PeakStartTime
    {
        get => GetProperty<TerraformProperty<string>>("peak_start_time");
        set => WithProperty("peak_start_time", value);
    }

    /// <summary>
    /// The ramp_down_capacity_threshold_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownCapacityThresholdPercent is required")]
    public required TerraformProperty<double> RampDownCapacityThresholdPercent
    {
        get => GetProperty<TerraformProperty<double>>("ramp_down_capacity_threshold_percent");
        set => WithProperty("ramp_down_capacity_threshold_percent", value);
    }

    /// <summary>
    /// The ramp_down_force_logoff_users attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownForceLogoffUsers is required")]
    public required TerraformProperty<bool> RampDownForceLogoffUsers
    {
        get => GetProperty<TerraformProperty<bool>>("ramp_down_force_logoff_users");
        set => WithProperty("ramp_down_force_logoff_users", value);
    }

    /// <summary>
    /// The ramp_down_load_balancing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownLoadBalancingAlgorithm is required")]
    public required TerraformProperty<string> RampDownLoadBalancingAlgorithm
    {
        get => GetProperty<TerraformProperty<string>>("ramp_down_load_balancing_algorithm");
        set => WithProperty("ramp_down_load_balancing_algorithm", value);
    }

    /// <summary>
    /// The ramp_down_minimum_hosts_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownMinimumHostsPercent is required")]
    public required TerraformProperty<double> RampDownMinimumHostsPercent
    {
        get => GetProperty<TerraformProperty<double>>("ramp_down_minimum_hosts_percent");
        set => WithProperty("ramp_down_minimum_hosts_percent", value);
    }

    /// <summary>
    /// The ramp_down_notification_message attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownNotificationMessage is required")]
    public required TerraformProperty<string> RampDownNotificationMessage
    {
        get => GetProperty<TerraformProperty<string>>("ramp_down_notification_message");
        set => WithProperty("ramp_down_notification_message", value);
    }

    /// <summary>
    /// The ramp_down_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownStartTime is required")]
    public required TerraformProperty<string> RampDownStartTime
    {
        get => GetProperty<TerraformProperty<string>>("ramp_down_start_time");
        set => WithProperty("ramp_down_start_time", value);
    }

    /// <summary>
    /// The ramp_down_stop_hosts_when attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownStopHostsWhen is required")]
    public required TerraformProperty<string> RampDownStopHostsWhen
    {
        get => GetProperty<TerraformProperty<string>>("ramp_down_stop_hosts_when");
        set => WithProperty("ramp_down_stop_hosts_when", value);
    }

    /// <summary>
    /// The ramp_down_wait_time_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownWaitTimeMinutes is required")]
    public required TerraformProperty<double> RampDownWaitTimeMinutes
    {
        get => GetProperty<TerraformProperty<double>>("ramp_down_wait_time_minutes");
        set => WithProperty("ramp_down_wait_time_minutes", value);
    }

    /// <summary>
    /// The ramp_up_capacity_threshold_percent attribute.
    /// </summary>
    public TerraformProperty<double>? RampUpCapacityThresholdPercent
    {
        get => GetProperty<TerraformProperty<double>>("ramp_up_capacity_threshold_percent");
        set => WithProperty("ramp_up_capacity_threshold_percent", value);
    }

    /// <summary>
    /// The ramp_up_load_balancing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampUpLoadBalancingAlgorithm is required")]
    public required TerraformProperty<string> RampUpLoadBalancingAlgorithm
    {
        get => GetProperty<TerraformProperty<string>>("ramp_up_load_balancing_algorithm");
        set => WithProperty("ramp_up_load_balancing_algorithm", value);
    }

    /// <summary>
    /// The ramp_up_minimum_hosts_percent attribute.
    /// </summary>
    public TerraformProperty<double>? RampUpMinimumHostsPercent
    {
        get => GetProperty<TerraformProperty<double>>("ramp_up_minimum_hosts_percent");
        set => WithProperty("ramp_up_minimum_hosts_percent", value);
    }

    /// <summary>
    /// The ramp_up_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampUpStartTime is required")]
    public required TerraformProperty<string> RampUpStartTime
    {
        get => GetProperty<TerraformProperty<string>>("ramp_up_start_time");
        set => WithProperty("ramp_up_start_time", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualDesktopScalingPlanTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_virtual_desktop_scaling_plan resource.
/// </summary>
public class AzurermVirtualDesktopScalingPlan : TerraformResource
{
    public AzurermVirtualDesktopScalingPlan(string name) : base("azurerm_virtual_desktop_scaling_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The exclusion_tag attribute.
    /// </summary>
    public TerraformProperty<string>? ExclusionTag
    {
        get => GetProperty<TerraformProperty<string>>("exclusion_tag");
        set => this.WithProperty("exclusion_tag", value);
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public TerraformProperty<string>? FriendlyName
    {
        get => GetProperty<TerraformProperty<string>>("friendly_name");
        set => this.WithProperty("friendly_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    public required TerraformProperty<string> TimeZone
    {
        get => GetProperty<TerraformProperty<string>>("time_zone");
        set => this.WithProperty("time_zone", value);
    }

    /// <summary>
    /// Block for host_pool.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermVirtualDesktopScalingPlanHostPoolBlock>? HostPool
    {
        get => GetProperty<List<AzurermVirtualDesktopScalingPlanHostPoolBlock>>("host_pool");
        set => this.WithProperty("host_pool", value);
    }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    public List<AzurermVirtualDesktopScalingPlanScheduleBlock>? Schedule
    {
        get => GetProperty<List<AzurermVirtualDesktopScalingPlanScheduleBlock>>("schedule");
        set => this.WithProperty("schedule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualDesktopScalingPlanTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVirtualDesktopScalingPlanTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
