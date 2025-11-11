using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for cdn_managed_https in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCdnEndpointCustomDomainCdnManagedHttpsBlock : TerraformBlockBase
{
    /// <summary>
    /// The certificate_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateType is required")]
    [TerraformProperty("certificate_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CertificateType { get; set; }

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtocolType is required")]
    [TerraformProperty("protocol_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProtocolType { get; set; }

    /// <summary>
    /// The tls_version attribute.
    /// </summary>
    [TerraformProperty("tls_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TlsVersion { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCdnEndpointCustomDomainTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for user_managed_https in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCdnEndpointCustomDomainUserManagedHttpsBlock : TerraformBlockBase
{
    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultSecretId is required")]
    [TerraformProperty("key_vault_secret_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyVaultSecretId { get; set; }

    /// <summary>
    /// The tls_version attribute.
    /// </summary>
    [TerraformProperty("tls_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TlsVersion { get; set; }

}

/// <summary>
/// Manages a azurerm_cdn_endpoint_custom_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermCdnEndpointCustomDomain : TerraformResource
{
    public AzurermCdnEndpointCustomDomain(string name) : base("azurerm_cdn_endpoint_custom_domain", name)
    {
    }

    /// <summary>
    /// The cdn_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnEndpointId is required")]
    [TerraformProperty("cdn_endpoint_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CdnEndpointId { get; set; }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformProperty("host_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HostName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for cdn_managed_https.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CdnManagedHttps block(s) allowed")]
    [TerraformProperty("cdn_managed_https")]
    public partial TerraformList<TerraformBlock<AzurermCdnEndpointCustomDomainCdnManagedHttpsBlock>>? CdnManagedHttps { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermCdnEndpointCustomDomainTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for user_managed_https.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserManagedHttps block(s) allowed")]
    [TerraformProperty("user_managed_https")]
    public partial TerraformList<TerraformBlock<AzurermCdnEndpointCustomDomainUserManagedHttpsBlock>>? UserManagedHttps { get; set; }

}
