using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for host_pool in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualDesktopScalingPlanHostPoolBlock() : TerraformBlock("host_pool")
{
    /// <summary>
    /// The hostpool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostpoolId is required")]
    [TerraformProperty("hostpool_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HostpoolId { get; set; }

    /// <summary>
    /// The scaling_plan_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingPlanEnabled is required")]
    [TerraformProperty("scaling_plan_enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> ScalingPlanEnabled { get; set; }

}

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualDesktopScalingPlanScheduleBlock() : TerraformBlock("schedule")
{
    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DaysOfWeek is required")]
    [TerraformProperty("days_of_week")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> DaysOfWeek { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The off_peak_load_balancing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OffPeakLoadBalancingAlgorithm is required")]
    [TerraformProperty("off_peak_load_balancing_algorithm")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OffPeakLoadBalancingAlgorithm { get; set; }

    /// <summary>
    /// The off_peak_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OffPeakStartTime is required")]
    [TerraformProperty("off_peak_start_time")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OffPeakStartTime { get; set; }

    /// <summary>
    /// The peak_load_balancing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeakLoadBalancingAlgorithm is required")]
    [TerraformProperty("peak_load_balancing_algorithm")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PeakLoadBalancingAlgorithm { get; set; }

    /// <summary>
    /// The peak_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeakStartTime is required")]
    [TerraformProperty("peak_start_time")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PeakStartTime { get; set; }

    /// <summary>
    /// The ramp_down_capacity_threshold_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownCapacityThresholdPercent is required")]
    [TerraformProperty("ramp_down_capacity_threshold_percent")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> RampDownCapacityThresholdPercent { get; set; }

    /// <summary>
    /// The ramp_down_force_logoff_users attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownForceLogoffUsers is required")]
    [TerraformProperty("ramp_down_force_logoff_users")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> RampDownForceLogoffUsers { get; set; }

    /// <summary>
    /// The ramp_down_load_balancing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownLoadBalancingAlgorithm is required")]
    [TerraformProperty("ramp_down_load_balancing_algorithm")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RampDownLoadBalancingAlgorithm { get; set; }

    /// <summary>
    /// The ramp_down_minimum_hosts_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownMinimumHostsPercent is required")]
    [TerraformProperty("ramp_down_minimum_hosts_percent")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> RampDownMinimumHostsPercent { get; set; }

    /// <summary>
    /// The ramp_down_notification_message attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownNotificationMessage is required")]
    [TerraformProperty("ramp_down_notification_message")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RampDownNotificationMessage { get; set; }

    /// <summary>
    /// The ramp_down_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownStartTime is required")]
    [TerraformProperty("ramp_down_start_time")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RampDownStartTime { get; set; }

    /// <summary>
    /// The ramp_down_stop_hosts_when attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownStopHostsWhen is required")]
    [TerraformProperty("ramp_down_stop_hosts_when")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RampDownStopHostsWhen { get; set; }

    /// <summary>
    /// The ramp_down_wait_time_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownWaitTimeMinutes is required")]
    [TerraformProperty("ramp_down_wait_time_minutes")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> RampDownWaitTimeMinutes { get; set; }

    /// <summary>
    /// The ramp_up_capacity_threshold_percent attribute.
    /// </summary>
    [TerraformProperty("ramp_up_capacity_threshold_percent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RampUpCapacityThresholdPercent { get; set; }

    /// <summary>
    /// The ramp_up_load_balancing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampUpLoadBalancingAlgorithm is required")]
    [TerraformProperty("ramp_up_load_balancing_algorithm")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RampUpLoadBalancingAlgorithm { get; set; }

    /// <summary>
    /// The ramp_up_minimum_hosts_percent attribute.
    /// </summary>
    [TerraformProperty("ramp_up_minimum_hosts_percent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RampUpMinimumHostsPercent { get; set; }

    /// <summary>
    /// The ramp_up_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampUpStartTime is required")]
    [TerraformProperty("ramp_up_start_time")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RampUpStartTime { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualDesktopScalingPlanTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_virtual_desktop_scaling_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermVirtualDesktopScalingPlan : TerraformResource
{
    public AzurermVirtualDesktopScalingPlan(string name) : base("azurerm_virtual_desktop_scaling_plan", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The exclusion_tag attribute.
    /// </summary>
    [TerraformProperty("exclusion_tag")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExclusionTag { get; set; }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    [TerraformProperty("friendly_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FriendlyName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    [TerraformProperty("time_zone")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TimeZone { get; set; }

    /// <summary>
    /// Block for host_pool.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("host_pool")]
    public TerraformList<AzurermVirtualDesktopScalingPlanHostPoolBlock> HostPool { get; set; } = new();

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    [TerraformProperty("schedule")]
    public required TerraformList<AzurermVirtualDesktopScalingPlanScheduleBlock> Schedule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermVirtualDesktopScalingPlanTimeoutsBlock Timeouts { get; set; } = new();

}
