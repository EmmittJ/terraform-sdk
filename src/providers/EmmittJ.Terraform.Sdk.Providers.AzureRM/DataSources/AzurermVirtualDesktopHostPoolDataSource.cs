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
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
        this.WithOutput("custom_rdp_properties");
        this.WithOutput("description");
        this.WithOutput("friendly_name");
        this.WithOutput("load_balancer_type");
        this.WithOutput("location");
        this.WithOutput("maximum_sessions_allowed");
        this.WithOutput("personal_desktop_assignment_type");
        this.WithOutput("preferred_app_group_type");
        this.WithOutput("scheduled_agent_updates");
        this.WithOutput("start_vm_on_connect");
        this.WithOutput("tags");
        this.WithOutput("type");
        this.WithOutput("validate_environment");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualDesktopHostPoolDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVirtualDesktopHostPoolDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
