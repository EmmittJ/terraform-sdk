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
    public string? ApiToken
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_token")?.Value;
        set => this.WithProperty("api_token", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The api_url attribute.
    /// </summary>
    public string? ApiUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_url")?.Value;
        set => this.WithProperty("api_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The connection_point attribute.
    /// </summary>
    public string? ConnectionPoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_point")?.Value;
        set => this.WithProperty("connection_point", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    public string? EnvironmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("environment_id")?.Value;
        set => this.WithProperty("environment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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

    /// <summary>
    /// The tenant attribute.
    /// </summary>
    public string? Tenant
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenant")?.Value;
        set => this.WithProperty("tenant", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tenant_token attribute.
    /// </summary>
    public string? TenantToken
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenant_token")?.Value;
        set => this.WithProperty("tenant_token", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
