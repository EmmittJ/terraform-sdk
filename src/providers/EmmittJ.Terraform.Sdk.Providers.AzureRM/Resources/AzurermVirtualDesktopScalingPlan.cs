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
        set => SetProperty("hostpool_id", value);
    }

    /// <summary>
    /// The scaling_plan_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingPlanEnabled is required")]
    public required TerraformProperty<bool> ScalingPlanEnabled
    {
        set => SetProperty("scaling_plan_enabled", value);
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
        set => SetProperty("days_of_week", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The off_peak_load_balancing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OffPeakLoadBalancingAlgorithm is required")]
    public required TerraformProperty<string> OffPeakLoadBalancingAlgorithm
    {
        set => SetProperty("off_peak_load_balancing_algorithm", value);
    }

    /// <summary>
    /// The off_peak_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OffPeakStartTime is required")]
    public required TerraformProperty<string> OffPeakStartTime
    {
        set => SetProperty("off_peak_start_time", value);
    }

    /// <summary>
    /// The peak_load_balancing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeakLoadBalancingAlgorithm is required")]
    public required TerraformProperty<string> PeakLoadBalancingAlgorithm
    {
        set => SetProperty("peak_load_balancing_algorithm", value);
    }

    /// <summary>
    /// The peak_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeakStartTime is required")]
    public required TerraformProperty<string> PeakStartTime
    {
        set => SetProperty("peak_start_time", value);
    }

    /// <summary>
    /// The ramp_down_capacity_threshold_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownCapacityThresholdPercent is required")]
    public required TerraformProperty<double> RampDownCapacityThresholdPercent
    {
        set => SetProperty("ramp_down_capacity_threshold_percent", value);
    }

    /// <summary>
    /// The ramp_down_force_logoff_users attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownForceLogoffUsers is required")]
    public required TerraformProperty<bool> RampDownForceLogoffUsers
    {
        set => SetProperty("ramp_down_force_logoff_users", value);
    }

    /// <summary>
    /// The ramp_down_load_balancing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownLoadBalancingAlgorithm is required")]
    public required TerraformProperty<string> RampDownLoadBalancingAlgorithm
    {
        set => SetProperty("ramp_down_load_balancing_algorithm", value);
    }

    /// <summary>
    /// The ramp_down_minimum_hosts_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownMinimumHostsPercent is required")]
    public required TerraformProperty<double> RampDownMinimumHostsPercent
    {
        set => SetProperty("ramp_down_minimum_hosts_percent", value);
    }

    /// <summary>
    /// The ramp_down_notification_message attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownNotificationMessage is required")]
    public required TerraformProperty<string> RampDownNotificationMessage
    {
        set => SetProperty("ramp_down_notification_message", value);
    }

    /// <summary>
    /// The ramp_down_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownStartTime is required")]
    public required TerraformProperty<string> RampDownStartTime
    {
        set => SetProperty("ramp_down_start_time", value);
    }

    /// <summary>
    /// The ramp_down_stop_hosts_when attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownStopHostsWhen is required")]
    public required TerraformProperty<string> RampDownStopHostsWhen
    {
        set => SetProperty("ramp_down_stop_hosts_when", value);
    }

    /// <summary>
    /// The ramp_down_wait_time_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownWaitTimeMinutes is required")]
    public required TerraformProperty<double> RampDownWaitTimeMinutes
    {
        set => SetProperty("ramp_down_wait_time_minutes", value);
    }

    /// <summary>
    /// The ramp_up_capacity_threshold_percent attribute.
    /// </summary>
    public TerraformProperty<double>? RampUpCapacityThresholdPercent
    {
        set => SetProperty("ramp_up_capacity_threshold_percent", value);
    }

    /// <summary>
    /// The ramp_up_load_balancing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampUpLoadBalancingAlgorithm is required")]
    public required TerraformProperty<string> RampUpLoadBalancingAlgorithm
    {
        set => SetProperty("ramp_up_load_balancing_algorithm", value);
    }

    /// <summary>
    /// The ramp_up_minimum_hosts_percent attribute.
    /// </summary>
    public TerraformProperty<double>? RampUpMinimumHostsPercent
    {
        set => SetProperty("ramp_up_minimum_hosts_percent", value);
    }

    /// <summary>
    /// The ramp_up_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampUpStartTime is required")]
    public required TerraformProperty<string> RampUpStartTime
    {
        set => SetProperty("ramp_up_start_time", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("description");
        SetOutput("exclusion_tag");
        SetOutput("friendly_name");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("tags");
        SetOutput("time_zone");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The exclusion_tag attribute.
    /// </summary>
    public TerraformProperty<string> ExclusionTag
    {
        get => GetRequiredOutput<TerraformProperty<string>>("exclusion_tag");
        set => SetProperty("exclusion_tag", value);
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public TerraformProperty<string> FriendlyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("friendly_name");
        set => SetProperty("friendly_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    public required TerraformProperty<string> TimeZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("time_zone");
        set => SetProperty("time_zone", value);
    }

    /// <summary>
    /// Block for host_pool.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermVirtualDesktopScalingPlanHostPoolBlock>? HostPool
    {
        set => SetProperty("host_pool", value);
    }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    public List<AzurermVirtualDesktopScalingPlanScheduleBlock>? Schedule
    {
        set => SetProperty("schedule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualDesktopScalingPlanTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
