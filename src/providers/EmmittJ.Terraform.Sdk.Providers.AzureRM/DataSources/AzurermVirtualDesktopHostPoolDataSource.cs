using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualDesktopHostPoolDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_virtual_desktop_host_pool.
/// </summary>
public class AzurermVirtualDesktopHostPoolDataSource : TerraformDataSource
{
    public AzurermVirtualDesktopHostPoolDataSource(string name) : base("azurerm_virtual_desktop_host_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("custom_rdp_properties");
        SetOutput("description");
        SetOutput("friendly_name");
        SetOutput("load_balancer_type");
        SetOutput("location");
        SetOutput("maximum_sessions_allowed");
        SetOutput("personal_desktop_assignment_type");
        SetOutput("preferred_app_group_type");
        SetOutput("scheduled_agent_updates");
        SetOutput("start_vm_on_connect");
        SetOutput("tags");
        SetOutput("type");
        SetOutput("validate_environment");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualDesktopHostPoolDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The custom_rdp_properties attribute.
    /// </summary>
    public TerraformExpression CustomRdpProperties => this["custom_rdp_properties"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public TerraformExpression FriendlyName => this["friendly_name"];

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    public TerraformExpression LoadBalancerType => this["load_balancer_type"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The maximum_sessions_allowed attribute.
    /// </summary>
    public TerraformExpression MaximumSessionsAllowed => this["maximum_sessions_allowed"];

    /// <summary>
    /// The personal_desktop_assignment_type attribute.
    /// </summary>
    public TerraformExpression PersonalDesktopAssignmentType => this["personal_desktop_assignment_type"];

    /// <summary>
    /// The preferred_app_group_type attribute.
    /// </summary>
    public TerraformExpression PreferredAppGroupType => this["preferred_app_group_type"];

    /// <summary>
    /// The scheduled_agent_updates attribute.
    /// </summary>
    public TerraformExpression ScheduledAgentUpdates => this["scheduled_agent_updates"];

    /// <summary>
    /// The start_vm_on_connect attribute.
    /// </summary>
    public TerraformExpression StartVmOnConnect => this["start_vm_on_connect"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

    /// <summary>
    /// The validate_environment attribute.
    /// </summary>
    public TerraformExpression ValidateEnvironment => this["validate_environment"];

}
