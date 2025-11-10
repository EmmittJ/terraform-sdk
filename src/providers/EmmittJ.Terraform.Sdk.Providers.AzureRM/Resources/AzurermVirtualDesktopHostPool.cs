using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for scheduled_agent_updates in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualDesktopHostPoolScheduledAgentUpdatesBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [TerraformPropertyName("timezone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Timezone { get; set; }

    /// <summary>
    /// The use_session_host_timezone attribute.
    /// </summary>
    [TerraformPropertyName("use_session_host_timezone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseSessionHostTimezone { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualDesktopHostPoolTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_virtual_desktop_host_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermVirtualDesktopHostPool : TerraformResource
{
    public AzurermVirtualDesktopHostPool(string name) : base("azurerm_virtual_desktop_host_pool", name)
    {
    }

    /// <summary>
    /// The custom_rdp_properties attribute.
    /// </summary>
    [TerraformPropertyName("custom_rdp_properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomRdpProperties { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    [TerraformPropertyName("friendly_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FriendlyName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerType is required")]
    [TerraformPropertyName("load_balancer_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LoadBalancerType { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The maximum_sessions_allowed attribute.
    /// </summary>
    [TerraformPropertyName("maximum_sessions_allowed")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaximumSessionsAllowed { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The personal_desktop_assignment_type attribute.
    /// </summary>
    [TerraformPropertyName("personal_desktop_assignment_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PersonalDesktopAssignmentType { get; set; }

    /// <summary>
    /// Preferred App Group type to display
    /// </summary>
    [TerraformPropertyName("preferred_app_group_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PreferredAppGroupType { get; set; }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PublicNetworkAccess { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The start_vm_on_connect attribute.
    /// </summary>
    [TerraformPropertyName("start_vm_on_connect")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? StartVmOnConnect { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// The validate_environment attribute.
    /// </summary>
    [TerraformPropertyName("validate_environment")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ValidateEnvironment { get; set; }

    /// <summary>
    /// The vm_template attribute.
    /// </summary>
    [TerraformPropertyName("vm_template")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VmTemplate { get; set; }

    /// <summary>
    /// Block for scheduled_agent_updates.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduledAgentUpdates block(s) allowed")]
    [TerraformPropertyName("scheduled_agent_updates")]
    public TerraformList<TerraformBlock<AzurermVirtualDesktopHostPoolScheduledAgentUpdatesBlock>>? ScheduledAgentUpdates { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVirtualDesktopHostPoolTimeoutsBlock>? Timeouts { get; set; } = new();

}
