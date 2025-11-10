using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for quota in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudBuildDeploymentQuotaBlock : TerraformBlock
{
    /// <summary>
    /// The cpu attribute.
    /// </summary>
    public TerraformProperty<string>? Cpu
    {
        get => GetProperty<TerraformProperty<string>>("cpu");
        set => WithProperty("cpu", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformProperty<string>? Memory
    {
        get => GetProperty<TerraformProperty<string>>("memory");
        set => WithProperty("memory", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudBuildDeploymentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    public List<TerraformProperty<string>>? ApplicationPerformanceMonitoringIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("application_performance_monitoring_ids");
        set => this.WithProperty("application_performance_monitoring_ids", value);
    }

    /// <summary>
    /// The build_result_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BuildResultId is required")]
    public required TerraformProperty<string> BuildResultId
    {
        get => GetProperty<TerraformProperty<string>>("build_result_id");
        set => this.WithProperty("build_result_id", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EnvironmentVariables
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("environment_variables");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudAppId is required")]
    public required TerraformProperty<string> SpringCloudAppId
    {
        get => GetProperty<TerraformProperty<string>>("spring_cloud_app_id");
        set => this.WithProperty("spring_cloud_app_id", value);
    }

    /// <summary>
    /// Block for quota.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Quota block(s) allowed")]
    public List<AzurermSpringCloudBuildDeploymentQuotaBlock>? Quota
    {
        get => GetProperty<List<AzurermSpringCloudBuildDeploymentQuotaBlock>>("quota");
        set => this.WithProperty("quota", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudBuildDeploymentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSpringCloudBuildDeploymentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
