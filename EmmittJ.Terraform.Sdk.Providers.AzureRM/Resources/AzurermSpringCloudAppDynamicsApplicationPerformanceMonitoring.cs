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
    public string? AgentAccountAccessKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_account_access_key")?.Value;
        set => this.WithProperty("agent_account_access_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The agent_account_name attribute.
    /// </summary>
    public string? AgentAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_account_name")?.Value;
        set => this.WithProperty("agent_account_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The agent_application_name attribute.
    /// </summary>
    public string? AgentApplicationName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_application_name")?.Value;
        set => this.WithProperty("agent_application_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The agent_node_name attribute.
    /// </summary>
    public string? AgentNodeName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_node_name")?.Value;
        set => this.WithProperty("agent_node_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The agent_tier_name attribute.
    /// </summary>
    public string? AgentTierName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_tier_name")?.Value;
        set => this.WithProperty("agent_tier_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The agent_unique_host_id attribute.
    /// </summary>
    public string? AgentUniqueHostId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_unique_host_id")?.Value;
        set => this.WithProperty("agent_unique_host_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The controller_host_name attribute.
    /// </summary>
    public string? ControllerHostName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("controller_host_name")?.Value;
        set => this.WithProperty("controller_host_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The controller_port attribute.
    /// </summary>
    public double? ControllerPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("controller_port")?.Value;
        set => this.WithProperty("controller_port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The controller_ssl_enabled attribute.
    /// </summary>
    public bool? ControllerSslEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("controller_ssl_enabled")?.Value;
        set => this.WithProperty("controller_ssl_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The globally_enabled attribute.
    /// </summary>
    public bool? GloballyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("globally_enabled")?.Value;
        set => this.WithProperty("globally_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The spring_cloud_service_id attribute.
    /// </summary>
    public string? SpringCloudServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spring_cloud_service_id")?.Value;
        set => this.WithProperty("spring_cloud_service_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
