using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNginxCertificateDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_nginx_certificate.
/// </summary>
public class AzurermNginxCertificateDataSource : TerraformDataSource
{
    public AzurermNginxCertificateDataSource(string name) : base("azurerm_nginx_certificate", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The nginx_deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NginxDeploymentId is required")]
    [TerraformPropertyName("nginx_deployment_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> NginxDeploymentId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermNginxCertificateDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The certificate_virtual_path attribute.
    /// </summary>
    [TerraformPropertyName("certificate_virtual_path")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CertificateVirtualPath => new TerraformReference(this, "certificate_virtual_path");

    /// <summary>
    /// The error_code attribute.
    /// </summary>
    [TerraformPropertyName("error_code")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ErrorCode => new TerraformReference(this, "error_code");

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    [TerraformPropertyName("error_message")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ErrorMessage => new TerraformReference(this, "error_message");

    /// <summary>
    /// The key_vault_secret_creation_date attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_secret_creation_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KeyVaultSecretCreationDate => new TerraformReference(this, "key_vault_secret_creation_date");

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_secret_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KeyVaultSecretId => new TerraformReference(this, "key_vault_secret_id");

    /// <summary>
    /// The key_vault_secret_version attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_secret_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KeyVaultSecretVersion => new TerraformReference(this, "key_vault_secret_version");

    /// <summary>
    /// The key_virtual_path attribute.
    /// </summary>
    [TerraformPropertyName("key_virtual_path")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KeyVirtualPath => new TerraformReference(this, "key_virtual_path");

    /// <summary>
    /// The sha1_thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("sha1_thumbprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Sha1Thumbprint => new TerraformReference(this, "sha1_thumbprint");

}
