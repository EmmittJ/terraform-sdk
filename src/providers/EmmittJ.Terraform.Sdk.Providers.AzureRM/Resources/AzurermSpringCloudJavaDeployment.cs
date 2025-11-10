using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for quota in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudJavaDeploymentQuotaBlock : ITerraformBlock
{
    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [TerraformPropertyName("cpu")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Cpu { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "cpu");

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [TerraformPropertyName("memory")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Memory { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "memory");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudJavaDeploymentTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_spring_cloud_java_deployment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSpringCloudJavaDeployment : TerraformResource
{
    public AzurermSpringCloudJavaDeployment(string name) : base("azurerm_spring_cloud_java_deployment", name)
    {
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    [TerraformPropertyName("environment_variables")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [TerraformPropertyName("instance_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? InstanceCount { get; set; }

    /// <summary>
    /// The jvm_options attribute.
    /// </summary>
    [TerraformPropertyName("jvm_options")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? JvmOptions { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    [TerraformPropertyName("runtime_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RuntimeVersion { get; set; }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudAppId is required")]
    [TerraformPropertyName("spring_cloud_app_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SpringCloudAppId { get; set; }

    /// <summary>
    /// Block for quota.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Quota block(s) allowed")]
    [TerraformPropertyName("quota")]
    public TerraformList<TerraformBlock<AzurermSpringCloudJavaDeploymentQuotaBlock>>? Quota { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSpringCloudJavaDeploymentTimeoutsBlock>? Timeouts { get; set; } = new();

}
