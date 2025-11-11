using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for custom_https_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorCustomHttpsConfigurationCustomHttpsConfigurationBlock
{
    /// <summary>
    /// The azure_key_vault_certificate_secret_name attribute.
    /// </summary>
    [TerraformPropertyName("azure_key_vault_certificate_secret_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AzureKeyVaultCertificateSecretName { get; set; }

    /// <summary>
    /// The azure_key_vault_certificate_secret_version attribute.
    /// </summary>
    [TerraformPropertyName("azure_key_vault_certificate_secret_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AzureKeyVaultCertificateSecretVersion { get; set; }

    /// <summary>
    /// The azure_key_vault_certificate_vault_id attribute.
    /// </summary>
    [TerraformPropertyName("azure_key_vault_certificate_vault_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AzureKeyVaultCertificateVaultId { get; set; }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    [TerraformPropertyName("certificate_source")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CertificateSource { get; set; }




}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFrontdoorCustomHttpsConfigurationTimeoutsBlock
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
/// Manages a azurerm_frontdoor_custom_https_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermFrontdoorCustomHttpsConfiguration : TerraformResource
{
    public AzurermFrontdoorCustomHttpsConfiguration(string name) : base("azurerm_frontdoor_custom_https_configuration", name)
    {
    }

    /// <summary>
    /// The custom_https_provisioning_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomHttpsProvisioningEnabled is required")]
    [TerraformPropertyName("custom_https_provisioning_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> CustomHttpsProvisioningEnabled { get; set; }

    /// <summary>
    /// The frontend_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendEndpointId is required")]
    [TerraformPropertyName("frontend_endpoint_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> FrontendEndpointId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Block for custom_https_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomHttpsConfiguration block(s) allowed")]
    [TerraformPropertyName("custom_https_configuration")]
    public TerraformList<TerraformBlock<AzurermFrontdoorCustomHttpsConfigurationCustomHttpsConfigurationBlock>>? CustomHttpsConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermFrontdoorCustomHttpsConfigurationTimeoutsBlock>? Timeouts { get; set; }

}
