using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for scheduled_agent_updates in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualDesktopHostPoolScheduledAgentUpdatesBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformProperty<string>? Timezone
    {
        get => GetProperty<TerraformProperty<string>>("timezone");
        set => WithProperty("timezone", value);
    }

    /// <summary>
    /// The use_session_host_timezone attribute.
    /// </summary>
    public TerraformProperty<bool>? UseSessionHostTimezone
    {
        get => GetProperty<TerraformProperty<bool>>("use_session_host_timezone");
        set => WithProperty("use_session_host_timezone", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualDesktopHostPoolTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The custom_rdp_properties attribute.
    /// </summary>
    public TerraformProperty<string>? CustomRdpProperties
    {
        get => GetProperty<TerraformProperty<string>>("custom_rdp_properties");
        set => this.WithProperty("custom_rdp_properties", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public TerraformProperty<string>? FriendlyName
    {
        get => GetProperty<TerraformProperty<string>>("friendly_name");
        set => this.WithProperty("friendly_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerType is required")]
    public required TerraformProperty<string> LoadBalancerType
    {
        get => GetProperty<TerraformProperty<string>>("load_balancer_type");
        set => this.WithProperty("load_balancer_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The maximum_sessions_allowed attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumSessionsAllowed
    {
        get => GetProperty<TerraformProperty<double>>("maximum_sessions_allowed");
        set => this.WithProperty("maximum_sessions_allowed", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The personal_desktop_assignment_type attribute.
    /// </summary>
    public TerraformProperty<string>? PersonalDesktopAssignmentType
    {
        get => GetProperty<TerraformProperty<string>>("personal_desktop_assignment_type");
        set => this.WithProperty("personal_desktop_assignment_type", value);
    }

    /// <summary>
    /// Preferred App Group type to display
    /// </summary>
    public TerraformProperty<string>? PreferredAppGroupType
    {
        get => GetProperty<TerraformProperty<string>>("preferred_app_group_type");
        set => this.WithProperty("preferred_app_group_type", value);
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public TerraformProperty<string>? PublicNetworkAccess
    {
        get => GetProperty<TerraformProperty<string>>("public_network_access");
        set => this.WithProperty("public_network_access", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The start_vm_on_connect attribute.
    /// </summary>
    public TerraformProperty<bool>? StartVmOnConnect
    {
        get => GetProperty<TerraformProperty<bool>>("start_vm_on_connect");
        set => this.WithProperty("start_vm_on_connect", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The validate_environment attribute.
    /// </summary>
    public TerraformProperty<bool>? ValidateEnvironment
    {
        get => GetProperty<TerraformProperty<bool>>("validate_environment");
        set => this.WithProperty("validate_environment", value);
    }

    /// <summary>
    /// The vm_template attribute.
    /// </summary>
    public TerraformProperty<string>? VmTemplate
    {
        get => GetProperty<TerraformProperty<string>>("vm_template");
        set => this.WithProperty("vm_template", value);
    }

    /// <summary>
    /// Block for scheduled_agent_updates.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduledAgentUpdates block(s) allowed")]
    public List<AzurermVirtualDesktopHostPoolScheduledAgentUpdatesBlock>? ScheduledAgentUpdates
    {
        get => GetProperty<List<AzurermVirtualDesktopHostPoolScheduledAgentUpdatesBlock>>("scheduled_agent_updates");
        set => this.WithProperty("scheduled_agent_updates", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualDesktopHostPoolTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVirtualDesktopHostPoolTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
