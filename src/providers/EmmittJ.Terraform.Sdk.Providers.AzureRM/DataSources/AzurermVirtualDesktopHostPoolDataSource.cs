using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualDesktopHostPoolDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVirtualDesktopHostPoolDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The custom_rdp_properties attribute.
    /// </summary>
    [TerraformPropertyName("custom_rdp_properties")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomRdpProperties => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "custom_rdp_properties");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    [TerraformPropertyName("friendly_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FriendlyName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "friendly_name");

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    [TerraformPropertyName("load_balancer_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LoadBalancerType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "load_balancer_type");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The maximum_sessions_allowed attribute.
    /// </summary>
    [TerraformPropertyName("maximum_sessions_allowed")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaximumSessionsAllowed => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "maximum_sessions_allowed");

    /// <summary>
    /// The personal_desktop_assignment_type attribute.
    /// </summary>
    [TerraformPropertyName("personal_desktop_assignment_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PersonalDesktopAssignmentType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "personal_desktop_assignment_type");

    /// <summary>
    /// The preferred_app_group_type attribute.
    /// </summary>
    [TerraformPropertyName("preferred_app_group_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PreferredAppGroupType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "preferred_app_group_type");

    /// <summary>
    /// The scheduled_agent_updates attribute.
    /// </summary>
    [TerraformPropertyName("scheduled_agent_updates")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ScheduledAgentUpdates => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "scheduled_agent_updates");

    /// <summary>
    /// The start_vm_on_connect attribute.
    /// </summary>
    [TerraformPropertyName("start_vm_on_connect")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> StartVmOnConnect => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "start_vm_on_connect");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

    /// <summary>
    /// The validate_environment attribute.
    /// </summary>
    [TerraformPropertyName("validate_environment")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ValidateEnvironment => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "validate_environment");

}
