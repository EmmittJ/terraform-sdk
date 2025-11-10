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
        get => GetProperty<TerraformProperty<string>>("azure_key_vault_certificate_secret_name");
        set => WithProperty("azure_key_vault_certificate_secret_name", value);
    }

    /// <summary>
    /// The azure_key_vault_certificate_secret_version attribute.
    /// </summary>
    public TerraformProperty<string>? AzureKeyVaultCertificateSecretVersion
    {
        get => GetProperty<TerraformProperty<string>>("azure_key_vault_certificate_secret_version");
        set => WithProperty("azure_key_vault_certificate_secret_version", value);
    }

    /// <summary>
    /// The azure_key_vault_certificate_vault_id attribute.
    /// </summary>
    public TerraformProperty<string>? AzureKeyVaultCertificateVaultId
    {
        get => GetProperty<TerraformProperty<string>>("azure_key_vault_certificate_vault_id");
        set => WithProperty("azure_key_vault_certificate_vault_id", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateSource
    {
        get => GetProperty<TerraformProperty<string>>("certificate_source");
        set => WithProperty("certificate_source", value);
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformProperty<string>? MinimumTlsVersion
    {
        get => GetProperty<TerraformProperty<string>>("minimum_tls_version");
        set => WithProperty("minimum_tls_version", value);
    }

    /// <summary>
    /// The provisioning_state attribute.
    /// </summary>
    public TerraformProperty<string>? ProvisioningState
    {
        get => GetProperty<TerraformProperty<string>>("provisioning_state");
        set => WithProperty("provisioning_state", value);
    }

    /// <summary>
    /// The provisioning_substate attribute.
    /// </summary>
    public TerraformProperty<string>? ProvisioningSubstate
    {
        get => GetProperty<TerraformProperty<string>>("provisioning_substate");
        set => WithProperty("provisioning_substate", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_frontdoor_custom_https_configuration resource.
/// </summary>
public class AzurermFrontdoorCustomHttpsConfiguration : TerraformResource
{
    public AzurermFrontdoorCustomHttpsConfiguration(string name) : base("azurerm_frontdoor_custom_https_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The custom_https_provisioning_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomHttpsProvisioningEnabled is required")]
    public required TerraformProperty<bool> CustomHttpsProvisioningEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("custom_https_provisioning_enabled");
        set => this.WithProperty("custom_https_provisioning_enabled", value);
    }

    /// <summary>
    /// The frontend_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendEndpointId is required")]
    public required TerraformProperty<string> FrontendEndpointId
    {
        get => GetProperty<TerraformProperty<string>>("frontend_endpoint_id");
        set => this.WithProperty("frontend_endpoint_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Block for custom_https_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomHttpsConfiguration block(s) allowed")]
    public List<AzurermFrontdoorCustomHttpsConfigurationCustomHttpsConfigurationBlock>? CustomHttpsConfiguration
    {
        get => GetProperty<List<AzurermFrontdoorCustomHttpsConfigurationCustomHttpsConfigurationBlock>>("custom_https_configuration");
        set => this.WithProperty("custom_https_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermFrontdoorCustomHttpsConfigurationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermFrontdoorCustomHttpsConfigurationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
