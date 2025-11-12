using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for quota in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSpringCloudJavaDeploymentQuotaBlock() : TerraformBlock("quota")
{
    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [TerraformProperty("cpu")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Cpu { get; set; }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [TerraformProperty("memory")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Memory { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSpringCloudJavaDeploymentTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_spring_cloud_java_deployment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermSpringCloudJavaDeployment : TerraformResource
{
    public AzurermSpringCloudJavaDeployment(string name) : base("azurerm_spring_cloud_java_deployment", name)
    {
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    [TerraformProperty("environment_variables")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [TerraformProperty("instance_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? InstanceCount { get; set; }

    /// <summary>
    /// The jvm_options attribute.
    /// </summary>
    [TerraformProperty("jvm_options")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? JvmOptions { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    [TerraformProperty("runtime_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RuntimeVersion { get; set; }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudAppId is required")]
    [TerraformProperty("spring_cloud_app_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SpringCloudAppId { get; set; }

    /// <summary>
    /// Block for quota.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Quota block(s) allowed")]
    [TerraformProperty("quota")]
    public TerraformList<AzurermSpringCloudJavaDeploymentQuotaBlock> Quota { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermSpringCloudJavaDeploymentTimeoutsBlock Timeouts { get; set; } = new();

}
