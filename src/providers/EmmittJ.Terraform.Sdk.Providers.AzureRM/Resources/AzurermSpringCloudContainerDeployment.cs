using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for quota in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSpringCloudContainerDeploymentQuotaBlock : TerraformBlockBase
{
    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [TerraformProperty("cpu")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Cpu { get; set; }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [TerraformProperty("memory")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Memory { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSpringCloudContainerDeploymentTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_spring_cloud_container_deployment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermSpringCloudContainerDeployment : TerraformResource
{
    public AzurermSpringCloudContainerDeployment(string name) : base("azurerm_spring_cloud_container_deployment", name)
    {
    }

    /// <summary>
    /// The addon_json attribute.
    /// </summary>
    [TerraformProperty("addon_json")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AddonJson { get; set; }

    /// <summary>
    /// The application_performance_monitoring_ids attribute.
    /// </summary>
    [TerraformProperty("application_performance_monitoring_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ApplicationPerformanceMonitoringIds { get; set; }

    /// <summary>
    /// The arguments attribute.
    /// </summary>
    [TerraformProperty("arguments")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Arguments { get; set; }

    /// <summary>
    /// The commands attribute.
    /// </summary>
    [TerraformProperty("commands")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Commands { get; set; }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    [TerraformProperty("environment_variables")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    [TerraformProperty("image")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Image { get; set; }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [TerraformProperty("instance_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? InstanceCount { get; set; }

    /// <summary>
    /// The language_framework attribute.
    /// </summary>
    [TerraformProperty("language_framework")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LanguageFramework { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    [TerraformProperty("server")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Server { get; set; }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudAppId is required")]
    [TerraformProperty("spring_cloud_app_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SpringCloudAppId { get; set; }

    /// <summary>
    /// Block for quota.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Quota block(s) allowed")]
    [TerraformProperty("quota")]
    public TerraformList<TerraformBlock<AzurermSpringCloudContainerDeploymentQuotaBlock>>? Quota { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermSpringCloudContainerDeploymentTimeoutsBlock>? Timeouts { get; set; }

}
