using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNginxCertificateDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_nginx_certificate.
/// </summary>
public partial class AzurermNginxCertificateDataSource : TerraformDataSource
{
    public AzurermNginxCertificateDataSource(string name) : base("azurerm_nginx_certificate", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The nginx_deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NginxDeploymentId is required")]
    [TerraformProperty("nginx_deployment_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NginxDeploymentId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermNginxCertificateDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The certificate_virtual_path attribute.
    /// </summary>
    [TerraformProperty("certificate_virtual_path")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CertificateVirtualPath { get; }

    /// <summary>
    /// The error_code attribute.
    /// </summary>
    [TerraformProperty("error_code")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ErrorCode { get; }

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    [TerraformProperty("error_message")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ErrorMessage { get; }

    /// <summary>
    /// The key_vault_secret_creation_date attribute.
    /// </summary>
    [TerraformProperty("key_vault_secret_creation_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KeyVaultSecretCreationDate { get; }

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_secret_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KeyVaultSecretId { get; }

    /// <summary>
    /// The key_vault_secret_version attribute.
    /// </summary>
    [TerraformProperty("key_vault_secret_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KeyVaultSecretVersion { get; }

    /// <summary>
    /// The key_virtual_path attribute.
    /// </summary>
    [TerraformProperty("key_virtual_path")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KeyVirtualPath { get; }

    /// <summary>
    /// The sha1_thumbprint attribute.
    /// </summary>
    [TerraformProperty("sha1_thumbprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Sha1Thumbprint { get; }

}
