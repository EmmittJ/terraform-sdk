using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultCertificateDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault_certificate.
/// </summary>
public class AzurermKeyVaultCertificateDataSource : TerraformDataSource
{
    public AzurermKeyVaultCertificateDataSource(string name) : base("azurerm_key_vault_certificate", name)
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
    public TerraformBlock<AzurermKeyVaultCertificateDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The certificate_data attribute.
    /// </summary>
    [TerraformPropertyName("certificate_data")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateData => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_data");

    /// <summary>
    /// The certificate_data_base64 attribute.
    /// </summary>
    [TerraformPropertyName("certificate_data_base64")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateDataBase64 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_data_base64");

    /// <summary>
    /// The certificate_policy attribute.
    /// </summary>
    [TerraformPropertyName("certificate_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CertificatePolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "certificate_policy");

    /// <summary>
    /// The expires attribute.
    /// </summary>
    [TerraformPropertyName("expires")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Expires => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "expires");

    /// <summary>
    /// The not_before attribute.
    /// </summary>
    [TerraformPropertyName("not_before")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NotBefore => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "not_before");

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_manager_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceManagerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_manager_id");

    /// <summary>
    /// The resource_manager_versionless_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_manager_versionless_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceManagerVersionlessId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_manager_versionless_id");

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [TerraformPropertyName("secret_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecretId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secret_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("thumbprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Thumbprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "thumbprint");

    /// <summary>
    /// The versionless_id attribute.
    /// </summary>
    [TerraformPropertyName("versionless_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VersionlessId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "versionless_id");

    /// <summary>
    /// The versionless_secret_id attribute.
    /// </summary>
    [TerraformPropertyName("versionless_secret_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VersionlessSecretId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "versionless_secret_id");

}
