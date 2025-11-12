using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for custom_https_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFrontdoorCustomHttpsConfigurationCustomHttpsConfigurationBlock() : TerraformBlock("custom_https_configuration")
{
    /// <summary>
    /// The azure_key_vault_certificate_secret_name attribute.
    /// </summary>
    [TerraformProperty("azure_key_vault_certificate_secret_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AzureKeyVaultCertificateSecretName { get; set; }

    /// <summary>
    /// The azure_key_vault_certificate_secret_version attribute.
    /// </summary>
    [TerraformProperty("azure_key_vault_certificate_secret_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AzureKeyVaultCertificateSecretVersion { get; set; }

    /// <summary>
    /// The azure_key_vault_certificate_vault_id attribute.
    /// </summary>
    [TerraformProperty("azure_key_vault_certificate_vault_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AzureKeyVaultCertificateVaultId { get; set; }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    [TerraformProperty("certificate_source")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificateSource { get; set; }




}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermFrontdoorCustomHttpsConfigurationTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_frontdoor_custom_https_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermFrontdoorCustomHttpsConfiguration : TerraformResource
{
    public AzurermFrontdoorCustomHttpsConfiguration(string name) : base("azurerm_frontdoor_custom_https_configuration", name)
    {
    }

    /// <summary>
    /// The custom_https_provisioning_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomHttpsProvisioningEnabled is required")]
    [TerraformProperty("custom_https_provisioning_enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> CustomHttpsProvisioningEnabled { get; set; }

    /// <summary>
    /// The frontend_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendEndpointId is required")]
    [TerraformProperty("frontend_endpoint_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FrontendEndpointId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for custom_https_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomHttpsConfiguration block(s) allowed")]
    [TerraformProperty("custom_https_configuration")]
    public TerraformList<AzurermFrontdoorCustomHttpsConfigurationCustomHttpsConfigurationBlock> CustomHttpsConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermFrontdoorCustomHttpsConfigurationTimeoutsBlock Timeouts { get; set; } = new();

}
