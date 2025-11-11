using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKeyVaultCertificateDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault_certificate.
/// </summary>
public partial class AzurermKeyVaultCertificateDataSource : TerraformDataSource
{
    public AzurermKeyVaultCertificateDataSource(string name) : base("azurerm_key_vault_certificate", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformProperty("key_vault_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KeyVaultId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Version { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermKeyVaultCertificateDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The certificate_data attribute.
    /// </summary>
    [TerraformProperty("certificate_data")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CertificateData { get; }

    /// <summary>
    /// The certificate_data_base64 attribute.
    /// </summary>
    [TerraformProperty("certificate_data_base64")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CertificateDataBase64 { get; }

    /// <summary>
    /// The certificate_policy attribute.
    /// </summary>
    [TerraformProperty("certificate_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> CertificatePolicy { get; }

    /// <summary>
    /// The expires attribute.
    /// </summary>
    [TerraformProperty("expires")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Expires { get; }

    /// <summary>
    /// The not_before attribute.
    /// </summary>
    [TerraformProperty("not_before")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NotBefore { get; }

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    [TerraformProperty("resource_manager_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceManagerId { get; }

    /// <summary>
    /// The resource_manager_versionless_id attribute.
    /// </summary>
    [TerraformProperty("resource_manager_versionless_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceManagerVersionlessId { get; }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [TerraformProperty("secret_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecretId { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [TerraformProperty("thumbprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Thumbprint { get; }

    /// <summary>
    /// The versionless_id attribute.
    /// </summary>
    [TerraformProperty("versionless_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VersionlessId { get; }

    /// <summary>
    /// The versionless_secret_id attribute.
    /// </summary>
    [TerraformProperty("versionless_secret_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VersionlessSecretId { get; }

}
