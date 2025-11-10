using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for custom_https_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorCustomHttpsConfigurationCustomHttpsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The azure_key_vault_certificate_secret_name attribute.
    /// </summary>
    public TerraformProperty<string>? AzureKeyVaultCertificateSecretName
    {
        set => SetProperty("azure_key_vault_certificate_secret_name", value);
    }

    /// <summary>
    /// The azure_key_vault_certificate_secret_version attribute.
    /// </summary>
    public TerraformProperty<string>? AzureKeyVaultCertificateSecretVersion
    {
        set => SetProperty("azure_key_vault_certificate_secret_version", value);
    }

    /// <summary>
    /// The azure_key_vault_certificate_vault_id attribute.
    /// </summary>
    public TerraformProperty<string>? AzureKeyVaultCertificateVaultId
    {
        set => SetProperty("azure_key_vault_certificate_vault_id", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateSource
    {
        set => SetProperty("certificate_source", value);
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformProperty<string>? MinimumTlsVersion
    {
        set => SetProperty("minimum_tls_version", value);
    }

    /// <summary>
    /// The provisioning_state attribute.
    /// </summary>
    public TerraformProperty<string>? ProvisioningState
    {
        set => SetProperty("provisioning_state", value);
    }

    /// <summary>
    /// The provisioning_substate attribute.
    /// </summary>
    public TerraformProperty<string>? ProvisioningSubstate
    {
        set => SetProperty("provisioning_substate", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFrontdoorCustomHttpsConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_frontdoor_custom_https_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermFrontdoorCustomHttpsConfiguration : TerraformResource
{
    public AzurermFrontdoorCustomHttpsConfiguration(string name) : base("azurerm_frontdoor_custom_https_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("custom_https_provisioning_enabled");
        SetOutput("frontend_endpoint_id");
        SetOutput("id");
    }

    /// <summary>
    /// The custom_https_provisioning_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomHttpsProvisioningEnabled is required")]
    public required TerraformProperty<bool> CustomHttpsProvisioningEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("custom_https_provisioning_enabled");
        set => SetProperty("custom_https_provisioning_enabled", value);
    }

    /// <summary>
    /// The frontend_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendEndpointId is required")]
    public required TerraformProperty<string> FrontendEndpointId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("frontend_endpoint_id");
        set => SetProperty("frontend_endpoint_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Block for custom_https_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomHttpsConfiguration block(s) allowed")]
    public List<AzurermFrontdoorCustomHttpsConfigurationCustomHttpsConfigurationBlock>? CustomHttpsConfiguration
    {
        set => SetProperty("custom_https_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermFrontdoorCustomHttpsConfigurationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
