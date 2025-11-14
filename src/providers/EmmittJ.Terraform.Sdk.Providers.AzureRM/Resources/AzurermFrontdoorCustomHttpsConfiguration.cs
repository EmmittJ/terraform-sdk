using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for custom_https_configuration in .
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
    [TerraformArgument("azure_key_vault_certificate_secret_name")]
    public TerraformValue<string>? AzureKeyVaultCertificateSecretName
    {
        get => new TerraformReference<string>(this, "azure_key_vault_certificate_secret_name");
        set => SetArgument("azure_key_vault_certificate_secret_name", value);
    }

    /// <summary>
    /// The azure_key_vault_certificate_secret_version attribute.
    /// </summary>
    [TerraformArgument("azure_key_vault_certificate_secret_version")]
    public TerraformValue<string>? AzureKeyVaultCertificateSecretVersion
    {
        get => new TerraformReference<string>(this, "azure_key_vault_certificate_secret_version");
        set => SetArgument("azure_key_vault_certificate_secret_version", value);
    }

    /// <summary>
    /// The azure_key_vault_certificate_vault_id attribute.
    /// </summary>
    [TerraformArgument("azure_key_vault_certificate_vault_id")]
    public TerraformValue<string>? AzureKeyVaultCertificateVaultId
    {
        get => new TerraformReference<string>(this, "azure_key_vault_certificate_vault_id");
        set => SetArgument("azure_key_vault_certificate_vault_id", value);
    }

    /// <summary>
    /// The certificate_source attribute.
    /// </summary>
    [TerraformArgument("certificate_source")]
    public TerraformValue<string>? CertificateSource
    {
        get => new TerraformReference<string>(this, "certificate_source");
        set => SetArgument("certificate_source", value);
    }




}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The custom_https_provisioning_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomHttpsProvisioningEnabled is required")]
    [TerraformArgument("custom_https_provisioning_enabled")]
    public required TerraformValue<bool> CustomHttpsProvisioningEnabled
    {
        get => new TerraformReference<bool>(this, "custom_https_provisioning_enabled");
        set => SetArgument("custom_https_provisioning_enabled", value);
    }

    /// <summary>
    /// The frontend_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendEndpointId is required")]
    [TerraformArgument("frontend_endpoint_id")]
    public required TerraformValue<string> FrontendEndpointId
    {
        get => new TerraformReference<string>(this, "frontend_endpoint_id");
        set => SetArgument("frontend_endpoint_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Block for custom_https_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomHttpsConfiguration block(s) allowed")]
    [TerraformArgument("custom_https_configuration")]
    public TerraformList<AzurermFrontdoorCustomHttpsConfigurationCustomHttpsConfigurationBlock> CustomHttpsConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermFrontdoorCustomHttpsConfigurationTimeoutsBlock Timeouts { get; set; } = new();

}
