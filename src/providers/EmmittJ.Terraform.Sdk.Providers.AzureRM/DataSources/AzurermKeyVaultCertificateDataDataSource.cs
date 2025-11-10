using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultCertificateDataDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault_certificate_data.
/// </summary>
public class AzurermKeyVaultCertificateDataDataSource : TerraformDataSource
{
    public AzurermKeyVaultCertificateDataDataSource(string name) : base("azurerm_key_vault_certificate_data", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKeyVaultCertificateDataDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The certificates_count attribute.
    /// </summary>
    [TerraformPropertyName("certificates_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> CertificatesCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "certificates_count");

    /// <summary>
    /// The expires attribute.
    /// </summary>
    [TerraformPropertyName("expires")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Expires => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "expires");

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
    /// The not_before attribute.
    /// </summary>
    [TerraformPropertyName("not_before")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NotBefore => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "not_before");

    /// <summary>
    /// The pem attribute.
    /// </summary>
    [TerraformPropertyName("pem")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Pem => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "pem");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

}
