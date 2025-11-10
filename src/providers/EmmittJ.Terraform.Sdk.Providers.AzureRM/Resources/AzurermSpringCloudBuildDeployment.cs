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
        set => SetProperty("cpu", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformProperty<string>? Memory
    {
        set => SetProperty("memory", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_spring_cloud_build_deployment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSpringCloudBuildDeployment : TerraformResource
{
    public AzurermSpringCloudBuildDeployment(string name) : base("azurerm_spring_cloud_build_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("addon_json");
        SetOutput("application_performance_monitoring_ids");
        SetOutput("build_result_id");
        SetOutput("environment_variables");
        SetOutput("id");
        SetOutput("instance_count");
        SetOutput("name");
        SetOutput("spring_cloud_app_id");
    }

    /// <summary>
    /// The addon_json attribute.
    /// </summary>
    public TerraformProperty<string> AddonJson
    {
        get => GetRequiredOutput<TerraformProperty<string>>("addon_json");
        set => SetProperty("addon_json", value);
    }

    /// <summary>
    /// The application_performance_monitoring_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>> ApplicationPerformanceMonitoringIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("application_performance_monitoring_ids");
        set => SetProperty("application_performance_monitoring_ids", value);
    }

    /// <summary>
    /// The build_result_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BuildResultId is required")]
    public required TerraformProperty<string> BuildResultId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("build_result_id");
        set => SetProperty("build_result_id", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> EnvironmentVariables
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("environment_variables");
        set => SetProperty("environment_variables", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    public TerraformProperty<double> InstanceCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("instance_count");
        set => SetProperty("instance_count", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudAppId is required")]
    public required TerraformProperty<string> SpringCloudAppId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("spring_cloud_app_id");
        set => SetProperty("spring_cloud_app_id", value);
    }

    /// <summary>
    /// Block for quota.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Quota block(s) allowed")]
    public List<AzurermSpringCloudBuildDeploymentQuotaBlock>? Quota
    {
        set => SetProperty("quota", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudBuildDeploymentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
