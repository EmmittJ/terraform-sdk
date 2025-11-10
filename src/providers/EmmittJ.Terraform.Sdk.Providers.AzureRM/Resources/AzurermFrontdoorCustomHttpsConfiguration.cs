using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for custom_https_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorCustomHttpsConfigurationCustomHttpsConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The azure_key_vault_certificate_secret_name attribute.
    /// </summary>
    [TerraformPropertyName("azure_key_vault_certificate_secret_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AzureKeyVaultCertificateSecretName { get; set; }

    /// <summary>
    /// The azure_key_vault_certificate_secret_version attribute.
    /// </summary>
    [TerraformPropertyName("azure_key_vault_certificate_secret_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AzureKeyVaultCertificateSecretVersion { get; set; }

    /// <summary>
    /// The azure_key_vault_certificate_vault_id attribute.
    /// </summary>
    [TerraformPropertyName("azure_key_vault_certificate_vault_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AzureKeyVaultCertificateVaultId { get; set; }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    [TerraformPropertyName("certificate_source")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CertificateSource { get; set; }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    [TerraformPropertyName("minimum_tls_version")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MinimumTlsVersion => new TerraformReferenceProperty<TerraformProperty<string>>("", "minimum_tls_version");

    /// <summary>
    /// The provisioning_state attribute.
    /// </summary>
    [TerraformPropertyName("provisioning_state")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProvisioningState => new TerraformReferenceProperty<TerraformProperty<string>>("", "provisioning_state");

    /// <summary>
    /// The provisioning_substate attribute.
    /// </summary>
    [TerraformPropertyName("provisioning_substate")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProvisioningSubstate => new TerraformReferenceProperty<TerraformProperty<string>>("", "provisioning_substate");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFrontdoorCustomHttpsConfigurationTimeoutsBlock : ITerraformBlock
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
    public required TerraformProperty<TerraformProperty<bool>> CustomHttpsProvisioningEnabled { get; set; }

    /// <summary>
    /// The frontend_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendEndpointId is required")]
    [TerraformPropertyName("frontend_endpoint_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FrontendEndpointId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Block for custom_https_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomHttpsConfiguration block(s) allowed")]
    [TerraformPropertyName("custom_https_configuration")]
    public TerraformList<TerraformBlock<AzurermFrontdoorCustomHttpsConfigurationCustomHttpsConfigurationBlock>>? CustomHttpsConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermFrontdoorCustomHttpsConfigurationTimeoutsBlock>? Timeouts { get; set; } = new();

}
