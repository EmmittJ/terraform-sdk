using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_spring_cloud_elastic_application_performance_monitoring resource.
/// </summary>
public class AzurermSpringCloudElasticApplicationPerformanceMonitoring : TerraformResource
{
    public AzurermSpringCloudElasticApplicationPerformanceMonitoring(string name) : base("azurerm_spring_cloud_elastic_application_performance_monitoring", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The application_packages attribute.
    /// </summary>
    public List<string>? ApplicationPackages
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("application_packages")?.Value;
        set => this.WithProperty("application_packages", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The server_url attribute.
    /// </summary>
    public string? ServerUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_url")?.Value;
        set => this.WithProperty("server_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public string? ServiceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_name")?.Value;
        set => this.WithProperty("service_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
