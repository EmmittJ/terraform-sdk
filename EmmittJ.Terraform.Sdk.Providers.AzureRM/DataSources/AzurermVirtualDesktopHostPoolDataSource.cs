using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("custom_rdp_properties");
        this.DeclareOutput("description");
        this.DeclareOutput("friendly_name");
        this.DeclareOutput("load_balancer_type");
        this.DeclareOutput("location");
        this.DeclareOutput("maximum_sessions_allowed");
        this.DeclareOutput("personal_desktop_assignment_type");
        this.DeclareOutput("preferred_app_group_type");
        this.DeclareOutput("scheduled_agent_updates");
        this.DeclareOutput("start_vm_on_connect");
        this.DeclareOutput("tags");
        this.DeclareOutput("type");
        this.DeclareOutput("validate_environment");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
