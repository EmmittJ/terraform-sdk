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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualDesktopHostPoolDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

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
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermVirtualDesktopHostPoolDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The custom_rdp_properties attribute.
    /// </summary>
    [TerraformArgument("custom_rdp_properties")]
    public TerraformValue<string> CustomRdpProperties
    {
        get => new TerraformReference<string>(this, "custom_rdp_properties");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    [TerraformArgument("friendly_name")]
    public TerraformValue<string> FriendlyName
    {
        get => new TerraformReference<string>(this, "friendly_name");
    }

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    [TerraformArgument("load_balancer_type")]
    public TerraformValue<string> LoadBalancerType
    {
        get => new TerraformReference<string>(this, "load_balancer_type");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The maximum_sessions_allowed attribute.
    /// </summary>
    [TerraformArgument("maximum_sessions_allowed")]
    public TerraformValue<double> MaximumSessionsAllowed
    {
        get => new TerraformReference<double>(this, "maximum_sessions_allowed");
    }

    /// <summary>
    /// The personal_desktop_assignment_type attribute.
    /// </summary>
    [TerraformArgument("personal_desktop_assignment_type")]
    public TerraformValue<string> PersonalDesktopAssignmentType
    {
        get => new TerraformReference<string>(this, "personal_desktop_assignment_type");
    }

    /// <summary>
    /// The preferred_app_group_type attribute.
    /// </summary>
    [TerraformArgument("preferred_app_group_type")]
    public TerraformValue<string> PreferredAppGroupType
    {
        get => new TerraformReference<string>(this, "preferred_app_group_type");
    }

    /// <summary>
    /// The scheduled_agent_updates attribute.
    /// </summary>
    [TerraformArgument("scheduled_agent_updates")]
    public TerraformList<object> ScheduledAgentUpdates
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "scheduled_agent_updates").ResolveNodes(ctx));
    }

    /// <summary>
    /// The start_vm_on_connect attribute.
    /// </summary>
    [TerraformArgument("start_vm_on_connect")]
    public TerraformValue<bool> StartVmOnConnect
    {
        get => new TerraformReference<bool>(this, "start_vm_on_connect");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformArgument("type")]
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

    /// <summary>
    /// The validate_environment attribute.
    /// </summary>
    [TerraformArgument("validate_environment")]
    public TerraformValue<bool> ValidateEnvironment
    {
        get => new TerraformReference<bool>(this, "validate_environment");
    }

}
