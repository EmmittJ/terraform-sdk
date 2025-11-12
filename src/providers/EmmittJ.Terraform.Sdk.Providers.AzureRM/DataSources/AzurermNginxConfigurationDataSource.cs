using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNginxConfigurationDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_nginx_configuration.
/// </summary>
public partial class AzurermNginxConfigurationDataSource : TerraformDataSource
{
    public AzurermNginxConfigurationDataSource(string name) : base("azurerm_nginx_configuration", name)
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermNginxConfigurationDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The config_file attribute.
    /// </summary>
    [TerraformProperty("config_file")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> ConfigFile { get; }

    /// <summary>
    /// The package_data attribute.
    /// </summary>
    [TerraformProperty("package_data")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PackageData { get; }

    /// <summary>
    /// The protected_file attribute.
    /// </summary>
    [TerraformProperty("protected_file")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> ProtectedFile { get; }

    /// <summary>
    /// The root_file attribute.
    /// </summary>
    [TerraformProperty("root_file")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RootFile { get; }

}
