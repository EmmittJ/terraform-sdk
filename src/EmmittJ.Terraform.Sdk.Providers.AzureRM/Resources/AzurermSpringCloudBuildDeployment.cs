using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_spring_cloud_build_deployment resource.
/// </summary>
public class AzurermSpringCloudBuildDeployment : TerraformResource
{
    public AzurermSpringCloudBuildDeployment(string name) : base("azurerm_spring_cloud_build_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The addon_json attribute.
    /// </summary>
    public TerraformProperty<string>? AddonJson
    {
        get => GetProperty<TerraformProperty<string>>("addon_json");
        set => this.WithProperty("addon_json", value);
    }

    /// <summary>
    /// The application_performance_monitoring_ids attribute.
    /// </summary>
    public TerraformProperty<List<string>>? ApplicationPerformanceMonitoringIds
    {
        get => GetProperty<TerraformProperty<List<string>>>("application_performance_monitoring_ids");
        set => this.WithProperty("application_performance_monitoring_ids", value);
    }

    /// <summary>
    /// The build_result_id attribute.
    /// </summary>
    public TerraformProperty<string>? BuildResultId
    {
        get => GetProperty<TerraformProperty<string>>("build_result_id");
        set => this.WithProperty("build_result_id", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public TerraformMapProperty<string>? EnvironmentVariables
    {
        get => GetProperty<TerraformMapProperty<string>>("environment_variables");
        set => this.WithProperty("environment_variables", value);
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
    /// The instance_count attribute.
    /// </summary>
    public TerraformProperty<double>? InstanceCount
    {
        get => GetProperty<TerraformProperty<double>>("instance_count");
        set => this.WithProperty("instance_count", value);
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
    /// The spring_cloud_app_id attribute.
    /// </summary>
    public TerraformProperty<string>? SpringCloudAppId
    {
        get => GetProperty<TerraformProperty<string>>("spring_cloud_app_id");
        set => this.WithProperty("spring_cloud_app_id", value);
    }

}
