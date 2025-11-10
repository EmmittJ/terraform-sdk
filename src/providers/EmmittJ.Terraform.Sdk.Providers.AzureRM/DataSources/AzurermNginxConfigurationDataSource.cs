using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNginxConfigurationDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_nginx_configuration.
/// </summary>
public class AzurermNginxConfigurationDataSource : TerraformDataSource
{
    public AzurermNginxConfigurationDataSource(string name) : base("azurerm_nginx_configuration", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The nginx_deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NginxDeploymentId is required")]
    [TerraformPropertyName("nginx_deployment_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NginxDeploymentId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermNginxConfigurationDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The config_file attribute.
    /// </summary>
    [TerraformPropertyName("config_file")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> ConfigFile => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "config_file");

    /// <summary>
    /// The package_data attribute.
    /// </summary>
    [TerraformPropertyName("package_data")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PackageData => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "package_data");

    /// <summary>
    /// The protected_file attribute.
    /// </summary>
    [TerraformPropertyName("protected_file")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> ProtectedFile => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "protected_file");

    /// <summary>
    /// The root_file attribute.
    /// </summary>
    [TerraformPropertyName("root_file")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RootFile => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "root_file");

}
