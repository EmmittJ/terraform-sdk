using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_spring_cloud_gateway resource.
/// </summary>
public class AzurermSpringCloudGateway : TerraformResource
{
    public AzurermSpringCloudGateway(string name) : base("azurerm_spring_cloud_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("url");
    }

    /// <summary>
    /// The application_performance_monitoring_ids attribute.
    /// </summary>
    public List<string>? ApplicationPerformanceMonitoringIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("application_performance_monitoring_ids")?.Value;
        set => this.WithProperty("application_performance_monitoring_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The application_performance_monitoring_types attribute.
    /// </summary>
    public List<string>? ApplicationPerformanceMonitoringTypes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("application_performance_monitoring_types")?.Value;
        set => this.WithProperty("application_performance_monitoring_types", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public Dictionary<string, string>? EnvironmentVariables
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("environment_variables")?.Value;
        set => this.WithProperty("environment_variables", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public bool? HttpsOnly
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("https_only")?.Value;
        set => this.WithProperty("https_only", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The instance_count attribute.
    /// </summary>
    public double? InstanceCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("instance_count")?.Value;
        set => this.WithProperty("instance_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    public bool? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled")?.Value;
        set => this.WithProperty("public_network_access_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The sensitive_environment_variables attribute.
    /// </summary>
    public Dictionary<string, string>? SensitiveEnvironmentVariables
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("sensitive_environment_variables")?.Value;
        set => this.WithProperty("sensitive_environment_variables", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
