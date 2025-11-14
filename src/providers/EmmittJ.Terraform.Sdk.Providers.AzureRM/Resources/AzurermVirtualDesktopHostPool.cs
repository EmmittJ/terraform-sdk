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
/// Block type for scheduled_agent_updates in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualDesktopHostPoolScheduledAgentUpdatesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scheduled_agent_updates";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [TerraformArgument("timezone")]
    public TerraformValue<string>? Timezone
    {
        get => new TerraformReference<string>(this, "timezone");
        set => SetArgument("timezone", value);
    }

    /// <summary>
    /// The use_session_host_timezone attribute.
    /// </summary>
    [TerraformArgument("use_session_host_timezone")]
    public TerraformValue<bool>? UseSessionHostTimezone
    {
        get => new TerraformReference<bool>(this, "use_session_host_timezone");
        set => SetArgument("use_session_host_timezone", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualDesktopHostPoolTimeoutsBlock : TerraformBlock
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
    [TerraformArgument("custom_rdp_properties")]
    public TerraformValue<string>? CustomRdpProperties
    {
        get => new TerraformReference<string>(this, "custom_rdp_properties");
        set => SetArgument("custom_rdp_properties", value);
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
    /// The load_balancer_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerType is required")]
    [TerraformArgument("load_balancer_type")]
    public required TerraformValue<string> LoadBalancerType
    {
        get => new TerraformReference<string>(this, "load_balancer_type");
        set => SetArgument("load_balancer_type", value);
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
    /// The maximum_sessions_allowed attribute.
    /// </summary>
    [TerraformArgument("maximum_sessions_allowed")]
    public TerraformValue<double>? MaximumSessionsAllowed
    {
        get => new TerraformReference<double>(this, "maximum_sessions_allowed");
        set => SetArgument("maximum_sessions_allowed", value);
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
    /// The personal_desktop_assignment_type attribute.
    /// </summary>
    [TerraformArgument("personal_desktop_assignment_type")]
    public TerraformValue<string>? PersonalDesktopAssignmentType
    {
        get => new TerraformReference<string>(this, "personal_desktop_assignment_type");
        set => SetArgument("personal_desktop_assignment_type", value);
    }

    /// <summary>
    /// Preferred App Group type to display
    /// </summary>
    [TerraformArgument("preferred_app_group_type")]
    public TerraformValue<string>? PreferredAppGroupType
    {
        get => new TerraformReference<string>(this, "preferred_app_group_type");
        set => SetArgument("preferred_app_group_type", value);
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    [TerraformArgument("public_network_access")]
    public TerraformValue<string>? PublicNetworkAccess
    {
        get => new TerraformReference<string>(this, "public_network_access");
        set => SetArgument("public_network_access", value);
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
    /// The start_vm_on_connect attribute.
    /// </summary>
    [TerraformArgument("start_vm_on_connect")]
    public TerraformValue<bool>? StartVmOnConnect
    {
        get => new TerraformReference<bool>(this, "start_vm_on_connect");
        set => SetArgument("start_vm_on_connect", value);
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The validate_environment attribute.
    /// </summary>
    [TerraformArgument("validate_environment")]
    public TerraformValue<bool>? ValidateEnvironment
    {
        get => new TerraformReference<bool>(this, "validate_environment");
        set => SetArgument("validate_environment", value);
    }

    /// <summary>
    /// The vm_template attribute.
    /// </summary>
    [TerraformArgument("vm_template")]
    public TerraformValue<string>? VmTemplate
    {
        get => new TerraformReference<string>(this, "vm_template");
        set => SetArgument("vm_template", value);
    }

    /// <summary>
    /// Block for scheduled_agent_updates.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduledAgentUpdates block(s) allowed")]
    [TerraformArgument("scheduled_agent_updates")]
    public TerraformList<AzurermVirtualDesktopHostPoolScheduledAgentUpdatesBlock> ScheduledAgentUpdates { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermVirtualDesktopHostPoolTimeoutsBlock Timeouts { get; set; } = new();

}
