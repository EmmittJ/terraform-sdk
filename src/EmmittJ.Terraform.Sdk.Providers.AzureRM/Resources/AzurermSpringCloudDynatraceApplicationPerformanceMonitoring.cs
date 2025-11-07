using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_spring_cloud_dynatrace_application_performance_monitoring resource.
/// </summary>
public class AzurermSpringCloudDynatraceApplicationPerformanceMonitoring : TerraformResource
{
    public AzurermSpringCloudDynatraceApplicationPerformanceMonitoring(string name) : base("azurerm_spring_cloud_dynatrace_application_performance_monitoring", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_token attribute.
    /// </summary>
    public TerraformProperty<string>? ApiToken
    {
        get => GetProperty<TerraformProperty<string>>("api_token");
        set => this.WithProperty("api_token", value);
    }

    /// <summary>
    /// The api_url attribute.
    /// </summary>
    public TerraformProperty<string>? ApiUrl
    {
        get => GetProperty<TerraformProperty<string>>("api_url");
        set => this.WithProperty("api_url", value);
    }

    /// <summary>
    /// The connection_point attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionPoint
    {
        get => GetProperty<TerraformProperty<string>>("connection_point");
        set => this.WithProperty("connection_point", value);
    }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    public TerraformProperty<string>? EnvironmentId
    {
        get => GetProperty<TerraformProperty<string>>("environment_id");
        set => this.WithProperty("environment_id", value);
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

    /// <summary>
    /// The tenant attribute.
    /// </summary>
    public TerraformProperty<string>? Tenant
    {
        get => GetProperty<TerraformProperty<string>>("tenant");
        set => this.WithProperty("tenant", value);
    }

    /// <summary>
    /// The tenant_token attribute.
    /// </summary>
    public TerraformProperty<string>? TenantToken
    {
        get => GetProperty<TerraformProperty<string>>("tenant_token");
        set => this.WithProperty("tenant_token", value);
    }

}
