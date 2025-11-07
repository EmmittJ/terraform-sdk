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
    public TerraformLiteralProperty<string>? ConnectionString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_string");
        set => this.WithProperty("connection_string", value);
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
    /// The role_instance attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RoleInstance
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_instance");
        set => this.WithProperty("role_instance", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RoleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_name");
        set => this.WithProperty("role_name", value);
    }

    /// <summary>
    /// The sampling_percentage attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? SamplingPercentage
    {
        get => GetProperty<TerraformLiteralProperty<double>>("sampling_percentage");
        set => this.WithProperty("sampling_percentage", value);
    }

    /// <summary>
    /// The sampling_requests_per_second attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? SamplingRequestsPerSecond
    {
        get => GetProperty<TerraformLiteralProperty<double>>("sampling_requests_per_second");
        set => this.WithProperty("sampling_requests_per_second", value);
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
