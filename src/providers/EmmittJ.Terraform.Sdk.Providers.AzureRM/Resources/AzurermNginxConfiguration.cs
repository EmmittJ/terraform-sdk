using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for config_file in .
/// Nesting mode: set
/// </summary>
public partial class AzurermNginxConfigurationConfigFileBlock : TerraformBlockBase
{
    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    [TerraformProperty("content")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Content { get; set; }

    /// <summary>
    /// The virtual_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualPath is required")]
    [TerraformProperty("virtual_path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VirtualPath { get; set; }

}

/// <summary>
/// Block type for protected_file in .
/// Nesting mode: set
/// </summary>
public partial class AzurermNginxConfigurationProtectedFileBlock : TerraformBlockBase
{
    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    [TerraformProperty("content")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Content { get; set; }


    /// <summary>
    /// The virtual_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualPath is required")]
    [TerraformProperty("virtual_path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VirtualPath { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNginxConfigurationTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_nginx_configuration resource.
/// </summary>
public partial class AzurermNginxConfiguration : TerraformResource
{
    public AzurermNginxConfiguration(string name) : base("azurerm_nginx_configuration", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The nginx_deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NginxDeploymentId is required")]
    [TerraformProperty("nginx_deployment_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NginxDeploymentId { get; set; }

    /// <summary>
    /// The package_data attribute.
    /// </summary>
    [TerraformProperty("package_data")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PackageData { get; set; }

    /// <summary>
    /// The root_file attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFile is required")]
    [TerraformProperty("root_file")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RootFile { get; set; }

    /// <summary>
    /// Block for config_file.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("config_file")]
    public partial TerraformSet<TerraformBlock<AzurermNginxConfigurationConfigFileBlock>>? ConfigFile { get; set; }

    /// <summary>
    /// Block for protected_file.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("protected_file")]
    public partial TerraformSet<TerraformBlock<AzurermNginxConfigurationProtectedFileBlock>>? ProtectedFile { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermNginxConfigurationTimeoutsBlock>? Timeouts { get; set; }

}
