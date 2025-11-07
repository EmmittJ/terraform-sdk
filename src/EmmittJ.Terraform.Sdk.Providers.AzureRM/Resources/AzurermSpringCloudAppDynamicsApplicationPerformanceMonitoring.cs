using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformProperty<string>? AgentAccountAccessKey
    {
        get => GetProperty<TerraformProperty<string>>("agent_account_access_key");
        set => this.WithProperty("agent_account_access_key", value);
    }

    /// <summary>
    /// The agent_account_name attribute.
    /// </summary>
    public TerraformProperty<string>? AgentAccountName
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
    public TerraformProperty<string>? ControllerHostName
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    public TerraformProperty<string>? SpringCloudServiceId
    {
        get => GetProperty<TerraformProperty<string>>("spring_cloud_service_id");
        set => this.WithProperty("spring_cloud_service_id", value);
    }

}
