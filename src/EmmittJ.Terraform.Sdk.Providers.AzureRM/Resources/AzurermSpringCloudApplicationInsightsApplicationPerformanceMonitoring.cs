using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_spring_cloud_application_insights_application_performance_monitoring resource.
/// </summary>
public class AzurermSpringCloudApplicationInsightsApplicationPerformanceMonitoring : TerraformResource
{
    public AzurermSpringCloudApplicationInsightsApplicationPerformanceMonitoring(string name) : base("azurerm_spring_cloud_application_insights_application_performance_monitoring", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public string? ConnectionString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_string")?.Value;
        set => this.WithProperty("connection_string", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The role_instance attribute.
    /// </summary>
    public string? RoleInstance
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_instance")?.Value;
        set => this.WithProperty("role_instance", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public string? RoleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_name")?.Value;
        set => this.WithProperty("role_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sampling_percentage attribute.
    /// </summary>
    public double? SamplingPercentage
    {
        get => GetProperty<TerraformLiteralProperty<double>>("sampling_percentage")?.Value;
        set => this.WithProperty("sampling_percentage", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The sampling_requests_per_second attribute.
    /// </summary>
    public double? SamplingRequestsPerSecond
    {
        get => GetProperty<TerraformLiteralProperty<double>>("sampling_requests_per_second")?.Value;
        set => this.WithProperty("sampling_requests_per_second", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
