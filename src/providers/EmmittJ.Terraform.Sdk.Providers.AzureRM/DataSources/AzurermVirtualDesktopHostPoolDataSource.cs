using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualDesktopHostPoolDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_virtual_desktop_host_pool.
/// </summary>
public partial class AzurermVirtualDesktopHostPoolDataSource : TerraformDataSource
{
    public AzurermVirtualDesktopHostPoolDataSource(string name) : base("azurerm_virtual_desktop_host_pool", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermVirtualDesktopHostPoolDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The custom_rdp_properties attribute.
    /// </summary>
    [TerraformProperty("custom_rdp_properties")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CustomRdpProperties { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    [TerraformProperty("friendly_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FriendlyName { get; }

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    [TerraformProperty("load_balancer_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LoadBalancerType { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The maximum_sessions_allowed attribute.
    /// </summary>
    [TerraformProperty("maximum_sessions_allowed")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaximumSessionsAllowed { get; }

    /// <summary>
    /// The personal_desktop_assignment_type attribute.
    /// </summary>
    [TerraformProperty("personal_desktop_assignment_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PersonalDesktopAssignmentType { get; }

    /// <summary>
    /// The preferred_app_group_type attribute.
    /// </summary>
    [TerraformProperty("preferred_app_group_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PreferredAppGroupType { get; }

    /// <summary>
    /// The scheduled_agent_updates attribute.
    /// </summary>
    [TerraformProperty("scheduled_agent_updates")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ScheduledAgentUpdates { get; }

    /// <summary>
    /// The start_vm_on_connect attribute.
    /// </summary>
    [TerraformProperty("start_vm_on_connect")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> StartVmOnConnect { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

    /// <summary>
    /// The validate_environment attribute.
    /// </summary>
    [TerraformProperty("validate_environment")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ValidateEnvironment { get; }

}
