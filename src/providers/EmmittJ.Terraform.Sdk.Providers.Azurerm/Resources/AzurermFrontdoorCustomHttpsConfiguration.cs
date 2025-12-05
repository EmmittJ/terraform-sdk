using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for custom_https_configuration in AzurermFrontdoorCustomHttpsConfiguration.
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorCustomHttpsConfigurationCustomHttpsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_https_configuration";

    /// <summary>
    /// The azure_key_vault_certificate_secret_name attribute.
    /// </summary>
    public TerraformValue<string>? AzureKeyVaultCertificateSecretName
    {
        get => GetArgument<TerraformValue<string>>("azure_key_vault_certificate_secret_name");
        set => SetArgument("azure_key_vault_certificate_secret_name", value);
    }

    /// <summary>
    /// The azure_key_vault_certificate_secret_version attribute.
    /// </summary>
    public TerraformValue<string>? AzureKeyVaultCertificateSecretVersion
    {
        get => GetArgument<TerraformValue<string>>("azure_key_vault_certificate_secret_version");
        set => SetArgument("azure_key_vault_certificate_secret_version", value);
    }

    /// <summary>
    /// The azure_key_vault_certificate_vault_id attribute.
    /// </summary>
    public TerraformValue<string>? AzureKeyVaultCertificateVaultId
    {
        get => GetArgument<TerraformValue<string>>("azure_key_vault_certificate_vault_id");
        set => SetArgument("azure_key_vault_certificate_vault_id", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    public TerraformValue<string>? CertificateSource
    {
        get => GetArgument<TerraformValue<string>>("certificate_source");
        set => SetArgument("certificate_source", value);
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformValue<string> MinimumTlsVersion
        => CreateReference("minimum_tls_version");

    /// <summary>
    /// The provisioning_state attribute.
    /// </summary>
    public TerraformValue<string> ProvisioningState
        => CreateReference("provisioning_state");

    /// <summary>
    /// The provisioning_substate attribute.
    /// </summary>
    public TerraformValue<string> ProvisioningSubstate
        => CreateReference("provisioning_substate");

}


/// <summary>
/// Block type for timeouts in AzurermFrontdoorCustomHttpsConfiguration.
/// Nesting mode: single
/// </summary>
public class AzurermFrontdoorCustomHttpsConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_frontdoor_custom_https_configuration Terraform resource.
/// Manages a azurerm_frontdoor_custom_https_configuration resource.
/// </summary>
public partial class AzurermFrontdoorCustomHttpsConfiguration(string name) : TerraformResource("azurerm_frontdoor_custom_https_configuration", name)
{
    /// <summary>
    /// The custom_https_provisioning_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomHttpsProvisioningEnabled is required")]
    public required TerraformValue<bool> CustomHttpsProvisioningEnabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("custom_https_provisioning_enabled");
        set => SetArgument("custom_https_provisioning_enabled", value);
    }

    /// <summary>
    /// The frontend_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendEndpointId is required")]
    public required TerraformValue<string> FrontendEndpointId
    {
        get => GetRequiredArgument<TerraformValue<string>>("frontend_endpoint_id");
        set => SetArgument("frontend_endpoint_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// CustomHttpsConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomHttpsConfiguration block(s) allowed")]
    public TerraformList<AzurermFrontdoorCustomHttpsConfigurationCustomHttpsConfigurationBlock>? CustomHttpsConfiguration
    {
        get => GetArgument<TerraformList<AzurermFrontdoorCustomHttpsConfigurationCustomHttpsConfigurationBlock>>("custom_https_configuration");
        set => SetArgument("custom_https_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermFrontdoorCustomHttpsConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermFrontdoorCustomHttpsConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
