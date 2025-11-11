using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for host_pool in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualDesktopScalingPlanHostPoolBlock
{
    /// <summary>
    /// The hostpool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostpoolId is required")]
    [TerraformPropertyName("hostpool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HostpoolId { get; set; }

    /// <summary>
    /// The scaling_plan_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingPlanEnabled is required")]
    [TerraformPropertyName("scaling_plan_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> ScalingPlanEnabled { get; set; }

}

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualDesktopScalingPlanScheduleBlock
{
    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DaysOfWeek is required")]
    [TerraformPropertyName("days_of_week")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> DaysOfWeek { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The off_peak_load_balancing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OffPeakLoadBalancingAlgorithm is required")]
    [TerraformPropertyName("off_peak_load_balancing_algorithm")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> OffPeakLoadBalancingAlgorithm { get; set; }

    /// <summary>
    /// The off_peak_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OffPeakStartTime is required")]
    [TerraformPropertyName("off_peak_start_time")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> OffPeakStartTime { get; set; }

    /// <summary>
    /// The peak_load_balancing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeakLoadBalancingAlgorithm is required")]
    [TerraformPropertyName("peak_load_balancing_algorithm")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PeakLoadBalancingAlgorithm { get; set; }

    /// <summary>
    /// The peak_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeakStartTime is required")]
    [TerraformPropertyName("peak_start_time")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PeakStartTime { get; set; }

    /// <summary>
    /// The ramp_down_capacity_threshold_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownCapacityThresholdPercent is required")]
    [TerraformPropertyName("ramp_down_capacity_threshold_percent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> RampDownCapacityThresholdPercent { get; set; }

    /// <summary>
    /// The ramp_down_force_logoff_users attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownForceLogoffUsers is required")]
    [TerraformPropertyName("ramp_down_force_logoff_users")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> RampDownForceLogoffUsers { get; set; }

    /// <summary>
    /// The ramp_down_load_balancing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownLoadBalancingAlgorithm is required")]
    [TerraformPropertyName("ramp_down_load_balancing_algorithm")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RampDownLoadBalancingAlgorithm { get; set; }

    /// <summary>
    /// The ramp_down_minimum_hosts_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownMinimumHostsPercent is required")]
    [TerraformPropertyName("ramp_down_minimum_hosts_percent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> RampDownMinimumHostsPercent { get; set; }

    /// <summary>
    /// The ramp_down_notification_message attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownNotificationMessage is required")]
    [TerraformPropertyName("ramp_down_notification_message")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RampDownNotificationMessage { get; set; }

    /// <summary>
    /// The ramp_down_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownStartTime is required")]
    [TerraformPropertyName("ramp_down_start_time")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RampDownStartTime { get; set; }

    /// <summary>
    /// The ramp_down_stop_hosts_when attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownStopHostsWhen is required")]
    [TerraformPropertyName("ramp_down_stop_hosts_when")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RampDownStopHostsWhen { get; set; }

    /// <summary>
    /// The ramp_down_wait_time_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampDownWaitTimeMinutes is required")]
    [TerraformPropertyName("ramp_down_wait_time_minutes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> RampDownWaitTimeMinutes { get; set; }

    /// <summary>
    /// The ramp_up_capacity_threshold_percent attribute.
    /// </summary>
    [TerraformPropertyName("ramp_up_capacity_threshold_percent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RampUpCapacityThresholdPercent { get; set; }

    /// <summary>
    /// The ramp_up_load_balancing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampUpLoadBalancingAlgorithm is required")]
    [TerraformPropertyName("ramp_up_load_balancing_algorithm")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RampUpLoadBalancingAlgorithm { get; set; }

    /// <summary>
    /// The ramp_up_minimum_hosts_percent attribute.
    /// </summary>
    [TerraformPropertyName("ramp_up_minimum_hosts_percent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RampUpMinimumHostsPercent { get; set; }

    /// <summary>
    /// The ramp_up_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RampUpStartTime is required")]
    [TerraformPropertyName("ramp_up_start_time")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RampUpStartTime { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualDesktopScalingPlanTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The exclusion_tag attribute.
    /// </summary>
    [TerraformPropertyName("exclusion_tag")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExclusionTag { get; set; }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    [TerraformPropertyName("friendly_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FriendlyName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    [TerraformPropertyName("time_zone")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TimeZone { get; set; }

    /// <summary>
    /// Block for host_pool.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("host_pool")]
    public TerraformList<TerraformBlock<AzurermVirtualDesktopScalingPlanHostPoolBlock>>? HostPool { get; set; }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    [TerraformPropertyName("schedule")]
    public TerraformList<TerraformBlock<AzurermVirtualDesktopScalingPlanScheduleBlock>>? Schedule { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVirtualDesktopScalingPlanTimeoutsBlock>? Timeouts { get; set; }

}
