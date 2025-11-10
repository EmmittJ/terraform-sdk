using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudAppDynamicsApplicationPerformanceMonitoringTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_spring_cloud_app_dynamics_application_performance_monitoring resource.
/// </summary>
public class AzurermSpringCloudAppDynamicsApplicationPerformanceMonitoring : TerraformResource
{
    public AzurermSpringCloudAppDynamicsApplicationPerformanceMonitoring(string name) : base("azurerm_spring_cloud_app_dynamics_application_performance_monitoring", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The agent_account_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentAccountAccessKey is required")]
    public required TerraformProperty<string> AgentAccountAccessKey
    {
        get => GetProperty<TerraformProperty<string>>("agent_account_access_key");
        set => this.WithProperty("agent_account_access_key", value);
    }

    /// <summary>
    /// The agent_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentAccountName is required")]
    public required TerraformProperty<string> AgentAccountName
    {
        get => GetProperty<TerraformProperty<string>>("agent_account_name");
        set => this.WithProperty("agent_account_name", value);
    }

    /// <summary>
    /// The agent_application_name attribute.
    /// </summary>
    public TerraformProperty<string>? AgentApplicationName
    {
        get => GetProperty<TerraformProperty<string>>("agent_application_name");
        set => this.WithProperty("agent_application_name", value);
    }

    /// <summary>
    /// The agent_node_name attribute.
    /// </summary>
    public TerraformProperty<string>? AgentNodeName
    {
        get => GetProperty<TerraformProperty<string>>("agent_node_name");
        set => this.WithProperty("agent_node_name", value);
    }

    /// <summary>
    /// The agent_tier_name attribute.
    /// </summary>
    public TerraformProperty<string>? AgentTierName
    {
        get => GetProperty<TerraformProperty<string>>("agent_tier_name");
        set => this.WithProperty("agent_tier_name", value);
    }

    /// <summary>
    /// The agent_unique_host_id attribute.
    /// </summary>
    public TerraformProperty<string>? AgentUniqueHostId
    {
        get => GetProperty<TerraformProperty<string>>("agent_unique_host_id");
        set => this.WithProperty("agent_unique_host_id", value);
    }

    /// <summary>
    /// The controller_host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControllerHostName is required")]
    public required TerraformProperty<string> ControllerHostName
    {
        get => GetProperty<TerraformProperty<string>>("controller_host_name");
        set => this.WithProperty("controller_host_name", value);
    }

    /// <summary>
    /// The controller_port attribute.
    /// </summary>
    public TerraformProperty<double>? ControllerPort
    {
        get => GetProperty<TerraformProperty<double>>("controller_port");
        set => this.WithProperty("controller_port", value);
    }

    /// <summary>
    /// The controller_ssl_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ControllerSslEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("controller_ssl_enabled");
        set => this.WithProperty("controller_ssl_enabled", value);
    }

    /// <summary>
    /// The globally_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? GloballyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("globally_enabled");
        set => this.WithProperty("globally_enabled", value);
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
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    public required TerraformProperty<string> SpringCloudServiceId
    {
        get => GetProperty<TerraformProperty<string>>("spring_cloud_service_id");
        set => this.WithProperty("spring_cloud_service_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudAppDynamicsApplicationPerformanceMonitoringTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSpringCloudAppDynamicsApplicationPerformanceMonitoringTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
