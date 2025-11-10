using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    [TerraformPropertyName("key_vault_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyVaultId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Version { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

    /// <summary>
    /// The certificate_count attribute.
    /// </summary>
    [TerraformPropertyName("certificate_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> CertificateCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "certificate_count");

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [TerraformPropertyName("expiration_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExpirationDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "expiration_date");

    /// <summary>
    /// The hex attribute.
    /// </summary>
    [TerraformPropertyName("hex")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Hex => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hex");

    /// <summary>
    /// The key attribute.
    /// </summary>
    [TerraformPropertyName("key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Key => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key");

    /// <summary>
    /// The not_before_date attribute.
    /// </summary>
    [TerraformPropertyName("not_before_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NotBeforeDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "not_before_date");

    /// <summary>
    /// The pem attribute.
    /// </summary>
    [TerraformPropertyName("pem")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Pem => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "pem");

}
