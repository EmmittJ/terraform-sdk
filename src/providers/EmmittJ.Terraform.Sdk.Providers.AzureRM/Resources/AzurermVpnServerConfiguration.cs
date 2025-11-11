using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_active_directory_authentication in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVpnServerConfigurationAzureActiveDirectoryAuthenticationBlock : TerraformBlockBase
{
    /// <summary>
    /// The audience attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Audience is required")]
    [TerraformProperty("audience")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Audience { get; set; }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    [TerraformProperty("issuer")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Issuer { get; set; }

    /// <summary>
    /// The tenant attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tenant is required")]
    [TerraformProperty("tenant")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Tenant { get; set; }

}

/// <summary>
/// Block type for client_revoked_certificate in .
/// Nesting mode: set
/// </summary>
public partial class AzurermVpnServerConfigurationClientRevokedCertificateBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Thumbprint is required")]
    [TerraformProperty("thumbprint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Thumbprint { get; set; }

}

/// <summary>
/// Block type for client_root_certificate in .
/// Nesting mode: set
/// </summary>
public partial class AzurermVpnServerConfigurationClientRootCertificateBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_cert_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicCertData is required")]
    [TerraformProperty("public_cert_data")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PublicCertData { get; set; }

}

/// <summary>
/// Block type for ipsec_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVpnServerConfigurationIpsecPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The dh_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DhGroup is required")]
    [TerraformProperty("dh_group")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DhGroup { get; set; }

    /// <summary>
    /// The ike_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeEncryption is required")]
    [TerraformProperty("ike_encryption")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IkeEncryption { get; set; }

    /// <summary>
    /// The ike_integrity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeIntegrity is required")]
    [TerraformProperty("ike_integrity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IkeIntegrity { get; set; }

    /// <summary>
    /// The ipsec_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpsecEncryption is required")]
    [TerraformProperty("ipsec_encryption")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IpsecEncryption { get; set; }

    /// <summary>
    /// The ipsec_integrity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpsecIntegrity is required")]
    [TerraformProperty("ipsec_integrity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IpsecIntegrity { get; set; }

    /// <summary>
    /// The pfs_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfsGroup is required")]
    [TerraformProperty("pfs_group")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PfsGroup { get; set; }

    /// <summary>
    /// The sa_data_size_kilobytes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SaDataSizeKilobytes is required")]
    [TerraformProperty("sa_data_size_kilobytes")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> SaDataSizeKilobytes { get; set; }

    /// <summary>
    /// The sa_lifetime_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SaLifetimeSeconds is required")]
    [TerraformProperty("sa_lifetime_seconds")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> SaLifetimeSeconds { get; set; }

}

/// <summary>
/// Block type for radius in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVpnServerConfigurationRadiusBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVpnServerConfigurationTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_vpn_server_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermVpnServerConfiguration : TerraformResource
{
    public AzurermVpnServerConfiguration(string name) : base("azurerm_vpn_server_configuration", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The vpn_authentication_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnAuthenticationTypes is required")]
    [TerraformProperty("vpn_authentication_types")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? VpnAuthenticationTypes { get; set; }

    /// <summary>
    /// The vpn_protocols attribute.
    /// </summary>
    [TerraformProperty("vpn_protocols")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> VpnProtocols { get; set; }

    /// <summary>
    /// Block for azure_active_directory_authentication.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("azure_active_directory_authentication")]
    public partial TerraformList<TerraformBlock<AzurermVpnServerConfigurationAzureActiveDirectoryAuthenticationBlock>>? AzureActiveDirectoryAuthentication { get; set; }

    /// <summary>
    /// Block for client_revoked_certificate.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("client_revoked_certificate")]
    public partial TerraformSet<TerraformBlock<AzurermVpnServerConfigurationClientRevokedCertificateBlock>>? ClientRevokedCertificate { get; set; }

    /// <summary>
    /// Block for client_root_certificate.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("client_root_certificate")]
    public partial TerraformSet<TerraformBlock<AzurermVpnServerConfigurationClientRootCertificateBlock>>? ClientRootCertificate { get; set; }

    /// <summary>
    /// Block for ipsec_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpsecPolicy block(s) allowed")]
    [TerraformProperty("ipsec_policy")]
    public partial TerraformList<TerraformBlock<AzurermVpnServerConfigurationIpsecPolicyBlock>>? IpsecPolicy { get; set; }

    /// <summary>
    /// Block for radius.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Radius block(s) allowed")]
    [TerraformProperty("radius")]
    public partial TerraformList<TerraformBlock<AzurermVpnServerConfigurationRadiusBlock>>? Radius { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermVpnServerConfigurationTimeoutsBlock>? Timeouts { get; set; }

}
