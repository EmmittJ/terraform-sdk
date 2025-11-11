using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for quota in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudContainerDeploymentQuotaBlock
{
    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [TerraformPropertyName("cpu")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Cpu { get; set; } = default!;

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [TerraformPropertyName("memory")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Memory { get; set; } = default!;

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudContainerDeploymentTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_spring_cloud_container_deployment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSpringCloudContainerDeployment : TerraformResource
{
    public AzurermSpringCloudContainerDeployment(string name) : base("azurerm_spring_cloud_container_deployment", name)
    {
    }

    /// <summary>
    /// The addon_json attribute.
    /// </summary>
    [TerraformPropertyName("addon_json")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AddonJson { get; set; } = default!;

    /// <summary>
    /// The application_performance_monitoring_ids attribute.
    /// </summary>
    [TerraformPropertyName("application_performance_monitoring_ids")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ApplicationPerformanceMonitoringIds { get; set; }

    /// <summary>
    /// The arguments attribute.
    /// </summary>
    [TerraformPropertyName("arguments")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Arguments { get; set; }

    /// <summary>
    /// The commands attribute.
    /// </summary>
    [TerraformPropertyName("commands")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Commands { get; set; }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    [TerraformPropertyName("environment_variables")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    [TerraformPropertyName("image")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Image { get; set; }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [TerraformPropertyName("instance_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? InstanceCount { get; set; }

    /// <summary>
    /// The language_framework attribute.
    /// </summary>
    [TerraformPropertyName("language_framework")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LanguageFramework { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    [TerraformPropertyName("server")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Server { get; set; }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudAppId is required")]
    [TerraformPropertyName("spring_cloud_app_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SpringCloudAppId { get; set; }

    /// <summary>
    /// Block for quota.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Quota block(s) allowed")]
    [TerraformPropertyName("quota")]
    public TerraformList<TerraformBlock<AzurermSpringCloudContainerDeploymentQuotaBlock>>? Quota { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSpringCloudContainerDeploymentTimeoutsBlock>? Timeouts { get; set; }

}
