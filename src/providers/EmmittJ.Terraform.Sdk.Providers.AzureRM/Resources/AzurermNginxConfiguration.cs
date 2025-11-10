using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for config_file in .
/// Nesting mode: set
/// </summary>
public class AzurermNginxConfigurationConfigFileBlock : ITerraformBlock
{
    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    [TerraformPropertyName("content")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Content { get; set; }

    /// <summary>
    /// The virtual_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualPath is required")]
    [TerraformPropertyName("virtual_path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VirtualPath { get; set; }

}

/// <summary>
/// Block type for protected_file in .
/// Nesting mode: set
/// </summary>
public class AzurermNginxConfigurationProtectedFileBlock : ITerraformBlock
{
    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    [TerraformPropertyName("content")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Content { get; set; }

    /// <summary>
    /// The content_hash attribute.
    /// </summary>
    [TerraformPropertyName("content_hash")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContentHash => new TerraformReferenceProperty<TerraformProperty<string>>("", "content_hash");

    /// <summary>
    /// The virtual_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualPath is required")]
    [TerraformPropertyName("virtual_path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VirtualPath { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNginxConfigurationTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_nginx_configuration resource.
/// </summary>
public class AzurermNginxConfiguration : TerraformResource
{
    public AzurermNginxConfiguration(string name) : base("azurerm_nginx_configuration", name)
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
    /// The package_data attribute.
    /// </summary>
    [TerraformPropertyName("package_data")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PackageData { get; set; }

    /// <summary>
    /// The root_file attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFile is required")]
    [TerraformPropertyName("root_file")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RootFile { get; set; }

    /// <summary>
    /// Block for config_file.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("config_file")]
    public TerraformSet<TerraformBlock<AzurermNginxConfigurationConfigFileBlock>>? ConfigFile { get; set; } = new();

    /// <summary>
    /// Block for protected_file.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("protected_file")]
    public TerraformSet<TerraformBlock<AzurermNginxConfigurationProtectedFileBlock>>? ProtectedFile { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermNginxConfigurationTimeoutsBlock>? Timeouts { get; set; } = new();

}
