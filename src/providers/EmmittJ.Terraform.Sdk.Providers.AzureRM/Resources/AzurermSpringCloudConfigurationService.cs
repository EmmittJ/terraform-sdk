using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for repository in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudConfigurationServiceRepositoryBlock
{
    /// <summary>
    /// The ca_certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("ca_certificate_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CaCertificateId { get; set; }

    /// <summary>
    /// The host_key attribute.
    /// </summary>
    [TerraformPropertyName("host_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HostKey { get; set; }

    /// <summary>
    /// The host_key_algorithm attribute.
    /// </summary>
    [TerraformPropertyName("host_key_algorithm")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HostKeyAlgorithm { get; set; }

    /// <summary>
    /// The label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Label is required")]
    [TerraformPropertyName("label")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Label { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// The patterns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Patterns is required")]
    [TerraformPropertyName("patterns")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Patterns { get; set; }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    [TerraformPropertyName("private_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrivateKey { get; set; }

    /// <summary>
    /// The search_paths attribute.
    /// </summary>
    [TerraformPropertyName("search_paths")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SearchPaths { get; set; }

    /// <summary>
    /// The strict_host_key_checking attribute.
    /// </summary>
    [TerraformPropertyName("strict_host_key_checking")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? StrictHostKeyChecking { get; set; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformPropertyName("uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Uri { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [TerraformPropertyName("username")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Username { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudConfigurationServiceTimeoutsBlock
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
/// Manages a azurerm_spring_cloud_configuration_service resource.
/// </summary>
public class AzurermSpringCloudConfigurationService : TerraformResource
{
    public AzurermSpringCloudConfigurationService(string name) : base("azurerm_spring_cloud_configuration_service", name)
    {
    }

    /// <summary>
    /// The generation attribute.
    /// </summary>
    [TerraformPropertyName("generation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Generation { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The refresh_interval_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("refresh_interval_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RefreshIntervalInSeconds { get; set; }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    [TerraformPropertyName("spring_cloud_service_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SpringCloudServiceId { get; set; }

    /// <summary>
    /// Block for repository.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("repository")]
    public TerraformList<TerraformBlock<AzurermSpringCloudConfigurationServiceRepositoryBlock>>? Repository { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSpringCloudConfigurationServiceTimeoutsBlock>? Timeouts { get; set; }

}
