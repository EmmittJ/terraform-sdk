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
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformProperty<string>? Timezone
    {
        set => SetProperty("timezone", value);
    }

    /// <summary>
    /// The use_session_host_timezone attribute.
    /// </summary>
    public TerraformProperty<bool>? UseSessionHostTimezone
    {
        set => SetProperty("use_session_host_timezone", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("custom_rdp_properties");
        SetOutput("description");
        SetOutput("friendly_name");
        SetOutput("id");
        SetOutput("load_balancer_type");
        SetOutput("location");
        SetOutput("maximum_sessions_allowed");
        SetOutput("name");
        SetOutput("personal_desktop_assignment_type");
        SetOutput("preferred_app_group_type");
        SetOutput("public_network_access");
        SetOutput("resource_group_name");
        SetOutput("start_vm_on_connect");
        SetOutput("tags");
        SetOutput("type");
        SetOutput("validate_environment");
        SetOutput("vm_template");
    }

    /// <summary>
    /// The custom_rdp_properties attribute.
    /// </summary>
    public TerraformProperty<string> CustomRdpProperties
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_rdp_properties");
        set => SetProperty("custom_rdp_properties", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public TerraformProperty<string> FriendlyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("friendly_name");
        set => SetProperty("friendly_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerType is required")]
    public required TerraformProperty<string> LoadBalancerType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("load_balancer_type");
        set => SetProperty("load_balancer_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The maximum_sessions_allowed attribute.
    /// </summary>
    public TerraformProperty<double> MaximumSessionsAllowed
    {
        get => GetRequiredOutput<TerraformProperty<double>>("maximum_sessions_allowed");
        set => SetProperty("maximum_sessions_allowed", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The personal_desktop_assignment_type attribute.
    /// </summary>
    public TerraformProperty<string> PersonalDesktopAssignmentType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("personal_desktop_assignment_type");
        set => SetProperty("personal_desktop_assignment_type", value);
    }

    /// <summary>
    /// Preferred App Group type to display
    /// </summary>
    public TerraformProperty<string> PreferredAppGroupType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("preferred_app_group_type");
        set => SetProperty("preferred_app_group_type", value);
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public TerraformProperty<string> PublicNetworkAccess
    {
        get => GetRequiredOutput<TerraformProperty<string>>("public_network_access");
        set => SetProperty("public_network_access", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The start_vm_on_connect attribute.
    /// </summary>
    public TerraformProperty<bool> StartVmOnConnect
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("start_vm_on_connect");
        set => SetProperty("start_vm_on_connect", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The validate_environment attribute.
    /// </summary>
    public TerraformProperty<bool> ValidateEnvironment
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("validate_environment");
        set => SetProperty("validate_environment", value);
    }

    /// <summary>
    /// The vm_template attribute.
    /// </summary>
    public TerraformProperty<string> VmTemplate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vm_template");
        set => SetProperty("vm_template", value);
    }

    /// <summary>
    /// Block for scheduled_agent_updates.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduledAgentUpdates block(s) allowed")]
    public List<AzurermVirtualDesktopHostPoolScheduledAgentUpdatesBlock>? ScheduledAgentUpdates
    {
        set => SetProperty("scheduled_agent_updates", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualDesktopHostPoolTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
