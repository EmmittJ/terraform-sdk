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
    public TerraformLiteralProperty<string>? AgentAccountAccessKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_account_access_key");
        set => this.WithProperty("agent_account_access_key", value);
    }

    /// <summary>
    /// The agent_account_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AgentAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_account_name");
        set => this.WithProperty("agent_account_name", value);
    }

    /// <summary>
    /// The agent_application_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AgentApplicationName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_application_name");
        set => this.WithProperty("agent_application_name", value);
    }

    /// <summary>
    /// The agent_node_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AgentNodeName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_node_name");
        set => this.WithProperty("agent_node_name", value);
    }

    /// <summary>
    /// The agent_tier_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AgentTierName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_tier_name");
        set => this.WithProperty("agent_tier_name", value);
    }

    /// <summary>
    /// The agent_unique_host_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AgentUniqueHostId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_unique_host_id");
        set => this.WithProperty("agent_unique_host_id", value);
    }

    /// <summary>
    /// The controller_host_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ControllerHostName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("controller_host_name");
        set => this.WithProperty("controller_host_name", value);
    }

    /// <summary>
    /// The controller_port attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ControllerPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("controller_port");
        set => this.WithProperty("controller_port", value);
    }

    /// <summary>
    /// The controller_ssl_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ControllerSslEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("controller_ssl_enabled");
        set => this.WithProperty("controller_ssl_enabled", value);
    }

    /// <summary>
    /// The globally_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? GloballyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("globally_enabled");
        set => this.WithProperty("globally_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SpringCloudServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spring_cloud_service_id");
        set => this.WithProperty("spring_cloud_service_id", value);
    }

}
