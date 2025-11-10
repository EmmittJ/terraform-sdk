using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for quota in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudContainerDeploymentQuotaBlock : TerraformBlock
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
public class AzurermSpringCloudContainerDeploymentTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_spring_cloud_container_deployment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSpringCloudContainerDeployment : TerraformResource
{
    public AzurermSpringCloudContainerDeployment(string name) : base("azurerm_spring_cloud_container_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("addon_json");
        SetOutput("application_performance_monitoring_ids");
        SetOutput("arguments");
        SetOutput("commands");
        SetOutput("environment_variables");
        SetOutput("id");
        SetOutput("image");
        SetOutput("instance_count");
        SetOutput("language_framework");
        SetOutput("name");
        SetOutput("server");
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
    /// The arguments attribute.
    /// </summary>
    public List<TerraformProperty<string>> Arguments
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("arguments");
        set => SetProperty("arguments", value);
    }

    /// <summary>
    /// The commands attribute.
    /// </summary>
    public List<TerraformProperty<string>> Commands
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("commands");
        set => SetProperty("commands", value);
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
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    public required TerraformProperty<string> Image
    {
        get => GetRequiredOutput<TerraformProperty<string>>("image");
        set => SetProperty("image", value);
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
    /// The language_framework attribute.
    /// </summary>
    public TerraformProperty<string> LanguageFramework
    {
        get => GetRequiredOutput<TerraformProperty<string>>("language_framework");
        set => SetProperty("language_framework", value);
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
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformProperty<string> Server
    {
        get => GetRequiredOutput<TerraformProperty<string>>("server");
        set => SetProperty("server", value);
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
    public List<AzurermSpringCloudContainerDeploymentQuotaBlock>? Quota
    {
        set => SetProperty("quota", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudContainerDeploymentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
