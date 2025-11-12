using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for scheduled_agent_updates in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualDesktopHostPoolScheduledAgentUpdatesBlock() : TerraformBlock("scheduled_agent_updates")
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [TerraformProperty("timezone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Timezone { get; set; }

    /// <summary>
    /// The use_session_host_timezone attribute.
    /// </summary>
    [TerraformProperty("use_session_host_timezone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UseSessionHostTimezone { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualDesktopHostPoolTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_virtual_desktop_host_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermVirtualDesktopHostPool : TerraformResource
{
    public AzurermVirtualDesktopHostPool(string name) : base("azurerm_virtual_desktop_host_pool", name)
    {
    }

    /// <summary>
    /// The custom_rdp_properties attribute.
    /// </summary>
    [TerraformProperty("custom_rdp_properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomRdpProperties { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

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
    /// The load_balancer_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerType is required")]
    [TerraformProperty("load_balancer_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LoadBalancerType { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The maximum_sessions_allowed attribute.
    /// </summary>
    [TerraformProperty("maximum_sessions_allowed")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaximumSessionsAllowed { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The personal_desktop_assignment_type attribute.
    /// </summary>
    [TerraformProperty("personal_desktop_assignment_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PersonalDesktopAssignmentType { get; set; }

    /// <summary>
    /// Preferred App Group type to display
    /// </summary>
    [TerraformProperty("preferred_app_group_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PreferredAppGroupType { get; set; }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    [TerraformProperty("public_network_access")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PublicNetworkAccess { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The start_vm_on_connect attribute.
    /// </summary>
    [TerraformProperty("start_vm_on_connect")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? StartVmOnConnect { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The validate_environment attribute.
    /// </summary>
    [TerraformProperty("validate_environment")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ValidateEnvironment { get; set; }

    /// <summary>
    /// The vm_template attribute.
    /// </summary>
    [TerraformProperty("vm_template")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VmTemplate { get; set; }

    /// <summary>
    /// Block for scheduled_agent_updates.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduledAgentUpdates block(s) allowed")]
    [TerraformProperty("scheduled_agent_updates")]
    public TerraformList<AzurermVirtualDesktopHostPoolScheduledAgentUpdatesBlock> ScheduledAgentUpdates { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermVirtualDesktopHostPoolTimeoutsBlock Timeouts { get; set; } = new();

}
