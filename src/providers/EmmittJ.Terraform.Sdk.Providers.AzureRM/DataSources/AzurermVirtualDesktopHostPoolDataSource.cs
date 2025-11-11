using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualDesktopHostPoolDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_virtual_desktop_host_pool.
/// </summary>
public class AzurermVirtualDesktopHostPoolDataSource : TerraformDataSource
{
    public AzurermVirtualDesktopHostPoolDataSource(string name) : base("azurerm_virtual_desktop_host_pool", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVirtualDesktopHostPoolDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The custom_rdp_properties attribute.
    /// </summary>
    [TerraformPropertyName("custom_rdp_properties")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CustomRdpProperties => new TerraformReference(this, "custom_rdp_properties");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    [TerraformPropertyName("friendly_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FriendlyName => new TerraformReference(this, "friendly_name");

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    [TerraformPropertyName("load_balancer_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LoadBalancerType => new TerraformReference(this, "load_balancer_type");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The maximum_sessions_allowed attribute.
    /// </summary>
    [TerraformPropertyName("maximum_sessions_allowed")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaximumSessionsAllowed => new TerraformReference(this, "maximum_sessions_allowed");

    /// <summary>
    /// The personal_desktop_assignment_type attribute.
    /// </summary>
    [TerraformPropertyName("personal_desktop_assignment_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PersonalDesktopAssignmentType => new TerraformReference(this, "personal_desktop_assignment_type");

    /// <summary>
    /// The preferred_app_group_type attribute.
    /// </summary>
    [TerraformPropertyName("preferred_app_group_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PreferredAppGroupType => new TerraformReference(this, "preferred_app_group_type");

    /// <summary>
    /// The scheduled_agent_updates attribute.
    /// </summary>
    [TerraformPropertyName("scheduled_agent_updates")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ScheduledAgentUpdates => new TerraformReference(this, "scheduled_agent_updates");

    /// <summary>
    /// The start_vm_on_connect attribute.
    /// </summary>
    [TerraformPropertyName("start_vm_on_connect")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> StartVmOnConnect => new TerraformReference(this, "start_vm_on_connect");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Type => new TerraformReference(this, "type");

    /// <summary>
    /// The validate_environment attribute.
    /// </summary>
    [TerraformPropertyName("validate_environment")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ValidateEnvironment => new TerraformReference(this, "validate_environment");

}
