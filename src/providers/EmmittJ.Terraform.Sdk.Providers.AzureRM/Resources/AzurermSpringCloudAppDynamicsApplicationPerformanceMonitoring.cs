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
        SetOutput("agent_account_access_key");
        SetOutput("agent_account_name");
        SetOutput("agent_application_name");
        SetOutput("agent_node_name");
        SetOutput("agent_tier_name");
        SetOutput("agent_unique_host_id");
        SetOutput("controller_host_name");
        SetOutput("controller_port");
        SetOutput("controller_ssl_enabled");
        SetOutput("globally_enabled");
        SetOutput("id");
        SetOutput("name");
        SetOutput("spring_cloud_service_id");
    }

    /// <summary>
    /// The agent_account_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentAccountAccessKey is required")]
    public required TerraformProperty<string> AgentAccountAccessKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("agent_account_access_key");
        set => SetProperty("agent_account_access_key", value);
    }

    /// <summary>
    /// The agent_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentAccountName is required")]
    public required TerraformProperty<string> AgentAccountName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("agent_account_name");
        set => SetProperty("agent_account_name", value);
    }

    /// <summary>
    /// The agent_application_name attribute.
    /// </summary>
    public TerraformProperty<string> AgentApplicationName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("agent_application_name");
        set => SetProperty("agent_application_name", value);
    }

    /// <summary>
    /// The agent_node_name attribute.
    /// </summary>
    public TerraformProperty<string> AgentNodeName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("agent_node_name");
        set => SetProperty("agent_node_name", value);
    }

    /// <summary>
    /// The agent_tier_name attribute.
    /// </summary>
    public TerraformProperty<string> AgentTierName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("agent_tier_name");
        set => SetProperty("agent_tier_name", value);
    }

    /// <summary>
    /// The agent_unique_host_id attribute.
    /// </summary>
    public TerraformProperty<string> AgentUniqueHostId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("agent_unique_host_id");
        set => SetProperty("agent_unique_host_id", value);
    }

    /// <summary>
    /// The controller_host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControllerHostName is required")]
    public required TerraformProperty<string> ControllerHostName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("controller_host_name");
        set => SetProperty("controller_host_name", value);
    }

    /// <summary>
    /// The controller_port attribute.
    /// </summary>
    public TerraformProperty<double> ControllerPort
    {
        get => GetRequiredOutput<TerraformProperty<double>>("controller_port");
        set => SetProperty("controller_port", value);
    }

    /// <summary>
    /// The controller_ssl_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ControllerSslEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("controller_ssl_enabled");
        set => SetProperty("controller_ssl_enabled", value);
    }

    /// <summary>
    /// The globally_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> GloballyEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("globally_enabled");
        set => SetProperty("globally_enabled", value);
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
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    public required TerraformProperty<string> SpringCloudServiceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("spring_cloud_service_id");
        set => SetProperty("spring_cloud_service_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudAppDynamicsApplicationPerformanceMonitoringTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
