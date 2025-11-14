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
/// Manages a azurerm_key_vault_certificate ephemeral resource (temporary credentials/tokens).
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public class AzurermKeyVaultCertificateEphemeralResource : TerraformEphemeralResource
{
    public AzurermKeyVaultCertificateEphemeralResource(string name) : base("azurerm_key_vault_certificate", name)
    {
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformArgument("key_vault_id")]
    public required TerraformValue<string> KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformArgument("version")]
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The certificate_count attribute.
    /// </summary>
    [TerraformArgument("certificate_count")]
    public TerraformValue<double> CertificateCount
    {
        get => new TerraformReference<double>(this, "certificate_count");
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [TerraformArgument("expiration_date")]
    public TerraformValue<string> ExpirationDate
    {
        get => new TerraformReference<string>(this, "expiration_date");
    }

    /// <summary>
    /// The hex attribute.
    /// </summary>
    [TerraformArgument("hex")]
    public TerraformValue<string> Hex
    {
        get => new TerraformReference<string>(this, "hex");
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [TerraformArgument("key")]
    public TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
    }

    /// <summary>
    /// The not_before_date attribute.
    /// </summary>
    [TerraformArgument("not_before_date")]
    public TerraformValue<string> NotBeforeDate
    {
        get => new TerraformReference<string>(this, "not_before_date");
    }

    /// <summary>
    /// The pem attribute.
    /// </summary>
    [TerraformArgument("pem")]
    public TerraformValue<string> Pem
    {
        get => new TerraformReference<string>(this, "pem");
    }

}
